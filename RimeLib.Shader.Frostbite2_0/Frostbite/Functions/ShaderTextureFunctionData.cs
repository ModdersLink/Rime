using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Diagnostics.CodeAnalysis;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite.Functions;

public class ShaderTextureFunctionData : IFbSerializable
{
    public class Texture : IFbSerializable
    {
        public ShaderConstantFunction Function { get; set; } = ShaderConstantFunction.ShaderConstantFunction_ViewMatrix;
        public ShaderValueType ValueType { get; set; } = ShaderValueType.ShaderValueType_None;
        public byte Index { get; set; }
        public byte Parameter { get; set; }

        public Texture()
        {

        }
        
        public Texture(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write((byte) Function);
            p_Writer.Write((byte) ValueType);
            p_Writer.Write(Index);
            p_Writer.Write(Parameter);

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            Function = (ShaderConstantFunction)p_Reader.ReadUByte();
            ValueType = (ShaderValueType)p_Reader.ReadUByte();
            Index = p_Reader.ReadUByte();
            Parameter = p_Reader.ReadUByte();
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

            
    };

    public Texture[] Textures { get; set; } = Array.Empty<Texture>();

    /// <summary>
    /// Default constructor
    /// </summary>
    public ShaderTextureFunctionData()
    {

    }

    /// <summary>
    /// TextureHeader Constructor
    /// This will read out the ITexture structure at an opened stream where the position is at a ITexture structure in the data
    /// </summary>
    /// <param name="p_Reader">Reference to an IceReader class</param>
    public ShaderTextureFunctionData(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write((uint) Textures.Length);

        for (var i = 0; i < Textures.Length; i++)
            Textures[i].Serialize(p_Writer);

        return true;
    }

    public void Deserialize(RimeReader p_Reader)
    {
        var s_TextureCount = p_Reader.ReadUInt32();

        Textures = new Texture[s_TextureCount];

        for (var i = 0; i < s_TextureCount; i++)
            Textures[i] = new Texture(p_Reader);
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