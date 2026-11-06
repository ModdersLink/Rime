using System.IO;
using fb;
using RimeLib.IO;

namespace RimeLib.Shader.Frostbite2013_2.Frostbite;

/// <summary>
/// A version 194 solution state, 32 bytes laid out as the engine's ShaderSolutionState: four name
/// hashes (BF3's three and the tessellation shader fragment's), a packed word, the outdoor light
/// state, the PS3 clip plane count, a packed byte, the multisample count, the quality level, the
/// bool permutation and three unused bytes. The engine declares the two packed fields as anonymous
/// unions, so they are kept whole.
/// </summary>
public class ShaderSolutionState : Frostbite2_0.Frostbite.Solutions.ShaderSolutionState
{
    public uint TessellationShaderFragmentNameHash { get; set; }
    public uint PackedState { get; set; }
    public byte PackedFlags { get; set; }
    public byte Quality { get; set; }

    public override void Deserialize(RimeReader p_Reader)
    {
        SurfaceShaderNameHash = p_Reader.ReadUInt32();
        VertexShaderFragmentNameHash = p_Reader.ReadUInt32();
        TessellationShaderFragmentNameHash = p_Reader.ReadUInt32();
        GeometryDeclarationHash = p_Reader.ReadUInt32();
        PackedState = p_Reader.ReadUInt32();

        OutdoorLightEnable = p_Reader.ReadBool();
        OutdoorLightShadowmapMethod = (ShaderShadowmapMethod)p_Reader.ReadUByte();
        OutdoorLightShadowmapQuality = (ShaderShadowmapQuality)p_Reader.ReadUByte();
        OutdoorLightTransparencyShadowmapEnable = p_Reader.ReadBool();

        Ps3ClipPlaneCount = p_Reader.ReadUByte();
        PackedFlags = p_Reader.ReadUByte();
        OutdoorLightMultisampleCount = p_Reader.ReadUByte();
        Quality = p_Reader.ReadUByte();
        BoolPermutation = p_Reader.ReadUByte();
        p_Reader.Seek(3, SeekOrigin.Current);
    }

    public override bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write(SurfaceShaderNameHash);
        p_Writer.Write(VertexShaderFragmentNameHash);
        p_Writer.Write(TessellationShaderFragmentNameHash);
        p_Writer.Write(GeometryDeclarationHash);
        p_Writer.Write(PackedState);

        p_Writer.Write(OutdoorLightEnable);
        p_Writer.Write((byte)OutdoorLightShadowmapMethod);
        p_Writer.Write((byte)OutdoorLightShadowmapQuality);
        p_Writer.Write(OutdoorLightTransparencyShadowmapEnable);

        p_Writer.Write(Ps3ClipPlaneCount);
        p_Writer.Write(PackedFlags);
        p_Writer.Write(OutdoorLightMultisampleCount);
        p_Writer.Write(Quality);
        p_Writer.Write(BoolPermutation);
        p_Writer.Write(new byte[3]);
        return true;
    }
}
