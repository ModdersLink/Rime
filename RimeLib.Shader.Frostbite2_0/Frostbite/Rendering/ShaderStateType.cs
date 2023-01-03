using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Rendering
{
    [Flags]
    public enum ShaderStateType
    {
        ShaderStateType_Mode = (1 << 0),
        ShaderStateType_SurfaceShader = (1 << 1),
        ShaderStateType_VertexShaderFragment = (1 << 2),
        ShaderStateType_Bones = (1 << 3),
        ShaderStateType_GeometrySpace = (1 << 4),
        ShaderStateType_SkinningMethod = (1 << 5),
        ShaderStateType_WorldTransform = (1 << 6),
        ShaderStateType_PrevWorldTransform = (1 << 7),
        ShaderStateType_LightProbe = (1 << 8),
        ShaderStateType_LightMap = (1 << 9),
        ShaderStateType_OutdoorLight = (1 << 10),
        ShaderStateType_View = (1 << 11),
        ShaderStateType_TileViews = (1 << 12),
        ShaderStateType_RightHanded = (1 << 13),
        ShaderStateType_InvertCullMode = (1 << 14),
        ShaderStateType_Fog = (1 << 15),
        ShaderStateType_DynamicEnvmap = (1 << 16),
        ShaderStateType_Stencil = (1 << 17),
        ShaderStateType_WireframeEnable = (1 << 18),
        ShaderStateType_Viewport = (1 << 19),
        ShaderStateType_ScissorRect = (1 << 20),
        ShaderStateType_DepthMode = (1 << 21),
        ShaderStateType_DepthBias = (1 << 22),
        ShaderStateType_DepthOnlyEnable = (1 << 23),
        ShaderStateType_ColorWriteMask = (1 << 24),
        ShaderStateType_HeightfieldTessellationEnable = (1 << 25),
        ShaderStateType_ColorScale = (1 << 26),
        ShaderStateType_Technique = (1 << 27),
        ShaderStateType_CullFrustum = (1 << 28),
        ShaderStateType_GeometryCullVolumes = (1 << 29),
        ShaderStateType_LightMapTextures = (1 << 30),
    };
}
