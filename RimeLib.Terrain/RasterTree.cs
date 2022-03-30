using System.Diagnostics.CodeAnalysis;
using RimeLib.Frostbite;
using RimeLib.IO;

namespace RimeLib.Terrain
{
    public abstract class RasterTree : IFbSerializable
    {
        public enum RasterTreeTypes
        {
            HeightfieldTreeType = 0x0,
            TerrainMaskTreeType = 0x1,
            TerrainColorTreeType = 0x2,
            TerrainMaterialTreeType = 0x3,
            DestructionDepthTreeType = 0x4,
            StreamableRasterTreeTypeCount = 0x3,
            RasterTreeTypeCount = 0x5,
            RasterTreeTypeInvalid = 0xFF
        };

        public abstract bool Serialize(RimeWriter p_Writer);
        public abstract bool Serialize([NotNullWhen(true)] out byte[]? p_Data);
        public abstract void Deserialize(RimeReader p_Reader);
        public abstract void Deserialize(byte[] p_Data);
    }

}
