using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Content.Venice.Mounting
{
    internal class ResourceVariant : ObjectVariant, IResourceVariant
    {
        protected ResourceType m_Type;
        protected byte[]? m_Meta;

        public ResourceVariant(IReadableObject p_Readable, ResourceType p_Type, byte[]? p_Meta, string p_ContainedSuperbundle, string? p_ContainedBundle) :
            base(p_Readable, p_ContainedSuperbundle, p_ContainedBundle)
        {
            m_Type = p_Type;
            m_Meta = p_Meta;
        }

        public ResourceType GetResourceType()
        {
            return m_Type;
        }

        public bool TryGetMeta(out byte[]? p_Meta)
        {
            p_Meta = m_Meta;
            return m_Meta != null;
        }
    }
}