using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Venice.Mounting
{
    internal class ChunkVariant : ObjectVariant, IChunkVariant
    {
        protected DbObject? m_Meta;

        public ChunkVariant(IReadableObject p_Readable, DbObject? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) :
            base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
        {
            m_Meta = p_Meta;
        }

        public bool TryGetMeta(out DbObject? p_Meta)
        {
            p_Meta = m_Meta;
            return m_Meta != null;
        }
    }
}