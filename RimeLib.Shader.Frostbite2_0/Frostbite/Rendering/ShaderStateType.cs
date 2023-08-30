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
        ShaderStateType_Mode 	 	 	 	 	 	  = (1 << 1),
        ShaderStateType_SurfaceShader 	 	  	 	  = (1 << 2),
        ShaderStateType_VertexShaderFragment  	 	  = (1 << 3),
        ShaderStateType_Bones 	 	 	 	 	 	  = (1 << 4),
        ShaderStateType_GeometrySpace 	 	 	 	  = (1 << 5),
        ShaderStateType_SkinningMethod 	 	 	 	  = (1 << 6),
        ShaderStateType_WorldTransform 	 	 	 	  = (1 << 7),
        ShaderStateType_PrevWorldTransform 	 	 	  = (1 << 8),
        ShaderStateType_LightProbe 	 	 	 	 	  = (1 << 9),
        ShaderStateType_LightMap 	 	 	 	 	  = (1 << 10),
        ShaderStateType_OutdoorLight 	 	 	 	  = (1 << 11),
        ShaderStateType_View 	 	 	 	 	 	  = (1 << 12),
        ShaderStateType_TileViews 	 	 	 	 	  = (1 << 13),
        ShaderStateType_RightHanded 	 	 	 	  = (1 << 14),
        ShaderStateType_InvertCullMode 	 	 	 	  = (1 << 15),
        ShaderStateType_Fog 	 	 	 	 	 	  = (1 << 16),
        ShaderStateType_DynamicEnvmap 	 	 	 	  = (1 << 17),
        ShaderStateType_Stencil 	 	 	 	 	  = (1 << 18),
        ShaderStateType_WireframeEnable 	 	 	  = (1 << 19),
        ShaderStateType_Viewport 	 	 	 	 	  = (1 << 20),
        ShaderStateType_ScissorRect 	 	 	 	  = (1 << 21),
        ShaderStateType_DepthMode 	 	 	 	 	  = (1 << 22),
        ShaderStateType_DepthBias 	 	 	 	 	  = (1 << 23),
        ShaderStateType_DepthOnlyEnable 	 	 	  = (1 << 24),
        ShaderStateType_ColorWriteMask 	 	 	 	  = (1 << 25),
        ShaderStateType_HeightfieldTessellationEnable = (1 << 26),
        ShaderStateType_ColorScale 	 	 	 	 	  = (1 << 27),
        ShaderStateType_Technique 	 	 	 	 	  = (1 << 28),
        ShaderStateType_CullFrustum 	 	 	 	  = (1 << 29),
        ShaderStateType_GeometryCullVolumes  	 	  = (1 << 30),
        ShaderStateType_LightMapTextures 	 	 	  = (1 << 31),
 
    };
}
