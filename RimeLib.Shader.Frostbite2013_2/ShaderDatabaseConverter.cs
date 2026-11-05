using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using fb;
using RimeLib.Frostbite;
using RimeLib.Shader.Frostbite2013_2.Frostbite;
using BaseContainer = RimeLib.Shader.Frostbite2_0.Frostbite.ShaderDatabaseContainer;
using BaseDatabase = RimeLib.Shader.Frostbite2_0.Frostbite.ShaderDatabase;
using BaseInfo = RimeLib.Shader.Frostbite2_0.Frostbite.SurfaceShaderInfo;
using BaseSolution = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolution;
using BaseState = RimeLib.Shader.Frostbite2_0.Frostbite.Solutions.ShaderSolutionState;
using BaseVertex = RimeLib.Shader.Frostbite2_0.Frostbite.Shaders.VertexShaderPermutation;
using PixelPermutation = RimeLib.Shader.Frostbite2_0.Frostbite.Shaders.PixelShaderPermutation;
using Permutation = RimeLib.Shader.Frostbite2_0.Frostbite.Shaders.ShaderPermutation;
using ShaderConstant = RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstant;
using ConstantFunctions = RimeLib.Shader.Frostbite2_0.Frostbite.Functions.ShaderConstantFunctionData;
using TextureFunctions = RimeLib.Shader.Frostbite2_0.Frostbite.Functions.ShaderTextureFunctionData;

namespace RimeLib.Shader.Frostbite2013_2;

/// <summary>
/// Version 194 shaders as Frostbite 2's (version 182). The bytecode is the same shader model in
/// both, so permutations keep it with their constants; the stages Frostbite 2 lacks (hull and
/// domain) are left out with the solutions using them. Frostbite 2 finds a solution by the hash of
/// the state it draws in, which this engine packs differently, so each solution takes the state of
/// its template's solution in the same role, named after the converted shader.
/// </summary>
public class ShaderDatabaseConverter : IShaderDatabaseConverter
{
    /// <summary>Constant functions whose value moved in the enumeration; those up to 38 are the same in both.</summary>
    private static readonly Dictionary<uint, uint> s_Functions = new()
    {
        [40] = 39, [41] = 40, [42] = 41, [43] = 42, [45] = 43, [49] = 45, [50] = 46, [51] = 47, [52] = 48, [55] = 51,
    };

    private const uint c_LastSharedFunction = 38;

    /// <summary>External values Frostbite 2 names otherwise.</summary>
    private static readonly Dictionary<string, string> s_ExternalValues = new(StringComparer.Ordinal)
    {
        ["worldToEnlightenUvTransform"] = "enlightenUvTransform",
        ["worldToEnlightenUvTranslation"] = "enlightenUvTranslation",
    };

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public byte[] Convert(byte[] p_Source, IReadOnlyDictionary<uint, ConvertedShader> p_Shaders, byte[] p_Template, EngineType p_Target,
        Func<string, string> p_MoveName, TextWriter p_Log)
    {
        if (p_Target != EngineType.Frostbite2_0)
            throw new NotSupportedException($"shaders are converted to Frostbite 2 only, not {p_Target}");

        var s_Source = new ShaderDatabaseContainer();
        s_Source.Deserialize(p_Source);
        var s_Template = new BaseContainer();
        s_Template.Deserialize(p_Template);

        var s_Result = new BaseContainer();
        foreach (var (s_Path, s_From) in s_Source.Databases)
        {
            if (!s_Template.Databases.TryGetValue(s_Path, out var s_Templates))
            {
                p_Log.WriteLine($"render path {s_Path}: the template has none; left out.");
                continue;
            }

            var s_Into = new BaseDatabase { RenderPath = s_Path };
            var s_Writer = new Writer((ShaderDatabase)s_From, s_Into, p_MoveName, p_Log);
            foreach (var s_Info in s_From.ShaderInfos)
            {
                if (!p_Shaders.TryGetValue(s_Info.Key, out var s_Shader))
                    continue;

                var s_TemplateInfo = s_Templates.ShaderInfos.FirstOrDefault(p_I => p_I.Key == s_Shader.TemplateKey);
                if (s_TemplateInfo == null)
                {
                    p_Log.WriteLine($"  {s_Shader.Name} ({s_Path}): the template database has no shader 0x{s_Shader.TemplateKey:X8}; left out.");
                    continue;
                }

                s_Writer.Add(s_Info, s_TemplateInfo, s_Shader.Name);
            }

            s_Into.ShaderInfos = s_Into.ShaderInfos.OrderBy(p_I => p_I.Key).ToList();
            s_Into.Resolve();
            s_Result.Databases.Add(s_Path, s_Into);
            p_Log.WriteLine($"render path {s_Path}: {s_Into.ShaderInfos.Count} shader(s), {s_Into.Solutions.Count} solution(s) converted.");
        }

        return s_Result.Serialize(out var s_Data) ? s_Data : [];
    }

