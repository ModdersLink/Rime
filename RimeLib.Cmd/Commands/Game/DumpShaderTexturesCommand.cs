using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes each shader's own textures out of a shaderdb, as JSON.
    ///
    /// A mesh whose MeshVariationDatabase entry carries no texture parameters is not untextured --
    /// its surface comes from the shader, which names the textures it streams in its StreamableTextures
    /// list. That list is the only place those bindings exist; nothing in EBX carries them.
    /// </summary>
    [CommandDescription("Dumps each shader's StreamableTextures from a shaderdb, as JSON.")]
    public class DumpShaderTexturesCommand : Command
    {
        [CommandArgument(Description = "The shaderdb resource name, e.g. levels/mp_001/mp_001/shaderdb")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The output .json file")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_shader_textures <shaderdb-resource> <destination.json>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource) || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find shaderdb resource ({Name}).");
                return false;
            }

            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Mounter.GetEngineType());
            s_Resolver.Initialize(s_Resource.FirstVariant, s_Mounter);

            // Reached by reflection, the same way DumpShaderDbCommand does, so this command does not
            // depend on a version-specific shaderdb type.
            var s_Container = s_Resolver.GetType().GetProperty("ShaderDatabaseContainer")?.GetValue(s_Resolver);
            var s_Databases = s_Container?.GetType().GetProperty("Databases")?.GetValue(s_Container)
                as System.Collections.IDictionary;

            if (s_Databases == null)
            {
                p_Writer.WriteLine("No render-path databases in shaderdb.");
                return false;
            }

            var s_Shaders = new Dictionary<string, List<string>>();

            foreach (var s_Key in s_Databases.Keys)
            {
                var s_Db = s_Databases[s_Key];

                if (s_Db!.GetType().GetProperty("Shaders")?.GetValue(s_Db) is not System.Collections.IDictionary s_Set)
                    continue;

                foreach (var s_ShaderKey in s_Set.Keys)
                {
                    var s_ShaderName = s_ShaderKey?.ToString() ?? "";
                    var s_Info = s_Set[s_ShaderKey];

                    if (s_Info!.GetType().GetProperty("StreamableTextures")?.GetValue(s_Info) is not System.Array s_Textures)
                        continue;

                    var s_Names = new List<string>();

                    foreach (var s_Texture in s_Textures)
                    {
                        var s_TextureName = s_Texture?.GetType().GetProperty("Name")?.GetValue(s_Texture)?.ToString();

                        if (!string.IsNullOrWhiteSpace(s_TextureName))
                            s_Names.Add(s_TextureName!);
                    }

                    // A render path can repeat a shader; the first list seen is enough.
                    if (s_Names.Count > 0 && !s_Shaders.ContainsKey(s_ShaderName))
                        s_Shaders[s_ShaderName] = s_Names;
                }
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { shaders = s_Shaders }));
            p_Writer.WriteLine($"Shader textures for {Name} written to {Destination.FullName} ({s_Shaders.Count} shaders).");

            return true;
        }
    }
}
