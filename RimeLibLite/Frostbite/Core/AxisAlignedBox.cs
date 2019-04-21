using RimeLib.IO;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation of fb::AxisAlignedBox
    /// </summary>
    public class AxisAlignedBox
    {
        /// <summary>
        /// Minimum position of the aligned box
        /// </summary>
        public Vec3 Min { get; set; }

        /// <summary>
        /// Maximum position of the aligned box
        /// </summary>
        public Vec3 Max { get; set; }

        /// <summary>
        /// Constructor taking an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a aab object</param>
        public AxisAlignedBox(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AxisAlignedBox()
        {
	        Min = new Vec3();
	        Max = new Vec3();
        }

        /// <summary>
        /// Loads this object from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of this object</param>
        public void Deserialize(RimeReader p_Reader)
        {
            Min = new Vec3(p_Reader);
            Max = new Vec3(p_Reader);
        }

        /// <summary>
        /// Writes this object to an opened writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position of this object</param>
        public void Serialize(RimeWriter p_Writer)
        {
            Min.Serialize(p_Writer);
            Max.Serialize(p_Writer);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Min Max as strings</returns>
	    public override string ToString()
	    {
		    return $"{Min} {Max}";
	    }
    }
}
