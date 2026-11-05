using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;

namespace RimeLib.Enlighten.Frostbite2_0;

/// <summary>
/// Frostbite 2 Enlighten resources: the database (its lightmap instances and the systems and probe
/// sets it names), a probe set, the shader database and the static database. Each dump reports
/// <c>reencodesExactly</c>, whether serialising what was read gives back the shipped bytes.
/// </summary>
public class EnlightenCodec : IEnlightenCodec
{
    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    /// <summary>
    /// Does serialising <paramref name="p_Object"/> give back exactly <paramref name="p_Original"/>?
    /// </summary>
    private static bool ReEncodes(IFbSerializable p_Object, byte[] p_Original)
    {
        if (!p_Object.Serialize(out var s_Written) || s_Written == null)
            return false;

        if (s_Written.Length != p_Original.Length)
            return false;

        for (var i = 0; i < s_Written.Length; ++i)
        {
            if (s_Written[i] != p_Original[i])
                return false;
        }

        return true;
    }

    /// <summary>
    /// The structured read for one Enlighten resource, or null if this is not a type that is
    /// parsed.
    ///
    /// Null is not a failure everywhere it is seen: <see cref="ResourceType.EnlightenSystem"/>
    /// is Enlighten's own radiosity data and nothing here decodes it. A caller carrying the
    /// bytes verbatim can still carry one; a caller wanting fields cannot.
    /// </summary>
    public EnlightenResourceDump? Dump(ResourceType p_Type, byte[] p_Data)
    {
        switch (p_Type)
        {
            case ResourceType.EnlightenDatabase:
                return DumpDatabase(p_Data);

            case ResourceType.EnlightenProbeSet:
                return DumpProbeSet(p_Data);

            case ResourceType.EnlightenShaderDatabase:
                return DumpShaderDatabase(p_Data);

            case ResourceType.StaticEnlightenDatabase:
                return DumpStaticDatabase(p_Data);

            default:
                return null;
        }
    }

    private static EnlightenResourceDump DumpDatabase(byte[] p_Data)
    {
        var s_Database = new EnlightenDatabase();
        s_Database.Deserialize(p_Data);

        var s_ReEncodes = ReEncodes(s_Database, p_Data);

        return new EnlightenResourceDump(new
        {
            type = "EnlightenDatabase",
            enabled = s_Database.Enabled,
            dynamicDataEnable = s_Database.DynamicDataEnable,
            outputAtlasWidth = s_Database.OutputAtlasWidth,
            outputAtlasHeight = s_Database.OutputAtlasHeight,
            // The systems and probe sets are named here and shipped as their own resources, so
            // this list is also what a bundle has to carry alongside the database.
            systemNames = s_Database.SystemNames,
            probeSetNames = s_Database.ProbeSetNames,
            probeCount = s_Database.ProbeCount,
            terrainLightMaps = s_Database.TerrainLightMaps.ConvertAll(p_Map => (object)new
            {
                min = p_Map.WorldBoundingBox.min,
                max = p_Map.WorldBoundingBox.max,
                uvTransform = p_Map.UVTransform,
                uvTranslation = p_Map.UVTranslation
            }),
            // Each instance ties one baked lightmap to one placed object, by guid and
            // transform. Move that object and the instance still points where it used to be:
            // this is the record that says a bake cannot survive an edit to the geometry.
            lightMapInstances = s_Database.LightMapInstances.ConvertAll(p_Instance => (object)new
            {
                guid = p_Instance.Guid.ToString(),
                transform = p_Instance.Transform,
                uvTransform = p_Instance.UVTransform,
                uvTranslation = p_Instance.UVTranslation
            }),
            trailingBytes = s_Database.TrailingData.Length,
            reencodesExactly = s_ReEncodes
        }, s_ReEncodes);
    }

    private static EnlightenResourceDump DumpProbeSet(byte[] p_Data)
    {
        var s_ProbeSet = new EnlightenProbeSet();
        s_ProbeSet.Deserialize(p_Data);

        var s_ReEncodes = ReEncodes(s_ProbeSet, p_Data);

        return new EnlightenResourceDump(new
        {
            type = "EnlightenProbeSet",
            transform = s_ProbeSet.Transform,
            inverseTransform = s_ProbeSet.InverseTransform,
            min = s_ProbeSet.BoundingBox.min,
            max = s_ProbeSet.BoundingBox.max,
            blendDistance = s_ProbeSet.BlendDistance,
            dim = s_ProbeSet.Dim,
            priority = s_ProbeSet.Priority,
            probeCount = s_ProbeSet.ProbeCount,
            globalOffset = s_ProbeSet.GlobalOffset,
            staticProbeSet = s_ProbeSet.StaticProbeSet,
            dynamicDataEnable = s_ProbeSet.DynamicDataEnable,
            indirection = s_ProbeSet.Indirection,
            positions = s_ProbeSet.Positions,
            validIndices = s_ProbeSet.ValidIndices,
            reencodesExactly = s_ReEncodes
        }, s_ReEncodes);
    }

    private static EnlightenResourceDump DumpStaticDatabase(byte[] p_Data)
    {
        var s_Static = new StaticEnlightenDatabase();
        s_Static.Deserialize(p_Data);

        var s_ReEncodes = ReEncodes(s_Static, p_Data);

        return new EnlightenResourceDump(new
        {
            type = "StaticEnlightenDatabase",
            enabled = s_Static.Enabled,
            outputAtlasWidth = s_Static.OutputAtlasWidth,
            outputAtlasHeight = s_Static.OutputAtlasHeight,
            // The coefficients themselves are the bulk of the resource and mean nothing read
            // one by one, so the dump reports how many there are and proves it can write them
            // back rather than printing 2707 sets of sixteen floats.
            probeCount = s_Static.Probes.Count,
            reencodesExactly = s_ReEncodes
        }, s_ReEncodes);
    }

    private static EnlightenResourceDump DumpShaderDatabase(byte[] p_Data)
    {
        var s_Shaders = new EnlightenShaderDatabase();
        s_Shaders.Deserialize(p_Data);

        var s_ReEncodes = ReEncodes(s_Shaders, p_Data);

        return new EnlightenResourceDump(new
        {
            type = "EnlightenShaderDatabase",
            materials = s_Shaders.Materials.ConvertAll(p_Material => (object)new
            {
                color = p_Material.Color,
                guid = p_Material.Guid.ToString(),
                shaderId = p_Material.ShaderId,
                emissive = p_Material.Emissive
            }),
            reencodesExactly = s_ReEncodes
        }, s_ReEncodes);
    }
}
