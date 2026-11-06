using System.Collections.Generic;
using System.IO;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;

namespace RimeLib.Serialization.Conversion;

/// <summary>
/// Puts a converted level's parts together the way a level of this engine has them: its
/// sub-worlds and their game modes, modelled on a template level of the engine.
/// </summary>
public interface ILevelComposer : IEngineInterface
{
    /// <summary>
    /// The level partition with a reference to the sub-world bundle <paramref name="p_Bundle"/>,
    /// included (in which game modes it loads, whether it autoloads) as the template level includes
    /// its sub-world <paramref name="p_TemplateBundle"/>. <paramref name="p_Summary"/> names the
    /// inclusion options. Throws <see cref="InvalidDataException"/> when the level or the template's
    /// sub-world reference is not there.
    /// </summary>
    DatabasePartitionBase AddSubWorld(DatabasePartitionBase p_Level, DatabasePartitionBase p_Template, string p_TemplateBundle, string p_Bundle, out string p_Summary);

    /// <summary>
    /// A game mode's sub-world named <paramref name="p_Name"/>: the template sub-world's setups
    /// linked to the objects <paramref name="p_Parts"/> hold that the source sub-world links its
    /// reference to the mode's bundle <paramref name="p_Mode"/> to, and its interface fed the
    /// source mode's values. <paramref name="p_Fields"/> maps a template field id to the source's
    /// where they differ. Throws <see cref="InvalidDataException"/> when the template is not a
    /// sub-world or the source references no such mode.
    /// </summary>
    DatabasePartitionBase BuildGameMode(string p_Name, IEngineMounter p_TemplateGame, DatabasePartitionBase p_Template,
        IEngineMounter p_SourceGame, DatabasePartitionBase p_Source, string p_Mode, IReadOnlyList<DatabasePartitionBase> p_Parts,
        IReadOnlyDictionary<int, int> p_Fields, TextWriter p_Log);
}
