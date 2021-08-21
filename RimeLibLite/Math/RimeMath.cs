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
    }
}
