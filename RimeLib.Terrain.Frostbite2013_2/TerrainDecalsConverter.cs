using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2013_2
{
    /// <summary>
    /// Frostbite 2013.2 (BF4) TerrainDecals (.decals) blocks: Frostbite 2's block with a mesh
    /// scattering mask shader after the two shaders and a tangent space flag after the vertex range.
    /// A block's vertex range is a byte offset and size into the vertex buffer, and blocks with
    /// tangent space have another vertex layout, so the vertices are kept as bytes.
    /// </summary>
    public class TerrainDecalsConverter : TerrainDecalsConverterBase
    {
        public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2013_2 };

        // Three empty names, start index, primitive count, two bounding boxes, draw distance, vertex range, tangent space flag.
        protected override long MinBlockBytes => 72;

        protected override bool KeepsVertexBytes => true;

        protected override DecalBlock ReadBlock(RimeReader p_Reader)
        {
            var s_Block = new DecalBlock
            {
                SurfaceShaderName = p_Reader.ReadNullTerminatedString(),
                ZOnlySurfaceShaderName = p_Reader.ReadNullTerminatedString(),
                MeshScatteringMaskSurfaceShaderName = p_Reader.ReadNullTerminatedString(),
                StartIndex = p_Reader.ReadUInt32(),
                PrimitiveCount = p_Reader.ReadUInt32(),
            };

            for (var i = 0; i < 6; ++i) s_Block.BoundingBox[i] = p_Reader.ReadSingle();
            for (var i = 0; i < 6; ++i) s_Block.BoundingBox2[i] = p_Reader.ReadSingle();

            s_Block.DrawDistance = p_Reader.ReadSingle();
            s_Block.VertexBegin = p_Reader.ReadUInt32();
            s_Block.VertexEnd = p_Reader.ReadUInt32();
            s_Block.TangentSpaceEnable = p_Reader.ReadBool();
            return s_Block;
        }

        protected override void WriteBlock(RimeWriter p_Writer, DecalBlock p_Block)
        {
            p_Writer.WriteNullTerminatedString(p_Block.SurfaceShaderName);
            p_Writer.WriteNullTerminatedString(p_Block.ZOnlySurfaceShaderName);
            p_Writer.WriteNullTerminatedString(p_Block.MeshScatteringMaskSurfaceShaderName);
            p_Writer.Write(p_Block.StartIndex);
            p_Writer.Write(p_Block.PrimitiveCount);

            for (var i = 0; i < 6; ++i) p_Writer.Write(p_Block.BoundingBox[i]);
            for (var i = 0; i < 6; ++i) p_Writer.Write(p_Block.BoundingBox2[i]);

            p_Writer.Write(p_Block.DrawDistance);
            p_Writer.Write(p_Block.VertexBegin);
            p_Writer.Write(p_Block.VertexEnd);
            p_Writer.Write(p_Block.TangentSpaceEnable);
        }
    }
}
