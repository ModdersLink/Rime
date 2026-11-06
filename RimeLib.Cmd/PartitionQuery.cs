using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// Mounted partitions by what they are: their primary instance's type, the superbundles that
    /// carry them and a name prefix. A level template ("all weapons", "the XP4 soldiers") is such a
    /// query rather than a fixed list, so it follows the game through patches.
    /// </summary>
    internal static class PartitionQuery
    {
        /// <param name="p_Types">Primary instance type names; a trailing * matches a prefix.</param>
        /// <param name="p_Superbundles">Superbundles one of which has to carry the partition, or none for any.</param>
        /// <param name="p_Prefixes">Name prefixes one of which the partition has to start with, or none for any.</param>
        public static List<string> Find(IEngineMounter p_Mounter, IReadOnlyCollection<string> p_Types,
            IReadOnlyCollection<string> p_Superbundles, IReadOnlyCollection<string> p_Prefixes)
        {
            var s_Superbundles = p_Superbundles.Select(p_S => p_S.ToLowerInvariant()).ToHashSet();
            var s_Prefixes = p_Prefixes.Select(p_P => p_P.ToLowerInvariant()).ToList();
            var s_Reader = EngineInterfaceRegistry.Create<IPartitionImportReader>(p_Mounter.GetEngineType());

            var s_Candidates = p_Mounter.GetPartitions()
                .Where(p_P => s_Prefixes.Count == 0 || s_Prefixes.Any(p_X => p_P.Key.StartsWith(p_X, StringComparison.OrdinalIgnoreCase)))
                .Where(p_P => s_Superbundles.Count == 0 || p_P.Value.Variants.Any(p_V => s_Superbundles.Contains(p_V.GetContainedSuperbundle().ToLowerInvariant())))
                .ToList();

            // The type comes from the partition's metadata, so this reads headers, not payloads.
            var s_Matches = new bool[s_Candidates.Count];
            System.Threading.Tasks.Parallel.For(0, s_Candidates.Count, i =>
            {
                try
                {
                    s_Matches[i] = s_Reader.ReadPrimaryTypeName(s_Candidates[i].Value.FirstVariant) is { } s_Type && Matches(s_Type, p_Types);
                }
                catch (Exception)
                {
                    // An unreadable header matches nothing.
                }
            });

            var s_Found = s_Candidates.Where((_, i) => s_Matches[i]).Select(p_P => p_P.Key.ToLowerInvariant()).ToList();
            s_Found.Sort(StringComparer.Ordinal);
            return s_Found;
        }

        public static bool Matches(string p_Type, IEnumerable<string> p_Patterns) =>
            p_Patterns.Any(p_P => p_P.EndsWith('*') ? p_Type.StartsWith(p_P[..^1], StringComparison.Ordinal) : p_Type == p_P);
    }
}
