using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Havok.Frostbite2013_2;

/// <summary>
/// Reads the Frostbite header of a BF4 HavokPhysicsData resource, which comes before the Havok
/// packfiles (its size is the first value of the resource meta): the part count, then four arrays,
/// each a count and an offset into the resource (part translations, local bounding boxes, per-part
/// material indices, material flags and indices). The material values are packed as MaterialDecl's.
/// </summary>
public class HavokMaterials : IHavokMaterials
{
    private const int c_MaterialFlagsAndIndicesSlot = 3;
    private const int c_SlotSize = 12;

    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

    public IReadOnlyList<uint> GetMaterialFlagsAndIndices(IResourceObject p_Resource)
    {
        byte[] s_Data;
        using (var s_Reader = p_Resource.GetReader())
            s_Data = s_Reader.ReadBytes((int)s_Reader.Length);

        var s_Slot = 4 + c_MaterialFlagsAndIndicesSlot * c_SlotSize;
        if (s_Data.Length < s_Slot + c_SlotSize)
            throw new InvalidDataException("HavokPhysicsData is too short for its header.");

        var s_Count = BitConverter.ToUInt32(s_Data, s_Slot);
        var s_Offset = BitConverter.ToUInt64(s_Data, s_Slot + 4);
        if (s_Count > 0 && s_Offset + (ulong)s_Count * 4 > (ulong)s_Data.Length)
            throw new InvalidDataException($"HavokPhysicsData's {s_Count} material(s) at {s_Offset} overrun the resource.");

        var s_Materials = new uint[s_Count];
        for (var i = 0; i < s_Count; ++i)
            s_Materials[i] = BitConverter.ToUInt32(s_Data, (int)s_Offset + i * 4);
        return s_Materials;
    }
}
