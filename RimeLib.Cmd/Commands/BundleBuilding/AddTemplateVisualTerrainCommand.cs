using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Resources;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Gives a terrain the visuals of one of this engine's own: its visual terrain, renamed to draw
    /// the terrain's streaming tree, without mesh scattering, and decals. Frostbite 2 draws terrain and
    /// its decals with shaders generated per level, looked up by name, so the terrain draws with the
    /// template's layers once the template's shaders are in the level's shader database
    /// (build_shader_database with the template's terrain as an always-held prefix). The decals are the
    /// terrain's own, converted from its engine and drawn with the template's decal shaders alike in
    /// name, or decals with no geometry when none are given.
    /// The terrain's mask, when the bundle holds its streaming tree, is given the template's layers:
    /// the engine draws a part of the ground with the first combination holding every layer there, so
    /// each layer becomes the template layer that leaves the most nodes such a combination with a
    /// surface draw, and an exact one where it can.
    /// </summary>
    [CommandDescription("Gives a terrain a template terrain's visuals: its visual terrain, renamed and without scattering, and the terrain's own decals drawn with the template's decal shaders (or empty decals).")]
    public class AddTemplateVisualTerrainCommand : Command
    {
        [CommandArgument(Description = "The terrain, as its TerrainData names it, e.g. Levels/MP_Prison/MP_Prison_Terrain_8k/MP_Prison_Terrain_8k.")]
        public string? Terrain { get; set; }

        [CommandArgument(Description = "The template's visual terrain resource, e.g. levels/mp_007/terrain/mp_007.visual.")]
        public string? Template { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the template is in.")]
        public int Id { get; set; }

        [CommandArgument(Description = "The terrain's own decals resource, e.g. levels/mp/mp_prison/mp_prison_terrain_8k/mp_prison_terrain_8k.decals. Omit for decals with no geometry.", Optional = true)]
        public string? Decals { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game the decals are in.", Optional = true)]
        public int DecalsId { get; set; }

        [CommandArgument(Description = "Decal shaders chosen by hand, as pattern=shader pairs separated by ';': a decal whose shader contains the pattern draws with the template's shader, or is left out when it is empty.", Optional = true)]
        public string? DecalShaders { get; set; }

        [CommandArgument(Description = "The terrain's own visual terrain resource in the decals' game, e.g. levels/mp/mp_prison/mp_prison_terrain_8k/mp_prison_terrain_8k: the terrain then draws with its own layers and shaders (add_converted_shaders), only the template's default surface shader and decal shaders kept.", Optional = true)]
        public string? Visual { get; set; }

        [CommandArgument(Description = "The terrain's own layer combinations resource beside its visual terrain, e.g. levels/mp/mp_prison/mp_prison_terrain_8k/mp_prison_terrain_8k.layercombinations_win32.", Optional = true)]
        public string? LayerCombinations { get; set; }

        [CommandArgument(Description = "Names to move in its own shaders' names, as 'from=to', e.g. 'levels/mp/mp_prison/=Levels/MP_Prison/'.", Optional = true)]
        public string? MoveNames { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Terrain) || string.IsNullOrWhiteSpace(Template))
            {
                p_Writer.WriteLine("usage: add_template_visual_terrain <terrain> <template> <id> [decals] [decals id] [decal shaders] [visual] [layer combinations] [move]");
                return false;
            }

            var s_Bundle = (BundleBuildingContext)p_Context;
            var s_Visuals = Require<ITemplateVisualTerrain>(((SbBuildingContext)s_Bundle.Parent!).EngineType, p_Writer);
            if (s_Visuals == null)
                return false;

            var s_Mounters = ((BaseContext)s_Bundle.Parent!.Parent!).GetMounters();
            if (!s_Mounters.TryGetValue(Id, out var s_Game)
                || !s_Game.TryGetResource(Template!.ToLowerInvariant(), out var s_Template))
            {
                p_Writer.WriteLine($"Game {Id} has no resource '{Template}'.");
                return false;
            }

            IEngineMounter? s_OwnGame = null;
            IMountedObject<IResourceVariant>? s_OwnVisual = null, s_OwnCombinations = null, s_OwnDecals = null;
            if (!string.IsNullOrWhiteSpace(Visual)
                && (!s_Mounters.TryGetValue(DecalsId, out s_OwnGame)
                    || !s_OwnGame.TryGetResource(Visual!.ToLowerInvariant(), out s_OwnVisual)
                    || string.IsNullOrWhiteSpace(LayerCombinations)
                    || !s_OwnGame.TryGetResource(LayerCombinations.ToLowerInvariant(), out s_OwnCombinations)))
            {
                p_Writer.WriteLine($"Game {DecalsId} has no visual terrain '{Visual}' with layer combinations '{LayerCombinations}'.");
                return false;
            }

            if (!string.IsNullOrWhiteSpace(Decals)
                && (!s_Mounters.TryGetValue(DecalsId, out s_OwnGame) || !s_OwnGame.TryGetResource(Decals!.ToLowerInvariant(), out s_OwnDecals)))
            {
                p_Writer.WriteLine($"Game {DecalsId} has no resource '{Decals}'.");
                return false;
            }

            var s_Resources = s_Visuals.Build(new TemplateVisualTerrainRequest
            {
                Terrain = Terrain!,
                TemplateGame = s_Game,
                Template = s_Template.FirstVariant,
                TemplateName = Template!,
                BundleResources = s_Bundle.GetResources(),
                OwnEngine = s_OwnGame?.GetEngineType() ?? s_Game.GetEngineType(),
                OwnVisual = s_OwnVisual?.FirstVariant,
                OwnLayerCombinations = s_OwnCombinations?.FirstVariant,
                OwnDecals = s_OwnDecals?.FirstVariant,
                DecalShaders = DecalShaders,
                MoveNames = MoveNames,
            }, p_Writer);

            if (s_Resources == null)
                return false;

            foreach (var s_Resource in s_Resources)
                s_Bundle.AddGeneratedResource(s_Resource.Name, s_Resource.Data, s_Resource.Type, s_Resource.Meta);
            return true;
        }
    }
}