    /// <summary>Writes converted shaders of one source render path into a Frostbite 2 database.</summary>
    private sealed class Writer
    {
        private readonly ShaderDatabase m_From;
        private readonly BaseDatabase m_Into;
        private readonly Func<string, string> m_MoveName;
        private readonly TextWriter m_Log;
        private readonly HashSet<uint> m_Declarations = new();

        public Writer(ShaderDatabase p_From, BaseDatabase p_Into, Func<string, string> p_MoveName, TextWriter p_Log)
        {
            m_From = p_From;
            m_Into = p_Into;
            m_MoveName = p_MoveName;
            m_Log = p_Log;
        }

        /// <summary>The shader, its solutions paired with the template's in order, or nothing where they do not pair.</summary>
        public void Add(BaseInfo p_Info, BaseInfo p_Template, string p_Name)
        {
            var s_Path = m_From.RenderPath;
            var s_Untessellated = p_Info.Solutions.Cast<ShaderSolution>()
                .Where(p_S => p_S.HullPermutation == null && p_S.DomainPermutation == null).ToList();

            // A role is known only where each side has one solution: a 2d terrain shader's.
            if (s_Untessellated.Count != 1 || p_Template.Solutions.Length != 1)
            {
                m_Log.WriteLine($"  {p_Name} ({s_Path}): {s_Untessellated.Count} solution(s) without tessellation, the template {p_Template.Solutions.Length}; " +
                    "solutions are paired only one to one, left out.");
                return;
            }

            var s_Key = RimeLib.Frostbite.Utils.HashQuickLowerCase(p_Name);
            var s_Solutions = new List<ushort>();
            foreach (var (s_Solution, s_TemplateSolution) in s_Untessellated.Zip(p_Template.Solutions))
            {
                if (Solution(s_Solution, s_TemplateSolution, s_Key, p_Name) is { } s_Index)
                    s_Solutions.Add(s_Index);
            }

            if (s_Solutions.Count == 0)
                return;

            var s_Info = new BaseInfo
            {
                Key = s_Key,
                SurfaceShaderType = p_Template.SurfaceShaderType,
                Flags = p_Info.Flags,
                BoolParameterCount = p_Info.BoolParameterCount,
                BoolParameterDefaultMask = p_Info.BoolParameterDefaultMask,
                BoolParameterRequiredMask = p_Info.BoolParameterRequiredMask,
                BoolParameterIds = (uint[])p_Info.BoolParameterIds.Clone(),
                StreamableTextures = StreamableTextures(p_Info, p_Name),
                StreamableExternalTextures = StreamableExternalTextures(p_Info, p_Name),
                SolutionIndices = s_Solutions,
            };
            m_Into.ShaderInfos.Add(s_Info);
        }

