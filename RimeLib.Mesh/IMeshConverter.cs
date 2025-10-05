using System.Collections.Generic;
using RimeLib.Content.Mounting;
using SharpGLTF.Geometry;
using SharpGLTF.Geometry.VertexTypes;
using SharpGLTF.Schema2;

namespace RimeLib.Mesh;

public interface IMeshConverter : IEngineInterface
{
    public void ConvertToObj(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public void ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
    public List<MeshBuilder<VertexPosition, VertexTexture1>> ConvertToGltf(IResourceObject p_Resource, IEngineMounter p_Mounter);
    public void ConvertToBlenderScript(IResourceObject p_Resource, IEngineMounter p_Mounter, string p_OutputFilePath);
}