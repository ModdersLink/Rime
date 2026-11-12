using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite;

namespace RimeLib.Shader
{
    /// <summary>A shader to convert: its name in the target, and the target's shader it draws like.</summary>
    /// <param name="Name">The shader asset's name in the target, as written.</param>
    /// <param name="TemplateKey">The key of the template shader in the template database.</param>
    public sealed record ConvertedShader(string Name, uint TemplateKey);

    /// <summary>
    /// A shader whose g-buffer pixel shader was translated into the target's: its name in the target, the source
    /// solution the translation was made from, the target's shader it is drawn as, and the translated bytecode for
    /// each of that template's solutions (by index, in the render path it was translated for).
    /// </summary>
    public sealed record TranslatedShader(string Name, uint SourceKey, int SourceSolution, uint TemplateKey,
        string RenderPath, IReadOnlyDictionary<int, byte[]> Pixels);

    /// <summary>Converts shaders of this engine's shader databases to another engine's.</summary>
    public interface IShaderDatabaseConverter : IEngineInterface
    {
        /// <summary>
        /// A shader database of the target's engine holding the given shaders of this engine's
        /// database, each under its name in the target. Each takes the type and solution states of
        /// its template, a shader of the target's engine drawn in the same role, solution for
        /// solution; its own bytecode, constants and textures are kept. Shaders whose solutions do
        /// not pair with their template's are left out and logged.
        /// </summary>
        /// <param name="p_Source">This engine's shaderdb resource.</param>
        /// <param name="p_Shaders">The shaders to convert, by key in the source.</param>
        /// <param name="p_Template">A shaderdb resource of the target's engine holding the templates.</param>
        /// <param name="p_MoveName">A texture's name as it is named in the target.</param>
        byte[] Convert(byte[] p_Source, IReadOnlyDictionary<uint, ConvertedShader> p_Shaders, byte[] p_Template, EngineType p_Target,
            Func<string, string> p_MoveName, TextWriter p_Log);

        /// <summary>
        /// A shader database of the target's engine holding each translated shader under its name: its template's
        /// solutions, states and vertex shaders, with the translated pixel shaders in the solutions they were made
        /// for, bound by the source solution's constants - its textures and parameters - and the template's engine
        /// functions. The template's other solutions keep its own pixel shaders.
        /// </summary>
        /// <param name="p_Source">This engine's shaderdb resource, holding the translated shaders.</param>
        /// <param name="p_Template">A shaderdb resource of the target's engine holding the templates.</param>
        /// <param name="p_MoreTemplates">
        /// The target's other shaderdb resources holding the templates: their solutions for states the first has none
        /// for are added too, each with the translation of the first's solution whose pixel shader is the same.
        /// </param>
        byte[] ConvertTranslated(byte[] p_Source, IReadOnlyList<TranslatedShader> p_Shaders, byte[] p_Template, EngineType p_Target,
            Func<string, string> p_MoveName, TextWriter p_Log, IReadOnlyList<byte[]>? p_MoreTemplates = null, Func<uint, bool>? p_Used = null);
    }
}
