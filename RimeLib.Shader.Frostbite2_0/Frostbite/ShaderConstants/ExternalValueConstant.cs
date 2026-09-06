using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;

public class ExternalValueConstant : IFbSerializable
{
    public string Name { get; set; } = string.Empty;

    public uint Handle { get; set; }
    public ushort Index { get; set; }
    public ushort ArraySize { get; set; }
    public byte Size { get; set; }
    public bool Required { get; set; }

    /// <summary>
    /// The two bytes between <see cref="Required"/> and <see cref="DefaultValue"/>, which pad the
    /// record out to the 4-byte alignment the Vec4 needs.
    ///
    /// Kept rather than skipped because a writer that assumed they were zero could not be checked
    /// for byte equality against the game -- it would be assuming the very thing under test. They
    /// are read back and written back, so whatever BF3 puts there survives.
    /// </summary>
    public ushort Reserved { get; set; }

    public Vec4 DefaultValue { get; set; } = new();

    public ExternalValueConstant()
    {
    }

    public ExternalValueConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    /// <summary>
    /// Mirrors <see cref="Deserialize(RimeReader)"/> field for field, in its order: 0x30 bytes.
    /// </summary>
    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.WriteFixedLengthString(Name, 0x20);

        p_Writer.Write(Handle);

        p_Writer.Write(Index);

        p_Writer.Write(ArraySize);

        p_Writer.Write(Size);
        p_Writer.Write(Required);

        p_Writer.Write(Reserved);

        p_Writer.Write(DefaultValue.x);
        p_Writer.Write(DefaultValue.y);
        p_Writer.Write(DefaultValue.z);
        p_Writer.Write(DefaultValue.w);

        return true;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Name = p_Reader.ReadFixedLengthString(0x20);

        Handle = p_Reader.ReadUInt32();

        Index = p_Reader.ReadUInt16();

        ArraySize = p_Reader.ReadUInt16();

        Size = p_Reader.ReadUByte();
        Required = p_Reader.ReadBool();

        Reserved = p_Reader.ReadUInt16();

        DefaultValue.x = p_Reader.ReadSingle();
        DefaultValue.y = p_Reader.ReadSingle();
        DefaultValue.z = p_Reader.ReadSingle();
        DefaultValue.w = p_Reader.ReadSingle();
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using var s_Writer = new RimeWriter(s_Stream);

        if (Serialize(s_Writer))
        {
            p_Data = s_Stream.ToArray();
            return true;
        }

        p_Data = null;
        return false;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));

        Deserialize(s_Reader);
    }

}