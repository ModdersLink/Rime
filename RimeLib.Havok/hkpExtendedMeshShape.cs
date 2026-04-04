using RimeLib.IO;

namespace RimeLib.Havok;

public class hkpExtendedMeshShape
{
    public byte[] Header1 { get; set; } = new byte[200];
    public int IndexCount { get; set; }
    public byte[] Header2 { get; set; } = new byte[36];
    public List<hkpTransform> Transforms { get; set; } = new List<hkpTransform>();

    public hkpExtendedMeshShape()
    {
        
    }

    public hkpExtendedMeshShape(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Header1 = p_Reader.ReadBytes(0xC8); // 0x118 on 64 bit
        IndexCount = p_Reader.ReadInt32();
        Header2 = p_Reader.ReadBytes(0x24); // 0x34 on 64 bit

        for (var s_Index = 0; s_Index < IndexCount; s_Index++)
        {
            // Skip unknown 32 bytes
            p_Reader.Seek(0x20,  SeekOrigin.Current); // 0x40 on 64 bit
            
            Transforms.Add(new hkpTransform(p_Reader));
        }
    }
}