        /// <summary>The solution's index in the target, drawn in the template solution's state; null where it uses what the target lacks.</summary>
        private ushort? Solution(ShaderSolution p_Solution, BaseSolution p_Template, uint p_Key, string p_Name)
        {
            if (p_Solution.GeometryPermutation != null)
            {
                m_Log.WriteLine($"  {p_Name}: a solution with a geometry shader; left out.");
                return null;
            }

            var s_Vertex = p_Solution.VertexPermutation == null ? null : Vertex((VertexShaderPermutation)p_Solution.VertexPermutation, p_Name);
            var s_Pixel = p_Solution.PixelPermutation == null ? null : Pixel(p_Solution.PixelPermutation, p_Name);
            if ((p_Solution.VertexPermutation != null && s_Vertex == null) || (p_Solution.PixelPermutation != null && s_Pixel == null))
                return null;

            var s_State = BaseDatabase.Clone(p_Template.State);
            s_State.SurfaceShaderNameHash = p_Key;
            s_State.BoolPermutation = p_Solution.State.BoolPermutation;
            if (s_State.GeometryDeclarationHash != p_Solution.State.GeometryDeclarationHash)
            {
                m_Log.WriteLine($"  {p_Name}: geometry declaration 0x{p_Solution.State.GeometryDeclarationHash:X8}, the template's 0x{s_State.GeometryDeclarationHash:X8}; left out.");
                return null;
            }

            if (m_Declarations.Add(s_State.GeometryDeclarationHash))
                m_Into.Declarations.AddRange(m_From.Declarations.Where(p_D => p_D.Hash == s_State.GeometryDeclarationHash).Select(BaseDatabase.Clone));

            var s_Converted = new BaseSolution
            {
                StateHash = s_State.Hash,
                Flags = p_Template.Flags,
                SurfaceType = p_Template.SurfaceType,
                BlendMode = p_Template.BlendMode,
                AlphaRef = p_Template.AlphaRef,
                VertexPermutationIndex = s_Vertex ?? -1,
                PixelPermutationIndex = s_Pixel ?? -1,
                VertexConstantsIndex = Constant(p_Solution.VertexConstants),
                PixelConstantsIndex = Constant(p_Solution.PixelConstants),
                State = s_State,
            };

            if (m_Into.Solutions.Count > ushort.MaxValue)
                throw new InvalidOperationException("More solutions than a shader database can index.");
            m_Into.Solutions.Add(s_Converted);
            return (ushort)(m_Into.Solutions.Count - 1);
        }

        private long? Vertex(VertexShaderPermutation p_Permutation, string p_Name)
        {
            var s_Vertex = new BaseVertex
            {
                InputSignatureBytecode = p_Permutation.InputSignatureBytecode,
                Elements = p_Permutation.Elements,
            };
            if (!Fill(s_Vertex, p_Permutation, p_Name))
                return null;

            m_Into.VertexPermutations.Add(s_Vertex);
            return m_Into.VertexPermutations.Count - 1;
        }

        private long? Pixel(Permutation p_Permutation, string p_Name)
        {
            var s_Pixel = new PixelPermutation();
            if (!Fill(s_Pixel, p_Permutation, p_Name))
                return null;

            m_Into.PixelPermutations.Add(s_Pixel);
            return m_Into.PixelPermutations.Count - 1;
        }

        /// <summary>Gives the permutation the source's bytecode and copies of its blocks; false where a function has no counterpart.</summary>
        private bool Fill(Permutation p_Into, Permutation p_From, string p_Name)
        {
            var s_Functions = BaseDatabase.Clone(p_From.ConstantFunction);
            foreach (var s_Function in s_Functions.Constants)
            {
                if (Function(s_Function.Function) is not { } s_Mapped)
                {
                    m_Log.WriteLine($"  {p_Name}: constant function {(uint)s_Function.Function} has no Frostbite 2 counterpart; solution left out.");
                    return false;
                }

                s_Function.Function = s_Mapped;
            }

            var s_Textures = BaseDatabase.Clone(p_From.TextureFunction);
            foreach (var s_Texture in s_Textures.Textures)
            {
                if (Function(s_Texture.Function) is not { } s_Mapped)
                {
                    m_Log.WriteLine($"  {p_Name}: texture function {(uint)s_Texture.Function} has no Frostbite 2 counterpart; solution left out.");
                    return false;
                }

                s_Texture.Function = s_Mapped;
            }

            p_Into.Guid = p_From.Guid;
            p_Into.ShaderBytecode = p_From.ShaderBytecode;
            p_Into.InstructionCount = p_From.InstructionCount;
            p_Into.ConstantIndex = (int)Constant(p_From.Constant);
            m_Into.ConstantFunctions.Add(s_Functions);
            p_Into.ConstantFunctionIndex = m_Into.ConstantFunctions.Count - 1;
            m_Into.TextureFunctions.Add(s_Textures);
            p_Into.TextureFunctionIndex = m_Into.TextureFunctions.Count - 1;
            return true;
        }

