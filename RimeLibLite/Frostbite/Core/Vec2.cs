using System;
using System.Reflection;
using RimeLib.IO;
using RimeLib.Math;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Frostbite's built in 2D Vector Library
    /// </summary>
    public class Vec2
    {
        /// <summary>
        /// X component
        /// </summary>
        public float X { get; set; }

        /// <summary>
        /// Y component
        /// </summary>
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
            double s_Sum = (X * X) + (Y * Y);
		    var s_Sq = (float) System.Math.Sqrt(s_Sum);
            return System.Math.Abs(s_Sq);
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
                p_V1.Y + p_V2.Y
            ));
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
                p_V1.Y - p_V2.Y
            ));
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
                -p_V1.Y
            ));
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
                +p_V1.Y
            ));
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
            if (p_V1 is null || p_V2 is null)
                return false;

            return (
                RimeMath.FloatingEqual(p_V1.X, p_V2.X) &&
                RimeMath.FloatingEqual(p_V1.Y, p_V2.Y)
            );
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
                p_V1.Y * p_S2
            );
        }

        public static Vec2 operator *(float p_S1, Vec2 p_V2)
        {
            return p_V2 * p_S1;
        }

        public static bool IsUnitVector(Vec2 p_V1)
        {
            return RimeMath.FloatingEqual(p_V1.GetMagnitude(), 1.0f);
        }

        public bool IsUnitVector()
        {
            return IsUnitVector(this);
        }

        public static Vec2 Normalize(Vec2 p_V1)
        {
            if (RimeMath.FloatingEqual(p_V1.GetMagnitude(), 0.0f))
                throw new DivideByZeroException("Cannot normalize a vector with a magnitude of zero.");

            var s_Inv = 1.0f / p_V1.GetMagnitude();

            return new Vec2(
                p_V1.X * s_Inv,
                p_V1.Y * s_Inv
            );
        }

	    public void Assign(Vec2 p_Other)
	    {
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

            return new Vec2(
                p_V1.X * (1 - p_Control) + p_V2.X * p_Control,
                p_V1.Y * (1 - p_Control) + p_V2.Y * p_Control
            );
        }

        public Vec2 Interoplate(Vec2 p_V1, float p_Control)
        {
            return Interoplate(this, p_V1, p_Control);
        }

        public static float Distance(Vec2 p_V1, Vec2 p_V2)
        {
            return (float) System.Math.Sqrt(
                (p_V1.X - p_V2.X) * (p_V1.X - p_V2.X) +
                (p_V1.Y - p_V2.Y) * (p_V1.Y - p_V2.Y)
            );
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
            return new Vec2(
                (float) System.Math.Pow(p_V1.X, p_Power),
                (float) System.Math.Pow(p_V1.Y, p_Power)
            );
        }

        public void PowComponents(float p_Power)
        {
            Assign(PowComponents(this, p_Power));
        }

        public static Vec2 SqrtComponents(Vec2 p_V1)
        {
            return new Vec2(
                (float) System.Math.Sqrt(p_V1.X),
                (float) System.Math.Sqrt(p_V1.Y)
            );
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
        
        protected bool Equals(Vec2 p_Other)
        {
            return X.Equals(p_Other.X) && Y.Equals(p_Other.Y);
        }

        public override bool Equals(object p_Obj)
        {
            if (ReferenceEquals(null, p_Obj))
                return false;

            if (ReferenceEquals(this, p_Obj))
                return true;

            if (p_Obj.GetType() != GetType())
                return false;

            return Equals((Vec2) p_Obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X.GetHashCode() * 397) ^ Y.GetHashCode();
            }
        }
    }
}
