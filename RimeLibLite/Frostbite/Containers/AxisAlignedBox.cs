using System.Reflection;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Implementation of fb::AxisAlignedBox
    /// </summary>
    [ContainerType(16), ContainerStruct]
    public class AxisAlignedBox : FrostbiteContainer
    {
        /// <summary>
        /// Minimum position of the aligned box
        /// </summary>
        [ContainerField("min")]
        public Vec3 Min { get; set; } = Vec3.Zero;

        /// <summary>
        /// Maximum position of the aligned box
        /// </summary>
        [ContainerField("max", 16)]
        public Vec3 Max { get; set; } = Vec3.Zero;

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
        /// Binds ebx data to this object
        /// </summary>
        /// <param name="p_Descriptor">Field Descriptor</param>
        /// <param name="p_Value">Value</param>
        public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
        {
            switch ((int) p_Descriptor.NameHash)
            {
                case 193413807:
                    Min = (Vec3) p_Value;
                    break;

                case 193414065:
                    Max = (Vec3) p_Value;
                    break;

                default:
                    base.Bind(p_Descriptor, p_Value);
                    break;
            }
        }
        
        /// <summary>
        /// Gets the field value by name hash
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>Value</returns>
		public override object? GetFieldValueByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 193413807:
                    return Min;

                case 193414065:
                    return Max;

                default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

        /// <summary>
        /// Gets the field information by name hash
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>PropertyInfo object</returns>
		public override PropertyInfo? GetFieldInfoByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 193413807:
                    return typeof(AxisAlignedBox).GetProperty(nameof(Min));

                case 193414065:
                    return typeof(AxisAlignedBox).GetProperty(nameof(Max));
                    
				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
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
