using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// THIS MAY NOT BE THE REAL NAME IDGAF
/// 010 SCRIPTS FROM POWBACK LEAD THE WAY
/// </summary>
public class hkDescriptorInfo
{
    public long Offset { get; set; }
    public int Key { get; set; }
    
    // Don't serialize this
    public long FinalOffset { get; set; }

    public const int c_SizeOfDescriptorInfo = sizeof(long) + sizeof(int);

    public hkDescriptorInfo()
    {
        
    }

    public hkDescriptorInfo(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Offset = p_Reader.ReadInt64();
        Key = p_Reader.ReadInt32();
    }
}