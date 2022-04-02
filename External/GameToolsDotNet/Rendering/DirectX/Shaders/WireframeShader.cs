using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SharpDX;
using SharpDX.D3DCompiler;
using SharpDX.Direct3D11;
using SharpDX.DXGI;

namespace GameToolsDotNet.Rendering.DirectX.Shaders
{
    [ShaderAttribute(ShaderType.Wireframe)]
    public class WireframeShader : Shader
    {
        [StructLayout(LayoutKind.Sequential, Size = kSizeOf)]
        public struct Vertex
        {
            public const int kSizeOf = 32;

            public Vector4 Position;
            public Vector4 Color;

            public Vertex(Vector3 position, Vector4 color)
            {
                this.Position = new Vector4(position, 1f);
                this.Color = color;
            }

            public Vertex(Vector4 position, Vector4 color)
            {
                this.Position = position;
                this.Color = color;
            }
        }

        public override bool InitializeGraphics(RenderManager manager, params object[] args)
        {
            // Get the application folder path.
            string appFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

            // Compile our vertex and pixel shaders.
            ShaderBytecode vertexByteCode = ShaderBytecode.Compile(Properties.Resources.Wireframe_fx, "VShader", "vs_4_0", ShaderFlags.None, EffectFlags.None);
            this.VertexShader = new VertexShader(manager.Device, vertexByteCode);

            ShaderBytecode pixelByteCode = ShaderBytecode.Compile(Properties.Resources.Wireframe_fx, "PShader", "ps_4_0", ShaderFlags.None, EffectFlags.None);
            this.PixelShader = new PixelShader(manager.Device, pixelByteCode);

            // Setup our vertex declaration and bind it to the inputs for the vertex shader.
            this.VertexDeclaration = new InputLayout(manager.Device, vertexByteCode.Data, new InputElement[]
                    {
                    new InputElement("POSITION",        0, Format.R32G32B32A32_Float,  0,   0),
                    new InputElement("COLOR",           0, Format.R32G32B32A32_Float, 16,   0),
                    });

            // Successfully initialized.
            return true;
        }
    }
}
