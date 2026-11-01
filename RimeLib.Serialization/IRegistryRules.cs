using System;
using System.Collections.Generic;
using RimeLib.Frostbite;

namespace RimeLib.Serialization;

/// <summary>
/// The rules by which a level's network registries are filled: for an instance of the level's
/// closure, which registries list it (or the assets it points at).
/// </summary>
public interface IRegistryRules : IEngineInterface
{
    /// <summary>
    /// The registry entries of a closure (without the registries themselves), as kind (named as
    /// <see cref="ILevelIndexes"/> names them) and entry, possibly repeated. <paramref name="p_Resolve"/>
    /// looks up the instance a reference points at.
    /// </summary>
    IEnumerable<(string Kind, CtrRefBase Entry)> GetEntries(IReadOnlyList<DataContainerBase> p_Closure, Func<CtrRefBase, DataContainerBase?> p_Resolve);

    /// <summary>
    /// The sub-world bundles an instance includes (by bundle name). The level's own registry also
    /// lists what these sub-worlds' registries list, as far as it ships in a bundle loaded with the
    /// level (see <see cref="GetLevelBundles"/>).
    /// </summary>
    IEnumerable<string> GetSubWorldBundles(DataContainerBase p_Instance);

    /// <summary>
    /// Whether what an instance references is not used through it (an interface descriptor's field
    /// values), so it doesn't make those referenced instances part of the level.
    /// </summary>
    bool IsDescriptionOnly(DataContainerBase p_Instance);

    /// <summary>
    /// The bundles loaded with a level (its own bundle and the like), by the level partition's name.
    /// </summary>
    IEnumerable<string> GetLevelBundles(string p_LevelPartition);
}
