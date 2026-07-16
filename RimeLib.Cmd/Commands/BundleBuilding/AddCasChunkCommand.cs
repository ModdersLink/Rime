using RimeLib.Cmd.Attributes;
using RimeLib.Cmd.Contexts;
using RimeLib.Frostbite.Core;
using System.IO;

namespace RimeLib.Cmd.Commands.BundleBuilding
{
    [CommandDescription("Adds a catalog-backed chunk to this bundle DIRECTLY from an {id, sha1} pair " +
        "(e.g. copied from another bundle's manifest). add_existing_chunk only finds TOC-LISTED chunks " +
        "(the mounter's chunk index); BUNDLE-manifest chunks (level sound/ambient/gamemode stream " +
        "payloads) are invisible to it — this command emits them as pure cas refs regardless. Used by " +
        "the exact-manifest bundle clone (dicepair) to carry the loose stream chunks whose absence " +
        "freezes the level load. Replaces any same-id chunk already in the bundle.")]
    internal class AddCasChunkCommand : Command
    {
        [CommandArgument(Description = "The GUID of the chunk (from the source bundle manifest).")]
        public GUID? ChunkId { get; set; }

        [CommandArgument(Description = "The 40-hex-char SHA1 of the chunk payload (from the source manifest; must exist in cas.cat).")]
        public string? Sha1 { get; set; }

        [CommandArgument(Description = "Optional chunkMeta h32 (int, fnv of the owner asset name) when the source manifest entry had one.", Optional = true)]
        public string? H32 { get; set; }

        [CommandArgument(Description = "Optional chunkMeta meta.firstMip when the source manifest entry had one.", Optional = true)]
        public string? FirstMip { get; set; }

        [CommandArgument(Description = "Optional rangeStart when the source manifest entry was RANGED ('-' = none).", Optional = true)]
        public string? RangeStart { get; set; }

        [CommandArgument(Description = "Optional rangeEnd.", Optional = true)]
        public string? RangeEnd { get; set; }

        [CommandArgument(Description = "Optional logicalOffset.", Optional = true)]
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
                p_Writer.WriteLine("usage: add_cas_chunk <chunkGuid> <sha1hex> [h32] [firstMip]");
                return false;
            }

            var s_Mounter = System.Linq.Enumerable.FirstOrDefault(s_BaseContext.GetMounters().Values)
                            as RimeLib.Content.Frostbite2_0.Mounting.EngineMounter;
            if (s_Mounter == null)
            {
                p_Writer.WriteLine("add_cas_chunk: no Frostbite2_0 mounter.");
                return false;
            }

            int? s_H32 = null, s_FirstMip = null;
            if (!string.IsNullOrWhiteSpace(H32) && H32 != "-" && int.TryParse(H32, out var s_H)) s_H32 = s_H;
            if (!string.IsNullOrWhiteSpace(FirstMip) && FirstMip != "-" && int.TryParse(FirstMip, out var s_F)) s_FirstMip = s_F;
            uint? s_RS = null, s_RE = null, s_LO = null;
            if (!string.IsNullOrWhiteSpace(RangeStart) && RangeStart != "-" && uint.TryParse(RangeStart, out var s_A)) s_RS = s_A;
            if (!string.IsNullOrWhiteSpace(RangeEnd) && RangeEnd != "-" && uint.TryParse(RangeEnd, out var s_B)) s_RE = s_B;
            if (!string.IsNullOrWhiteSpace(LogicalOffset) && LogicalOffset != "-" && uint.TryParse(LogicalOffset, out var s_C)) s_LO = s_C;

            if (!s_Mounter.TryMakeCasChunkVariant(ChunkId, Sha1!, out var s_Variant, s_H32, s_FirstMip, s_RS, s_RE, s_LO))
            {
                p_Writer.WriteLine($"add_cas_chunk: sha1 not in catalog for chunk {ChunkId} ({Sha1}).");
                return false;
            }

            try { s_BundleContext.RemoveChunk(ChunkId); } catch { }
            s_BundleContext.AddChunk(ChunkId, s_Variant);
            p_Writer.WriteLine($"cas-chunk {ChunkId} added (sha1 {Sha1}, {(s_H32.HasValue ? "h32=" + s_H32 : "no meta")}).");
            return true;
        }
    }
}
