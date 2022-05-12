using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.ShaderConstants;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class ShaderConstant : IFbSerializable
{
    public TextureConstant[] Textures { get; set; } = Array.Empty<TextureConstant>();

    public ExternalValueConstant[] ExternalValues { get; set; } = Array.Empty<ExternalValueConstant>();
    public ExternalTextureConstant[] ExternalTextures { get; set; } = Array.Empty<ExternalTextureConstant>();

    public SamplerState[] Samplers { get; set; } = Array.Empty<SamplerState>();

    public ShaderConstant()
    {
    }

    public ShaderConstant(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_StartPosition = p_Reader.Position - 4; //4 bytes allready used...

        p_Reader.Seek(4, SeekOrigin.Current); //Pad

        var s_ValueConstantOffset = p_Reader.ReadUInt64();
        var s_TextureConstantOffset = p_Reader.ReadUInt64();

        var s_ExternalValueConstantOffset = p_Reader.ReadUInt64();
        var s_ExternalTextureConstantOffset = p_Reader.ReadUInt64();

        var s_SamplerStatesOffset = p_Reader.ReadUInt64();



        var s_ConstantCount = p_Reader.ReadUInt16();
        var s_ValueConstantsStart = p_Reader.ReadUInt16();


        var s_ValueConstantCount = p_Reader.ReadUByte();
        var s_TextureConstantCount = p_Reader.ReadUByte();
        var s_ExternalValueConstantCount = p_Reader.ReadUByte();
        var s_ExternalTextureConstantCount = p_Reader.ReadUByte();
        var s_SamplerStateCount = p_Reader.ReadUByte();


        if (s_ValueConstantCount > 0)
        {
            //TODO: Valueconstants is just a list of vector4s
            p_Reader.Seek(s_StartPosition + (long) s_ValueConstantOffset, SeekOrigin.Begin);
        }

        if (s_TextureConstantCount > 0)
        {
            p_Reader.Seek(s_StartPosition + (long) s_TextureConstantOffset, SeekOrigin.Begin);

            Textures = new TextureConstant[s_TextureConstantCount];

            for (var i = 0; i < s_TextureConstantCount; i++)
                Textures[i] = new TextureConstant(p_Reader);
        }

        if (s_ExternalValueConstantCount > 0)
        {
            p_Reader.Seek(s_StartPosition + (long) s_ExternalValueConstantOffset, SeekOrigin.Begin);

            ExternalValues = new ExternalValueConstant[s_ExternalValueConstantCount];

            for (var i = 0; i < s_ExternalValueConstantCount; i++)
                ExternalValues[i] = new ExternalValueConstant(p_Reader);
        }

        if (s_ExternalTextureConstantCount > 0)
        {
            p_Reader.Seek(s_StartPosition + (long) s_ExternalTextureConstantOffset, SeekOrigin.Begin);

            ExternalTextures = new ExternalTextureConstant[s_ExternalTextureConstantCount];

            for (var i = 0; i < s_ExternalTextureConstantCount; i++)
                ExternalTextures[i] = new ExternalTextureConstant(p_Reader);
        }

        if (s_SamplerStateCount > 0)
        {
            p_Reader.Seek(s_StartPosition + (long) s_SamplerStatesOffset, SeekOrigin.Begin);

            Samplers = new SamplerState[s_SamplerStateCount];

            for (var i = 0; i < s_SamplerStateCount; i++)
                Samplers[i] = new SamplerState(p_Reader);
        }
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