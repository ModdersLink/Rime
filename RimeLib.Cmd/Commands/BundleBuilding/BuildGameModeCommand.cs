using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Serialization;
using RimeLib.Serialization.Conversion;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Builds a game mode's sub-world from a template sub-world of this engine: the template's
    /// setups (the references its sub-world links and feeds, a full_teamdeathmatch say) linked to
    /// the objects a source map's mode is linked to (spawns, combat area, zones), which converted
    /// partitions of this bundle hold, and fed the source mode's interface values. The template's
    /// own map content is left out.
    /// </summary>
    [CommandDescription("Builds a game mode's sub-world from a template sub-world's setups, linked to the objects a source map's mode is linked to.")]
    public class BuildGameModeCommand : Command
    {
        [CommandArgument(Description = "The sub-world to build, e.g. Levels/MP_Prison/TeamDeathmatch; its partition is the name in lower case.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the template comes from (this bundle's engine).")]
        public int TemplateId { get; set; }

        [CommandArgument(Description = "The template sub-world, e.g. levels/mp_subway/teamdeathmatch.")]
        public string? Template { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the map comes from.")]
        public int SourceId { get; set; }

        [CommandArgument(Description = "The source sub-world that links the mode's objects, e.g. levels/mp/mp_prison/deathmatch.")]
        public string? Source { get; set; }

        [CommandArgument(Description = "The bundle of the source mode's sub-world, which the source references, e.g. Levels/MP/MP_Prison/TeamDeathmatch0.")]
        public string? Mode { get; set; }

        [CommandArgument(Description = "Comma-separated converted partitions of this bundle that hold the linked objects.")]
        public string? Parts { get; set; }

        [CommandArgument(Description = "Comma-separated template=source field pairs, by name or id, where the source names a link or interface field differently, e.g. 698556373=FriendZones.", Optional = true)]
        public string? Fields { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Template) || string.IsNullOrWhiteSpace(Source)
                || string.IsNullOrWhiteSpace(Mode) || string.IsNullOrWhiteSpace(Parts))
            {
                p_Writer.WriteLine("usage: build_game_mode <name> <template_id> <template> <source_id> <source> <mode> <parts> [fields]");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Sb = (SbBuildingContext)s_Bundle.Parent!;
            var s_Mounters = ((BaseContext)s_Sb.Parent!).GetMounters();
            if (!s_Mounters.TryGetValue(TemplateId, out var s_TemplateGame) || !s_Mounters.TryGetValue(SourceId, out var s_SourceGame))
            {
                p_Writer.WriteLine("Mount the template's and the source's games first.");
                return false;
            }

            if (!TryParseFields(Fields, out var s_Fields))
            {
                p_Writer.WriteLine($"Could not read the field pairs '{Fields}'.");
                return false;
            }

            var s_Composer = Require<ILevelComposer>(s_Sb.EngineType, p_Writer);
            if (s_Composer == null)
                return false;

            if (Parse(s_TemplateGame, Template!) is not { } s_TemplatePartition)
            {
                p_Writer.WriteLine($"'{Template}' is not a partition of the template's game.");
                return false;
            }

            if (Parse(s_SourceGame, Source!) is not { } s_SourcePartition)
            {
                p_Writer.WriteLine($"'{Source}' is not a partition of the source's game.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<IPartitionConverter>(s_Sb.EngineType);
            var s_BundleParts = BundlePartitionVariant.All(s_Bundle);
            var s_Parts = new List<DatabasePartitionBase>();
            foreach (var s_Name in Parts!.Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                if (!s_BundleParts.TryGetValue(s_Name.ToLowerInvariant(), out var s_Variant))
                {
                    p_Writer.WriteLine($"The bundle has no partition '{s_Name}'.");
                    return false;
                }
                s_Parts.Add(s_Converter.FromPartitionObject(s_Name, s_Variant));
            }

            DatabasePartitionBase s_Built;
            try
            {
                s_Built = s_Composer.BuildGameMode(Name!, s_TemplateGame, s_TemplatePartition, s_SourceGame, s_SourcePartition, Mode!, s_Parts, s_Fields, p_Writer);
            }
            catch (InvalidDataException s_Ex)
            {
                p_Writer.WriteLine(s_Ex.Message);
                return false;
            }

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                EngineInterfaceRegistry.Create<IPartitionGenerator>(s_Sb.EngineType).Generate(s_Built, s_Writer);

            s_Bundle.RemovePartition(s_Built.Name);
            s_Bundle.AddRawPartitionBytes(s_Built.Name, s_Stream.ToArray());
            p_Writer.WriteLine($"Built '{s_Built.Name}' from '{Template}'.");
            return true;
        }

        private static bool TryParseFields(string? p_Fields, out Dictionary<int, int> p_Map)
        {
            p_Map = new Dictionary<int, int>();
            foreach (var s_Pair in (p_Fields ?? "").Split(',', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
            {
                var s_Sides = s_Pair.Split('=', StringSplitOptions.TrimEntries);
                if (s_Sides.Length != 2 || s_Sides.Any(string.IsNullOrEmpty))
                    return false;
                p_Map[FieldId(s_Sides[0])] = FieldId(s_Sides[1]);
            }
            return true;
        }

        /// <summary>A field by id, or by name as the engine hashes it.</summary>
        private static int FieldId(string p_Field) =>
            int.TryParse(p_Field, NumberStyles.Integer, CultureInfo.InvariantCulture, out var s_Id) ? s_Id : unchecked((int)RimeLib.Frostbite.Utils.HashQuick(p_Field));

        private static DatabasePartitionBase? Parse(IEngineMounter p_Game, string p_Name) =>
            p_Game.TryGetPartition(p_Name, out var s_Mounted) && s_Mounted.FirstVariant is { } s_Variant
                ? EngineInterfaceRegistry.Create<IPartitionConverter>(p_Game.GetEngineType()).FromPartitionObject(p_Name, s_Variant)
                : null;
    }
}
