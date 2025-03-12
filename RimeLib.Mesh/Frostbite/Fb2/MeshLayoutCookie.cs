namespace RimeLib.Mesh.Frostbite.Fb2;

/// <summary>
/// The MeshLayoutCookie is found in the resMeta for Mesh in cas-bundles
/// 
/// </summary>
public class MeshLayoutCookie
{
    public uint CellBlockSize { get; set; }
    public uint RsxBlockSize { get; set; }
    public uint RelocationSize { get; set; }
    public ushort MeshSetSize { get; set; }
    public ushort SubsetSize { get; set; }
}