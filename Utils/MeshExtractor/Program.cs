using CommandLine;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Mesh.Frostbite;
using RimeLib.Mesh.Frostbite.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace MeshExtractor
{
    class Program
    {
        internal class Options
        {
            [Option('q', "quiet", Required = false, Default = false, HelpText = "Suppress console output.")]
            public bool Quiet { get; set; } = false;

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }

            [Value(2, MetaName = "outPath", Required = true, HelpText = "The output directory where the extracted files will be put into.")]
            public string OutputPath { get; set; } = "";
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                LoadContentAssembly(p_Options);
                DumpFiles(p_Options);

                Console.WriteLine("Content successfully extracted. Press any key to exit...");
                Console.ReadKey();
            }).WithNotParsed(p_Err => { Environment.Exit(1); });
        }

        private static void LoadContentAssembly(Options p_Options)
        {
            var s_AssemblyName = "RimeLib.Content." + p_Options.EngineType;

            try
            {
                if (!p_Options.Quiet)
                    Console.WriteLine("Loading engine content support assembly.");

                Assembly.Load(s_AssemblyName);
            }
            catch
            {
                if (!p_Options.Quiet)
                    Console.WriteLine($"Failed to load supporting engine assembly ({s_AssemblyName}.dll). This means that the engine is not supported or that you are missing required files.");

                Environment.Exit(1);
            }
        }

        private static async void DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineMounterRegistry.Create(p_Options.EngineType);

            if (!p_Options.Quiet)
                Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true);

            if (!p_Options.Quiet)
                Console.WriteLine($"Everythingis now mounted! Starting model conversion.");

            foreach (var p_Pair in s_Mounter.GetResources())
            {
                var l_Name = p_Pair.Key;
                var l_MountedObject = p_Pair.Value;

                foreach (var l_Variant in l_MountedObject.Variants)
                {
                    if (l_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    // Dump the mesh
                    DumpMesh(s_Mounter, p_Options, l_Name, l_MountedObject);
                }
            }

            // TODO: Speed this up
            // Uncomment below once debugging is done
            /*Parallel.ForEach(s_Mounter.GetResources(), p_Pair =>
            {
                var l_Name = p_Pair.Key;
                var l_MountedObject = p_Pair.Value;

                foreach (var l_Variant in l_MountedObject.Variants)
                {
                    if (l_Variant.GetResourceType() != RimeLib.Content.Frostbite.ResourceType.MeshSet)
                        continue;

                    // Dump the mesh
                    DumpMesh(p_Options, l_Name, l_MountedObject);
                }
            });*/
        }

        private static void DumpMesh<T>(IEngineMounter p_Mounter, Options p_Options, string p_FilePath, IMountedObject<T> p_Object) where T : IObjectVariant
        {
            // Construct a full path to this object and make sure its directory exists.
            var s_Path = Path.Join(p_Options.OutputPath, p_FilePath + ".obj").Normalize();

            var s_Directory = Path.GetDirectoryName(s_Path);
            Directory.CreateDirectory(s_Directory);

            if (!p_Options.Quiet)
                Console.WriteLine("/" + p_FilePath + ".obj");

            // Get a reader to the object.
            var s_Variant = p_Object.FirstVariant;
            using var s_Reader = s_Variant.GetReader();

            var s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

            File.WriteAllBytes(s_Path + ".bin", s_Data);

            using var s_Reader2 = new RimeReader(new MemoryStream(s_Data), RimeLib.IO.Conversion.Endianness.LittleEndian);
            var s_MeshSetLayout = new MeshSetLayout(s_Reader2);

            var s_CurrentLod = 0;
            using var s_Writer = new StringWriter();

            foreach (var l_Lod in s_MeshSetLayout.Lods)
            {
                var l_MeshLayout = l_Lod.Object;
                if (l_MeshLayout == null)
                {
                    s_CurrentLod++;
                    continue;
                }

                s_Writer.WriteLine($"# Automatically generated file");
                s_Writer.WriteLine($"# Name: {l_MeshLayout.Name.Object}");
                s_Writer.WriteLine($"# ChunkId: {l_MeshLayout.DataChunkId}");
                s_Writer.WriteLine($"# Lod: {s_CurrentLod}");

                var l_DataChunkId = l_MeshLayout.DataChunkId;

                if (!p_Mounter.TryGetChunk(l_DataChunkId, out IMountedObject<IChunkVariant> p_Chunk))
                    continue;

                // TODO: Determine wtf this reader is open to
                using var l_Reader = new RimeReader(p_Chunk.FirstVariant.GetReader(), RimeLib.IO.Conversion.Endianness.LittleEndian);

                // Each of the subsets can be one part
                foreach (var l_Subset in l_MeshLayout.Subsets.Get)
                {                    
                    var l_Verts = new List<(float, float, float)>();
                    var l_Normals = new List<(float, float, float)>();
                    var l_Indicies = new List<(ushort, ushort, ushort)>();

                    for (var l_VertexIndex = 0; l_VertexIndex < l_Subset.VertexCount; ++l_VertexIndex)
                    {
                        var l_VertexBlock = new VertexData(l_Reader);

                        l_Verts.Add((l_VertexBlock.X, l_VertexBlock.Y, l_VertexBlock.Z));
                        l_Normals.Add((l_VertexBlock.VertexNormals[0], l_VertexBlock.VertexNormals[1], l_VertexBlock.VertexNormals[2]));
                    }

                    // Read out all of the primitives
                    for (var l_PrimitiveIndex = 0; l_PrimitiveIndex < l_Subset.PrimitiveCount; ++l_PrimitiveIndex)
                    {
                        l_Indicies.Add((l_Reader.ReadUInt16(), l_Reader.ReadUInt16(), l_Reader.ReadUInt16()));
                    }

                    // Write out all of the information we have gathered so far
                    s_Writer.WriteLine($"# Subset Primitve Type: {l_Subset.PrimitiveType}");
                    s_Writer.WriteLine($"# Subset Primitive Count: {l_Subset.PrimitiveCount}");
                    s_Writer.WriteLine($"# Subset Vertex Count: {l_Subset.VertexCount}");

                    foreach (var l_Vert in l_Verts)
                        s_Writer.WriteLine($"v {l_Vert.Item1} {l_Vert.Item2} {l_Vert.Item3}");

                    foreach (var l_Normal in l_Normals)
                        s_Writer.WriteLine($"vn {l_Normal.Item1} {l_Normal.Item2} {l_Normal.Item3}");

                    s_Writer.WriteLine($"g {l_MeshLayout.Name}");
                    s_Writer.WriteLine($"usemtl {l_Subset.MaterialName}");

                    foreach (var l_Index in l_Indicies)
                        s_Writer.WriteLine($"f {l_Index.Item1} {l_Index.Item2} {l_Index.Item3}");
                }

                s_CurrentLod++;
            }

            var s_ObjData = s_Writer.ToString();

            File.WriteAllText(s_Path, s_ObjData);
        }
    }
}
