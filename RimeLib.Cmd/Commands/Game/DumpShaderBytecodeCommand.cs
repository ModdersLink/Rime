using System;
using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Shader;

namespace RimeLib.Cmd.Commands.Game
{
    /// <summary>
    /// Writes the COMPILED shader programs out of Systems/ShaderProgramDb.
    ///
    /// The shaderdb resources say which textures a shader binds to which register; they do not say
    /// what it DOES with them. That is in the compiled DX11 bytecode, which the program database
    /// carries per stage as a plain byte[]. DXBC is self-describing -- its RDEF chunk names every
    /// constant buffer, variable, offset and type, and ISGN names every input -- so dumping the
    /// blob is enough to recover the constants a shader reads and the maths it applies, without
    /// running the game.
    ///
    /// Written for the terrain, whose layer blending and per-layer UV scales exist nowhere else.
    /// </summary>
    [CommandDescription("Dumps compiled shader bytecode from Systems/ShaderProgramDb.")]
    public class DumpShaderBytecodeCommand : Command
    {
        [CommandArgument(Description = "The program-database resource, e.g. levels/mp_001/mp_001/shaderdb")]
        public string? Database { get; set; }

        [CommandArgument(Description = "Case-insensitive substring of the shader name to match, or ? to list")]
        public string? Match { get; set; }

        [CommandArgument(Description = "Directory to write <stage>.<name>.dxbc files into")]
        public DirectoryInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Database) || string.IsNullOrWhiteSpace(Match) || Destination is null)
            {
                p_Writer.WriteLine("Usage: dump_shader_bytecode <database> <name-substring|?> <destination-dir>");
                return false;
            }

            var s_Mounter = ((GameContext)p_Context).GetMounter();

            // Systems/ShaderProgramDb carries only the engine's own passes -- DeferredShadow,
            // DeferredOutdoorLight, MsaaClassify. Every SURFACE shader, terrain included, is in the
            // level's own shaderdb, so which database to open has to be the caller's choice.
            if (!s_Mounter.TryGetResource(Database!, out var s_Resource)
                || s_Resource.FirstVariant == null)
            {
                p_Writer.WriteLine($"Could not find {Database}.");
                return false;
            }

            // Reflection, like DumpShaderTexturesCommand: this project does not reference the
            // version-specific shader assembly, and should not start to for one command.
            var s_Resolver = EngineInterfaceRegistry.Create<IShaderResolver>(s_Mounter.GetEngineType());
            var s_Assembly = s_Resolver.GetType().Assembly;
            var s_ContainerType = s_Assembly.GetType(
                "RimeLib.Shader.Frostbite2_0.Frostbite.ShaderProgramDatabaseContainer");

            if (s_ContainerType == null)
            {
                p_Writer.WriteLine("No ShaderProgramDatabaseContainer in the shader assembly.");
                return false;
            }

            using var s_Reader = s_Resource.FirstVariant.GetReader();
            var s_Container = Activator.CreateInstance(s_ContainerType, s_Reader);
            var s_TryGetDatabase = s_ContainerType.GetMethod("TryGetDatabase");
            var s_PathType = s_TryGetDatabase!.GetParameters()[0].ParameterType;
            var s_Args = new object?[] { Enum.Parse(s_PathType, "ShaderRenderPath_Dx11"), null };

            if (!(bool)s_TryGetDatabase.Invoke(s_Container, s_Args)!)
            {
                p_Writer.WriteLine("No Dx11 render path in the program database.");
                return false;
            }

            var s_Db = s_Args[1]!;
            var s_DbType = s_Db.GetType();
            var s_GetNames = s_DbType.GetMethod("GetShaderNames")!;
            var s_TryGetShader = s_DbType.GetMethod("TryGetShader")!;
            var s_StageType = s_GetNames.GetParameters()[0].ParameterType;

            Destination.Create();

            var s_Written = 0;

            foreach (var s_StageValue in new[] { 0, 1 })
            {
                var s_Stage = Enum.ToObject(s_StageType, s_StageValue);
                var s_Names = (System.Collections.IEnumerable)s_GetNames.Invoke(s_Db, new[] { s_Stage })!;

                var s_All = s_Names.Cast<string>().ToList();

                // "?" lists instead of writing: the program database is keyed by its OWN names,
                // which are not the surface-shader names the shaderdb uses, and there is no other
                // way to find out what they look like.
                if (Match == "?")
                {
                    var s_ListFile = Path.Combine(Destination.FullName,
                        $"names.{(s_StageValue == 0 ? "vs" : "ps")}.txt");

                    File.WriteAllLines(s_ListFile, s_All);
                    p_Writer.WriteLine($"--- {(s_StageValue == 0 ? "vs" : "ps")}: {s_All.Count} programs -> {s_ListFile}");

                    continue;
                }

                foreach (string s_Name in s_All)
                {
                    if (s_Name.IndexOf(Match!, StringComparison.OrdinalIgnoreCase) < 0)
                        continue;

                    var s_Call = new object?[] { s_Stage, s_Name, null };

                    if (!(bool)s_TryGetShader.Invoke(s_Db, s_Call)!)
                        continue;

                    var s_Info = s_Call[2]!;
                    var s_Data = s_Info.GetType().GetProperty("Data")?.GetValue(s_Info) as byte[];

                    if (s_Data == null || s_Data.Length == 0)
                        continue;

                    var s_Safe = s_Name.Replace('/', '_').Replace('\\', '_');
                    var s_File = Path.Combine(Destination.FullName,
                        $"{(s_StageValue == 0 ? "vs" : "ps")}.{s_Safe}.dxbc");

                    File.WriteAllBytes(s_File, s_Data);
                    p_Writer.WriteLine($"{(s_StageValue == 0 ? "vs" : "ps")} {s_Name} -> {s_Data.Length} bytes");
                    s_Written++;
                }
            }

            p_Writer.WriteLine($"{s_Written} shader program(s) written to {Destination.FullName}");
            return s_Written > 0;
        }
    }
}
