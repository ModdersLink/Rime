using RimeLib.Frostbite;
using RimeLib.IO;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RimeLib.Terrain.Frostbite2_0.Frostbite.VisualTerrain
{
    public class VisualTerrain : IFbSerializable
    {
        public float MeshScatteringCellFov = 0.0f;
        public uint MeshScatteringCellMaskSamplesPerSide;
        public uint MeshScatteringInstancePoolSize;
        public uint MeshScatteringInstanceDrawBufferSize;
        
        public float ResourcePatchFov;
        public float ResourceLodScale;
        public float ResourceTriangleSizeMin;

        public uint TextureAtlasSampleCountX;
        public uint TextureAtlasSampleCountY;
        public float TextureSamplesPerMeterMax;
        
        public float TextureDetailFalloffCurve;
        public float TextureDetailFalloffDistance;
        public float TextureDetailFalloffFactor;

        public float TextureInvisibleDetailReductionFactor;
        public float TextureOccludedDetailReductionFactor;

        public string SurfaceShaderName = string.Empty;
        public string StreamingTreeResourceName = string.Empty;
        public string DecalsResourceName = string.Empty;

        public VisualTerrainLayer[] Layers { get; set; } = new VisualTerrainLayer[0];

        public TerrainLayerCombinationDraw[] TerrainLayerCombinationDraws { get; set; } = new TerrainLayerCombinationDraw[0];

        public VisualTerrain(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// The exact mirror of <see cref="Deserialize(RimeReader)"/>, field for field and in its
        /// order, so a resource that was read can be written back.
        ///
        /// Both counts are taken from the ARRAYS, not from a stored count field: the arrays are the
        /// truth after an edit, and a caller that appends a layer should not also have to remember
        /// to bump a separate counter. For an unedited resource the two agree, which is why this
        /// round-trips the shipped bytes exactly.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.Write(MeshScatteringCellFov);
            p_Writer.Write(MeshScatteringCellMaskSamplesPerSide);
            p_Writer.Write(MeshScatteringInstancePoolSize);
            p_Writer.Write(MeshScatteringInstanceDrawBufferSize);

            p_Writer.Write(ResourcePatchFov);
            p_Writer.Write(ResourceLodScale);
            p_Writer.Write(ResourceTriangleSizeMin);

            p_Writer.Write(TextureAtlasSampleCountX);
            p_Writer.Write(TextureAtlasSampleCountY);

            p_Writer.Write(TextureSamplesPerMeterMax);

            p_Writer.Write(TextureDetailFalloffCurve);
            p_Writer.Write(TextureDetailFalloffDistance);
            p_Writer.Write(TextureDetailFalloffFactor);
            p_Writer.Write(TextureInvisibleDetailReductionFactor);
            p_Writer.Write(TextureOccludedDetailReductionFactor);

            p_Writer.WriteNullTerminatedString(SurfaceShaderName);

            p_Writer.Write((uint) Layers.Length);
            foreach (var s_Layer in Layers)
                if (!s_Layer.Serialize(p_Writer))
                    return false;

            p_Writer.WriteNullTerminatedString(StreamingTreeResourceName);
            p_Writer.WriteNullTerminatedString(DecalsResourceName);

            p_Writer.Write((uint) TerrainLayerCombinationDraws.Length);
            foreach (var s_Draw in TerrainLayerCombinationDraws)
                if (!s_Draw.Serialize(p_Writer))
                    return false;

            return true;
        }

        public void Deserialize(RimeReader p_Reader)
        {
            MeshScatteringCellFov = p_Reader.ReadSingle();
            MeshScatteringCellMaskSamplesPerSide = p_Reader.ReadUInt32();
            MeshScatteringInstancePoolSize = p_Reader.ReadUInt32();
            MeshScatteringInstanceDrawBufferSize = p_Reader.ReadUInt32();

            ResourcePatchFov = p_Reader.ReadSingle();
            ResourceLodScale = p_Reader.ReadSingle();
            ResourceTriangleSizeMin = p_Reader.ReadSingle();

            TextureAtlasSampleCountX = p_Reader.ReadUInt32();
            TextureAtlasSampleCountY = p_Reader.ReadUInt32();

            TextureSamplesPerMeterMax = p_Reader.ReadSingle();

            TextureDetailFalloffCurve = p_Reader.ReadSingle();
            TextureDetailFalloffDistance = p_Reader.ReadSingle();
            TextureDetailFalloffFactor = p_Reader.ReadSingle();
            TextureInvisibleDetailReductionFactor = p_Reader.ReadSingle();
            TextureOccludedDetailReductionFactor = p_Reader.ReadSingle();

            SurfaceShaderName = p_Reader.ReadNullTerminatedString();

            var s_LayerCount = p_Reader.ReadUInt32();
            Layers = new VisualTerrainLayer[s_LayerCount];
            for (var i = 0; i < s_LayerCount; i++)
                Layers[i] = new VisualTerrainLayer(p_Reader);

            StreamingTreeResourceName = p_Reader.ReadNullTerminatedString();
            DecalsResourceName = p_Reader.ReadNullTerminatedString();

            var s_LayerCombinationDrawCount = p_Reader.ReadUInt32();
            TerrainLayerCombinationDraws = new TerrainLayerCombinationDraw[s_LayerCombinationDrawCount];
            for (var i = 0; i < s_LayerCombinationDrawCount; i++)
                TerrainLayerCombinationDraws[i] = new TerrainLayerCombinationDraw(p_Reader);
        }

        public bool Serialize([NotNullWhen(true)] out byte[]? p_Data)
        {
            var s_Stream = new MemoryStream();
            using var s_Writer = new RimeWriter(s_Stream);

            if (Serialize(s_Writer))
            {
                p_Data = s_Stream.ToArray();
                return true;
            }

            p_Data = null;
            return false;
        }

        public void Deserialize(byte[] p_Data)
        {
            using var s_Reader = new RimeReader(new MemoryStream(p_Data));
            Deserialize(s_Reader);
        }
    }
}
