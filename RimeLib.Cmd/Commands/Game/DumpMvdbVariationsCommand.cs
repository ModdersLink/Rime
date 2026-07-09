using System.IO;
using System.Linq;
using fb;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the MeshVariationDatabase entries for meshes matching a filter: mesh name + " +
                        "VariationAssetNameHash + material count. Use to find a vehicle's CAMO variation hash " +
                        "(0 = base/grey; a non-zero VariationAssetNameHash = a variation like camo) to pass as " +
                        "EntityCreationParams.variationNameHash at spawn.")]
    public class DumpMvdbVariationsCommand : Command
    {
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

            var s_Variant = s_SrcMounted.Variants.FirstOrDefault(v => v.GetContainedBundle() != null) ?? s_SrcMounted.FirstVariant;
            var s_Db = s_Converter.FromPartitionObject(Name!, s_Variant!);

            var s_Needle = Mesh!.ToLowerInvariant();
            int s_Matched = 0;

            foreach (var s_Inst in s_Db.Instances)
            {
                if (s_Inst is not MeshVariationDatabaseEntry s_E) continue;
                if (!s_Mounter.TryGetPartitionByGuid(s_E.Mesh.PartitionGuid, out var s_MName, out _) || s_MName == null) continue;
                if (!s_MName.ToLowerInvariant().Contains(s_Needle)) continue;
                s_Matched++;
                p_Writer.WriteLine($"MVDBVAR: mesh={s_MName} variationHash={s_E.VariationAssetNameHash} " +
                                   $"(0x{s_E.VariationAssetNameHash:X8}) materials={s_E.Materials.Count}");
            }

            p_Writer.WriteLine($"MVDBVAR-DONE: {Name} '{Mesh}' matched={s_Matched}");
            return true;
        }
    }
}
