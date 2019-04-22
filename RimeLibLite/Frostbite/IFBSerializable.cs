using RimeLib.IO;

namespace RimeLib.Frostbite
{
    /// <summary>
    /// Serializable objects will use this interface
    /// </summary>
    public interface IFbSerializable
    {
        /// <summary>
        /// Serialize to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position</param>
        /// <returns>True on success, false otherwise</returns>
        bool Serialize(RimeWriter p_Writer);

        /// <summary>
        /// Serialize to a byte array
        /// </summary>
        /// <returns>byte[]</returns>
        bool Serialize(out byte[] p_Data);

        /// <summary>
        /// Deserialize from an open reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position</param>
        void Deserialize(RimeReader p_Reader);

        /// <summary>
        /// Deserialize from an byte array
        /// </summary>
        /// <param name="p_Data">Input byte array</param>
        void Deserialize(byte[] p_Data);
    }
}
