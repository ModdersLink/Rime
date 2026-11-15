using System.Collections.Generic;

namespace RimeLib.Shader
{
    /// <summary>A solution of a shader: the render path it is in, its index among the shader's solutions there, and its pixel shader.</summary>
    public sealed record ShaderSolutionPixel(string RenderPath, int Index, byte[] Bytecode);

    /// <summary>Reads the solutions of this engine's shader databases.</summary>
    public interface IShaderSolutionReader : IEngineInterface
    {
        /// <summary>The solutions of a shader with a pixel shader, in every render path of a shaderdb resource; none where it has no such shader.</summary>
        IReadOnlyList<ShaderSolutionPixel> GetPixelShaders(byte[] p_Database, uint p_Key);
    }
}
