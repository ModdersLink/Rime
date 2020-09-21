using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps the specified texture resource to a dds file.")]
    public class DebugVerifyTexturesBitCount : Command
    {

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
#if !DEBUG
            try
            {
#endif
                (p_Context as GameContext)!.Debug_VerifyBitCount(p_Writer);
                p_Writer.WriteLine("Chunk successfully dumped.");
                return true;
#if !DEBUG
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump chunk with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
#endif
        }
    }
}
