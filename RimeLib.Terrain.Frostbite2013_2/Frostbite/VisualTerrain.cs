using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// One mesh scattering type of a terrain layer. Field names follow the EBX
/// <c>TerrainMeshScatteringType</c> and Frostbite 2's cooked record where the values line up;
/// the rest is kept as read.
/// </summary>
public class MeshScatteringType
{
    public string MeshName { get; set; } = string.Empty;

    /// <summary>The same for every record of a mesh: the mesh resource's id.</summary>
    public ulong MeshResourceId { get; set; }

    /// <summary>0 for the mesh's own look.</summary>
    public uint VariationAssetNameHash { get; set; }

    /// <summary>Counts up across the whole resource.</summary>
    public uint Identifier { get; set; }

    /// <summary>Per quality level: low, medium, high, ultra.</summary>
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

    /// <summary>Five flags after the wind settings, meaning not established.</summary>
    public byte[] Flags { get; set; } = new byte[5];

    /// <summary>Five values after the flags (spawn levels and modes in Frostbite 2's order), meaning not established.</summary>
    public uint[] Settings { get; set; } = new uint[5];

    /// <summary>Four increasing distances, meaning not established.</summary>
    public float[] Distances { get; set; } = new float[4];

    public uint InstanceType { get; set; }
    public uint InstanceValue { get; set; }

    /// <summary>Five more values, present for instance types other than 1.</summary>
    public uint[] InstanceDistances { get; set; } = [];

    /// <summary>Three bytes, a float and three bytes ending the record, meaning not established.</summary>
    public byte[] TailBefore { get; set; } = new byte[3];
    public float TailValue { get; set; }
    public byte[] TailAfter { get; set; } = new byte[3];

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
        s_Type.Flags = p_Reader.ReadBytes(5);

        for (var i = 0; i < 5; ++i)
            s_Type.Settings[i] = p_Reader.ReadUInt32();
        for (var i = 0; i < 4; ++i)
            s_Type.Distances[i] = p_Reader.ReadSingle();

        s_Type.InstanceType = p_Reader.ReadUInt32();
        s_Type.InstanceValue = p_Reader.ReadUInt32();
        if (s_Type.InstanceType > 1)
        {
            s_Type.InstanceDistances = new uint[5];
            for (var i = 0; i < 5; ++i)
                s_Type.InstanceDistances[i] = p_Reader.ReadUInt32();
        }

        s_Type.TailBefore = p_Reader.ReadBytes(3);
        s_Type.TailValue = p_Reader.ReadSingle();
        s_Type.TailAfter = p_Reader.ReadBytes(3);
        return s_Type;
    }

    public void Write(RimeWriter p_Writer)
    {
        if (InstanceDistances.Length != (InstanceType > 1 ? 5 : 0))
            throw new InvalidDataException($"Instance type {InstanceType} takes {(InstanceType > 1 ? 5 : 0)} instance distances, not {InstanceDistances.Length}.");

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
        p_Writer.Write(Flags);
        foreach (var s_Value in Settings)
            p_Writer.Write(s_Value);
        foreach (var s_Value in Distances)
            p_Writer.Write(s_Value);
        p_Writer.Write(InstanceType);
        p_Writer.Write(InstanceValue);
        foreach (var s_Value in InstanceDistances)
            p_Writer.Write(s_Value);
        p_Writer.Write(TailBefore);
        p_Writer.Write(TailValue);
        p_Writer.Write(TailAfter);
    }
}

public class VisualTerrainLayer
{
    public MeshScatteringType[] ScatteringTypes { get; set; } = [];
}

/// <summary>
/// A VisualTerrain resource: the scattering of each terrain layer. Unlike Frostbite 2 it names no
/// surface shader, streaming tree or decals (EBX references those by id) and holds no layer
/// combination draws (those are their own resource, <see cref="TerrainLayerCombinations"/>).
/// </summary>
public class VisualTerrain
{
    public const int HeaderSize = 0x54;

    /// <summary>The header as read: cell, patch, atlas and texture detail settings.</summary>
    public byte[] Header { get; set; } = new byte[HeaderSize];

    public VisualTerrainLayer[] Layers { get; set; } = [];

    // Header fields whose place is established, by their Frostbite 2 counterparts.
    public uint MeshScatteringCellMaskSamplesPerSide => BitConverter.ToUInt32(Header, 0x14);
    public uint MeshScatteringInstancePoolSize => BitConverter.ToUInt32(Header, 0x18);
    public uint MeshScatteringInstanceDrawBufferSize => BitConverter.ToUInt32(Header, 0x1C);
    public uint TextureAtlasSampleCountX => BitConverter.ToUInt32(Header, 0x30);
    public uint TextureAtlasSampleCountY => BitConverter.ToUInt32(Header, 0x34);
    public float TextureSamplesPerMeterMax => BitConverter.ToSingle(Header, 0x38);

    public static VisualTerrain Read(RimeReader p_Reader)
    {
        var s_Terrain = new VisualTerrain { Header = p_Reader.ReadBytes(HeaderSize) };

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
            s_Writer.Write(Header);
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
