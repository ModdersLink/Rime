using RimeLib.Frostbite;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// The chunk meta a bundle lists for a chunk added from a file: its owner's name hash and, for a
    /// texture, the mip its data starts at.
    /// </summary>
    public interface IChunkMetaWriter : IEngineInterface
    {
        DbObject Create(int? p_AssetNameHash, int? p_FirstMip);
    }
}
