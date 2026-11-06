using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using fb;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Shader.Frostbite2_0.Frostbite.Solutions;

namespace RimeLib.Shader.Frostbite2_0.Frostbite;

/// <summary>
/// A shader's entry in the shader table: its key (the lowercase name hash of the shader asset), its
/// type, flags and bool parameters, the textures it streams, and the indices of its solutions.
/// The solutions are filled in by <see cref="ShaderDatabase"/> after reading.
/// </summary>
public class SurfaceShaderInfo : IFbSerializable
{
    /// <summary>What every streamed texture records after its name: how it is mapped, and its tiling.</summary>
    public abstract class StreamableTextureBase : IFbSerializable
    {
        public ShaderTextureCoordType CoordType { get; set; } = ShaderTextureCoordType.ShaderTextureCoordType_Unknown;
        public VertexElementUsage VertexUsage { get; set; } = VertexElementUsage.VertexElementUsage_Unknown;

        /// <summary>The engine's textureTilesPerCoord.</summary>
        public float Factor { get; set; }

        public abstract void Deserialize(RimeReader p_Reader);
        public abstract bool Serialize(RimeWriter p_Writer);

        protected void ReadMapping(RimeReader p_Reader)
        {
            CoordType = (ShaderTextureCoordType)p_Reader.ReadUInt32();
            VertexUsage = (VertexElementUsage)p_Reader.ReadUInt32();
            Factor = p_Reader.ReadSingle();
        }

        protected void WriteMapping(RimeWriter p_Writer)
        {
            p_Writer.Write((uint)CoordType);
            p_Writer.Write((uint)VertexUsage);
            p_Writer.Write(Factor);
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                Serialize(s_Writer);

            p_Data = s_Stream.ToArray();
            return true;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
            Deserialize(s_Reader);
        }
    }

    /// <summary>A texture the shader streams, by name.</summary>
    public class StreamableTexture : StreamableTextureBase
    {
        public string Name { get; set; } = string.Empty;

        public override void Deserialize(RimeReader p_Reader)
        {
            Name = p_Reader.ReadNullTerminatedString();
            ReadMapping(p_Reader);
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.WriteNullTerminatedString(Name);
            WriteMapping(p_Writer);
            return true;
        }
    }

    /// <summary>A texture the shader streams through a parameter, by the parameter's name and id.</summary>
    public class StreamableExternalTexture : StreamableTextureBase
    {
        public string ParameterName { get; set; } = string.Empty;
        public uint ParameterId { get; set; }

        public override void Deserialize(RimeReader p_Reader)
        {
            ParameterName = p_Reader.ReadNullTerminatedString();
            ParameterId = p_Reader.ReadUInt32();
            ReadMapping(p_Reader);
        }

        public override bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.WriteNullTerminatedString(ParameterName);
            p_Writer.Write(ParameterId);
            WriteMapping(p_Writer);
            return true;
        }
    }

    /// <summary>The lowercase name hash of the shader asset.</summary>
    public uint Key { get; set; }

    public SurfaceShaderType SurfaceShaderType { get; set; } = SurfaceShaderType.SurfaceShaderType_Opaque;

    public byte Flags { get; set; }
    public byte BoolParameterCount { get; set; }
    public byte BoolParameterDefaultMask { get; set; }
    public byte BoolParameterRequiredMask { get; set; }

    public uint[] BoolParameterIds { get; set; } = new uint[8];

    public StreamableTexture[] StreamableTextures { get; set; } = Array.Empty<StreamableTexture>();
    public StreamableExternalTexture[] StreamableExternalTextures { get; set; } = Array.Empty<StreamableExternalTexture>();

    public List<ushort> SolutionIndices { get; set; } = new();

    public ShaderSolution[] Solutions { get; set; } = Array.Empty<ShaderSolution>();
    public Dictionary<ulong, ShaderSolution> SolutionMap { get; } = new();

    /// <summary>The hash of the shader asset's name as written (not lowercased), once the name is known.</summary>
    public uint NameHash { get; internal set; }

    public void Deserialize(RimeReader p_Reader)
    {
        Key = p_Reader.ReadUInt32();
        SurfaceShaderType = (SurfaceShaderType)p_Reader.ReadUInt32();

        Flags = p_Reader.ReadUByte();
        BoolParameterCount = p_Reader.ReadUByte();
        BoolParameterDefaultMask = p_Reader.ReadUByte();
        BoolParameterRequiredMask = p_Reader.ReadUByte();

        for (var i = 0; i < BoolParameterIds.Length; i++)
            BoolParameterIds[i] = p_Reader.ReadUInt32();

        DeserializeTextures(p_Reader);

        var s_SolutionCount = p_Reader.ReadUInt32();
        SolutionIndices = new List<ushort>((int)s_SolutionCount);
        for (var i = 0; i < s_SolutionCount; i++)
            SolutionIndices.Add(p_Reader.ReadUInt16());
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        SerializeInfo(p_Writer);
        p_Writer.Write((uint)SolutionIndices.Count);
        foreach (var s_Index in SolutionIndices)
            p_Writer.Write(s_Index);
        return true;
    }

    /// <summary>Everything but the solutions: what two databases holding the shader should agree on.</summary>
    public void SerializeInfo(RimeWriter p_Writer)
    {
        p_Writer.Write(Key);
        p_Writer.Write((uint)SurfaceShaderType);

        p_Writer.Write(Flags);
        p_Writer.Write(BoolParameterCount);
        p_Writer.Write(BoolParameterDefaultMask);
        p_Writer.Write(BoolParameterRequiredMask);

        foreach (var s_Id in BoolParameterIds)
            p_Writer.Write(s_Id);

        SerializeTextures(p_Writer);
    }

    /// <summary>This engine's streamable texture records.</summary>
    protected virtual StreamableTexture CreateStreamableTexture() => new();
    protected virtual StreamableExternalTexture CreateStreamableExternalTexture() => new();

    /// <summary>The streamable and streamable external textures, each a count then the entries.</summary>
    private void DeserializeTextures(RimeReader p_Reader)
    {
        StreamableTextures = new StreamableTexture[p_Reader.ReadUInt32()];
        for (var i = 0; i < StreamableTextures.Length; i++)
        {
            StreamableTextures[i] = CreateStreamableTexture();
            StreamableTextures[i].Deserialize(p_Reader);
        }

        StreamableExternalTextures = new StreamableExternalTexture[p_Reader.ReadUInt32()];
        for (var i = 0; i < StreamableExternalTextures.Length; i++)
        {
            StreamableExternalTextures[i] = CreateStreamableExternalTexture();
            StreamableExternalTextures[i].Deserialize(p_Reader);
        }
    }

    private void SerializeTextures(RimeWriter p_Writer)
    {
        p_Writer.Write((uint)StreamableTextures.Length);
        foreach (var s_Texture in StreamableTextures)
            s_Texture.Serialize(p_Writer);

        p_Writer.Write((uint)StreamableExternalTextures.Length);
        foreach (var s_Texture in StreamableExternalTextures)
            s_Texture.Serialize(p_Writer);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            Serialize(s_Writer);

        p_Data = s_Stream.ToArray();
        return true;
    }

    public void Deserialize(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        Deserialize(s_Reader);
    }
}
