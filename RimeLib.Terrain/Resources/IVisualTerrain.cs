using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>
/// One combination of terrain layers, and the shader that draws it.
/// </summary>
/// <remarks>
/// The shader's name encodes the combination it serves -- MP_017 has one called
/// "..._Terrain__0MD_1MD_2MD_3MD_4MD_5MD__3d__0", meaning layers 0 to 5, each masked and with a
/// diffuse. Its textures are the level's terrain layer textures.
/// </remarks>
public class VisualTerrainDraw
{
    public string Shader { get; set; } = string.Empty;
    /// <summary>Which layers this draw blends, in order.</summary>
    public List<int> Layers { get; set; } = new();
    /// <summary>2d draws paint the ground; 3d draws are the ones with world-space projection.</summary>
    public string Kind { get; set; } = string.Empty;
    public int Level { get; set; }
}

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
}

/// <summary>
/// Reads a level's VisualTerrain resource: the layers its ground is painted with, and the shaders
/// that blend them. Nothing in EBX carries this.
/// </summary>
public interface IVisualTerrain : IEngineInterface
{
    bool ReadVisualTerrain(IResourceObject p_Resource, IEngineMounter p_Mounter, out VisualTerrainInfo? p_Info);
}
