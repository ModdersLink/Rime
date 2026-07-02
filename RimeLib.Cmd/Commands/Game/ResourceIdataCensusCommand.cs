using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("CENSUS: counts how many mounted RESOURCE variants across the whole game are delivered as cas-bundle InlineData (idata) vs catalog SHA1 refs vs noncas bundles. Answers whether retail BF3 ever uses resource-idata — generated mod resources ship as idata and render BLACK on the MVDB path, so a zero/near-zero retail count means the engine fetches resource payloads from cas.cat only and mods need a noncas annex bundle for generated textures. No args.")]
    public class ResourceIdataCensusCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Ctx = (GameContext)p_Context;
            var s_Mounter = s_Ctx.GetMounter() as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("resource_idata_census: no Frostbite2_0 mounter.");
                return false;
            }
            p_Writer.WriteLine(s_Mounter.ResourceIdataCensus());
            return true;
        }
    }
}
