using System;
using System.Collections.Generic;
using System.Linq;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0
{
    /// <summary>
    /// Builds a Frostbite 2 TerrainDecals resource block by block. A block's vertex range is a range of
    /// vertex indices into its geometry's vertices and its indices index the whole geometry.
    /// </summary>
    public sealed class TerrainDecalsBuilder
    {
        /// <summary>The Y bounds Frostbite 2 gives a 2d block, which is drawn on the terrain at any height.</summary>
        public const float UnboundedY = 1e20f;

        private readonly TerrainDecalsResource m_Decals;

        /// <param name="p_Header">The resource whose draw distances and decal cells the built one takes.</param>
        public TerrainDecalsBuilder(TerrainDecalsResource p_Header)
        {
            m_Decals = new TerrainDecalsResource
            {
                Decal3dFarDrawDistance = p_Header.Decal3dFarDrawDistance,
                Decal2dNearDrawDistance = p_Header.Decal2dNearDrawDistance,
                DecalCellsPerHeightfieldTileSide = p_Header.DecalCellsPerHeightfieldTileSide,
                DecalDestructionMaskEnable = p_Header.DecalDestructionMaskEnable,
                Geometry2d = new DecalGeometry { Vertices = new List<DecalVertex>() },
                Geometry3d = new DecalGeometry { Vertices = new List<DecalVertex>() },
                GeometryWater = new DecalGeometry { WaterVertices = new List<DecalWaterVertex>() },
            };
        }

        /// <summary>
        /// Adds a 2d or 3d block drawn with <paramref name="p_Shader"/>, with <paramref name="p_Block"/>'s
        /// bounds and draw distance.
        /// </summary>
        /// <param name="p_Indices">Triangle list indices into <paramref name="p_Vertices"/>.</param>
        public void Add(DecalGeometryKind p_Kind, DecalBlock p_Block, string p_Shader, string p_ZOnlyShader,
            IReadOnlyList<DecalVertex> p_Vertices, IReadOnlyList<uint> p_Indices)
        {
            if (p_Kind == DecalGeometryKind.Water)
                throw new ArgumentException("water blocks have another vertex layout", nameof(p_Kind));

            var s_Geometry = Geometry(p_Kind);
            var s_Begin = (uint)s_Geometry.Vertices!.Count;

            s_Geometry.Blocks.Add(new DecalBlock
            {
                SurfaceShaderName = p_Shader,
                ZOnlySurfaceShaderName = p_ZOnlyShader,
                StartIndex = (uint)s_Geometry.Indices.Count,
                PrimitiveCount = (uint)(p_Indices.Count / 3),
                BoundingBox = (float[])p_Block.BoundingBox.Clone(),
                BoundingBox2 = (float[])p_Block.BoundingBox2.Clone(),
                DrawDistance = p_Block.DrawDistance,
                VertexBegin = s_Begin,
                VertexEnd = s_Begin + (uint)p_Vertices.Count,
            });
            ++s_Geometry.BlockCount;

            s_Geometry.Vertices.AddRange(p_Vertices);
            s_Geometry.Indices.AddRange(p_Indices.Select(p_Index => s_Begin + p_Index));
        }

        /// <summary>
        /// Adds a 3d block's geometry as a 2d block drawn with <paramref name="p_Shader"/>: its vertices
        /// without their height, its bounds unbounded in Y.
        /// </summary>
        public void AddAs2d(DecalBlock p_Block, string p_Shader, string p_ZOnlyShader, IReadOnlyList<DecalVertex> p_Vertices, IReadOnlyList<uint> p_Indices)
        {
            var s_Block = new DecalBlock
            {
                BoundingBox = (float[])p_Block.BoundingBox.Clone(),
                BoundingBox2 = (float[])p_Block.BoundingBox2.Clone(),
                DrawDistance = p_Block.DrawDistance,
            };
            foreach (var s_Box in new[] { s_Block.BoundingBox, s_Block.BoundingBox2 })
            {
                s_Box[1] = UnboundedY;
                s_Box[4] = -UnboundedY;
            }

            var s_Vertices = p_Vertices.Select(p_Vertex => new DecalVertex
            {
                Position = [p_Vertex.Position[0], p_Vertex.Position[2]],
                TexCoord = (float[])p_Vertex.TexCoord.Clone(),
                UserMasks = (ushort[])p_Vertex.UserMasks.Clone(),
            }).ToList();

            Add(DecalGeometryKind.Decal2d, s_Block, p_Shader, p_ZOnlyShader, s_Vertices, p_Indices);
        }

        public TerrainDecalsResource Build() => m_Decals;

        /// <summary>A block's vertices of a Frostbite 2 geometry and its indices into them.</summary>
        public static (List<DecalVertex> Vertices, List<uint> Indices) BlockGeometry(DecalGeometry p_Geometry, DecalBlock p_Block)
        {
            var s_Vertices = p_Geometry.Vertices!.GetRange((int)p_Block.VertexBegin, (int)(p_Block.VertexEnd - p_Block.VertexBegin));
            var s_Indices = p_Geometry.Indices.GetRange((int)p_Block.StartIndex, (int)p_Block.PrimitiveCount * 3)
                .Select(p_Index => p_Index - p_Block.VertexBegin).ToList();
            return (s_Vertices, s_Indices);
        }

        private DecalGeometry Geometry(DecalGeometryKind p_Kind) =>
            p_Kind == DecalGeometryKind.Decal2d ? m_Decals.Geometry2d : m_Decals.Geometry3d;
    }
}
