using System;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite;

/// <summary>
/// One Havok object graph as Frostbite ships it: its 32-bit packfile, then its 64-bit packfile,
/// each of a known size. Whatever follows a packfile inside its size is kept as bytes.
/// </summary>
public sealed class HavokPackfilePair
{
    public HavokPhysicsData.HavokInstance Instance32 { get; private set; } = null!;
    public HavokPhysicsData.HavokInstance Instance64 { get; private set; } = null!;
    public byte[] Trailing32 { get; private set; } = [];
    public byte[] Trailing64 { get; private set; } = [];

    public static HavokPackfilePair Read(byte[] p_Data, int p_Offset, int p_Size32, int p_Size64)
    {
        if (p_Offset + (long)p_Size32 + p_Size64 > p_Data.Length)
            throw new InvalidDataException($"Packfiles of {p_Size32} and {p_Size64} bytes at {p_Offset} overrun the {p_Data.Length} byte resource.");

        var s_Pair = new HavokPackfilePair();
        (s_Pair.Instance32, s_Pair.Trailing32) = ReadOne(p_Data, p_Offset, p_Size32);
        (s_Pair.Instance64, s_Pair.Trailing64) = ReadOne(p_Data, p_Offset + p_Size32, p_Size64);
        return s_Pair;
    }

    private static (HavokPhysicsData.HavokInstance, byte[]) ReadOne(byte[] p_Data, int p_Offset, int p_Size)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, p_Offset, p_Size, false));
        var s_Instance = new HavokPhysicsData.HavokInstance(s_Reader);
        var s_End = (int)Written(s_Instance).Length;
        if (s_End > p_Size)
            throw new InvalidDataException($"A {p_Size} byte packfile writes back as {s_End} bytes.");
        return (s_Instance, p_Data.AsSpan(p_Offset + s_End, p_Size - s_End).ToArray());
    }

    private static byte[] Written(HavokPhysicsData.HavokInstance p_Instance)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            p_Instance.Serialize(s_Writer);
        return s_Stream.ToArray();
    }

    public int Size32 => Written(Instance32).Length + Trailing32.Length;
    public int Size64 => Written(Instance64).Length + Trailing64.Length;

    public void Write(RimeWriter p_Writer)
    {
        p_Writer.Write(Written(Instance32));
        p_Writer.Write(Trailing32);
        p_Writer.Write(Written(Instance64));
        p_Writer.Write(Trailing64);
    }
}
