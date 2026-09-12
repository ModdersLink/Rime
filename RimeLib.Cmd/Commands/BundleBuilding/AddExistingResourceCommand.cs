using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds an existing resource to this bundle.")]
    internal class AddExistingResourceCommand : Command
    {
        [CommandArgument(Description = "The name of the resource.")]
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

            if (!s_EngineMounter.TryGetResource(Name!, out var s_Resource))
            {
                p_Writer.WriteLine($"Could not find resource ({Name}).");
                return false;
            }

            IResourceVariant? s_Variant;

            if (s_BundleContext.Cas())
            {
                // Prefer a cas-backed variant, but do not require one. BF3 ships plenty of resources
                // only in noncas bundles, and the cas manifest builder content-addresses a noncas
                // frame anyway -- bare sha1 ref on a catalog hit, idata otherwise. Requiring one
                // dropped 640 of 1192 resources on a level build and the 621 chunks their payloads
                // name with them, while the superbundle still built without error and listed the
                // same partitions as the noncas one. Same fallback chain add_existing_chunk and
                // reference_existing_partition already use.
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.Cas && p_Resource.GetContainedBundle() != null)
                    ?? s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null)
                    ?? s_Resource.FirstVariant;
            }
            else
                s_Variant = s_Resource.Variants.FirstOrDefault(p_Resource => p_Resource.GetContainedBundle() != null);

            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Name}).");
                return false;
            }

            s_BundleContext.AddResource(Name!, s_Variant);

            return true;
        }
    }
}
