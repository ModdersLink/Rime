using RimeLib.IO;

namespace RimeLib.Frostbite.Containers
{
    /// <summary>
    /// Implementation of fb::AxisAlignedBox2
    /// </summary>
    public class AxisAlignedBox2 : IFbSerializable
    {
        /// <summary>
        /// Minimum position
        /// </summary>
        public Vec2 Min { get; set; } = Vec2.Zero;

        /// <summary>
        /// Maximum position
        /// </summary>
        public Vec2 Max { get; set; } = Vec2.Zero;

        /// <summary>
        /// Constructor to read an AxisAlignedBox2 from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of AxisAlignedBox2</param>
        public AxisAlignedBox2(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public AxisAlignedBox2()
        {
            Min = new Vec2();
            Max = new Vec2();
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Min = new Vec2(p_Reader);
            Max = new Vec2(p_Reader);
        }

        public void Deserialize(byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }

        public bool Serialize(out byte[] p_Data)
        {
            throw new System.NotImplementedException();
        }
    }

}
