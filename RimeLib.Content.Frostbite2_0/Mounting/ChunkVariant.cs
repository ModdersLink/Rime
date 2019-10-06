using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    internal class ChunkVariant : ObjectVariant, IChunkVariant
    {
        protected DbObject? m_Meta;

        public ChunkVariant(IReadableObjectWithHash p_Readable, DbObject? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) :
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