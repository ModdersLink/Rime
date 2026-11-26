using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    /// <summary>
    /// Has the converted closures translate their shaders instead of only standing them in: a converted mesh
    /// shader whose g-buffer pixel shader the translator re-emits for every g-buffer solution of its stand-in keeps
    /// its own shader and parameters, drawn with the stand-in's solutions and its own translated pixel shaders
    /// (add_translated_shaders); the others stand in as before.
    /// </summary>
    [CommandDescription("Has converted closures translate converted shaders' g-buffer pixel shaders onto their stand-ins with a shader translator (RimeShaderEditor.exe --retarget-batch).")]
    public class SetShaderTranslatorCommand : Command
    {
        [CommandArgument(Description = "The translator executable, e.g. RimeShaderEditor.exe; empty to only stand in.")]
        public string? Path { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_SbContext = (SbBuildingContext)p_Context;
            if (string.IsNullOrWhiteSpace(Path))
            {
                s_SbContext.ShaderTranslator = null;
                p_Writer.WriteLine("Converted shaders stand in only.");
                return true;
            }

            if (!File.Exists(Path))
            {
                p_Writer.WriteLine($"No translator at '{Path}'.");
                return false;
            }

            s_SbContext.ShaderTranslator = System.IO.Path.GetFullPath(Path);
            p_Writer.WriteLine($"Converted shaders are translated with '{s_SbContext.ShaderTranslator}'.");
            return true;
        }
    }
}
