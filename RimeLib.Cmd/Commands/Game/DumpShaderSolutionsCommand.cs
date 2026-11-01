using System;
using System.Collections;
using System.IO;
using RimeLib;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps every solution of a shader in a shaderdb: its Technique, ColorScale, BoolPermutation, Mode and StateHash.")]
    public class DumpShaderSolutionsCommand : Command
    {
        // Use it to check which techniques a level's shaderdb actually compiled for a given shader,
        // camo against plain for instance.
        [CommandArgument(Description = "The shaderdb resource name, e.g. levels/mp_017/mp_017/shaderdb")]
        public string? Name { get; set; }

        [CommandArgument(Description = "Shader name (or substring), e.g. Vehicles/M1A2/M1A2_Frame_Main")]
        public string? Shader { get; set; }

        [CommandArgument(Description = "Optional directory to write the bytecode into", Optional = true)]
        public string? Destination { get; set; }

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
            var s_Matched = 0;

            foreach (var s_PathKey in s_Databases.Keys)
            {
                var s_Db = s_Databases[s_PathKey];
                var s_Shaders = s_Db?.GetType().GetProperty("Shaders")?.GetValue(s_Db) as IDictionary;
                if (s_Shaders == null) continue;

                foreach (var s_ShaderKey in s_Shaders.Keys)
                {
                    var s_ShaderName = s_ShaderKey?.ToString() ?? "";
                    if (!s_ShaderName.ToLowerInvariant().Contains(s_Needle)) continue;
                    s_Matched++;

                    var s_Info = s_Shaders[s_ShaderKey];
                    var s_Solutions = s_Info?.GetType().GetProperty("Solutions")?.GetValue(s_Info) as Array;
                    p_Writer.WriteLine($"SHSOL-SHADER: [{s_PathKey}] {s_ShaderName}  solutions={(s_Solutions?.Length ?? 0)}");
                    if (s_Solutions == null) continue;

                    foreach (var s_Solution in s_Solutions)
                    {
                        var s_StateHash = s_Solution!.GetType().GetProperty("StateHash")?.GetValue(s_Solution);
                        var s_State = s_Solution.GetType().GetProperty("State")?.GetValue(s_Solution);
                        object? Get(string p_Name) => s_State?.GetType().GetProperty(p_Name)?.GetValue(s_State);
                        p_Writer.WriteLine(
                            $"  SHSOL: tech={Get("Technique")} colorScale={Get("ColorScale")} " +
                            $"boolPerm={Get("BoolPermutation")} mode={Get("Mode")} " +
                            $"objLight={Get("ObjectLighting")} stateHash=0x{s_StateHash:X}");

                        // The COMPILED BYTECODE. It is not in systems/shaderprogramdb -- that
                        // holds only engine passes (Sky, deferred lighting, tonemap). Each surface
                        // shader carries its own compiled program here, inside its solution's
                        // permutation, which is why a search of the program database found nothing.
                        foreach (var s_Stage in new[] { "PixelPermutation", "VertexPermutation" })
                        {
                            var s_Perm = s_Solution.GetType().GetProperty(s_Stage)?.GetValue(s_Solution);

                            if (s_Perm == null)
                                continue;

                            var s_Bytes = s_Perm.GetType().GetProperty("ShaderBytecode")?.GetValue(s_Perm) as byte[];
                            var s_Instr = s_Perm.GetType().GetProperty("InstructionCount")?.GetValue(s_Perm);
                            var s_Magic = (s_Bytes != null && s_Bytes.Length >= 4)
                                ? System.Text.Encoding.ASCII.GetString(s_Bytes, 0, 4) : "-";

                            p_Writer.WriteLine($"    {s_Stage}: {(s_Bytes?.Length ?? 0)} bytes, " +
                                $"magic='{s_Magic}', instructions={s_Instr}");

                            if (s_Bytes != null && s_Bytes.Length > 0 && Destination != null)
                            {
                                // Create the directory rather than assuming it exists. Without
                                // this, File.WriteAllBytes throws DirectoryNotFoundException, the
                                // exception escapes ProcessCommand and takes the whole REPL down --
                                // which reads as "this shader crashes the dumper" rather than "the
                                // output path was not there".
                                Directory.CreateDirectory(Destination);

                                File.WriteAllBytes(Path.Combine(Destination,
                                    $"{s_Stage}.{s_StateHash:X}.bin"), s_Bytes);
                            }
                        }

                        // The baked float constants. A generated terrain shader's per-layer UV
                        // scale lives here and nowhere else -- the client has been guessing it
                        // with a hardcoded tile size. Printed with their register index, because
                        // the index is what the shader indexes them by.
                        foreach (var s_Which in new[] { "PixelConstants", "VertexConstants" })
                        {
                            var s_Constants = s_Solution.GetType().GetProperty(s_Which)?.GetValue(s_Solution);

                            if (s_Constants == null)
                                continue;

                            var s_Start = s_Constants.GetType().GetProperty("ValueConstantsStart")?.GetValue(s_Constants);
                            var s_Values = s_Constants.GetType().GetProperty("ValueConstants")?.GetValue(s_Constants)
                                as System.Collections.IEnumerable;
                            var s_Index = Convert.ToInt32(s_Start ?? 0);

                            if (s_Values == null)
                                continue;

                            foreach (var s_Value in s_Values)
                            {
                                var s_Type = s_Value.GetType();
                                object? C(string p_N) => s_Type.GetProperty(p_N)?.GetValue(s_Value);
                                p_Writer.WriteLine($"    {s_Which}[c{s_Index}] = " +
                                    $"{C("x")}, {C("y")}, {C("z")}, {C("w")}");
                                s_Index++;
                            }
                        }
                    }
                }
            }

            p_Writer.WriteLine($"SHSOL-DONE: {Name} '{Shader}' matched={s_Matched}");
            return true;
        }
    }
}
