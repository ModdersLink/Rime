namespace RimeLib.Mesh;

/// <summary>
/// The type of mesh to export
/// </summary>
public enum MeshConverterType
{
    /// <summary>
    /// Export to GLTF
    /// </summary>
    Gltf,
    
    /// <summary>
    /// Export to GLB
    /// </summary>
    Glb,
    
    /// <summary>
    /// Export to text OBJ
    /// </summary>
    Obj,
    
    /// <summary>
    /// Export to blender script
    /// </summary>
    BlenderScript
}