using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Havok;
using RimeLib.Serialization;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd
{
    /// <summary>
    /// The global material indices a level's content uses, which is what its material grid has rows
    /// for: the material references in the EBX the level and its sub-worlds reach, the material
    /// tables of the Havok physics data they reach, and the materials of their terrain.
    /// </summary>
    internal sealed class MaterialCollector
    {
        public sealed class Result
        {
            /// <summary>The partitions walked: the level and every sub-world it references.</summary>
            public List<string> Roots { get; } = new();

            /// <summary>The bundles the content names (weapon, vehicle and configuration bundles), taken whole.</summary>
            public SortedSet<string> Bundles { get; } = new(StringComparer.Ordinal);

            /// <summary>Per global material index, where it was found ("ebx:Type.Field", "havok:resource", "terrain:resource").</summary>
            public SortedDictionary<uint, SortedSet<string>> Materials { get; } = new();

            public List<string> Problems { get; } = new();
        }

        private readonly IEngineMounter m_Mounter;
        private readonly RegistryDeriver m_Deriver;
        private readonly IMaterialGridRules m_Rules;
        private readonly IHavokMaterials? m_Havok;
        private readonly ITerrainHeightfield? m_Terrain;

        public MaterialCollector(IEngineMounter p_Mounter)
        {
            m_Mounter = p_Mounter;
            m_Deriver = new RegistryDeriver(p_Mounter);
            var s_Engine = p_Mounter.GetEngineType();
            m_Rules = EngineInterfaceRegistry.Create<IMaterialGridRules>(s_Engine);
            m_Havok = EngineInterfaceRegistry.IsSupported<IHavokMaterials>(s_Engine) ? EngineInterfaceRegistry.Create<IHavokMaterials>(s_Engine) : null;
            m_Terrain = EngineInterfaceRegistry.IsSupported<ITerrainHeightfield>(s_Engine) ? EngineInterfaceRegistry.Create<ITerrainHeightfield>(s_Engine) : null;
        }

        public bool ReadsHavok => m_Havok != null;
        public bool ReadsTerrain => m_Terrain != null;

        public DatabasePartitionBase? Parse(string p_Name) => m_Deriver.Parse(p_Name);

        public string? MaterialName(uint p_Material) => m_Rules.GetMaterialName(p_Material, m_Deriver.Parse);

        public Result Collect(string p_Level)
        {
            var s_Result = new Result();
            var s_Content = new HashSet<DataContainerBase>();
            var s_Queue = new Queue<string>();
            var s_Seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            s_Queue.Enqueue(p_Level.ToLowerInvariant());

            while (s_Queue.Count > 0)
            {
                var s_Root = s_Queue.Dequeue();
                if (!s_Seen.Add(s_Root))
                    continue;
                if (!m_Mounter.TryGetPartition(s_Root, out _))
                {
                    s_Result.Problems.Add($"sub-world partition {s_Root} is not mounted");
                    continue;
                }

                s_Result.Roots.Add(s_Root);
                var (_, s_Reached) = m_Deriver.ReachedContent(s_Root);
                foreach (var s_Instance in s_Reached)
                {
                    if (!s_Content.Add(s_Instance))
                        continue;

                    // A sub-world's partition is named like its bundle, without the platform folder.
                    if (s_Instance.GetType().Name == "SubWorldReferenceObjectData" && s_Instance.GetType().GetProperty("BundleName")?.GetValue(s_Instance) is string { Length: > 0 } s_Bundle)
                        s_Queue.Enqueue(s_Bundle.ToLowerInvariant().Replace("win32/", ""));
                }
            }

            var s_Resources = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_NamedBundles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            var s_FollowBundles = true;
            var s_Pending = new Queue<DataContainerBase>(s_Content);
            while (true)
            {
                while (s_Pending.Count > 0)
                    VisitInstance(s_Pending.Dequeue(), s_Result, s_Resources, s_FollowBundles ? s_NamedBundles : new HashSet<string>());

                // A bundle the level's content names loads with the level, whole: its partitions and
                // its resources. Bundles those name in turn are not followed; that reaches content
                // the level never loads (every vehicle and weapon of the game).
                var s_New = s_NamedBundles.Where(p_B => s_Result.Bundles.Add(p_B)).ToList();
                if (s_New.Count == 0)
                    break;
                s_NamedBundles = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
                s_FollowBundles = false;

                foreach (var s_Bundle in s_New)
                {
                    foreach (var s_Partition in m_Mounter.GetPartitionsInBundle(s_Bundle))
                    {
                        foreach (var s_Instance in m_Deriver.Parse(s_Partition.ToLowerInvariant())?.Instances ?? Enumerable.Empty<DataContainerBase>())
                        {
                            if (s_Instance != null && s_Content.Add(s_Instance))
                                s_Pending.Enqueue(s_Instance);
                        }
                    }

                    foreach (var (s_Name, s_Type) in m_Mounter.GetResourcesInBundle(s_Bundle))
                    {
                        if (s_Type is ResourceType.HavokPhysicsData or ResourceType.TerrainStreamingTree)
                            s_Resources.Add(s_Name.ToLowerInvariant());
                    }
                }
            }

            foreach (var s_Name in s_Resources.OrderBy(p_N => p_N, StringComparer.Ordinal))
                CollectResource(s_Name, s_Result);

            return s_Result;
        }

        private void VisitInstance(DataContainerBase s_Instance, Result s_Result, HashSet<string> s_Resources, HashSet<string> p_Bundles)
        {
            {
                var s_Type = s_Instance.GetType().Name;

                // A grid lists every material pair, and the container every pair there is; neither is content.
                if (s_Type is "MaterialGridData" or "MaterialContainerAsset")
                    return;

                m_Bundles = p_Bundles;
                Visit(s_Instance, 0, s_Type, s_Result, s_Resources);

                // Frostbite 2 binds physics data and the terrain streaming tree by the asset's name.
                if (s_Instance.GetType().GetProperty("Name")?.GetValue(s_Instance) is string s_Name && s_Name.Length > 0)
                {
                    var s_Lower = s_Name.ToLowerInvariant();
                    foreach (var s_Candidate in new[] { s_Lower, s_Lower + ".streamingtree" })
                    {
                        if (m_Mounter.TryGetResource(s_Candidate, out _))
                            s_Resources.Add(s_Candidate);
                    }
                }
            }
        }

        private HashSet<string> m_Bundles = new();
        private HashSet<string>? m_MountedBundles;

        private void Add(Result p_Result, uint p_Packed, string p_Source)
        {
            foreach (var s_Material in m_Rules.GetMaterials(p_Packed, m_Deriver.Parse))
            {
                if (!p_Result.Materials.TryGetValue(s_Material, out var s_Sources))
                    p_Result.Materials[s_Material] = s_Sources = new SortedSet<string>(StringComparer.Ordinal);
                s_Sources.Add(p_Source);
            }
        }

        /// <summary>Walks an instance's fields, its structs and arrays, for material references and resource ids.</summary>
        private void Visit(object? p_Value, int p_Depth, string p_Field, Result p_Result, HashSet<string> p_Resources)
        {
            if (p_Value == null || p_Depth > 4)
                return;

            if (m_Rules.TryGetPackedMaterial(p_Value, m_Deriver.Resolve, out var s_Packed))
            {
                Add(p_Result, s_Packed, $"ebx:{p_Field}");
                return;
            }

            if (p_Value is ResourceRef s_ResourceRef)
            {
                if (s_ResourceRef.Id != 0 && m_Mounter.TryGetResource(s_ResourceRef, out var s_Resource))
                    p_Resources.Add(s_Resource.OriginalName.ToLowerInvariant());
                return;
            }

            if (p_Value is string s_String)
            {
                // A string naming a mounted bundle (weapon, vehicle and configuration bundles are named so).
                m_MountedBundles ??= m_Mounter.GetMountedBundles().Select(p_B => p_B.ToLowerInvariant()).ToHashSet();
                var s_Bundle = s_String.ToLowerInvariant();
                if (!s_Bundle.StartsWith("win32/"))
                    s_Bundle = "win32/" + s_Bundle;
                if (s_String.Length > 0 && m_MountedBundles.Contains(s_Bundle) && !s_Bundle.Contains("/levels/"))
                    m_Bundles.Add(s_Bundle);
                return;
            }

            if (p_Value is CtrRefBase)
                return;

            var s_Type = p_Value.GetType();
            if (s_Type.IsPrimitive || s_Type.IsEnum)
                return;

            if (p_Value is IEnumerable s_List)
            {
                foreach (var s_Item in s_List)
                    Visit(s_Item, p_Depth + 1, p_Field, p_Result, p_Resources);
                return;
            }

            // Only the engine's own types carry fields worth walking; another instance is visited on its own.
            if ((p_Depth > 0 && p_Value is DataContainerBase) || (s_Type.Namespace != "fb" && s_Type.Namespace?.StartsWith("fb.") != true))
                return;

            foreach (var s_Property in s_Type.GetProperties())
            {
                if (s_Property.GetIndexParameters().Length > 0 || s_Property.DeclaringType == typeof(DataContainerBase))
                    continue;

                object? s_Field;
                try
                {
                    s_Field = s_Property.GetValue(p_Value);
                }
                catch
                {
                    continue;
                }

                Visit(s_Field, p_Depth + 1, p_Depth == 0 ? $"{s_Type.Name}.{s_Property.Name}" : p_Field, p_Result, p_Resources);
            }
        }

        private void CollectResource(string p_Name, Result p_Result)
        {
            if (!m_Mounter.TryGetResource(p_Name, out var s_Resource))
                return;

            var s_Variant = s_Resource.FirstVariant;
            try
            {
                switch (s_Variant.GetResourceType())
                {
                    case ResourceType.HavokPhysicsData when m_Havok != null:
                        foreach (var s_Packed in m_Havok.GetMaterialFlagsAndIndices(s_Variant))
                            Add(p_Result, s_Packed, $"havok:{p_Name}");
                        break;

                    case ResourceType.TerrainStreamingTree when m_Terrain != null:
                        if (!m_Terrain.ReadHeightfield(s_Variant, m_Mounter, out var s_Tree) || s_Tree == null || !s_Tree.HasMaterialTree)
                            break;
                        foreach (var s_Packed in s_Tree.MaterialPairIndices.Append(s_Tree.BackgroundMaterialIndex))
                            Add(p_Result, s_Packed, $"terrain:{p_Name}");
                        break;
                }
            }
            catch (Exception s_Ex)
            {
                p_Result.Problems.Add($"resource {p_Name} could not be read: {s_Ex.Message}");
            }
        }
    }
}
