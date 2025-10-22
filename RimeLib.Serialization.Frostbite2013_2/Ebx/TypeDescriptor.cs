using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using RimeLib.Frostbite.Core;
using RimeLib.IO;
using RimeLib.Serialization.Frostbite2013_2.Extensions;
using RimeLib.Utils;

namespace RimeLib.Serialization.Frostbite2013_2.Ebx;

public class TypeDescriptor
{
    public static int SizeOf => 14 + MemberInfoFlags.SizeOf;

    public string Name
    {
        get
        {
            return m_Name;
        }
        set
        {
            m_Name = value;

            if (m_Name != null)
                NameHash = Frostbite.Utils.HashQuick(m_Name);
        }
    }

    public uint NameHash { get; set; }
    public uint LayoutDescriptor { get; set; } // Field Descriptor Count?
    public byte FieldCount { get; set; }
    public byte Alignment { get; set; }
    public MemberInfoFlags Flags { get; set; }
    public ushort Size { get; set; }
    public ushort SecondarySize { get; set; }

    private string m_Name;

    public TypeDescriptor(RimeReader p_Reader, IReadOnlyDictionary<uint, string> p_HashedTypeNames)
    {
        NameHash = p_Reader.ReadUInt32();
        LayoutDescriptor = p_Reader.ReadUInt32();
        FieldCount = (byte)p_Reader.ReadByte();
        Alignment = (byte)p_Reader.ReadByte();
        Flags = new MemberInfoFlags();
        Flags.Deserialize(p_Reader);
        Size = p_Reader.ReadUInt16();
        SecondarySize = p_Reader.ReadUInt16();
        m_Name = string.Empty;

        if (p_HashedTypeNames.TryGetValue(NameHash, out var s_Name))
            Name = s_Name;
    }

    public TypeDescriptor()
    {
        m_Name = string.Empty;
        Flags = new MemberInfoFlags();
    }

    public void Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(NameHash);
        p_Writer.Write(LayoutDescriptor);
        p_Writer.Write(FieldCount);
        p_Writer.Write(Alignment);
        Flags.Serialize(p_Writer);
        p_Writer.Write(Size);
        p_Writer.Write(SecondarySize);
    }

    public void GetObjectData(SerializationInfo p_Info, StreamingContext p_Context)
    {
        throw new NotImplementedException();
    }

    protected bool Equals(TypeDescriptor other)
    {
        return NameHash == other.NameHash && LayoutDescriptor == other.LayoutDescriptor && FieldCount == other.FieldCount && Alignment == other.Alignment && Equals(Flags, other.Flags) && Size == other.Size && SecondarySize == other.SecondarySize;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((TypeDescriptor)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = (int)NameHash;
            hashCode = (hashCode * 397) ^ (int)LayoutDescriptor;
            hashCode = (hashCode * 397) ^ FieldCount.GetHashCode();
            hashCode = (hashCode * 397) ^ Alignment.GetHashCode();
            hashCode = (hashCode * 397) ^ Flags.GetHashCode();
            hashCode = (hashCode * 397) ^ Size.GetHashCode();
            hashCode = (hashCode * 397) ^ SecondarySize.GetHashCode();
            return hashCode;
        }
    }

    public static bool operator ==(TypeDescriptor left, TypeDescriptor right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(TypeDescriptor left, TypeDescriptor right)
    {
        return !Equals(left, right);
    }

    public override string ToString()
    {
        return m_Name;
    }
}