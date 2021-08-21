using RimeLib.IO;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace RimeLib.Terrain.Rime
{
    public class HeightmapTile
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Level { get; set; }
        public int Resolution { get; set; }

        private readonly ushort[] m_Data;
        private HeightmapTile[] m_Children;
        private HeightmapTile? m_Parent;

        //public static readonly Empty = new HeightmapTile { X = 0, Y = 0, Level = 0, Resolution = 0 };

        public HeightmapTile(int p_X, int p_Y, int p_Level, int p_Resolution)
        {
            if (p_Resolution != 133)
                throw new Exception("Unsupported tile resolution.");

            X = p_X;
            Y = p_Y;
            Level = p_Level;
            Resolution = p_Resolution - 4;
            m_Data = new ushort[Resolution * Resolution];
            m_Children = Array.Empty<HeightmapTile>();
            m_Parent = null;
        }

        public HeightmapTile(int p_X, int p_Y, int p_Level, int p_Resolution, byte[] p_Data)
        {
            if (p_Resolution != 133)
                throw new Exception("Unsupported tile resolution.");

            X = p_X;
            Y = p_Y;
            Level = p_Level;
            Resolution = p_Resolution - 4;
            m_Data = new ushort[Resolution * Resolution];
            m_Children = Array.Empty<HeightmapTile>();
            m_Parent = null;

            using (var s_Reader = new RimeReader(new MemoryStream(p_Data)))
                ParseTile(s_Reader);

            Debug.WriteLine($"{m_MinHeight} - {m_MaxHeight}");
        }

        public HeightmapTile(int p_X, int p_Y, int p_Level, int p_Resolution, RimeReader p_Reader)
        {
            if (p_Resolution != 133)
                throw new Exception("Unsupported tile resolution.");

            X = p_X;
            Y = p_Y;
            Level = p_Level;
            Resolution = p_Resolution - 4;
            m_Data = new ushort[Resolution * Resolution];
            m_Children = Array.Empty<HeightmapTile>();
            m_Parent = null;

            ParseTile(p_Reader);
        }

        public void SetChildren(HeightmapTile[]? p_Children)
        {
            if (p_Children is null)
                return;

            if (p_Children == null)
                return;

            if (p_Children != null && p_Children.Length != 4)
                return;

#pragma warning disable CS8601 // Possible null reference assignment.
            m_Children = p_Children;
#pragma warning restore CS8601 // Possible null reference assignment.

            if (m_Children == null)
                return;

            // Set parent to self.
            foreach (var s_Child in m_Children)
                s_Child.m_Parent = this;
        }

        public ushort Get(int p_X, int p_Y)
        {
            if (p_X < 0 || p_X >= Resolution ||
                p_Y < 0 || p_Y >= Resolution)
                return 0;

            return m_Data[p_X + (p_Y * Resolution)];
        }

        private static ushort m_MaxHeight = ushort.MinValue;
        private static ushort m_MinHeight = ushort.MaxValue;

        public void Set(int p_X, int p_Y, ushort p_Height, ushort p_Binary)
        {
            if (p_X < 0 || p_X >= Resolution ||
                p_Y < 0 || p_Y >= Resolution)
                return;

            if (p_Height > m_MaxHeight)
                m_MaxHeight = p_Height;

            if (p_Height < m_MinHeight)
                m_MinHeight = p_Height;

            m_Data[p_X + (p_Y * Resolution)] = p_Height;
        }

        public ushort[] GetData(int p_Resolution)
        {
            if (((p_Resolution - 1) & (p_Resolution - 2)) != 0)
                throw new Exception("Heightmap tiles can only be exported in power-of-two plus 1 resolutions.");

            if (m_Children != null)
                return StitchChildrenData(p_Resolution);

            if (p_Resolution == Resolution)
                return m_Data;

            var s_Data = new ushort[p_Resolution * p_Resolution];

            var s_Ratio = (float)(Resolution - 1) / p_Resolution;
            var s_Offset = 0;

            // TODO: Do we need to use a different interpolation algorithm?
            for (var i = 0; i < p_Resolution; ++i)
            {
                for (var j = 0; j < p_Resolution; ++j)
                {
                    var s_X = (int)(s_Ratio * j);
                    var s_Y = (int)(s_Ratio * i);

                    var s_XDiff = (s_Ratio * j) - s_X;
                    var s_YDiff = (s_Ratio * i) - s_Y;

                    var s_Index = s_Y * Resolution + s_X;

                    var s_A = m_Data[s_Index];
                    var s_B = m_Data[s_Index + 1];
                    var s_C = m_Data[s_Index + Resolution];
                    var s_D = m_Data[s_Index + Resolution + 1];

                    var s_Gray = s_A * (1.0f - s_XDiff) * (1.0f - s_YDiff) + s_B * (s_XDiff) * (1.0f - s_YDiff) + s_C * (s_YDiff) * (1.0f - s_XDiff) + s_D * (s_XDiff * s_YDiff);
                    s_Data[s_Offset++] = (ushort)s_Gray;
                }
            }

            return s_Data;
        }

        public HeightmapTile? GetChild(int p_X, int p_Y)
        {
            if (m_Children == null)
                return null;

            var s_X = (X * 2) + p_X;
            var s_Y = (Y * 2) + p_Y;
            var s_Level = Level + 1;

            return m_Children.FirstOrDefault(p_Child => p_Child.X == s_X && p_Child.Y == s_Y && p_Child.Level == s_Level);
        }

        public byte[] Serialize(int p_Resolution)
        {
            if (((p_Resolution - 1) & (p_Resolution - 2)) != 0)
                throw new Exception("Heightmap tiles can only be exported in power-of-two plus 1 resolutions.");

            var s_Data = GetData(p_Resolution);

            using (var s_Writer = new RimeWriter(new MemoryStream()))
            {
                foreach (var s_Pixel in s_Data)
                    s_Writer.Write(s_Pixel);

                return ((MemoryStream)s_Writer.BaseStream).ToArray();
            }
        }

        public byte[]? Generate()
        {
            // TODO: Generate original 133x133 tile based on self, neighbor, parent data.
            return null;
        }

        protected ushort[] StitchChildrenData(int p_Resolution)
        {
            var s_Data = new ushort[p_Resolution * p_Resolution];

            var s_HalfResolution = (p_Resolution - 1) / 2;

            var s_ChildData = new ushort[4][];

            for (var y = 0; y < 2; ++y)
            {
                for (var x = 0; x < 2; ++x)
                {
                    var s_ChildTile = GetChild(x, y);

                    if (s_ChildTile == null)
                        throw new Exception($"Unable to find child tile for coordinates {x}x{y}.");

                    s_ChildData[x + (y * 2)] = s_ChildTile.GetData(s_HalfResolution + 1);
                }
            }

            for (var y = 0; y < p_Resolution; ++y)
            {
                for (var x = 0; x < p_Resolution; ++x)
                {
                    var s_TileX = x / s_HalfResolution;
                    var s_TileY = y / s_HalfResolution;

                    var s_DataX = x % s_HalfResolution;
                    var s_DataY = y % s_HalfResolution;

                    // Handle last-pixel edges.
                    if (s_TileX == 2)
                    {
                        s_TileX = 1;
                        s_DataX = s_HalfResolution;
                    }

                    if (s_TileY == 2)
                    {
                        s_TileY = 1;
                        s_DataY = s_HalfResolution;
                    }

                    s_Data[x + (y * p_Resolution)] = s_ChildData[s_TileX + (s_TileY * 2)][s_DataX + (s_DataY * (s_HalfResolution + 1))];
                }
            }

            return s_Data;
        }

        protected void ParseTile(RimeReader p_Reader)
        {
            for (var y = 0; y < Resolution + 4; ++y)
            {
                for (var x = 0; x < Resolution + 4; ++x)
                {
                    if (y < 2 || x < 2 || y - 2 >= Resolution || x - 2 >= Resolution)
                    {
                        p_Reader.ReadUInt16();
                        continue;
                    }

                    var s_Binary = p_Reader.ReadUInt16();
                    Set(x - 2, y - 2, s_Binary, s_Binary);
                }
            }
        }
    }

}
