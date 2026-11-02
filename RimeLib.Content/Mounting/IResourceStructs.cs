using System.Collections.Generic;
using RimeLib.Content.Frostbite;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// Resource types an engine reads into structs and writes back. Several subsystems implement it
    /// for one engine (textures, meshes, terrain, ...), each for the types it knows; a writer is
    /// trusted once writing an unchanged resource gives back its bytes.
    /// </summary>
    public interface IResourceStructs : IEngineInterface
    {
        IReadOnlyCollection<ResourceType> Types { get; }

        /// <summary>Reads a resource's payload (with its meta, where the type has one) and writes it back.</summary>
        byte[] RoundTrip(ResourceType p_Type, byte[] p_Data, byte[]? p_Meta);
    }
}
