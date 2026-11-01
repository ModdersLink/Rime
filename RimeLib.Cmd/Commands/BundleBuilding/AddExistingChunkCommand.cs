using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite.Core;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static RimeLib.Utils.RiffFile;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds an existing chunk to this bundle.")]
    internal class AddExistingChunkCommand : Command
    {
        [CommandArgument(Description = "The GUID of the chunk.")]
        public GUID? Guid { get; set; }

        // TODO: Make this portion a little less shit
        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = ((BundleBuildingContext)p_Context);
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            if (s_SbBuildingContext == null)
            {
                p_Writer.WriteLine("Parent context is invalid.");
                return false;
            }

            var s_BaseContext = s_SbBuildingContext.Parent as BaseContext;
            if ( s_BaseContext == null)
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

            if (!s_EngineMounter.TryGetChunk(Guid!, out var s_Chunk))
            {
                p_Writer.WriteLine($"Could not find chunk ({Guid}).");
                return false;
            }

            IChunkVariant? s_Variant;
            if (s_BundleContext.Cas())
            {
                // The cas builder content-addresses noncas frames, emitting a ref on a catalog hit and
                // idata otherwise, so falling back past the catalog-backed variants is fine.
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.Cas && p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.FirstVariant;
            }
            else
                s_Variant = s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetContainedBundle() != null);

            // Prefer a variant that still carries its asset name hash. The same chunk lives in
            // several bundles and only some of them stored meta for it; one that did not ships the
            // chunk with h32=0, which drops it out of the name-to-chunk reverse map -- a mesh's LOD
            // data is then in the bundle and the streamer cannot find it, so the object comes in
            // wrong or not at all. MEASURED on an exported MP_001: 566 of 607 chunks added this way
            // lost their hash. Same rule reference_existing_partition already follows.
            if (s_Variant != null && s_Variant.GetAssetNameHash() == null)
                s_Variant = s_Chunk.Variants.FirstOrDefault(
                        p_Chunk => p_Chunk.GetAssetNameHash() != null && p_Chunk.GetContainedBundle() != null)
                    ?? s_Chunk.Variants.FirstOrDefault(p_Chunk => p_Chunk.GetAssetNameHash() != null)
                    ?? s_Variant;

            if (s_Variant == null)
            {
                p_Writer.Write($"Could not find a valid variant of ({Guid}).");
                return false;
            }

            s_BundleContext.AddChunk(Guid!, s_Variant);

            return true;
        }
    }
}
