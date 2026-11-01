using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// One mesh scattering type of a terrain layer (the engine's MeshScatteringTypeBase), in stream
/// order. A later engine version reads the same fields in the same order where both have them.
/// </summary>
public class MeshScatteringType
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

    public static MeshScatteringType Read(RimeReader p_Reader)
    {
        var s_Type = new MeshScatteringType
        {
            MeshName = p_Reader.ReadNullTerminatedString(),
            MeshResourceId = p_Reader.ReadUInt64(),
            VariationAssetNameHash = p_Reader.ReadUInt32(),
            Identifier = p_Reader.ReadUInt32(),
        };

        for (var i = 0; i < 4; ++i)
            s_Type.Density[i] = p_Reader.ReadSingle();

        s_Type.RandomPositionOffset = p_Reader.ReadSingle();
        s_Type.MinMask = p_Reader.ReadSingle();
        s_Type.MaxMask = p_Reader.ReadSingle();
        s_Type.MinScaleX = p_Reader.ReadSingle();
        s_Type.MinScaleY = p_Reader.ReadSingle();
        s_Type.MaxScaleX = p_Reader.ReadSingle();
        s_Type.MaxScaleY = p_Reader.ReadSingle();
        s_Type.MinMaskScaleFactorX = p_Reader.ReadSingle();
        s_Type.MinMaskScaleFactorY = p_Reader.ReadSingle();
        s_Type.ScaleRandomness = p_Reader.ReadSingle();
        s_Type.WindScale = p_Reader.ReadSingle();
        s_Type.Stiffness = p_Reader.ReadSingle();
        s_Type.Damping = p_Reader.ReadSingle();
        s_Type.Mass = p_Reader.ReadSingle();
        s_Type.WindWiggle = p_Reader.ReadSingle();
        s_Type.LastLodAndBillboard = p_Reader.ReadSByte();
        s_Type.Enabled = p_Reader.ReadBool();
        s_Type.Flags = p_Reader.ReadBytes(3);

        for (var i = 0; i < 4; ++i)
            s_Type.SpawnLevelCounts[i] = p_Reader.ReadUInt32();
        s_Type.ShadowViewDistance = p_Reader.ReadSingle();
        for (var i = 0; i < 4; ++i)
            s_Type.LodDistances[i] = p_Reader.ReadSingle();

        s_Type.TextureAtlasSizeX = p_Reader.ReadUInt32();
        s_Type.TextureAtlasSizeY = p_Reader.ReadUInt32();
        if (s_Type.TileCount > 1)
        {
            if (s_Type.TileCount > 0xFFFF)
                throw new InvalidDataException($"A scattering texture atlas of {s_Type.TextureAtlasSizeX}x{s_Type.TextureAtlasSizeY} tiles; the walk is misaligned.");

            s_Type.TextureAtlasCumulativeTileWeights = new uint[s_Type.TileCount];
            for (var i = 0; i < s_Type.TileCount; ++i)
                s_Type.TextureAtlasCumulativeTileWeights[i] = p_Reader.ReadUInt32();
            s_Type.TextureAtlasCumulativeTileWeightMax = p_Reader.ReadUInt32();
        }

        s_Type.FirstSpawnLevel = p_Reader.ReadUByte();
        s_Type.RotationMode = p_Reader.ReadUByte();
        s_Type.OrientationMode = p_Reader.ReadUByte();
        s_Type.RotateTowardsSlopeRandomWeight = p_Reader.ReadSingle();
        s_Type.BillboardingEnable = p_Reader.ReadBool();
        s_Type.InstanceDataMode = p_Reader.ReadUByte();
        s_Type.GroundClampBoundingBoxEnable = p_Reader.ReadBool();
        return s_Type;
    }

    public void Write(RimeWriter p_Writer)
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
    }
}

public class VisualTerrainLayer
{
    public MeshScatteringType[] ScatteringTypes { get; set; } = [];
}

