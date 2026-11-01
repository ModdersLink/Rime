using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Cmd
{
    /// <summary>A partition of a bundle being built, readable like a mounted one.</summary>
    internal class BundlePartitionVariant : IObjectVariant
    {
        private readonly IReadableObject m_Object;
        private readonly string m_Bundle;

        public BundlePartitionVariant(IReadableObject p_Object, string p_Bundle)
        {
            m_Object = p_Object;
            m_Bundle = p_Bundle;
        }

        /// <summary>The partitions of a bundle being built, by lowercase name.</summary>
        public static Dictionary<string, IObjectVariant> All(BundleBuildingContext p_Context)
        {
            var s_Bundle = p_Context.BundleName.ToLowerInvariant();
            return p_Context.GetPartitions().ToDictionary(p_P => p_P.Key.ToLowerInvariant(),
                p_P => p_P.Value as IObjectVariant ?? new BundlePartitionVariant(p_P.Value, s_Bundle), StringComparer.OrdinalIgnoreCase);
        }

        public bool Cas => false;
        public RimeReader GetReader() => m_Object.GetReader();
        public long GetSize() => m_Object.GetSize();
        public Sha1? GetSha1() => (m_Object as IObjectWithHash)?.GetSha1();
        public string GetContainedSuperbundle() => "";
        public string? GetContainedBundle() => m_Bundle;
    }
}
