using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Prints the bundle-manifest META bytes (hex) of every mounted variant of a resource. BF3 texture binding (TextureAsset/MVDB path) reads this meta — generated add_dds resources shipped meta=EMPTY, which is the black-vehicle bug.")]
    public class DumpResourceMetaCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
        public string? Name { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter();
            if (!s_Mounter.TryGetResource(Name!, out var s_Res))
            {
                p_Writer.WriteLine($"Resource not found: {Name}");
                return false;
            }
            int s_I = 0;
            foreach (var s_V in s_Res.Variants)
            {
                string s_Hex = "(none)";
                if (s_V.TryGetMeta(out var s_Meta) && s_Meta != null)
                    s_Hex = s_Meta.Length == 0 ? "(empty)" : string.Join(" ", s_Meta.Select(p_B => p_B.ToString("x2")));
                p_Writer.WriteLine($"variant[{s_I++}] sb={s_V.GetContainedSuperbundle()} bundle={s_V.GetContainedBundle() ?? "-"} cas={s_V.Cas} metaLen={(s_Meta == null ? -1 : s_Meta.Length)} meta={s_Hex}");
            }
            return true;
        }
    }
}
