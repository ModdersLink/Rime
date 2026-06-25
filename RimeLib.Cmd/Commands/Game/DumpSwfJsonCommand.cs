using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps a SwfMovie (Scaleform .gfx) resource's structure as JSON: header + tag table (type, offset, length, raw hex). For full editable XML, dump the .gfx with dump_resource and run ffdec -swf2xml.")]
    public class DumpSwfJsonCommand : Command
    {
        [CommandArgument(Description = "The name of the SwfMovie resource to dump.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The destination .json file.")]
        public FileInfo? Destination { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                ((GameContext) p_Context).DumpSwfJson(Name!, Destination!);
                p_Writer.WriteLine("SwfMovie structure successfully dumped to JSON.");
                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to dump SwfMovie with error:");
                p_Writer.WriteLine(s_Exception.Message);
                return false;
            }
        }
    }
}
