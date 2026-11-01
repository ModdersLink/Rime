using RimeLib.Frostbite;
using RimeLib.IO;
using RimeLib.Terrain.Resources;

namespace RimeLib.Terrain.Frostbite2_0
{
    /// <summary>
    /// Frostbite 2 (BF3) TerrainDecals (.decals) blocks. Mirrors bree's 010 template
    /// (External/010templates/bree/fb2/TerrainDecals.bt).
    /// </summary>
    public class TerrainDecalsConverter : TerrainDecalsConverterBase
    {
        public override EngineType[] GetSupportedEngines() => new[] { EngineType.Frostbite2_0 };

        // Two empty names, start index, primitive count, two bounding boxes, draw distance, vertex range.
        protected override long MinBlockBytes => 70;

        protected override DecalBlock ReadBlock(RimeReader p_Reader)
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

        protected override void WriteBlock(RimeWriter p_Writer, DecalBlock p_Block)
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
    }
}
