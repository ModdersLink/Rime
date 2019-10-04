using System.Collections.Generic;
using System.Threading.Tasks;
using RimeLib.Content.Frostbite;
using RimeLib.Frostbite;
using RimeLib.Frostbite.Core;
using RimeLib.Frostbite.Db;

namespace RimeLib.Content.Mounting
{
    public interface IObjectVariant : IReadableObject
    {
        string GetContainedSuperbundle();
        string? GetContainedBundle();
    }

    public interface IResourceVariant : IObjectVariant
    {
        ResourceType GetResourceType();
        bool TryGetMeta(out DbObject? p_Meta);
    }

    public interface IChunkVariant : IObjectVariant
    {
        bool TryGetMeta(out DbObject? p_Meta);
    }

    /// <summary>
    /// Represents a mounted game object (eg. a resource or chunk) and holds
    /// a collection of all the different mounted variants of this object,
    /// contained in different bundles or superbundles.
    /// </summary>
    /// <typeparam name="T">The variant type.</typeparam>
    public interface IMountedObject<T> where T : IObjectVariant
    {
        IEnumerable<T> Variants { get; }
        T FirstVariant { get; }
    }

    public interface IMountedObject : IMountedObject<IObjectVariant> {}

    public interface IEngineMounter
    {
        /// <summary>
        /// Get the engine type this mounter supports.
        /// </summary>
        /// <returns>The engine type.</returns>
        EngineType GetSupportedEngine();

        /// <summary>
        /// Mount the game at the specified path.
        /// </summary>
        /// <param name="p_GamePath">The path of the game.</param>
        /// <param name="p_AutoMount">Whether to automatically mount superbundles and their contained bundles.</param>
        Task Mount(string p_GamePath, bool p_AutoMount);

        /// <summary>
        /// List all the available superbundles in the currently mounted game.
        /// </summary>
        /// <returns>A list of superbundle names.</returns>
        IEnumerable<string> GetAvailableSuperbundles();

        /// <summary>
        /// Mount a specific superbundle by its name.
        /// </summary>
        /// <param name="p_Superbundle">The name of the superbundle.</param>
        /// <param name="p_AutoMount">Whether to automatically mount the contained bundles.</param>
        Task MountSuperbundle(string p_Superbundle, bool p_AutoMount);

        /// <summary>
        /// List all the available bundles in the currently mounted superbundles.
        /// </summary>
        /// <returns>A list of bundle names.</returns>
        IEnumerable<string> GetAvailableBundles();

        /// <summary>
        /// Mount a specific bundle by its name.
        /// </summary>
        /// <param name="p_Bundle">The name of the bundle.</param>
        Task MountBundle(string p_Bundle);

        /// <summary>
        /// List all the resources contained in a specific mounted bundle.
        /// </summary>
        /// <param name="p_Bundle">The name of the bundle.</param>
        /// <returns>A list of resource names.</returns>
        IEnumerable<string> GetResourcesInBundle(string p_Bundle);

        /// <summary>
        /// List all the chunks contained in a specific mounted bundle.
        /// </summary>
        /// <param name="p_Bundle">The name of the bundle.</param>
        /// <returns>A list of chunk ids.</returns>
        IEnumerable<GUID> GetChunksInBundle(string p_Bundle);

        /// <summary>
        /// List all the partitions contained in a specific mounted bundle.
        /// </summary>
        /// <param name="p_Bundle">The name of the bundle.</param>
        /// <returns>A list of partition names.</returns>
        IEnumerable<string> GetPartitionsInBundle(string p_Bundle);

        /// <summary>
        /// Try to get a mounted resource. The resource will be provided in an output parameter.
        /// </summary>
        /// <param name="p_Path">The path to the resource.</param>
        /// <param name="p_Resource">The output resource object.</param>
        /// <returns>When the return value is `true` then the output will **not** be `null`. When it's `false` it **will** be `null`.</returns>
        bool TryGetResource(string p_Path, out IMountedObject<IResourceVariant>? p_Resource);

        /// <summary>
        /// Try to get a mounted chunk. The chunk will be provided in an output parameter.
        /// </summary>
        /// <param name="p_GUID">The id of the chunk.</param>
        /// <param name="p_Chunk">The output chunk object.</param>
        /// <returns>When the return value is `true` then the output will **not** be `null`. When it's `false` it **will** be `null`.</returns>
        bool TryGetChunk(GUID p_GUID, out IMountedObject<IChunkVariant>? p_Chunk);

        /// <summary>
        /// Try to get a mounted partition. The partition will be provided in an output parameter.
        /// </summary>
        /// <param name="p_Path">The path to the partition.</param>
        /// <param name="p_Partition">The output partition object.</param>
        /// <returns>When the return value is `true` then the output will **not** be `null`. When it's `false` it **will** be `null`.</returns>
        bool TryGetPartition(string p_Path, out IMountedObject? p_Partition);
    }
}
