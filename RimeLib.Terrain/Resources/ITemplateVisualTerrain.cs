using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>A resource to add to a bundle: its name, payload, type and meta.</summary>
public sealed record GeneratedResource(string Name, byte[] Data, ResourceType Type, byte[]? Meta);

/// <summary>What <see cref="ITemplateVisualTerrain.Build"/> gives a terrain the visuals of.</summary>
public sealed class TemplateVisualTerrainRequest
{
    /// <summary>The terrain, as its TerrainData names it.</summary>
    public string Terrain { get; init; } = string.Empty;

    /// <summary>The game the template is in, which also holds the template's decals.</summary>
    public required IEngineMounter TemplateGame { get; init; }

    /// <summary>The template's visual terrain and its name.</summary>
    public required IResourceObject Template { get; init; }
    public string TemplateName { get; init; } = string.Empty;

    /// <summary>The bundle's resources, where the terrain's streaming tree may be.</summary>
    public IReadOnlyDictionary<string, IResourceObject> BundleResources { get; init; } = new Dictionary<string, IResourceObject>();

    /// <summary>The engine of the terrain's own decals and visual terrain.</summary>
    public EngineType OwnEngine { get; init; }

    /// <summary>The terrain's own decals, or null for decals with no geometry.</summary>
    public IResourceObject? OwnDecals { get; init; }

    /// <summary>The terrain's own visual terrain and layer combinations, or null to draw with the template's layers.</summary>
    public IResourceObject? OwnVisual { get; init; }
    public IResourceObject? OwnLayerCombinations { get; init; }

    /// <summary>Decal shaders chosen by hand, as pattern=shader pairs separated by ';'.</summary>
    public string? DecalShaders { get; init; }

    /// <summary>Names to move in the terrain's own shaders' names, as 'from=to'.</summary>
    public string? MoveNames { get; init; }
}

/// <summary>Gives a terrain the visuals of one of this engine's own terrains.</summary>
public interface ITemplateVisualTerrain : IEngineInterface
{
    /// <summary>
    /// The visual terrain, decals and, where the bundle holds it, the streaming tree to add, or null
    /// when that cannot be done; what it did and why not are written to <paramref name="p_Log"/>.
    /// </summary>
    IReadOnlyList<GeneratedResource>? Build(TemplateVisualTerrainRequest p_Request, TextWriter p_Log);
}
