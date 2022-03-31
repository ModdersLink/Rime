using RimeLib.IO;
using System.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation for fb::ObjectId
    /// </summary>
    public class ObjectId : GUID
    {
        /// <summary>
        /// Constructor for reading an ObjectId from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a ObjectId</param>
        public ObjectId(RimeReader p_Reader)
            : base(p_Reader)
        {
        }

        public ObjectId(byte[] p_Data)
            : base(new RimeReader(new MemoryStream(p_Data)))
        {
            
        }
    }
}
