using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Content.Building
{
    /// <summary>
    /// A resource with another resource's type, meta and id but different contents, from memory or
    /// from a file, optionally under another name or with other meta.
    /// </summary>
    public class ReplacedResource : IResourceObject
    {
        private readonly IResourceObject m_Original;
        private readonly Func<RimeReader> m_Reader;
        private readonly Func<long> m_Size;
        private readonly string? m_Name;
        private readonly byte[]? m_Meta;

        /// <param name="p_Name">The name to derive the id from when the original has none; the caller's name otherwise.</param>
        /// <param name="p_Meta">Meta to use instead of the original's.</param>
        public ReplacedResource(IResourceObject p_Original, byte[] p_Data, string? p_Name = null, byte[]? p_Meta = null)
            : this(p_Original, () => new RimeReader(new MemoryStream(p_Data, false)), () => p_Data.Length, p_Name, p_Meta)
        {
        }

        private ReplacedResource(IResourceObject p_Original, Func<RimeReader> p_Reader, Func<long> p_Size, string? p_Name, byte[]? p_Meta)
        {
            m_Original = p_Original;
            m_Reader = p_Reader;
            m_Size = p_Size;
            m_Name = p_Name;
            m_Meta = p_Meta;
        }

        /// <summary>A resource whose contents are read from a file each time they are read.</summary>
        public static ReplacedResource FromFile(IResourceObject p_Original, string p_Path, string? p_Name = null, byte[]? p_Meta = null)
        {
            return new ReplacedResource(p_Original,
                () => new RimeReader(File.Open(p_Path, FileMode.Open, FileAccess.Read, FileShare.Read)),
                () => new FileInfo(p_Path).Length, p_Name, p_Meta);
        }

        public ResourceType GetResourceType() => m_Original.GetResourceType();

        public bool TryGetMeta([NotNullWhen(true)] out byte[]? p_Meta)
        {
            if (m_Meta != null)
            {
                p_Meta = m_Meta;
                return true;
            }

            return m_Original.TryGetMeta(out p_Meta);
        }

        public ResourceRef GetId(string? p_Name = null)
        {
            // Bundles without resource ids (non-CAS) give none; the id then comes from name and data.
            try { return m_Original.GetId(p_Name ?? m_Name); }
            catch { return new ResourceRef(p_Name ?? m_Name ?? string.Empty, this); }
        }

        public RimeReader GetReader() => m_Reader();

        public long GetSize() => m_Size();
    }
}
