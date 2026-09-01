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

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
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
