using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using GameToolsDotNet.Rendering.DirectX;
using ImGuiNET;
using RimeLib;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO.Conversion;
using RimeLib.Mesh.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using RimeLib.Texture;
using RimeLib.Texture.DDS;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Buffer = SharpDX.Direct3D11.Buffer;
using Resource = SharpDX.Direct3D11.Resource;
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
            DrawDistanceMinimum = 1,
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
                IsDepthEnabled = true,
                DepthWriteMask = DepthWriteMask.All,
                DepthComparison = Comparison.LessEqual,
                IsStencilEnabled = true,
                StencilReadMask = 240,
                StencilWriteMask = 255,
                FrontFace = new DepthStencilOperationDescription()
                {
                    FailOperation = StencilOperation.Keep,
                    DepthFailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Replace,
                    Comparison = Comparison.GreaterEqual,
                },
                BackFace = new DepthStencilOperationDescription()
                {
                    FailOperation = StencilOperation.Keep,
                    DepthFailOperation = StencilOperation.Keep,
                    PassOperation = StencilOperation.Replace,
                    Comparison = Comparison.GreaterEqual,
                }
            }
        );

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
    }

    protected override void DrawFrameEarly(bool p_IsFocused)
    {
        base.DrawFrameEarly(p_IsFocused);

        if (m_MeshSet == null)
            return;
        
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

        //Device.ImmediateContext.OutputMerger.DepthStencilState = m_DepthStencilState;
        
        Device.ImmediateContext.DrawIndexed(1194, 0, 0);
        
        for (var i = 0; i < s_Lod.Subsets.Count; ++i)
        {
            // Set vertex shader.
            
            // Set input assembler input layout.
            // Set pixel shader.
            // Set pixel shader samplers.
            // Set input assembler primitive topology.
            // Set input assembler vertex buffer.
            // Set pixel shader shader resources.
            // Set pixel shader constant buffer.
            // Draw indexed.
        }

        // Restore rasterizer state.
        Device.ImmediateContext.Rasterizer.State = s_PrevState;
    }
}
