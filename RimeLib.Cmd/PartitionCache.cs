using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Serialization;

namespace RimeLib.Cmd
{
    /// <summary>
    /// The mounted partitions the steps of one build_level run have parsed, so each is parsed once
    /// per run rather than once per step (BF3 mp_subway parses 12k partitions 234k times). Callers
    /// share what they get, so only those that read it use the cache; one that fills in what it
    /// parses (a template) parses its own copy. A bundle's own partitions change between steps and
    /// are never cached.
    /// </summary>
    internal static class PartitionCache
    {
        private static ConcurrentDictionary<(IObjectVariant, string), Lazy<DatabasePartitionBase>>? s_Current;

        /// <summary>Caches until the returned scope is disposed.</summary>
        public static IDisposable Begin()
        {
            s_Current = new ConcurrentDictionary<(IObjectVariant, string), Lazy<DatabasePartitionBase>>(new KeyComparer());
            return new Scope();
        }

        /// <summary>The partition parsed, from the cache when one is active. A partition that does not parse throws every time.</summary>
        public static DatabasePartitionBase Parse(IPartitionConverter p_Converter, string p_Name, IObjectVariant p_Variant)
        {
            var s_Cache = s_Current;
            if (s_Cache == null || p_Variant is BundlePartitionVariant)
                return p_Converter.FromPartitionObject(p_Name, p_Variant);

            return s_Cache.GetOrAdd((p_Variant, p_Name), p_Key => new Lazy<DatabasePartitionBase>(() => p_Converter.FromPartitionObject(p_Key.Item2, p_Key.Item1))).Value;
        }

        private sealed class Scope : IDisposable
        {
            public void Dispose() => s_Current = null;
        }

        /// <summary>A variant is the mounted object itself, so it is compared by reference.</summary>
        private sealed class KeyComparer : IEqualityComparer<(IObjectVariant, string)>
        {
            public bool Equals((IObjectVariant, string) p_A, (IObjectVariant, string) p_B) =>
                ReferenceEquals(p_A.Item1, p_B.Item1) && string.Equals(p_A.Item2, p_B.Item2, StringComparison.Ordinal);

            public int GetHashCode((IObjectVariant, string) p_Key) =>
                HashCode.Combine(System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(p_Key.Item1), StringComparer.Ordinal.GetHashCode(p_Key.Item2));
        }
    }
}
