using System.IO;
using System.Linq;
using fb;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the MVDB entries for meshes matching a filter: mesh name, VariationAssetNameHash and material count. Hash 0 is the base appearance.")]
    public class DumpMeshVariationDbVariationsCommand : Command
    {
        // A non-zero VariationAssetNameHash names an appearance such as a camo. Pass the one you want
        // as EntityCreationParams.variationNameHash when spawning the vehicle.
        [CommandArgument(Description = "The MVDB resource name, e.g. levels/mp_017/r/meshvariationdb_win32")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Mesh name substring, e.g. 9k22_tunguska_m_mesh")]
        public string? Mesh { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Mesh))
            {
                p_Writer.WriteLine("Usage: dump_mvdb_variations <mvdb-resource> <mesh-substring>");
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

            var s_Needle = Mesh!.ToLowerInvariant();
            var s_Matched = 0;

            foreach (var s_Instance in s_Db.Instances)
            {
                if (s_Instance is not MeshVariationDatabaseEntry s_Entry) continue;
                if (!s_Mounter.TryGetPartitionByGuid(s_Entry.Mesh.PartitionGuid, out var s_MeshName, out _) || s_MeshName == null) continue;
                if (!s_MeshName.ToLowerInvariant().Contains(s_Needle)) continue;

                s_Matched++;
                p_Writer.WriteLine($"MVDBVAR: mesh={s_MeshName} variationHash={s_Entry.VariationAssetNameHash} " +
                                   $"(0x{s_Entry.VariationAssetNameHash:X8}) materials={s_Entry.Materials.Count}");
            }

            p_Writer.WriteLine($"MVDBVAR-DONE: {Name} '{Mesh}' matched={s_Matched}");
            return true;
        }
    }
}
