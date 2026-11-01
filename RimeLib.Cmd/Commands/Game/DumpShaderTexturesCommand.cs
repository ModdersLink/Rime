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

            // register -> texture, per shader.
            //
            // A shader that bakes its own textures binds them to sampler registers, and the
            // register is the only thing in this format that says WHICH texture plays which role.
            // Emitted so the mapping can be VALIDATED against meshes whose diffuse is already
            // known from their material, instead of guessed at from filenames.
            var s_Registers = new Dictionary<string, Dictionary<string, string>>();

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

                    // The EXTERNAL slots too: a shader that streams nothing of its own can still
                    // declare parameters something else is expected to fill, and their names say
                    // what the surface actually wants ("external:Diffuse"). Without them a shader
                    // with no streamables looks like a shader with no textures.
                    if (s_Info.GetType().GetProperty("StreamableExternalTextures")?.GetValue(s_Info) is System.Array s_External)
                    {
                        foreach (var s_Slot in s_External)
                        {
                            var s_Parameter = s_Slot?.GetType().GetProperty("ParameterName")?.GetValue(s_Slot)?.ToString();

                            if (!string.IsNullOrWhiteSpace(s_Parameter))
                                s_Names.Add("external:" + s_Parameter);
                        }
                    }

                    var s_ByRegister = new Dictionary<string, string>();

                    if (s_Info.GetType().GetProperty("Solutions")?.GetValue(s_Info) is System.Array s_Solutions)
                    {
                        foreach (var s_Solution in s_Solutions)
                        {
                            foreach (var s_Which in new[] { "PixelConstants", "VertexConstants" })
                            {
                                var s_Constants = s_Solution?.GetType().GetProperty(s_Which)?.GetValue(s_Solution);

                                if (s_Constants?.GetType().GetProperty("Textures")?.GetValue(s_Constants)
                                        is not System.Array s_Constant)
                                    continue;

                                foreach (var s_Entry in s_Constant)
                                {
                                    var s_TexName = s_Entry?.GetType().GetProperty("Name")?.GetValue(s_Entry)?.ToString();
                                    var s_Reg = s_Entry?.GetType().GetProperty("Index")?.GetValue(s_Entry);

                                    if (string.IsNullOrWhiteSpace(s_TexName) || s_Reg == null)
                                        continue;

                                    var s_RegKey = System.Convert.ToInt32(s_Reg).ToString();

                                    if (!s_ByRegister.ContainsKey(s_RegKey))
                                        s_ByRegister[s_RegKey] = s_TexName!;
                                }
                            }
                        }
                    }

                    if (s_ByRegister.Count > 0 && !s_Registers.ContainsKey(s_ShaderName))
                        s_Registers[s_ShaderName] = s_ByRegister;

                    // A render path can repeat a shader; the first list seen is enough.
                    if (s_Names.Count > 0 && !s_Shaders.ContainsKey(s_ShaderName))
                        s_Shaders[s_ShaderName] = s_Names;
                }
            }

            File.WriteAllText(Destination.FullName, JsonConvert.SerializeObject(new { shaders = s_Shaders, registers = s_Registers }));
            p_Writer.WriteLine($"Shader textures for {Name} written to {Destination.FullName} ({s_Shaders.Count} shaders).");

            return true;
        }
    }
}
