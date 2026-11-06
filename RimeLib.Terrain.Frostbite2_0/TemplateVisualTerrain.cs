using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Content.Frostbite;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Terrain.Frostbite2_0.Frostbite.TerrainMask;
using RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0;

/// <summary>
/// Gives a Frostbite 2 terrain the visuals of one of the engine's own: its visual terrain, renamed to draw
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
public class TemplateVisualTerrain : ITemplateVisualTerrain
{
    private const string c_Visual = ".visual";
    private const string c_StreamingTree = ".StreamingTree";
    private const string c_Decals = ".Decals";

    public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

    public IReadOnlyList<GeneratedResource>? Build(TemplateVisualTerrainRequest p_Request, TextWriter p_Writer)
    {
        var s_Out = new List<GeneratedResource>();
        var s_Game = p_Request.TemplateGame;
        var s_Template = p_Request.Template;

        VisualTerrain s_Visual;
        // Some variants hand back a big-endian reader; the resource is little-endian on PC.
        using (var s_Reader = s_Template.GetReader())
        {
            s_Reader.Endianness = Endianness.LittleEndian;
            s_Visual = new VisualTerrain(s_Reader);
        }

        var s_TemplateDecals = s_Visual.DecalsResourceName;
        s_Visual.StreamingTreeResourceName = p_Request.Terrain + c_StreamingTree;
        s_Visual.DecalsResourceName = p_Request.Terrain + c_Decals;
        foreach (var s_Layer in s_Visual.Layers)
            s_Layer.ScatteringTypes = [];

        if (!s_Visual.Serialize(out var s_VisualData))
        {
            p_Writer.WriteLine("The visual terrain did not serialize.");
            return null;
        }

        var s_Name = p_Request.Terrain.ToLowerInvariant();
        if (p_Request.OwnVisual != null)
        {
            if (OwnVisual(p_Request, s_Visual, p_Writer) is not { } s_Own)
                return null;
            s_VisualData = s_Own;
        }

        s_Out.Add(new GeneratedResource(s_Name + c_Visual, s_VisualData, ResourceType.VisualTerrain, null));
        if (p_Request.OwnVisual == null && MapLayers(p_Request.BundleResources, s_Name + c_StreamingTree.ToLowerInvariant(), s_Visual, p_Writer) is { } s_Tree)
            s_Out.Add(s_Tree);

        if (!s_Game.TryGetResource(s_TemplateDecals.ToLowerInvariant(), out var s_DecalsResource))
        {
            p_Writer.WriteLine($"The template's game has no decals '{s_TemplateDecals}'.");
            return null;
        }

        var s_Converter = new TerrainDecalsConverter();
        TerrainDecalsResource s_TemplateDecalsData;
        using (var s_Reader = s_DecalsResource.FirstVariant.GetReader())
            s_TemplateDecalsData = s_Converter.Read(s_Reader);

        var s_Decals = new TerrainDecalsBuilder(s_TemplateDecalsData).Build();
        if (p_Request.OwnDecals != null)
        {
            if (OwnDecals(p_Request, s_TemplateDecalsData, p_Writer) is not { } s_Own)
                return null;
            s_Decals = s_Own;
        }

        var s_Stream = new MemoryStream();
        using (var s_Writer = new RimeWriter(s_Stream))
            s_Converter.Write(s_Writer, s_Decals);
        s_Out.Add(new GeneratedResource(s_Name + c_Decals.ToLowerInvariant(), s_Stream.ToArray(), ResourceType.TerrainDecals, null));

        // The permutations sit beside the folder of the default surface shader (Levels/MP_007/Terrain/MP_007__...).
        var s_Folder = s_Visual.SurfaceShaderName.ToLowerInvariant();
        s_Folder = s_Folder[..s_Folder.LastIndexOf('/')];
        s_Folder = s_Folder[..(s_Folder.LastIndexOf('/') + 1)];
        p_Writer.WriteLine(p_Request.OwnVisual == null
            ? $"'{s_Name}' draws with '{p_Request.TemplateName}''s {s_Visual.Layers.Length} layer(s) and {s_Visual.TerrainLayerCombinationDraws.Length} combination(s); " +
              $"hold its shaders under '{s_Folder}' in the shader database."
            : $"'{s_Name}' draws with its own layers and '{p_Request.TemplateName}''s default surface shader; hold that under '{s_Folder}' in the shader database.");
        return s_Out;
    }

    /// <summary>
    /// The terrain's own visual terrain in this engine's layout, its layer combinations drawn with
    /// its own 2d shaders under their moved names; its mask keeps its layers.
    /// </summary>
    private static byte[]? OwnVisual(TemplateVisualTerrainRequest p_Request, VisualTerrain p_Template, TextWriter p_Writer)
    {
        var s_Resource = p_Request.OwnVisual!;
        var s_Combinations = p_Request.OwnLayerCombinations!;
        var s_Engine = p_Request.OwnEngine;
        if (!EngineInterfaceRegistry.IsSupported<ITerrainConverter>(s_Engine))
        {
            p_Writer.WriteLine($"Visual terrain of {s_Engine} is not converted.");
            return null;
        }

        var s_Move = (p_Request.MoveNames ?? "").Split('=', 2);
        string Moved(string p_Name) =>
            s_Move.Length == 2 && p_Name.StartsWith(s_Move[0], StringComparison.OrdinalIgnoreCase) ? s_Move[1] + p_Name[s_Move[0].Length..] : p_Name;

        var s_Data = EngineInterfaceRegistry.Create<ITerrainConverter>(s_Engine).ConvertVisualTerrain(s_Resource, s_Combinations,
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
    private static GeneratedResource? MapLayers(IReadOnlyDictionary<string, IResourceObject> p_Resources, string p_StreamingTree, VisualTerrain p_Template, TextWriter p_Writer)
    {
        if (!p_Resources.TryGetValue(p_StreamingTree, out var s_Resource))
        {
            p_Writer.WriteLine($"The bundle has no '{p_StreamingTree}'; its mask keeps its layers.");
            return null;
        }

        var s_Tree = new TerrainStreamingTree();
        using (var s_Reader = s_Resource.GetReader())
            s_Tree.Deserialize(s_Reader.ReadBytes((int)s_Reader.Length));
        if (s_Tree.TerrainMaskTree is not TerrainMaskTree { RootNode: TerrainMaskTree.Node s_Root })
            return null;

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
            return null;
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
            return null;
        }

        var s_NodeCount = s_Sets.Sum(p_S => p_S.Count);
        p_Writer.WriteLine($"Mask layers {string.Join(", ", s_Source.Select((p_L, i) => $"{p_L}->{s_Best.Map[i]}"))}: " +
            $"{s_Best.Covered} of {s_NodeCount} node(s) drawn by a template combination, {s_Best.Exact} by an exact one.");
        return new GeneratedResource(p_StreamingTree, s_Data, ResourceType.TerrainStreamingTree, s_Resource.TryGetMeta(out var s_Meta) ? s_Meta : null);
    }

    /// <summary>The terrain's own decals in this engine's layout, drawn with the template's decal shaders.</summary>
    private static TerrainDecalsResource? OwnDecals(TemplateVisualTerrainRequest p_Request, TerrainDecalsResource p_Template, TextWriter p_Writer)
    {
        var s_Resource = p_Request.OwnDecals!;
        var s_Engine = p_Request.OwnEngine;
        TerrainDecalsResource s_Source;
        using (var s_Reader = s_Resource.GetReader())
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

        var s_Overrides = (p_Request.DecalShaders ?? "").Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
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
