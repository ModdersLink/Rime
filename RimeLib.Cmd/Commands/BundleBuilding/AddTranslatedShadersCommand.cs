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
            foreach (var s_Group in s_SbContext.TranslatedShaders
                         .GroupBy(p_T => (p_T.SourceDatabase, p_T.Source, Template: s_Index.Databases.FindIndex(p_D => p_D.Keys.Contains(p_T.Shader.TemplateKey)))))
            {
                var (s_SourceDatabase, s_Source, s_Template) = s_Group.Key;
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

                var s_Converter = EngineInterfaceRegistry.Create<IShaderDatabaseConverter>(s_Source.GetEngineType());
                var s_Converted = s_Converter.ConvertTranslated(Read(s_SourceResource.FirstVariant), s_Shaders, s_Index.Databases[s_Template].Load(),
                    s_SbContext.EngineType, p_N => p_N, p_Writer);
                s_Parts.Add(() => s_Converted);
                s_Translated.AddRange(s_Shaders.Select(p_S => p_S.Name));
            }

            // The built database's shaders, then the translated ones.
            var s_Data = Read(s_Built);
            var s_Keys = s_Builder.GetShaderKeys(s_Data);
            var s_Names = s_Keys.Where(s_Index.Names.ContainsKey).Select(p_K => s_Index.Names[p_K]).Concat(s_Translated).Distinct().ToList();
            var s_Merged = s_Builder.Build(new List<Func<byte[]>> { () => s_Data }.Concat(s_Parts).ToList(), s_Names, false, p_Writer, out var s_Missing);
            foreach (var s_Shader in s_Missing)
                p_Writer.WriteLine($"  NOT TRANSLATED {s_Shader}");

            var s_Meta = s_Built.TryGetMeta(out var s_BuiltMeta) ? s_BuiltMeta : null;
            s_BundleContext.RemoveResource(s_Name);
            s_BundleContext.AddGeneratedResource(s_Name, s_Merged, ResourceType.IShaderDatabase, s_Meta);
            p_Writer.WriteLine($"Added {s_Translated.Count - s_Missing.Count(s_Translated.Contains)} translated shader(s) to '{s_Name}' ({s_Merged.Length} bytes).");
            return true;
        }
    }
}
