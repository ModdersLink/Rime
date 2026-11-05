using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Cmd.Commands.SbBuilding;
using RimeLib.Content.Building;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;
using RimeLib.Utils;

namespace RimeLib.Cmd.Contexts
{
    public class SbBuildingContext : ExecutionContext
    {
        internal class FileReader : IReadableObject
        {
            private readonly string m_Path;

            public FileReader(string p_Path)
            {
                m_Path = p_Path;
            }

            public RimeReader GetReader()
            {
                var s_FileStream = File.Open(m_Path, FileMode.Open, FileAccess.Read, FileShare.Read);
                return new RimeReader(s_FileStream);
            }

            public long GetSize()
            {
                return new FileInfo(m_Path).Length;
            }
        }

        internal class MemoryReader : IReadableObject
        {
            private readonly byte[] m_Data;

            public MemoryReader(byte[] p_Data)
            {
                m_Data = p_Data;
            }

            public RimeReader GetReader()
            {
                return new RimeReader(new MemoryStream(m_Data));
            }

            public long GetSize()
            {
                return m_Data.Length;
            }
        }

        internal class ChunkFileReader : FileReader, IChunkObject
        {
            private readonly string? m_AssetName;
            private readonly int? m_AssetHash;
            private readonly int? m_FirstMip;
            private readonly EngineType m_Engine;

            public ChunkFileReader(EngineType p_Engine, string p_Path, string? p_AssetName, int? p_FirstMip = null) :
                base(p_Path)
            {
                m_Engine = p_Engine;
                m_AssetName = p_AssetName;
                m_FirstMip = p_FirstMip;
            }

            public ChunkFileReader(EngineType p_Engine, string p_Path, int? p_AssetHash, int? p_FirstMip = null) :
                base(p_Path)
            {
                m_Engine = p_Engine;
                m_AssetHash = p_AssetHash;
                m_FirstMip = p_FirstMip;
            }

            /// <summary>
            /// A texture chunk's meta, when one was supplied.
            ///
            /// `firstMip` is how the engine slices a texture chunk into D3D subresources: it says
            /// which mip the chunk's data starts at. Returning nothing leaves the mip chain
            /// undescribed, and CreateTexture2D then rejects the subresource array outright with
            /// E_INVALIDARG -- which is a malformed descriptor, not an allocation failure, and is
            /// exactly the error a rebuilt DDS produces. Chunks pulled from an existing bundle keep
            /// their own meta because the closure passes the mounted variant through; this is the
            /// path for a chunk added from a FILE, which had no way to carry one.
            /// </summary>
            public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
            {
                p_Meta = null;

                if (m_FirstMip == null)
                    return false;

                p_Meta = EngineInterfaceRegistry.Create<IChunkMetaWriter>(m_Engine).Create(m_AssetHash, m_FirstMip);
                return true;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetRangeEnd()
            {
                return (uint)GetSize();
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }

            public uint GetLogicalSize()
            {
                return (uint)GetSize();
            }

            public int? GetAssetNameHash()
            {
                if (m_AssetHash != null)
                    return m_AssetHash;

                if (m_AssetName == null)
                    return null;

                return (int)Frostbite.Utils.HashQuick(m_AssetName);
            }
        }

        public EngineType EngineType;

        /// <summary>Per level partition built so far, the meshes its mesh variation database's keys cover.</summary>
        internal Dictionary<string, IReadOnlyCollection<string>> DerivedMeshes { get; } = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>The shaders the bundles built so far draw with, for a shader database built after them.</summary>
        internal HashSet<string> DrawnShaders { get; } = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The partitions converted from another engine into the bundles built so far, by name: a later
        /// bundle loads with them and so references them rather than adding them, and derives its
        /// fields from what they hold.
        /// </summary>
        internal Dictionary<string, RimeLib.Serialization.DatabasePartitionBase> ConvertedPartitions { get; } = new(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// The bundle whose converted partitions the others share: the first to convert, the level's,
        /// which the game loads before its sub-worlds. Sub-world bundles load beside each other and do
        /// not see each other's partitions, so each converts its own.
        /// </summary>
        internal string? SharedConversionBundle { get; set; }

        /// <summary>
        /// How the converted partitions' materials map to this engine's, once a converted closure
        /// has made it: the bundles share it, so the grid can be built for every material they use.
        /// </summary>
        internal RimeLib.Serialization.Conversion.MaterialMapping? ConvertedMaterials { get; set; }

        /// <summary>
        /// This engine's shaders, to stand in for the converted mesh materials' shaders, once a
        /// converted closure has learned them from the game of this engine mounted beside the source,
        /// by the kind of mesh they draw (see <see cref="MountedShaders.ByMesh"/>).
        /// </summary>
        internal IReadOnlyDictionary<string, RimeLib.Serialization.Conversion.ShaderStandIns>? ShaderStandIns { get; set; }

        /// <summary>
        /// The source resources the converted closures met of a type not converted, by their name in
        /// the source, for a command that builds what they hold in this engine's form (an emitter
        /// system's atlas from the atlas textures).
        /// </summary>
        internal Dictionary<string, RimeLib.Content.Frostbite.ResourceType> UnconvertedResources { get; } = new(StringComparer.OrdinalIgnoreCase);

        protected string m_OutPath;
        protected string m_SbName;

        protected SuperbundleBuilder m_Builder;

        public SbBuildingContext(BaseContext p_Parent, EngineType p_EngineType, string p_OutPath, string p_SbName, bool p_Cas = false)
        {
            Parent = p_Parent;
            EngineType = p_EngineType;
            m_OutPath = p_OutPath;
            m_SbName = p_SbName;

            m_Builder = SuperbundleBuilder.Create(p_EngineType, p_SbName, p_Cas);

            RegisterCommand<AddChunkCommand>();
            RegisterCommand<AddExistingChunkCommand>();
            RegisterCommand<RemoveChunkCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<BuildBundleCommand>();
            RegisterCommand<CloneSbChunksCommand>();
            RegisterCommand<RemoveBundleCommand>();
            RegisterCommand<ListBundlesCommand>();
            RegisterCommand<BuildCommand>();

            RegisterEngineCommands(p_EngineType);
        }

        internal void AddCasTocChunk(GUID p_Id, Sha1 p_Sha1)
        {
            m_Builder.WithCasTocChunk(p_Id, p_Sha1);
        }

        public override string GetShortDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Bundles = m_Builder.GetBundles().Count;

            return $"building sb - {m_SbName} - {s_Chunks} chunk{(s_Chunks == 1 ? "" : "s")} - {s_Bundles} bundle{(s_Bundles == 1 ? "" : "s")}";
        }

