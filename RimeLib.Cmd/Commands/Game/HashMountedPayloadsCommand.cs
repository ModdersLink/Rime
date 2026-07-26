using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("CAS-REF RE: hashes the STORED payload bytes of every mounted variant whose superbundle name starts with <sb_prefix> (case-insensitive) and writes a TSV (kind,name,sb,bundle,storedSize,sha1,manifestSha1,inGameCatalog). The sha1 is computed over the exact stored frame (original compressed blocks / raw windows) = the content address a DLC cas-ification would produce. Run over win32/xp for the game's DLC side and over standalone-mounted mod sbs for the mod side, then intersect the sha1 columns. Args: <sb_prefix> <out_tsv>.")]
    public class HashMountedPayloadsCommand : Command
    {
        [CommandArgument(Description = "Superbundle name prefix filter (case-insensitive), e.g. win32/xp")]
        public string? SbPrefix { get; set; }

        [CommandArgument(Description = "The destination .tsv file.")]
        public FileInfo? Destination { get; set; }

        [CommandArgument(Optional = true, Description = "true = hash the DECOMPRESSED (engine-visible) bytes of every variant including catalog refs, instead of the stored frame.")]
        public bool Logical { get; set; } = false;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("hash_mounted_payloads: no Frostbite2_0 mounter.");
                return false;
            }
            p_Writer.WriteLine(s_Mounter.HashMountedPayloads(SbPrefix!, Destination!.FullName, Logical));
            return true;
        }
    }
}
