using System.IO;
using System.Linq;
using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;

namespace RimeLib.Cmd.Commands.Game
{
    [CommandDescription("Dumps each chunk's guid + h32 (AssetNameHash) for a mounted bundle. Used to verify chunk-meta linkage (h32=0 = missing meta -> UI-flow spin).")]
    public class DumpBundleChunkMetaCommand : Command
    {
        [CommandArgument(Description = "The name of the bundle.")]
        public string? Bundle { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_Chunks = ((GameContext)p_Context).GetBundleChunksWithHash(Bundle!).ToList();
            if (s_Chunks.Count == 0)
            {
                p_Writer.WriteLine("This bundle contains no chunks (or no chunk meta).");
                return true;
            }

            var s_Zero = 0;
            foreach (var s_Chunk in s_Chunks)
            {
                p_Writer.WriteLine($"CHUNKMETA: {s_Chunk.Guid:D} h32=0x{s_Chunk.AssetNameHash:X8} ({s_Chunk.AssetNameHash})");
                if (s_Chunk.AssetNameHash == 0) s_Zero++;
            }
            p_Writer.WriteLine($"dump_bundle_chunk_meta: {s_Chunks.Count} chunk(s), {s_Zero} with h32=0.");
            return true;
        }
    }
}
