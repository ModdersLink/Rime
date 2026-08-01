using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Content.Frostbite2_0.Mounting;
using RimeLib.Frostbite.Core;
using System.IO;
using System.Linq;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a catalog-backed chunk from an id and sha1 pair, with its range and chunkMeta given explicitly and no need to mount the bundle it came from. Replaces any chunk already under that id.")]
    internal class AddCasChunkCommand : Command
    {
        // Prefer add_existing_chunk: mounting the source bundle also makes its manifest chunks
        // resolvable, and the variant then carries its own range and meta. This command exists for the
        // cases that has no answer for, namely copying an entry straight out of a manifest dump and
        // cutting a range that no mounted variant has, such as the tail range cap_texture needs.
        [CommandArgument(Description = "The GUID of the chunk, from the source bundle manifest.")]
        public GUID? ChunkId { get; set; }

        [CommandArgument(Description = "The chunk payload's 40-hex-character SHA1. Must exist in a mounted catalog.")]
        public string? Sha1 { get; set; }

        [CommandArgument(Description = "chunkMeta h32, the hash of the owner asset's name, when the source entry had one.", Optional = true)]
        public string? H32 { get; set; }

        [CommandArgument(Description = "chunkMeta meta.firstMip, which retail keeps equal to the header's MipmapBaseIndex.", Optional = true)]
        public string? FirstMip { get; set; }

        // A ranged entry has to keep its range: widening a slice to the whole payload leaves the
        // texture header disagreeing with its chunk and the texture then fails to create.
        [CommandArgument(Description = "rangeStart, when the source entry was ranged. '-' for none.", Optional = true)]
        public string? RangeStart { get; set; }

        [CommandArgument(Description = "rangeEnd. Defaults to the end of the payload.", Optional = true)]
        public string? RangeEnd { get; set; }

        [CommandArgument(Description = "logicalOffset, the payload offset the range starts at.", Optional = true)]
        public string? LogicalOffset { get; set; }

        public override bool Execute(ref ExecutionContext p_Context, TextWriter p_Writer)
        {
            var s_BundleContext = (BundleBuildingContext)p_Context;
            var s_SbBuildingContext = (SbBuildingContext?)s_BundleContext.Parent;
            var s_BaseContext = s_SbBuildingContext?.Parent as BaseContext;
            if (s_SbBuildingContext == null || s_BaseContext == null)
            {
                p_Writer.WriteLine("Context is invalid.");
                return false;
            }

            if (ChunkId == null || string.IsNullOrWhiteSpace(Sha1))
            {
                p_Writer.WriteLine("usage: add_cas_chunk <chunkGuid> <sha1hex> [h32] [firstMip] [rangeStart] [rangeEnd] [logicalOffset]");
                return false;
            }

            var s_Mounter = s_BaseContext.GetMounters().Values.FirstOrDefault() as EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("add_cas_chunk: no Frostbite2_0 mounter.");
                return false;
            }

            var s_H32 = ParseInt(H32);
            var s_FirstMip = ParseInt(FirstMip);
            var s_RangeStart = ParseUInt(RangeStart);
            var s_RangeEnd = ParseUInt(RangeEnd);
            var s_LogicalOffset = ParseUInt(LogicalOffset);

            if (!s_Mounter.TryMakeCasChunkVariant(ChunkId, Sha1!, out var s_Variant,
                    s_H32, s_FirstMip, s_RangeStart, s_RangeEnd, s_LogicalOffset))
            {
                p_Writer.WriteLine($"add_cas_chunk: sha1 not in catalog for chunk {ChunkId} ({Sha1}).");
                return false;
            }

            try { s_BundleContext.RemoveChunk(ChunkId); } catch { }
            s_BundleContext.AddChunk(ChunkId, s_Variant);

            p_Writer.WriteLine($"cas-chunk {ChunkId} added (sha1 {Sha1}, {(s_H32.HasValue ? "h32=" + s_H32 : "no meta")}).");
            return true;
        }

        private static int? ParseInt(string? p_Value)
        {
            if (string.IsNullOrWhiteSpace(p_Value) || p_Value == "-")
                return null;
            return int.TryParse(p_Value, out var s_Parsed) ? s_Parsed : null;
        }

        private static uint? ParseUInt(string? p_Value)
        {
            if (string.IsNullOrWhiteSpace(p_Value) || p_Value == "-")
                return null;
            return uint.TryParse(p_Value, out var s_Parsed) ? s_Parsed : null;
        }
    }
}
