using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using fb;
using GameToolsDotNet.Rendering.DirectX;
using ImGuiNET;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite2_0.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Texture;
using RimeLib.Texture.DDS;
using SharpDX;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using SharpDX.Mathematics.Interop;
using Buffer = SharpDX.Direct3D11.Buffer;
using Resource = SharpDX.Direct3D11.Resource;
using StencilOperation = SharpDX.Direct3D11.StencilOperation;
using Vector2 = System.Numerics.Vector2;
using Vector3 = SharpDX.Vector3;
using Vector4 = SharpDX.Vector4;

namespace Rime;

public class RimeRenderManager : RenderManager
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct VertexGlobals
    {
        public Matrix WorldMatrix;
    }
    
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ViewConstants
    {
        public float Time;
        private readonly uint _pad0;
        private readonly ulong _pad1;
        public Vector4 ScreenSize;
        public Vector3 DebugNonFiniteColor;
        private readonly uint _pad2;
        public Matrix ViewMatrix;
        public Matrix ProjMatrix;
        public Matrix ViewProjMatrix;
        public Matrix CrViewProjMatrix;
        public Vector4 ViewportZMinMaxKzKw;
        public Vector3 CameraPos;
        private readonly uint _pad3;
        public Vector3 TransparentStartAndEndAndClamp;
        private readonly uint _pad4;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct ExternalConstants
    {
        public Vector4 Color;
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct DeferredGlobals
    {
        public Vector3 LightDirection;
        private readonly float _pad;
    }
    
    private Resource? m_TextureResource = null;
    private ShaderResourceView? m_ResourceView = null;
    private Vector2 m_ResourceSize = Vector2.Zero;

    public RimeRenderManager() : base(GetRenderConfig())
    {
    }

    private static RenderConfig GetRenderConfig()
    {
        return new RenderConfig()
        {
            DebugLayerEnabled = true,
            DrawDistanceMinimum = 0.01f,
            DrawDistanceMaximum = 9999,
            RightHandPerspective = true,
            UpAxis = UpAxis.Y_Up,
        };
    }

    public override object GetResourceFromFileName(string p_FileName)
    {
        throw new NotImplementedException();
    }

    public override object GetResourceFromKey(object p_Key)
    {
        throw new NotImplementedException();
    }

    public void SetTexture(ShaderResourceView p_Resource)
    {
        m_ResourceSize = new Vector2(256, 256);
        m_ResourceView = p_Resource;
    }

    protected override void RenderGuiLayer(bool p_IsFocused)
    {
        base.RenderGuiLayer(p_IsFocused);

        if (m_ResourceView != null)
        {
            ImGui.Begin("Texture Viewer");

            ImGui.Image(m_ResourceView.NativePointer, m_ResourceSize);

            ImGui.End();
        }
    }

    private MeshSetLayout? m_MeshSet;
    private SurfaceShaderInfo? m_Shader;
    private Buffer? m_IndexBuffer;
    //private Buffer? m_VertexBuffer;
    private Buffer[] m_VertexBuffers = Array.Empty<Buffer>();
    private VertexBufferBinding[] m_VertexBufferBindings = Array.Empty<VertexBufferBinding>();

    private Buffer? m_VertexGlobalsBuffer;
    private Buffer? m_ViewConstantsBuffer;
    private Buffer? m_ExternalConstantsBuffer;
    private Buffer? m_DeferredGlobalsBuffer;

    private VertexShader[] m_VertexShaders;
    private InputLayout[] m_InputLayouts;
    private SamplerState[][] m_VertexSamplers;
    private PixelShader[] m_PixelShaders;
    private SamplerState[][] m_PixelSamplers;
    private GeometryShader[] m_GeometryShaders;

    private Tuple<byte, ShaderResourceView>[][] m_Textures;
    
    private DepthStencilState? m_DepthStencilState;

    private VertexGlobals m_VertexGlobals;
    private ViewConstants m_ViewConstants;
    private ExternalConstants m_ExternalConstants;
    private DeferredGlobals m_DeferredGlobals;

    public void DrawMesh(MeshSetLayout p_MeshSet, SurfaceShaderInfo p_Shader, IEngineMounter p_Mounter, ShaderProgramDatabase p_ShaderProgramDb)
    {
        var s_Converter = EngineInterfaceRegistry.Create<ITextureConverter>(EngineType.Frostbite2_0);

        var s_LodPtr = p_MeshSet.Lods.First();
        
        //foreach (var s_LodPtr in p_MeshSet.Lods)
        {
            var s_Lod = s_LodPtr.Object;
            
            var s_Name = s_Lod.Name.Object;

            var s_LodChunkId = s_Lod.DataChunkId;
            
            if (!p_Mounter.TryGetChunk(s_LodChunkId, out var s_Chunk))
                return;

            using var s_LodReader = s_Chunk.FirstVariant.GetReader();
            s_LodReader.Endianness = Endianness.LittleEndian;
            
            /*using var s_VertexStream = new DataStream(
                (int)s_Lod.VertexDataSize,
                true,
                true
            );

            s_VertexStream.Write(s_LodReader.ReadBytes((int)s_Lod.VertexDataSize), 0, (int)s_Lod.VertexDataSize);
            s_VertexStream.Seek(0, SeekOrigin.Begin);
            
            m_VertexBuffer = new Buffer(
                Device,
                s_VertexStream,
                (int)s_Lod.VertexDataSize,
                ResourceUsage.Immutable,
                BindFlags.VertexBuffer,
                CpuAccessFlags.None,
                ResourceOptionFlags.None,
                32
            );*/

            m_VertexBuffers = new Buffer[s_Lod.Subsets.Count];
            m_VertexBufferBindings = new VertexBufferBinding[s_Lod.Subsets.Count];

            for (var i = 0; i < s_Lod.Subsets.Get.Length; i++)
            {
                var s_Subset = s_Lod.Subsets.Get[i];
                var s_VertexBufferSize = (int)(s_Subset.VertexCount * s_Subset.VertexStride);
                
                using var s_VertexStream = new DataStream(
                    s_VertexBufferSize,
                    true,
                    true
                );

                s_VertexStream.Write(s_LodReader.ReadBytes(s_VertexBufferSize), 0, s_VertexBufferSize);
                s_VertexStream.Seek(0, SeekOrigin.Begin);

                m_VertexBuffers[i] = new Buffer(
                    Device,
                    s_VertexStream,
                    s_VertexBufferSize,
                    ResourceUsage.Default,
                    BindFlags.VertexBuffer,
                    CpuAccessFlags.None,
                    ResourceOptionFlags.None,
                    0
                );

                m_VertexBufferBindings[i] = new VertexBufferBinding(m_VertexBuffers[i], s_Subset.VertexStride, 0);
            }

            if (s_Lod.IndexBufferFormat == IndexBufferFormat.IndexBufferFormat_16Bit)
            {
                var s_Indices = new ushort[s_Lod.IndexDataSize / sizeof(ushort)];

                for (var i = 0; i < s_Indices.Length; ++i)
                    s_Indices[i] = s_LodReader.ReadUInt16();
                
                m_IndexBuffer = Buffer.Create(Device, BindFlags.IndexBuffer, s_Indices);
            }
            else
            {
                var s_Indices = new uint[s_Lod.IndexDataSize / sizeof(uint)];

                for (var i = 0; i < s_Indices.Length; ++i)
                    s_Indices[i] = s_LodReader.ReadUInt32();
                
                m_IndexBuffer = Buffer.Create(Device, BindFlags.IndexBuffer, s_Indices);
            }
            
            var s_VertexShaders = new List<VertexShader>();
            var s_InputLayouts = new List<InputLayout>();
            var s_VertexSamplers = new List<SamplerState[]>();
            var s_PixelShaders = new List<PixelShader>();
            var s_PixelSamplers = new List<SamplerState[]>();
            var s_GeometryShaders = new List<GeometryShader>();
            var s_Textures = new List<Tuple<byte, ShaderResourceView>[]>();
               
            foreach (var s_Solution in p_Shader.Solutions)
            {
                if (s_Solution.VertexPermutation != null)
                {
                    var s_Shader = new VertexShader(Device, s_Solution.VertexPermutation.ShaderBytecode);
                    var s_InputLayout = new InputLayout(
                        Device,
                        s_Solution.VertexPermutation.InputSignatureBytecode,
                        s_Solution.VertexPermutation.Elements
                    );

                    s_VertexShaders.Add(s_Shader);
                    s_InputLayouts.Add(s_InputLayout);
                }

                if (s_Solution.VertexConstants != null)
                {
                    var s_Samplers = new List<SamplerState>();
                    
                    foreach (var s_Sampler in s_Solution.VertexConstants.Samplers)
                    {
                        s_Samplers.Add(new SamplerState(Device, s_Sampler.Desc));
                    }
                    
                    s_VertexSamplers.Add(s_Samplers.ToArray());
                }
                
                if (s_Solution.PixelPermutation != null)
                {
                    var s_Shader = new PixelShader(Device, s_Solution.PixelPermutation.ShaderBytecode);
                   
                    s_PixelShaders.Add(s_Shader);
                }

                if (s_Solution.PixelConstants != null)
                {
                    var s_Samplers = new List<SamplerState>();
                    
                    foreach (var s_Sampler in s_Solution.PixelConstants.Samplers)
                    {
                        s_Samplers.Add(new SamplerState(Device, s_Sampler.Desc));
                    }
                    
                    s_PixelSamplers.Add(s_Samplers.ToArray());

                    var s_OwnTextures = new List<Tuple<byte, ShaderResourceView>>();

                    foreach (var s_Texture in s_Solution.PixelConstants.Textures)
                    {
                        if (!p_Mounter.TryGetResource(s_Texture.Name, out var s_TextureResource))
                            throw new Exception($"Could not find texture '{s_Texture.Name}' for shader.");

                        var s_ResourceView = s_Converter.CreateTextureResourceView(s_TextureResource.FirstVariant, p_Mounter, Device);
                        s_OwnTextures.Add(Tuple.Create(s_Texture.Index, s_ResourceView));
                    }
                    
                    s_Textures.Add(s_OwnTextures.ToArray());
                }
                
                if (s_Solution.GeometryPermutation != null)
                {
                    var s_Shader = new GeometryShader(Device, s_Solution.GeometryPermutation.ShaderBytecode);
                   
                    s_GeometryShaders.Add(s_Shader);
                }
            }
            
            m_VertexShaders = s_VertexShaders.ToArray();
            m_InputLayouts = s_InputLayouts.ToArray();
            m_VertexSamplers = s_VertexSamplers.ToArray();
            m_PixelShaders = s_PixelShaders.ToArray();
            m_PixelSamplers = s_PixelSamplers.ToArray();
            m_GeometryShaders = s_GeometryShaders.ToArray();
            m_Textures = s_Textures.ToArray();
        }

        m_Shader = p_Shader;
        m_MeshSet = p_MeshSet;

        m_DepthStencilState = new DepthStencilState(
            Device,
            new DepthStencilStateDescription()
            {
                IsDepthEnabled = false,
                DepthWriteMask = DepthWriteMask.All,
                DepthComparison = Comparison.GreaterEqual,
                IsStencilEnabled = false,
                StencilReadMask = 0xff,
                StencilWriteMask = 0xff,
                FrontFace = new DepthStencilOperationDescription()
                {
                    FailOperation = StencilOperation.Keep,
                    DepthFailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Replace,
                    Comparison = Comparison.Always,
                },
                BackFace = new DepthStencilOperationDescription()
                {
                    FailOperation = StencilOperation.Keep,
                    DepthFailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Replace,
                    Comparison = Comparison.Always,
                }
            }
        );

        m_ExternalConstants = new ExternalConstants()
        {
            Color = new Vector4(1.0f, 0.0f, 0.0f, 1.0f)
        };

        m_VertexGlobalsBuffer = Buffer.Create(
            Device,
            BindFlags.ConstantBuffer,
            ref m_VertexGlobals,
            Utilities.SizeOf<VertexGlobals>()
        );

        m_ViewConstantsBuffer = Buffer.Create(
            Device,
            BindFlags.ConstantBuffer,
            ref m_ViewConstants,
            Utilities.SizeOf<ViewConstants>()
        );
        
        m_ExternalConstantsBuffer = Buffer.Create(
            Device,
            BindFlags.ConstantBuffer,
            ref m_ExternalConstants,
            Utilities.SizeOf<ExternalConstants>()
        );
        
        m_DeferredGlobalsBuffer = Buffer.Create(
            Device,
            BindFlags.ConstantBuffer,
            ref m_DeferredGlobals,
            Utilities.SizeOf<DeferredGlobals>()
        );

        var s_RTDesc = new Texture2DDescription()
        {
            ArraySize = 1,
            MipLevels = 1,
            Width = ViewSize.Width,
            Height = ViewSize.Height,
            Format = Format.R8G8B8A8_UNorm,
            SampleDescription = new SampleDescription(1, 0),
            Usage = ResourceUsage.Default,
            BindFlags = BindFlags.ShaderResource | BindFlags.RenderTarget,
            CpuAccessFlags = CpuAccessFlags.None,
            OptionFlags = ResourceOptionFlags.None,
        };
        
        m_RTTex0 = new Texture2D(Device, s_RTDesc);
        m_RTTex1 = new Texture2D(Device, s_RTDesc);
        m_RTTex2 = new Texture2D(Device, s_RTDesc);
        m_RTTex3 = new Texture2D(Device, s_RTDesc);

        m_RT0 = new RenderTargetView(Device, m_RTTex0);
        m_RT1 = new RenderTargetView(Device, m_RTTex1);
        m_RT2 = new RenderTargetView(Device, m_RTTex2);
        m_RT3 = new RenderTargetView(Device, m_RTTex3);

        m_GBufferResourceView0 = new ShaderResourceView(Device, m_RTTex0);
        m_GBufferResourceView1 = new ShaderResourceView(Device, m_RTTex1);
        m_GBufferResourceView2 = new ShaderResourceView(Device, m_RTTex2);
        m_GBufferResourceView3 = new ShaderResourceView(Device, m_RTTex3);
        
        ///////////////////////////

        if (!p_ShaderProgramDb.TryGetShader(ShaderStageType.ShaderStageType_Vertex, "Dx11/DeferredOutdoorLightTile", out var s_DeferredOutdoorLightTileVS))
            return;

        if (!p_ShaderProgramDb.TryGetShader(ShaderStageType.ShaderStageType_Pixel, "Dx11/DeferredOutdoorLightTile_key=1,trans=0,skin=1,specular=1,shadowSlice=0,shadowQuality=0,shadowMode=0,cloud=1,skyVis=0,dynamicEnvmap=0,msaa=1,gbLayout=0", out var s_DeferredOutdoorLightTilePS))
            return;

        if (!p_ShaderProgramDb.TryGetShader(ShaderStageType.ShaderStageType_Vertex, "Dx11/Tonemap", out var s_TonemapVS))
            return;

        if (!p_ShaderProgramDb.TryGetShader(ShaderStageType.ShaderStageType_Pixel, "Dx11/Tonemap_tonemap=0,grain=0,dof=0,blur=0,colorGrading=0,chromostereopsis=0,distort=0", out var s_TonemapPS))
            return;

        var s_ReflectShader = (byte[] p_ShaderBytecode) =>
        {
            var s_Reflect = new ShaderReflection(p_ShaderBytecode);

            for (var i = 0; i < s_Reflect.Description.ConstantBuffers; ++i)
            {
                var s_Cb = s_Reflect.GetConstantBuffer(i);
                Debug.WriteLine($"Constant buffer {s_Cb.Description.Name} of size {s_Cb.Description.Size} and type {s_Cb.Description.Type}.");
                
                for (var j = 0; j < s_Cb.Description.VariableCount; ++j)
                {
                    var s_Variable = s_Cb.GetVariable(j);
                    Debug.WriteLine($"Variable {s_Variable.Description.Name} of type {s_Variable.GetVariableType().Description.Name} at offset {s_Variable.Description.StartOffset}.");
                }
            }

            for (var i = 0; i < s_Reflect.Description.InputParameters; ++i)
            {
                var s_Param = s_Reflect.GetInputParameterDescription(i);
                Debug.WriteLine($"Input parameter {s_Param.SemanticName} of type {s_Param.ComponentType} at register {s_Param.Register}.");
            }

            for (var i = 0; i < s_Reflect.Description.OutputParameters; ++i)
            {
                var s_Param = s_Reflect.GetOutputParameterDescription(i);
                Debug.WriteLine($"Output parameter {s_Param.SemanticName} of type {s_Param.ComponentType} at register {s_Param.Register}.");
            }

            for (var i = 0; i < s_Reflect.Description.BoundResources; ++i)
            {
                var s_Resource = s_Reflect.GetResourceBindingDescription(i);
                Debug.WriteLine($"Bound resource {s_Resource.Name} of type {s_Resource.Type}.");
            }
        };

        s_ReflectShader(s_DeferredOutdoorLightTileVS.Data);
        s_ReflectShader(s_DeferredOutdoorLightTilePS.Data);
        s_ReflectShader(s_TonemapVS.Data);
        s_ReflectShader(s_TonemapPS.Data);

        // TODO: Dx11/DeferredOutdoorLightTile VS
        // Dx11/DeferredOutdoorLightTile_key=1,trans=0,skin=1,specular=1,shadowSlice=0,shadowQuality=0,shadowMode=0,cloud=1,skyVis=0,dynamicEnvmap=0,msaa=1,gbLayout=0 PS

        // These appear hardcoded but can probably use D3DReflect
        // g_shadowmapTexture0 = 2048 x 2048 R16_Typeless white
        // g_transShadowmapTexture0 = 2048 x 2048 R8G8B8A8_UNORM black
        // same for Texture1 and 2
        // g_cloudShadowTexture = 1x1 R8G8B8A8_UNORM white
        // g_skyEnvmap = 128 x 128 R8G8B8A8_UNORM black
        // g_customEnvmap = 512 x 512 BC3_TYPELESS (can probably do R8G8B8A8_UNORM) black
        // g_depthTexture = depth rt
        // g_bufferTexture0 = RT0
        // g_bufferTexture1 = RT1
        // g_bufferTexture2 = RT2
        // g_bufferTexture3 = ??? View size R8G8B8A8_UNORM
        // g_msaaClasifyTexture = view size R8_UNORM black

        // PS $Globals
        // g_cameraPos float3
        // g_invScreenSize float2
        // g_invViewProjMatrix = float4x4
        // g_shadowmapHalfSizeAndInvHalfSize = float4
        // g_shadowmapPoissonScale = float4
        // g_shadowmapNoiseTilingFactor = float4
        // g_cloudOffsetAndScale = float3
        // g_cloudCoverageAndExponent = float2
        // g_lightDir = float3
        // g_keyColor = float4
        // g_keyTranslucencyParams = float4
        // g_shadowmapTransform0 = float4x4
        // g_shadowmapTransform1 = float4x4
        // g_shadowmapTransform2 = float4x4
        // g_subParams = float4
        // g_envmapParams = float4
        // g_skyEnvmap8BitTexInvScale = float
        // g_colorScale = float


        // Dx11/Tonemap VS
        // Dx11/Tonemap_tonemap=0,grain=0,dof=0,blur=0,colorGrading=0,chromostereopsis=0,distort=0 PS

        // mainTexture = output of prev stage
        // tonemapBloomTexture = 640x360 R16G16B16A16_FLOAT black
        // colorGradingTexture = 32x32x32 T8G8B8A8_UNORM weird
        // filmGrainTexture = 512x512 R8_UNORM red

        // These are fetched by using D3DReflect
        // VS / PS $Globals
        // invPixelSize = float2
        // depthFactors = float4
        // fadeParams = float2
        // color = float4
        // colorMatrix0 = float4
        // colorMatrix1 = float 4
        // colorMatrix2 = float 4
        // exponent = float
        // combineTextureWeights = float4[2]
        // colorScale = float4
        // invTexelSize = float2
        // downsampleQuarterZOffset = float4
        // sampleCount int
        // filterWidth = float
        // mipLevelSource = float
        // radialBlurScales = float4
        // radialBlurCenter = float2
        // poissonRadialBlurConstants = float4
        // blendFactor = float
        // filmGrainColorScale = float3
        // filmGrainTextureScaleAndOffset = float4
        // depthScaleFactors = float3
        // dofParams = float4
        // bloomScale = float3
        // invGamma = float3
        // luminanceVector = float3
        // vignetteParams = float3
        // VignetteColor = float4
        // chromostereopsisParams = float4

        var s_DeferredShaderCode = @"
// Resources.
Texture2D g_Buffer0 : register(t0); // Normal
Texture2D g_Buffer1 : register(t1); // Diffuse
Texture2D g_Buffer2 : register(t2); // ??
Texture2D g_Buffer3 : register(t3); // ??

// Samplers.
SamplerState Sampler0 : register(s0);

// Globals.
float3 lightDirection;

struct VertexOutput
{
	float4 position : SV_POSITION;
	float2 texcoord0 : TEXCOORD0;
};

VertexOutput VS(float4 position : POSITION, float2 texcoord : TEXCOORD0)
{
	VertexOutput output;

	// Pass the position and texcoord through to the pixel shader.
	output.position = position;
	output.texcoord0 = texcoord;

	return output;
}

float4 PS(VertexOutput I) : SV_Target
{
	float4 colors;
    float4 normals;
    float3 lightDir;
    float lightIntensity;
    float4 outputColor;

    // Sample the colors from the color render texture using the point sampler at this texture coordinate location.
    colors = g_Buffer1.Sample(Sampler0, I.texcoord0);
    colors.w = 1.0f;

    // Sample the normals from the normal render texture using the point sampler at this texture coordinate location.
    normals = g_Buffer0.Sample(Sampler0, I.texcoord0);
    normals.w = 1.0f;

    // Calculate the amount of light on this pixel.
    lightIntensity = saturate(dot(normals.xyz, lightDirection));

    // Determine the final amount of diffuse color based on the color of the pixel combined with the light intensity.
    outputColor = saturate(colors * lightIntensity);

    return outputColor;
}
        ";
        
        var s_DeferredVertexBytecode = ShaderBytecode.Compile(s_DeferredShaderCode, "VS", "vs_4_0", ShaderFlags.Debug);
        var s_DeferredPixelBytecode = ShaderBytecode.Compile(s_DeferredShaderCode, "PS", "ps_4_0", ShaderFlags.Debug);

        m_DeferredVertexShader = new VertexShader(Device, s_DeferredVertexBytecode);
        m_DeferredPixelShader = new PixelShader(Device, s_DeferredPixelBytecode);
        
        m_DeferredInputLayout = new InputLayout(Device, s_DeferredVertexBytecode, new[]
        {
            new InputElement("POSITION", 0, Format.R32G32B32A32_Float, 0, 0),
            new InputElement("TEXCOORD", 0, Format.R32G32_Float, 16, 0)
        });
        
        ScreenToTextureVertex[] vertices = new ScreenToTextureVertex[4]
        {
            new ScreenToTextureVertex(new Vector4(-1f, 1f, 0f, 1f), new Vector2(0f, 0f)),
            new ScreenToTextureVertex(new Vector4(1f, 1f, 0f, 1f), new Vector2(1f, 0f)),
            new ScreenToTextureVertex(new Vector4(-1f, -1f, 0f, 1f), new Vector2(0f, 1f)),
            new ScreenToTextureVertex(new Vector4(1f, -1f, 0f, 1f), new Vector2(1f, 1f))
        };
        
        m_DeferredVertexBuffer = Buffer.Create(this.Device, BindFlags.VertexBuffer, vertices);

        m_RasterizerState = new RasterizerState(
            Device,
            new RasterizerStateDescription()
            {
                CullMode = CullMode.None,
                FillMode = FillMode.Solid,
                IsDepthClipEnabled = true,
            }
        );

        m_DeferredSamplerState = new SamplerState(Device, new SamplerStateDescription
        {
            AddressU = TextureAddressMode.Clamp,
            AddressV = TextureAddressMode.Clamp,
            AddressW = TextureAddressMode.Clamp,
            BorderColor = new RawColor4(0.0f, 0.0f, 0.0f, 0.0f),
            MaximumLod = 0,
            Filter = Filter.MinMagLinearMipPoint,
            MipLodBias = 0,
            MaximumAnisotropy = 8,
            ComparisonFunction = Comparison.Never
        });
    }

    private Texture2D m_RTTex0;
    private RenderTargetView m_RT0;
    private ShaderResourceView m_GBufferResourceView0;
    private Texture2D m_RTTex1;
    private RenderTargetView m_RT1;
    private ShaderResourceView m_GBufferResourceView1;
    private Texture2D m_RTTex2;
    private RenderTargetView m_RT2;
    private ShaderResourceView m_GBufferResourceView2;
    private Texture2D m_RTTex3;
    private RenderTargetView m_RT3;
    private ShaderResourceView m_GBufferResourceView3;
    
    private SamplerState m_DeferredSamplerState;

    private VertexShader m_DeferredVertexShader;
    private PixelShader m_DeferredPixelShader;
    private InputLayout m_DeferredInputLayout;
    private Buffer m_DeferredVertexBuffer;

    private RasterizerState m_RasterizerState;
    
    [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
    public struct ScreenToTextureVertex
    {
        public const int kSizeOf = 16 + 8;

        public Vector4 Postion;
        public Vector2 Texcoord;

        public ScreenToTextureVertex(Vector4 position, Vector2 texcoord)
        {
            this.Postion = position;
            this.Texcoord = texcoord;
        }
    }

    private void ResetShaderInputs()
    {
        for (var i = 0; i < 16; ++i)
        {
            Device.ImmediateContext.VertexShader.SetShaderResource(i, null);
            Device.ImmediateContext.PixelShader.SetShaderResource(i, null);
        }
    }
    
    protected override void DrawFrameEarly(bool p_IsFocused)
    {
        base.DrawFrameEarly(p_IsFocused);

        if (m_MeshSet == null)
            return;

        ResetShaderInputs();

        Device.ImmediateContext.ClearRenderTargetView(m_RT0, new RawColor4(0.0f, 0.0f, 0.0f, 0.0f));
        Device.ImmediateContext.ClearRenderTargetView(m_RT1, new RawColor4(0.0f, 0.0f, 0.0f, 0.0f));
        Device.ImmediateContext.ClearRenderTargetView(m_RT2, new RawColor4(0.0f, 0.0f, 0.0f, 0.0f));
        Device.ImmediateContext.ClearRenderTargetView(m_RT3, new RawColor4(0.0f, 0.0f, 0.0f, 0.0f));
        
        Device.ImmediateContext.OutputMerger.SetRenderTargets(DepthStencilView, m_RT0, m_RT1, m_RT2, m_RT3);
        
        var s_ViewMatrix = Camera.ViewMatrix;
        var s_ProjectionMatrix = ProjectionMatrix;
        var s_ViewMatrixAtOrigin = s_ViewMatrix;
        s_ViewMatrixAtOrigin.TranslationVector = Vector3.Zero;

        m_VertexGlobals.WorldMatrix = Matrix.Identity;

        m_ViewConstants.Time = RenderTime.TimeDelta;
        m_ViewConstants.ScreenSize = new Vector4(ViewSize.Width, ViewSize.Height, 0, 0);

        m_ViewConstants.ViewMatrix = Matrix.Transpose(s_ViewMatrix);
        m_ViewConstants.ProjMatrix = Matrix.Transpose(s_ProjectionMatrix);
        m_ViewConstants.ViewProjMatrix =  Matrix.Transpose(s_ViewMatrix * s_ProjectionMatrix);
        m_ViewConstants.CrViewProjMatrix = Matrix.Transpose(s_ViewMatrixAtOrigin * s_ProjectionMatrix);
        m_ViewConstants.ViewportZMinMaxKzKw = new Vector4(0.0f, 10.0f, 0.0f, 0.0f);
        m_ViewConstants.CameraPos = Camera.Position;
        m_ViewConstants.TransparentStartAndEndAndClamp = new Vector3(0.0f, 0.1f, 0.0f);

        Device.ImmediateContext.UpdateSubresource(ref m_VertexGlobals, m_VertexGlobalsBuffer);
        Device.ImmediateContext.UpdateSubresource(ref m_ViewConstants, m_ViewConstantsBuffer);

        Device.ImmediateContext.VertexShader.SetConstantBuffer(0, m_VertexGlobalsBuffer);
        Device.ImmediateContext.VertexShader.SetConstantBuffer(2, m_ViewConstantsBuffer);
        
        Device.ImmediateContext.PixelShader.SetConstantBuffer(1, m_ExternalConstantsBuffer);
        
        var s_Lod = m_MeshSet.Lods.First().Object;

        // Set input assembler index buffer.
        var s_Format = s_Lod.IndexBufferFormat == IndexBufferFormat.IndexBufferFormat_16Bit
            ? Format.R16_UInt
            : Format.R32_UInt;
        
        // NOTE: For each solution create vertex shader, input elements,
        // use them to create an input layout and a pixel shader,
        // and to also create pixel samplers.

        // Store rasterizer state.
        var s_PrevState = Device.ImmediateContext.Rasterizer.State;

        Device.ImmediateContext.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleList;
        Device.ImmediateContext.InputAssembler.SetVertexBuffers(0, m_VertexBufferBindings);
        Device.ImmediateContext.InputAssembler.SetIndexBuffer(m_IndexBuffer, s_Format, 0);
        
        Device.ImmediateContext.HullShader.Set(null);
        Device.ImmediateContext.DomainShader.Set(null);

        // 0, 5 - 9, 11, 14
        var s_SolutionIndex = 8;
        
        Device.ImmediateContext.VertexShader.Set(m_VertexShaders[s_SolutionIndex]);
        Device.ImmediateContext.VertexShader.SetSamplers(0, m_VertexSamplers[s_SolutionIndex]);
        
        Device.ImmediateContext.PixelShader.Set(m_PixelShaders[s_SolutionIndex]);
        Device.ImmediateContext.PixelShader.SetSamplers(0, m_PixelSamplers[s_SolutionIndex]);
        
        Device.ImmediateContext.InputAssembler.InputLayout = m_InputLayouts[s_SolutionIndex];

        foreach (var (s_Index, s_ResourceView) in m_Textures[s_SolutionIndex])
            Device.ImmediateContext.PixelShader.SetShaderResources(s_Index, s_ResourceView);

        Device.ImmediateContext.OutputMerger.DepthStencilState = DepthStencilState;

        //Device.ImmediateContext.OutputMerger.BlendState = m_BlendState;
        
        Device.ImmediateContext.DrawIndexed(1194, 0, 0);

        // Now do deferred shading.
        ResetShaderInputs();
        
        Device.ImmediateContext.OutputMerger.SetRenderTargets(DepthStencilView, RenderView);
        
        m_DeferredGlobals.LightDirection = new Vector3(0.0f, 0.0f, 1.0f);
        Device.ImmediateContext.UpdateSubresource(ref m_DeferredGlobals, m_DeferredGlobalsBuffer);

        Device.ImmediateContext.PixelShader.SetShaderResources(
            0,
            m_GBufferResourceView0,
            m_GBufferResourceView1,
            m_GBufferResourceView2,
            m_GBufferResourceView3
        );

        Device.ImmediateContext.InputAssembler.PrimitiveTopology = PrimitiveTopology.TriangleStrip;
        Device.ImmediateContext.InputAssembler.SetVertexBuffers(0, new VertexBufferBinding(m_DeferredVertexBuffer, ScreenToTextureVertex.kSizeOf, 0));

        Device.ImmediateContext.VertexShader.Set(m_DeferredVertexShader);
        Device.ImmediateContext.PixelShader.Set(m_DeferredPixelShader);
        Device.ImmediateContext.PixelShader.SetSampler(0, m_DeferredSamplerState);

        Device.ImmediateContext.InputAssembler.InputLayout = m_DeferredInputLayout;

        Device.ImmediateContext.PixelShader.SetConstantBuffer(0, m_DeferredGlobalsBuffer);
        
        Device.ImmediateContext.Rasterizer.State = m_RasterizerState;
        Device.ImmediateContext.OutputMerger.BlendState = TransparencyBlendState;
        Device.ImmediateContext.OutputMerger.DepthStencilState = m_DepthStencilState;
        
        Device.ImmediateContext.Draw(4, 0);
      
        // Restore rasterizer state.
        Device.ImmediateContext.Rasterizer.State = s_PrevState;
    }
}
