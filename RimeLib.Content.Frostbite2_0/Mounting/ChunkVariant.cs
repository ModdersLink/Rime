using System;
using System.Diagnostics.CodeAnalysis;
using RimeLib.Content.Frostbite2_0.Frostbite.Chunks;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    internal class ChunkVariant : ObjectVariant, IChunkVariant
    {
        protected DbObject? m_Meta;
        protected uint m_RangeStart;
        protected uint m_LogicalOffset;
        protected bool m_Cas;

        public bool Cas => m_Cas;

        public ChunkVariant(IReadableObjectWithHash p_Readable, uint p_RangeStart, uint p_LogicalOffset, DbObject? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) :
            base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
        {
            m_Meta = p_Meta;
            m_RangeStart = p_RangeStart;
            m_LogicalOffset = p_LogicalOffset;
            m_Cas = (p_Readable is CatalogReadable || p_Readable is CasChunkEntry);
        }

        public bool TryGetMeta([NotNullWhen(true)] out DbObject? p_Meta)
        {
            p_Meta = m_Meta;
            return m_Meta != null;
        }

        public uint GetRangeStart()
        {
            return m_RangeStart;
        }

        public uint GetLogicalOffset()
        {
            return m_LogicalOffset;
        }

        public int? GetAssetNameHash()
        {
            if (m_Meta == null)
                return null;
            
            try
            {
                var s_Meta = DbObjectConverter.FromDbObject<ChunkEntry.ChunkMetaEntry>(m_Meta);
                return s_Meta.AssetNameHash;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}