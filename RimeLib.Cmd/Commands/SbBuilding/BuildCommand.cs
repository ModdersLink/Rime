using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Builds the superbundle and exits this context.")]
    public class BuildCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                p_Writer.WriteLine("Building superbundle. Please wait...");

                ((SbBuildingContext) p_Context).Build();

                p_Writer.WriteLine("Superbundle successfully built!");

                p_Context = p_Context.Parent!;

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to build superbundle with error:");
                p_Writer.WriteLine(s_Exception.Message);

                return false;
            }
        }
    }
}