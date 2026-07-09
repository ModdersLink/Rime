using System.Collections;
using System.IO;
using System.Linq;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the per-SOLUTION state of a shader in a shaderdb: Technique / ColorScale / " +
                        "BoolPermutation / Mode / StateHash for every solution. Use to check WHICH techniques " +
                        "(e.g. camo vs grey) a level's shaderdb actually compiled for a given vehicle shader.")]
    public class DumpShaderSolutionsCommand : Command
    {
        [CommandArgument(Description = "The shaderdb resource name, e.g. levels/mp_017/mp_017/shaderdb")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Shader name (or substring), e.g. Vehicles/M1A2/M1A2_Frame_Main")]
        public string? Shader { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name) || string.IsNullOrWhiteSpace(Shader))
            {
                p_Writer.WriteLine("Usage: dump_shader_solutions <resource> <shader-name-or-substring>");
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
            var s_Container = s_Resolver.GetType().GetProperty("ShaderDatabaseContainer")?.GetValue(s_Resolver);
            var s_Databases = s_Container?.GetType().GetProperty("Databases")?.GetValue(s_Container) as IDictionary;
            if (s_Databases == null)
            {
                p_Writer.WriteLine("Shaderdb parsed to null / no databases.");
                return false;
            }

            var s_Needle = Shader!.ToLowerInvariant();
            int s_Matched = 0;

            foreach (var s_PathKey in s_Databases.Keys)
            {
                var s_Db = s_Databases[s_PathKey];
                var s_Shaders = s_Db?.GetType().GetProperty("Shaders")?.GetValue(s_Db) as IDictionary;
                if (s_Shaders == null) continue;

                foreach (var s_ShKey in s_Shaders.Keys)
                {
                    var s_ShName = s_ShKey?.ToString() ?? "";
                    if (!s_ShName.ToLowerInvariant().Contains(s_Needle)) continue;
                    s_Matched++;

                    var s_Info = s_Shaders[s_ShKey];
                    var s_Sols = s_Info?.GetType().GetProperty("Solutions")?.GetValue(s_Info) as System.Array;
                    p_Writer.WriteLine($"SHSOL-SHADER: [{s_PathKey}] {s_ShName}  solutions={(s_Sols?.Length ?? 0)}");
                    if (s_Sols == null) continue;

                    foreach (var s_Sol in s_Sols)
                    {
                        var s_HashObj = s_Sol!.GetType().GetProperty("StateHash")?.GetValue(s_Sol);
                        var s_State = s_Sol.GetType().GetProperty("State")?.GetValue(s_Sol);
                        object? Get(string p_N) => s_State?.GetType().GetProperty(p_N)?.GetValue(s_State);
                        p_Writer.WriteLine(
                            $"  SHSOL: tech={Get("Technique")} colorScale={Get("ColorScale")} " +
                            $"boolPerm={Get("BoolPermutation")} mode={Get("Mode")} " +
                            $"objLight={Get("ObjectLighting")} stateHash=0x{s_HashObj:X}");
                    }
                }
            }

            p_Writer.WriteLine($"SHSOL-DONE: {Name} '{Shader}' matched={s_Matched}");
            return true;
        }
    }
}
