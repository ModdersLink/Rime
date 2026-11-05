using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;
using BaseDraw = RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain;

namespace RimeLib.Terrain.Frostbite2013_2.Frostbite;

/// <summary>Frostbite 2's mask scale draw method without its own destruction mask flag.</summary>
public class MeshScatteringMaskScaleMethod : BaseDraw.MeshScatteringMaskScaleMethod
{
    protected override bool HasDestructionMaskEnable => false;
}

/// <summary>Frostbite 2's 2d draw method without its own destruction mask flag.</summary>
public class Surface2dDrawMethod : BaseDraw.Surface2dDrawMethod
{
    protected override bool HasDestructionMaskEnable => false;
}

/// <summary>Frostbite 2's 3d draw method without its own destruction mask flag.</summary>
public class Surface3dDrawMethod : BaseDraw.Surface3dDrawMethod
{
    protected override bool HasDestructionMaskEnable => false;
}

/// <summary>Frostbite 2's layer combination draw, over the methods above.</summary>
public class TerrainLayerCombinationDraw : BaseDraw.TerrainLayerCombinationDraw
{
    protected override BaseDraw.MeshScatteringMaskScaleMethod ReadMaskScaleMethod(RimeReader p_Reader) => Read(new MeshScatteringMaskScaleMethod(), p_Reader);
    protected override BaseDraw.Surface2dDrawMethod ReadSurface2dMethod(RimeReader p_Reader) => Read(new Surface2dDrawMethod(), p_Reader);
    protected override BaseDraw.Surface3dDrawMethod ReadSurface3dMethod(RimeReader p_Reader) => Read(new Surface3dDrawMethod(), p_Reader);

    private static T Read<T>(T p_Method, RimeReader p_Reader) where T : IFbSerializable
    {
        p_Method.Deserialize(p_Reader);
        return p_Method;
    }
}

/// <summary>
/// A TerrainLayerCombinations resource: the terrain's default surface shader, and per combination
/// of layers the shaders that draw it. These are Frostbite 2's VisualTerrain draws in a resource of
/// their own; the destruction mask flag is the resource's, not each draw method's.
/// </summary>
public class TerrainLayerCombinations : IFbSerializable
{
    public string DefaultSurfaceShaderName { get; set; } = string.Empty;
    public bool DestructionMaskEnable { get; set; }
    public List<TerrainLayerCombinationDraw> Draws { get; set; } = new();

    public void Deserialize(RimeReader p_Reader)
    {
        DefaultSurfaceShaderName = p_Reader.ReadNullTerminatedString();
        DestructionMaskEnable = p_Reader.ReadBool();

        var s_Count = p_Reader.ReadUInt32();
        Draws = new List<TerrainLayerCombinationDraw>((int)s_Count);
        for (var i = 0; i < s_Count; ++i)
        {
            var s_Draw = new TerrainLayerCombinationDraw();
            s_Draw.Deserialize(p_Reader);
            Draws.Add(s_Draw);
        }
    }

    public bool Serialize(RimeWriter p_Writer)
    {
        p_Writer.WriteNullTerminatedString(DefaultSurfaceShaderName);
        p_Writer.Write(DestructionMaskEnable);
        p_Writer.Write((uint)Draws.Count);
        foreach (var s_Draw in Draws)
            if (!s_Draw.Serialize(p_Writer))
                return false;
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
            throw new InvalidDataException($"TerrainLayerCombinations ends {s_Reader.Length - s_Reader.Position} byte(s) after its last draw.");
    }
}
