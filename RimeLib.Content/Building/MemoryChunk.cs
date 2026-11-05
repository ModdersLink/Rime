using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Db;
using RimeLib.IO;

namespace RimeLib.Content.Building
{
    /// <summary>A whole chunk from memory, with the meta and asset name hash it is shipped with.</summary>
    public sealed class MemoryChunk : IChunkObject
    {
        private readonly byte[] m_Data;
        private readonly DbObject? m_Meta;
        private readonly int? m_AssetNameHash;

        public MemoryChunk(byte[] p_Data, DbObject? p_Meta, int? p_AssetNameHash)
        {
            m_Data = p_Data;
            m_Meta = p_Meta;
            m_AssetNameHash = p_AssetNameHash;
        }

        public RimeReader GetReader() => new(new MemoryStream(m_Data, false));

        public long GetSize() => m_Data.Length;

        public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
        {
            p_Meta = m_Meta;
            return p_Meta != null;
        }

        public uint GetRangeStart() => 0;

        public uint GetRangeEnd() => (uint)m_Data.Length;

        public uint GetLogicalOffset() => 0;

        public uint GetLogicalSize() => (uint)m_Data.Length;

        public int? GetAssetNameHash() => m_AssetNameHash;
    }
}
