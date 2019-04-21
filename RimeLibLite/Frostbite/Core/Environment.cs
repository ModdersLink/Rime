using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// TODO: Figure out the use of this?
    /// Implementation of fb::Environment
    /// </summary>
    public class Environment
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public Environment()
        {
            Data = new byte[1];
        }

        /// <summary>
        /// Constructor that passes an environment data
        /// </summary>
        /// <param name="p_Data">Environment data</param>
        public Environment(byte[] p_Data)
        {
            Data = p_Data;
        }

        /// <summary>
        /// Constructor to read an environment from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of an Environment</param>
        public Environment(RimeReader p_Reader)
        {
            Data = p_Reader.ReadBytes(1);
        }

        /// <summary>
        /// Returns environment data
        /// </summary>
        public byte[] Data
        {
            // TODO: figure out if we need to limit this or something?
            get;
            set;
        }
    }
}