/// <summary>
/// A VisualTerrain resource: the mesh scattering, patch and texture settings, and the scattering of
/// each terrain layer. Unlike Frostbite 2 it names no surface shader, streaming tree or decals
/// (EBX references those by id) and holds no layer combination draws (those are their own
/// resource, <see cref="TerrainLayerCombinations"/>).
/// </summary>
public class VisualTerrain
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

    public static VisualTerrain Read(RimeReader p_Reader)
    {
        var s_Terrain = new VisualTerrain();
        for (var i = 0; i < 4; ++i)
            s_Terrain.MeshScatteringScaleFactors[i] = p_Reader.ReadSingle();
        s_Terrain.MeshScatteringCellFov = p_Reader.ReadSingle();
        s_Terrain.MeshScatteringCellMaskSamplesPerSide = p_Reader.ReadUInt32();
        s_Terrain.MeshScatteringInstancePoolSize = p_Reader.ReadUInt32();
        s_Terrain.MeshScatteringInstanceDrawBufferSize = p_Reader.ReadUInt32();
        s_Terrain.MeshScatteringVirtualTextureBlurriness = p_Reader.ReadInt32();
        s_Terrain.ResourcePatchFov = p_Reader.ReadSingle();
        s_Terrain.ResourceLodScale = p_Reader.ReadSingle();
        s_Terrain.ResourceTriangleSizeMin = p_Reader.ReadSingle();
        s_Terrain.TextureAtlasSampleCountX = p_Reader.ReadUInt32();
        s_Terrain.TextureAtlasSampleCountY = p_Reader.ReadUInt32();
        s_Terrain.TextureSamplesPerMeterMax = p_Reader.ReadSingle();
        s_Terrain.TextureDetailFalloffCurve = p_Reader.ReadSingle();
        s_Terrain.TextureDetailFalloffDistance = p_Reader.ReadSingle();
        s_Terrain.TextureDetailFalloffFactor = p_Reader.ReadSingle();
        s_Terrain.TextureInvisibleDetailReductionFactor = p_Reader.ReadSingle();
        s_Terrain.TextureOccludedDetailReductionFactor = p_Reader.ReadSingle();
        s_Terrain.VirtualTextureDisableTerrainLayerIndex = p_Reader.ReadInt32();

        s_Terrain.Layers = new VisualTerrainLayer[p_Reader.ReadUInt32()];
        for (var i = 0; i < s_Terrain.Layers.Length; ++i)
        {
            var s_Layer = new VisualTerrainLayer { ScatteringTypes = new MeshScatteringType[p_Reader.ReadUInt32()] };
            for (var j = 0; j < s_Layer.ScatteringTypes.Length; ++j)
                s_Layer.ScatteringTypes[j] = MeshScatteringType.Read(p_Reader);
            s_Terrain.Layers[i] = s_Layer;
        }

        if (p_Reader.Position != p_Reader.Length)
            throw new InvalidDataException($"VisualTerrain ends {p_Reader.Length - p_Reader.Position} byte(s) after its last layer.");

        return s_Terrain;
    }

    public static VisualTerrain Read(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        return Read(s_Reader);
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            foreach (var s_Value in MeshScatteringScaleFactors)
                s_Writer.Write(s_Value);
            s_Writer.Write(MeshScatteringCellFov);
            s_Writer.Write(MeshScatteringCellMaskSamplesPerSide);
            s_Writer.Write(MeshScatteringInstancePoolSize);
            s_Writer.Write(MeshScatteringInstanceDrawBufferSize);
            s_Writer.Write(MeshScatteringVirtualTextureBlurriness);
            s_Writer.Write(ResourcePatchFov);
            s_Writer.Write(ResourceLodScale);
            s_Writer.Write(ResourceTriangleSizeMin);
            s_Writer.Write(TextureAtlasSampleCountX);
            s_Writer.Write(TextureAtlasSampleCountY);
            s_Writer.Write(TextureSamplesPerMeterMax);
            s_Writer.Write(TextureDetailFalloffCurve);
            s_Writer.Write(TextureDetailFalloffDistance);
            s_Writer.Write(TextureDetailFalloffFactor);
            s_Writer.Write(TextureInvisibleDetailReductionFactor);
            s_Writer.Write(TextureOccludedDetailReductionFactor);
            s_Writer.Write(VirtualTextureDisableTerrainLayerIndex);

            s_Writer.Write((uint)Layers.Length);
            foreach (var s_Layer in Layers)
            {
                s_Writer.Write((uint)s_Layer.ScatteringTypes.Length);
                foreach (var s_Type in s_Layer.ScatteringTypes)
                    s_Type.Write(s_Writer);
            }
        }

        p_Data = s_Stream.ToArray();
        return true;
    }
}
