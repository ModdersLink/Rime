using CommandLine;
using RimeLib.Frostbite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using fb;
using IceBloc.Export;
using IceBloc.InternalFormats;
using RimeLib;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Extensions;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite2_0.Frostbite;
using RimeLib.Serialization;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Texture;
using RimeLib.Utils;
using VertexElementUsage = fb.VertexElementUsage;

namespace EbxExtractor
{
    class Program
    {
        internal class Options
        {

            [Value(0, MetaName = "gamePath", Required = true, HelpText = "The path of the game to be whose content you want to extract.")]
            public string GamePath { get; set; } = "";

            [Value(1, MetaName = "engineType", Required = true, HelpText = "The engine type of the game.")]
            public EngineType EngineType { get; set; }
        }

        static void Main(string[] p_Args)
        {
            Parser.Default.ParseArguments<Options>(p_Args).WithParsed(p_Options =>
            {
                if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, p_Options.EngineType) ||
                    !AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, p_Options.EngineType) ||
                    !AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, p_Options.EngineType))
                {
                    Console.WriteLine("Could not load support assemblies.");
                    return;
                }
                
                DumpFiles(p_Options).Wait();
            }).WithNotParsed(p_Error =>
            {
                System.Environment.Exit(1);
            });
            
            Console.WriteLine("Hello World!");
        }
        
        public static List<InternalMesh> ConvertToInternal(MeshSetLayout p_MeshSet, IEngineMounter p_Mounter)
        {
            List<InternalMesh> meshList = new();

            // For each LOD.
            for (var i = 0; i < p_MeshSet.LodCount; i++)
            {
                var s_LodPtr = p_MeshSet.Lods[i];
                var s_Lod = s_LodPtr.Object;
                var s_LodChunkId = s_Lod.DataChunkId;

                if (!p_Mounter.TryGetChunk(s_LodChunkId, out var s_Chunk))
                    return new();

                using var s_TempLodReader = s_Chunk.FirstVariant.GetReader();
                var s_LodData = s_TempLodReader.ToArray();
                using var s_LodReader = new RimeReader(new MemoryStream(s_LodData));
                s_LodReader.Endianness = Endianness.LittleEndian;

                // For each MeshSubset.
                for (var j = 0; j < s_Lod.Subsets.Get.Length; j++)
                {
                    var sub = s_Lod.Subsets.Get[j];
                    InternalMesh mesh = new();

                    mesh.Name = sub.MaterialName.Object + "_LOD" + i;
                    mesh.IsSkinned = false; // TODO

                    var indexStartOffset = s_Lod.VertexDataSize;

                    // Start reading vertices.
                    s_LodReader.Seek(sub.VertexOffset, SeekOrigin.Begin);

                    for (int k = 0; k < sub.VertexCount; k++)
                    {
                        Vertex vert = new();

                        var posElement =
                            sub.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_Pos);
                        var norElement =
                            sub.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_Normal);
                        var uv0Element =
                            sub.GeometryDeclarationDesc.GetByUsage(VertexElementUsage.VertexElementUsage_TexCoord0);

                        var position = posElement.Read(s_LodReader, sub.VertexStride);
                        var normals = norElement == null
                            ? new Vector4()
                            : norElement.Read(s_LodReader, sub.VertexStride);
                        var texcoord = uv0Element == null
                            ? new Vector4()
                            : uv0Element.Read(s_LodReader, sub.VertexStride);

                        // We're done reading the current vertex, move up the stream.
                        s_LodReader.Seek(sub.VertexStride, SeekOrigin.Current);

                        vert.PositionX = position.X;
                        vert.PositionY = position.Y;
                        vert.PositionZ = position.Z;
                        vert.NormalX = normals.X;
                        vert.NormalY = normals.Y;
                        vert.NormalZ = normals.Z;
                        vert.TexCoordX = texcoord.X;
                        vert.TexCoordY = 1.0f - texcoord.Y;

                        mesh.Vertices.Add(vert);
                    }

                    // Read face indices.
                    s_LodReader.Seek(indexStartOffset + (sub.StartIndex * 2), SeekOrigin.Begin);

                    for (int k = 0; k < sub.PrimitiveCount; k++)
                    {
                        int a = s_LodReader.ReadUInt16();
                        int b = s_LodReader.ReadUInt16();
                        int c = s_LodReader.ReadUInt16();

                        mesh.Faces.Add((a, b, c));
                    }

                    meshList.Add(mesh);
                }
            }

            return meshList;
        }

        public static HashSet<VertexElementUsage> GetUniqueUsages(MeshSetLayout p_MeshSet)
        {
            HashSet<VertexElementUsage> meshList = new();

            // For each LOD.
            for (var i = 0; i < p_MeshSet.LodCount; i++)
            {
                var s_LodPtr = p_MeshSet.Lods[i];
                var s_Lod = s_LodPtr.Object;

                // For each MeshSubset.
                for (var j = 0; j < s_Lod.Subsets.Get.Length; j++)
                {
                    var sub = s_Lod.Subsets.Get[j];

                    for (int k = 0; k < sub.VertexCount; k++)
                    {
                        foreach (var s_Element in sub.GeometryDeclarationDesc.Elements)
                        {
                            meshList.Add(s_Element.Usage);
                        }
                    }

                }
            }

            return meshList;
        }


        private static async Task DumpFiles(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);
            
            Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true, s_Mounter.GetEngineType());
            /*await s_Mounter.MountSuperbundle("win32/levels/xp5_001/xp5_001", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks0", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks1", true);
            await s_Mounter.MountSuperbundle("Win32/Chunks2", true);
            await s_Mounter.MountSuperbundle("Win32/MpChunks", true);
            await s_Mounter.MountSuperbundle("Win32/Xp5Chunks", true);*/

            var s_MeshName = "xp2/objects/wallmodulespalace_01/floorpalace_09_mesh";
            var s_TextureName = "Architecture/TexturesShared/MarbleDarkFloor01";
            var s_TextureVariants = new[] { "d", "n" };

            var s_ShaderName = "Systems/ShaderProgramDb";

            if (!s_Mounter.TryGetResource(s_ShaderName, out var s_ShaderResource))
                return;
            
            using var s_ShaderProgramDbReader = s_ShaderResource.FirstVariant.GetReader();
            var s_ShaderProgramDbCtr = new ShaderProgramDatabaseContainer(s_ShaderProgramDbReader);
            
            if (!s_ShaderProgramDbCtr.TryGetDatabase(ShaderRenderPath.ShaderRenderPath_Dx11, out var s_ShaderProgramDb))
                return;

            var s_ShortName = s_MeshName.Split("/").Last();
            
            if (!s_Mounter.TryGetResource(s_MeshName,
                    out var s_Resource))
                return;

            if (!s_Mounter.TryGetPartition("Animations/Skeletons/VeniceAntSke01", out var s_SkeletonPartitionObj))
                return;

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
            var s_SkeletonPartition = s_Converter.FromPartitionObject("Animations/Skeletons/VeniceAntSke01", s_SkeletonPartitionObj.FirstVariant);
            var s_Asset = s_SkeletonPartition.PrimaryInstance as SkeletonAsset;
            
            using var s_MeshReader = s_Resource.FirstVariant.GetReader();
            var s_MeshData = s_MeshReader.ToArray();
            using var s_TempMeshReader = new RimeReader(new MemoryStream(s_MeshData));
            var s_MeshSet = new MeshSetLayout(s_TempMeshReader);

            var s_ConvertedMeshes = ConvertToInternal(s_MeshSet, s_Mounter);
            for (int i = 0; i < s_ConvertedMeshes.Count; ++i)
            {
                ModelExporterOBJ.Export(s_ConvertedMeshes[i], $@"C:\Users\Orfeas\home\scratch\rime-shit\{s_ShortName}-{i}");
            }

            var s_TextureConverter = EngineInterfaceRegistry.Create<ITextureConverter>(p_Options.EngineType);

            foreach (var s_Variant in s_TextureVariants)
            {
                if (!s_Mounter.TryGetResource($"{s_TextureName}_{s_Variant}", out var s_TextureResource))
                    return;

                using var s_TextureWriter =
                    new RimeWriter(File.Create($@"C:\Users\Orfeas\home\scratch\rime-shit\{s_ShortName}-{s_Variant}.dds"));
                s_TextureConverter.ConvertToDDS(s_TextureResource.FirstVariant, s_Mounter, s_TextureWriter);

            }
         
            Console.WriteLine($"{s_Asset} {s_MeshSet}");
        }
        
        private static async Task GetUsages(Options p_Options)
        {
            var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(p_Options.EngineType);
            
            Console.WriteLine($"Mounting game with engine '{p_Options.EngineType}' at path '{p_Options.GamePath}'. Please wait, this could take a while.");

            await s_Mounter.Mount(p_Options.GamePath, true, s_Mounter.GetEngineType());

            var s_Usages = new HashSet<VertexElementUsage>();

            Parallel.ForEach(s_Mounter.GetResources(), (kvp) =>
            {
                var s_Resource = kvp.Value;
                
                if (s_Resource.FirstVariant.GetResourceType() != ResourceType.MeshSet)
                    return;

                using var s_MeshReader = s_Resource.FirstVariant.GetReader();
                var s_MeshData = s_MeshReader.ToArray();
                using var s_TempMeshReader = new RimeReader(new MemoryStream(s_MeshData));
                var s_MeshSet = new MeshSetLayout(s_TempMeshReader);

                var s_UsagesForThis = GetUniqueUsages(s_MeshSet);

                if (s_UsagesForThis.Contains(VertexElementUsage.VertexElementUsage_RadiosityTexCoord))
                {
                    Console.WriteLine($"Some mesh: {kvp.Key}");
                }
                
                lock (s_Usages)
                {
                    s_Usages.UnionWith(s_UsagesForThis);
                }
            });
            
            Console.WriteLine($"Whatever {s_Usages}");
        }
    }
}
