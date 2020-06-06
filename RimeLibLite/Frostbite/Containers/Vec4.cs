using System;
using System.Reflection;
using RimeLib.IO;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Ebx;

namespace RimeLib.Serialization.Containers
{
    /// <summary>
    /// Implementation of fb::Vec4
    /// </summary>
    [ContainerType(16)]
    public class Vec4 : FrostbiteContainer
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
        /// Z component
        /// </summary>
        [ContainerField("z", 8)]
        public float Z { get; set; }

        /// <summary>
        /// W component
        /// </summary>
        [ContainerField("w", 12)]
        public float W { get; set; }
		
        /// <summary>
        /// Default constructor
        /// </summary>
        public Vec4()
        {
            X = 0;
            Y = 0;
            Z = 0;
            W = 0;
        }

        /// <summary>
        /// Constructor where the components are supplied
        /// </summary>
        /// <param name="p_X">X component</param>
        /// <param name="p_Y">Y component</param>
        /// <param name="p_Z">Z component</param>
        /// <param name="p_W">W component</param>
        public Vec4(float p_X, float p_Y, float p_Z, float p_W)
        {
            X = p_X;
            Y = p_Y;
            Z = p_Z;
            W = p_W;
        }

        /// <summary>
        /// Constructor that reads the vector from an open reader
        /// </summary>
        /// <param name="p_Reader">Opened reader to the position where to read the vector</param>
        public Vec4(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Reads the vector from an open reader
        /// </summary>
        /// <param name="p_Reader">Opened reader to the position of the vector</param>
        public void Deserialize(RimeReader p_Reader)
        {
            X = p_Reader.ReadSingle();
            Y = p_Reader.ReadSingle();
            Z = p_Reader.ReadSingle();
            W = p_Reader.ReadSingle();
        }
		
        /// <summary>
        /// Gets the magnitude of this vector
        /// </summary>
        /// <returns>Magnitude</returns>
		public float GetMagnitude()
        {
            float sum = (X * X) + (Y * Y) + (Z * Z) + (W * W);
            float sq = (float) System.Math.Sqrt((double)sum);
            return System.Math.Abs(sq);
        }

        /// <summary>
        /// Vector addition
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns></returns>
        public static Vec4 operator +(Vec4 p_V1, Vec4 p_V2)
        {
            return (new Vec4(
                p_V1.X + p_V2.X,
                p_V1.Y + p_V2.Y,
                p_V1.Z + p_V2.Z,
                p_V1.W + p_V2.W));
        }

        /// <summary>
        /// Vector subtraction
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Subtracted vector</returns>
        public static Vec4 operator -(Vec4 p_V1, Vec4 p_V2)
        {
            return (new Vec4(
                p_V1.X - p_V2.X,
                p_V1.Y - p_V2.Y,
                p_V1.Z - p_V2.Z,
                p_V1.W - p_V2.W));
        }

        /// <summary>
        /// Vector negation
        /// </summary>
        /// <param name="p_V1">Vector to negate</param>
        /// <returns>Negated vector</returns>
        public static Vec4 operator -(Vec4 p_V1)
        {
            return (new Vec4(
                -p_V1.X,
                -p_V1.Y,
                -p_V1.Z,
                -p_V1.W));
        }

        /// <summary>
        /// Vector ?
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Vector</returns>
        public static Vec4 operator +(Vec4 p_V1)
        {
            return (new Vec4(
                +p_V1.X,
                +p_V1.Y,
                +p_V1.Z,
                +p_V1.W));
        }

        /// <summary>
        /// Vector less than
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Returns true if less than, false otherwise</returns>
        public static bool operator <(Vec4 p_V1, Vec4 p_V2)
        {
            return p_V1.GetMagnitude() < p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector less than equal
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if less than or equal, false otherwise</returns>
        public static bool operator <=(Vec4 p_V1, Vec4 p_V2)
        {
            return p_V1.GetMagnitude() <= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector greater than
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if greater than, false otherwise</returns>
        public static bool operator >(Vec4 p_V1, Vec4 p_V2)
        {
            return p_V1.GetMagnitude() > p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector greater than or equal
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if greater than or equal, false otherwise</returns>
        public static bool operator >=(Vec4 p_V1, Vec4 p_V2)
        {
            return p_V1.GetMagnitude() >= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector equals
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if equals, false otherwise</returns>
        public static bool operator ==(Vec4 p_V1, Vec4 p_V2)
        {
            return (System.Math.Abs(p_V1.X - p_V2.X) < float.Epsilon &&
                    System.Math.Abs(p_V1.Y - p_V2.Y) < float.Epsilon &&
                    System.Math.Abs(p_V1.Z - p_V2.Z) < float.Epsilon &&
                    System.Math.Abs(p_V1.W - p_V2.W) < float.Epsilon);
        }

        /// <summary>
        /// Vector not equals
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if not equal, false otherwise</returns>
        public static bool operator !=(Vec4 p_V1, Vec4 p_V2)
        {
            return !(p_V1 == p_V2);
        }

        /// <summary>
        /// Operator division with constant
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_S2">Constant to divide by</param>
        /// <returns>Vector</returns>
        public static Vec4 operator /(Vec4 p_V1, float p_S2)
        {
            return new Vec4(p_V1.X / p_S2, p_V1.Y / p_S2, p_V1.Z / p_S2, p_V1.W / p_S2);
        }

        /// <summary>
        /// Vector multiplication with constant
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_S2">Constant to divide by</param>
        /// <returns>Vector</returns>
        public static Vec4 operator *(Vec4 p_V1, float p_S2)
        {
            return new Vec4(
                p_V1.X * p_S2,
                p_V1.Y * p_S2,
                p_V1.Z * p_S2,
                p_V1.W * p_S2);
        }

        /// <summary>
        /// Vector multiplication with a constant
        /// </summary>
        /// <param name="p_S1">Constant</param>
        /// <param name="p_V2">Vector</param>
        /// <returns></returns>
        public static Vec4 operator *(float p_S1, Vec4 p_V2)
        {
            return p_V2 * p_S1;
        }

        /// <summary>
        /// Is the supplied vector a unit vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>True if unit vector, false otherwise</returns>
        public static bool IsUnitVector(Vec4 p_V1)
        {
            return System.Math.Abs(p_V1.GetMagnitude() - 0) < float.Epsilon;
        }

        /// <summary>
        /// Is this vector a unit vector
        /// </summary>
        /// <returns>True if unit vector, false otherwise</returns>
        public bool IsUnitVector()
        {
            return IsUnitVector(this);
        }

        /// <summary>
        /// Normaizes supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Normalized vector</returns>
        public static Vec4 Normalize(Vec4 p_V1)
        {
            if (p_V1.GetMagnitude() <= float.Epsilon)
                throw new DivideByZeroException("Cannot normalize a vector with a magnitude of zero.");
            else
            {
                float inv = 1 / p_V1.GetMagnitude();
                return new Vec4(
                    p_V1.X * inv,
                    p_V1.Y * inv,
                    p_V1.Z * inv,
                    p_V1.W * inv);
            }
        }

        /// <summary>
        /// Assign supplied vector to this vector
        /// </summary>
        /// <param name="p_Other">Vector</param>
	    public void Assign(Vec4 p_Other)
	    {
		    //if (p_Other == null)
			   // return;

		    X = p_Other.X;
		    Y = p_Other.Y;
		    Z = p_Other.Z;
		    W = p_Other.W;
	    }
        /// <summary>
        /// Normalize this vector
        /// </summary>
        public void Normalize()
        {
            Assign(Normalize(this));
        }

        /// <summary>
        /// Calculate the vector between two vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Distance</returns>
        public static float Distance(Vec4 p_V1, Vec4 p_V2)
        {
            return (float) System.Math.Sqrt(
                (p_V1.X - p_V2.X) * (p_V1.X - p_V2.X) +
                (p_V1.Y - p_V2.Y) * (p_V1.Y - p_V2.Y) +
                (p_V1.Z - p_V2.Z) * (p_V1.Z - p_V2.Z) +
                (p_V1.W - p_V2.W) * (p_V1.W - p_V2.W));
        }

        /// <summary>
        /// Calculate the vector between this and a supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Distance</returns>
        public float Distance(Vec4 p_V1)
        {
            return Distance(this, p_V1);
        }

        /// <summary>
        /// Calculate the absolute value of supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Magnitude</returns>
        public static float Abs(Vec4 p_V1)
        {
            return p_V1.GetMagnitude();
        }

        /// <summary>
        /// Calculates the absolute value of this vector
        /// </summary>
        /// <returns>Magnitude</returns>
        public float Abs()
        {
            return GetMagnitude();
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>X, Y, Z, W components</returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z}, {W})";
        }

        /// <summary>
        /// Bind values to this vector
        /// </summary>
        /// <param name="p_Descriptor">Field Descriptor</param>
        /// <param name="p_Value">Value to bind</param>
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

				case 177631:
					Z = (float)p_Value;
					break;

				case 177618:
                    W = (float) p_Value;
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
                case 177629:
                    return X;

                case 177628:
                    return Y;

                case 177631:
                    return Z;

                case 177618:
                    return W;

                default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

        /// <summary>
        /// Gets field information by name hash
        /// </summary>
        /// <param name="p_Hash">Name hash</param>
        /// <returns>Property information</returns>
		public override PropertyInfo? GetFieldInfoByHash(uint p_Hash)
		{
			switch ((int) p_Hash)
            {
                case 177629:
                    return typeof(Vec4).GetProperty(nameof(X));

                case 177628:
                    return typeof(Vec4).GetProperty(nameof(Y));

                case 177631:
                    return typeof(Vec4).GetProperty(nameof(Z));

                case 177618:
                    return typeof(Vec4).GetProperty(nameof(W));
    
				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}

        protected bool Equals(Vec4 other)
        {
            return X.Equals(other.X) && Y.Equals(other.Y) && Z.Equals(other.Z) && W.Equals(other.W);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Vec4) obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = X.GetHashCode();
                hashCode = (hashCode*397) ^ Y.GetHashCode();
                hashCode = (hashCode*397) ^ Z.GetHashCode();
                hashCode = (hashCode*397) ^ W.GetHashCode();
                return hashCode;
            }
        }
    }
}
