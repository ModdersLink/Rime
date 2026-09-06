using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// NOTE: THIS IS NOT THE ACTUAL CLASS NAME, IM RUNNING OUT OF TIME AND CBA TO FIND IT
/// GOING OFF OF POWBACKS 010 SCRIPTS
/// </summary>
public class hkDescriptor
{
    public int Signature { get; set; }
    public byte Version { get; set; }
    public string Name { get; set; } = string.Empty;
    public long Key { get; set; }

    public hkDescriptor()
    {
        Signature = 0;
        Version = 0;
        Name = string.Empty;
    }

    public hkDescriptor(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Signature = p_Reader.ReadInt32();
        Version = p_Reader.ReadUByte();
        Key = p_Reader.Position;
        Name = p_Reader.ReadNullTerminatedString();
    }

    /// <summary>
    /// Mirrors <see cref="Deserialize"/> field for field, in its order.
    ///
    /// Key is deliberately not written: it is the source POSITION the name was read from, an index
    /// the descriptor infos point at, not a field of the record.
    /// </summary>
    public void Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(Signature);
        p_Writer.Write(Version);
        p_Writer.WriteNullTerminatedString(Name);
    }
}