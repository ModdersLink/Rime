using RimeLib.Content.Mounting;

namespace RimeLib.Terrain.Resources;

/// <summary>
/// Reads a TerrainLayerCombinations resource: the default surface shader and the shaders each
/// combination of terrain layers draws with. Engines that keep these in VisualTerrain (Frostbite 2)
/// give them through <see cref="IVisualTerrain"/> instead.
/// </summary>
public interface ITerrainLayerCombinations : IEngineInterface
{
    /// <summary>Fills <see cref="VisualTerrainInfo.SurfaceShader"/> and <see cref="VisualTerrainInfo.Draws"/>.</summary>
    bool ReadLayerCombinations(IResourceObject p_Resource, out VisualTerrainInfo? p_Info);

    /// <summary>Reads the resource and writes it straight back, to check the writer.</summary>
    bool RoundTripLayerCombinations(IResourceObject p_Resource, out byte[]? p_Original, out byte[]? p_Rebuilt);
}