        public override string GetLongDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Bundles = m_Builder.GetBundles().Count;

            var s_OutPath = Path.Join(m_OutPath, m_SbName);
            s_OutPath = s_OutPath.Replace(Path.AltDirectorySeparatorChar, Path.DirectorySeparatorChar);

            var s_Text = "Superbundle Builder\n\n";

            s_Text += $"Superbundle name: {m_SbName}\n";
            s_Text += $"Output sb: {s_OutPath}.sb\n";
            s_Text += $"Output toc: {s_OutPath}.toc\n";
            s_Text += $"Chunks added: {s_Chunks}\n";
            s_Text += $"Bundles added: {s_Bundles}";

            return s_Text;
        }

        internal void AddChunk(GUID p_Guid, FileInfo p_File, string? p_AssetName)
        {
            m_Builder.WithChunk(p_Guid, new ChunkFileReader(EngineType, p_File.FullName, p_AssetName));
        }

        internal void AddChunk(GUID p_Guid, IChunkObject p_ChunkObject)
        {
            m_Builder.WithChunk(p_Guid, p_ChunkObject);
        }

        internal void RemoveChunk(GUID p_Guid)
        {
            m_Builder.RemoveChunk(p_Guid);
        }

        internal IReadOnlyDictionary<GUID, IChunkObject> GetChunks()
        {
            return m_Builder.GetChunks();
        }

        /// <summary>A bundle already built into this superbundle, by name in any case.</summary>
        internal BundleDescriptor? GetBuiltBundle(string p_Name)
        {
            foreach (var (s_Name, s_Bundle) in m_Builder.GetBundles())
                if (string.Equals(s_Name, p_Name, StringComparison.OrdinalIgnoreCase))
                    return s_Bundle;
            return null;
        }

        internal void AddBundle(BundleDescriptor p_BundleDescriptor)
        {
            m_Builder.WithBundle(p_BundleDescriptor);
        }

        internal void RemoveBundle(string p_Name)
        {
            m_Builder.RemoveBundle(p_Name);
        }

        internal IReadOnlyDictionary<string, BundleDescriptor> GetBundles()
        {
            return m_Builder.GetBundles();
        }

        /// <param name="p_NoCasRefs">
        /// For a cas superbundle: embed every payload instead of ref'ing catalogued ones. The output
        /// is as large as a noncas build, so it is a diagnostic, not a shipping mode: it separates
        /// "the cas manifest format is wrong" from "the sha1 refs do not resolve" when a cas build
        /// will not load.
        /// </param>
        internal void Build(TextWriter p_Writer, bool p_NoCasRefs = false)
        {
            if (m_Builder.Cas() && p_NoCasRefs)
            {
                p_Writer.WriteLine("Embedding every payload, emitting no refs.");
            }
            else if (m_Builder.Cas() && Parent is BaseContext s_BaseContext)
            {
                // Give a cas build a catalog membership probe, so a noncas source can ship as a bare
                // sha1 ref whenever the player's own catalog already holds the identical stored frame.
                foreach (var s_MounterEntry in s_BaseContext.GetMounters())
                {
                    if (s_MounterEntry.Value is ICatalogProbe s_Probe && s_MounterEntry.Value.GetEngineType() == EngineType)
                    {
                        m_Builder.WithCatalogProbe(s_Probe.CatalogContainsEntry);
                        break;
                    }
                }
            }

            var s_OutPath = Path.Join(m_OutPath, m_SbName);
            Directory.CreateDirectory(Path.GetDirectoryName(s_OutPath)!);

            using var s_TocStream = File.Open(s_OutPath + ".toc", FileMode.Create, FileAccess.ReadWrite);
            using var s_SbStream = File.Open(s_OutPath + ".sb", FileMode.Create, FileAccess.ReadWrite);

            m_Builder.Build(s_SbStream, s_TocStream);

            foreach (var s_Warning in m_Builder.Warnings)
                p_Writer.WriteLine($"Warning: {s_Warning}");
        }

        internal bool Cas()
        {
            return m_Builder.Cas();
        }
    }
}
