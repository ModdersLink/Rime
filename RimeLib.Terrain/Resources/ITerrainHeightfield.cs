using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>Reads a terrain streaming tree's heightfield, which is where a level's ground surface
/// lives -- nothing in EBX describes it.</summary>
public interface ITerrainHeightfield : IEngineInterface
{
    bool ReadHeightfield(IResourceObject p_Resource, IEngineMounter p_Mounter, out TerrainHeightfield? p_Heightfield);

    /// <summary>
    /// Rebuild a streaming tree with edited heightfield samples, so an EDITED terrain can be
    /// shipped rather than only read.
    ///
    /// Each edit names a node by (level, indexX, indexY) and supplies its samples. A replacement
    /// must be the same length as the block it replaces: the blocks that follow are found by
    /// walking past it, so a different size moves every node after it.
    /// </summary>
    /// <returns>false, with p_Error set, if a node is missing or a size does not match.</returns>
    bool WriteHeightfield(IResourceObject p_Resource, IReadOnlyList<TerrainNodeEdit> p_Edits,
        out byte[]? p_Payload, out string? p_Error);

    /// <summary>
    /// A material or destruction node's samples, one byte each, row by row, or null when its
    /// encoded lines do not decode to whole lines. <paramref name="p_ReEncodes"/> says whether
    /// encoding them again gives back the shipped bytes.
    /// </summary>
    byte[]? DecodeSamples(TerrainMaterialSamples p_Node, int p_SamplesPerSide, out bool p_ReEncodes);
}
