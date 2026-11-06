using System;
using System.Collections.Generic;
using System.IO;
using fb;
using RimeLib.Animation.Frostbite;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Animation.Frostbite2_0;

/// <summary>Frostbite 2's AnimationSet banks; a bank of another packaging keeps package meta, which is not written.</summary>
public class AssetBankStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.AssetBank];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        var s_Packaging = (AntPackagingType)AnimationSetBank.ReadPackagingType(p_Data);
        if (s_Packaging != AntPackagingType.AntPackagingType_AnimationSet)
            throw new NotSupportedException($"a {s_Packaging} bank keeps package meta, which is not written");

        var s_Bank = new AnimationSetBank();
        s_Bank.Deserialize(p_Data);
        if (!s_Bank.Serialize(out var s_Written))
            throw new InvalidDataException("the bank writer refused");
        return s_Written;
    }
}
