using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Shaders;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>A hull shader: a <see cref="ShaderPermutation"/> with nothing of its own.</summary>
public class HullShaderPermutation : ShaderPermutation
{
}

/// <summary>A domain shader: a <see cref="ShaderPermutation"/> with nothing of its own.</summary>
public class DomainShaderPermutation : ShaderPermutation
{
}

/// <summary>
/// A version 194 vertex shader: BF3's, then a list of pairs of 16-bit values (in most entries the
/// two are equal). What they map is not known; they are kept as read.
/// </summary>
public class VertexShaderPermutation : Frostbite2_0.Frostbite.Shaders.VertexShaderPermutation
{
    public List<(ushort First, ushort Second)> ElementIndexPairs { get; set; } = new();

    protected override void DeserializeStage(RimeReader p_Reader)
    {
        base.DeserializeStage(p_Reader);

        var s_Count = p_Reader.ReadUInt32();
        ElementIndexPairs = new List<(ushort, ushort)>((int)s_Count);
        for (var i = 0; i < s_Count; i++)
            ElementIndexPairs.Add((p_Reader.ReadUInt16(), p_Reader.ReadUInt16()));
    }

    protected override void SerializeStage(RimeWriter p_Writer)
    {
        base.SerializeStage(p_Writer);

        p_Writer.Write((uint)ElementIndexPairs.Count);
        foreach (var (s_First, s_Second) in ElementIndexPairs)
        {
            p_Writer.Write(s_First);
            p_Writer.Write(s_Second);
        }
    }
}
