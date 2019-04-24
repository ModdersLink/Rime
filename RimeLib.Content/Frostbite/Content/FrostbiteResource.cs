namespace RimeLib.Content.Frostbite.Content
{
    /// <summary>
    /// Frostbite resource object
    /// </summary>
    public abstract class FrostbiteResource
    {
        /// <summary>
        /// Type of the resource
        /// </summary>
        public abstract ResourceType ResourceType { get; }

        /// <summary>
        /// Name of the resource
        /// </summary>
        public virtual string Name { get; set; } = "";

        public abstract byte[] SerializeData();
        public abstract byte[]? SerializeMeta();
    }
}
