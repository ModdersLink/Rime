using System;
using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using fb;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class SurfaceShaderInfo : IFbSerializable
{

    public class StreamableTextureBase
    {
        public ShaderTextureCoordType CoordType { get; set; } = ShaderTextureCoordType.ShaderTextureCoordType_Unknown;
        public VertexElementUsage VertexUsage { get; set; } = VertexElementUsage.VertexElementUsage_Unknown;
        public float Factor { get; set; }
    }
    public class StreamableTexture : StreamableTextureBase, IFbSerializable
    {
        public string Name { get; set; } = string.Empty;

        public StreamableTexture()
        {
        }

        public StreamableTexture(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }
        public void Deserialize(RimeReader p_Reader)
        {
            Name = p_Reader.ReadNullTerminatedString();

            CoordType = (ShaderTextureCoordType)p_Reader.ReadUInt32();
            VertexUsage = (VertexElementUsage)p_Reader.ReadUInt32();
            Factor = p_Reader.ReadSingle();
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

    public class StreamableExternalTexture : StreamableTextureBase, IFbSerializable
    {
        public string ParameterName { get; set; } = string.Empty;
        public uint ParameterId { get; set; }

        public StreamableExternalTexture()
        {
        }

        public StreamableExternalTexture(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new System.NotImplementedException();
        }
        public void Deserialize(RimeReader p_Reader)
        {
            ParameterName = p_Reader.ReadNullTerminatedString();
            ParameterId = p_Reader.ReadUInt32();


            CoordType = (ShaderTextureCoordType)p_Reader.ReadUInt32();
            VertexUsage = (VertexElementUsage)p_Reader.ReadUInt32();
            Factor = p_Reader.ReadSingle();
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


    public SurfaceShaderType SurfaceShaderType { get; set; } = SurfaceShaderType.SurfaceShaderType_Opaque;

    public byte Flags { get; set; } = 0;
    public byte BoolParameterCount { get; set; } = 0;
    public byte BoolParameterDefaultMask { get; set; } = 0;
    public byte BoolParameterRequiredMask { get; set; } = 0;

    public uint[] BoolParameterIds { get; set; } = new uint[8];

    public StreamableTexture[] StreamableTextures { get; set; } = Array.Empty<StreamableTexture>();

    public StreamableExternalTexture[] StreamableExternalTextures { get; set; } = Array.Empty<StreamableExternalTexture>();


    public ushort[] SolutionIndices { get; set; } = Array.Empty<ushort>();


    public SurfaceShaderInfo()
    {
    }

    public SurfaceShaderInfo(RimeReader p_Reader)
    {
        Deserialize(p_Reader);
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        throw new System.NotImplementedException();
    }
    public void Deserialize(RimeReader p_Reader)
    {
        SurfaceShaderType = (SurfaceShaderType)p_Reader.ReadUInt32();

        Flags = p_Reader.ReadUByte();
        BoolParameterCount = p_Reader.ReadUByte();
        BoolParameterDefaultMask = p_Reader.ReadUByte();
        BoolParameterRequiredMask = p_Reader.ReadUByte();

        for (var i = 0; i < 8; i++)
            BoolParameterIds[i] = p_Reader.ReadUInt32();

        var s_StreamableTexturesCount = p_Reader.ReadUInt32();
        StreamableTextures = new StreamableTexture[s_StreamableTexturesCount];
        for (var i = 0; i < s_StreamableTexturesCount; i++)
            StreamableTextures[i] = new StreamableTexture(p_Reader);

        var s_StreamableExternalTexturesCount = p_Reader.ReadUInt32();
        StreamableExternalTextures = new StreamableExternalTexture[s_StreamableExternalTexturesCount];
        for (var i = 0; i < s_StreamableExternalTexturesCount; i++)
            StreamableExternalTextures[i] = new StreamableExternalTexture(p_Reader);

        var s_SolutionCount = p_Reader.ReadUInt32();
        SolutionIndices = new ushort[s_SolutionCount];
        for (var i = 0; i < s_SolutionCount; i++)
            SolutionIndices[i] = p_Reader.ReadUInt16();
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