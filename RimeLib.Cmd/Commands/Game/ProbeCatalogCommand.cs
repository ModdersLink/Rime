using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("DLC-CATALOG RE oracle: loads a generated cas.cat and reports how many of the named objects' stored-frame sha1s it now contains. With authoritative=true it chains the catalog onto the mounted base (AuthoritativeCatalog) and reads one entry back — proving a mod cas-ref would resolve at bundle mount. Args: <cat_path> <name_list.txt> [authoritative].")]
    public class ProbeCatalogCommand : Command
    {
        [CommandArgument(Description = "Path to the generated cas.cat.")]
        public FileInfo? CatPath { get; set; }

        [CommandArgument(Description = "Text file with one resource/partition name per line.")]
        public FileInfo? NameList { get; set; }

        [CommandArgument(Optional = true, Description = "true = chain as AuthoritativeCatalog and read an entry back.")]
        public bool Authoritative { get; set; } = false;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("probe_catalog: no Frostbite2_0 mounter.");
                return false;
            }
            var s_Names = File.ReadAllLines(NameList!.FullName)
                .Select(p_L => p_L.Trim())
                .Where(p_L => p_L.Length > 0 && !p_L.StartsWith("#"))
                .ToArray();
            p_Writer.WriteLine(s_Mounter.ProbeCatalog(CatPath!.FullName, s_Names, Authoritative));
            return true;
        }
    }
}