        private static ShaderConstantFunction? Function(ShaderConstantFunction p_Function)
        {
            var s_Value = (uint)p_Function;
            if (s_Value <= c_LastSharedFunction)
                return p_Function;
            return s_Functions.TryGetValue(s_Value, out var s_Mapped) ? (ShaderConstantFunction)s_Mapped : null;
        }

        /// <summary>A copy of the block in the target, its textures named as there without a hash (Frostbite 2 stores none), -1 for none.</summary>
        private long Constant(ShaderConstant? p_Constant)
        {
            if (p_Constant == null)
                return -1;

            var s_Constant = BaseDatabase.Clone(p_Constant);
            foreach (var s_Texture in s_Constant.Textures)
            {
                s_Texture.Name = m_MoveName(s_Texture.Name);
                s_Texture.NameHash = 0;
            }

            foreach (var s_Value in s_Constant.ExternalValues)
            {
                if (s_ExternalValues.TryGetValue(s_Value.Name, out var s_Name))
                    s_Value.Name = s_Name;
            }

            m_Into.Constants.Add(s_Constant);
            return m_Into.Constants.Count - 1;
        }

        /// <summary>
        /// The streamed textures by name: the source keeps the lowercase hash of the name, which the
        /// textures of the shader's constants carry with their names. Those named by none are left out.
        /// </summary>
        private BaseInfo.StreamableTexture[] StreamableTextures(BaseInfo p_Info, string p_Name)
        {
            var s_Names = p_Info.Solutions.SelectMany(p_S => new[] { p_S.VertexConstants, p_S.PixelConstants })
                .Where(p_C => p_C != null).SelectMany(p_C => p_C!.Textures)
                .GroupBy(p_T => p_T.NameHash).ToDictionary(p_G => p_G.Key, p_G => p_G.First().Name);

            var s_Result = new List<BaseInfo.StreamableTexture>();
            foreach (var s_Texture in p_Info.StreamableTextures.Cast<SurfaceShaderInfo.HashedStreamableTexture>())
            {
                if (!s_Names.TryGetValue(s_Texture.NameHash, out var s_Name))
                {
                    m_Log.WriteLine($"  {p_Name}: streamed texture 0x{s_Texture.NameHash:X8} is no texture of its constants; left out.");
                    continue;
                }

                s_Result.Add(new BaseInfo.StreamableTexture
                {
                    Name = m_MoveName(s_Name), CoordType = s_Texture.CoordType, VertexUsage = s_Texture.VertexUsage, Factor = s_Texture.Factor,
                });
            }

            return s_Result.ToArray();
        }

        /// <summary>
        /// The textures streamed through parameters, by the name of an external texture of the
        /// shader's constants whose hash the source keeps; those named by no such texture left out.
        /// </summary>
        private BaseInfo.StreamableExternalTexture[] StreamableExternalTextures(BaseInfo p_Info, string p_Name)
        {
            var s_Parameters = p_Info.Solutions.SelectMany(p_S => new[] { p_S.VertexConstants, p_S.PixelConstants })
                .Where(p_C => p_C != null).SelectMany(p_C => p_C!.ExternalTextures).Select(p_T => p_T.Name).Distinct()
                .SelectMany(p_N => new[] { (Hash: RimeLib.Frostbite.Utils.HashQuick(p_N), Name: p_N), (Hash: RimeLib.Frostbite.Utils.HashQuickLowerCase(p_N), Name: p_N) })
                .GroupBy(p_P => p_P.Hash).ToDictionary(p_G => p_G.Key, p_G => p_G.First().Name);

            var s_Result = new List<BaseInfo.StreamableExternalTexture>();
            foreach (var s_Texture in p_Info.StreamableExternalTextures.Cast<SurfaceShaderInfo.HashedStreamableExternalTexture>())
            {
                if (!s_Parameters.TryGetValue(s_Texture.ParameterNameHash, out var s_Parameter))
                {
                    m_Log.WriteLine($"  {p_Name}: streamed parameter texture 0x{s_Texture.ParameterNameHash:X8} names no external texture; left out.");
                    continue;
                }

                s_Result.Add(new BaseInfo.StreamableExternalTexture
                {
                    ParameterName = s_Parameter, ParameterId = s_Texture.ParameterId,
                    CoordType = s_Texture.CoordType, VertexUsage = s_Texture.VertexUsage, Factor = s_Texture.Factor,
                });
            }

            return s_Result.ToArray();
        }
    }
}
