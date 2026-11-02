using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace RimeLib.Serialization.Frostbite2_0;

public class PartitionImportReader : IPartitionImportReader
{
    public EngineType[] GetSupportedEngines()
    {
        return new[] { EngineType.Frostbite2_0 };
    }

    public (GUID Partition, IReadOnlyCollection<GUID> Imports) ReadImports(IObjectVariant p_Variant)
    {
        return EbxReader.ReadPartitionImports(p_Variant);
    }

    public string? ReadPrimaryTypeName(IObjectVariant p_Variant) => EbxReader.ReadPrimaryTypeName(p_Variant);
}
