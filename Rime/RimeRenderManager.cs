using System;
using System.Collections.Generic;
using System.Linq;
using GameToolsDotNet.Rendering.DirectX;
using ImGuiNET;
using RimeLib.Content.Mounting;
using RimeLib.Mesh.Frostbite;
using RimeLib.Shader.Frostbite2_0.Frostbite;
using SharpDX;
using SharpDX.Direct3D11;
using SharpDX.DXGI;
using Buffer = SharpDX.Direct3D11.Buffer;
using Resource = SharpDX.Direct3D11.Resource;
using Vector2 = System.Numerics.Vector2;

namespace Rime;

public class RimeRenderManager : RenderManager
{
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
            RightHandPerspective = false,
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
    private Buffer[] m_VertexBuffers = Array.Empty<Buffer>();
    private VertexBufferBinding[] m_VertexBufferBindings = Array.Empty<VertexBufferBinding>();

    private VertexShader[] m_VertexShaders;
    private InputLayout[] m_InputLayouts;
    private SamplerState[][] m_VertexSamplers;
    private PixelShader[] m_PixelShaders;
    private SamplerState[][] m_PixelSamplers;
    private GeometryShader[] m_GeometryShaders;

    public void DrawMesh(MeshSetLayout p_MeshSet, SurfaceShaderInfo p_Shader, IEngineMounter p_Mounter)
    {
        var s_LodPtr = p_MeshSet.Lods.First();
        
        //foreach (var s_LodPtr in p_MeshSet.Lods)
        {
            var s_Lod = s_LodPtr.Object;
            
            var s_Name = s_Lod.Name.Object;

            var s_LodChunkId = s_Lod.DataChunkId;
            
            if (!p_Mounter.TryGetChunk(s_LodChunkId, out var s_Chunk))
                return;

            using var s_LodReader = s_Chunk.FirstVariant.GetReader();

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

            var s_VertexShaders = new List<VertexShader>();
            var s_InputLayouts = new List<InputLayout>();
            var s_VertexSamplers = new List<SamplerState[]>();
            var s_PixelShaders = new List<PixelShader>();
            var s_PixelSamplers = new List<SamplerState[]>();
            var s_GeometryShaders = new List<GeometryShader>();
            
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
        }

        m_Shader = p_Shader;
        m_MeshSet = p_MeshSet;
    }

    protected override void DrawFrameEarly(bool p_IsFocused)
    {
        base.DrawFrameEarly(p_IsFocused);

        if (m_MeshSet == null)
            return;

        var s_Lod = m_MeshSet.Lods.First().Object;

        // Set input assembler index buffer.
        var s_Format = s_Lod.IndexBufferFormat == IndexBufferFormat.IndexBufferFormat_16Bit
            ? Format.R16_UInt
            : Format.R32_UInt;
        
        Device.ImmediateContext.InputAssembler.SetIndexBuffer(m_IndexBuffer, s_Format, 0);
        
        // NOTE: For each solution create vertex shader, input elements,
        // use them to create an input layout and a pixel shader,
        // and to also create pixel samplers.

        // Store rasterizer state.
        var s_PrevState = Device.ImmediateContext.Rasterizer.State;

        Device.ImmediateContext.InputAssembler.SetVertexBuffers(0, m_VertexBufferBindings);
        
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
