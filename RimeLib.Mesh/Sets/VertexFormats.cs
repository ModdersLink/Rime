using System;
using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Mesh.Sets;

/// <summary>The bytes each vertex format takes, and reading and writing the common ones as four floats.</summary>
public static class VertexFormats
{
    public static int Size(VertexFormat p_Format) => p_Format switch
    {
        VertexFormat.None => 0,
        VertexFormat.UByteN => 1,
        VertexFormat.Half or VertexFormat.Short or VertexFormat.ShortN => 2,
        VertexFormat.Float or VertexFormat.Half2 or VertexFormat.Byte4 or VertexFormat.Byte4N or VertexFormat.UByte4
            or VertexFormat.UByte4N or VertexFormat.Short2 or VertexFormat.Short2N or VertexFormat.UShort2
            or VertexFormat.UShort2N or VertexFormat.Int or VertexFormat.IntN or VertexFormat.UInt or VertexFormat.UIntN => 4,
        VertexFormat.Half3 or VertexFormat.Short3 or VertexFormat.Short3N => 6,
        VertexFormat.Float2 or VertexFormat.Half4 or VertexFormat.Short4 or VertexFormat.Short4N or VertexFormat.UShort4
            or VertexFormat.UShort4N or VertexFormat.Int2 or VertexFormat.Int2N or VertexFormat.UInt2 or VertexFormat.UInt2N => 8,
        VertexFormat.Float3 or VertexFormat.Int3 or VertexFormat.UInt3 => 12,
        VertexFormat.Float4 or VertexFormat.Int4 or VertexFormat.Int4N or VertexFormat.UInt4 or VertexFormat.UInt4N => 16,
        _ => 4, // the packed 10/11-bit formats
    };

    /// <summary>Whether <see cref="Read"/> and <see cref="Write"/> handle the format.</summary>
    public static bool CanConvert(VertexFormat p_Format) => p_Format is VertexFormat.Float or VertexFormat.Float2
        or VertexFormat.Float3 or VertexFormat.Float4 or VertexFormat.Half or VertexFormat.Half2 or VertexFormat.Half3
        or VertexFormat.Half4 or VertexFormat.UByte4 or VertexFormat.UByte4N or VertexFormat.Byte4N
        or VertexFormat.Short2N or VertexFormat.Short4N or VertexFormat.UShort2N or VertexFormat.UShort4N;

    /// <summary>The element's components; the ones the format lacks are 0.</summary>
    public static Vector4 Read(VertexFormat p_Format, RimeReader p_Reader)
    {
        Span<float> s_Values = stackalloc float[4];
        s_Values.Clear();
        for (var i = 0; i < Components(p_Format); ++i)
        {
            s_Values[i] = p_Format switch
            {
                VertexFormat.Float or VertexFormat.Float2 or VertexFormat.Float3 or VertexFormat.Float4 => p_Reader.ReadSingle(),
                VertexFormat.Half or VertexFormat.Half2 or VertexFormat.Half3 or VertexFormat.Half4 => (float)p_Reader.ReadHalf(),
                VertexFormat.UByte4 => p_Reader.ReadUByte(),
                VertexFormat.UByte4N => p_Reader.ReadUByte() / 255f,
                VertexFormat.Byte4N => System.Math.Max(p_Reader.ReadSByte() / 127f, -1),
                VertexFormat.Short2N or VertexFormat.Short4N => System.Math.Max(p_Reader.ReadInt16() / 32767f, -1),
                VertexFormat.UShort2N or VertexFormat.UShort4N => p_Reader.ReadUInt16() / 65535f,
                _ => throw new NotSupportedException($"reading vertex format {p_Format}"),
            };
        }

        return new Vector4(s_Values[0], s_Values[1], s_Values[2], s_Values[3]);
    }

    /// <summary>Writes the components the format has, rounded and clamped to its range.</summary>
    public static void Write(VertexFormat p_Format, Vector4 p_Value, RimeWriter p_Writer)
    {
        ReadOnlySpan<float> s_Values = [p_Value.X, p_Value.Y, p_Value.Z, p_Value.W];
        for (var i = 0; i < Components(p_Format); ++i)
        {
            var s_Value = s_Values[i];
            switch (p_Format)
            {
                case VertexFormat.Float or VertexFormat.Float2 or VertexFormat.Float3 or VertexFormat.Float4:
                    p_Writer.Write(s_Value);
                    break;
                case VertexFormat.Half or VertexFormat.Half2 or VertexFormat.Half3 or VertexFormat.Half4:
                    p_Writer.WriteHalf((Half)s_Value);
                    break;
                case VertexFormat.UByte4:
                    p_Writer.Write((byte)System.Math.Clamp(MathF.Round(s_Value), 0, 255));
                    break;
                case VertexFormat.UByte4N:
                    p_Writer.Write((byte)MathF.Round(System.Math.Clamp(s_Value, 0, 1) * 255));
                    break;
                case VertexFormat.Byte4N:
                    p_Writer.Write((sbyte)MathF.Round(System.Math.Clamp(s_Value, -1, 1) * 127));
                    break;
                case VertexFormat.Short2N or VertexFormat.Short4N:
                    p_Writer.Write((short)MathF.Round(System.Math.Clamp(s_Value, -1, 1) * 32767));
                    break;
                case VertexFormat.UShort2N or VertexFormat.UShort4N:
                    p_Writer.Write((ushort)MathF.Round(System.Math.Clamp(s_Value, 0, 1) * 65535));
                    break;
                default:
                    throw new NotSupportedException($"writing vertex format {p_Format}");
            }
        }
    }

    /// <summary>The components of a format <see cref="CanConvert"/> handles.</summary>
    private static int Components(VertexFormat p_Format) => p_Format switch
    {
        VertexFormat.Float or VertexFormat.Half => 1,
        VertexFormat.Float2 or VertexFormat.Half2 or VertexFormat.Short2N or VertexFormat.UShort2N => 2,
        VertexFormat.Float3 or VertexFormat.Half3 => 3,
        VertexFormat.Float4 or VertexFormat.Half4 or VertexFormat.UByte4 or VertexFormat.UByte4N or VertexFormat.Byte4N
            or VertexFormat.Short4N or VertexFormat.UShort4N => 4,
        _ => throw new NotSupportedException($"converting vertex format {p_Format}"),
    };
}
