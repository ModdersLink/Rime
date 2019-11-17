using System;
using System.Collections.Generic;
using RimeLib.Content.Building;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;

namespace Rime.Utils.RimeREPL.Contexts
{
    internal class BundleBuildingContext : REPLContext
    {
        internal class ResourceFileReader : SbBuildingContext.FileReader, IResourceObject
        {
            private readonly ResourceType m_ResourceType;

            public ResourceFileReader(string p_Path, ResourceType p_ResourceType) :
                base(p_Path)
            {
                m_ResourceType = p_ResourceType;
            }

            public ResourceType GetResourceType()
            {
                return m_ResourceType;
            }

            public bool TryGetMeta(out byte[]? p_Meta)
            {
                p_Meta = null;
                return false;
            }
        }

        protected readonly SbBuildingContext m_Parent;
        protected readonly string m_BundleName;

        protected BundleBuilder m_Builder;

        public BundleBuildingContext(SbBuildingContext p_Parent, string p_BundleName)
        {
            m_Parent = p_Parent;
            m_BundleName = p_BundleName;

            m_Builder = BundleBuilder.Create(m_BundleName);
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

                m_Builder.WithChunk(new GUID(s_Id), new SbBuildingContext.ChunkFileReader(s_Path));

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

            if (s_Parts[0] == "add_resource")
            {
                var s_Name = s_Parts[1];
                var s_Path = s_Parts[2];

                if (!Enum.TryParse<ResourceType>(s_Parts[3], out var s_ResourceType))
                {
                    Console.WriteLine("Invalid resource type specified. Available types:");

                    foreach (var s_Type in Enum.GetNames(typeof(ResourceType)))
                        Console.WriteLine("- " + s_Type);

                    return true;
                }

                m_Builder.WithResource(s_Name, new ResourceFileReader(s_Path, s_ResourceType));

                return true;
            }

            if (s_Parts[0] == "remove_resource")
            {
                var s_Name = s_Parts[1];

                m_Builder.RemoveResource(s_Name);

                return true;
            }

            if (s_Parts[0] == "list_resources")
            {
                foreach (var s_Resource in m_Builder.GetResources())
                    Console.WriteLine($"- {s_Resource.Key}");

                return true;
            }

            if (s_Parts[0] == "add_partition")
            {
                var s_Name = s_Parts[1];
                var s_Path = s_Parts[2];

                m_Builder.WithPartition(s_Name, new SbBuildingContext.FileReader(s_Path));

                return true;
            }

            if (s_Parts[0] == "remove_partition")
            {
                var s_Name = s_Parts[1];

                m_Builder.RemovePartition(s_Name);

                return true;
            }

            if (s_Parts[0] == "list_partitions")
            {
                foreach (var s_Partition in m_Builder.GetPartitions())
                    Console.WriteLine($"- {s_Partition.Key}");

                return true;
            }

            if (s_Parts[0] == "build")
            {
                Console.WriteLine("Building bundle...");

                m_Parent.AddBundle(m_Builder.Build());

                Console.WriteLine("Bundle successfully built. Returning to superbundle.");

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
            Console.WriteLine("add_resource <name> <path> <type>");
            Console.WriteLine("remove_resource <name>");
            Console.WriteLine("list_resources");
            Console.WriteLine("add_partition <name> <path>");
            Console.WriteLine("remove_partition <name>");
            Console.WriteLine("list_partitions");
            Console.WriteLine("build");
            Console.WriteLine("help");
            Console.WriteLine("exit");
        }

        public override string GetDescription()
        {
            var s_Chunks = m_Builder.GetChunks().Count;
            var s_Resources = m_Builder.GetResources().Count;
            var s_Partitions = m_Builder.GetPartitions().Count;

            return $"building bundle - {m_BundleName} - {s_Chunks} chunk{(s_Chunks == 1 ? "" : "s")} - {s_Resources} resource{(s_Resources == 1 ? "" : "s")} - {s_Partitions} partition{(s_Partitions == 1 ? "" : "s")}";
        }
    }
}
