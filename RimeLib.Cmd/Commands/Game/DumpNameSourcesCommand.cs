using System;
using System.Collections.Generic;
using System.Buffers.Binary;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.IO;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes every NAME the mounted game itself contains, so a reverse table for fb::hashQuick /
    /// fb::hashQuickLowerCase can be built by HASHING THE GAME'S OWN STRINGS rather than guessing.
    /// Public hash lists are speculative; a name that BF3 ships is correct by construction.
    ///
    /// A full mount is expensive enough that this has to answer every source in ONE pass, so it
    /// writes one file per source and a summary.json with the counts, and it never merges them --
    /// which source a name came from is what makes the resulting table auditable.
    ///
    /// The EBX pass deliberately does NOT use the partition converter. Reading a partition's
    /// instances needs a generated fb:: class for every type it holds and throws when one is
    /// missing, which would silently skip whole directories of the game. The header, the type
    /// string table and the string table are FIXED-LAYOUT and version-stable, so they are parsed
    /// here directly from the bytes: that reads 100% of partitions instead of the subset Rime has
    /// classes for. Layout is StreamingPartitionHeader (80 bytes) + ImportCount*32 imports +
    /// TypeStringTableSize bytes of type/field names, with the value string table living at
    /// [MetaSize, MetaSize+StringTableSize) -- the same offsets EbxReader.GetStringAtOffset uses.
    ///
    /// It also collects GROUND TRUTH: places where BF3 states a hash and its name in its own data.
    ///  * every EBX type/field descriptor stores fb::hashQuick(name) next to the type string table
    ///    that holds the name (millions of statements, and the reader would not work if they did
    ///    not agree);
    ///  * fb::ObjectVariation carries Asset.Name AND NameHash on the same instance;
    ///  * fb::MeshVariationDatabaseEntry.VariationAssetNameHash names a variation stored in a
    ///    DIFFERENT partition -- the cross-partition case a reverse table actually exists for;
    ///  * non-cas chunk entries carry an AssetNameHash of the asset they belong to.
    /// </summary>
    [CommandDescription("Dumps every name source in the mounted game (partitions, resources, bundles, EBX type/field/string tables, Ant rig names) plus hash ground truth, for building a name-hash reverse table.")]
    public class DumpNameSourcesCommand : Command
    {
        [CommandArgument(Description = "Destination directory for the name-source dump")]
        public DirectoryInfo? Destination { get; set; }

        [CommandArgument(Description = "Stop after this many partitions (0 = all). For smoke tests.", Optional = true)]
        public int MaxPartitions { get; set; } = 0;

        private const int c_HeaderSize = 80;
        private const int c_ImportSize = 32;
        private const int c_DescriptorSize = 16;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_name_sources <destination-dir> [max-partitions]");
                return false;
            }

            var s_Context = (GameContext)p_Context;
            var s_Mounter = s_Context.GetMounter();

            Directory.CreateDirectory(Destination.FullName);

            var s_Counts = new Dictionary<string, object>();

            // ---- 1. The names the mount itself knows -------------------------------------------
            // Available, not merely Mounted: m_MountedBundles is only filled by an EXPLICIT
            // mount_bundle, so a superbundle mounted with auto-mount leaves GetMountedBundles()
            // empty (measured: 0 bundles against 12,709 partitions from one auto-mounted
            // superbundle). The available set is the bundle names the superbundle TOCs declare,
            // which is what we are after.
            var s_Superbundles = new SortedSet<string>(StringComparer.Ordinal);
            s_Superbundles.UnionWith(s_Mounter.GetAvailableSuperbundles());
            s_Superbundles.UnionWith(s_Mounter.GetMountedSuperbundles());

            var s_Bundles = new SortedSet<string>(StringComparer.Ordinal);
            s_Bundles.UnionWith(s_Mounter.GetAvailableBundles());
            s_Bundles.UnionWith(s_Mounter.GetMountedBundles());

            var s_Partitions = s_Mounter.GetPartitions();
            var s_Resources = s_Mounter.GetResources();
            var s_Chunks = s_Mounter.GetChunks();

            // OriginalName, not the dictionary key: the mounter lowercases its keys, and
            // fb::hashQuick is case SENSITIVE, so a lowercased key would hash to the wrong value
            // and the cased half of the table would be silently wrong.
            var s_PartitionNames = s_Partitions.Values.Select(p_V => p_V.OriginalName).ToList();
            var s_ResourceNames = s_Resources.Values.Select(p_V => p_V.OriginalName).ToList();

            WriteLines(Path.Combine(Destination.FullName, "superbundles.txt"), s_Superbundles);
            WriteLines(Path.Combine(Destination.FullName, "bundles.txt"), s_Bundles);
            WriteLines(Path.Combine(Destination.FullName, "partitions.txt"), s_PartitionNames);
            WriteLines(Path.Combine(Destination.FullName, "resources.txt"), s_ResourceNames);
            WriteLines(Path.Combine(Destination.FullName, "chunks.txt"),
                       s_Chunks.Keys.Select(p_G => p_G.ToString("D")));

            var s_DbxNames = s_Mounter.GetDbxPartitions().Values.Select(p_V => p_V.OriginalName).ToList();
            WriteLines(Path.Combine(Destination.FullName, "dbx_partitions.txt"), s_DbxNames);

            s_Counts["superbundles"] = s_Superbundles.Count;
            s_Counts["bundles"] = s_Bundles.Count;
            s_Counts["dbx_partitions"] = s_DbxNames.Count;
            s_Counts["partitions"] = s_PartitionNames.Count;
            s_Counts["resources"] = s_ResourceNames.Count;
            s_Counts["chunks"] = s_Chunks.Count;

            p_Writer.WriteLine($"NAMESRC: superbundles={s_Superbundles.Count} bundles={s_Bundles.Count} " +
                               $"partitions={s_PartitionNames.Count} resources={s_ResourceNames.Count} " +
                               $"chunks={s_Chunks.Count}");
            p_Writer.Flush();

            // ---- 2. Chunk asset-name hashes (ground truth, hash side only) ---------------------
            // Non-cas bundles record fb::hashQuick(assetName) beside each chunk. The name is NOT
            // stored with it, which is exactly what a reverse table is for.
            var s_ChunkAssetHashes = new HashSet<uint>();

            foreach (var s_Bundle in s_Bundles)
            {
                try
                {
                    foreach (var s_Entry in s_Mounter.GetChunksWithHashInBundle(s_Bundle))
                        s_ChunkAssetHashes.Add(unchecked((uint)s_Entry.AssetNameHash));
                }
                catch (Exception)
                {
                    // A bundle kind that does not carry chunk hashes. Counted by absence.
                }
            }

            s_ChunkAssetHashes.Remove(0);
            WriteLines(Path.Combine(Destination.FullName, "gt_chunk_asset_hashes.txt"),
                       s_ChunkAssetHashes.Select(p_H => p_H.ToString("X8")));
            s_Counts["gt_chunk_asset_hashes"] = s_ChunkAssetHashes.Count;
            p_Writer.WriteLine($"NAMESRC: chunkAssetNameHashes={s_ChunkAssetHashes.Count}");
            p_Writer.Flush();

            // ---- 3. Every EBX partition's type-string table and value string table -------------
            var s_TypeStrings = new HashSet<string>(StringComparer.Ordinal);
            var s_ValueStrings = new HashSet<string>(StringComparer.Ordinal);
            var s_DescriptorHashes = new HashSet<uint>();

            var s_ObjectVariationPartitions = new List<string>();
            var s_MvdbPartitions = new List<string>();
            var s_AntPartitions = new List<string>();

            var s_Read = 0;
            var s_Failed = 0;
            var s_NotLittleEndian = 0;
            var s_DescriptorHashStatements = 0L;
            var s_DescriptorHashUnresolved = 0L;
            var s_Index = 0;

            foreach (var s_Entry in s_Partitions)
            {
                if (MaxPartitions > 0 && s_Index >= MaxPartitions)
                    break;

                s_Index++;

                byte[] s_Data;

                try
                {
                    using var s_Reader = s_Entry.Value.FirstVariant.GetReader();
                    s_Data = s_Reader.ReadBytes((int)s_Reader.Length);
                }
                catch (Exception)
                {
                    s_Failed++;
                    continue;
                }

                if (s_Data.Length < c_HeaderSize)
                {
                    s_Failed++;
                    continue;
                }

                if (!(s_Data[0] == 0xCE && s_Data[1] == 0xD1 && s_Data[2] == 0xB2 && s_Data[3] == 0x0F))
                {
                    // Big-endian (console) partitions would need byte-swapped reads. BF3 PC is
                    // little-endian throughout; counted rather than silently skipped.
                    s_NotLittleEndian++;
                    continue;
                }

                try
                {
                    var s_MetaSize = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(4));
                    var s_ImportCount = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(12));
                    var s_TypeDescriptorCount = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(24));
                    var s_FieldDescriptorCount = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(28));
                    var s_TypeStringTableSize = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(32));
                    var s_StringTableSize = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(36));

                    var s_TypeStringStart = c_HeaderSize + (int)s_ImportCount * c_ImportSize;
                    var s_TypeStringEnd = s_TypeStringStart + (int)s_TypeStringTableSize;

                    if (s_TypeStringEnd > s_Data.Length ||
                        s_MetaSize + s_StringTableSize > s_Data.Length)
                    {
                        s_Failed++;
                        continue;
                    }

                    var s_Local = new List<string>();
                    AppendNullTerminated(s_Data, s_TypeStringStart, (int)s_TypeStringTableSize, s_Local);

                    var s_LocalByHash = new Dictionary<uint, string>();

                    foreach (var s_String in s_Local)
                    {
                        s_TypeStrings.Add(s_String);
                        s_LocalByHash[RimeLib.Frostbite.Utils.HashQuick(s_String)] = s_String;
                    }

                    // Field descriptors, then 16-byte padding, then type descriptors. Each one's
                    // first uint32 is fb::hashQuick of its name; the name is in the table above.
                    var s_Cursor = s_TypeStringEnd;

                    for (var i = 0; i < s_FieldDescriptorCount; ++i)
                    {
                        if (s_Cursor + c_DescriptorSize > s_Data.Length)
                            break;

                        var s_Hash = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(s_Cursor));
                        s_DescriptorHashes.Add(s_Hash);
                        s_DescriptorHashStatements++;

                        if (!s_LocalByHash.ContainsKey(s_Hash))
                            s_DescriptorHashUnresolved++;

                        s_Cursor += c_DescriptorSize;
                    }

                    while (s_Cursor % 16 != 0)
                        s_Cursor++;

                    for (var i = 0; i < s_TypeDescriptorCount; ++i)
                    {
                        if (s_Cursor + c_DescriptorSize > s_Data.Length)
                            break;

                        var s_Hash = BinaryPrimitives.ReadUInt32LittleEndian(s_Data.AsSpan(s_Cursor));
                        s_DescriptorHashes.Add(s_Hash);
                        s_DescriptorHashStatements++;

                        if (!s_LocalByHash.ContainsKey(s_Hash))
                            s_DescriptorHashUnresolved++;

                        s_Cursor += c_DescriptorSize;
                    }

                    // The value string table: every CString field in every instance points into it.
                    AppendNullTerminated(s_Data, (int)s_MetaSize, (int)s_StringTableSize, s_ValueStrings);

                    // Which partitions are worth a full (expensive, throwing) parse later.
                    if (s_LocalByHash.ContainsValue("ObjectVariation"))
                        s_ObjectVariationPartitions.Add(s_Entry.Value.OriginalName);

                    if (s_LocalByHash.ContainsValue("MeshVariationDatabaseEntry"))
                        s_MvdbPartitions.Add(s_Entry.Value.OriginalName);

                    if (s_LocalByHash.ContainsValue("AntPackageAsset"))
                        s_AntPartitions.Add(s_Entry.Value.OriginalName);

                    s_Read++;
                }
                catch (Exception)
                {
                    s_Failed++;
                }

                if (s_Read % 10000 == 0 && s_Read > 0)
                {
                    p_Writer.WriteLine($"NAMESRC: ebx {s_Read} read, typeStrings={s_TypeStrings.Count} " +
                                       $"valueStrings={s_ValueStrings.Count}");
                    p_Writer.Flush();
                }
            }

            WriteLines(Path.Combine(Destination.FullName, "ebx_type_strings.txt"), s_TypeStrings);
            WriteLines(Path.Combine(Destination.FullName, "ebx_value_strings.txt"), s_ValueStrings);
            WriteLines(Path.Combine(Destination.FullName, "gt_ebx_descriptor_hashes.txt"),
                       s_DescriptorHashes.Select(p_H => p_H.ToString("X8")));

            s_Counts["ebx_partitions_read"] = s_Read;
            s_Counts["ebx_partitions_failed"] = s_Failed;
            s_Counts["ebx_partitions_not_little_endian"] = s_NotLittleEndian;
            s_Counts["ebx_type_strings"] = s_TypeStrings.Count;
            s_Counts["ebx_value_strings"] = s_ValueStrings.Count;
            s_Counts["gt_ebx_descriptor_hashes"] = s_DescriptorHashes.Count;
            s_Counts["gt_ebx_descriptor_statements"] = s_DescriptorHashStatements;
            s_Counts["gt_ebx_descriptor_statements_unresolved_in_own_file"] = s_DescriptorHashUnresolved;

            p_Writer.WriteLine($"NAMESRC: ebxRead={s_Read} ebxFailed={s_Failed} ebxNotLE={s_NotLittleEndian} " +
                               $"typeStrings={s_TypeStrings.Count} valueStrings={s_ValueStrings.Count} " +
                               $"descriptorHashes={s_DescriptorHashes.Count} " +
                               $"descriptorStatements={s_DescriptorHashStatements} " +
                               $"unresolvedInOwnFile={s_DescriptorHashUnresolved}");
            p_Writer.Flush();

            // ---- 4. ObjectVariation: name and hash on the SAME instance ------------------------
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());

            var s_VariationRows = new List<string>();
            var s_VariationFailed = 0;

            foreach (var s_Name in s_ObjectVariationPartitions)
            {
                try
                {
                    if (!s_Mounter.TryGetPartition(s_Name, out var s_Object))
                        continue;

                    var s_Db = s_Converter.FromPartitionObject(s_Name, s_Object.FirstVariant);

                    foreach (var s_Instance in s_Db.Instances)
                    {
                        if (s_Instance is not fb.ObjectVariation s_Variation)
                            continue;

                        // Not through WriteLines' escaping by accident: these rows are TSV, so the
                        // name column has to be escaped BEFORE the tabs that structure the row.
                        s_VariationRows.Add($"{s_Variation.NameHash:X8}\t{Escape(s_Variation.Name)}\t{Escape(s_Name)}");
                    }
                }
                catch (Exception)
                {
                    s_VariationFailed++;
                }
            }

            // WriteRaw, not WriteLines: the rows are already built with escaped columns, and
            // escaping them again would turn the tabs that structure the TSV into literal "\t".
            WriteRaw(Path.Combine(Destination.FullName, "gt_objectvariation.tsv"), s_VariationRows);
            s_Counts["gt_objectvariation_rows"] = s_VariationRows.Count;
            s_Counts["gt_objectvariation_partitions"] = s_ObjectVariationPartitions.Count;
            s_Counts["gt_objectvariation_partitions_failed"] = s_VariationFailed;

            p_Writer.WriteLine($"NAMESRC: objectVariationPartitions={s_ObjectVariationPartitions.Count} " +
                               $"rows={s_VariationRows.Count} failed={s_VariationFailed}");
            p_Writer.Flush();

            // ---- 5. MVDB: a hash pointing at a name that lives somewhere else -------------------
            var s_MvdbHashes = new HashSet<uint>();
            var s_MvdbFailed = 0;

            foreach (var s_Name in s_MvdbPartitions)
            {
                try
                {
                    if (!s_Mounter.TryGetPartition(s_Name, out var s_Object))
                        continue;

                    var s_Variant = s_Object.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null)
                                    ?? s_Object.FirstVariant;
                    var s_Db = s_Converter.FromPartitionObject(s_Name, s_Variant);

                    foreach (var s_Instance in s_Db.Instances)
                    {
                        if (s_Instance is not fb.MeshVariationDatabaseEntry s_Row)
                            continue;

                        if (s_Row.VariationAssetNameHash != 0)
                            s_MvdbHashes.Add(s_Row.VariationAssetNameHash);
                    }
                }
                catch (Exception)
                {
                    s_MvdbFailed++;
                }
            }

            WriteLines(Path.Combine(Destination.FullName, "gt_mvdb_variation_hashes.txt"),
                       s_MvdbHashes.Select(p_H => p_H.ToString("X8")));
            s_Counts["gt_mvdb_partitions"] = s_MvdbPartitions.Count;
            s_Counts["gt_mvdb_partitions_failed"] = s_MvdbFailed;
            s_Counts["gt_mvdb_variation_hashes"] = s_MvdbHashes.Count;

            p_Writer.WriteLine($"NAMESRC: mvdbPartitions={s_MvdbPartitions.Count} " +
                               $"variationHashes={s_MvdbHashes.Count} failed={s_MvdbFailed}");
            p_Writer.Flush();

            // ---- 6. Ant: object names, joint names, DOF slot names ------------------------------
            // These are in the AssetBank BLOB, not in EBX, so no amount of partition listing finds
            // them. Slot names such as "LeftHandThumb2.q" are what an Ant channel resolves to.
            var s_AntNames = new HashSet<string>(StringComparer.Ordinal);
            var s_AntFailures = new List<string>();
            var s_AntBanks = 0;
            var s_AntFailed = 0;
            var s_AntObjects = 0L;

            foreach (var s_Name in s_AntPartitions)
            {
                byte[]? s_Blob;
                string? s_BlobError;

                try
                {
                    s_Blob = AntBankFile.Read(s_Mounter, s_Name, out _, out s_BlobError);
                }
                catch (Exception s_Ex)
                {
                    s_AntFailed++;
                    // Named, not just counted: "322 of 323 loaded" is only checkable if the one
                    // that did not is identified.
                    s_AntFailures.Add($"{s_Name}\t{s_Ex.GetType().Name}: {s_Ex.Message}");
                    continue;
                }

                if (s_Blob == null)
                {
                    s_AntFailed++;
                    s_AntFailures.Add($"{s_Name}\t{s_BlobError ?? "no bank blob"}");
                    continue;
                }

                try
                {
                    var s_Bank = new Rimelib.Animation.Frostbite2_0.Frostbite.AssetBank();
                    s_Bank.SetLocalResolver(new RimeLib.Animation.Frostbite.Resolver.LocalAssetResolver());

                    using (var s_BankReader = new RimeReader(new MemoryStream(s_Blob)))
                        s_Bank.Load(s_BankReader, s_Bank);

                    foreach (var s_Object in s_Bank.Objects)
                    {
                        s_AntObjects++;

                        Add(s_AntNames, s_Object.ObjectName);
                        Add(s_AntNames, TryGetString(s_Object, "Name"));

                        if (s_Object is ant.LayoutAsset s_Layout)
                        {
                            foreach (var s_Slot in s_Layout.Slots)
                                Add(s_AntNames, s_Slot.Name);
                        }
                        else if (s_Object is ant.SkeletonAsset s_Skeleton)
                        {
                            foreach (var s_Joint in s_Skeleton.Joints)
                                Add(s_AntNames, s_Joint.JointName);
                        }
                    }

                    s_AntBanks++;
                }
                catch (Exception s_Ex)
                {
                    s_AntFailed++;
                    s_AntFailures.Add($"{s_Name}\t{s_Ex.GetType().Name}: {s_Ex.Message}");
                }
            }

            WriteLines(Path.Combine(Destination.FullName, "ant_names.txt"), s_AntNames);
            WriteRaw(Path.Combine(Destination.FullName, "ant_failures.tsv"), s_AntFailures);
            s_Counts["ant_partitions"] = s_AntPartitions.Count;
            s_Counts["ant_banks_loaded"] = s_AntBanks;
            s_Counts["ant_banks_failed"] = s_AntFailed;
            s_Counts["ant_objects"] = s_AntObjects;
            s_Counts["ant_names"] = s_AntNames.Count;

            p_Writer.WriteLine($"NAMESRC: antPartitions={s_AntPartitions.Count} banks={s_AntBanks} " +
                               $"failed={s_AntFailed} objects={s_AntObjects} names={s_AntNames.Count}");

            File.WriteAllText(Path.Combine(Destination.FullName, "summary.json"),
                              JsonConvert.SerializeObject(s_Counts, Formatting.Indented));

            p_Writer.WriteLine($"NAMESRC-DONE: {Destination.FullName}");
            return true;
        }

        private static void Add(HashSet<string> p_Set, string? p_Value)
        {
            if (!string.IsNullOrEmpty(p_Value))
                p_Set.Add(p_Value!);
        }

        private static string? TryGetString(object p_Object, string p_Property)
        {
            var s_Property = p_Object.GetType().GetProperty(p_Property);
            return s_Property?.GetValue(p_Object) as string;
        }

        /// <summary>
        /// Splits a NUL-separated blob into the strings it holds. Empty runs are dropped: a string
        /// table starts with a NUL so that offset 0 means the empty string.
        /// </summary>
        private static void AppendNullTerminated(byte[] p_Data, int p_Start, int p_Length,
                                                 ICollection<string> p_Out)
        {
            var s_End = p_Start + p_Length;
            var s_Cursor = p_Start;

            while (s_Cursor < s_End)
            {
                var s_Stop = s_Cursor;

                while (s_Stop < s_End && p_Data[s_Stop] != 0)
                    s_Stop++;

                if (s_Stop > s_Cursor)
                    p_Out.Add(Encoding.UTF8.GetString(p_Data, s_Cursor, s_Stop - s_Cursor));

                s_Cursor = s_Stop + 1;
            }
        }

        /// <summary>
        /// One name per line -- but a value string table holds LOCALISATION text, and those carry
        /// newlines and tabs. Written raw they would split one name across several lines and the
        /// reader downstream would invent names that BF3 never contained, which is the exact
        /// failure this table exists to avoid. So every line is backslash-escaped and the
        /// regenerator unescapes it.
        /// </summary>
        private static void WriteLines(string p_Path, IEnumerable<string> p_Lines)
        {
            using var s_Writer = new StreamWriter(p_Path, false, new UTF8Encoding(false));

            foreach (var s_Line in p_Lines)
                s_Writer.WriteLine(Escape(s_Line));
        }

        private static void WriteRaw(string p_Path, IEnumerable<string> p_Lines)
        {
            using var s_Writer = new StreamWriter(p_Path, false, new UTF8Encoding(false));

            foreach (var s_Line in p_Lines)
                s_Writer.WriteLine(s_Line);
        }

        private static string Escape(string p_Value)
        {
            if (p_Value.IndexOf('\\') < 0 && p_Value.IndexOf('\n') < 0 &&
                p_Value.IndexOf('\r') < 0 && p_Value.IndexOf('\t') < 0)
            {
                return p_Value;
            }

            var s_Builder = new StringBuilder(p_Value.Length + 8);

            foreach (var s_Char in p_Value)
            {
                switch (s_Char)
                {
                    case '\\': s_Builder.Append("\\\\"); break;
                    case '\n': s_Builder.Append("\\n"); break;
                    case '\r': s_Builder.Append("\\r"); break;
                    case '\t': s_Builder.Append("\\t"); break;
                    default: s_Builder.Append(s_Char); break;
                }
            }

            return s_Builder.ToString();
        }
    }
}
