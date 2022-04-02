using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameToolsDotNet.Rendering.Vertex
{
    public class VertexHelper
    {
        public static Vector2 Unpack_R16G16_SNorm(byte[] buffer, int index)
        {
            // Get the vector components in compressed form from the buffer.
            short x = BitConverter.ToInt16(buffer, index);
            short y = BitConverter.ToInt16(buffer, index + 2);

            // Decompress and return as a vector.
            return new Vector2(SNorm16ToFloat(x), SNorm16ToFloat(y));
        }

        public static Vector2 Unpack_R32G32_Float(byte[] buffer, int index)
        {
            // No compression, return as-is.
            return new Vector2(BitConverter.ToSingle(buffer, index), BitConverter.ToSingle(buffer, index + 4));
        }

        public static byte[] Pack_R11G11B10_Float(Vector3 vector)
        {
            float x = vector.X < 0f ? 1f + vector.X : vector.X;
            float y = vector.Y < 0f ? 1f + vector.Y : vector.Y;
            float z = vector.Z < 0f ? 1f + vector.Z : vector.Z;

            x = Math.Min(x, 1f);
            y = Math.Min(y, 1f);
            z = Math.Min(z, 1f);

            uint xp = (uint)Math.Floor(x * (float)0x3FF);
            uint yp = (uint)Math.Floor(y * (float)0x3FF);
            uint zp = (uint)Math.Floor(z * (float)0x1FF);

            if (vector.X < 0f)
                xp |= 1 << 10;
            if (vector.Y < 0f)
                yp |= 1 << 10;
            if (vector.Z < 0f)
                zp |= 1 << 9;

            uint value = (zp << 22) | (yp << 11) | xp;
            return BitConverter.GetBytes(value);
        }

        public static Vector3 Unpack_R11G11B10_Float(byte[] buffer, int index)
        {
            // Get the 32-bit compressed vector value and unpack.
            int value = BitConverter.ToInt32(buffer, index);

            float x = (float)(value & 0x3FF) / (float)0x3FF;
            if (((value >> 10) & 1) == 1)
                x = -(1 - x);

            float y = (float)((value >> 11) & 0x3FF) / (float)0x3FF;
            if (((value >> 21) & 1) == 1)
                y = -(1 - y);

            float z = (float)((value >> 22) & 0x1FF) / (float)0x1FF;
            if (((value >> 31) & 1) == 1)
                z = -(1 - z);

            return new Vector3(x, y, z);
        }

        public static Vector3 Unpack_R32G32B32_Float(byte[] buffer, int index)
        {
            // No compression, return as-is.
            return new Vector3(BitConverter.ToSingle(buffer, index), BitConverter.ToSingle(buffer, index + 4), BitConverter.ToSingle(buffer, index + 8));
        }

        public static Vector4 Unpack_R16G16B16A16_SNorm(byte[] buffer, int index)
        {
            // Get the vector components in compressed form from the buffer.
            short x = BitConverter.ToInt16(buffer, index);
            short y = BitConverter.ToInt16(buffer, index + 2);
            short z = BitConverter.ToInt16(buffer, index + 4);
            short w = BitConverter.ToInt16(buffer, index + 6);

            // Decompress and return as a vector.
            return new Vector4(SNorm16ToFloat(x), SNorm16ToFloat(y), SNorm16ToFloat(z), SNorm16ToFloat(w));
        }

        public static float SNorm16ToFloat(short value)
        {
            // Map [-32768, 32767] to [-1, 1].
            return Math.Max(value / 32767.0f, -1.0f);
        }

        public static short FloatToSNorm16(float value)
        {
            // Map [-1, 1] to [-32768, 32767].
            return (short)(value * 32767.0f);
        }

        public static ushort[] TriangleStripToTriangleList(ushort[] stripIndices, int startIndex, int indexCount, int startingVertex)
        {
            // Create a list to hold the triangle list indices.
            List<ushort> triList = new List<ushort>();

            // Loop and convert the triangle strip to a triangle list.
            for (int i = 0; i < indexCount - 2; i++)
            {
                // Get the vertex indices for the current triangle.
                ushort v1 = (ushort)(stripIndices[startIndex + i] - startingVertex);
                ushort v2 = (ushort)(stripIndices[startIndex + i + 1] - startingVertex);
                ushort v3 = (ushort)(stripIndices[startIndex + i + 2] - startingVertex);

                // Check for degenerate triangle.
                if (v1 == v2 || v1 == v3 || v2 == v3)
                {
                    // Degenerate triangle, skip.
                    continue;
                }

                // Check for clockwise/counter clockwise orientation and handle accordingly.
                if (i % 2 != 0)
                {
                    triList.Add(v2);
                    triList.Add(v1);
                    triList.Add(v3);
                }
                else
                {
                    triList.Add(v1);
                    triList.Add(v2);
                    triList.Add(v3);
                }
            }

            // Return the triangle list.
            return triList.ToArray();
        }
    }
}
