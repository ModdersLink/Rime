using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Venice.Mounting
{
    internal class MountedResource : MountedObject, IMountedResource
    {
        protected ResourceType m_Type;
        protected DbObject? m_Meta;

        public MountedResource(IReadableObject p_Readable, ResourceType p_Type, DbObject? p_Meta) 
            : base(p_Readable)
        {
            m_Type = p_Type;
            m_Meta = p_Meta;
        }

        public ResourceType GetResourceType()
        {
            return m_Type;
        }

        public bool TryGetResourceMeta(out DbObject? p_Meta)
        {
            p_Meta = m_Meta;
            return m_Meta != null;
        }
    }
}