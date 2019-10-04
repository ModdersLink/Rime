using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Venice.Mounting
{
    internal class MountedChunk : MountedObject, IMountedChunk
    {
        protected DbObject? m_Meta;

        public MountedChunk(IReadableObject p_Readable, DbObject? p_Meta) 
            : base(p_Readable)
        {
            m_Meta = p_Meta;
        }

        public bool TryGetChunkMeta(out DbObject? p_Meta)
        {
            p_Meta = m_Meta;
            return m_Meta != null;
        }
    }
}
