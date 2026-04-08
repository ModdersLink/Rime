using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;

namespace RimeLib.Mesh;

public interface IMeshConverter : IEngineInterface
{
    public void ConvertToObj(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    /// <summary>
    /// Converts a specified MeshSet resource to a GLTF or GLB file format
    /// </summary>
    /// <param name="p_Resource">MeshAsset resource to convert</param>
    /// <param name="p_Mounter">IEngineMounter with mounted resources</param>
    /// <param name="p_OutputFilePath">Output file path on the host filesystem for the .gltf/.glb file</param>
    public void ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public void ConvertToGlb(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public List<MeshBuilder<VertexPosition, VertexTexture1>> ConvertToMeshBuilders(IResourceObject p_Resource, IEngineMounter p_Mounter);
    public void ConvertToBlenderScript(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    /// <summary>
    /// Retrieves a dictionary mapping chunk lod names to their corresponding GUIDs for the specified resource.
    /// </summary>
    /// <param name="p_Resource">MeshAsset resource to read.</returns>
    public Dictionary<string, GUID> GetChunkGuids(IResourceObject p_Resource);
}