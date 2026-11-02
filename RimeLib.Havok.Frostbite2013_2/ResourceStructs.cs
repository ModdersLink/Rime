using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Havok.Frostbite;
using RimeLib.IO;

namespace RimeLib.Havok.Frostbite2013_2;

public class ResourceStructs : IResourceStructs
{
    public EngineType[] GetSupportedEngines() => [EngineType.Frostbite2013_2];

    public IReadOnlyCollection<ResourceType> Types { get; } = [ResourceType.HavokPhysicsData, ResourceType.HavokDestructionPhysicsData, ResourceType.HavokClothPhysicsData, ResourceType.RagdollResource];

    public byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta)
    {
        // Cloth: the two packfile sizes, then the packfiles. Ragdoll: the packfiles, their sizes in the meta.
        if (p_Type is ResourceType.HavokClothPhysicsData or ResourceType.RagdollResource)
        {
            var s_Cloth = p_Type == ResourceType.HavokClothPhysicsData;
            var s_Sizes = s_Cloth ? p_Data : p_Meta ?? throw new InvalidDataException("a ragdoll resource without meta");
            int s_Size32, s_Size64;
            using (var s_SizeReader = new RimeReader(new MemoryStream(s_Sizes, false)))
            {
                s_Size32 = s_SizeReader.ReadInt32();
                s_Size64 = s_SizeReader.ReadInt32();
            }
            var s_Pair = HavokPackfilePair.Read(p_Data, s_Cloth ? 8 : 0, s_Size32, s_Size64);
            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
            {
                if (s_Cloth)
                {
                    s_Writer.Write(s_Pair.Size32);
                    s_Writer.Write(s_Pair.Size64);
                }

                s_Pair.Write(s_Writer);
            }

            return s_Stream.ToArray();
        }

        using var s_Reader = new RimeReader(new MemoryStream(p_Data, false));
        if (!new HavokPhysicsData(s_Reader).Serialize(out var s_Written) || s_Written == null)
            throw new InvalidDataException("the physics data writer refused");
        return s_Written;
    }
}
