using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite2_0.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2_0;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2_0, EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } =
        [ResourceType.HavokPhysicsData, ResourceType.HavokDestructionPhysicsData, ResourceType.HavokClothPhysicsData, ResourceType.RagdollResource];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        IFbSerializable s_Struct;
        using (var s_Reader = new RimeReader(new MemoryStream(p_Data, false)))
            s_Struct = p_Type switch
            {
                ResourceType.HavokClothPhysicsData => new HavokClothPhysicsData(s_Reader),
                ResourceType.RagdollResource => ReadRagdoll(s_Reader, p_Meta ?? throw new InvalidDataException("a ragdoll resource without meta")),
                _ => new HavokPhysicsData(s_Reader),
            };

        if (!s_Struct.Serialize(out var s_Written))
            throw new InvalidDataException($"the {p_Type} writer refused");
        return s_Written;
    }

    /// <summary>A RagdollResource is a packfile pair whose sizes are the first two words of its meta.</summary>
    private static HavokPackfilePair ReadRagdoll(RimeReader p_Reader, byte[] p_Meta)
    {
        using var s_Meta = new RimeReader(new MemoryStream(p_Meta, false));
        var s_Pair = new HavokPackfilePair(s_Meta.ReadInt32(), s_Meta.ReadInt32());
        s_Pair.Deserialize(p_Reader);
        return s_Pair;
    }
}
