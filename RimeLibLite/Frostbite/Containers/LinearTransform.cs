using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;
using System.Reflection;

namespace RimeLib.Frostbite.Containers
{
    /// <summary>
    /// Implementation for fb::LinearTransform
    /// </summary>
    // TODO: Implement MemberInfoFlags
    [ContainerType(Alignment: 16, Size: 64)]
    public class LinearTransform : FrostbiteContainer
    {
        /// <summary>
        /// Right vector
        /// </summary>
        [ContainerField("right")]
        public Vec3 Right { get; set; }

        /// <summary>
        /// Up vector
        /// </summary>
        [ContainerField("up", 16)]
        public Vec3 Up { get; set; }

        /// <summary>
        /// Forward vector
        /// </summary>
        [ContainerField("forward", 32)]
        public Vec3 Forward { get; set; }

        /// <summary>
        /// Transform vector (position)
        /// </summary>
        [ContainerField("trans", 48)]
        public Vec3 Trans { get; set; }

        /// <summary>
        /// Default Identity of a LinearTransform (Matrix.Identity)
        /// </summary>
        public static readonly LinearTransform Identity = new LinearTransform(Vec3.UnitX,
            Vec3.UnitY,
            Vec3.UnitZ,
            Vec3.Zero);

        /// <summary>
        /// Default zero'd LinearTransform (all values are 0)
        /// </summary>
        public static readonly LinearTransform Zero = new LinearTransform(Vec3.Zero,
            Vec3.Zero,
            Vec3.Zero,
            Vec3.Zero);

        /// <summary>
        /// Default constructor
        /// </summary>
        public LinearTransform()
        {
            Right = new Vec3();
            Up = new Vec3();
            Forward = new Vec3();
            Trans = new Vec3();
        }

        /// <summary>
        /// Constructor providing all vector components
        /// </summary>
        /// <param name="p_Right">Right vector component</param>
        /// <param name="p_Up">Up vector component</param>
        /// <param name="p_Forward">Forward vector component</param>
        /// <param name="p_Trans">Transform (position) vector component</param>
        public LinearTransform(Vec3 p_Right, Vec3 p_Up, Vec3 p_Forward, Vec3 p_Trans)
        {
            Right = p_Right;
            Up = p_Up;
            Forward = p_Forward;
            Trans = p_Trans;
        }

        /// <summary>
        /// Binds an object to this LinearTransform
        /// </summary>
        /// <param name="p_Descriptor">FieldDescriptor object for which field should be binded</param>
        /// <param name="p_Value">Object to bind</param>
        public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
        {
            switch ((int) p_Descriptor.NameHash)
            {
                case 194951909:
                    Right = (Vec3) p_Value;
                    break;

                case 5861280:
                    Up = (Vec3) p_Value;
                    break;

                case 1735999518:
                    Forward = (Vec3) p_Value;
                    break;

                case 182273375:
                    Trans = (Vec3) p_Value;
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
                case 194951909:
                    return Right;

                case 5861280:
                    return Up;

                case 1735999518:
                    return Forward;

                case 182273375:
                    return Trans;

                default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

        /// <summary>
        /// Gets the field information by hash
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>PropertyInfo object</returns>
		public override PropertyInfo? GetFieldInfoByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 194951909:
                    return typeof(LinearTransform).GetProperty(nameof(Right));

                case 5861280:
                    return typeof(LinearTransform).GetProperty(nameof(Up));

                case 1735999518:
                    return typeof(LinearTransform).GetProperty(nameof(Forward));

                case 182273375:
                    return typeof(LinearTransform).GetProperty(nameof(Trans));
    
				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>Right, Up, Forward, and Transform vectors</returns>
	    public override string ToString()
	    {
		    return $"{Right} {Up} {Forward} {Trans}";
		}

        /// <summary>
        /// Vector addition
        /// </summary>
        /// <param name="p_First">First vector</param>
        /// <param name="p_Second">Second vector</param>
        /// <returns>Added vector</returns>
        public static LinearTransform operator +(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right + p_Second.Right,
                p_First.Up + p_Second.Up,
                p_First.Forward + p_Second.Forward,
                p_First.Trans + p_Second.Trans);
        }

        /// <summary>
        /// Vector subtraction
        /// </summary>
        /// <param name="p_First">First vector</param>
        /// <param name="p_Second">Second vector</param>
        /// <returns>Subtracted vector</returns>
        public static LinearTransform operator -(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right - p_Second.Right,
                p_First.Up - p_Second.Up,
                p_First.Forward - p_Second.Forward,
                p_First.Trans - p_Second.Trans);
        }

        /// <summary>
        /// Vector multiplication
        /// </summary>
        /// <param name="p_First">First vector</param>
        /// <param name="p_Second">Second vector</param>
        /// <returns>Multiplied vector</returns>
        public static LinearTransform operator *(LinearTransform p_First, LinearTransform p_Second)
        {
            return new LinearTransform(p_First.Right * p_Second.Right,
                p_First.Up * p_Second.Up,
                p_First.Forward * p_Second.Forward,
                p_First.Trans * p_Second.Trans);
        }
    }
}
