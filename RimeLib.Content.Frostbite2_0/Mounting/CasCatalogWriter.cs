using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using RimeLib.Content.Mounting;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Frostbite2_0.Mounting
{
    /// <summary>Frostbite 2 cas catalogs, kept by the <see cref="EngineMounter"/>.</summary>
    public class CasCatalogWriter : ICasCatalogWriter
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        public string BuildCatalog(IEngineMounter p_Mounter, IEnumerable<string> p_Names, string p_OutDir, uint p_StartIndex, IEnumerable<GUID> p_ChunkIds) =>
            ((EngineMounter)p_Mounter).BuildCasCatalog(p_Names, p_OutDir, p_StartIndex, p_ChunkIds);

        public string MountExternalCatalog(IEngineMounter p_Mounter, string p_CatPath) =>
            ((EngineMounter)p_Mounter).MountExternalCatalog(p_CatPath);

        public IEnumerable<(GUID Id, Sha1? Sha1)> GetTocChunks(IEngineMounter p_Mounter, string p_Superbundle) =>
            ((EngineMounter)p_Mounter).GetSuperbundleTocChunks(p_Superbundle);

        public bool TryMakeChunkVariant(IEngineMounter p_Mounter, GUID p_Id, string p_Sha1Hex, [NotNullWhen(true)] out IChunkVariant? p_Variant,
            int? p_AssetNameHash, int? p_FirstMip, uint? p_RangeStart, uint? p_RangeEnd, uint? p_LogicalOffset) =>
            ((EngineMounter)p_Mounter).TryMakeCasChunkVariant(p_Id, p_Sha1Hex, out p_Variant, p_AssetNameHash, p_FirstMip, p_RangeStart, p_RangeEnd, p_LogicalOffset);
    }
}
