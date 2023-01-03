using System;
using RimeLib.Frostbite;
using RimeLib.IO;
using System.Diagnostics.CodeAnalysis;
using fb;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;
using System.Collections.Generic;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

public class SurfaceShaderInfo
{
    public class StreamableTextureBase
    {
        public ShaderTextureCoordType CoordType { get; set; } = ShaderTextureCoordType.ShaderTextureCoordType_Unknown;
        public VertexElementUsage VertexUsage { get; set; } = VertexElementUsage.VertexElementUsage_Unknown;
        public float Factor { get; set; }
    }
    
    public class StreamableTexture : StreamableTextureBase
    {
        public string Name { get; set; } = string.Empty;

        public StreamableTexture()
        {
        }

        public StreamableTexture(RimeReader p_Reader)
        {
            Name = p_Reader.ReadNullTerminatedString();

            CoordType = (ShaderTextureCoordType)p_Reader.ReadUInt32();
            VertexUsage = (VertexElementUsage)p_Reader.ReadUInt32();
            Factor = p_Reader.ReadSingle();
        }
    }

    public class StreamableExternalTexture : StreamableTextureBase
    {
        public string ParameterName { get; set; } = string.Empty;
        public uint ParameterId { get; set; }

        public StreamableExternalTexture()
        {
        }

        public StreamableExternalTexture(RimeReader p_Reader)
        {
            ParameterName = p_Reader.ReadNullTerminatedString();
            ParameterId = p_Reader.ReadUInt32();

            CoordType = (ShaderTextureCoordType)p_Reader.ReadUInt32();
            VertexUsage = (VertexElementUsage)p_Reader.ReadUInt32();
            Factor = p_Reader.ReadSingle();
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

    public ShaderSolution[] Solutions { get; set; } = Array.Empty<ShaderSolution>();

    public Dictionary<ulong, ShaderSolution> SolutionMap { get; } = new();


    public uint NameHash { get; internal set; } = 0;

    public SurfaceShaderInfo()
    {
    }

    public SurfaceShaderInfo(RimeReader p_Reader, ShaderSolution[] p_Solutions, uint? p_NameHash = null)
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
        Solutions = new ShaderSolution[s_SolutionCount];

        for (var i = 0; i < s_SolutionCount; i++)
        {
            var s_Solution = p_Solutions[p_Reader.ReadUInt16()];

            Solutions[i] = s_Solution;
            SolutionMap.Add(s_Solution.StateHash, s_Solution);
        }

        if (p_NameHash != null)
            NameHash = (uint) p_NameHash;
    }


}