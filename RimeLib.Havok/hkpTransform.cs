using System.Numerics;
using RimeLib.IO;

namespace RimeLib.Havok;

public class hkpTransform
{
    public Vector4 Rotation { get; set; }
    public Vector3 Position { get; set; }

    public hkpTransform()
    {
        
    }

    public hkpTransform(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Rotation = new  Vector4(p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
        Position = new  Vector3(p_Reader.ReadSingle(), p_Reader.ReadSingle(), p_Reader.ReadSingle());
        
        // Skip the last float since it always appears to be 0.5. Dunno wtf it is... 
        p_Reader.Seek(4, SeekOrigin.Current);
    }
}