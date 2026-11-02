using System.Collections.Generic;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// Resource types whose cookie (16-byte meta) an engine reads. Several subsystems implement it
    /// for one engine, each for the types it knows.
    /// </summary>
    public interface IResourceCookies : IEngineInterface
    {
        IReadOnlyCollection<ResourceType> Types { get; }

        ResourceCookie Read(ResourceType p_Type, byte[] p_Meta);
    }
}
