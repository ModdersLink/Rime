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
