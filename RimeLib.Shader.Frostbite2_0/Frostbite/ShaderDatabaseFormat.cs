using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.IO;
using RimeLib.Shader.Pooled;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>The layout of a version 182 shader database.</summary>
public sealed class ShaderDatabaseFormat : PooledShaderDatabaseFormat
{
    public static ShaderDatabaseFormat Instance { get; } = new();

    private const int c_Constants = 0, c_ConstantFunctions = 1, c_TextureFunctions = 2;
    private const int c_VertexPermutations = 3, c_PixelPermutations = 4, c_GeometryPermutations = 5;

    public override uint Version => 182;

    // Version, render path.
    public override int HeaderSize => 8;

    public override int StateSize => 32;

    // Surface shader, vertex shader fragment, geometry declaration.
    public override int DeclarationHashOffset => 8;

    // 16 elements, 4 streams, element and stream count, padding.
    public override int DeclarationSize => 16 * 4 + 4 * 2 + 4;

    public override IReadOnlyList<(string Name, Func<RimeReader, PooledRecord> Read)> Pools { get; } =
    [
        ("constants", p_R => PooledRecord.Read(p_R, (p_Reader, _) => p_Reader.Seek(p_Reader.ReadUInt32() - 4, SeekOrigin.Current))),
        ("constant functions", p_R => PooledRecord.Read(p_R, (p_Reader, _) =>
        {
            var s_Constants = p_Reader.ReadUInt16();
            p_Reader.ReadUInt16();
            p_Reader.Seek(s_Constants * 8, SeekOrigin.Current);
        })),
        ("texture functions", p_R => PooledRecord.Read(p_R, (p_Reader, _) => p_Reader.Seek(p_Reader.ReadUInt32() * 4, SeekOrigin.Current))),
        ("vertex permutations", p_R => ReadPermutation(p_R, true)),
        ("pixel permutations", p_R => ReadPermutation(p_R, false)),
        ("geometry permutations", p_R => PooledRecord.Read(p_R, (p_Reader, _) =>
        {
            p_Reader.Seek(16, SeekOrigin.Current);
            p_Reader.Seek(p_Reader.ReadUInt32() + 4, SeekOrigin.Current);
        })),
        // State hash, flags, state; then the vertex, pixel and geometry permutation and the vertex and pixel constants.
        ("solutions", p_R => PooledRecord.Read(p_R, (p_Reader, p_Ref) =>
        {
            p_Reader.Seek(24, SeekOrigin.Current);
            foreach (var s_Pool in new[] { c_VertexPermutations, c_PixelPermutations, c_GeometryPermutations, c_Constants, c_Constants })
                p_Ref(s_Pool, true);
        })),
    ];

    /// <summary>Guid, bytecode, constants and function indices, then for vertex shaders the input signature and elements, and the instruction count.</summary>
    private static PooledRecord ReadPermutation(RimeReader p_Reader, bool p_Vertex) => PooledRecord.Read(p_Reader, (p_R, p_Ref) =>
    {
        p_R.Seek(16, SeekOrigin.Current);
        p_R.Seek(p_R.ReadUInt32(), SeekOrigin.Current);
        p_Ref(c_Constants, false);
        p_Ref(c_ConstantFunctions, false);
        p_Ref(c_TextureFunctions, false);

        if (p_Vertex)
        {
            p_R.Seek(p_R.ReadInt32(), SeekOrigin.Current);
            p_R.Seek(p_R.ReadUInt32() * 24, SeekOrigin.Current);
            var s_Names = p_R.ReadUInt32();
            for (var i = 0; i < s_Names; i++)
                p_R.ReadNullTerminatedString();
        }

        p_R.ReadUInt32();
    });

    /// <summary>Type, flags, bool parameters, then the streamable textures and external textures with their names.</summary>
    public override void SkipShaderInfo(RimeReader p_Reader)
    {
        p_Reader.Seek(4 + 4 + 8 * 4, SeekOrigin.Current);

        var s_Textures = p_Reader.ReadUInt32();
        for (var t = 0; t < s_Textures; t++)
        {
            p_Reader.ReadNullTerminatedString();
            p_Reader.Seek(12, SeekOrigin.Current);
        }

        var s_External = p_Reader.ReadUInt32();
        for (var t = 0; t < s_External; t++)
        {
            p_Reader.ReadNullTerminatedString();
            p_Reader.Seek(16, SeekOrigin.Current);
        }
    }
}
