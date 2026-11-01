using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Derives a level partition's mesh variation database and compares it with the shipped one. The
    /// keys (mesh, variation) come from the content the level reaches; what an entry binds comes from
    /// the pool of every mesh variation database in the mounted game, since mesh materials don't
    /// carry their textures in the shipped data.
    /// </summary>
    [CommandDescription("Derives the mesh variation database of a level partition from its content and the game's other databases, and compares it with the shipped one.")]
    public class DeriveMeshVariationDbCommand : Command
    {
        [CommandArgument(Description = "The level partition, e.g. levels/mp_subway/rush.")]
        public string? Partition { get; set; }

        [CommandArgument(Description = "Where to write the JSON report.", Optional = true)]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Description = "The database to compare with. Default: <partition>/meshvariationdb_win32.", Optional = true)]
        public string? Database { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Partition))
            {
                p_Writer.WriteLine("usage: derive_mvdb <partition> [destination.json] [database]");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();
            var s_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(s_Mounter.GetEngineType());
            var s_Root = Partition!.ToLowerInvariant();
            var s_DatabaseName = (Database ?? $"{s_Root}/meshvariationdb_win32").ToLowerInvariant();
            var s_Deriver = new RegistryDeriver(s_Mounter);
            var s_MeshDeriver = new MeshVariationDeriver(s_Deriver);
            var s_Pool = s_MeshDeriver.Pool;
            p_Writer.WriteLine($"Pool: {s_MeshDeriver.PoolDatabases} databases, {s_Pool.Count} keys, {s_Pool.Count(p_P => p_P.Value.Select(p_E => p_E.Fingerprint).Distinct().Count() > 1)} bound differently in different databases.");

            if (s_Deriver.Parse(s_DatabaseName) is not { } s_Shipped)
            {
                p_Writer.WriteLine($"No database named '{s_DatabaseName}'.");
                return false;
            }

            var s_ShippedEntries = s_Rules.ReadEntries(s_Shipped).Select(p_E => (Key: (s_Deriver.Key(p_E.Mesh.PartitionGuid, p_E.Mesh.InstanceId), p_E.VariationHash), Fingerprint: s_Rules.Fingerprint(p_E.Entry))).ToList();
            var s_Redirects = s_Rules.ReadRedirects(s_Shipped).ToList();

            var s_Result = s_MeshDeriver.Derive(s_Root, s_Mounter.GetPartitionsInBundle(s_Deriver.Rules.GetLevelBundles(s_Root).First()), p_Writer);
            var s_Derived = s_Result.Keys;
            var s_Closure = s_Result.Closure;
            var s_Meshes = s_Result.PlainMeshes;
            var s_Variations = s_Result.Variations;
            var s_ByKey = s_Deriver.ReachedContent(s_Closure, true, null, null).GroupBy(p_I => s_Deriver.Key(p_I.Partition!.PartitionGuid, p_I.InstanceId)).ToDictionary(p_G => p_G.Key, p_G => p_G.First());

            var s_ShippedKeys = s_ShippedEntries.Select(p_E => p_E.Key).ToHashSet();
            var s_Missing = s_ShippedKeys.Where(p_K => !s_Derived.Contains(p_K)).ToList();
            var s_Extra = s_Derived.Where(p_K => !s_ShippedKeys.Contains(p_K)).ToList();

            // Whether the shipped entries bind what the pool binds for their key.
            var s_SameAsPool = s_ShippedEntries.Count(p_E => s_Pool.TryGetValue(p_E.Key, out var s_List) && s_List.All(p_O => p_O.Fingerprint == p_E.Fingerprint));
            var s_PoolMeshes = s_Pool.Keys.Select(p_K => p_K.Mesh).ToHashSet();
            var s_MeshesWithoutEntry = s_Meshes.Count(p_M => !s_PoolMeshes.Contains(p_M));

            p_Writer.WriteLine($"{s_Root}: closure of {s_Closure.Partitions.Count} partitions; {s_Meshes.Count} meshes and {s_Variations.Count - 1} variations reached; {s_MeshesWithoutEntry} meshes no database binds.");
            p_Writer.WriteLine($"--- {s_DatabaseName}: shipped {s_ShippedEntries.Count} entries ({s_ShippedKeys.Count} keys) and {s_Redirects.Count} redirects, derived {s_Derived.Count}, matching {s_ShippedKeys.Count(s_Derived.Contains)}");
            p_Writer.WriteLine($"    shipped entries binding exactly what every other database binds for their key: {s_SameAsPool}");
            WriteGroups(p_Writer, "missing", s_Missing, s_Deriver, s_Meshes, s_Variations);
            WriteGroups(p_Writer, "extra", s_Extra, s_Deriver, s_Meshes, s_Variations);

            if (Destination != null)
            {
                object Describe((string Mesh, uint Hash) p_Key) => new
                {
                    Mesh = s_Deriver.PartitionName(p_Key.Mesh),
                    p_Key.Hash,
                    MeshReached = s_Meshes.Contains(p_Key.Mesh),
                    VariationReached = s_Variations.Contains(p_Key.Hash),
                    MeshReferencedBy = s_Deriver.ReferencedBy.GetValueOrDefault(p_Key.Mesh)?.Take(5),
                    Pool = s_Pool.GetValueOrDefault(p_Key)?.Select(p_E => p_E.Database).Distinct().Take(5),
                    Bundles = s_Deriver.PartitionName(p_Key.Mesh) is { } s_Name && s_Mounter.TryGetPartition(s_Name, out var s_P) ? s_P.Variants.Select(p_V => p_V.GetContainedBundle()).ToList() : null,
                    Referrers = s_Deriver.ReferrersOf(p_Key.Mesh).Take(4).Select(p_R => s_ByKey.TryGetValue(p_R, out var s_R) ? s_R.GetType().Name : "(not reached)"),
                };

                File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new
                {
                    Partition = s_Root,
                    Database = s_DatabaseName,
                    Missing = s_Missing.Select(Describe),
                    Extra = s_Extra.Select(Describe),
                    Redirects = s_Redirects.Select(p_R => new { Mesh = s_Deriver.PartitionName(s_Deriver.Key(p_R.Mesh.PartitionGuid, p_R.Mesh.InstanceId)), Hash = p_R.VariationHash }),
                }, Formatting.Indented));
                p_Writer.WriteLine($"Report written to {Destination.FullName}.");
            }

            return true;
        }

        private static void WriteGroups(TextWriter p_Writer, string p_Label, List<(string Mesh, uint Hash)> p_Keys, RegistryDeriver p_Deriver,
            HashSet<string> p_Meshes, HashSet<uint> p_Variations)
        {
            if (p_Keys.Count == 0)
                return;

            p_Writer.WriteLine($"    {p_Label}: {p_Keys.Count}");
            foreach (var s_Group in p_Keys.GroupBy(p_K => (p_K.Hash == 0 ? "base" : "variation") +
                                                          (p_Meshes.Contains(p_K.Mesh) ? ", mesh reached" : ", mesh not reached") +
                                                          (p_K.Hash == 0 ? "" : p_Variations.Contains(p_K.Hash) ? ", variation reached" : ", variation not reached"))
                         .OrderByDescending(p_G => p_G.Count()))
            {
                var s_Examples = s_Group.Select(p_K => p_Deriver.PartitionName(p_K.Mesh)).Distinct().Take(4);
                p_Writer.WriteLine($"      {s_Group.Key,-55} {s_Group.Count(),5}  e.g. {string.Join(", ", s_Examples)}");
            }
        }
    }
}
