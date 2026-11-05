using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// Builds and chains cas catalogs for a mounted game, so a build can reference stored frames by
    /// sha1 instead of embedding them.
    /// </summary>
    public interface ICasCatalogWriter : IEngineInterface
    {
        /// <summary>
        /// Writes a cas.cat and its cas files holding the stored frames of the named objects and
        /// chunks that no mounted catalog holds yet. Returns a summary line.
        /// </summary>
        string BuildCatalog(IEngineMounter p_Mounter, IEnumerable<string> p_Names, string p_OutDir, uint p_StartIndex, IEnumerable<GUID> p_ChunkIds);

        /// <summary>Chains an external cas.cat onto the mounted catalogs for builds only. Returns a summary line.</summary>
        string MountExternalCatalog(IEngineMounter p_Mounter, string p_CatPath);

        /// <summary>The chunks a superbundle's toc lists, with their sha1 when they are cas-backed.</summary>
        IEnumerable<(GUID Id, Sha1? Sha1)> GetTocChunks(IEngineMounter p_Mounter, string p_Superbundle);

        /// <summary>
        /// A catalog-backed chunk variant from an id and sha1, with its range and chunk meta given by
        /// the caller. Fails when no mounted catalog holds the hash.
        /// </summary>
        bool TryMakeChunkVariant(IEngineMounter p_Mounter, GUID p_Id, string p_Sha1Hex, [NotNullWhen(true)] out IChunkVariant? p_Variant,
            int? p_AssetNameHash, int? p_FirstMip, uint? p_RangeStart, uint? p_RangeEnd, uint? p_LogicalOffset);
    }
}
