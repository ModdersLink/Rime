using System.Diagnostics;
using System.IO;

namespace RimeLib.Terrain.Rime
{
    public class HeightmapManager
    {
        public HeightmapManager()
        {

        }

        public HeightmapTile[]? GetTilesAt(int p_X, int p_Y, int p_Level, string p_BasePath)
        {
            var s_Path = Path.Combine(p_BasePath, $"{p_X}x{p_Y}x{p_Level}");

            if (!Directory.Exists(s_Path))
                return null;

            var s_TileX = p_X * 2;
            var s_TileY = p_Y * 2;
            var s_TileLevel = p_Level + 1;

            var s_Tile00Path = Path.Combine(s_Path, $"{s_TileX + 0}x{s_TileY + 0}x{s_TileLevel}.raw");
            var s_Tile01Path = Path.Combine(s_Path, $"{s_TileX + 0}x{s_TileY + 1}x{s_TileLevel}.raw");
            var s_Tile10Path = Path.Combine(s_Path, $"{s_TileX + 1}x{s_TileY + 0}x{s_TileLevel}.raw");
            var s_Tile11Path = Path.Combine(s_Path, $"{s_TileX + 1}x{s_TileY + 1}x{s_TileLevel}.raw");

            if (!File.Exists(s_Tile00Path) ||
                !File.Exists(s_Tile01Path) ||
                !File.Exists(s_Tile10Path) ||
                !File.Exists(s_Tile11Path))
                return null;

            Debug.WriteLine("Parsing tiles at {0}x{1}x{2} ({3})...", p_X, p_Y, p_Level, s_Path);

            var s_Tile00 = new HeightmapTile(s_TileX + 0, s_TileY + 0, s_TileLevel, 133, File.ReadAllBytes(s_Tile00Path));
            s_Tile00.SetChildren(GetTilesAt(s_TileX + 0, s_TileY + 0, s_TileLevel, s_Path));

            var s_Tile01 = new HeightmapTile(s_TileX + 0, s_TileY + 1, s_TileLevel, 133, File.ReadAllBytes(s_Tile01Path));
            s_Tile01.SetChildren(GetTilesAt(s_TileX + 0, s_TileY + 1, s_TileLevel, s_Path));

            var s_Tile10 = new HeightmapTile(s_TileX + 1, s_TileY + 0, s_TileLevel, 133, File.ReadAllBytes(s_Tile10Path));
            s_Tile10.SetChildren(GetTilesAt(s_TileX + 1, s_TileY + 0, s_TileLevel, s_Path));

            var s_Tile11 = new HeightmapTile(s_TileX + 1, s_TileY + 1, s_TileLevel, 133, File.ReadAllBytes(s_Tile11Path));
            s_Tile11.SetChildren(GetTilesAt(s_TileX + 1, s_TileY + 1, s_TileLevel, s_Path));

            return new[]
            {
                s_Tile00,
                s_Tile01,
                s_Tile10,
                s_Tile11
            };
        }

        public HeightmapTile[]? GetTilesAtSingle(int p_X, int p_Y, int p_Level, string p_BasePath)
        {
            var s_Path = Path.Combine(p_BasePath, $"{p_X}x{p_Y}x{p_Level}");

            if (!Directory.Exists(s_Path))
                return null;

            var s_TileX = p_X * 2;
            var s_TileY = p_Y * 2;
            var s_TileLevel = p_Level + 1;

            var s_Tile00Path = Path.Combine(s_Path, $"{s_TileX + 0}x{s_TileY + 0}x{s_TileLevel}.raw");
            var s_Tile01Path = Path.Combine(s_Path, $"{s_TileX + 0}x{s_TileY + 1}x{s_TileLevel}.raw");
            var s_Tile10Path = Path.Combine(s_Path, $"{s_TileX + 1}x{s_TileY + 0}x{s_TileLevel}.raw");
            var s_Tile11Path = Path.Combine(s_Path, $"{s_TileX + 1}x{s_TileY + 1}x{s_TileLevel}.raw");

            if (!File.Exists(s_Tile00Path) ||
                !File.Exists(s_Tile01Path) ||
                !File.Exists(s_Tile10Path) ||
                !File.Exists(s_Tile11Path))
                return null;

            Debug.WriteLine("Parsing tiles at {0}x{1}x{2} ({3})...", p_X, p_Y, p_Level, s_Path);

            var s_Tile00 = new HeightmapTile(s_TileX + 0, s_TileY + 0, s_TileLevel, 133, File.ReadAllBytes(s_Tile00Path));
            var s_Tile01 = new HeightmapTile(s_TileX + 0, s_TileY + 1, s_TileLevel, 133, File.ReadAllBytes(s_Tile01Path));
            var s_Tile10 = new HeightmapTile(s_TileX + 1, s_TileY + 0, s_TileLevel, 133, File.ReadAllBytes(s_Tile10Path));
            var s_Tile11 = new HeightmapTile(s_TileX + 1, s_TileY + 1, s_TileLevel, 133, File.ReadAllBytes(s_Tile11Path));

            return new[]
            {
                s_Tile00,
                s_Tile01,
                s_Tile10,
                s_Tile11
            };
        }
    }

}
