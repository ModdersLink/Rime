using System.Collections.Generic;
using System.Numerics;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Conversion;

/// <summary>A named area of an emitter system's atlas, in texture coordinates.</summary>
public sealed record EmitterAtlasEntry(string TextureName, Vector2 MinUv, Vector2 MaxUv);

/// <summary>An emitter system: its base and normal atlas textures and the named areas of them.</summary>
public sealed class EmitterSystemModel
{
    public CtrRefBase BaseAtlas { get; set; } = new();
    public CtrRefBase NormalAtlas { get; set; } = new();
    public List<EmitterAtlasEntry> Entries { get; } = new();
}

/// <summary>How an engine keeps the emitter system a level's particles find their atlas textures in.</summary>
public interface IEmitterSystemRules : IEngineInterface
{
    /// <summary>The emitter system an instance is, or null when it is not one.</summary>
    EmitterSystemModel? ReadSystem(DataContainerBase p_Instance);

    /// <summary>An emitter system instance named <paramref name="p_Name"/>.</summary>
    DataContainerBase CreateSystem(string p_Name, GUID p_InstanceGuid, EmitterSystemModel p_System);

    /// <summary>The name of the texture asset an instance is, or null when it is not one.</summary>
    string? GetTextureAssetName(DataContainerBase p_Instance);

    /// <summary>A texture asset instance named <paramref name="p_Name"/>.</summary>
    DataContainerBase CreateTextureAsset(string p_Name, GUID p_InstanceGuid);

    /// <summary>The atlas texture names an emitter's instance looks up, none for other instances.</summary>
    IEnumerable<string> GetEmitterTextureNames(DataContainerBase p_Instance);
}
