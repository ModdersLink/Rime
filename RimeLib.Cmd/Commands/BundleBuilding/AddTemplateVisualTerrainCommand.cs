using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
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
        private const string c_Visual = ".visual";
        private const string c_StreamingTree = ".StreamingTree";
        private const string c_Decals = ".Decals";

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
            if (!((BaseContext)s_Bundle.Parent!.Parent!).GetMounters().TryGetValue(Id, out var s_Game)
                || !s_Game.TryGetResource(Template!.ToLowerInvariant(), out var s_Template))
            {
                p_Writer.WriteLine($"Game {Id} has no resource '{Template}'.");
                return false;
            }

            VisualTerrain s_Visual;
            // Some variants hand back a big-endian reader; the resource is little-endian on PC.
            using (var s_Reader = s_Template.FirstVariant.GetReader())
            {
                s_Reader.Endianness = Endianness.LittleEndian;
                s_Visual = new VisualTerrain(s_Reader);
            }

            var s_TemplateDecals = s_Visual.DecalsResourceName;
            s_Visual.StreamingTreeResourceName = Terrain + c_StreamingTree;
            s_Visual.DecalsResourceName = Terrain + c_Decals;
            foreach (var s_Layer in s_Visual.Layers)
                s_Layer.ScatteringTypes = [];

            if (!s_Visual.Serialize(out var s_VisualData))
            {
                p_Writer.WriteLine("The visual terrain did not serialize.");
                return false;
            }

            var s_Name = Terrain!.ToLowerInvariant();
            if (!string.IsNullOrWhiteSpace(Visual))
            {
                if (OwnVisual(s_Bundle, s_Visual, p_Writer) is not { } s_Own)
                    return false;
                s_VisualData = s_Own;
            }

            s_Bundle.AddGeneratedResource(s_Name + c_Visual, s_VisualData, ResourceType.VisualTerrain, null);
            if (string.IsNullOrWhiteSpace(Visual))
                MapLayers(s_Bundle, s_Name + c_StreamingTree.ToLowerInvariant(), s_Visual, p_Writer);

            if (!s_Game.TryGetResource(s_TemplateDecals.ToLowerInvariant(), out var s_DecalsResource))
            {
                p_Writer.WriteLine($"Game {Id} has no decals '{s_TemplateDecals}' for the template.");
                return false;
            }

            var s_Converter = EngineInterfaceRegistry.Create<ITerrainDecalsConverter>(EngineType.Frostbite2_0);
            TerrainDecalsResource s_TemplateDecalsData;
            using (var s_Reader = s_DecalsResource.FirstVariant.GetReader())
                s_TemplateDecalsData = s_Converter.Read(s_Reader);

            var s_Decals = new TerrainDecalsBuilder(s_TemplateDecalsData).Build();
            if (!string.IsNullOrWhiteSpace(Decals))
            {
                if (OwnDecals(s_Bundle, s_TemplateDecalsData, p_Writer) is not { } s_Own)
                    return false;
                s_Decals = s_Own;
            }

            var s_Stream = new MemoryStream();
            using (var s_Writer = new RimeWriter(s_Stream))
                s_Converter.Write(s_Writer, s_Decals);
            s_Bundle.AddGeneratedResource(s_Name + c_Decals.ToLowerInvariant(), s_Stream.ToArray(), ResourceType.TerrainDecals, null);

            // The permutations sit beside the folder of the default surface shader (Levels/MP_007/Terrain/MP_007__...).
            var s_Folder = s_Visual.SurfaceShaderName.ToLowerInvariant();
            s_Folder = s_Folder[..s_Folder.LastIndexOf('/')];
            s_Folder = s_Folder[..(s_Folder.LastIndexOf('/') + 1)];
            p_Writer.WriteLine(string.IsNullOrWhiteSpace(Visual)
                ? $"'{s_Name}' draws with '{Template}''s {s_Visual.Layers.Length} layer(s) and {s_Visual.TerrainLayerCombinationDraws.Length} combination(s); " +
                  $"hold its shaders under '{s_Folder}' in the shader database."
                : $"'{s_Name}' draws with its own layers and '{Template}''s default surface shader; hold that under '{s_Folder}' in the shader database.");
            return true;
        }

        /// <summary>
        /// The terrain's own visual terrain in this engine's layout, its layer combinations drawn with
        /// its own 2d shaders under their moved names; its mask keeps its layers.
        /// </summary>
        private byte[]? OwnVisual(BundleBuildingContext p_Bundle, VisualTerrain p_Template, TextWriter p_Writer)
        {
            if (!((BaseContext)p_Bundle.Parent!.Parent!).GetMounters().TryGetValue(DecalsId, out var s_Game)
                || !s_Game.TryGetResource(Visual!.ToLowerInvariant(), out var s_Resource)
                || string.IsNullOrWhiteSpace(LayerCombinations)
                || !s_Game.TryGetResource(LayerCombinations.ToLowerInvariant(), out var s_Combinations))
            {
                p_Writer.WriteLine($"Game {DecalsId} has no visual terrain '{Visual}' with layer combinations '{LayerCombinations}'.");
                return null;
            }

            var s_Engine = s_Game.GetEngineType();
            if (!EngineInterfaceRegistry.IsSupported<ITerrainConverter>(s_Engine))
            {
                p_Writer.WriteLine($"Visual terrain of {s_Engine} is not converted.");
                return null;
            }

            var s_Move = (MoveNames ?? "").Split('=', 2);
            string Moved(string p_Name) =>
                s_Move.Length == 2 && p_Name.StartsWith(s_Move[0], StringComparison.OrdinalIgnoreCase) ? s_Move[1] + p_Name[s_Move[0].Length..] : p_Name;

            var s_Data = EngineInterfaceRegistry.Create<ITerrainConverter>(s_Engine).ConvertVisualTerrain(s_Resource.FirstVariant, s_Combinations.FirstVariant,
                p_Template.StreamingTreeResourceName, p_Template.DecalsResourceName, p_Template.SurfaceShaderName, Moved, false, EngineType.Frostbite2_0, p_Writer);
            var s_Converted = new VisualTerrain();
            s_Converted.Deserialize(s_Data);
            var s_Folders = s_Converted.TerrainLayerCombinationDraws
                .SelectMany(p_D => p_D.Surface2dDrawMethods).Select(p_M => p_M.ShaderName.ToLowerInvariant())
                .Select(p_N => p_N[..(p_N.LastIndexOf('/') + 1)]).Distinct();
            p_Writer.WriteLine($"Own layers: hold their shaders under '{string.Join("', '", s_Folders)}' in the shader database (add_converted_shaders); the mask keeps its layers.");
            var s_Added = AddExactSubsets(s_Converted);
            p_Writer.WriteLine($"Own layers: {s_Added} combination(s) added for layer sets only a larger one held.");
            return s_Converted.Serialize(out var s_Exact) ? s_Exact : null;
        }

        /// <summary>
        /// Gives each set of layers a combination's layers include a combination of its own, the
        /// combinations fewest layers first, each pass masking only its combination's layers: the
        /// engine draws a tile with the first combination holding its layers and expects to find each
        /// layer a pass masks there. A new one
        /// draws with the shader of the smallest combination holding it, masking only its layers;
        /// one whose dropped layers the shader masks last draws exactly.
        /// </summary>
        private static int AddExactSubsets(VisualTerrain p_Visual)
        {
            var s_Draws = p_Visual.TerrainLayerCombinationDraws.Where(p_D => p_D.Surface2dDrawMethods.Length > 0).ToList();
            // Each pass masks only its own combination's layers, in ascending order like the layers.
            foreach (var s_Draw in p_Visual.TerrainLayerCombinationDraws)
            {
                s_Draw.TerrainLayerIndices = s_Draw.TerrainLayerIndices.Order().ToArray();
                foreach (var s_Method in s_Draw.Surface2dDrawMethods)
                    s_Method.MaskedTerrainLayerIndices = s_Method.MaskedTerrainLayerIndices.Where(s_Draw.TerrainLayerIndices.Contains).ToArray();
            }

            var s_Have = s_Draws.Select(p_D => Key(p_D.TerrainLayerIndices)).ToHashSet();
            var s_Added = new List<TerrainLayerCombinationDraw>();
            foreach (var s_Draw in s_Draws.OrderBy(p_D => p_D.TerrainLayerIndices.Length))
            {
                var s_Layers = s_Draw.TerrainLayerIndices.Order().ToArray();
                for (var s_Bits = 1; s_Bits < 1 << s_Layers.Length; ++s_Bits)
                {
                    var s_Subset = s_Layers.Where((_, i) => (s_Bits >> i & 1) != 0).ToArray();
                    if (!s_Have.Add(Key(s_Subset)))
                        continue;

                    // The smallest holder whose masked layers keep their slots, else the smallest.
                    var s_Holder = s_Draws.Where(p_D => s_Subset.All(p_D.TerrainLayerIndices.Contains))
                        .OrderBy(p_D => p_D.Surface2dDrawMethods.All(p_M => MasksFirst(p_M.MaskedTerrainLayerIndices, s_Subset)) ? 0 : 1)
                        .ThenBy(p_D => p_D.TerrainLayerIndices.Length).First();
                    s_Added.Add(new TerrainLayerCombinationDraw
                    {
                        TerrainLayerIndices = s_Subset,
                        MeshScatteringMaskScaleLevelEnd = s_Holder.MeshScatteringMaskScaleLevelEnd,
                        Surface2dDrawMethods = s_Holder.Surface2dDrawMethods.Select(p_M => new Surface2dDrawMethod
                        {
                            DrawPassType = p_M.DrawPassType,
                            MaskedTerrainLayerIndices = p_M.MaskedTerrainLayerIndices.Where(s_Subset.Contains).ToArray(),
                            ShaderName = p_M.ShaderName,
                            DestructionMaskEnable = p_M.DestructionMaskEnable,
                        }).ToArray(),
                    });
                }
            }

            p_Visual.TerrainLayerCombinationDraws = p_Visual.TerrainLayerCombinationDraws.Concat(s_Added)
                .OrderBy(p_D => p_D.Surface2dDrawMethods.Length > 0 ? p_D.TerrainLayerIndices.Length : int.MaxValue).ToArray();
            return s_Added.Count;

            static string Key(IEnumerable<byte> p_Layers) => string.Join(',', p_Layers.Order());
            static bool MasksFirst(byte[] p_Masked, byte[] p_Subset) =>
                p_Masked.TakeWhile(p_Subset.Contains).Count() == p_Masked.Count(p_Subset.Contains);
        }

        /// <summary>Gives the mask of the bundle's streaming tree the template's layers.</summary>
        private static void MapLayers(BundleBuildingContext p_Bundle, string p_StreamingTree, VisualTerrain p_Template, TextWriter p_Writer)
        {
            if (!p_Bundle.GetResources().TryGetValue(p_StreamingTree, out var s_Resource))
            {
                p_Writer.WriteLine($"The bundle has no '{p_StreamingTree}'; its mask keeps its layers.");
                return;
            }

            var s_Tree = new TerrainStreamingTree();
            using (var s_Reader = s_Resource.GetReader())
                s_Tree.Deserialize(s_Reader.ReadBytes((int)s_Reader.Length));
            if (s_Tree.TerrainMaskTree is not TerrainMaskTree { RootNode: TerrainMaskTree.Node s_Root })
                return;

            var s_Nodes = new List<TerrainMaskTree.Node>();
            void Collect(TerrainMaskTree.Node p_Node)
            {
                s_Nodes.Add(p_Node);
                foreach (var s_Child in p_Node.Children)
                    Collect((TerrainMaskTree.Node)s_Child);
            }
            Collect(s_Root);

            var s_Sets = s_Nodes.Where(p_N => p_N.Subtiles.Count > 0)
                .GroupBy(p_N => string.Join(',', p_N.Subtiles.Select(p_S => p_S.TerrainLayerIndex).Distinct().Order()))
                .Select(p_G => (Layers: p_G.First().Subtiles.Select(p_S => p_S.TerrainLayerIndex).Distinct().ToArray(), Count: p_G.Count()))
                .ToList();
            var s_Source = s_Sets.SelectMany(p_S => p_S.Layers).Distinct().Order().ToArray();
            var s_Draws = p_Template.TerrainLayerCombinationDraws.Where(p_D => p_D.Surface2dDrawMethods.Length > 0).Select(p_D => p_D.TerrainLayerIndices.ToHashSet()).ToList();
            var s_Candidates = s_Draws.SelectMany(p_D => p_D).Distinct().Order().ToArray();
            if (s_Source.Length > s_Candidates.Length)
            {
                p_Writer.WriteLine($"The terrain has {s_Source.Length} layers, the template's combinations {s_Candidates.Length}; its mask keeps its layers.");
                return;
            }

            // Every injective assignment, scored by the nodes left a combination, then by those left an exact one.
            var s_Best = (Covered: -1, Exact: -1, Map: Array.Empty<byte>());
            var s_Map = new byte[s_Source.Length];
            var s_Used = new bool[s_Candidates.Length];
            void Assign(int p_Index)
            {
                if (p_Index == s_Source.Length)
                {
                    int s_Covered = 0, s_Exact = 0;
                    foreach (var (s_Layers, s_Count) in s_Sets)
                    {
                        var s_Image = s_Layers.Select(p_L => s_Map[Array.IndexOf(s_Source, p_L)]).ToHashSet();
                        if (s_Draws.Any(p_D => p_D.IsSupersetOf(s_Image)))
                            s_Covered += s_Count;
                        if (s_Draws.Any(p_D => p_D.SetEquals(s_Image)))
                            s_Exact += s_Count;
                    }

                    if (s_Covered > s_Best.Covered || (s_Covered == s_Best.Covered && s_Exact > s_Best.Exact))
                        s_Best = (s_Covered, s_Exact, (byte[])s_Map.Clone());
                    return;
                }

                for (var i = 0; i < s_Candidates.Length; ++i)
                {
                    if (s_Used[i])
                        continue;

                    s_Used[i] = true;
                    s_Map[p_Index] = s_Candidates[i];
                    Assign(p_Index + 1);
                    s_Used[i] = false;
                }
            }
            Assign(0);

            foreach (var s_Subtile in s_Nodes.SelectMany(p_N => p_N.Subtiles))
                s_Subtile.TerrainLayerIndex = s_Best.Map[Array.IndexOf(s_Source, s_Subtile.TerrainLayerIndex)];

            if (!s_Tree.Serialize(out var s_Data))
            {
                p_Writer.WriteLine("The streaming tree did not serialize; its mask keeps its layers.");
                return;
            }

            p_Bundle.AddGeneratedResource(p_StreamingTree, s_Data, ResourceType.TerrainStreamingTree, s_Resource.TryGetMeta(out var s_Meta) ? s_Meta : null);
            var s_NodeCount = s_Sets.Sum(p_S => p_S.Count);
            p_Writer.WriteLine($"Mask layers {string.Join(", ", s_Source.Select((p_L, i) => $"{p_L}->{s_Best.Map[i]}"))}: " +
                $"{s_Best.Covered} of {s_NodeCount} node(s) drawn by a template combination, {s_Best.Exact} by an exact one.");
        }

        /// <summary>The terrain's own decals in this engine's layout, drawn with the template's decal shaders.</summary>
        private TerrainDecalsResource? OwnDecals(BundleBuildingContext p_Bundle, TerrainDecalsResource p_Template, TextWriter p_Writer)
        {
            if (!((BaseContext)p_Bundle.Parent!.Parent!).GetMounters().TryGetValue(DecalsId, out var s_Game)
                || !s_Game.TryGetResource(Decals!.ToLowerInvariant(), out var s_Resource))
            {
                p_Writer.WriteLine($"Game {DecalsId} has no resource '{Decals}'.");
                return null;
            }

            var s_Engine = s_Game.GetEngineType();
            TerrainDecalsResource s_Source;
            using (var s_Reader = s_Resource.FirstVariant.GetReader())
                s_Source = EngineInterfaceRegistry.Create<ITerrainDecalsConverter>(s_Engine).Read(s_Reader);

            if (s_Engine != EngineType.Frostbite2_0)
            {
                if (!EngineInterfaceRegistry.IsSupported<ITerrainConverter>(s_Engine))
                {
                    p_Writer.WriteLine($"Terrain decals of {s_Engine} are not converted.");
                    return null;
                }

                s_Source = EngineInterfaceRegistry.Create<ITerrainConverter>(s_Engine).ConvertDecals(s_Source, EngineType.Frostbite2_0, p_Writer);
            }

            var s_Overrides = (DecalShaders ?? "").Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(p_Pair => p_Pair.Split('=', 2, StringSplitOptions.TrimEntries))
                .Select(p_Pair => (p_Pair[0], p_Pair.Length > 1 ? p_Pair[1] : ""))
                .ToList();
            var s_Shaders = new TemplateDecalShaders(p_Template, s_Overrides);

            var s_Blocks = new List<(DecalGeometry Geometry, DecalBlock Block, DecalGeometryKind Kind, (string Shader, string ZOnlyShader) Target)>();
            var s_Matches = new SortedDictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var (s_Kind, s_Geometry) in new[] { (DecalGeometryKind.Decal2d, s_Source.Geometry2d), (DecalGeometryKind.Decal3d, s_Source.Geometry3d) })
            {
                foreach (var s_Block in s_Geometry.Blocks)
                {
                    var s_Match = s_Shaders.Match(s_Kind, s_Block.SurfaceShaderName);
                    s_Matches[$"{s_Kind} {s_Block.SurfaceShaderName}"] = s_Match?.Shader ?? "(left out)";
                    if (s_Match is not { } s_Target)
                        continue;

                    s_Blocks.Add((s_Geometry, s_Block, s_Kind, s_Target));

                    // The template draws its 3d decals far away as 2d ones.
                    if (s_Kind == DecalGeometryKind.Decal3d && s_Shaders.Counterpart2d(s_Target.Shader) is { } s_Target2d)
                        s_Blocks.Add((s_Geometry, s_Block, DecalGeometryKind.Decal2d, s_Target2d));
                }
            }

            // Blocks drawn with one shader follow each other.
            var s_Builder = new TerrainDecalsBuilder(p_Template);
            foreach (var (s_Geometry, s_Block, s_Kind, s_Target) in s_Blocks.OrderBy(p_Entry => p_Entry.Target.Shader, StringComparer.OrdinalIgnoreCase))
            {
                var (s_Vertices, s_Indices) = TerrainDecalsBuilder.BlockGeometry(s_Geometry, s_Block);
                if (s_Kind == DecalGeometryKind.Decal2d && s_Geometry == s_Source.Geometry3d)
                    s_Builder.AddAs2d(s_Block, s_Target.Shader, s_Target.ZOnlyShader, s_Vertices, s_Indices);
                else
                    s_Builder.Add(s_Kind, s_Block, s_Target.Shader, s_Target.ZOnlyShader, s_Vertices, s_Indices);
            }

            foreach (var (s_From, s_To) in s_Matches)
                p_Writer.WriteLine($"  {s_From} -> {s_To}");

            var s_Decals = s_Builder.Build();
            var s_Folders = s_Decals.Geometry2d.Blocks.Concat(s_Decals.Geometry3d.Blocks)
                .Select(p_Block => p_Block.SurfaceShaderName.ToLowerInvariant())
                .Select(p_Name => p_Name[..(p_Name.LastIndexOf('/') + 1)])
                .Distinct();
            p_Writer.WriteLine($"Decals: {s_Decals.Geometry2d.BlockCount} 2d and {s_Decals.Geometry3d.BlockCount} 3d block(s); " +
                $"hold their shaders under '{string.Join("', '", s_Folders)}' in the shader database.");
            return s_Decals;
        }
    }
}
