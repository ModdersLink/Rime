using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>A resource a terrain resource becomes in another engine.</summary>
public sealed record ConvertedTerrainResource(string Name, ResourceType Type, byte[] Data);

/// <summary>Converts this engine's terrain resources to another engine's.</summary>
public interface ITerrainConverter : IEngineInterface
{
    /// <summary>
    /// The resources a terrain resource of this engine becomes in the target's, named after the
    /// name it has there; none where the target keeps nothing of it. Tile data the resource keeps in
    /// chunks is read through the mounter.
    /// </summary>
    /// <param name="p_Name">The resource's name in the target, in lower case as bundles keep it.</param>
    /// <param name="p_Materials">A packed material of this engine as the target's.</param>
    IReadOnlyList<ConvertedTerrainResource> Convert(IResourceObject p_Resource, string p_Name, IEngineMounter p_Mounter, EngineType p_Target,
        Func<uint, uint> p_Materials, TextWriter p_Log);

    /// <summary>
    /// This engine's terrain decals in the target's layout. Their blocks still name this engine's
    /// shaders, which the target has to replace with its own; blocks the target cannot draw are left out.
    /// </summary>
    TerrainDecalsResource ConvertDecals(TerrainDecalsResource p_Decals, EngineType p_Target, TextWriter p_Log);

    /// <summary>
    /// This engine's visual terrain and the draws of its layer combinations as the target's visual
    /// terrain resource, drawing the given streaming tree and decals with the terrain's own layers
    /// and shaders, under their names in the target. Draws the target cannot take are left out.
    /// </summary>
    /// <param name="p_SurfaceShader">The target's default surface shader for the terrain.</param>
    /// <param name="p_ShaderName">A shader's name in the target.</param>
    /// <param name="p_Keep3d">Whether to keep the 3d draw methods, whose shaders the target then has to hold too.</param>
    byte[] ConvertVisualTerrain(IResourceObject p_Visual, IResourceObject p_LayerCombinations, string p_StreamingTree, string p_Decals,
        string p_SurfaceShader, Func<string, string> p_ShaderName, bool p_Keep3d, EngineType p_Target, TextWriter p_Log);
}
