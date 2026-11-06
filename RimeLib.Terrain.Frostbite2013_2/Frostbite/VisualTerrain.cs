using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// One mesh scattering type of a terrain layer (the engine's MeshScatteringTypeBase), in stream
/// order. A later engine version reads the same fields in the same order where both have them.
/// </summary>
public class MeshScatteringType : IFbSerializable
{
    public string MeshName { get; set; } = string.Empty;

    /// <summary>The mesh resource's id.</summary>
    public ulong MeshResourceId { get; set; }

    /// <summary>0 for the mesh's own look.</summary>
    public uint VariationAssetNameHash { get; set; }

    /// <summary>Counts up across the whole resource.</summary>
    public uint Identifier { get; set; }

    /// <summary>A QualityScalableFloat: low, medium, high, ultra.</summary>
    public float[] Density { get; set; } = new float[4];

    public float RandomPositionOffset { get; set; }
    public float MinMask { get; set; }
    public float MaxMask { get; set; }
    public float MinScaleX { get; set; }
    public float MinScaleY { get; set; }
    public float MaxScaleX { get; set; }
    public float MaxScaleY { get; set; }
    public float MinMaskScaleFactorX { get; set; }
    public float MinMaskScaleFactorY { get; set; }
    public float ScaleRandomness { get; set; }
    public float WindScale { get; set; }
    public float Stiffness { get; set; }
    public float Damping { get; set; }
    public float Mass { get; set; }
    public float WindWiggle { get; set; }
    public sbyte LastLodAndBillboard { get; set; }
    public bool Enabled { get; set; }

    /// <summary>Three flags; castShadowsEnable is one of them, which one is not established.</summary>
    public byte[] Flags { get; set; } = new byte[3];

    /// <summary>Per lod level.</summary>
    public uint[] SpawnLevelCounts { get; set; } = new uint[4];

    public float ShadowViewDistance { get; set; }

    /// <summary>Per lod level.</summary>
    public float[] LodDistances { get; set; } = new float[4];

    public uint TextureAtlasSizeX { get; set; }
    public uint TextureAtlasSizeY { get; set; }

    /// <summary>One per atlas tile, present when the atlas has more than one tile.</summary>
    public uint[] TextureAtlasCumulativeTileWeights { get; set; } = [];

    /// <summary>Present when the atlas has more than one tile.</summary>
    public uint TextureAtlasCumulativeTileWeightMax { get; set; }

    public byte FirstSpawnLevel { get; set; }
    public byte RotationMode { get; set; }
    public byte OrientationMode { get; set; }
    public float RotateTowardsSlopeRandomWeight { get; set; }
    public bool BillboardingEnable { get; set; }

    /// <summary>MeshScatteringInstanceDataMode: none, normal, normal and atlas index, normal and colour, wind and atlas index, wind.</summary>
    public byte InstanceDataMode { get; set; }

    public bool GroundClampBoundingBoxEnable { get; set; }

    private uint TileCount => TextureAtlasSizeX * TextureAtlasSizeY;

