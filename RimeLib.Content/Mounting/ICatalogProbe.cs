using RimeLib.Frostbite.Core;

namespace RimeLib.Content.Mounting
{
    /// <summary>A mounter that can tell whether the game's catalogs hold a blob, so a cas build can reference it instead of embedding it.</summary>
    public interface ICatalogProbe
    {
        bool CatalogContainsEntry(Sha1 p_Hash);
    }
}
