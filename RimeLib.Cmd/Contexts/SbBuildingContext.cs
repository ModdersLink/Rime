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
                var s_FileStream = File.Open(m_Path, FileMode.Open, FileAccess.Read);
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
            
            public ChunkFileReader(string p_Path, string? p_AssetName) :
                base(p_Path)
            {
                m_AssetName = p_AssetName;
            }

            public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
            {
                p_Meta = null;
                return false;
            }

            public uint GetRangeStart()
            {
                return 0;
            }

            public uint GetLogicalOffset()
            {
                return 0;
            }

            public int? GetAssetNameHash()
            {
                if (m_AssetName == null)
                    return null;
                
                return (int)Frostbite.Utils.HashQuick(m_AssetName);
            }
        }

        public EngineType EngineType;
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
            RegisterCommand<RemoveChunkCommand>();
            RegisterCommand<ListChunksCommand>();
            RegisterCommand<BuildBundleCommand>();
            RegisterCommand<RemoveBundleCommand>();
            RegisterCommand<ListBundlesCommand>();
            RegisterCommand<BuildCommand>();
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
            m_Builder.WithChunk(p_Guid, new ChunkFileReader(p_File.FullName, p_AssetName));
        }

        internal void RemoveChunk(GUID p_Guid)
        {
            m_Builder.RemoveChunk(p_Guid);
        }

        internal IReadOnlyDictionary<GUID, IChunkObject> GetChunks()
        {
            return m_Builder.GetChunks();
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

        internal void Build()
        {
            var s_OutPath = Path.Join(m_OutPath, m_SbName);
            Directory.CreateDirectory(Path.GetDirectoryName(s_OutPath)!);

            using var s_TocStream = File.Open(s_OutPath + ".toc", FileMode.Create, FileAccess.ReadWrite);
            using var s_SbStream = File.Open(s_OutPath + ".sb", FileMode.Create, FileAccess.ReadWrite);

            m_Builder.Build(s_SbStream, s_TocStream);
        }
    }
}
