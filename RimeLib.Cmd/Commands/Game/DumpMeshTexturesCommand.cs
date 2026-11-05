using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using Newtonsoft.Json;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes which textures a level's meshes actually use, as JSON.
    ///
    /// A MeshMaterial in a mesh's own partition names a shader but usually carries no texture
    /// parameters -- in Frostbite the bindings live in the level's MeshVariationDatabase, one entry
    /// per mesh, one material per subset, each with its own texture parameters. So this is the only
    /// place to learn that a given mesh subset is painted with a given texture resource.
    /// </summary>
    [CommandDescription("Dumps mesh -> material -> texture resource bindings from a MeshVariationDatabase, as JSON.")]
    public class DumpMeshTexturesCommand : Command
    {
        [CommandArgument(Description = "The MVDB resource name, e.g. levels/mp_001/mp_001/meshvariationdb_win32")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_mesh_textures <mvdb-resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Rules = Require<IMeshVariationRules>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Rules == null)
                return false;

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());

            // A CtrRef resolves through the PartitionRegistry, and nothing here filled it.
            //
            // So s_Material.Material.Get() returned null for EVERY material, its texture parameters
            // were never read, and each subset came out empty -- indistinguishable from a mesh with
            // no textures. Consumers then fall back to picking a texture by filename, which is how
            // BF3's crane ended up painted with its own alpha MASK (CraneAlphaMask_D wins a "_d
            // means diffuse" guess) and wearing a shop's logo on another subset.
            //
            // Populated BEFORE the MVDB is converted, deliberately: parsing partitions while
            // iterating a converted one closes the shared stream out from under it (see
            // MeshVariationDbAddEntryCommand). Same guard LevelMeshConverter.WalkLevel uses.
            if (!PartitionRegistry.Partitions.Any())
                PartitionRegistry.ParseAndRegisterAllPartitions(s_Mounter);

            if (!s_Mounter.TryGetPartition(Name!, out var s_SrcMounted))
            {
                p_Writer.WriteLine($"Could not find MVDB partition ({Name}).");
                return false;
            }

            var s_Variant = s_SrcMounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null) ?? s_SrcMounted.FirstVariant;
            var s_Db = s_Converter.FromPartitionObject(Name!, s_Variant!);

            // mesh -> variation hash -> material index -> parameter -> texture resource.
            //
            // Every variation is kept, not just the base. An object placed with a variation (a
            // camo, a dirty version, a damaged one) is painted from THAT entry's textures, and
            // collapsing them to the base both loses those textures and paints the object wrong.
            var s_Meshes = new Dictionary<string, Dictionary<string, List<Dictionary<string, string>>>>();

            foreach (var (s_Mesh, s_Hash, s_Entry) in s_Rules.ReadEntries(s_Db))
            {
                // An entry whose mesh partition does not resolve is kept under its guid, so anything
                // not backed by a mesh partition (terrain among the candidates) still shows up.
                if (!s_Mounter.TryGetPartitionByGuid(s_Mesh.PartitionGuid, out var s_MeshName, out _) || s_MeshName == null)
                    s_MeshName = "unresolved:" + s_Mesh.PartitionGuid;

                var s_Materials = new List<Dictionary<string, string>>();

                foreach (var s_Material in s_Rules.GetMaterials(s_Entry))
                {
                    var s_Textures = new Dictionary<string, string>();

                    // Where the material lives, whether or not it resolves here: a material that
                    // does not load in this context still names its partition, and an entry with no
                    // texture parameters of its own is often bound through that material.
                    if (s_Mounter.TryGetPartitionByGuid(s_Material.Material.PartitionGuid, out var s_MatPartition, out _) &&
                        s_MatPartition != null)
                        s_Textures["$material"] = s_MatPartition;

                    var s_MeshMaterial = s_Material.Material.Get() is { } s_MaterialInstance
                        ? s_Rules.GetShaderInstance(s_MaterialInstance)
                        : null;

                    if (s_MeshMaterial == null)
                    {
                        s_Textures["$materialUnresolved"] = "1";
                    }
                    else
                    {
                        // The shader this material instances, by name. Many material slots carry no
                        // texture parameter anywhere in EBX: their bindings are the compiled shader's
                        // StreamableTextures, which dump_shader_textures reads, and the name joins the
                        // two dumps.
                        AddShader(s_Mounter, s_MeshMaterial, s_Textures);
                    }

                    AddTextures(s_Mounter, s_Material.Textures, s_Textures);

                    // The variation is what an object placed with a camo, a dirty pass or a damaged
                    // state is painted from. Last, so where it names a shader or texture, that wins.
                    if (s_Material.MaterialVariation.Get() is { } s_VariationInstance &&
                        s_Rules.GetShaderInstance(s_VariationInstance) is { } s_Variation)
                        AddShader(s_Mounter, s_Variation, s_Textures);

                    // Colour parameters, for a material that binds no texture at all: wire lights,
                    // glow strips and similar are drawn from a shader constant, so the colour is the
                    // material. Prefixed so a consumer cannot mistake a colour for a texture.
                    foreach (var (s_Name, s_Value) in s_MeshMaterial?.Vectors ?? new List<(string Name, Vector4 Value)>())
                    {
                        if (string.IsNullOrWhiteSpace(s_Name))
                            continue;

                        s_Textures["$vec:" + s_Name] = $"{s_Value.X},{s_Value.Y},{s_Value.Z},{s_Value.W}";
                    }

                    s_Materials.Add(s_Textures);
                }

                if (!s_Meshes.TryGetValue(s_MeshName, out var s_Variations))
                {
                    s_Variations = new Dictionary<string, List<Dictionary<string, string>>>();
                    s_Meshes[s_MeshName] = s_Variations;
                }

                s_Variations[s_Hash.ToString()] = s_Materials;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { meshes = s_Meshes }));
            p_Writer.WriteLine($"Mesh textures for {Name} written to {Destination.FullName} ({s_Meshes.Count} meshes).");

            return true;
        }

        private static void AddShader(IEngineMounter p_Mounter, ShaderInstanceModel p_Shader, Dictionary<string, string> p_Textures)
        {
            if (p_Mounter.TryGetPartitionByGuid(p_Shader.Shader.PartitionGuid, out var s_ShaderName, out _) && s_ShaderName != null)
                p_Textures["$shader"] = s_ShaderName;

            AddTextures(p_Mounter, p_Shader.Textures, p_Textures);
        }

        /// <summary>
        /// Adds each texture by parameter name. A binding that does not resolve is reported with its
        /// guid rather than dropped, so a subset never looks like one without textures.
        /// </summary>
        private static void AddTextures(IEngineMounter p_Mounter, IEnumerable<(string Name, CtrRefBase Texture)> p_Parameters, Dictionary<string, string> p_Textures)
        {
            foreach (var (s_Name, s_Texture) in p_Parameters)
            {
                if (!p_Mounter.TryGetPartitionByGuid(s_Texture.PartitionGuid, out var s_TextureName, out _) || s_TextureName == null)
                {
                    p_Textures["$unresolved:" + s_Name] = s_Texture.PartitionGuid.ToString();
                    continue;
                }

                p_Textures[s_Name] = s_TextureName;
            }
        }
    }
}
