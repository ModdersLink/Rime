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
    public byte EndByte { get; set; }

    // This is not serialized
    // FTell() - StartOffset - classDataStart + 5;
    public long Key { get; set; }
    public long Pos { get; set; }

    public hkDescriptor()
    {
        Signature = 0;
        Version = 0;
        Name = string.Empty;
        EndByte = 0xFF;
    }

    public hkDescriptor(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Signature = p_Reader.ReadInt32();
        Version = p_Reader.ReadUByte();
        Name = p_Reader.ReadNullTerminatedString();
        
        // ????
        Pos = p_Reader.Position;
        
        EndByte = p_Reader.ReadUByte();
    }
}