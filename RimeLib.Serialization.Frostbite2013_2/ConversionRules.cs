using System;
using System.Collections.Generic;
using System.Linq;
using fb.Audio;
using fb.Emitter;
using RimeLib.Frostbite;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2013_2;

public class ConversionRules : IConversionRules
{
    /// <summary>
    /// To Frostbite 2, which names some enum values differently, keeps single values where this engine
    /// has structs or flags, and has one emitter template where this engine has one per quality.
    /// </summary>
    private static readonly Conversion.ConversionRules s_ToFrostbite2 = new()
    {
        // Frostbite 2 has one emitter template, which is the partition's primary instance. Its mesh
        // variation redirects are entries without materials, which take the mesh's plain entry's.
        Types = new Dictionary<string, string>
        {
            ["ScalableEmitterDocument"] = "EmitterDocument",
            ["MeshVariationDatabaseRedirectEntry"] = "MeshVariationDatabaseEntry",
        },
        Primary = new Dictionary<string, string> { ["ScalableEmitterDocument"] = "TemplateDataHigh" },
        Fields = new Dictionary<(string, string), FieldSource>
        {
            [("ScalableEmitterDocument", "TemplateData")] = new("TemplateDataHigh"),
            [("ScalableEmitterDocument", "RootProcessor")] = new("TemplateDataHigh.RootProcessor"),
            [("EffectEntityData", "LowEndPc")] = new("Enable.Low"),
            [("EffectEntityData", "MediumPc")] = new("Enable.Medium"),
            [("EffectEntityData", "HighEndPc")] = new("Enable.High"),
            [("EffectEntityData", "MaxInstanceCount")] = new("MaxActiveInstanceCount.High"),
            // Frostbite 2 names the parameters of fx/globaleffectparameterlist its parameter does.
            [("EvaluatorData", "EmitterParameter")] = new("Parameter.Name"),
            [("EmitterTemplateData", "EmittableType")] = new("", p_Template => Emittables((EmitterTemplateData)p_Template))
            {
                Reads = ["EmittableType", "EmittableAlignment"],
            },
            // Frostbite 2's game configuration, which a level names.
            [("LevelData", "GameConfigurationName")] = new("", _ => "gameconfigurations/game") { Reads = ["GameConfigurationName"] },
            // Processors here have no switch to turn them off.
            [("ProcessorData", "Enable")] = new("", _ => true),
            [("DataBusData", "Descriptor")] = new("Interface"),
            // The bus flags' bits, in the order Frostbite 2 has the fields: bit 1 is set where a
            // connection uses the interface; the others follow from that order.
            [("DataBusData", "NeedNetworkId")] = new("Flags", Bit(0)),
            [("DataBusData", "InterfaceHasConnections")] = new("Flags", Bit(1)),
            [("DataBusData", "AlwaysCreateEntityBusClient")] = new("Flags", Bit(2)),
            [("DataBusData", "AlwaysCreateEntityBusServer")] = new("Flags", Bit(3)),
            [("SoundWaveAsset", "Variations")] = new("", p_Wave => Variations((SoundWaveAsset)p_Wave))
            {
                Reads = ["RuntimeVariations", "Segments", "Subtitles"],
            },
            // Set exactly where the variation's segments have seek tables, in both engines.
            [("SoundWaveVariation", "SeekTablesSize")] = new("PersistentDataSize"),
            [("GameObjectData", "IsEventConnectionTarget")] = new("Flags", Realm(25)),
            [("GameObjectData", "IsPropertyConnectionTarget")] = new("Flags", Realm(27)),
        },
        EnumValues = new Dictionary<(string, string), string>
        {
            [("SoundWaveVariationSelection", "SoundWaveVariationSelection_Sequential")] = "SwvsSequential",
            [("SoundWaveVariationSelection", "SoundWaveVariationSelection_Random")] = "SwvsRandom",
            // The value between Unconnected and Bus in both engines.
            [("SoundGraphPluginConnectionType", "SoundGraphPluginConnectionType_Signal")] = "SoundGraphPluginConnectionType_Voice",
        },
        Unwrap = new Dictionary<string, string>
        {
            ["EffectWithSpeedRange"] = "Effect",
            // Frostbite 2 has one value for every quality setting.
            ["QualityScalableFloat"] = "High",
            ["AudioGraphNodePort"] = "UnconnectedValue",
            // Where Frostbite 2 references the shader alone, as decal templates do.
            ["SurfaceShaderInstanceDataStruct"] = "Shader",
        },
        // Each such resource is named after the asset's partition, which is how Frostbite 2 finds it;
        // a GroupHavokAsset's is not.
        NamedResources = new HashSet<string>
        {
            "RigidMeshAsset.MeshSetResource",
            "SkinnedMeshAsset.MeshSetResource",
            "CompositeMeshAsset.MeshSetResource",
            "TextureAsset.Resource",
            "HavokAsset.Resource",
            "EnlightenShaderDatabaseAsset.DatabaseResource",
            "TerrainData.VisualResource",
        },
    };

