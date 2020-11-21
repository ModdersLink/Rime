using System;
using System.Reflection;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Frostbite's built in 2D Vector Library
    /// </summary>
    [ContainerType(4), ContainerStruct]
    public class Vec2 : FrostbiteContainer
    {
        /// <summary>
        /// X component
        /// </summary>
        [ContainerField("x")]
        public float X { get; set; }

        /// <summary>
        /// Y component
        /// </summary>
        [ContainerField("y", 4)]
        public float Y { get; set; }
        
        /// <summary>
        /// Default constructor
        /// </summary>
        public Vec2()
        {
            X = 0;
            Y = 0;
        }

        /// <summary>
        /// Reads out a Vec2 object from opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the Vec2 object</param>
        public Vec2(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Creates a Vec2 from components
        /// </summary>
        /// <param name="p_X">X component</param>
        /// <param name="p_Y">Y component</param>
        public Vec2(float p_X, float p_Y)
        {
            X = p_X;
            Y = p_Y;
        }

        /// <summary>
        /// Loads a Vec2 from an opened reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of the Vec2 object</param>
        public void Deserialize(RimeReader p_Reader)
        {
            X = p_Reader.ReadSingle();
            Y = p_Reader.ReadSingle();
        }
		
        /// <summary>
        /// Gets the magnitude of the vector
        /// </summary>
        /// <returns>Magnitude</returns>
		public float GetMagnitude()
        {
            float sum = (X * X) + (Y * Y);
		float sq = (float)System.Math.Sqrt((double)sum);
            return System.Math.Abs(sq);
        }

        /// <summary>
        /// Addition operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>Vec2</returns>
        public static Vec2 operator +(Vec2 p_V1, Vec2 p_V2)
        {
            return (new Vec2(
                p_V1.X + p_V2.X,
                p_V1.Y + p_V2.Y));
        }

        /// <summary>
        /// Subtraction operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>Subtracted vector</returns>
        public static Vec2 operator -(Vec2 p_V1, Vec2 p_V2)
        {
            return (new Vec2(
                p_V1.X - p_V2.X,
                p_V1.Y - p_V2.Y));
        }

        /// <summary>
        /// Local subtraction operator
        /// </summary>
        /// <param name="p_V1">Vec2 to subtract</param>
        /// <returns>Subtracted vector</returns>
        public static Vec2 operator -(Vec2 p_V1)
        {
            return (new Vec2(
                -p_V1.X,
                -p_V1.Y));
        }

        /// <summary>
        /// Local addition operator
        /// </summary>
        /// <param name="p_V1">Vec2 to add</param>
        /// <returns>Added vector</returns>
        public static Vec2 operator +(Vec2 p_V1)
        {
            return (new Vec2(
                +p_V1.X,
                +p_V1.Y));
        }

        /// <summary>
        /// Less than operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if first is less than second, false otherwise</returns>
        public static bool operator <(Vec2 p_V1, Vec2 p_V2)
        {
            return p_V1.GetMagnitude() < p_V2.GetMagnitude();
        }

        /// <summary>
        /// Less than equal operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if less than or equal, false otherwise</returns>
        public static bool operator <=(Vec2 p_V1, Vec2 p_V2)
        {
            return p_V1.GetMagnitude() <= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Greater than operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if first vector is greater than the second, false otherwise</returns>
        public static bool operator >(Vec2 p_V1, Vec2 p_V2)
        {
            return p_V1.GetMagnitude() > p_V2.GetMagnitude();
        }

        /// <summary>
        /// Greater than equal operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if first vector is greater than or equal the second, false otherwise</returns>
        public static bool operator >=(Vec2 p_V1, Vec2 p_V2)
        {
            return p_V1.GetMagnitude() >= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Equals operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if equals, false otherwise</returns>
        public static bool operator ==(Vec2 p_V1, Vec2 p_V2)
        {
            return (
                System.Math.Abs(p_V1.X - p_V2.X) < float.Epsilon &&
                System.Math.Abs(p_V1.Y - p_V2.Y) < float.Epsilon);
        }

        /// <summary>
        /// Not equals operator
        /// </summary>
        /// <param name="p_V1">First Vec2</param>
        /// <param name="p_V2">Second Vec2</param>
        /// <returns>True if equal, false otherwise</returns>
        public static bool operator !=(Vec2 p_V1, Vec2 p_V2)
        {
            return !(p_V1 == p_V2);
        }

        public static Vec2 operator /(Vec2 p_V1, float p_S2)
        {
            return new Vec2(p_V1.X / p_S2, p_V1.Y / p_S2);
        }

        public static Vec2 operator *(Vec2 p_V1, float p_S2)
        {
            return new Vec2(
                p_V1.X * p_S2,
                p_V1.Y * p_S2);
        }

        public static Vec2 operator *(float p_S1, Vec2 p_V2)
        {
            return p_V2 * p_S1;
        }

        public static bool IsUnitVector(Vec2 p_V1)
        {
            return System.Math.Abs(p_V1.GetMagnitude() - 1.0f) < float.Epsilon;
        }

        public bool IsUnitVector()
        {
            return IsUnitVector(this);
        }

        public static Vec2 Normalize(Vec2 p_V1)
        {
            if (System.Math.Abs(p_V1.GetMagnitude() - 1.0f) < float.Epsilon)
                throw new DivideByZeroException("Cannot normalize a vector with a magnitude of zero.");
            else
            {
                float inv = 1 / p_V1.GetMagnitude();
                return new Vec2(
                    p_V1.X * inv,
                    p_V1.Y * inv);
            }
        }

	    public void Assign(Vec2 p_Other)
	    {
		    //if (p_Other == null)
			   // return;

		    X = p_Other.X;
		    Y = p_Other.Y;
	    }

        public void Normalize()
        {
            Assign(Normalize(this));
        }

        public static Vec2 Interoplate(Vec2 p_V1, Vec2 p_V2, float p_Control)
        {
            if (p_Control > 1f || p_Control < 0f)
                throw new ArgumentOutOfRangeException("Control cannot be less than zero or greater than one.");
            else
                return new Vec2(p_V1.X * (1 - p_Control) + p_V2.X * p_Control,
                            p_V1.Y * (1 - p_Control) + p_V2.Y * p_Control);
        }

        public Vec2 Interoplate(Vec2 p_V1, float p_Control)
        {
            return Interoplate(this, p_V1, p_Control);
        }

        public static float Distance(Vec2 p_V1, Vec2 p_V2)
        {
            return (float) System.Math.Sqrt(
                (p_V1.X - p_V2.X) * (p_V1.X - p_V2.X) +
                (p_V1.Y - p_V2.Y) * (p_V1.Y - p_V2.Y));
        }

        public float Distance(Vec2 p_V1)
        {
            return Distance(this, p_V1);
        }

        public static float Abs(Vec2 p_V1)
        {
            return p_V1.GetMagnitude();
        }

        public float Abs()
        {
            return GetMagnitude();
        }

        public static Vec2 Max(Vec2 p_V1, Vec2 p_V2)
        {
            if (p_V1 >= p_V2)
                return p_V1;
            return p_V2;
        }

        public Vec2 Max(Vec2 p_V1)
        {
            return Max(this, p_V1);
        }

        public static Vec2 Min(Vec2 p_V1, Vec2 p_V2)
        {
            if (p_V1 <= p_V2)
                return p_V1;
            return p_V2;
        }

        public Vec2 Min(Vec2 p_V1)
        {
            return Min(this, p_V1);
        }

        public static float SumComponents(Vec2 p_V1)
        {
            return (p_V1.X + p_V1.Y);
        }

        public float SumComponents()
        {
            return SumComponents(this);
        }

        public static Vec2 PowComponents(Vec2 p_V1, float p_Power)
        {
            return new Vec2((float) System.Math.Pow(p_V1.X, p_Power),
                (float) System.Math.Pow(p_V1.Y, p_Power));
        }

        public void PowComponents(float p_Power)
        {
            Assign(PowComponents(this, p_Power));
        }

        public static Vec2 SqrtComponents(Vec2 p_V1)
        {
            return new Vec2(
                (float) System.Math.Sqrt(p_V1.X),
                (float) System.Math.Sqrt(p_V1.Y));
        }

        public void SqrtComponents()
        {
            Assign(SqrtComponents(this));
        }

        public static Vec2 SqrComponents(Vec2 p_V1)
        {
            return new Vec2(p_V1.X * p_V1.X,
                p_V1.Y * p_V1.Y);
        }

        public void SqrComponents()
        {
            Assign(SqrComponents(this));
        }

        public static float SumComponentSqrs(Vec2 p_V1)
        {
            Vec2 v2 = SqrComponents(p_V1);
            return v2.SumComponents();
        }

        public float SumComponentSqrs()
        {
            return SumComponentSqrs(this);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }

        public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
        {
            switch ((int) p_Descriptor.NameHash)
            {
                case 177629:
                    X = (float) p_Value;
                    break;

                case 177628:
                    Y = (float) p_Value;
                    break;

                default:
                    base.Bind(p_Descriptor, p_Value);
                    break;
            }
        }
        
		public override object? GetFieldValueByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 177629:
                    return X;

                case 177628:
                    return Y;
                    
                default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo? GetFieldInfoByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 177629:
                    return typeof(Vec2).GetProperty(nameof(X));

                case 177628:
                    return typeof(Vec2).GetProperty(nameof(Y));
                    
				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}

        protected bool Equals(Vec2 other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y);
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vec2) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode()*397) ^ Y.GetHashCode();
            }
        }
    }
}
