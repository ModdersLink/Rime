using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Mesh.Frostbite;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

public class ShaderSolutionState : IFbSerializable
{
    public uint SurfaceShaderNameHash { get; set; }
    public uint VertexShaderFragmentNameHash { get; set; }
    public uint GeometryDeclarationHash { get; set; }

    public GeometryDeclarationDesc GeometryDeclarationDesc { get; set; } = default!;

    public ShaderRenderMode Mode { get; set; } = ShaderRenderMode.ShaderRenderMode_Default;
    public ShaderGeometrySpace GeometrySpace { get; set; } = ShaderGeometrySpace.ShaderGeometrySpace_Object;
    public ShaderSkinningMethod SkinningMethod { get; set; } = ShaderSkinningMethod.ShaderSkinningMethod_None;
    public ShaderInstancingMethod InstancingMethod { get; set; } = ShaderInstancingMethod.ShaderInstancingMethod_None;
    public ShaderObjectLighting ObjectLighting { get; set; } = ShaderObjectLighting.ShaderObjectLighting_None;

    public byte ColorScale { get; set; }
    public byte Technique { get; set; }
    public byte BoolPermutation { get; set; }

    public byte Ps3ClipPlaneCount { get; set; }
    public byte HeightfieldTessellation { get; set; }

    public bool OutdoorLightEnable { get; set; }
    public ShaderShadowmapMethod OutdoorLightShadowmapMethod { get; set; } = ShaderShadowmapMethod.ShaderShadowmapMethod_None;
    public ShaderShadowmapQuality OutdoorLightShadowmapQuality { get; set; } = ShaderShadowmapQuality.ShaderShadowmapQuality_Pcf2x2;
    public bool OutdoorLightTransparencyShadowmapEnable { get; set; }

    public ShaderSolutionState(
        string p_SurfaceShaderName, 
        string p_VertexShaderFragmentName, 
        GeometryDeclarationDesc p_GeometryDeclarationDesc
    )
    {
        // TODO
        // GeometryDeclarationHash = Fletcher-32 of GeometryDeclarationDesc
    }

    public ShaderSolutionState(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        SurfaceShaderNameHash = p_Reader.ReadUInt32();
        VertexShaderFragmentNameHash = p_Reader.ReadUInt32();
        GeometryDeclarationHash = p_Reader.ReadUInt32();

        Mode = (ShaderRenderMode)p_Reader.ReadUByte();
        GeometrySpace = (ShaderGeometrySpace)p_Reader.ReadUByte();
        SkinningMethod = (ShaderSkinningMethod)p_Reader.ReadUByte();
        InstancingMethod = (ShaderInstancingMethod)p_Reader.ReadUByte();
        ObjectLighting = (ShaderObjectLighting)p_Reader.ReadUByte();

        ColorScale = p_Reader.ReadUByte();
        Technique = p_Reader.ReadUByte();
        BoolPermutation = p_Reader.ReadUByte();

        Ps3ClipPlaneCount = p_Reader.ReadUByte();
        HeightfieldTessellation = p_Reader.ReadUByte();

        OutdoorLightEnable = p_Reader.ReadBool();
        OutdoorLightShadowmapMethod = (ShaderShadowmapMethod)p_Reader.ReadUByte();
        OutdoorLightShadowmapQuality = (ShaderShadowmapQuality)p_Reader.ReadUByte();
        OutdoorLightTransparencyShadowmapEnable = p_Reader.ReadBool();

        p_Reader.Seek(0x6, System.IO.SeekOrigin.Current);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        p_Data = null;
        throw new System.NotImplementedException();
    }
        
    public void Deserialize(byte[] p_Data)
    {
        throw new System.NotImplementedException();
    }

}