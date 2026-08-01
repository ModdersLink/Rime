using System;
using System.Collections.Generic;
using System.IO;
using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.IO.Conversion;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0
{
    /// <summary>
    /// Frostbite 2 (BF3) TerrainDecals (.decals) (de)serializer. Mirrors bree's 010 template
    /// (External/010templates/bree/fb2/TerrainDecals.bt). Little-endian, no alignment,
    /// null-terminated strings (no length prefix). Reading then writing back is byte-identical.
    ///
    /// Layout:
    ///   float decal3dFarDrawDistance, float decal2dNearDrawDistance,
    ///   uint  decalCellsPerHeightfieldTileSide, byte decalDestructionMaskEnable,
    ///   then three geometries in order: 2d, 3d, water. Each:
    ///     uint blockCount; if != 0 { Block[blockCount]; uint vBytes; uint iBytes;
    ///                                vertices[vBytes/vsize]; uint indices[iBytes/4]; }
    /// </summary>
    public class TerrainDecalsConverter : ITerrainDecalsConverter
    {
        public EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        public static int VertexSize(DecalGeometryKind p_Kind) => p_Kind switch
        {
            DecalGeometryKind.Decal2d => 24, // 2 floats pos + 2 floats uv + 4 ushort masks
            DecalGeometryKind.Decal3d => 28, // 3 floats pos + 2 floats uv + 4 ushort masks
            DecalGeometryKind.Water => 36,   // 18 packed ushorts
            _ => throw new ArgumentOutOfRangeException(nameof(p_Kind)),
        };

        public TerrainDecalsResource Read(RimeReader p_Reader)
        {
            // The format is always little-endian on PC, but some resource variants hand back a reader
            // configured big-endian, which misreads every count and ends in an unbounded allocation.
            p_Reader.Endianness = Endianness.LittleEndian;

            var s_Decals = new TerrainDecalsResource
            {
                Decal3dFarDrawDistance = p_Reader.ReadSingle(),
                Decal2dNearDrawDistance = p_Reader.ReadSingle(),
                DecalCellsPerHeightfieldTileSide = p_Reader.ReadUInt32(),
                DecalDestructionMaskEnable = p_Reader.ReadUByte(),
            };

            s_Decals.Geometry2d = ReadGeometry(p_Reader, DecalGeometryKind.Decal2d);
            s_Decals.Geometry3d = ReadGeometry(p_Reader, DecalGeometryKind.Decal3d);
            s_Decals.GeometryWater = ReadGeometry(p_Reader, DecalGeometryKind.Water);
            return s_Decals;
        }

        public void Write(RimeWriter p_Writer, TerrainDecalsResource p_Decals)
        {
            p_Writer.Endianness = Endianness.LittleEndian;
            p_Writer.Write(p_Decals.Decal3dFarDrawDistance);
            p_Writer.Write(p_Decals.Decal2dNearDrawDistance);
            p_Writer.Write(p_Decals.DecalCellsPerHeightfieldTileSide);
            p_Writer.Write(p_Decals.DecalDestructionMaskEnable);

            WriteGeometry(p_Writer, p_Decals.Geometry2d, DecalGeometryKind.Decal2d);
            WriteGeometry(p_Writer, p_Decals.Geometry3d, DecalGeometryKind.Decal3d);
            WriteGeometry(p_Writer, p_Decals.GeometryWater, DecalGeometryKind.Water);
        }

        // Smallest possible on-disk Block (two empty null-terminated strings + the fixed fields):
        // 1 + 1 + uint StartIndex + uint PrimitiveCount + 6 floats bbox + 6 floats bbox2 +
        // float DrawDistance + uint VertexBegin + uint VertexEnd = 70 bytes.
        private const long MinBlockBytes = 70;

        private static DecalGeometry ReadGeometry(RimeReader p_Reader, DecalGeometryKind p_Kind)
        {
            var s_Geometry = new DecalGeometry { BlockCount = p_Reader.ReadUInt32() };
            if (s_Geometry.BlockCount == 0)
                return s_Geometry;

            // Sanity-bound the counts against the bytes left in the stream. A mis-read resource
            // (e.g. a DLC variant read without decompression) yields garbage counts; without this
            // guard `new List(count)` + the read loop allocate unbounded (observed: 25 GB / hang).
            var s_Remaining = p_Reader.Length - p_Reader.Position;
            if (s_Geometry.BlockCount > s_Remaining / MinBlockBytes)
                throw new InvalidDataException(
                    $"TerrainDecals {p_Kind} blockCount={s_Geometry.BlockCount} exceeds the {s_Remaining} bytes left " +
                    "(corrupt/mis-read .decals resource).");

            for (var i = 0u; i < s_Geometry.BlockCount; ++i)
                s_Geometry.Blocks.Add(ReadBlock(p_Reader));

            var s_VerticesByteCount = p_Reader.ReadUInt32();
            var s_IndicesByteCount = p_Reader.ReadUInt32();

            s_Remaining = p_Reader.Length - p_Reader.Position;
            if ((long) s_VerticesByteCount + s_IndicesByteCount > s_Remaining)
                throw new InvalidDataException(
                    $"TerrainDecals {p_Kind} vertex/index byte counts ({s_VerticesByteCount}+{s_IndicesByteCount}) " +
                    $"exceed the {s_Remaining} bytes left (corrupt/mis-read .decals resource).");

            var s_VertexCount = s_VerticesByteCount / (uint) VertexSize(p_Kind);

            if (p_Kind == DecalGeometryKind.Water)
            {
                s_Geometry.WaterVertices = new List<DecalWaterVertex>((int) s_VertexCount);
                for (var v = 0u; v < s_VertexCount; ++v)
                    s_Geometry.WaterVertices.Add(ReadWaterVertex(p_Reader));
            }
            else
            {
                var s_PosCount = p_Kind == DecalGeometryKind.Decal2d ? 2 : 3;
                s_Geometry.Vertices = new List<DecalVertex>((int) s_VertexCount);
                for (var v = 0u; v < s_VertexCount; ++v)
                    s_Geometry.Vertices.Add(ReadVertex(p_Reader, s_PosCount));
            }

            var s_IndexCount = s_IndicesByteCount / 4;
            for (var k = 0u; k < s_IndexCount; ++k)
                s_Geometry.Indices.Add(p_Reader.ReadUInt32());

            return s_Geometry;
        }

        private static void WriteGeometry(RimeWriter p_Writer, DecalGeometry p_Geometry, DecalGeometryKind p_Kind)
        {
            p_Writer.Write(p_Geometry.BlockCount);
            if (p_Geometry.BlockCount == 0)
                return;

            foreach (var s_Block in p_Geometry.Blocks)
                WriteBlock(p_Writer, s_Block);

            var s_VertexCount = p_Kind == DecalGeometryKind.Water
                ? p_Geometry.WaterVertices?.Count ?? 0
                : p_Geometry.Vertices?.Count ?? 0;

            p_Writer.Write((uint) (s_VertexCount * VertexSize(p_Kind)));
            p_Writer.Write((uint) (p_Geometry.Indices.Count * 4));

            if (p_Kind == DecalGeometryKind.Water)
            {
                foreach (var s_Vertex in p_Geometry.WaterVertices!)
                    WriteWaterVertex(p_Writer, s_Vertex);
            }
            else
            {
                foreach (var s_Vertex in p_Geometry.Vertices!)
                    WriteVertex(p_Writer, s_Vertex);
            }

            foreach (var s_Index in p_Geometry.Indices)
                p_Writer.Write(s_Index);
        }

        private static DecalBlock ReadBlock(RimeReader p_Reader)
        {
            var s_Block = new DecalBlock
            {
                SurfaceShaderName = p_Reader.ReadNullTerminatedString(),
                ZOnlySurfaceShaderName = p_Reader.ReadNullTerminatedString(),
                StartIndex = p_Reader.ReadUInt32(),
                PrimitiveCount = p_Reader.ReadUInt32(),
            };

            for (var i = 0; i < 6; ++i) s_Block.BoundingBox[i] = p_Reader.ReadSingle();
            for (var i = 0; i < 6; ++i) s_Block.BoundingBox2[i] = p_Reader.ReadSingle();

            s_Block.DrawDistance = p_Reader.ReadSingle();
            s_Block.VertexBegin = p_Reader.ReadUInt32();
            s_Block.VertexEnd = p_Reader.ReadUInt32();
            return s_Block;
        }

        private static void WriteBlock(RimeWriter p_Writer, DecalBlock p_Block)
        {
            p_Writer.WriteNullTerminatedString(p_Block.SurfaceShaderName);
            p_Writer.WriteNullTerminatedString(p_Block.ZOnlySurfaceShaderName);
            p_Writer.Write(p_Block.StartIndex);
            p_Writer.Write(p_Block.PrimitiveCount);

            for (var i = 0; i < 6; ++i) p_Writer.Write(p_Block.BoundingBox[i]);
            for (var i = 0; i < 6; ++i) p_Writer.Write(p_Block.BoundingBox2[i]);

            p_Writer.Write(p_Block.DrawDistance);
            p_Writer.Write(p_Block.VertexBegin);
            p_Writer.Write(p_Block.VertexEnd);
        }

        private static DecalVertex ReadVertex(RimeReader p_Reader, int p_PosCount)
        {
            var s_Vertex = new DecalVertex { Position = new float[p_PosCount] };
            for (var i = 0; i < p_PosCount; ++i) s_Vertex.Position[i] = p_Reader.ReadSingle();
            s_Vertex.TexCoord[0] = p_Reader.ReadSingle();
            s_Vertex.TexCoord[1] = p_Reader.ReadSingle();
            for (var i = 0; i < 4; ++i) s_Vertex.UserMasks[i] = p_Reader.ReadUInt16();
            return s_Vertex;
        }

        private static void WriteVertex(RimeWriter p_Writer, DecalVertex p_Vertex)
        {
            foreach (var s_Component in p_Vertex.Position) p_Writer.Write(s_Component);
            p_Writer.Write(p_Vertex.TexCoord[0]);
            p_Writer.Write(p_Vertex.TexCoord[1]);
            foreach (var s_Mask in p_Vertex.UserMasks) p_Writer.Write(s_Mask);
        }

        private static DecalWaterVertex ReadWaterVertex(RimeReader p_Reader)
        {
            var s_Vertex = new DecalWaterVertex();
            for (var i = 0; i < 4; ++i) s_Vertex.Position[i] = p_Reader.ReadUInt16();
            for (var i = 0; i < 4; ++i) s_Vertex.Normal[i] = p_Reader.ReadUInt16();
            for (var i = 0; i < 4; ++i) s_Vertex.Tangent[i] = p_Reader.ReadUInt16();
            for (var i = 0; i < 2; ++i) s_Vertex.TexCoord[i] = p_Reader.ReadUInt16();
            for (var i = 0; i < 4; ++i) s_Vertex.UserMasks[i] = p_Reader.ReadUInt16();
            return s_Vertex;
        }

        private static void WriteWaterVertex(RimeWriter p_Writer, DecalWaterVertex p_Vertex)
        {
            foreach (var s_Value in p_Vertex.Position) p_Writer.Write(s_Value);
            foreach (var s_Value in p_Vertex.Normal) p_Writer.Write(s_Value);
            foreach (var s_Value in p_Vertex.Tangent) p_Writer.Write(s_Value);
            foreach (var s_Value in p_Vertex.TexCoord) p_Writer.Write(s_Value);
            foreach (var s_Value in p_Vertex.UserMasks) p_Writer.Write(s_Value);
        }
    }
}
