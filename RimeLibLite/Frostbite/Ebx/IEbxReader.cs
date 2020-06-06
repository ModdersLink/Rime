using RimeLib.IO;

namespace RimeLib.Serialization.Ebx
{
    /// <summary>
    /// Ebx reader interface
    /// </summary>
    public interface IEbxReader
    {
        /// <summary>
        /// Parses a partition with specified name and opened reader to the position of the ebx data
        /// </summary>
        /// <param name="p_Name">Name of partition</param>
        /// <param name="p_Reader">Reader opened to the position of ebx data</param>
        /// <returns>Partition object</returns>
        FrostbitePartition ParsePartition(string p_Name, RimeReader p_Reader);

        /// <summary>
        /// Parses a partition with the specified name and data
        /// </summary>
        /// <param name="p_Name">Name of the parition</param>
        /// <param name="p_Data">Ebx partition data</param>
        /// <returns>Partition object</returns>
        FrostbitePartition ParsePartition(string p_Name, byte[] p_Data);
    }
}
