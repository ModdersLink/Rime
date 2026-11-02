using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Derives the keys (mesh, variation hash) of a level partition's mesh variation database from
    /// the content it reaches, and takes their entries from the pool of every database in the
    /// mounted game: mesh materials don't carry their textures in shipped data, and every key binds
    /// the same thing in every database that has it.
    /// </summary>
    internal class MeshVariationDeriver
    {
        private readonly RegistryDeriver m_Deriver;
        private readonly IMeshVariationRules m_Rules;
        private Dictionary<(string Mesh, uint Hash), List<(string Database, string Fingerprint, object Entry)>>? m_Pool;

        public MeshVariationDeriver(RegistryDeriver p_Deriver)
        {
            m_Deriver = p_Deriver;
            m_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(p_Deriver.Mounter.GetEngineType());
        }

        public IMeshVariationRules Rules => m_Rules;

        public int PoolDatabases { get; private set; }

        /// <summary>Every entry of every mesh variation database in the mounted game, by key.</summary>
        public Dictionary<(string Mesh, uint Hash), List<(string Database, string Fingerprint, object Entry)>> Pool
        {
            get
            {
                if (m_Pool != null)
                    return m_Pool;

                // The mounted databases don't change, so they are read once per mounted game; each
                // deriver still registers the keys it hands out.
                var s_Mounted = s_MountedPools.GetValue(m_Deriver.Mounter, _ => ReadMountedPool());
                m_Pool = new();
                foreach (var s_Item in s_Mounted.Entries)
                {
                    var s_Key = (m_Deriver.Key(s_Item.MeshPartition, s_Item.MeshInstance), s_Item.Hash);
                    if (!m_Pool.TryGetValue(s_Key, out var s_List))
                        m_Pool[s_Key] = s_List = new();
                    s_List.Add((s_Item.Database, s_Item.Fingerprint, s_Item.Entry));
                }
                PoolDatabases = s_Mounted.Databases;

                return m_Pool;
            }
        }

        private sealed record MountedPool(int Databases, List<(GUID MeshPartition, DataContainerId MeshInstance, uint Hash, string Database, string Fingerprint, object Entry)> Entries);

        private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<IEngineMounter, MountedPool> s_MountedPools = new();

        private MountedPool ReadMountedPool()
        {
            var s_Databases = 0;
            var s_Entries = new List<(GUID, DataContainerId, uint, string, string, object)>();
            foreach (var s_Name in m_Deriver.Mounter.GetPartitions().Keys.Where(p_N => p_N.EndsWith("meshvariationdb_win32", StringComparison.OrdinalIgnoreCase)))
            {
                var s_Lower = s_Name.ToLowerInvariant();
                if (!m_Deriver.Mounter.TryGetPartition(s_Lower, out var s_Mounted) || Parse(s_Lower, s_Mounted.FirstVariant) is not { } s_Parsed)
                    continue;

                ++s_Databases;
                foreach (var (s_Mesh, s_Hash, s_Entry) in m_Rules.ReadEntries(s_Parsed))
                    s_Entries.Add((s_Mesh.PartitionGuid, s_Mesh.InstanceId, s_Hash, s_Lower, m_Rules.Fingerprint(s_Entry), s_Entry));
            }

            return new MountedPool(s_Databases, s_Entries);
        }

        public class Result
        {
            public HashSet<(string Mesh, uint Hash)> Keys { get; init; } = new();
            public LevelClosure Closure { get; init; } = null!;
            public HashSet<string> PlainMeshes { get; init; } = new();
            public HashSet<uint> Variations { get; init; } = new();
        }

        /// <summary>
        /// The keys of a level partition's database. A mesh its own bundle ships gets a plain entry
        /// when no key for it is derived, here or for a sub-world: every mesh is bound somewhere, by
        /// the bundle that ships it if by nothing else.
        /// </summary>
        /// <param name="p_OwnBundlePartitions">The partitions of the level partition's own bundle.</param>
        /// <param name="p_KnownSubWorldMeshes">The meshes a sub-world's keys cover, when already derived (by its own bundle, earlier in the build).</param>
        public Result Derive(string p_Root, IEnumerable<string> p_OwnBundlePartitions, TextWriter p_Log, Func<string, IReadOnlyCollection<string>?>? p_KnownSubWorldMeshes = null)
        {
            var s_Root = p_Root.ToLowerInvariant();
            var (s_Closure, s_All) = m_Deriver.ReachedContent(s_Root);

            var s_Covered = new HashSet<string>();
            foreach (var s_SubWorld in s_All.SelectMany(m_Deriver.Rules.GetSubWorldBundles).Select(p_B => p_B.ToLowerInvariant()).Where(p_B => p_B != s_Root).Distinct())
            {
                if (m_Deriver.GetVariant(s_SubWorld) == null)
                    continue;

                if (p_KnownSubWorldMeshes?.Invoke(s_SubWorld) is { } s_Known)
                {
                    s_Covered.UnionWith(s_Known);
                    p_Log.WriteLine($"  sub-world {s_SubWorld}: {s_Known.Count} meshes, as derived for its bundle.");
                    continue;
                }

                var (s_SubClosure, _) = m_Deriver.ReachedContent(s_SubWorld);
                var s_SubKeys = DeriveKeys(s_SubClosure, out _, out _);
                s_Covered.UnionWith(s_SubKeys.Select(p_K => p_K.Mesh));
                p_Log.WriteLine($"  sub-world {s_SubWorld}: {s_SubKeys.Count} keys.");
            }

            var s_Keys = DeriveKeys(s_Closure, out var s_Plain, out var s_Variations);
            s_Covered.UnionWith(s_Keys.Select(p_K => p_K.Mesh));
            foreach (var s_Name in p_OwnBundlePartitions.Select(p_N => p_N.ToLowerInvariant()))
            {
                if (m_Deriver.Parse(s_Name) is not { PrimaryInstance: { } s_Primary } s_Parsed || !m_Rules.IsMesh(s_Primary))
                    continue;

                var s_Mesh = m_Deriver.Key(s_Parsed.PartitionGuid, s_Primary.InstanceId);
                if (!s_Covered.Contains(s_Mesh) && Pool.ContainsKey((s_Mesh, 0u)))
                    s_Keys.Add((s_Mesh, 0u));
            }

            p_Log.WriteLine($"{s_Root}: closure of {s_Closure.Partitions.Count} partitions, {s_Keys.Count} keys.");
            return new Result { Keys = s_Keys, Closure = s_Closure, PlainMeshes = s_Plain, Variations = s_Variations };
        }

        /// <summary>The pool entry for each key, in a stable order.</summary>
        public List<object> EntriesFor(IEnumerable<(string Mesh, uint Hash)> p_Keys)
        {
            return p_Keys.OrderBy(p_K => p_K.Mesh, StringComparer.Ordinal).ThenBy(p_K => p_K.Hash)
                .Select(p_K => Pool[p_K][0].Entry).ToList();
        }

        private DatabasePartitionBase? Parse(string p_Name, IObjectVariant p_Variant)
        {
            try
            {
                return EngineInterfaceRegistry.Create<IPartitionConverter>(m_Deriver.Mounter.GetEngineType()).FromPartitionObject(p_Name, p_Variant);
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// The keys a level's database holds, walking from the level partition with the variation
        /// that applies: a placement (a reference object, a static model group instance, an unlock
        /// pair) uses its own variation, or the one around it when it has none, and every mesh the
        /// walk reaches is used with the variation that applies there. Particle emitters use meshes
        /// without the database. Variations the walk reaches also pair with every mesh it reaches
        /// plainly (unlocks list variations and meshes side by side). Only keys some database in the
        /// game binds count.
        /// </summary>
        private HashSet<(string Mesh, uint Hash)> DeriveKeys(LevelClosure p_Closure, out HashSet<string> p_PlainMeshes, out HashSet<uint> p_Variations)
        {
            var s_Keys = new HashSet<(string, uint)>();
            p_PlainMeshes = new HashSet<string>();
            p_Variations = new HashSet<uint> { 0 };

            // Partitions count whole once their primary instance is reached, except for what a
            // placement places (a static model group's members sit in the level partition).
            var s_Placed = new HashSet<string>();
            var s_Siblings = new Dictionary<string, List<string>>();
            foreach (var s_Partition in p_Closure.Partitions.Values)
            {
                var s_Instances = s_Partition.Instances.Where(p_I => p_I != null).ToList();
                foreach (var s_Instance in s_Instances)
                {
                    foreach (var (s_Target, _) in m_Rules.GetPlacements(s_Instance, m_Deriver.Resolve))
                        s_Placed.Add(m_Deriver.Key(s_Target.PartitionGuid, s_Target.InstanceId));
                }

                if (s_Partition.PrimaryInstance != null)
                    s_Siblings[m_Deriver.Key(s_Partition.PartitionGuid, s_Partition.PrimaryInstance.InstanceId)] = s_Instances.Select(p_I => m_Deriver.Key(s_Partition.PartitionGuid, p_I.InstanceId)).ToList();
            }

            var s_Seen = new HashSet<(string, uint)>();
            var s_Queue = new Queue<(string Key, uint Hash)>();

            void Reach(string p_Key, uint p_Hash)
            {
                if (!s_Seen.Add((p_Key, p_Hash)))
                    return;

                s_Queue.Enqueue((p_Key, p_Hash));
                foreach (var s_Sibling in s_Siblings.GetValueOrDefault(p_Key) ?? new List<string>())
                {
                    if (!s_Placed.Contains(s_Sibling))
                        Reach(s_Sibling, p_Hash);
                }
            }

            if (p_Closure.Partitions.TryGetValue(p_Closure.Root, out var s_Root) && s_Root.PrimaryInstance != null)
                Reach(m_Deriver.Key(s_Root.PartitionGuid, s_Root.PrimaryInstance.InstanceId), 0);

            while (s_Queue.Count > 0)
            {
                var (s_Key, s_Hash) = s_Queue.Dequeue();
                if (!m_Deriver.Instances.TryGetValue(s_Key, out var s_Found))
                    continue;

                var s_Instance = s_Found.Instance;
                if (m_Rules.IsMesh(s_Instance))
                {
                    s_Keys.Add((s_Key, s_Hash));
                    if (s_Hash == 0)
                        p_PlainMeshes.Add(s_Key);
                    continue;
                }

                if (m_Rules.GetVariationHash(s_Instance) is { } s_Variation)
                    p_Variations.Add(s_Variation);

                if (m_Rules.UsesMeshesUnvaried(s_Instance))
                    continue;

                var s_Placements = m_Rules.GetPlacements(s_Instance, m_Deriver.Resolve).ToList();
                if (s_Placements.Count > 0)
                {
                    foreach (var (s_Target, s_Own) in s_Placements)
                        Reach(m_Deriver.Key(s_Target.PartitionGuid, s_Target.InstanceId), s_Own == 0 ? s_Hash : s_Own);
                    continue;
                }

                foreach (var s_Next in m_Deriver.ReferencesOf(s_Key))
                    Reach(s_Next, s_Hash);
            }

            var s_ByMesh = Pool.Keys.GroupBy(p_K => p_K.Mesh).ToDictionary(p_G => p_G.Key, p_G => p_G.Select(p_K => p_K.Hash).ToList());
            foreach (var s_Mesh in p_PlainMeshes)
            {
                foreach (var s_Hash in s_ByMesh.GetValueOrDefault(s_Mesh) ?? new List<uint>())
                {
                    if (p_Variations.Contains(s_Hash))
                        s_Keys.Add((s_Mesh, s_Hash));
                }
            }

            if (m_Rules.PlainEntryWithVariations)
            {
                foreach (var (s_Mesh, _) in s_Keys.ToList())
                    s_Keys.Add((s_Mesh, 0u));
            }

            s_Keys.IntersectWith(Pool.Keys);
            return s_Keys;
        }

    }
}
