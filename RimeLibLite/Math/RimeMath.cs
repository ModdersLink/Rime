using System.Numerics;
using System.Runtime.InteropServices;


namespace RimeLib.Math
{
    public static class RimeMath
    {
        [StructLayout(LayoutKind.Explicit)]
        private struct HalfConversionUnion
        {
            [FieldOffset(0)]
            public uint m_IntValue;

            [FieldOffset(0)]
            public float m_FloatValue;
        }

        public const float c_FbEpsilon = 0.000001f;

        public static bool FloatingEqual(float p_One, float p_Two)
        {
            return System.Math.Abs(p_One - p_Two) < c_FbEpsilon;
        }

        public static float HalfToFloat(ushort p_Value)
        {
            return Half.ToHalf(p_Value);
        }

        public static ushort FloatToHalf(float p_Value)
        {
            var s_Union = new HalfConversionUnion()
            {
                m_FloatValue = p_Value
            };
            
            var s_IntValue = s_Union.m_IntValue;
            var s_Sign = (s_IntValue & 0x80000000) >> 16;

            s_IntValue &= 0x7FFFFFFF;
            s_IntValue += 0xC8000000;

            return (ushort) (s_Sign | ((s_IntValue + 0xFFF + ((s_IntValue >> 13) & 1)) >> 13));
        }
        
        public static double BiCubicKernel(double p_Value)
        {
            if (p_Value < 0)
                p_Value = -p_Value;
            
            if (p_Value <= 1)
                return (1.5 * p_Value - 2.5) * p_Value * p_Value + 1;

            if (p_Value < 2)
                return ((-0.5 * p_Value + 2.5) * p_Value - 4) * p_Value + 2;

            return 0;
        }

        public static long RoundUp(long p_Value, long p_Base)
        {
            return (p_Value + (p_Base - 1)) & ~(p_Base - 1);
        }
        
        /// <summary>
        /// Convert Up/Right/Forward basis vectors to a Quaternion.
        /// - forwardIsLookDir=true: your Forward points where you look (use -Z in RH frames).
        /// - inputsAreColumns=true: vectors are basis COLUMNS (glTF-style). false = basis ROWS (DX-style).
        /// </summary>
        public static Quaternion FromUpRightForward(
            Vector3 up, Vector3 right, Vector3 forward,
            bool forwardIsLookDir = false,
            bool inputsAreColumns = true,
            bool orthonormalize = true)
        {
            // Choose Z basis according to your convention
            var s_Z = forwardIsLookDir ? -forward : forward; // glTF camera looks along -Z
            var s_X = right;
            var s_Y = up;

            if (orthonormalize)
            {
                // Enforce orthonormal, right-handed basis
                s_Z = SafeNormalize(s_Z);
                s_X = SafeNormalize(s_X);

                // y from z×x, then x from y×z (keeps x ⟂ y ⟂ z)
                s_Y = SafeNormalize(Vector3.Cross(s_Z, s_X));
                s_X = SafeNormalize(Vector3.Cross(s_Y, s_Z));

                // Ensure right-handedness: (x×y)·z > 0
                if (Vector3.Dot(Vector3.Cross(s_X, s_Y), s_Z) < 0f) s_X = -s_X;
            }
            else
            {
                s_X = SafeNormalize(s_X);
                s_Y = SafeNormalize(s_Y);
                s_Z = SafeNormalize(s_Z);
            }

            // Build rotation matrix for System.Numerics (row-major)
            Matrix4x4 s_Matrix;
            if (inputsAreColumns)
            {
                // Axes as COLUMNS ⇒ fill by columns across rows
                s_Matrix = new Matrix4x4(
                    s_X.X, s_Y.X, s_Z.X, 0f,
                    s_X.Y, s_Y.Y, s_Z.Y, 0f,
                    s_X.Z, s_Y.Z, s_Z.Z, 0f,
                    0f, 0f, 0f, 1f
                );
            }
            else
            {
                // Axes as ROWS
                s_Matrix = new Matrix4x4(
                    s_X.X, s_X.Y, s_X.Z, 0f,
                    s_Y.X, s_Y.Y, s_Y.Z, 0f,
                    s_Z.X, s_Z.Y, s_Z.Z, 0f,
                    0f, 0f, 0f, 1f
                );
            }

            return Quaternion.CreateFromRotationMatrix(s_Matrix);
        }
        
        private static Vector3 SafeNormalize(Vector3 p_Vector)
        {
            var s_Length = p_Vector.Length();
            return s_Length > 1e-8f ? p_Vector / s_Length : Vector3.UnitX; // fallback axis if degenerate
        }
    }
}
