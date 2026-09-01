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

                foreach (var s_Material in s_Entry.Materials)
                {
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
                                continue;

                            s_Textures[s_Parameter.ParameterName] = s_OwnName;
                        }
                    }

                    foreach (var s_Parameter in s_Material.TextureParameters)
                    {
                        if (!s_Mounter.TryGetPartitionByGuid(s_Parameter.Value.PartitionGuid, out var s_TextureName, out _) ||
                            s_TextureName == null)
                            continue;

                        s_Textures[s_Parameter.ParameterName] = s_TextureName;
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
