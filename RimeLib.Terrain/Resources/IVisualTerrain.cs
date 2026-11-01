using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Terrain.Resources;

/// <summary>
/// Reads a level's VisualTerrain resource: the layers its ground is painted with, and the shaders
/// that blend them. Nothing in EBX carries this.
/// </summary>
public interface IVisualTerrain : IEngineInterface
{
    bool ReadVisualTerrain(IResourceObject p_Resource, IEngineMounter p_Mounter, out VisualTerrainInfo? p_Info);

    /// <summary>
    /// Rebuilds a VisualTerrain resource from the SHIPPED one plus the edits in <paramref name="p_Edits"/>.
    ///
    /// The edits are applied onto the original rather than the resource being rebuilt from
    /// <see cref="VisualTerrainInfo"/> alone, because that view is deliberately lossy -- it carries
    /// nothing about the mask-scale draw methods or most of the resource header. Rebuilding from it
    /// would silently drop them, and the level would still look like it round-tripped.
    ///
    /// Returns false and leaves <paramref name="p_Data"/> null if the edits do not line up with the
    /// original (an unknown layer, a scattering index the layer does not have, or the same
    /// (Layer, Index) twice) -- a mismatch is reported, never absorbed.
    /// </summary>
    bool WriteVisualTerrain(IResourceObject p_Resource, VisualTerrainInfo p_Edits, out byte[]? p_Data,
        out string? p_Error);

    /// <summary>
    /// Reads the resource and writes it straight back out, unchanged. The point is the BYTES: this
    /// is how a caller checks that the writer reproduces what the game ships before trusting it
    /// with an edit.
    /// </summary>
    bool RoundTripVisualTerrain(IResourceObject p_Resource, out byte[]? p_Original, out byte[]? p_Rebuilt);
}
