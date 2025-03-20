using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite;

public class QuadtreeNodeId : IFbSerializable
{
    public static uint[] m_QuadtreeNodeChildOffsetX = { 0, 1, 1, 0 };
    public static uint[] m_QuadtreeNodeChildOffsetY = { 0, 0, 1, 1 };

    public ushort IndexX { get; set; }
    public ushort IndexY { get; set; }
    public byte Level { get; set; }

    public static readonly QuadtreeNodeId Empty = new QuadtreeNodeId { IndexX = 0, IndexY = 0, Level = 0 };

    public QuadtreeNodeId()
    {
    }

    public QuadtreeNodeId(QuadtreeNodeId p_Other)
    {
        IndexX = p_Other.IndexX;
        IndexY = p_Other.IndexY;
        Level = p_Other.Level;
    }

    public QuadtreeNodeId(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Level = p_Reader.ReadUByte();
        IndexX = p_Reader.ReadUInt16();
        IndexY = p_Reader.ReadUInt16();
    }

    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }

    protected bool Equals(QuadtreeNodeId other)
    {
        return IndexX == other.IndexX && IndexY == other.IndexY && Level == other.Level;
    }

    public override bool Equals(object? obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((QuadtreeNodeId)obj);
    }

    public override int GetHashCode()
    {
        unchecked
        {
            var hashCode = IndexX.GetHashCode();
            hashCode = (hashCode * 397) ^ IndexY.GetHashCode();
            hashCode = (hashCode * 397) ^ Level.GetHashCode();
            return hashCode;
        }
    }

    public static bool operator ==(QuadtreeNodeId left, QuadtreeNodeId right)
    {
        return Equals(left, right);
    }

    public static bool operator !=(QuadtreeNodeId left, QuadtreeNodeId right)
    {
        return !Equals(left, right);
    }
}
