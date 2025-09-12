using System;
using System.IO;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Utils;

namespace RimeLib.Cmd.Commands.Base
{
    [CommandDescription("Mounts a game.")]
    public class MountGameCommand : Command
    {
        [CommandArgument(Description = "The path to the game to mount.")]
        public DirectoryInfo? Path { get; set; } = null;

        [CommandArgument(Description = "The engine type of the game.")]
        public EngineType Engine { get; set; }

        [CommandArgument(Description = "Whether to automatically mount all superbundles and their contained bundles. Defaults to false.", Optional = true)]
        public bool AutoMount { get; set; } = false;

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (!Path!.Exists)
            {
                p_Writer.WriteLine("The specified game path does not exist.");
                return false;
            }

            // Load the required support assemblies.
            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Content, Engine))
            {
                p_Writer.WriteLine($"Failed to load supporting content assembly for engine '{Engine}'. This means that the engine is not supported or that you are missing required files.");
                return false;
            }
            
            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Texture, Engine))
            {
                p_Writer.WriteLine($"Failed to load supporting texture assembly for engine '{Engine}'. This means that the engine is not supported or that you are missing required files.");
                return false;
            }
            
            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Serialization, Engine))
            {
                p_Writer.WriteLine($"Failed to load supporting serialization assembly for engine '{Engine}'. This means that the engine is not supported or that you are missing required files.");
                return false;
            }

            if (!AssemblyUtils.LoadSupportAssembly(AssemblyType.Mesh, Engine))
            {
                p_Writer.WriteLine($"Failed to load supporting Mesh assembly for engine '{Engine}'. This means that the engine is not supported or that you are missing required files.");
                return false;
            }

            // Create the mounter and mount the game.
            p_Writer.WriteLine("Mounting game. Please wait...");

            try
            {
                var s_Mounter = EngineInterfaceRegistry.Create<IEngineMounter>(Engine);
                s_Mounter.Mount(Path.FullName, AutoMount, Engine).Wait();

                // Register the mounter with the context.
                var s_MounterId = ((BaseContext)p_Context).RegisterMounter(s_Mounter);

                p_Writer.WriteLine($"Game successfully mounted with id '{s_MounterId}'.");

                return true;
            }
            catch (Exception s_Exception)
            {
                p_Writer.WriteLine();
                p_Writer.WriteLine("Failed to mount the game with the following error:");
                p_Writer.WriteLine(s_Exception.Message);
                
                return false;
            }
        }
    }
}
