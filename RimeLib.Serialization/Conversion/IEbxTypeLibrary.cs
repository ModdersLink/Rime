using System;
using System.Collections.Generic;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization.Conversion;

/// <summary>An engine's EBX types, and partitions of them built from instances.</summary>
public interface IEbxTypeLibrary : IEngineInterface
{
    /// <summary>The engine's container, struct or enum type of this name, or none.</summary>
    Type? FindType(string p_Name);

    /// <summary>A partition of <paramref name="p_Instances"/>, each with a GUID id.</summary>
    DatabasePartitionBase CreatePartition(string p_Name, GUID p_PartitionGuid, GUID p_PrimaryInstanceGuid, IReadOnlyList<DataContainerBase> p_Instances);
}
