using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Checks that each mesh the mounted bundles ship has an entry in a mesh variation database of
    /// those bundles: the game draws a mesh only through its variation set. A mesh placed only with
    /// object variations has entries for those alone.
    /// </summary>
    [CommandDescription("Lists the meshes of the mounted bundles without an entry in a mesh variation database of those bundles.")]
    public class CheckMeshVariationsCommand : Command
    {
        [CommandArgument(Description = "Prefix of the bundles whose meshes and databases to check, e.g. win32/levels/mp_prison/.")]
        public string Bundles { get; set; } = "";

        [CommandArgument(Description = "How many meshes without an entry to list.", Optional = true)]
        public int List { get; set; } = 30;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Mounter.GetEngineType());
            var s_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(s_Mounter.GetEngineType());
            var s_Bundles = s_Mounter.GetMountedBundles().Where(p_B => p_B.StartsWith(Bundles, StringComparison.OrdinalIgnoreCase)).ToList();

            var s_Plain = new HashSet<GUID>();
            var s_Varied = new HashSet<GUID>();
            var s_Databases = 0;
            foreach (var s_Name in s_Bundles.SelectMany(s_Mounter.GetPartitionsInBundle).Distinct(StringComparer.OrdinalIgnoreCase)
                         .Where(p_N => p_N.Contains("meshvariationdb", StringComparison.OrdinalIgnoreCase)))
            {
                if (!s_Mounter.TryGetPartition(s_Name.ToLowerInvariant(), out var s_Partition))
                    continue;

                var s_Database = s_Converter.FromPartitionObject(s_Name, s_Partition.FirstVariant);
                ++s_Databases;
                foreach (var (s_Mesh, s_Hash, _) in s_Rules.ReadEntries(s_Database))
                    (s_Hash == 0 ? s_Plain : s_Varied).Add(s_Mesh.PartitionGuid);
            }

            // Each mesh with the first bundle that ships it.
            var s_Meshes = s_Bundles.SelectMany(p_B => s_Mounter.GetResourcesInBundle(p_B).Where(p_R => p_R.ResourceType == ResourceType.MeshSet).Select(p_R => (Mesh: p_R.Item1, Bundle: p_B)))
                .DistinctBy(p_M => p_M.Mesh, StringComparer.OrdinalIgnoreCase).ToList();
            var s_Missing = new List<string>();
            var s_OnlyVaried = 0;
            foreach (var (s_Mesh, s_Bundle) in s_Meshes)
            {
                if (!s_Mounter.TryGetPartition(s_Mesh.ToLowerInvariant(), out var s_Partition))
                    continue;

                var s_Guid = s_Converter.FromPartitionObject(s_Mesh, s_Partition.FirstVariant).PartitionGuid;
                if (s_Plain.Contains(s_Guid))
                    continue;
                if (s_Varied.Contains(s_Guid))
                    ++s_OnlyVaried;
                else
                    s_Missing.Add($"{s_Mesh} in {s_Bundle}");
            }

            foreach (var s_Group in s_Missing.GroupBy(p_M => p_M.Split('/')[0], StringComparer.OrdinalIgnoreCase).OrderByDescending(p_G => p_G.Count()))
                p_Writer.WriteLine($"  {s_Group.Count(),5} without an entry under {s_Group.Key}/");
            foreach (var s_Mesh in s_Missing.Order(StringComparer.OrdinalIgnoreCase).Take(List))
                p_Writer.WriteLine($"  no entry: {s_Mesh}");

            p_Writer.WriteLine($"check_mesh_variations: {s_Meshes.Count} mesh(es) in {s_Bundles.Count} bundle(s), {s_Databases} database(s); {s_Missing.Count} without an entry, {s_OnlyVaried} with entries for variations only.");
            return true;
        }
    }
}
