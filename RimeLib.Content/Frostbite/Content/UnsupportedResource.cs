namespace RimeLib.Content.Frostbite.Content
{
    /// <summary>
    /// An unsupported frostbite resource
    /// </summary>
    public class UnsupportedResource : FrostbiteResource
    {
        /// <summary>
        /// Type of resource
        /// </summary>
        public override ResourceType ResourceType => m_Type;

        /// <summary>
        /// Resource data
        /// </summary>
        public byte[] Data { get; set; }

        /// <summary>
        /// Resource metadata
        /// </summary>
        public byte[] Meta { get; set; }

        /// <summary>
        /// Type of resource
        /// </summary>
        protected ResourceType m_Type;

        /// <summary>
        /// Creates an unsupported resource
        /// </summary>
        /// <param name="p_Type">Type of the resource</param>
        /// <param name="p_Data">Data of the resource</param>
        /// <param name="p_Meta">Metadata of the resource</param>
        public UnsupportedResource(ResourceType p_Type, byte[] p_Data, byte[] p_Meta = null)
        {
            m_Type = p_Type;
            Data = p_Data;
            Meta = p_Meta;
        }

        public override byte[] SerializeData()
        {
            return Data;
        }

        public override byte[] SerializeMeta()
        {
            return Meta;
        }
    }
}
