using System.Collections.Generic;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// Fields an engine's build sets from the rest of the partition, which a partition converted to
/// the engine has to have set again.
/// </summary>
public interface IDerivedFields : IEngineInterface
{
    /// <summary>The fields <see cref="Derive"/> sets, by type and field.</summary>
    IReadOnlySet<string> Fields { get; }

    /// <summary>Sets the fields on each instance of the partition, counting in the report what it cannot derive.</summary>
    void Derive(DatabasePartitionBase p_Partition, ConversionReport p_Report);

    /// <summary>
    /// Sets the fields that depend on other partitions, such as those of a level's layers, on
    /// partitions converted together.
    /// </summary>
    void DeriveAcross(IReadOnlyCollection<DatabasePartitionBase> p_Partitions, ConversionReport p_Report);
}
