using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Adds shaders of a game of another engine to the shader database the bundle built
    /// (build_shader_database), converted to the bundle's engine: each draws in the states of a
    /// template shader of the bundle's game chosen by name pattern. The shaders' partitions and the
    /// textures they bind are converted and added with their closure, under the moved names.
    /// </summary>
    [CommandDescription("Adds shaders of a game of another engine, converted, to the bundle's shader database, drawn in a template shader's states, with their partitions and textures.")]
    public class AddConvertedShadersCommand : Command
    {
        [CommandArgument(Description = "The bundle's shader database, built with build_shader_database, e.g. levels/mp_prison/mp_prison/shaderdb.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The shader database of the other game, e.g. levels/mp/mp_prison/mp_prison/shaderdb.")]
        public string? Source { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game to convert from.")]
        public int Id { get; set; }

        [CommandArgument(Description = "Shaders to convert and their templates, as 'pattern=template' pairs separated by ';': a source shader whose name matches the pattern ('*' for any text) draws like the template, a shader of this bundle's game.")]
        public string? Templates { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game of this bundle's engine holding the templates.")]
        public int TemplateId { get; set; }

        [CommandArgument(Description = "Names to move, as 'from=to', as reference_converted_partition moves them, e.g. 'levels/mp/mp_prison/=Levels/MP_Prison/'.", Optional = true)]
        public string? MoveNames { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            var s_Mounters = ((BaseContext)s_SbContext.Parent!).GetMounters();
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Source) || string.IsNullOrWhiteSpace(Templates))
            {
                p_Writer.WriteLine("usage: add_converted_shaders <name> <source> <id> <pattern=template;...> <template id> [move]");
                return false;
            }

            if (!s_Mounters.TryGetValue(Id, out var s_Game) || !s_Game.TryGetResource(Source.ToLowerInvariant(), out var s_SourceResource))
            {
                p_Writer.WriteLine($"Game {Id} has no resource '{Source}'.");
                return false;
            }

            if (!s_Mounters.TryGetValue(TemplateId, out var s_TargetGame) || s_TargetGame.GetEngineType() != s_SbContext.EngineType)
            {
                p_Writer.WriteLine($"Id ({TemplateId}) is not a mounted game of this bundle's engine.");
                return false;
            }

            var s_Name = Name.ToLowerInvariant();
            if (!s_BundleContext.GetResources().TryGetValue(s_Name, out var s_Built))
            {
                p_Writer.WriteLine($"The bundle has no '{s_Name}'; build it with build_shader_database first.");
                return false;
            }

            var s_Engine = s_Game.GetEngineType();
            if (!EngineInterfaceRegistry.IsSupported<IShaderDatabaseConverter>(s_Engine))
            {
                p_Writer.WriteLine($"Shaders of {s_Engine} are not converted.");
                return false;
            }

            (string From, string To)? s_Move = null;
            if (!string.IsNullOrWhiteSpace(MoveNames))
            {
                var s_Parts = MoveNames.Split('=', 2);
                if (s_Parts.Length != 2)
                {
                    p_Writer.WriteLine($"'{MoveNames}' is not 'from=to'.");
                    return false;
                }

                s_Move = (s_Parts[0], s_Parts[1]);
            }

            string Moved(string p_Name) =>
                s_Move is var (s_From, s_To) && p_Name.StartsWith(s_From, StringComparison.OrdinalIgnoreCase) ? s_To + p_Name[s_From.Length..] : p_Name;

            // The source's shaders by partition name, with the textures their constants bind.
            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Engine);
            s_Resolver.Initialize(s_SourceResource.FirstVariant, s_Game);
            var s_SourceBuilder = EngineInterfaceRegistry.Create<IShaderDatabaseBuilder>(s_Engine);
            var s_Index = ShaderDatabaseIndex.Get(s_TargetGame);
            var s_Builder = s_Index.Builder;

            var s_Pairs = Templates.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries)
                .Select(p_Pair => p_Pair.Split('=', 2, StringSplitOptions.TrimEntries))
                .Where(p_Pair => p_Pair.Length == 2)
                .Select(p_Pair => (Pattern: new Regex("^" + Regex.Escape(p_Pair[0].ToLowerInvariant()).Replace("\\*", ".*") + "$"), Template: p_Pair[1].ToLowerInvariant()))
                .ToList();

            var s_Shaders = new Dictionary<uint, ConvertedShader>();
            var s_Partitions = new List<string>();
            var s_TemplateKeys = new HashSet<uint>();
            foreach (var s_Shader in s_Resolver.GetShaderNames().Order(StringComparer.Ordinal))
            {
                if (s_Pairs.FirstOrDefault(p_P => p_P.Pattern.IsMatch(s_Shader)) is not { Template: { } s_Template })
                    continue;

                var s_TemplateKey = s_Builder.GetShaderKey(s_Template);
                s_Shaders[s_SourceBuilder.GetShaderKey(s_Shader)] = new ConvertedShader(Moved(s_Shader).ToLowerInvariant(), s_TemplateKey);
                s_Partitions.Add(s_Shader);
                s_TemplateKeys.Add(s_TemplateKey);
            }

            if (s_Shaders.Count == 0)
            {
                p_Writer.WriteLine($"No shader of '{Source}' matches a pattern of '{Templates}'.");
                return false;
            }

            // One mounted database holding every template.
            var s_TemplateDatabase = s_Index.Databases.FirstOrDefault(p_D => s_TemplateKeys.All(p_D.Keys.Contains));
            if (s_TemplateDatabase.Load == null)
            {
                p_Writer.WriteLine($"No shader database of game {TemplateId} holds every template of '{Templates}'.");
                return false;
            }

            byte[] Read(Content.Mounting.IResourceObject p_Resource)
            {
                using var s_Reader = p_Resource.GetReader();
                return s_Reader.ReadBytes((int)s_Reader.Length);
            }

            var s_Converter = EngineInterfaceRegistry.Create<IShaderDatabaseConverter>(s_Engine);
            var s_Converted = s_Converter.Convert(Read(s_SourceResource.FirstVariant), s_Shaders, s_TemplateDatabase.Load(), s_SbContext.EngineType, Moved, p_Writer);

            // The built database's shaders, then the converted ones.
            var s_Data = Read(s_Built);
            var s_Keys = s_Builder.GetShaderKeys(s_Data);
            var s_Names = s_Keys.Where(s_Index.Names.ContainsKey).Select(p_K => s_Index.Names[p_K]).Concat(s_Shaders.Values.Select(p_S => p_S.Name)).ToList();
            var s_Merged = s_Builder.Build([() => s_Data, () => s_Converted], s_Names, false, p_Writer, out var s_Missing);
            if (s_Keys.Count(s_Index.Names.ContainsKey) != s_Keys.Count)
                p_Writer.WriteLine($"{s_Keys.Count - s_Keys.Count(s_Index.Names.ContainsKey)} shader(s) of '{s_Name}' are named by no partition of game {TemplateId}; left out.");
            foreach (var s_Shader in s_Missing)
                p_Writer.WriteLine($"  NOT CONVERTED {s_Shader}");

            var s_Meta = s_Built.TryGetMeta(out var s_BuiltMeta) ? s_BuiltMeta : null;
            s_BundleContext.RemoveResource(s_Name);
            s_BundleContext.AddGeneratedResource(s_Name, s_Merged, ResourceType.IShaderDatabase, s_Meta);

            // The converted shaders' partitions and the textures they bind.
            var s_Done = s_Partitions.Where(p_P => !s_Missing.Contains(Moved(p_P).ToLowerInvariant())).ToList();
            var s_ByShader = s_Resolver.GetTexturesByShader();
            var s_Textures = s_Done.SelectMany(p_S => s_ByShader.TryGetValue(p_S, out var s_T) ? s_T : Enumerable.Empty<string>())
                .Select(p_T => p_T.ToLowerInvariant()).Distinct().Order(StringComparer.Ordinal).ToList();
            if (ConvertedClosure.Create(s_BundleContext, Id, [], s_Move, p_Writer) is not { } s_Closure)
                return false;

            var s_Result = s_Closure.Add(s_Done.Concat(s_Textures), p_Writer);
            foreach (var s_Line in s_Result.Unresolved)
                p_Writer.WriteLine($"  {s_Line}");

            p_Writer.WriteLine($"Added {s_Done.Count} of {s_Shaders.Count} shader(s) of '{Source}' to '{s_Name}' ({s_Merged.Length} bytes), with {s_Textures.Count} texture(s): " +
                $"{s_Result.Partitions} partition(s), {s_Result.ConvertedResources} of {s_Result.Resources} resource(s) converted.");
            return true;
        }
    }
}
