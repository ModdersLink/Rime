using System;
using System.IO;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps a mounted shaderdb: its render paths, shader names, and each shader's solution and streamable texture counts.")]
    public class DumpShaderDbCommand : Command
    {
        // Read-only. Use it to compare which shaders and permutations two levels' shaderdbs carry, for
        // instance whether a foreign vehicle's camo shader is present at all.
        [CommandArgument(Description = "The shaderdb resource name, e.g. levels/mp_017/mp_017/shaderdb")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("Usage: dump_shader_db <resource-name>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            if (!s_Mounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find shaderdb resource ({Name}).");
                return false;
            }

            var s_Variant = s_Resource.FirstVariant;
            if (s_Variant == null)
            {
                p_Writer.WriteLine($"No variant for ({Name}).");
                return false;
            }

            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Mounter.GetEngineType());
            s_Resolver.Initialize(s_Variant, s_Mounter);

            // The resolver keeps the parsed container, reached by reflection here so this command does
            // not depend on a version-specific type.
            var s_ContainerProp = s_Resolver.GetType().GetProperty("ShaderDatabaseContainer");
            var s_Container = s_ContainerProp?.GetValue(s_Resolver);
            if (s_Container == null)
            {
                p_Writer.WriteLine("Shaderdb parsed to null (unsupported version or not a shaderdb resource).");
                return false;
            }

            var s_DatabasesProp = s_Container.GetType().GetProperty("Databases");
            var s_Databases = s_DatabasesProp?.GetValue(s_Container) as System.Collections.IDictionary;
            if (s_Databases == null)
            {
                p_Writer.WriteLine("No render-path databases in shaderdb.");
                return false;
            }

            var s_TotalShaders = 0;

            foreach (var s_Key in s_Databases.Keys)
            {
                var s_Db = s_Databases[s_Key];
                var s_ShadersProp = s_Db!.GetType().GetProperty("Shaders");
                var s_Shaders = s_ShadersProp?.GetValue(s_Db) as System.Collections.IDictionary;
                if (s_Shaders == null) continue;

                p_Writer.WriteLine($"SHADERDB-PATH: {s_Key}  shaders={s_Shaders.Count}");
                s_TotalShaders += s_Shaders.Count;

                foreach (var s_ShaderKey in s_Shaders.Keys)
                {
                    var s_ShaderName = s_ShaderKey?.ToString() ?? "";
                    var s_Info = s_Shaders[s_ShaderKey];

                    int s_Solutions = 0, s_Textures = 0;
                    if (s_Info!.GetType().GetProperty("Solutions")?.GetValue(s_Info) is Array s_SolutionArray)
                        s_Solutions = s_SolutionArray.Length;
                    if (s_Info.GetType().GetProperty("StreamableTextures")?.GetValue(s_Info) is Array s_TextureArray)
                        s_Textures = s_TextureArray.Length;

                    p_Writer.WriteLine($"  SHADER: {s_ShaderName}  solutions={s_Solutions} streamableTex={s_Textures}");
                }
            }

            p_Writer.WriteLine($"SHADERDB-DONE: {Name}  totalShaders={s_TotalShaders}");
            return true;
        }
    }
}
