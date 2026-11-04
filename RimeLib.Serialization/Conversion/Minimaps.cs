using System.Collections.Generic;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// The square of world a minimap texture shows: a world point (x, z) is at texture coordinates
/// u = 0.5 + SignX (x - CenterX) / Size and v = 0.5 + SignZ (z - CenterZ) / Size.
/// </summary>
public sealed record MinimapFrame(float CenterX, float CenterZ, float Size, int SignX, int SignZ);

/// <summary>An engine's minimap assets, as a source of a level's map image.</summary>
public interface IMinimapSource : IEngineInterface
{
    /// <summary>
    /// The texture asset of a minimap asset that shows the whole map, and the frame it shows; none
    /// for a partition that is not a minimap asset.
    /// </summary>
    (InstanceRef Texture, MinimapFrame Frame)? Read(DatabasePartitionBase p_Partition);
}

/// <summary>An engine's level minimap settings, which show a texture of the level.</summary>
public interface IMinimapTarget : IEngineInterface
{
    /// <summary>Which way this engine's minimap texture runs along x and z, as <see cref="MinimapFrame"/> has it.</summary>
    (int SignX, int SignZ) Signs { get; }

    /// <summary>The texture a level's minimap shows; none for a partition without minimap settings or texture.</summary>
    InstanceRef? Texture(DatabasePartitionBase p_Level);

    /// <summary>A texture asset of this engine, which finds its texture resource by its name.</summary>
    DataContainerBase TextureAsset(string p_Name);

    /// <summary>
    /// Sets a level's minimap settings to a template level's, showing the texture over the frame and
    /// without the template's distance fields, which outline the template's own map. Returns the
    /// partitions the settings reference besides the texture; none when either level has no settings.
    /// </summary>
    IReadOnlyList<InstanceRef>? Set(DatabasePartitionBase p_Level, DatabasePartitionBase p_Template, InstanceRef p_Texture, MinimapFrame p_Frame);
}
