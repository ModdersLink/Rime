using RimeLib.Frostbite.Core;

namespace RimeLib.Frostbite
{
    /// <summary>
    /// Object that can have an optional hash attached to it.
    /// </summary>
    public interface IObjectWithHash
    {
        /// <summary>
        /// Get the hash of this object, if it exists.
        /// </summary>
        /// <returns>The hash of the object if it exists, null otherwise.</returns>
        Sha1? GetSha1();
    }
}
