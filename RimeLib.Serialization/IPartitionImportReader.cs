using System.Collections.Generic;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Serialization;

/// <summary>
/// Reads which partitions a partition imports without parsing it: only the header and the import
/// table, which are at the start of the ebx. Cheap enough to run over every partition of a game, for
/// questions like "who outside this level refers to this asset".
/// </summary>
public interface IPartitionImportReader : IEngineInterface
{
    /// <summary>
    /// The partition's GUID and the distinct GUIDs of the partitions it imports from.
    /// </summary>
    (GUID Partition, IReadOnlyCollection<GUID> Imports) ReadImports(IObjectVariant p_Variant);
}
