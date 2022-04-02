using System;
using System.Collections.Generic;
using System.Text;

namespace GameToolsDotNet.Bitmaps.Swizzling
{
    public class XboxSwizzle
    {
        class MaskSet
        {
            public int x = 0;
            public int y = 0;
            public int z = 0;

            public MaskSet(int w, int h, int d)
            {
                int bit = 1;
                int index = 1;

                while (bit < w || bit < h || bit < d)
                {
                    //if (bit == 0) break;
                    if (bit < w)
                    {
                        x |= index;
                        index <<= 1;
                    }
                    if (bit < h)
                    {
                        y |= index;
                        index <<= 1;
                    }
                    if (bit < d)
                    {
                        z |= index;
                        index <<= 1;
                    }
                    bit <<= 1;
                }
            }
        }

        public static byte[] Swizzle(byte[] pixelBuffer, int pixelOffset, int width, int height, int depth, int bitCount, bool deswizzle)
        {
            bitCount /= 8;
            int a = 0;
            int b = 0;
            byte[] dataArray = new byte[width * height * bitCount];

            MaskSet masks = new MaskSet(width, height, depth);
            for (int y = 0; y < height * depth; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (deswizzle)
                    {
                        a = ((y * width) + x) * bitCount;
                        b = (Swizzle(x, y, depth, masks)) * bitCount;
                    }
                    else
                    {
                        b = ((y * width) + x) * bitCount;
                        a = (Swizzle(x, y, depth, masks)) * bitCount;
                    }

                    if (a < dataArray.Length && b < pixelBuffer.Length)
                    {
                        for (int i = 0; i < bitCount; i++)
                            dataArray[a + i] = pixelBuffer[b + i + pixelOffset];
                    }
                    else return null;
                }
            }

            return dataArray;
        }

        public static byte[] Swizzle(byte[] pixelBuffer, int width, int height, int depth, int bitCount, bool deswizzle)
        {
            return Swizzle(pixelBuffer, 0, width, height, depth, bitCount, deswizzle);
        }

        private static int Swizzle(int x, int y, int z, MaskSet masks)
        {
            return SwizzleAxis(x, masks.x) | SwizzleAxis(y, masks.y) | (z == -1 ? 0 : SwizzleAxis(z, masks.z));
        }

        public static int SwizzleAxis(int val, int mask)
        {
            int bit = 1;
            int result = 0;

            while (bit <= mask)
            {
                int tmp = mask & bit;

                if (tmp != 0) result |= (val & bit);
                else val <<= 1;

                bit <<= 1;
            }

            return result;
        }
    }
}
