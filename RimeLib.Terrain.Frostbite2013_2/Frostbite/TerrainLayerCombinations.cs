using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.IO;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>
/// A TerrainLayerCombinations resource: the terrain's default surface shader, and per combination
/// of layers the shaders that draw it. These are Frostbite 2's VisualTerrain draws in a resource of
/// their own; the draw methods end in one byte less each.
/// </summary>
public class TerrainLayerCombinations
{
    public class MaskScaleDrawMethod
    {
        public byte[] MaskedTerrainLayerIndices { get; set; } = [];
        public byte[] OutputLayerOrder { get; set; } = [];
        public string ShaderName { get; set; } = string.Empty;
        public byte Level { get; set; }
    }

    public class Surface2dDrawMethod
    {
        public uint DrawPassType { get; set; }
        public byte[] MaskedTerrainLayerIndices { get; set; } = [];
        public string ShaderName { get; set; } = string.Empty;
    }

    public class Surface3dDrawMethod
    {
        public byte[] MaskedTerrainLayerIndices { get; set; } = [];
        public string ShaderName { get; set; } = string.Empty;
        public byte Level { get; set; }
        public byte DrawDirectLayerCount { get; set; }
    }

    public class Draw
    {
        public byte[] TerrainLayerIndices { get; set; } = [];
        public byte MeshScatteringMaskScaleLevelEnd { get; set; }
        public List<MaskScaleDrawMethod> MaskScaleDrawMethods { get; set; } = new();
        public List<Surface2dDrawMethod> Surface2dDrawMethods { get; set; } = new();
        public List<Surface3dDrawMethod> Surface3dDrawMethods { get; set; } = new();
    }

    public string DefaultSurfaceShaderName { get; set; } = string.Empty;

    /// <summary>Between the shader name and the draw count, meaning not established.</summary>
    public byte Unknown { get; set; }

    public List<Draw> Draws { get; set; } = new();

    private static byte[] ReadIndices(RimeReader p_Reader)
    {
        var s_Count = p_Reader.ReadUInt32();
        if (s_Count > 255)
            throw new InvalidDataException($"A layer index list of {s_Count} entries; the walk is misaligned.");
        return p_Reader.ReadBytes((int)s_Count);
    }

    private static void WriteIndices(RimeWriter p_Writer, byte[] p_Indices)
    {
        p_Writer.Write((uint)p_Indices.Length);
        p_Writer.Write(p_Indices);
    }

    public static TerrainLayerCombinations Read(byte[] p_Data)
    {
        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));

        var s_Combinations = new TerrainLayerCombinations
        {
            DefaultSurfaceShaderName = s_Reader.ReadNullTerminatedString(),
            Unknown = s_Reader.ReadUByte(),
        };

        var s_DrawCount = s_Reader.ReadUInt32();
        for (var i = 0; i < s_DrawCount; ++i)
        {
            var s_Draw = new Draw { TerrainLayerIndices = ReadIndices(s_Reader) };

            var s_MaskScaleCount = s_Reader.ReadUInt32();
            s_Draw.MeshScatteringMaskScaleLevelEnd = s_Reader.ReadUByte();
            for (var j = 0; j < s_MaskScaleCount; ++j)
            {
                s_Draw.MaskScaleDrawMethods.Add(new MaskScaleDrawMethod
                {
                    MaskedTerrainLayerIndices = ReadIndices(s_Reader),
                    OutputLayerOrder = ReadIndices(s_Reader),
                    ShaderName = s_Reader.ReadNullTerminatedString(),
                    Level = s_Reader.ReadUByte(),
                });
            }

            var s_2dCount = s_Reader.ReadUInt32();
            for (var j = 0; j < s_2dCount; ++j)
            {
                s_Draw.Surface2dDrawMethods.Add(new Surface2dDrawMethod
                {
                    DrawPassType = s_Reader.ReadUInt32(),
                    MaskedTerrainLayerIndices = ReadIndices(s_Reader),
                    ShaderName = s_Reader.ReadNullTerminatedString(),
                });
            }

            var s_3dCount = s_Reader.ReadUInt32();
            for (var j = 0; j < s_3dCount; ++j)
            {
                s_Draw.Surface3dDrawMethods.Add(new Surface3dDrawMethod
                {
                    MaskedTerrainLayerIndices = ReadIndices(s_Reader),
                    ShaderName = s_Reader.ReadNullTerminatedString(),
                    Level = s_Reader.ReadUByte(),
                    DrawDirectLayerCount = s_Reader.ReadUByte(),
                });
            }

            s_Combinations.Draws.Add(s_Draw);
        }

        if (s_Reader.Position != s_Reader.Length)
            throw new InvalidDataException($"TerrainLayerCombinations ends {s_Reader.Length - s_Reader.Position} byte(s) after its last draw.");

        return s_Combinations;
    }

    public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
    {
        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
        {
            s_Writer.WriteNullTerminatedString(DefaultSurfaceShaderName);
            s_Writer.Write(Unknown);
            s_Writer.Write((uint)Draws.Count);

            foreach (var s_Draw in Draws)
            {
                WriteIndices(s_Writer, s_Draw.TerrainLayerIndices);

                s_Writer.Write((uint)s_Draw.MaskScaleDrawMethods.Count);
                s_Writer.Write(s_Draw.MeshScatteringMaskScaleLevelEnd);
                foreach (var s_Method in s_Draw.MaskScaleDrawMethods)
                {
                    WriteIndices(s_Writer, s_Method.MaskedTerrainLayerIndices);
                    WriteIndices(s_Writer, s_Method.OutputLayerOrder);
                    s_Writer.WriteNullTerminatedString(s_Method.ShaderName);
                    s_Writer.Write(s_Method.Level);
                }

                s_Writer.Write((uint)s_Draw.Surface2dDrawMethods.Count);
                foreach (var s_Method in s_Draw.Surface2dDrawMethods)
                {
                    s_Writer.Write(s_Method.DrawPassType);
                    WriteIndices(s_Writer, s_Method.MaskedTerrainLayerIndices);
                    s_Writer.WriteNullTerminatedString(s_Method.ShaderName);
                }

                s_Writer.Write((uint)s_Draw.Surface3dDrawMethods.Count);
                foreach (var s_Method in s_Draw.Surface3dDrawMethods)
                {
                    WriteIndices(s_Writer, s_Method.MaskedTerrainLayerIndices);
                    s_Writer.WriteNullTerminatedString(s_Method.ShaderName);
                    s_Writer.Write(s_Method.Level);
                    s_Writer.Write(s_Method.DrawDirectLayerCount);
                }
            }
        }

        p_Data = s_Stream.ToArray();
        return true;
    }
}
