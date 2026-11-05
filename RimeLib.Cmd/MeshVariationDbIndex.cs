using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Which texture partitions a mesh's MeshVariationDatabase entries bind, over every mounted
    /// database at once.
    ///
    /// The build pipeline moves texture bindings out of MeshMaterial and MeshMaterialVariation and
    /// into the MVDB. In shipped data the MVDB is the only place a mesh-to-texture binding exists,
    /// so no EBX walk can find one.
    ///
    /// An entry belongs to the (mesh, variation) pair, not to the level that ships it. Across the
    /// 831 shipped databases the entries for a given pair are byte-identical everywhere they
    /// appear. So the source database does not matter, and one index over everything mounted
    /// answers for any mesh in it.
    /// </summary>
    public static class MeshVariationDbIndex
    {
        // Mesh partition guid -> the texture partition guids its entries bind. Keeping the entries
        // themselves would pin every parsed database in memory for no gain.
        private static readonly Dictionary<GUID, HashSet<GUID>> m_Textures = new();

        private static IEngineMounter? m_BuiltFor;

        /// <summary>
        /// Parses every mounted MeshVariationDatabase once. Cheap to call again, because it rebuilds
        /// only when handed a different mounter.
        /// </summary>
        public static void Build(IEngineMounter p_Mounter, TextWriter p_Writer)
        {
            if (ReferenceEquals(m_BuiltFor, p_Mounter))
                return;

            m_Textures.Clear();

            var s_Databases = 0;
            var s_Entries = 0;

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(p_Mounter.GetEngineType());
            var s_Rules = EngineInterfaceRegistry.Create<IMeshVariationRules>(p_Mounter.GetEngineType());

            // One database per bundle, always named `<bundlePath>/MeshVariationDb_<platform>`. Match
            // on the name, so only a few hundred partitions are parsed instead of the whole game.
            foreach (var (s_Name, s_Mounted) in p_Mounter.GetPartitions())
            {
                if (s_Name.IndexOf("meshvariationdb", StringComparison.OrdinalIgnoreCase) < 0)
                    continue;

                try
                {
                    var s_Variant = s_Mounted.Variants.FirstOrDefault(p_V => p_V.GetContainedBundle() != null)
                                    ?? s_Mounted.FirstVariant;
                    var s_Db = s_Converter.FromPartitionObject(s_Name, s_Variant);
                    s_Databases++;

                    // Redirect entries alias the mesh's variation-0 set and bind nothing of their own.
                    foreach (var (s_Mesh, _, s_Entry) in s_Rules.ReadEntries(s_Db))
                    {
                        if (s_Mesh.IsNull())
                            continue;
                        s_Entries++;

                        foreach (var s_Texture in s_Rules.GetTextures(s_Entry))
                        {
                            if (!m_Textures.TryGetValue(s_Mesh.PartitionGuid, out var s_Set))
                            {
                                s_Set = new HashSet<GUID>();
                                m_Textures[s_Mesh.PartitionGuid] = s_Set;
                            }

                            s_Set.Add(s_Texture.PartitionGuid);
                        }
                    }
                }
                catch (Exception s_Ex)
                {
                    p_Writer.WriteLine($"WARN: could not index MVDB '{s_Name}': {s_Ex.Message}");
                }
            }

            m_BuiltFor = p_Mounter;

            p_Writer.WriteLine($"MVDB index: {s_Entries} entr(ies) from {s_Databases} database(s), binding textures for {m_Textures.Count} mesh partition(s).");
        }

        /// <summary>
        /// The texture partitions every mounted database binds for meshes in the given partition.
        /// </summary>
        public static bool TryGetTexturePartitions(GUID p_MeshPartitionGuid, [NotNullWhen(true)] out HashSet<GUID>? p_Textures)
        {
            return m_Textures.TryGetValue(p_MeshPartitionGuid, out p_Textures);
        }
    }
}
