using RimeLib.Frostbite.Core;
using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// THIS IS NOT THE REAL CLASS
/// 010 POWBACK
///
/// I AM FUCKING LOSING MY SANITY
/// </summary>
public class hkExtendedMeshEntry
{
    public Vector4 Up { get; set; } = new Vector4();
    public Vector4 Right { get; set; } = new Vector4();
    public Vector4 Forward { get; set; } = new Vector4();
    public Vector4 Transform { get; set; } = new Vector4();

    public hkExtendedMeshEntry()
    {
        
    }

    public hkExtendedMeshEntry(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        Up = new Vector4(p_Reader);
        Right = new  Vector4(p_Reader);
        Forward = new Vector4(p_Reader);
        Transform = new Vector4(p_Reader);
    }
}