    public void Deserialize(RimeReader p_Reader)
    {
        MeshName = p_Reader.ReadNullTerminatedString();
        MeshResourceId = p_Reader.ReadUInt64();
        VariationAssetNameHash = p_Reader.ReadUInt32();
        Identifier = p_Reader.ReadUInt32();

        for (var i = 0; i < 4; ++i)
            Density[i] = p_Reader.ReadSingle();

        RandomPositionOffset = p_Reader.ReadSingle();
        MinMask = p_Reader.ReadSingle();
        MaxMask = p_Reader.ReadSingle();
        MinScaleX = p_Reader.ReadSingle();
        MinScaleY = p_Reader.ReadSingle();
        MaxScaleX = p_Reader.ReadSingle();
        MaxScaleY = p_Reader.ReadSingle();
        MinMaskScaleFactorX = p_Reader.ReadSingle();
        MinMaskScaleFactorY = p_Reader.ReadSingle();
        ScaleRandomness = p_Reader.ReadSingle();
        WindScale = p_Reader.ReadSingle();
        Stiffness = p_Reader.ReadSingle();
        Damping = p_Reader.ReadSingle();
        Mass = p_Reader.ReadSingle();
        WindWiggle = p_Reader.ReadSingle();
        LastLodAndBillboard = p_Reader.ReadSByte();
        Enabled = p_Reader.ReadBool();
        Flags = p_Reader.ReadBytes(3);

        for (var i = 0; i < 4; ++i)
            SpawnLevelCounts[i] = p_Reader.ReadUInt32();
        ShadowViewDistance = p_Reader.ReadSingle();
        for (var i = 0; i < 4; ++i)
            LodDistances[i] = p_Reader.ReadSingle();

        TextureAtlasSizeX = p_Reader.ReadUInt32();
        TextureAtlasSizeY = p_Reader.ReadUInt32();
        if (TileCount > 1)
        {
            if (TileCount > 0xFFFF)
                throw new InvalidDataException($"A scattering texture atlas of {TextureAtlasSizeX}x{TextureAtlasSizeY} tiles; the walk is misaligned.");

            TextureAtlasCumulativeTileWeights = new uint[TileCount];
            for (var i = 0; i < TileCount; ++i)
                TextureAtlasCumulativeTileWeights[i] = p_Reader.ReadUInt32();
            TextureAtlasCumulativeTileWeightMax = p_Reader.ReadUInt32();
        }

        FirstSpawnLevel = p_Reader.ReadUByte();
        RotationMode = p_Reader.ReadUByte();
        OrientationMode = p_Reader.ReadUByte();
        RotateTowardsSlopeRandomWeight = p_Reader.ReadSingle();
        BillboardingEnable = p_Reader.ReadBool();
        InstanceDataMode = p_Reader.ReadUByte();
        GroundClampBoundingBoxEnable = p_Reader.ReadBool();
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        var s_Weights = TileCount > 1 ? (int)TileCount : 0;
        if (TextureAtlasCumulativeTileWeights.Length != s_Weights)
            throw new InvalidDataException($"A {TextureAtlasSizeX}x{TextureAtlasSizeY} texture atlas takes {s_Weights} tile weights, not {TextureAtlasCumulativeTileWeights.Length}.");

        p_Writer.WriteNullTerminatedString(MeshName);
        p_Writer.Write(MeshResourceId);
        p_Writer.Write(VariationAssetNameHash);
        p_Writer.Write(Identifier);
        foreach (var s_Value in Density)
            p_Writer.Write(s_Value);
        p_Writer.Write(RandomPositionOffset);
        p_Writer.Write(MinMask);
        p_Writer.Write(MaxMask);
        p_Writer.Write(MinScaleX);
        p_Writer.Write(MinScaleY);
        p_Writer.Write(MaxScaleX);
        p_Writer.Write(MaxScaleY);
        p_Writer.Write(MinMaskScaleFactorX);
        p_Writer.Write(MinMaskScaleFactorY);
        p_Writer.Write(ScaleRandomness);
        p_Writer.Write(WindScale);
        p_Writer.Write(Stiffness);
        p_Writer.Write(Damping);
        p_Writer.Write(Mass);
        p_Writer.Write(WindWiggle);
        p_Writer.Write(LastLodAndBillboard);
        p_Writer.Write(Enabled);
        p_Writer.Write(Flags);
        foreach (var s_Value in SpawnLevelCounts)
            p_Writer.Write(s_Value);
        p_Writer.Write(ShadowViewDistance);
        foreach (var s_Value in LodDistances)
            p_Writer.Write(s_Value);
        p_Writer.Write(TextureAtlasSizeX);
        p_Writer.Write(TextureAtlasSizeY);
        if (s_Weights > 0)
        {
            foreach (var s_Value in TextureAtlasCumulativeTileWeights)
                p_Writer.Write(s_Value);
            p_Writer.Write(TextureAtlasCumulativeTileWeightMax);
        }

        p_Writer.Write(FirstSpawnLevel);
        p_Writer.Write(RotationMode);
        p_Writer.Write(OrientationMode);
        p_Writer.Write(RotateTowardsSlopeRandomWeight);
        p_Writer.Write(BillboardingEnable);
        p_Writer.Write(InstanceDataMode);
        p_Writer.Write(GroundClampBoundingBoxEnable);
        return true;
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

/// <summary>A terrain layer's scattering: a count, then the scattering types.</summary>
public class VisualTerrainLayer : IFbSerializable
{
    public MeshScatteringType[] ScatteringTypes { get; set; } = [];

    public void Deserialize(RimeReader p_Reader)
    {
        ScatteringTypes = new MeshScatteringType[p_Reader.ReadUInt32()];
        for (var i = 0; i < ScatteringTypes.Length; ++i)
        {
            ScatteringTypes[i] = new MeshScatteringType();
            ScatteringTypes[i].Deserialize(p_Reader);
        }
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.Write((uint)ScatteringTypes.Length);
        foreach (var s_Type in ScatteringTypes)
            s_Type.Serialize(p_Writer);
        return true;
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

/// <summary>
/// A VisualTerrain resource: the mesh scattering, patch and texture settings, and the scattering of
/// each terrain layer. Unlike Frostbite 2 it names no surface shader, streaming tree or decals
/// (EBX references those by id) and holds no layer combination draws (those are their own
/// resource, <see cref="TerrainLayerCombinations"/>).
/// </summary>
public class VisualTerrain : IFbSerializable
{
    /// <summary>A QualityScalableFloat: low, medium, high, ultra.</summary>
    public float[] MeshScatteringScaleFactors { get; set; } = new float[4];

    public float MeshScatteringCellFov { get; set; }
    public uint MeshScatteringCellMaskSamplesPerSide { get; set; }
    public uint MeshScatteringInstancePoolSize { get; set; }
    public uint MeshScatteringInstanceDrawBufferSize { get; set; }
    public int MeshScatteringVirtualTextureBlurriness { get; set; }
    public float ResourcePatchFov { get; set; }
    public float ResourceLodScale { get; set; }
    public float ResourceTriangleSizeMin { get; set; }
    public uint TextureAtlasSampleCountX { get; set; }
    public uint TextureAtlasSampleCountY { get; set; }
    public float TextureSamplesPerMeterMax { get; set; }
    public float TextureDetailFalloffCurve { get; set; }
    public float TextureDetailFalloffDistance { get; set; }
    public float TextureDetailFalloffFactor { get; set; }
    public float TextureInvisibleDetailReductionFactor { get; set; }
    public float TextureOccludedDetailReductionFactor { get; set; }

    /// <summary>-1 for none.</summary>
    public int VirtualTextureDisableTerrainLayerIndex { get; set; }

    public VisualTerrainLayer[] Layers { get; set; } = [];

    public void Deserialize(RimeReader p_Reader)
    {
        for (var i = 0; i < MeshScatteringScaleFactors.Length; ++i)
            MeshScatteringScaleFactors[i] = p_Reader.ReadSingle();
        MeshScatteringCellFov = p_Reader.ReadSingle();
        MeshScatteringCellMaskSamplesPerSide = p_Reader.ReadUInt32();
        MeshScatteringInstancePoolSize = p_Reader.ReadUInt32();
        MeshScatteringInstanceDrawBufferSize = p_Reader.ReadUInt32();
        MeshScatteringVirtualTextureBlurriness = p_Reader.ReadInt32();
        ResourcePatchFov = p_Reader.ReadSingle();
        ResourceLodScale = p_Reader.ReadSingle();
        ResourceTriangleSizeMin = p_Reader.ReadSingle();
        TextureAtlasSampleCountX = p_Reader.ReadUInt32();
        TextureAtlasSampleCountY = p_Reader.ReadUInt32();
        TextureSamplesPerMeterMax = p_Reader.ReadSingle();
        TextureDetailFalloffCurve = p_Reader.ReadSingle();
        TextureDetailFalloffDistance = p_Reader.ReadSingle();
        TextureDetailFalloffFactor = p_Reader.ReadSingle();
        TextureInvisibleDetailReductionFactor = p_Reader.ReadSingle();
        TextureOccludedDetailReductionFactor = p_Reader.ReadSingle();
        VirtualTextureDisableTerrainLayerIndex = p_Reader.ReadInt32();

        Layers = new VisualTerrainLayer[p_Reader.ReadUInt32()];
        for (var i = 0; i < Layers.Length; ++i)
        {
            Layers[i] = new VisualTerrainLayer();
            Layers[i].Deserialize(p_Reader);
        }
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        foreach (var s_Value in MeshScatteringScaleFactors)
            p_Writer.Write(s_Value);
        p_Writer.Write(MeshScatteringCellFov);
        p_Writer.Write(MeshScatteringCellMaskSamplesPerSide);
        p_Writer.Write(MeshScatteringInstancePoolSize);
        p_Writer.Write(MeshScatteringInstanceDrawBufferSize);
        p_Writer.Write(MeshScatteringVirtualTextureBlurriness);
        p_Writer.Write(ResourcePatchFov);
        p_Writer.Write(ResourceLodScale);
        p_Writer.Write(ResourceTriangleSizeMin);
        p_Writer.Write(TextureAtlasSampleCountX);
        p_Writer.Write(TextureAtlasSampleCountY);
        p_Writer.Write(TextureSamplesPerMeterMax);
        p_Writer.Write(TextureDetailFalloffCurve);
        p_Writer.Write(TextureDetailFalloffDistance);
        p_Writer.Write(TextureDetailFalloffFactor);
        p_Writer.Write(TextureInvisibleDetailReductionFactor);
        p_Writer.Write(TextureOccludedDetailReductionFactor);
        p_Writer.Write(VirtualTextureDisableTerrainLayerIndex);

        p_Writer.Write((uint)Layers.Length);
        foreach (var s_Layer in Layers)
            s_Layer.Serialize(p_Writer);
        return true;
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
        if (s_Reader.Position != s_Reader.Length)
            throw new InvalidDataException($"VisualTerrain ends {s_Reader.Length - s_Reader.Position} byte(s) after its last layer.");
    }
}
