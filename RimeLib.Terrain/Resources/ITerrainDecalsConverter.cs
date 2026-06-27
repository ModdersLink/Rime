using RimeLib.IO;

namespace RimeLib.Terrain.Resources
{
    /// <summary>
    /// Per-engine (de)serializer for the TerrainDecals (.decals) resource. Resolved via
    /// <see cref="EngineInterfaceRegistry"/> by engine type, like the other resource converters.
    /// Reading a resource and writing it straight back is byte-identical to the original.
    /// </summary>
    public interface ITerrainDecalsConverter : IEngineInterface
    {
        TerrainDecalsResource Read(RimeReader p_Reader);
        void Write(RimeWriter p_Writer, TerrainDecalsResource p_Decals);
    }
}
