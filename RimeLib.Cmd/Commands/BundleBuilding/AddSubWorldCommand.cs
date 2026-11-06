using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds a reference to a sub-world's bundle to a level of this bundle, loaded as a template
    /// level loads one of its own: with that reference's inclusion settings (the game modes it
    /// loads in) and autoload.
    /// </summary>
    [CommandDescription("Adds a sub-world bundle to a level of this bundle, included as a template level includes one of its sub-worlds.")]
    public class AddSubWorldCommand : Command
    {
        [CommandArgument(Description = "The level partition of this bundle, e.g. levels/mp_prison/mp_prison.")]
        public string? Level { get; set; }

        [CommandArgument(Description = "The sub-world's bundle, e.g. Levels/MP_Prison/TeamDeathmatch.")]
        public string? Bundle { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the template level comes from (this bundle's engine).")]
        public int TemplateId { get; set; }

        [CommandArgument(Description = "The template level, e.g. levels/mp_subway/mp_subway.")]
        public string? TemplateLevel { get; set; }

        [CommandArgument(Description = "The template level's sub-world bundle to include it like, e.g. Levels/MP_Subway/TeamDeathmatch.")]
        public string? TemplateBundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Level) || string.IsNullOrWhiteSpace(Bundle) || string.IsNullOrWhiteSpace(TemplateLevel) || string.IsNullOrWhiteSpace(TemplateBundle))
            {
                p_Writer.WriteLine("usage: add_sub_world <level> <bundle> <template_id> <template_level> <template_bundle>");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            var s_Composer = Require<ILevelComposer>(s_Sb.EngineType, p_Writer);
            if (s_Composer == null)
                return false;

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            var s_LevelName = Level!.ToLowerInvariant();
            if (!BundlePartitionVariant.All(s_Bundle).TryGetValue(s_LevelName, out var s_LevelVariant))
            {
                p_Writer.WriteLine($"The bundle has no level '{Level}'.");
                return false;
            }

            if (!((BaseContext)s_Sb.Parent!).GetMounters().TryGetValue(TemplateId, out var s_Game)
                || !s_Game.TryGetPartition(TemplateLevel!, out var s_Mounted) || s_Mounted.FirstVariant is not { } s_TemplateVariant)
            {
                p_Writer.WriteLine($"No mounted level '{TemplateLevel}' in game {TemplateId}.");
                return false;
            }

            DatabasePartitionBase s_Built;
            string s_Summary;
            try
            {
                s_Built = s_Composer.AddSubWorld(s_Converter.FromPartitionObject(s_LevelName, s_LevelVariant),
                    s_Converter.FromPartitionObject(TemplateLevel!, s_TemplateVariant), TemplateBundle!, Bundle!, out s_Summary);
            }
            catch (InvalidDataException s_Ex)
            {
                p_Writer.WriteLine(s_Ex.Message);
                return false;
            }

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Built, s_Writer);
            s_Bundle.RemovePartition(s_LevelName);
            s_Bundle.AddRawPartitionBytes(s_LevelName, s_Stream.ToArray());
            p_Writer.WriteLine($"'{s_LevelName}' includes '{Bundle}' as '{TemplateLevel}' includes '{TemplateBundle}': {s_Summary}.");
            return true;
        }
    }
}
