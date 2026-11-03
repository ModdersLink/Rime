using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0.Frostbite;

/// <summary>
/// One Havok object graph as Frostbite ships it: its 32-bit packfile, then its 64-bit packfile.
/// Reading takes the two sizes from whoever stores them (the payload or the cookie); writing sets
/// them. Whatever follows a packfile inside its size is kept as bytes.
/// </summary>
public class HavokPackfilePair : IFbSerializable
{
    public int Size32 { get; set; }
    public int Size64 { get; set; }
    public HavokPhysicsData.HavokInstance Instance32 { get; set; } = new();
    public HavokPhysicsData.HavokInstance Instance64 { get; set; } = new();
    public byte[] Trailing32 { get; set; } = [];
    public byte[] Trailing64 { get; set; } = [];

    public HavokPackfilePair()
    {
    }

    public HavokPackfilePair(int p_Size32, int p_Size64)
    {
        Size32 = p_Size32;
        Size64 = p_Size64;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        if (p_Reader.Position + (long)Size32 + Size64 > p_Reader.Length)
            throw new InvalidDataException($"Packfiles of {Size32} and {Size64} bytes at {p_Reader.Position} overrun the {p_Reader.Length} byte resource.");

        (Instance32, Trailing32) = ReadPackfile(p_Reader.ReadBytes(Size32));
        (Instance64, Trailing64) = ReadPackfile(p_Reader.ReadBytes(Size64));
    }

    private static (HavokPhysicsData.HavokInstance, byte[]) ReadPackfile(byte[] p_Data)
    {
        var s_Instance = new HavokPhysicsData.HavokInstance(new RimeReader(new MemoryStream(p_Data, false)));
        var s_End = s_Instance.DataSection.AbsoluteDataStart + s_Instance.DataSection.EndOffset;
        if (s_End > p_Data.Length)
            throw new InvalidDataException($"A {p_Data.Length} byte packfile ends its data section at {s_End}.");

        return (s_Instance, p_Data.AsSpan(s_End).ToArray());
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        Size32 = WritePackfile(p_Writer, Instance32, Trailing32);
        Size64 = WritePackfile(p_Writer, Instance64, Trailing64);
        return true;
    }

    private static int WritePackfile(RimeWriter p_Writer, HavokPhysicsData.HavokInstance p_Instance, byte[] p_Trailing)
    {
        var s_Start = p_Writer.Position;
        p_Instance.Serialize(p_Writer);
        p_Writer.Write(p_Trailing);
        return (int)(p_Writer.Position - s_Start);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }
}
