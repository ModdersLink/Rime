using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using System;
using System.IO;

namespace RimeLib.Cmd.Commands.SbBuilding
{
    [CommandDescription("Adds an existing chunk to this superbundle.")]
    public class AddExistingChunkCommand : Command
    {
        [CommandArgument(Description = "The GUID of the chunk.")]
        public GUID? Guid { get; set; }

        [CommandArgument(Description = "Id returned by mount_game.")]
        public int Id { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BuildingContext = ((SbBuildingContext)p_Context);

            var s_ContextEngineType = s_BuildingContext.EngineType;
            // Get the base context
            var s_BaseContext = p_Context.Parent as BaseContext;
            if (s_BaseContext is null)
            {
                p_Writer.WriteLine("Parent is not base context, contact a dev.");
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

            // TODO: Ask nofate if adding a enum
            // specifying where this came from (Variant->Readable->[Sb,Cas,Bundle]ChunkEntry)
            // That would allow us to do some filtering and sorting

            ((SbBuildingContext)p_Context).AddChunk(Guid!, s_Chunk.FirstVariant);

            return true;
        }
    }
}
