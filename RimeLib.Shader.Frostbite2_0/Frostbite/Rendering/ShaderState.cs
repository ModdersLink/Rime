using fb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Rendering
{
    public class ShaderState
    {
        public static readonly ShaderState c_DefaultState = new ShaderState()
        {
            //0x1FCFD862,
            StateFlags = 
                ShaderStateType.ShaderStateType_Mode |
                ShaderStateType.ShaderStateType_SkinningMethod |
                ShaderStateType.ShaderStateType_WorldTransform |
                ShaderStateType.ShaderStateType_View |
                ShaderStateType.ShaderStateType_TileViews |
                ShaderStateType.ShaderStateType_InvertCullMode |
                ShaderStateType.ShaderStateType_Fog |
                ShaderStateType.ShaderStateType_DynamicEnvmap |
                ShaderStateType.ShaderStateType_Stencil |
                ShaderStateType.ShaderStateType_WireframeEnable |
                ShaderStateType.ShaderStateType_Viewport |
                ShaderStateType.ShaderStateType_DepthBias |
                ShaderStateType.ShaderStateType_DepthOnlyEnable |
                ShaderStateType.ShaderStateType_ColorWriteMask |
                ShaderStateType.ShaderStateType_HeightfieldTessellationEnable |
                ShaderStateType.ShaderStateType_ColorScale |
                ShaderStateType.ShaderStateType_Technique |
                ShaderStateType.ShaderStateType_CullFrustum,

            InstanceCount = 1,

            RightHanded = true,
            GeometrySpace = ShaderGeometrySpace.ShaderGeometrySpace_ObjectScaled,
            DepthMode = RenderDepthMode.RenderDepthMode_ReadAndWrite,
            ColorWriteMask = 0xF,
        };

        // this should probably be cleaned up. Class with generic type parameter and enable bool?
        public ShaderStateType StateFlags { get; set; } = 0;

        public uint BoneVectorCount { get; set; } = 0;
        public uint InstanceCount { get; set; } = 0;
        public bool DepthOnlyEnable { get; set; } = false;

        public bool InvertCullMode { get; set; } = false;
        public bool WireframeEnable { get; set; } = false;
        public bool RightHanded { get; set; } = false;
        public bool HeightfieldTesselationEnable { get; set; } = false;


        public uint Technique { get; set; } = 0;
        public uint GeometryCullVolumeCount { get; set; } = 0;

        public ShaderGeometrySpace GeometrySpace { get; set; } = ShaderGeometrySpace.ShaderGeometrySpace_Object;
        public ShaderSkinningMethod SkinningMethod { get; set; } = ShaderSkinningMethod.ShaderSkinningMethod_None;

        public RenderDepthMode DepthMode { get; set; } = RenderDepthMode.RenderDepthMode_Disabled;
        public ShaderDepthBiasGroup DepthBiasGroup { get; set; } = ShaderDepthBiasGroup.ShaderDepthBiasGroup_Default;

        public uint ColorWriteMask { get; set; } = 0;


        //TODO: A bunch of render states
        /*
fb::ShaderParameterBlockHeader surfaceShaderParameterBlockHeader;
fb::ShaderParameterBlockHeader dynamicParameterBlockHeader;
fb::ShaderParameterBlock *surfaceShaderParameterBlock;
fb::ShaderParameterBlock *dynamicParameterBlock;

fb::ISurfaceShader *surfaceShader;
fb::IVertexShaderFragment *vertexShaderFragment;

fb::ViewState *view;
fb::ViewportRect *viewport;
fb::ViewportRect *scissorRect;

__m128 *boneVectors;
fb::Mat4 *worldTransforms;
fb::Mat4 *prevWorldTransforms;

fb::ShProbe *lightProbes;
fb::RadiosityLightMapState *lightMaps;
fb::RadiosityLightMapTextures *lightMapTextures;
fb::OutdoorLightState *outdoorLight;

fb::FogState *fog;

fb::FrustumSoA *cullFrustum;
fb::GeometryCullVolume *geometryCullVolumes;

fb::StencilState *stencil;
fb::DynamicEnvmapState *dynamicEnvmap;
        */
    }
}
