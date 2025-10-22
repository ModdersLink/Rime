using RimeLib.IO;

namespace RimeLib.Havok;

/// <summary>
/// THIS IS NOT THE REAL NAME
/// COMES FROM POWBACKS 010 SCRIPTS
/// </summary>
public class hkxRoot
{
    public uint B1 { get; set; }
    public uint EntryCount { get; set; }
    public uint B3 { get; set; }
    public uint B4 { get; set; }
    public string EntryName { get; set; } = string.Empty;
    public uint Pad { get; set; }
    public string ClassName { get; set; } = string.Empty;

    public hkxRoot()
    {
        
    }

    public hkxRoot(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public void Deserialize(RimeReader p_Reader)
    {
        B1 = p_Reader.ReadUInt32();
        EntryCount = p_Reader.ReadUInt32();
        B3 = p_Reader.ReadUInt32();
        B4 = p_Reader.ReadUInt32();
        
        // Skip over all of the entries I guess?
        for (var s_EntryIndex = 0; s_EntryIndex < EntryCount; s_EntryIndex++)
            p_Reader.Seek(12,  SeekOrigin.Current);
        
        EntryName = p_Reader.ReadNullTerminatedString();
        
        // Not sure where the above call lands, we may not need to do this (we do)
        p_Reader.Seek(-1,  SeekOrigin.Current);
        Pad = p_Reader.ReadUInt32();
        
        ClassName = p_Reader.ReadNullTerminatedString();
    }
}