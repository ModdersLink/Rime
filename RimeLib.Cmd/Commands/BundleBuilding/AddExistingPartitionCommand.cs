using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds an existing partition to this bundle.")]
    internal class AddExistingPartitionCommand : Command
    {
        [CommandArgument(Description = "The name of the partition.")]
        public string? Name { get; set; }

        // TODO: Make this portion a little less shit
        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            if (string.IsNullOrWhiteSpace(Name))
            {
                p_Writer.WriteLine("The specified resource could not be found.");
                return false;
            }

            var s_BundleContext = ((BundleBuildingContext)p_Context);
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            var s_BaseContext = s_SbBuildingContext.Parent as BaseContext;
            if (s_BaseContext == null)
            {
                p_Writer.WriteLine("SbBuildingContext parent is invalid.");
                return false;
            }

            // Get the list of mounters
            var s_Mounters = s_BaseContext.GetMounters();
            if (!s_Mounters.TryGetValue(Id, out var s_EngineMounter))
            {
                p_Writer.WriteLine($"Id ({Id}) is not valid, ensure you mounted a game first");
                return false;
            }

            // TODO: Once we have cross-engine support, remove this check
            var s_ContextEngineType = s_SbBuildingContext.EngineType;
            if (s_EngineMounter.GetEngineType() != s_ContextEngineType)
            {
                p_Writer.WriteLine($"Cross-engine support has not been added, ({s_EngineMounter.GetEngineType()} != {s_ContextEngineType})");
                return false;
            }

            if (!s_EngineMounter.TryGetPartition(Name!, out var s_Partition))
            {
                p_Writer.WriteLine($"Could not find partition ({Name}).");
                return false;
            }

            var s_Variant = s_Partition.FirstVariant;
            if (s_BundleContext.Cas())
                s_Variant = s_Partition.Variants.FirstOrDefault(p_Partition => p_Partition.Cas && p_Partition.GetContainedBundle() != null);
            
            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Name}).");
                return false;
            }

            s_BundleContext.AddPartition(Name!, s_Variant);

            return true;
        }
    }
}
