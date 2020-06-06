using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Ebx
{
    /// <summary>
    /// Ebx instance
    /// </summary>
    public class Instance
    {
        /// <summary>
        /// Identifier for this instance
        /// </summary>
        public GUID Id { get; set; } = GUID.Empty;

        /// <summary>
        /// Type of this instance
        /// </summary>
        public TypeInstance Type { get; set; } = new TypeInstance();
    }
}
