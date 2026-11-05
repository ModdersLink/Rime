using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// The names a partition carries in its own tables: its type and field names, its string table,
/// and the name hashes its type and field descriptors state.
/// </summary>
public sealed record EbxNameTable(IReadOnlyList<string> TypeStrings, IReadOnlyList<string> ValueStrings, IReadOnlyList<uint> DescriptorHashes);

/// <summary>
/// Reads a partition's name tables straight from its bytes, without the types its instances need,
/// so every partition can be read, and the names instances state beside their hashes.
/// </summary>
public interface IEbxNameTable : IEngineInterface
{
    /// <summary>
    /// The partition's name tables, or null when it is not in the byte order this reads. Throws when
    /// the tables run past the end of the partition.
    /// </summary>
    EbxNameTable? Read(byte[] p_Partition);

    /// <summary>The names an instance states with their hash beside them (an object variation's name and name hash).</summary>
    IEnumerable<(uint Hash, string Name)> GetNamedHashes(DataContainerBase p_Instance);
}
