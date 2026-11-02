using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// A constant block: its size, the offsets of its five arrays (from the start of the block), the
/// constant count and value start, one count per array, then the arrays one after another from
/// 64 bytes in. An empty array's offset is where it would start. The block is padded to 16.
/// </summary>
public class ShaderConstant : IFbSerializable
{
    private const int c_HeaderSize = 64;
    private const int c_ValueSize = 16, c_TextureSize = 152, c_ExternalValueSize = 60, c_ExternalTextureSize = 40, c_SamplerSize = 64;

    public ushort ConstantCount { get; set; }
    public ushort ValueConstantsStart { get; set; }

    public Vec4[] ValueConstants { get; set; } = Array.Empty<Vec4>();
    public TextureConstant[] Textures { get; set; } = Array.Empty<TextureConstant>();
    public ExternalValueConstant[] ExternalValues { get; set; } = Array.Empty<ExternalValueConstant>();
    public ExternalTextureConstant[] ExternalTextures { get; set; } = Array.Empty<ExternalTextureConstant>();
    public SamplerState[] Samplers { get; set; } = Array.Empty<SamplerState>();

    public ShaderConstant()
    {
    }

    public ShaderConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_Start = p_Reader.Position;
        var s_Size = p_Reader.ReadUInt32();
        p_Reader.ReadUInt32();

        var s_Offsets = new long[5];
        for (var i = 0; i < s_Offsets.Length; i++)
            s_Offsets[i] = p_Reader.ReadInt64();

        ConstantCount = p_Reader.ReadUInt16();
        ValueConstantsStart = p_Reader.ReadUInt16();

        var s_Counts = p_Reader.ReadBytes(5);

        p_Reader.Seek(s_Start + s_Offsets[0], SeekOrigin.Begin);
        ValueConstants = new Vec4[s_Counts[0]];
        for (var i = 0; i < ValueConstants.Length; ++i)
            ValueConstants[i] = new Vec4 { x = p_Reader.ReadSingle(), y = p_Reader.ReadSingle(), z = p_Reader.ReadSingle(), w = p_Reader.ReadSingle() };

        Textures = ReadArray(p_Reader, s_Start + s_Offsets[1], s_Counts[1], p_R => new TextureConstant(p_R));
        ExternalValues = ReadArray(p_Reader, s_Start + s_Offsets[2], s_Counts[2], p_R => new ExternalValueConstant(p_R));
        ExternalTextures = ReadArray(p_Reader, s_Start + s_Offsets[3], s_Counts[3], p_R => new ExternalTextureConstant(p_R));
        Samplers = ReadArray(p_Reader, s_Start + s_Offsets[4], s_Counts[4], p_R => new SamplerState(p_R));

        p_Reader.Seek(s_Start + s_Size, SeekOrigin.Begin);
    }

    private static T[] ReadArray<T>(RimeReader p_Reader, long p_At, int p_Count, Func<RimeReader, T> p_Read)
    {
        p_Reader.Seek(p_At, SeekOrigin.Begin);
        var s_Items = new T[p_Count];
        for (var i = 0; i < p_Count; i++)
            s_Items[i] = p_Read(p_Reader);
        return s_Items;
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Offsets = new long[5];
        var s_Counts = new[] { ValueConstants.Length, Textures.Length, ExternalValues.Length, ExternalTextures.Length, Samplers.Length };
        var s_Sizes = new[] { c_ValueSize, c_TextureSize, c_ExternalValueSize, c_ExternalTextureSize, c_SamplerSize };
        long s_End = c_HeaderSize;
        for (var i = 0; i < s_Offsets.Length; i++)
        {
            if (s_Counts[i] > byte.MaxValue)
                throw new InvalidDataException($"A constant block holds at most {byte.MaxValue} entries per array, not {s_Counts[i]}.");

            s_Offsets[i] = s_End;
            s_End += (long)s_Counts[i] * s_Sizes[i];
        }

        var s_Size = (s_End + 15) & ~15L;

        var s_Start = p_Writer.Position;
        p_Writer.Write((uint)s_Size);
        p_Writer.Write(0u);
        foreach (var s_Offset in s_Offsets)
            p_Writer.Write(s_Offset);

        p_Writer.Write(ConstantCount);
        p_Writer.Write(ValueConstantsStart);
        foreach (var s_Count in s_Counts)
            p_Writer.Write((byte)s_Count);
        while (p_Writer.Position < s_Start + c_HeaderSize)
            p_Writer.Write((byte)0);

        foreach (var s_Value in ValueConstants)
        {
            p_Writer.Write(s_Value.x);
            p_Writer.Write(s_Value.y);
            p_Writer.Write(s_Value.z);
            p_Writer.Write(s_Value.w);
        }

        foreach (var s_Texture in Textures)
            s_Texture.Serialize(p_Writer);
        foreach (var s_Value in ExternalValues)
            s_Value.Serialize(p_Writer);
        foreach (var s_Texture in ExternalTextures)
            s_Texture.Serialize(p_Writer);
        foreach (var s_Sampler in Samplers)
            s_Sampler.Serialize(p_Writer);

        while (p_Writer.Position < s_Start + s_Size)
            p_Writer.Write((byte)0);
        return true;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
