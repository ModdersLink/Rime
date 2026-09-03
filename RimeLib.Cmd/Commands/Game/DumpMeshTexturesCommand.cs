using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using fb;
using Newtonsoft.Json;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
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

            foreach (var s_Instance in s_Db.Instances)
            {
                if (s_Instance is not MeshVariationDatabaseEntry s_Entry)
                    continue;

                // An entry whose mesh partition does not resolve was being dropped silently. Keep
                // it under its guid instead: anything not backed by a mesh partition -- terrain
                // among the candidates -- would otherwise be invisible in this dump.
                if (!s_Mounter.TryGetPartitionByGuid(s_Entry.Mesh.PartitionGuid, out var s_MeshName, out _) || s_MeshName == null)
                    s_MeshName = "unresolved:" + s_Entry.Mesh.PartitionGuid;


                var s_Materials = new List<Dictionary<string, string>>();

                // The MESH's own materials, which nothing here read.
                //
                // A MeshAsset carries RefArray<MeshMaterial> Materials, one per subset, and each
                // has its own shader instance with TextureParameters. Where the MVDB entry's
                // material carries none -- which is most of them -- this is where the binding
                // actually is. It only resolves now because the PartitionRegistry is populated;
                // before that .Get() returned null everywhere and this was invisible.
                var s_MeshAsset = s_Entry.Mesh.Get();
                var s_Index = -1;

                foreach (var s_Material in s_Entry.Materials)
                {
                    s_Index++;
                    var s_Textures = new Dictionary<string, string>();

                    // An entry with no texture parameters is not an untextured surface: the
                    // binding can sit on the MESH MATERIAL, whose own shader instance carries the
                    // parameters. That material is frequently a shared partition rather than the
                    // mesh's own, which is why nothing in the mesh's EBX shows it.
                    // Where the material lives, whether or not it resolves here. A material that
                    // does not load in this context still names its partition, and that is the only
                    // thread left to pull when an entry carries no parameters of its own.
                    if (s_Mounter.TryGetPartitionByGuid(s_Material.Material.PartitionGuid, out var s_MatPartition, out _) &&
                        s_MatPartition != null)
                        s_Textures["$material"] = s_MatPartition;

                    var s_MeshMaterial = s_Material.Material.Get();

                    if (s_MeshMaterial == null)
                        s_Textures["$materialUnresolved"] = "1";

                    if (s_MeshMaterial != null)
                    {
                        foreach (var s_Parameter in s_MeshMaterial.Shader.TextureParameters)
                        {
                            if (!s_Mounter.TryGetPartitionByGuid(s_Parameter.Value.PartitionGuid,
                                    out var s_OwnName, out _) || s_OwnName == null)
                            {
                                // Say the binding EXISTS but did not resolve, rather than dropping
                                // it. A skipped parameter leaves a subset looking identical to one
                                // with no textures at all, and consumers then guess a texture by
                                // filename -- which is how BF3's crane ended up painted with its
                                // own alpha MASK (CraneAlphaMask_D wins a "_d means diffuse" guess)
                                // and wearing a shop's logo on another subset. The guid is enough
                                // for a consumer to resolve it another way, or to report the gap.
                                s_Textures["$unresolved:" + s_Parameter.ParameterName] =
                                    s_Parameter.Value.PartitionGuid.ToString();
                                continue;
                            }

                            s_Textures[s_Parameter.ParameterName] = s_OwnName;
                        }
                    }

                    foreach (var s_Parameter in s_Material.TextureParameters)
                    {
                        if (!s_Mounter.TryGetPartitionByGuid(s_Parameter.Value.PartitionGuid, out var s_TextureName, out _) ||
                            s_TextureName == null)
                        {
                            // Same as above: an unresolved binding is reported, never dropped.
                            s_Textures["$unresolved:" + s_Parameter.ParameterName] =
                                s_Parameter.Value.PartitionGuid.ToString();
                            continue;
                        }

                        s_Textures[s_Parameter.ParameterName] = s_TextureName;
                    }

                    // The VARIATION's own shader, which nothing here read.
                    //
                    // A MeshVariationDatabaseMaterial carries two refs: the base Material and a
                    // MaterialVariation. The variation is what an object placed with a camo, a
                    // dirty pass or a damaged state is actually painted from, and its
                    // SurfaceShaderInstanceDataStruct carries its own TextureParameters. Reading
                    // only the base left every one of those subsets looking unbound, which sent
                    // them to the shader fallback and its filename guess.
                    //
                    // Last, so it WINS: where a variation names a texture, that is the one the
                    // object is drawn with.
                    var s_Variation = s_Material.MaterialVariation.Get();

                    if (s_Variation != null)
                    {
                        foreach (var s_Parameter in s_Variation.Shader.TextureParameters)
                        {
                            if (!s_Mounter.TryGetPartitionByGuid(s_Parameter.Value.PartitionGuid,
                                    out var s_VarName, out _) || s_VarName == null)
                            {
                                s_Textures["$unresolved:" + s_Parameter.ParameterName] =
                                    s_Parameter.Value.PartitionGuid.ToString();
                                continue;
                            }

                            s_Textures[s_Parameter.ParameterName] = s_VarName;
                        }
                    }

                    // Colour parameters, for a material that binds no texture at all.
                    //
                    // That is not an unpainted surface: BF3's wire lights, glow strips and similar
                    // are drawn from a shader constant, so the colour IS the material. Dropping
                    // these left them rendering as flat white geometry with nothing to explain it.
                    // Prefixed so a consumer cannot mistake a colour for a texture.
                    foreach (var s_Vector in s_Material.Material.Get()?.Shader.VectorParameters
                                             ?? new System.Collections.Generic.List<fb.VectorShaderParameter>())
                    {
                        if (string.IsNullOrWhiteSpace(s_Vector.ParameterName))
                            continue;

                        s_Textures["$vec:" + s_Vector.ParameterName] =
                            $"{s_Vector.Value.x},{s_Vector.Value.y},{s_Vector.Value.z},{s_Vector.Value.w}";
                    }

                    s_Materials.Add(s_Textures);
                }

                if (!s_Meshes.TryGetValue(s_MeshName, out var s_Variations))
                {
                    s_Variations = new Dictionary<string, List<Dictionary<string, string>>>();
                    s_Meshes[s_MeshName] = s_Variations;
                }

                s_Variations[s_Entry.VariationAssetNameHash.ToString()] = s_Materials;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { meshes = s_Meshes }));
            p_Writer.WriteLine($"Mesh textures for {Name} written to {Destination.FullName} ({s_Meshes.Count} meshes).");

            return true;
        }
    }
}
