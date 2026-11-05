using System.IO;
using System.Linq;
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
            var s_Rules = Require<IMeshVariationRules>(s_Mounter.GetEngineType(), p_Writer);
            if (s_Rules == null)
                return false;

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

            // Redirect entries alias the mesh's variation-0 entry and list no materials.
            var s_Rows = s_Rules.ReadEntries(s_Db).Select(p_E => (p_E.Mesh, p_E.VariationHash, Materials: s_Rules.GetMaterials(p_E.Entry).Count))
                .Concat(s_Rules.ReadRedirects(s_Db).Select(p_R => (p_R.Mesh, p_R.VariationHash, Materials: 0)));

            foreach (var (s_Mesh, s_Hash, s_MaterialCount) in s_Rows)
            {
                if (!s_Mounter.TryGetPartitionByGuid(s_Mesh.PartitionGuid, out var s_MeshName, out _) || s_MeshName == null) continue;
                if (!s_MeshName.ToLowerInvariant().Contains(s_Needle)) continue;

                s_Matched++;
                p_Writer.WriteLine($"MVDBVAR: mesh={s_MeshName} variationHash={s_Hash} " +
                                   $"(0x{s_Hash:X8}) materials={s_MaterialCount}");
            }

            p_Writer.WriteLine($"MVDBVAR-DONE: {Name} '{Mesh}' matched={s_Matched}");
            return true;
        }
    }
}
