using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Building;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace Rime.Utils.RimeREPL.Contexts
{
    internal class SbBuildingContext : REPLContext
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

        protected BaseContext m_Parent;
        protected EngineType m_EngineType;
        protected string m_OutPath;
        protected string m_SbName;

        protected SuperbundleBuilder m_Builder;

        public SbBuildingContext(BaseContext p_Parent, EngineType p_EngineType, string p_OutPath, string p_SbName)
        {
            m_Parent = p_Parent;
            m_EngineType = p_EngineType;
            m_OutPath = p_OutPath;
            m_SbName = p_SbName;

            m_Builder = SuperbundleBuilder.Create(p_EngineType, p_SbName);
        }

        public void AddBundle(BundleDescriptor p_Descriptor)
        {
            m_Builder.WithBundle(p_Descriptor);
        }

        public override bool TryGetParent(out REPLContext p_Parent)
        {
            p_Parent = m_Parent;
            return true;
        }

        public override bool ProcessCommand(string p_Input, out REPLContext p_NewContext)
        {
            p_NewContext = this;

            var s_Parts = p_Input.Split(" ");

            if (s_Parts[0] == "add_chunk")
            {
                var s_Id = s_Parts[1];
                var s_Path = s_Parts[2];

                m_Builder.WithChunk(new GUID(s_Id), new ChunkFileReader(s_Path));

                return true;
            }

            if (s_Parts[0] == "remove_chunk")
            {
                var s_Id = s_Parts[1];

                m_Builder.RemoveChunk(new GUID(s_Id));

                return true;
            }

            if (s_Parts[0] == "list_chunks")
            {
                foreach (var s_Chunk in m_Builder.GetChunks())
                    Console.WriteLine($"- {s_Chunk.Key.ToString("D")}");

                return true;
            }

            if (s_Parts[0] == "build_bundle")
            {
                var s_Name = s_Parts[1];

                p_NewContext = new BundleBuildingContext(this, s_Name);

                return true;
            }

            if (s_Parts[0] == "remove_bundle")
            {
                var s_Name = s_Parts[1];

                m_Builder.RemoveBundle(s_Name);

                return true;
            }

            if (s_Parts[0] == "list_bundles")
            {
                foreach (var s_Bundle in m_Builder.GetBundles())
                    Console.WriteLine($"- {s_Bundle.Key}");

                return true;
            }

            if (s_Parts[0] == "build")
            {
                var s_OutPath = Path.Join(m_OutPath, m_SbName);

                Console.WriteLine("Building Superbundle...");
                Console.WriteLine();
                Console.WriteLine($"Output Sb: {s_OutPath}.sb");
                Console.WriteLine($"Output Toc: {s_OutPath}.toc");

                Directory.CreateDirectory(Path.GetDirectoryName(s_OutPath));

                using var s_TocStream = File.Open(s_OutPath + ".toc", FileMode.Create, FileAccess.ReadWrite);
                using var s_SbStream = File.Open(s_OutPath + ".sb", FileMode.Create, FileAccess.ReadWrite);

                m_Builder.Build(s_SbStream, s_TocStream);

                Console.WriteLine();
                Console.WriteLine("Superbundle successfully built. Exiting builder.");

                p_NewContext = m_Parent;
                
                return true;
            }

            return false;
        }

        public override List<string> GetSuggestions(string p_Input)
        {
            return new List<string>();
        }

        public override void PrintHelp()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine();
            Console.WriteLine("add_chunk <id> <path>");
            Console.WriteLine("remove_chunk <id>");
            Console.WriteLine("list_chunks");
            Console.WriteLine("build_bundle <name>");
            Console.WriteLine("remove_bundle <name>");
            Console.WriteLine("list_bundles");
            Console.WriteLine("build");
            Console.WriteLine("help");
            Console.WriteLine("exit");
        }

        public override string GetDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Bundles = m_Builder.GetBundles().Count;

            return $"building sb - {m_SbName} - {s_Chunks} chunk{(s_Chunks == 1 ? "" : "s")} - {s_Bundles} bundle{(s_Bundles == 1 ? "" : "s")}";
        }
    }
}
