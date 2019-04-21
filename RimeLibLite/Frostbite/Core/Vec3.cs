using System;
using System.Reflection;
using RimeLib.IO;
using RimeLib.Math;

namespace RimeLib.Frostbite.Core
{
    /// <summary>
    /// Implementation for fb::Vec3
    /// </summary>
    public class Vec3
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
        /// Z component
        /// </summary>
        public float Z { get; set; }

        /// <summary>
        /// Vector 3 with all components set to zero
        /// </summary>
        public static readonly Vec3 Zero = new Vec3(0, 0, 0);

        /// <summary>
        /// Vector 3 with all components set to one
        /// </summary>
        public static readonly Vec3 One = new Vec3(1, 1, 1);

        /// <summary>
        /// Vector 3 with the X component set to 1
        /// </summary>
        public static readonly Vec3 UnitX = new Vec3(1, 0, 0);

        /// <summary>
        /// Vector 3 with the Y component set to 1
        /// </summary>
        public static readonly Vec3 UnitY = new Vec3(0, 1, 0);

        /// <summary>
        /// Vector 3 with the Z component set to 1
        /// </summary>
        public static readonly Vec3 UnitZ = new Vec3(0, 0, 1);

        /// <summary>
        /// Default constructor
        /// </summary>
        public Vec3()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }

        /// <summary>
        /// Copy constrauctor for Vec3
        /// </summary>
        /// <param name="p_Other">Other vector to copy</param>
	    public Vec3(Vec3 p_Other)
	    {
		    if (p_Other == null)
		    {
			    X = 0;
			    Y = 0;
			    Z = 0;
			    return;
		    }

		    X = p_Other.X;
		    Y = p_Other.Y;
		    Z = p_Other.Z;
	    }

        /// <summary>
        /// Constructor where all components are supplied
        /// </summary>
        /// <param name="p_X">X component</param>
        /// <param name="p_Y">Y component</param>
        /// <param name="p_Z">Z component</param>
        public Vec3(float p_X, float p_Y, float p_Z)
        {
            X = p_X;
            Y = p_Y;
            Z = p_Z;
        }

        /// <summary>
        /// Constructor where the components are read from a reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a Vec3</param>
        /// <param name="_">Unused</param>
        public Vec3(RimeReader p_Reader, bool _ = true)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// Reads the components of a vector from a reader
        /// </summary>
        /// <param name="p_Reader">Reader opened to the position of a Vec3</param>
        public void Deserialize(RimeReader p_Reader)
        {
            X = p_Reader.ReadSingle();
            Y = p_Reader.ReadSingle();
            Z = p_Reader.ReadSingle();
            p_Reader.ReadSingle(); // Padding
        }
		
        /// <summary>
        /// Gets the mangitude of this vector
        /// </summary>
        /// <returns>Magnitude</returns>
        public float GetMagnitude()
        {
			double s_Sum = (X * X) + (Y * Y) + (Z * Z);
			var s_Sq = (float) System.Math.Sqrt(s_Sum);
			return System.Math.Abs(s_Sq);
        }

        /// <summary>
        /// Vector Addition
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Vector with all components added together</returns>
        public static Vec3 operator +(Vec3 p_V1, Vec3 p_V2)
        {
            return (new Vec3(
                p_V1.X + p_V2.X,
                p_V1.Y + p_V2.Y,
                p_V1.Z + p_V2.Z
            ));
        }

        /// <summary>
        /// Vector subtraction
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Vector with all components subtracted</returns>
        public static Vec3 operator -(Vec3 p_V1, Vec3 p_V2)
        {
            return (new Vec3(
                p_V1.X - p_V2.X,
                p_V1.Y - p_V2.Y,
                p_V1.Z - p_V2.Z
            ));
        }

        /// <summary>
        /// Vector negation
        /// </summary>
        /// <param name="p_V1">Vector to negate</param>
        /// <returns>Negated vector</returns>
        public static Vec3 operator -(Vec3 p_V1)
        {
            return (new Vec3(
                -p_V1.X,
                -p_V1.Y,
                -p_V1.Z
            ));
        }
        
        /// <summary>
        /// Vector addition
        /// </summary>
        /// <param name="p_V1">Other vector to add to this vector</param>
        /// <returns>Vector</returns>
        public static Vec3 operator +(Vec3 p_V1)
        {
            return (new Vec3(
                p_V1.X,
                p_V1.Y,
                p_V1.Z
            ));
        }

        /// <summary>
        /// Vector less than
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Returns true if less than, false otherwise</returns>
        public static bool operator <(Vec3 p_V1, Vec3 p_V2)
        {
            return p_V1.GetMagnitude() < p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector less than equal
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if less than or equal, false otherwise</returns>
        public static bool operator <=(Vec3 p_V1, Vec3 p_V2)
        {
            return p_V1.GetMagnitude() <= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector greater than
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if greater than, false otherwise</returns>
        public static bool operator >(Vec3 p_V1, Vec3 p_V2)
        {
            return p_V1.GetMagnitude() > p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector greater than or equal
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if greater than or equal, false otherwise</returns>
        public static bool operator >=(Vec3 p_V1, Vec3 p_V2)
        {
            return p_V1.GetMagnitude() >= p_V2.GetMagnitude();
        }

        /// <summary>
        /// Vector equals
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if equals, false otherwise</returns>
        public static bool operator ==(Vec3 p_V1, Vec3 p_V2)
        {
            if (p_V1 is null || p_V2 is null)
                return false;

            return (
                RimeMath.FloatingEqual(p_V1.X, p_V2.X) &&
                RimeMath.FloatingEqual(p_V1.Y, p_V2.Y) &&
                RimeMath.FloatingEqual(p_V1.Z, p_V2.Z)
            );
        }

        /// <summary>
        /// Vector not equals
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if not equals, false otherwise</returns>
        public static bool operator !=(Vec3 p_V1, Vec3 p_V2)
        {
            return !(p_V1 == p_V2);
        }

        /// <summary>
        /// Vector division
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_S2">Second vector</param>
        /// <returns>Vector</returns>
        public static Vec3 operator /(Vec3 p_V1, float p_S2)
        {
            return new Vec3(p_V1.X / p_S2, p_V1.Y / p_S2, p_V1.Z / p_S2);
        }

        /// <summary>
        /// Vector multiplication 
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_S2">Second vector</param>
        /// <returns>Vector</returns>
        public static Vec3 operator *(Vec3 p_V1, float p_S2)
        {
            return new Vec3(
                p_V1.X * p_S2,
                p_V1.Y * p_S2,
                p_V1.Z * p_S2
            );
        }

        /// <summary>
        /// Vector multiplication by constant
        /// </summary>
        /// <param name="p_S1">Constant to multiply by</param>
        /// <param name="p_V2">Vector</param>
        /// <returns>Vector</returns>
        public static Vec3 operator *(float p_S1, Vec3 p_V2)
        {
            return p_V2 * p_S1;
        }

        /// <summary>
        /// Vector multiplication
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Vector</returns>
        public static Vec3 operator *(Vec3 p_V1, Vec3 p_V2)
        {
            return new Vec3(
                p_V1.X * p_V2.X,
                p_V1.Y * p_V2.Y,
                p_V1.Z * p_V2.Z
            );
        }

        /// <summary>
        /// Vector cross product
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Vector</returns>
        public static Vec3 CrossProduct(Vec3 p_V1, Vec3 p_V2)
        {
            return new Vec3(
                p_V1.Y * p_V2.Z - p_V1.Z * p_V2.Y,
                p_V1.Z * p_V2.X - p_V1.X * p_V2.Z,
                p_V1.X * p_V2.Y - p_V1.Y * p_V2.X
            );
        }

        /// <summary>
        /// Vector cross product
        /// </summary>
        /// <param name="p_V1">Vector to cross with</param>
        /// <returns>Vector</returns>
        public Vec3 CrossProduct(Vec3 p_V1)
        {
            return CrossProduct(this, p_V1);
        }

        /// <summary>
        /// Vector dot product
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>The dot product of both vectors</returns>
        public static float DotProduct(Vec3 p_V1, Vec3 p_V2)
        {
            return (
                p_V1.X * p_V2.X +
                p_V1.Y * p_V2.Y +
                p_V1.Z * p_V2.Z
            );
        }

        /// <summary>
        /// Vector dot product 
        /// </summary>
        /// <param name="p_V1">Other vector to compute dot product with this vector</param>
        /// <returns>The dot product of other vector and this</returns>
        public float DotProduct(Vec3 p_V1)
        {
            return DotProduct(this, p_V1);
        }

        /// <summary>
        /// Is this vector a unit vector
        /// </summary>
        /// <param name="p_V1">Vector to see if its a unit vector</param>
        /// <returns>True if unit vector, false otherwise</returns>
        public static bool IsUnitVector(Vec3 p_V1)
        {
            return RimeMath.FloatingEqual(p_V1.GetMagnitude(), 1.0f);
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
        /// Vector normalize
        /// </summary>
        /// <param name="p_V1">Vector to normalize</param>
        /// <returns>Vector</returns>
        public static Vec3 Normalize(Vec3 p_V1)
        {
            if (RimeMath.FloatingEqual(p_V1.GetMagnitude(), 0.0f))
                throw new DivideByZeroException("Cannot normalize a vector with a magnitude of zero.");

            var s_Inv = 1.0f / p_V1.GetMagnitude();

            return new Vec3(
                p_V1.X * s_Inv,
                p_V1.Y * s_Inv,
                p_V1.Z * s_Inv
            );
        }

        /// <summary>
        /// Assign other vector components to this vector
        /// </summary>
        /// <param name="p_Other">Other vector</param>
	    public void Assign(Vec3 p_Other)
	    {
		    if (p_Other == null)
			    return;

		    X = p_Other.X;
		    Y = p_Other.Y;
		    Z = p_Other.Z;
	    }

        /// <summary>
        /// Normalize this vector
        /// </summary>
        public void Normalize()
        {
            Assign(Normalize(this));
        }

        /// <summary>
        /// Interoplate
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <param name="p_Control">Control between 0 and 1</param>
        /// <returns></returns>
        public static Vec3 Interoplate(Vec3 p_V1, Vec3 p_V2, float p_Control)
        {
            if (p_Control > 1f || p_Control < 0f)
                throw new ArgumentOutOfRangeException("Control cannot be less than zero or greater than one.");

            return new Vec3(
                p_V1.X * (1 - p_Control) + p_V2.X * p_Control,
                p_V1.Y * (1 - p_Control) + p_V2.Y * p_Control,
                p_V1.Z * (1 - p_Control) + p_V2.Z * p_Control
            );
        }

        /// <summary>
        /// Vector interoplation
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_Control">Control between 0 and 1</param>
        /// <returns>Interoplated vector</returns>
        public Vec3 Interoplate(Vec3 p_V1, float p_Control)
        {
            return Interoplate(this, p_V1, p_Control);
        }

        /// <summary>
        /// Calculates the distance between two vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Distance between vectors</returns>
        public static float Distance(Vec3 p_V1, Vec3 p_V2)
        {
            return (float) System.Math.Sqrt(
                (p_V1.X - p_V2.X) * (p_V1.X - p_V2.X) +
                (p_V1.Y - p_V2.Y) * (p_V1.Y - p_V2.Y) +
                (p_V1.Z - p_V2.Z) * (p_V1.Z - p_V2.Z)
            );
        }

        /// <summary>
        /// Calculates the distance betwene this vector and supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Distance</returns>
        public float Distance(Vec3 p_V1)
        {
            return Distance(this, p_V1);
        }

        /// <summary>
        /// Vector absolute value
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Magnitude</returns>
        public static float Abs(Vec3 p_V1)
        {
            return p_V1.GetMagnitude();
        }

        /// <summary>
        /// Absolute value of this vector
        /// </summary>
        /// <returns>Magnitude of this vector</returns>
        public float Abs()
        {
            return GetMagnitude();
        }

        /// <summary>
        /// Calculate the angle between two vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Seocnd vector</param>
        /// <returns>Angle between the vectors</returns>
        public static float Angle(Vec3 p_V1, Vec3 p_V2)
        {
            return (float) System.Math.Acos(Normalize(p_V1).DotProduct(Normalize(p_V2)));
        }
        
        /// <summary>
        /// Angle between this vector and supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Angle between this vector and the supplied vector</returns>
        public float Angle(Vec3 p_V1)
        {
            return Angle(this, p_V1);
        }

        /// <summary>
        /// Max between two vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>The maximum most vector</returns>
        public static Vec3 Max(Vec3 p_V1, Vec3 p_V2)
        {
            if (p_V1 >= p_V2)
                return p_V1;

            return p_V2;
        }

        /// <summary>
        /// Max between this vector and supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Vector</returns>
        public Vec3 Max(Vec3 p_V1)
        {
            return Max(this, p_V1);
        }

        /// <summary>
        /// Minimum between two vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Minimum most vector</returns>
        public static Vec3 Min(Vec3 p_V1, Vec3 p_V2)
        {
            if (p_V1 <= p_V2)
                return p_V1;

            return p_V2;
        }

        /// <summary>
        /// Minimum between this and supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Minimum between this and supplied vector</returns>
        public Vec3 Min(Vec3 p_V1)
        {
            return Min(this, p_V1);
        }

        /// <summary>
        /// Add a degree of pitch to a vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_Degree">Degrees</param>
        /// <returns>Vector with added pitch</returns>
        public static Vec3 Pitch(Vec3 p_V1, float p_Degree)
        {
            var s_X = p_V1.X;
            var s_Y = (p_V1.Y * (float) System.Math.Cos(p_Degree)) - (p_V1.Z * (float) System.Math.Sin(p_Degree));
            var s_Z = (p_V1.Y * (float) System.Math.Sin(p_Degree)) + (p_V1.Z * (float) System.Math.Cos(p_Degree));

            return new Vec3(s_X, s_Y, s_Z);
        }

        /// <summary>
        /// Add pitch to this vector
        /// </summary>
        /// <param name="p_Degree">Degrees</param>
        public void Pitch(float p_Degree)
        {
			Assign(Pitch(this, p_Degree));
        }

        /// <summary>
        /// Adds yaw to a vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_Degree">Degrees</param>
        /// <returns>Vector with added yaw</returns>
        public static Vec3 Yaw(Vec3 p_V1, float p_Degree)
        {
            var s_X = (p_V1.Z * (float) System.Math.Sin(p_Degree)) + (p_V1.X * (float) System.Math.Cos(p_Degree));
            var s_Y = p_V1.Y;
            var s_Z = (p_V1.Z * (float) System.Math.Cos(p_Degree)) - (p_V1.X * (float) System.Math.Sin(p_Degree));

            return new Vec3(s_X, s_Y, s_Z);
        }

        /// <summary>
        /// Add yaw to this vector
        /// </summary>
        /// <param name="p_Degree">Degrees</param>
        public void Yaw(float p_Degree)
        {
			Assign(Yaw(this, p_Degree));
        }

        /// <summary>
        /// Add roll to a vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_Degree">Degrees</param>
        /// <returns>vector with added roll</returns>
        public static Vec3 Roll(Vec3 p_V1, float p_Degree)
        {
            var s_X = (p_V1.X * (float) System.Math.Cos(p_Degree)) - (p_V1.Y * (float) System.Math.Sin(p_Degree));
            var s_Y = (p_V1.X * (float) System.Math.Sin(p_Degree)) + (p_V1.Y * (float) System.Math.Cos(p_Degree));
            var s_Z = p_V1.Z;

            return new Vec3(s_X, s_Y, s_Z);
        }

        /// <summary>
        /// If back facing
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Returns true if backfacing, false otherwise</returns>
        public static bool IsBackFace(Vec3 p_V1, Vec3 p_V2)
        {
            return p_V1.DotProduct(p_V2) < 0;
        }

        /// <summary>
        /// Is this vector back facing to the supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>True if backfacing, false otherwise</returns>
        public bool IsBackFace(Vec3 p_V1)
        {
            return IsBackFace(this, p_V1);
        }

        /// <summary>
        /// Compares two vectors to see if they are perpendicular
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>True if perpendicular, false otherwise</returns>
        public static bool IsPerpendicular(Vec3 p_V1, Vec3 p_V2)
        {
            return RimeMath.FloatingEqual(p_V1.DotProduct(p_V2), 0);
        }

        /// <summary>
        /// Is this vector perpendicular to supplied vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>True if perpendicular, false otherwise</returns>
        public bool IsPerpendicular(Vec3 p_V1)
        {
            return IsPerpendicular(this, p_V1);
        }

        /// <summary>
        /// Calculates the mixed product between 3 vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <param name="p_V3">Third vector</param>
        /// <returns>Mixed product of the vectors</returns>
        public static float MixedProduct(Vec3 p_V1, Vec3 p_V2, Vec3 p_V3)
        {
            return DotProduct(CrossProduct(p_V1, p_V2), p_V3);
        }

        /// <summary>
        /// Calculates the mixed product between this and 2 vectors
        /// </summary>
        /// <param name="p_V1">First vector</param>
        /// <param name="p_V2">Second vector</param>
        /// <returns>Mixed product between the vectors</returns>
        public float MixedProduct(Vec3 p_V1, Vec3 p_V2)
        {
            return DotProduct(CrossProduct(this, p_V1), p_V2);
        }

        /// <summary>
        /// Sum of the components
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Sum of the components of the vector</returns>
        public static float SumComponents(Vec3 p_V1)
        {
            return (p_V1.X + p_V1.Y + p_V1.Z);
        }

        /// <summary>
        /// Sum of the components of this vector
        /// </summary>
        /// <returns>Sun of components</returns>
        public float SumComponents()
        {
            return SumComponents(this);
        }

        /// <summary>
        /// Raise all components to supplied power
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <param name="p_Power">Power to raise</param>
        /// <returns>Vector raised to supplied power</returns>
        public static Vec3 PowComponents(Vec3 p_V1, float p_Power)
        {
            return new Vec3(
                (float) System.Math.Pow(p_V1.X, p_Power),
                (float) System.Math.Pow(p_V1.Y, p_Power),
                (float) System.Math.Pow(p_V1.Z, p_Power)
            );
        }

        /// <summary>
        /// Raise this vector to supplied power
        /// </summary>
        /// <param name="p_Power">Power to raise</param>
        public void PowComponents(float p_Power)
        {
			Assign(PowComponents(this, p_Power));
        }

        /// <summary>
        /// Square root of components
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Vector square rooted</returns>
        public static Vec3 SqrtComponents(Vec3 p_V1)
        {
            return new Vec3(
                (float) System.Math.Sqrt(p_V1.X),
                (float) System.Math.Sqrt(p_V1.Y),
                (float) System.Math.Sqrt(p_V1.Z)
            );
        }

        /// <summary>
        /// Square root the components of this vector
        /// </summary>
        public void SqrtComponents()
        {
			Assign(SqrtComponents(this));
        }

        /// <summary>
        /// Square components of vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Squared vector</returns>
        public static Vec3 SqrComponents(Vec3 p_V1)
        {
            return new Vec3(
                p_V1.X * p_V1.X,
                p_V1.Y * p_V1.Y,
                p_V1.Z * p_V1.Z
            );
        }

        /// <summary>
        /// Square components of this vector
        /// </summary>
        public void SqrComponents()
        {
			Assign(SqrComponents(this));
        }

        /// <summary>
        /// Sum of the squared components of vector
        /// </summary>
        /// <param name="p_V1">Vector</param>
        /// <returns>Sum of squared components</returns>
        public static float SumComponentSqrs(Vec3 p_V1)
        {
            Vec3 v2 = SqrComponents(p_V1);
            return v2.SumComponents();
        }

        /// <summary>
        /// Calculate the sum of this vectors components squared
        /// </summary>
        /// <returns>Sum of squared components</returns>
        public float SumComponentSqrs()
        {
            return SumComponentSqrs(this);
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns>X, Y, and Z components</returns>
        public override string ToString()
        {
            return $"({X}, {Y}, {Z})";
        }
        
        /// <summary>
        /// Writes the components of this vector to an open writer
        /// </summary>
        /// <param name="p_Writer">Writer opened to the position to write the vector</param>
        public void Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(X);
            p_Writer.Write(Y);
            p_Writer.Write(Z);
            p_Writer.Write(0);
        }

        protected bool Equals(Vec3 p_Other)
        {
            return X.Equals(p_Other.X) && Y.Equals(p_Other.Y) && Z.Equals(p_Other.Z);
        }

        public override bool Equals(object p_Obj)
        {
            if (ReferenceEquals(null, p_Obj))
                return false;

            if (ReferenceEquals(this, p_Obj))
                return true;

            if (p_Obj.GetType() != GetType())
                return false;

            return Equals((Vec3) p_Obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var s_HashCode = X.GetHashCode();

                s_HashCode = (s_HashCode * 397) ^ Y.GetHashCode();
                s_HashCode = (s_HashCode * 397) ^ Z.GetHashCode();

                return s_HashCode;
            }
        }
    }
}