    private static Func<object, object> Bit(int p_Bit) => p_Flags => ((ushort)p_Flags & (1 << p_Bit)) != 0;

    /// <summary>
    /// The realms that connect to an object, from the two bits of its flags at <paramref name="p_Shift"/>:
    /// none, client, server or both here, and client, server, both or none in Frostbite 2.
    /// </summary>
    private static Func<object, object> Realm(int p_Shift) => p_Flags => (int)((((uint)p_Flags >> p_Shift) + 3) & 3);

    /// <summary>The type of an emitter's emittables that also says how quads align, as Frostbite 2 has it.</summary>
    private static EmittableType Emittables(EmitterTemplateData p_Template) => (p_Template.EmittableType, p_Template.EmittableAlignment) switch
    {
        (EmittableType.EmittableType_Quad, EmittableAlignment.EmittableAlignment_Screen) => EmittableType.ScreenAlignedQuad,
        // A quad stretched by its motion lies along its direction.
        (EmittableType.EmittableType_Quad, EmittableAlignment.EmittableAlignment_Direction or EmittableAlignment.EmittableAlignment_MotionStretch) => EmittableType.DirectionAlignedQuad,
        (EmittableType.EmittableType_Quad, EmittableAlignment.EmittableAlignment_World or EmittableAlignment.EmittableAlignment_WorldFixedRotation) => EmittableType.WorldAlignedQuad,
        (EmittableType.EmittableType_Quad, _) => EmittableType.Quad,
        (EmittableType.EmittableType_Mesh, _) => EmittableType.ParticleMesh,
        (EmittableType.EmittableType_Point, _) => EmittableType.Point,
        (EmittableType.EmittableType_Ribbon, _) => EmittableType.Trail,
        (var s_Type, _) => s_Type,
    };

    /// <summary>
    /// A sound wave's variations, each with its range of the wave's segments and subtitles, as
    /// Frostbite 2 has them.
    /// </summary>
    private static List<SoundWaveVariation> Variations(SoundWaveAsset p_Wave) => p_Wave.RuntimeVariations.Select(p_Variation => new SoundWaveVariation
    {
        Segments = p_Wave.Segments.Skip(p_Variation.FirstSegmentIndex).Take(p_Variation.SegmentCount).ToList(),
        Subtitles = p_Wave.Subtitles.Skip(p_Variation.FirstSubtitleIndex).Take(p_Variation.SubtitleCount).ToList(),
        PersistentDataSize = p_Variation.PersistentDataSize,
        ChunkIndex = p_Variation.ChunkIndex,
        FirstLoopSegmentIndex = p_Variation.FirstLoopSegmentIndex,
        LastLoopSegmentIndex = p_Variation.LastLoopSegmentIndex,
    }).ToList();

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public Conversion.ConversionRules? For(EngineType p_Target) => p_Target == EngineType.Frostbite2_0 ? s_ToFrostbite2 : null;
}
