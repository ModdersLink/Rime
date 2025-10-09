using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// THIS MAY NOT BE THE REAL NAME IDGAF
/// 010 SCRIPTS FROM POWBACK LEAD THE WAY
/// </summary>
public class hkDescriptorInfo
{
    public long Num10 { get; set; }
    public int Num11 { get; set; }
    
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
        Num10 = p_Reader.ReadInt64();
        Num11 = p_Reader.ReadInt32();
    }
}