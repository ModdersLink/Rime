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

            // mesh -> material index -> parameter -> texture resource
            var s_Meshes = new Dictionary<string, List<Dictionary<string, string>>>();
            var s_Base = new HashSet<string>();

            foreach (var s_Instance in s_Db.Instances)
            {
                if (s_Instance is not MeshVariationDatabaseEntry s_Entry)
                    continue;

                // An entry whose mesh partition does not resolve was being dropped silently. Keep
                // it under its guid instead: anything not backed by a mesh partition -- terrain
                // among the candidates -- would otherwise be invisible in this dump.
                if (!s_Mounter.TryGetPartitionByGuid(s_Entry.Mesh.PartitionGuid, out var s_MeshName, out _) || s_MeshName == null)
                    s_MeshName = "unresolved:" + s_Entry.Mesh.PartitionGuid;

                // Hash 0 is the base appearance and is what we want when it exists -- but plenty of
                // meshes (the destruction variants especially) appear ONLY under a variation hash,
                // and dropping those left them with no textures at all. Take a variation when the
                // base is absent, and let the base overwrite it if it turns up later.
                var s_IsBase = s_Entry.VariationAssetNameHash == 0;

                if (!s_IsBase && s_Meshes.ContainsKey(s_MeshName))
                    continue;

                if (s_IsBase && s_Base.Contains(s_MeshName))
                    continue;

                if (s_IsBase)
                    s_Base.Add(s_MeshName);

                var s_Materials = new List<Dictionary<string, string>>();

                foreach (var s_Material in s_Entry.Materials)
                {
                    var s_Textures = new Dictionary<string, string>();

                    foreach (var s_Parameter in s_Material.TextureParameters)
                    {
                        if (!s_Mounter.TryGetPartitionByGuid(s_Parameter.Value.PartitionGuid, out var s_TextureName, out _) ||
                            s_TextureName == null)
                            continue;

                        s_Textures[s_Parameter.ParameterName] = s_TextureName;
                    }

                    s_Materials.Add(s_Textures);
                }

                s_Meshes[s_MeshName] = s_Materials;
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { meshes = s_Meshes }));
            p_Writer.WriteLine($"Mesh textures for {Name} written to {Destination.FullName} ({s_Meshes.Count} meshes).");

            return true;
        }
    }
}
