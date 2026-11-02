using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Cmd.Commands.Game;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// The shaders a bundle's content draws with. A mesh draws with what its mesh variation database
    /// entries bind (a material variation's shader replaces the material's), so the shaders mesh
    /// partitions reference count only through those entries, or where a mesh is drawn without them
    /// (mesh particles).
    /// </summary>
    internal sealed class DrawnShaders
    {
        private readonly IEngineMounter m_Mounter;
        private readonly Func<string, bool> m_IsShader;
        private readonly IPartitionConverter m_Converter;
        private readonly IMeshVariationRules m_Rules;
        private readonly Dictionary<GUID, DatabasePartitionBase?> m_Partitions = new();
        private readonly HashSet<string> m_Shaders = new(StringComparer.OrdinalIgnoreCase);

        private DrawnShaders(IEngineMounter p_Mounter, Func<string, bool> p_IsShader)
        {
            m_Mounter = p_Mounter;
            m_IsShader = p_IsShader;
            m_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());
            m_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(p_Mounter.GetEngineType());
        }

        public static HashSet<string> Of(BundleBuildingContext p_Bundle, IEngineMounter p_Mounter, Func<string, bool> p_IsShader)
        {
            var s_Walk = new DrawnShaders(p_Mounter, p_IsShader);
            var s_Own = new List<DatabasePartitionBase>();
            foreach (var (s_Name, s_Variant) in BundlePartitionVariant.All(p_Bundle))
            {
                try
                {
                    var s_Partition = s_Walk.m_Converter.FromPartitionObject(s_Name, s_Variant);
                    s_Walk.m_Partitions[s_Partition.PartitionGuid] = s_Partition;
                    s_Own.Add(s_Partition);
                }
                catch (Exception)
                {
                    // An unparsable partition draws nothing here.
                }
            }

            foreach (var s_Partition in s_Own)
                s_Walk.Walk(s_Partition);

            return s_Walk.m_Shaders;
        }

        private void Walk(DatabasePartitionBase p_Partition)
        {
            if (p_Partition.PrimaryInstance != null && m_Rules.IsMesh(p_Partition.PrimaryInstance))
                return;

            foreach (var s_Instance in p_Partition.Instances.Where(p_I => p_I != null))
            {
                AddShaders(s_Instance);

                if (!m_Rules.UsesMeshesUnvaried(s_Instance))
                    continue;

                foreach (var (_, s_Ref) in AnalyzeRegistryCommand.References(s_Instance, s_Instance.GetType().Name, 0))
                {
                    if (Get(s_Ref.PartitionGuid) is { PrimaryInstance: { } s_Primary } s_Mesh && m_Rules.IsMesh(s_Primary))
                    {
                        foreach (var s_MeshInstance in s_Mesh.Instances.Where(p_I => p_I != null))
                            AddShaders(s_MeshInstance);
                    }
                }
            }

            foreach (var (_, _, s_Entry) in m_Rules.ReadEntries(p_Partition))
            foreach (var s_Material in m_Rules.GetDrawnMaterials(s_Entry))
            {
                if (Get(s_Material.PartitionGuid)?.Instances.FirstOrDefault(p_I => p_I != null && p_I.InstanceId == s_Material.InstanceId) is { } s_Instance)
                    AddShaders(s_Instance);
            }
        }

        private void AddShaders(DataContainerBase p_Instance)
        {
            foreach (var (_, s_Ref) in AnalyzeRegistryCommand.References(p_Instance, p_Instance.GetType().Name, 0))
            {
                if (m_Mounter.TryGetPartitionByGuid(s_Ref.PartitionGuid, out var s_Target, out _) && m_IsShader(s_Target.ToLowerInvariant()))
                    m_Shaders.Add(s_Target.ToLowerInvariant());
            }
        }

        /// <summary>A partition of the bundle, or else the mounted one.</summary>
        private DatabasePartitionBase? Get(GUID p_Guid)
        {
            if (m_Partitions.TryGetValue(p_Guid, out var s_Partition))
                return s_Partition;

            s_Partition = null;
            try
            {
                if (m_Mounter.TryGetPartitionByGuid(p_Guid, out var s_Name, out var s_Mounted))
                    s_Partition = PartitionCache.Parse(m_Converter, s_Name, s_Mounted.FirstVariant);
            }
            catch (Exception)
            {
                // Unparsable: nothing drawn through it.
            }

            m_Partitions[p_Guid] = s_Partition;
            return s_Partition;
        }
    }
}
