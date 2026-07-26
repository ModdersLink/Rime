using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("CAS-REF RE assumption probe: is a RETAIL cas.cat key equal to SHA1(stored blob bytes)? Samples entries from the base and patch catalogs, reads each blob from its own cas_NN.cas and re-hashes. A full MATCH means the CasCatalogWriter convention (content-address = sha1 of the stored bytes) is DICE's own convention, so a generated DLC catalog is engine-consistent. Optional arg: sample count (default 300).")]
    public class VerifyCatalogHashesCommand : Command
    {
        [CommandArgument(Optional = true, Description = "Number of entries to sample per catalog (default 300).")]
        public int Samples { get; set; } = 300;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("verify_catalog_hashes: no Frostbite2_0 mounter.");
                return false;
            }
            p_Writer.WriteLine(s_Mounter.VerifyCatalogHashes(Samples));
            return true;
        }
    }
}
