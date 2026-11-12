using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    /// <summary>
    /// Gives the converted shaders the converted closures translated (set_shader_translator) their entries in the
    /// shader database the bundle built (build_shader_database): each its stand-in's solutions under its own name,
    /// with its translated pixel shaders bound by its own constants. Their partitions and textures came with the
    /// closure, their materials kept them.
    /// </summary>
    [CommandDescription("Adds the converted shaders whose g-buffer pixel shaders were translated (set_shader_translator) to the bundle's shader database, drawn with their stand-ins' solutions.")]
    public class AddTranslatedShadersCommand : Command
    {
        [CommandArgument(Description = "The bundle's shader database, built with build_shader_database, e.g. levels/mp_prison/mp_prison/shaderdb.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Id returned by mount_game, of the game of this bundle's engine holding the stand-ins.")]
        public int TemplateId { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbContext = (SbBuildingContext)s_BundleContext.Parent!;
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("usage: add_translated_shaders <name> <template id>");
                return false;
            }

            if (!((BaseContext)s_SbContext.Parent!).GetMounters().TryGetValue(TemplateId, out var s_TargetGame) || s_TargetGame.GetEngineType() != s_SbContext.EngineType)
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

            if (s_SbContext.TranslatedShaders.Count == 0)
            {
                p_Writer.WriteLine("No converted shader was translated.");
                return true;
            }

            byte[] Read(Content.Mounting.IResourceObject p_Resource)
            {
                using var s_Reader = p_Resource.GetReader();
                return s_Reader.ReadBytes((int)s_Reader.Length);
            }

            var s_Index = ShaderDatabaseIndex.Get(s_TargetGame);
            var s_Builder = s_Index.Builder;
            var s_Parts = new List<Func<byte[]>>();
            var s_Translated = new List<string>();

            // One conversion per source database and the template database holding the stand-ins of its shaders.
            var s_Mounters = ((BaseContext)s_SbContext.Parent!).GetMounters();
            var s_TexturesAdded = 0;
            foreach (var s_Group in s_SbContext.TranslatedShaders
                         .GroupBy(p_T => (p_T.SourceDatabase, p_T.Source, p_T.Move, Template: s_Index.Databases.FindIndex(p_D => p_D.Keys.Contains(p_T.Shader.TemplateKey)))))
            {
                var (s_SourceDatabase, s_Source, s_Move, s_Template) = s_Group.Key;
                string Moved(string p_Name) =>
                    s_Move is var (s_From, s_To) && p_Name.StartsWith(s_From, StringComparison.OrdinalIgnoreCase) ? s_To + p_Name[s_From.Length..] : p_Name;

                var s_Shaders = s_Group.Select(p_T => p_T.Shader).ToList();
                if (s_Template < 0)
                {
                    p_Writer.WriteLine($"  {s_Shaders.Count} translated shader(s) of '{s_SourceDatabase}': no shader database of game {TemplateId} holds their stand-ins; left out.");
                    continue;
                }

                if (!s_Source.TryGetResource(s_SourceDatabase.ToLowerInvariant(), out var s_SourceResource))
                {
                    p_Writer.WriteLine($"  {s_Shaders.Count} translated shader(s): the source has no '{s_SourceDatabase}'; left out.");
                    continue;
                }

                // The stand-ins' solutions in every database: whether a mesh draws was decided over all of them.
                var s_TemplateKeys = s_Shaders.Select(p_S => p_S.TemplateKey).ToHashSet();
                var s_More = s_Index.Databases.Where((p_D, i) => i != s_Template && p_D.Keys.Overlaps(s_TemplateKeys)).Select(p_D => p_D.Load()).ToList();
                var s_Converter = EngineInterfaceRegistry.Create<IShaderDatabaseConverter>(s_Source.GetEngineType());
                var s_Converted = s_Converter.ConvertTranslated(Read(s_SourceResource.FirstVariant), s_Shaders, s_Index.Databases[s_Template].Load(),
                    s_SbContext.EngineType, Moved, p_Writer, s_More, s_SbContext.UsedDeclarations.Contains);
                s_Parts.Add(() => s_Converted);
                s_Translated.AddRange(s_Shaders.Select(p_S => p_S.Name));

                // The textures their constants bind by name, which the engine resolves when it draws them - a
                // missing one is a null texture in the draw, not a blank surface.
                var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Source.GetEngineType());
                s_Resolver.Initialize(s_SourceResource.FirstVariant, s_Source);
                var s_ByShader = s_Resolver.GetTexturesByShader();
                var s_Textures = s_Group.Select(p_T => p_T.SourceName.ToLowerInvariant())
                    .SelectMany(p_S => s_ByShader.TryGetValue(p_S, out var s_T) ? s_T : Enumerable.Empty<string>())
                    .Select(p_T => p_T.ToLowerInvariant()).Distinct().Order(StringComparer.Ordinal).ToList();
                var s_SourceId = s_Mounters.FirstOrDefault(p_M => ReferenceEquals(p_M.Value, s_Source)).Key;
                if (s_Textures.Count > 0 && ConvertedClosure.Create(s_BundleContext, s_SourceId, [], s_Move, p_Writer) is { } s_Closure)
                {
                    var s_Result = s_Closure.Add(s_Textures, p_Writer);
                    foreach (var s_Line in s_Result.Unresolved)
                        p_Writer.WriteLine($"  {s_Line}");
                    s_TexturesAdded += s_Textures.Count;
                }
            }

            // The stand-ins' own textures: their pixel shaders and constants stay in the solutions not translated
            // (depth-only, the other render path, a lightmap the translation would lose), and the engine binds the
            // textures those constants name when it draws them - for shaders the bundle's materials no longer use.
            var s_TemplateTextures = new HashSet<string>(StringComparer.Ordinal);
            foreach (var s_Group in s_SbContext.TranslatedShaders.GroupBy(p_T => s_Index.Databases.FindIndex(p_D => p_D.Keys.Contains(p_T.Shader.TemplateKey))))
            {
                if (s_Group.Key < 0 || !s_TargetGame.TryGetResource(s_Index.Databases[s_Group.Key].Name.ToLowerInvariant(), out var s_TemplateResource))
                    continue;

                var s_TemplateResolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_SbContext.EngineType);
                s_TemplateResolver.Initialize(s_TemplateResource.FirstVariant, s_TargetGame);
                var s_ByTemplate = s_TemplateResolver.GetTexturesByShader();
                foreach (var s_Key in s_Group.Select(p_T => p_T.Shader.TemplateKey).Distinct())
                {
                    if (s_Index.Names.TryGetValue(s_Key, out var s_TemplateName) && s_ByTemplate.TryGetValue(s_TemplateName.ToLowerInvariant(), out var s_Bound))
                        s_TemplateTextures.UnionWith(s_Bound.Select(p_T => p_T.ToLowerInvariant()));
                }
            }

            var s_Missing2 = s_TemplateTextures.Where(p_T => !s_BundleContext.GetPartitions().ContainsKey(p_T) && s_TargetGame.TryGetPartition(p_T, out _))
                .Order(StringComparer.Ordinal).ToList();
            if (s_Missing2.Count > 0 && PartitionClosure.Create(s_BundleContext, TemplateId, [], TextWriter.Null) is { } s_Adder)
                s_Adder.AddAll(s_Missing2, p_Writer);
            p_Writer.WriteLine($"{s_Missing2.Count} texture(s) the stand-ins bind added for their solutions the translated shaders keep.");

            // The built database's shaders, then the translated ones. A shader the database got from another engine
            // (add_converted_shaders: the terrain's) is no partition of this engine's game but one of the bundle's.
            var s_Data = Read(s_Built);
            var s_Keys = s_Builder.GetShaderKeys(s_Data);
            var s_BundleNames = new Dictionary<uint, string>();
            foreach (var s_Partition in s_BundleContext.GetPartitions().Keys)
                s_BundleNames.TryAdd(s_Builder.GetShaderKey(s_Partition), s_Partition.ToLowerInvariant());

            var s_Names = new List<string>();
            foreach (var s_Key in s_Keys)
            {
                if (s_Index.Names.TryGetValue(s_Key, out var s_Known) || s_BundleNames.TryGetValue(s_Key, out s_Known))
                    s_Names.Add(s_Known);
                else
                    p_Writer.WriteLine($"  DROPPED 0x{s_Key:X8}: no partition names this shader of the database, so it is not merged.");
            }

            s_Names = s_Names.Concat(s_Translated).Distinct().ToList();
            // Every part's solutions: a shader translated onto several stand-ins, for bundles fitted to each, holds them all.
            var s_Merged = s_Builder.Build(new List<Func<byte[]>> { () => s_Data }.Concat(s_Parts).ToList(), s_Names, true, p_Writer, out var s_Missing);
            foreach (var s_Shader in s_Missing)
                p_Writer.WriteLine($"  NOT TRANSLATED {s_Shader}");

            var s_Meta = s_Built.TryGetMeta(out var s_BuiltMeta) ? s_BuiltMeta : null;
            s_BundleContext.RemoveResource(s_Name);
            s_BundleContext.AddGeneratedResource(s_Name, s_Merged, ResourceType.IShaderDatabase, s_Meta);
            p_Writer.WriteLine($"Added {s_Translated.Count - s_Missing.Count(s_Translated.Contains)} translated shader(s) to '{s_Name}' ({s_Merged.Length} bytes), with {s_TexturesAdded} texture(s) they bind.");
            return true;
        }
    }
}
