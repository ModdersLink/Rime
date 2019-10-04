using RimeLib.IO;

namespace RimeLib.Frostbite
{
    /// <summary>
    /// Object that can be read as a stream of bytes.
    /// </summary>
    public interface IReadableObject
    {
        /// <summary>
        /// Gets a RimeReader that can be used to read this object.
        /// This reader should be disposed after use.
        /// </summary>
        /// <returns></returns>
        RimeReader GetReader();
    }
}
