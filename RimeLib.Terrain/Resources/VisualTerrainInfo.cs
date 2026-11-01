using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>What a level's terrain is painted with.</summary>
public class VisualTerrainInfo
{
    public string SurfaceShader { get; set; } = string.Empty;
    public string StreamingTree { get; set; } = string.Empty;
    public string Decals { get; set; } = string.Empty;
    public int LayerCount { get; set; }
    /// <summary>Whether each layer draws through a virtual texture.</summary>
    public List<bool> LayerVirtualTexture { get; set; } = new();
    public List<VisualTerrainDraw> Draws { get; set; } = new();
    public uint TextureAtlasWidth { get; set; }
    public uint TextureAtlasHeight { get; set; }
    public float TextureSamplesPerMeterMax { get; set; }
    /// <summary>Every layer's mesh scattering types, flattened, each naming its own layer.</summary>
    public List<VisualTerrainScattering> Scattering { get; set; } = new();
}
