using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite;
using RimeLib.Utils;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Enters the superbundle building context.")]
    public class BuildSbCommand : Command
    {
        [CommandArgument(Description = "The name of the superbundle to build.")]
        public string? Name { get; set; }

        [CommandArgument(Description = "The target engine type for the built superbundle.")]
        public EngineType Engine { get; set; }

        [CommandArgument(Description = "The folder to put the built superbundle in. Will be created if it doesn't exist.")]
        public DirectoryInfo? OutputPath { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            try
            {
                OutputPath!.Create();
            }
            catch
            {
                p_Writer.WriteLine("Could not create the output directory. Please verify that your path is correct and that you have the required access.");
                return false;
            }

            // TODO: Make sure that the Sb name is valid.

            // Load the required support assemblies.
            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, Engine))
            {
                p_Writer.WriteLine($"Failed to load supporting content assembly for engine '{Engine}'. This means that the engine is not supported or that you are missing required files.");
                return false;
            }

            // Create a new sb building context and replace our current one with it.
            p_Context = new SbBuildingContext((BaseContext) p_Context, Engine, OutputPath!.FullName, Name!);
            return true;
        }
    }
}
