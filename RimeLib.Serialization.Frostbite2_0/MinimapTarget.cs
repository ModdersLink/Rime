using System.Collections.Generic;
using System.Linq;
using fb;
using RimeLib.Frostbite;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2_0;

/// <summary>
/// A level's minimap settings, kept by its UI level description component: the detail texture,
/// which shows the map, over a square of WorldSize around WorldCenter (x, z). The texture runs
/// against x along u and against z along v.
/// </summary>
public class MinimapTarget : IMinimapTarget
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public (int SignX, int SignZ) Signs => (-1, -1);

    public InstanceRef? Texture(DatabasePartitionBase p_Level) =>
        Settings(p_Level)?.DetailTexture is { } s_Texture && !s_Texture.IsNull() ? Ref(s_Texture) : null;

    public DataContainerBase TextureAsset(string p_Name) => new TextureAsset { Name = p_Name };

    public IReadOnlyList<InstanceRef>? Set(DatabasePartitionBase p_Level, DatabasePartitionBase p_Template, InstanceRef p_Texture, MinimapFrame p_Frame)
    {
        var s_Component = p_Level.Instances.OfType<UILevelDescriptionComponent>().FirstOrDefault();
        if (s_Component == null || Settings(p_Template) is not { } s_Settings)
            return null;

        s_Settings.WorldCenter = new Vec2 { x = p_Frame.CenterX, y = p_Frame.CenterZ };
        s_Settings.WorldSize = p_Frame.Size;
        s_Settings.DetailTexture.SetValue(p_Texture.Partition, new DataContainerId.Guid(p_Texture.Instance));
        s_Settings.Vegetation.DistanceField = new();
        s_Settings.Detail.DistanceField = new();
        s_Component.MinimapData = s_Settings;
        return new[] { s_Settings.FadeTexture, s_Settings.AirRadarFadeTexture, s_Settings.CombatAreaMultiplyTexture }
            .Where(p_R => !p_R.IsNull()).Select(Ref).ToList();
    }

    private static UIMinimapData? Settings(DatabasePartitionBase p_Level) =>
        p_Level.Instances.OfType<UILevelDescriptionComponent>().FirstOrDefault()?.MinimapData;

    private static InstanceRef Ref(CtrRefBase p_Ref) =>
        new(p_Ref.PartitionGuid, PartitionConversion.InstanceGuid(p_Ref.PartitionGuid, p_Ref.InstanceId));
}
