using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Reads a shipped structure, writes it back, and diffs the BYTES.
    ///
    /// This exists because "the Serialize no longer throws" is not the same claim as "the bytes
    /// reach the game", and this project has repeatedly been burned by the gap. Every count below
    /// is asserted non-zero before any verdict is printed: a writer that emitted nothing would
    /// otherwise report a clean sweep of an empty set, which reads exactly like success.
    ///
    /// Each section reports "n of m byte-identical" against the game's own bytes at the offset the
    /// reader consumed them from -- not against a re-parse of our own output, which would only
    /// prove the writer agrees with itself.
    /// </summary>
    [CommandDescription("Round-trips the newly-written Serialize implementations against the mounted game and reports byte equality.")]
    public class RoundTripWritersCommand : Command
    {
        [CommandArgument(Description = "Directory to dump HavokPhysicsData payloads into, for offline work.", Optional = true)]
        public DirectoryInfo? HavokDumpDir { get; set; }

        [CommandArgument(Description = "Cap on how many resources of each kind to test (0 = all).", Optional = true)]
        public int Limit { get; set; } = 0;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Context = (GameContext) p_Context;
            var s_Mounter = s_Context.GetMounter();

            var s_Resources = s_Context.GetMountedResourceVariations();
            var s_Partitions = s_Mounter.GetPartitions();

            p_Writer.WriteLine($"CORPUS resources={s_Resources.Count} partitions={s_Partitions.Count}");
            p_Writer.WriteLine();

            // Counting first: a writer for something the game never ships is wasted effort.
            var s_ByType = new Dictionary<ResourceType, int>();

            foreach (var l_Resource in s_Resources.Values)
            {
                var s_Type = l_Resource.FirstVariant.GetResourceType();
                s_ByType[s_Type] = s_ByType.TryGetValue(s_Type, out var l_Count) ? l_Count + 1 : 1;
            }

            foreach (var l_Pair in s_ByType.OrderByDescending(p => p.Value))
                p_Writer.WriteLine($"COUNT {l_Pair.Key} = {l_Pair.Value}");

            p_Writer.WriteLine();

            // The engine projects round-trip their own structures, each subsystem its part.
            foreach (var s_RoundTrip in EngineInterfaceRegistry.CreateAll<IWriterRoundTrip>(s_Mounter.GetEngineType()))
                s_RoundTrip.Run(s_Mounter, Limit, p_Writer);

            TestShaderConstants(s_Context, s_Mounter, p_Writer);
            TestHavok(s_Context, p_Writer);

            return true;
        }

        // ---------------------------------------------------------------- shader constants

        /// <summary>
        /// Rebuilds each external constant record and looks for those exact bytes in the shaderdb
        /// payload the record was read from.
        ///
        /// Positional comparison is not available here: ShaderConstant reaches its external arrays
        /// through offsets it keeps as locals, so nothing downstream knows where a record sat. A
        /// 0x28/0x30-byte match that includes a 32-byte name and, for values, four floats is not
        /// something a wrong writer hits by accident, so this is a search over the source bytes,
        /// not a re-parse of our own output.
        /// </summary>
        void TestShaderConstants(GameContext p_Context, RimeLib.Content.Mounting.IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();

            var s_Dbs = 0;
            var s_ValueTotal = 0;
            var s_ValueFound = 0;
            var s_TextureTotal = 0;
            var s_TextureFound = 0;
            var s_FirstValueFailure = string.Empty;
            var s_FirstTextureFailure = string.Empty;

            foreach (var l_Resource in s_Resources.Values)
            {
                var s_Type = l_Resource.FirstVariant.GetResourceType();

                if (s_Type != ResourceType.DxShaderDatabase && s_Type != ResourceType.IShaderDatabase)
                    continue;

                if (Limit > 0 && s_Dbs >= Limit)
                    break;

                byte[] s_Payload;
                object? s_Container;

                try
                {
                    s_Payload = WriterRoundTrip.ReadAll(l_Resource.FirstVariant);

                    var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(p_Mounter.GetEngineType());
                    s_Resolver.Initialize(l_Resource.FirstVariant, p_Mounter);

                    s_Container = s_Resolver.GetType().GetProperty("ShaderDatabaseContainer")?.GetValue(s_Resolver);
                }
                catch (Exception)
                {
                    continue;
                }

                if (s_Container == null)
                    continue;

                if (s_Container.GetType().GetProperty("Databases")?.GetValue(s_Container) is not IDictionary s_Databases)
                    continue;

                ++s_Dbs;

                foreach (var l_Key in s_Databases.Keys)
                {
                    var s_Db = s_Databases[l_Key];

                    if (s_Db?.GetType().GetProperty("Constants")?.GetValue(s_Db) is not Array s_Constants)
                        continue;

                    foreach (var l_Constant in s_Constants)
                    {
                        if (l_Constant == null)
                            continue;

                        CheckRecords(l_Constant, "ExternalValues", s_Payload,
                                     ref s_ValueTotal, ref s_ValueFound, ref s_FirstValueFailure,
                                     l_Resource.OriginalName);

                        CheckRecords(l_Constant, "ExternalTextures", s_Payload,
                                     ref s_TextureTotal, ref s_TextureFound, ref s_FirstTextureFailure,
                                     l_Resource.OriginalName);
                    }
                }
            }

            p_Writer.WriteLine($"SHADERDB databases parsed = {s_Dbs}");
            p_Writer.WriteLine($"EXTERNALVALUECONSTANT {s_ValueFound} of {s_ValueTotal} byte-identical " +
                               $"{(s_ValueTotal > 0 && s_ValueFound == s_ValueTotal ? "PASS" : "FAIL")}");

            if (s_FirstValueFailure.Length > 0)
                p_Writer.WriteLine($"  first mismatch: {s_FirstValueFailure}");

            p_Writer.WriteLine($"EXTERNALTEXTURECONSTANT {s_TextureFound} of {s_TextureTotal} byte-identical " +
                               $"{(s_TextureTotal > 0 && s_TextureFound == s_TextureTotal ? "PASS" : "FAIL")}");

            if (s_FirstTextureFailure.Length > 0)
                p_Writer.WriteLine($"  first mismatch: {s_FirstTextureFailure}");

            if (s_ValueTotal == 0 || s_TextureTotal == 0)
                p_Writer.WriteLine("  NOTHING TESTED for at least one record kind -- that verdict means nothing.");
        }

        static void CheckRecords(object p_Constant, string p_Property, byte[] p_Payload,
                                 ref int p_Total, ref int p_Found, ref string p_FirstFailure,
                                 string p_ResourceName)
        {
            if (p_Constant.GetType().GetProperty(p_Property)?.GetValue(p_Constant) is not Array s_Records)
                return;

            foreach (var l_Record in s_Records)
            {
                if (l_Record is not IFbSerializable s_Serializable)
                    continue;

                ++p_Total;

                byte[]? s_Written = null;

                try
                {
                    s_Serializable.Serialize(out s_Written);
                }
                catch (Exception s_Exception)
                {
                    if (p_FirstFailure.Length == 0)
                        p_FirstFailure = $"{p_ResourceName}: {s_Exception.GetType().Name}";

                    continue;
                }

                if (s_Written == null)
                    continue;

                if (IndexOf(p_Payload, s_Written) >= 0)
                    ++p_Found;
                else if (p_FirstFailure.Length == 0)
                    p_FirstFailure = $"{p_ResourceName}: {s_Written.Length}-byte record not present in the shipped payload";
            }
        }

        static int IndexOf(byte[] p_Haystack, byte[] p_Needle)
        {
            if (p_Needle.Length == 0 || p_Haystack.Length < p_Needle.Length)
                return -1;

            var s_Last = p_Haystack.Length - p_Needle.Length;

            for (var i = 0; i <= s_Last; ++i)
            {
                var j = 0;

                while (j < p_Needle.Length && p_Haystack[i + j] == p_Needle[j])
                    ++j;

                if (j == p_Needle.Length)
                    return i;
            }

            return -1;
        }

        // ---------------------------------------------------------------- Havok

        void TestHavok(GameContext p_Context, TextWriter p_Writer)
        {
            var s_Resources = p_Context.GetMountedResourceVariations();
            var s_Total = 0;
            var s_Dumped = 0;
            long s_Bytes = 0;

            if (HavokDumpDir != null && !HavokDumpDir.Exists)
                HavokDumpDir.Create();

            foreach (var l_Resource in s_Resources.Values)
            {
                if (l_Resource.FirstVariant.GetResourceType() != ResourceType.HavokPhysicsData)
                    continue;

                ++s_Total;

                if (HavokDumpDir == null || (Limit > 0 && s_Dumped >= Limit))
                    continue;

                try
                {
                    var s_Payload = WriterRoundTrip.ReadAll(l_Resource.FirstVariant);
                    var s_File = Path.Combine(HavokDumpDir.FullName,
                                              l_Resource.OriginalName.Replace('/', '_') + ".bin");

                    File.WriteAllBytes(s_File, s_Payload);

                    ++s_Dumped;
                    s_Bytes += s_Payload.Length;
                }
                catch (Exception)
                {
                    // A resource that cannot be read is counted but not dumped.
                }
            }

            p_Writer.WriteLine($"HAVOKPHYSICSDATA resources = {s_Total}, dumped = {s_Dumped} ({s_Bytes} bytes)");
        }
    }
}
