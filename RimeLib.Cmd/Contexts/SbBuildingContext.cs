using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Cmd.Commands.SbBuilding;
using RimeLib.Content.Building;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

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

        internal class ChunkFileReader : FileReader, IChunkObject
        {
            public ChunkFileReader(string p_Path) :
                base(p_Path)
            {
            }

            public bool TryGetMeta(out DbObject? p_Meta)
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
        }

        protected EngineType m_EngineType;
        protected string m_OutPath;
        protected string m_SbName;

        protected SuperbundleBuilder m_Builder;

        public SbBuildingContext(BaseContext p_Parent, EngineType p_EngineType, string p_OutPath, string p_SbName)
        {
            Parent = p_Parent;
            m_EngineType = p_EngineType;
            m_OutPath = p_OutPath;
            m_SbName = p_SbName;

            m_Builder = SuperbundleBuilder.Create(p_EngineType, p_SbName);

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

            var s_Text = "Superbundle Builder\n";
            s_Text += $"Chunks added: {s_Chunks}\n";
            s_Text += $"Bundles added: {s_Bundles}";

            return s_Text;
        }

        internal void AddChunk(GUID p_Guid, FileInfo p_File)
        {
            m_Builder.WithChunk(p_Guid, new ChunkFileReader(p_File.FullName));
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

            using var s_TocStream = File.Open(s_OutPath + ".toc", FileMode.Create, FileAccess.ReadWrite);
            using var s_SbStream = File.Open(s_OutPath + ".sb", FileMode.Create, FileAccess.ReadWrite);

            m_Builder.Build(s_SbStream, s_TocStream);
        }
    }
}
