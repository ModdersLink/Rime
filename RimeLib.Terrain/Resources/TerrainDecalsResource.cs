using System;
using System.Collections.Generic;

namespace RimeLib.Terrain.Resources
{
    /// <summary>
    /// Which of the three TerrainDecals geometries a block/vertex belongs to.
    /// They differ only in the per-vertex layout.
    /// </summary>
    public enum DecalGeometryKind
    {
        Decal2d,
        Decal3d,
        Water,
    }

    /// <summary>
    /// One render block of a geometry: a single-shader run of triangles plus its
    /// culling info. Draw order is implicit = block order in the file.
    /// </summary>
    public class DecalBlock
    {
        public string SurfaceShaderName { get; set; } = "";
        public string ZOnlySurfaceShaderName { get; set; } = "";
        public uint StartIndex { get; set; }
        public uint PrimitiveCount { get; set; }
        public float[] BoundingBox { get; set; } = new float[6];  // minXYZ, maxXYZ (world space)
        public float[] BoundingBox2 { get; set; } = new float[6]; // bbox snapped to the 64m decal-cell grid
        public float DrawDistance { get; set; }
        public uint VertexBegin { get; set; }
        public uint VertexEnd { get; set; }
    }

    /// <summary>2d/3d render vertex. Positions are WORLD-space; userMasks are 4 raw 16-bit values (half-floats).</summary>
    public class DecalVertex
    {
        public float[] Position { get; set; } = Array.Empty<float>(); // 2d = (x,z), 3d = (x,y,z)
        public float[] TexCoord { get; set; } = new float[2];
        public ushort[] UserMasks { get; set; } = new ushort[4];
    }

    /// <summary>Water render vertex: all fields are packed 16-bit (left raw — the baker never edits water).</summary>
    public class DecalWaterVertex
    {
        public ushort[] Position { get; set; } = new ushort[4];
        public ushort[] Normal { get; set; } = new ushort[4];
        public ushort[] Tangent { get; set; } = new ushort[4];
        public ushort[] TexCoord { get; set; } = new ushort[2];
        public ushort[] UserMasks { get; set; } = new ushort[4];
    }

    /// <summary>
    /// One of the three geometries. When <see cref="BlockCount"/> is 0 the vertex/index
    /// section is absent in the file. For 2d/3d <see cref="Vertices"/> is populated; for
    /// water <see cref="WaterVertices"/> is populated (serialize with NullValueHandling.Ignore).
    /// </summary>
    public class DecalGeometry
    {
        public uint BlockCount { get; set; }
        public List<DecalBlock> Blocks { get; set; } = new();
        public List<DecalVertex>? Vertices { get; set; }
        public List<DecalWaterVertex>? WaterVertices { get; set; }
        public List<uint> Indices { get; set; } = new();
    }

    /// <summary>
    /// Engine-agnostic data model of a TerrainDecals (.decals, ResourceType 0x15E1F32E)
    /// resource: header plus the three geometries (2d/3d/water). The byte (de)serialization
    /// lives in the per-engine <see cref="ITerrainDecalsConverter"/> implementation.
    /// </summary>
    public class TerrainDecalsResource
    {
        public float Decal3dFarDrawDistance { get; set; }
        public float Decal2dNearDrawDistance { get; set; }
        public uint DecalCellsPerHeightfieldTileSide { get; set; }
        public byte DecalDestructionMaskEnable { get; set; }

        public DecalGeometry Geometry2d { get; set; } = new();
        public DecalGeometry Geometry3d { get; set; } = new();
        public DecalGeometry GeometryWater { get; set; } = new();
    }
}
