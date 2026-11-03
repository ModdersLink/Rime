using System.Collections.Generic;
using RimeLib.Frostbite;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Serialization.Frostbite2013_2;

public class ConversionRules : IConversionRules
{
    /// <summary>To Frostbite 2, which names some enum values differently and keeps single values where this engine has structs.</summary>
    private static readonly Conversion.ConversionRules s_ToFrostbite2 = new()
    {
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
    };

    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public Conversion.ConversionRules? For(EngineType p_Target) => p_Target == EngineType.Frostbite2_0 ? s_ToFrostbite2 : null;
}
