using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.IO;
using RimeLib.Shader.Pooled;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>The layout of a version 194 shader database.</summary>
public sealed class ShaderDatabaseFormat : PooledShaderDatabaseFormat
{
    public static ShaderDatabaseFormat Instance { get; } = new();

    private const int c_Constants = 0, c_ConstantFunctions = 1, c_TextureFunctions = 2;
    private const int c_VertexPermutations = 3, c_PixelPermutations = 4, c_GeometryPermutations = 5;
    private const int c_HullPermutations = 6, c_DomainPermutations = 7;

    public override uint Version => 194;

    // Version, render path, quality level.
    public override int HeaderSize => 12;

    public override int StateSize => 32;

    // Surface shader, vertex shader fragment, tessellation shader fragment, geometry declaration.
    public override int DeclarationHashOffset => 12;

    // 16 elements, 4 streams, element and stream count, padding.
    public override int DeclarationSize => 16 * 4 + 4 * 2 + 4;

    public override IReadOnlyList<(string Name, Func<RimeReader, PooledRecord> Read)> Pools { get; } =
    [
        // Size, then offsets and counts of the values, textures, external values and textures and sampler states.
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
        ("hull permutations", p_R => ReadPermutation(p_R, false)),
        ("domain permutations", p_R => ReadPermutation(p_R, false)),
        // State hash, flags, state; then the vertex, pixel, geometry, hull and domain permutation and the vertex and pixel constants.
        ("solutions", p_R => PooledRecord.Read(p_R, (p_Reader, p_Ref) =>
        {
            p_Reader.Seek(24, SeekOrigin.Current);
            foreach (var s_Pool in new[] { c_VertexPermutations, c_PixelPermutations, c_GeometryPermutations, c_HullPermutations, c_DomainPermutations, c_Constants, c_Constants })
                p_Ref(s_Pool, true);
        })),
    ];

    /// <summary>
    /// Guid, bytecode, constants and function indices; then for vertex shaders the input signature,
    /// its elements, their semantic names and a list of 4 byte entries; then a closing value.
    /// </summary>
    private static PooledRecord ReadPermutation(RimeReader p_Reader, bool p_Vertex) => PooledRecord.Read(p_Reader, (p_R, p_Ref) =>
    {
        p_R.Seek(16, SeekOrigin.Current);
        p_R.Seek(p_R.ReadUInt32(), SeekOrigin.Current);
        p_Ref(c_Constants, false);
        p_Ref(c_ConstantFunctions, false);
        p_Ref(c_TextureFunctions, false);

        if (p_Vertex)
        {
            p_R.Seek(p_R.ReadUInt32(), SeekOrigin.Current);
            p_R.Seek(p_R.ReadUInt32() * 24, SeekOrigin.Current);
            var s_Names = p_R.ReadUInt32();
            for (var i = 0; i < s_Names; i++)
                p_R.ReadNullTerminatedString();
            p_R.Seek(p_R.ReadUInt32() * 4, SeekOrigin.Current);
        }

        p_R.ReadUInt32();
    });

    /// <summary>Type and flags, then the streamable textures and external textures (by name hash).</summary>
    public override void SkipShaderInfo(RimeReader p_Reader)
    {
        p_Reader.Seek(4 + 36, SeekOrigin.Current);
        p_Reader.Seek(p_Reader.ReadUInt32() * 16, SeekOrigin.Current);
        p_Reader.Seek(p_Reader.ReadUInt32() * 20, SeekOrigin.Current);
    }
}
