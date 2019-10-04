using RimeLib.Frostbite;

namespace RimeLib.Content.Mounting
{
    /// <summary>
    /// A factory that creates instances of engine mounters for a specific engine type.
    /// </summary>
    public interface IEngineMounterFactory
    {
        /// <summary>
        /// Get the engine type this mounter factory supports.
        /// </summary>
        /// <returns>The engine type.</returns>
        EngineType GetSupportedEngine();

        /// <summary>
        /// Create a new engine mounter instance.
        /// </summary>
        /// <returns>A new engine mounter instance.</returns>
        IEngineMounter Create();
    }
}
