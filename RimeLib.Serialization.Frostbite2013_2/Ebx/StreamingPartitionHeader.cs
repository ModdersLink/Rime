using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

public class StreamingPartitionHeader : IFbSerializable
{
    public static int SizeOf => 13*4 + GUID.SizeOf;

    public uint Magic { get; set; }
    public uint MetaSize { get; set; }
    public uint PayloadSize { get; set; }
    public uint ImportCount { get; set; }
    public ushort RangeCount { get; set; }
    public ushort ExportedRangeCount { get; set; }
    public ushort TypeCount { get; set; }
    public ushort TypeDescriptorCount { get; set; }
    public ushort FieldDescriptorCount { get; set; }
    public ushort TypeStringTableSize { get; set; }
    public uint StringTableSize { get; set; }
    public uint ArrayCount { get; set; }
    public uint ArrayOffset { get; set; }
    public GUID PartitionGuid { get; set; } = GUID.Empty;

    public StreamingPartitionHeader()
    {

    }

    public StreamingPartitionHeader(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Magic);
        p_Writer.Write(MetaSize);
        p_Writer.Write(PayloadSize);
        p_Writer.Write(ImportCount);
        p_Writer.Write(RangeCount);
        p_Writer.Write(ExportedRangeCount);
        p_Writer.Write(TypeCount);
        p_Writer.Write(TypeDescriptorCount);
        p_Writer.Write(FieldDescriptorCount);
        p_Writer.Write(TypeStringTableSize);
        p_Writer.Write(StringTableSize);
        p_Writer.Write(ArrayCount);
        p_Writer.Write(ArrayOffset);
        PartitionGuid.Serialize(p_Writer);

        return true;
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

    public void Deserialize(RimeReader p_Reader)
    {
        Magic = p_Reader.ReadUInt32();
        MetaSize = p_Reader.ReadUInt32();
        PayloadSize = p_Reader.ReadUInt32();
        ImportCount = p_Reader.ReadUInt32(); //
        RangeCount = p_Reader.ReadUInt16();
        ExportedRangeCount = p_Reader.ReadUInt16();
        TypeCount = p_Reader.ReadUInt16();
        TypeDescriptorCount = p_Reader.ReadUInt16(); //
        FieldDescriptorCount = p_Reader.ReadUInt16(); //
        TypeStringTableSize = p_Reader.ReadUInt16();
        StringTableSize = p_Reader.ReadUInt32();
        ArrayCount = p_Reader.ReadUInt32(); //
        ArrayOffset = p_Reader.ReadUInt32();
        PartitionGuid = new GUID(p_Reader);
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data));

        Deserialize(s_Reader);
    }
}