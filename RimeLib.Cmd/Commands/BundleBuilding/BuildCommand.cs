using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Builds the bundle, adds it to the superbundle and returns to its context.")]
    public class BuildCommand : Command
    {
        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                p_Writer.WriteLine("Building bundle. Please wait...");

                var s_Descriptor = ((BundleBuildingContext) p_Context).Build();

                p_Context = p_Context.Parent!;

                ((SbBuildingContext)p_Context).AddBundle(s_Descriptor);

                p_Writer.WriteLine("Bundle successfully built and added to superbundle!");

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine("Failed to build bundle with error:");
                p_Writer.WriteLine(s_Exception.Message);

                return false;
            }
        }
    }
}