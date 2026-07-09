using System.IO;
using System.Linq;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps a mounted shaderdb (read-only): render paths, shader names, and per-shader " +
                        "solution (permutation) + streamable-texture counts. Use to compare which shaders/" +
                        "permutations a level's shaderdb carries (e.g. is a foreign vehicle's camo shader present?).")]
    public class DumpShaderDbCommand : Command
    {
        [CommandArgument(Description = "The shaderdb resource name, e.g. levels/mp_017/mp_017/shaderdb")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("Usage: dump_shader_db <resource-name>");
                return false;
            }
            string? Filter = null;

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

            // ShaderResolver keeps the parsed container; reflect it out generically so we don't depend on
            // a version-specific type. (Frostbite2_0 exposes ShaderDatabaseContainer.Databases -> ShaderDatabase.)
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

            var s_Filter = string.IsNullOrWhiteSpace(Filter) ? null : Filter!.ToLowerInvariant();
            int s_TotalShaders = 0, s_TotalMatched = 0;

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
                    if (s_Filter != null && !s_ShaderName.ToLowerInvariant().Contains(s_Filter))
                        continue;
                    s_TotalMatched++;

                    var s_Info = s_Shaders[s_ShaderKey];
                    int s_Sols = 0, s_Tex = 0;
                    var s_SolProp = s_Info!.GetType().GetProperty("Solutions");
                    if (s_SolProp?.GetValue(s_Info) is System.Array s_Sol) s_Sols = s_Sol.Length;
                    var s_TexProp = s_Info.GetType().GetProperty("StreamableTextures");
                    if (s_TexProp?.GetValue(s_Info) is System.Array s_TexArr) s_Tex = s_TexArr.Length;

                    p_Writer.WriteLine($"  SHADER: {s_ShaderName}  solutions={s_Sols} streamableTex={s_Tex}");
                }
            }

            p_Writer.WriteLine($"SHADERDB-DONE: {Name}  totalShaders={s_TotalShaders}"
                + (s_Filter != null ? $"  matched='{Filter}'={s_TotalMatched}" : ""));
            return true;
        }
    }
}
