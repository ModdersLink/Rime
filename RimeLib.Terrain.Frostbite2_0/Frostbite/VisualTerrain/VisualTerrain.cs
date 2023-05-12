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
        public string StreamingTreeResoruceName = string.Empty;
        public string DecalsResoruceName = string.Empty;

        VisualTerrainLayer[] Layers = new VisualTerrainLayer[0];

        //TerrainLayerCombinationDrawDatabase

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
            var s_A1 = p_Reader.ReadSingle();
            ResourceTriangleSizeMin = p_Reader.ReadSingle();

            TextureAtlasSampleCountX = p_Reader.ReadUInt32();
            TextureAtlasSampleCountY = p_Reader.ReadUInt32();


            var s_A2 = p_Reader.ReadSingle(); //TextureSamplesPerMeterMax

            var s_A3 = p_Reader.ReadSingle(); //TextureDetailFalloffCurve |  curve type?
            var s_A4 = p_Reader.ReadSingle(); // TextureDetailFalloffDistance
            var s_A5 = p_Reader.ReadSingle(); // TextureDetailFalloffFactor
            var s_A6 = p_Reader.ReadSingle(); // TextureInvisibleDetailReductionFactor
            var s_A7 = p_Reader.ReadSingle(); // TextureOccludedDetailReductionFactor


            /*
            // changes here
            ResourcePatchFov = p_Reader.ReadSingle();
            ResourceTriangleSizeMin = p_Reader.ReadSingle();


            TextureAtlasSampleCountX = p_Reader.ReadUInt32();
            TextureAtlasSampleCountY = p_Reader.ReadUInt32();
            TextureSamplesPerMeterMax = p_Reader.ReadUInt32();

            TextureDetailFalloffCurve = p_Reader.ReadSingle();
            TextureDetailFalloffDistance = p_Reader.ReadSingle();
            TextureDetailFalloffFactor = p_Reader.ReadSingle();

            TextureInvisibleDetailReductionFactor = p_Reader.ReadSingle();
            TextureOccludedDetailReductionFactor = p_Reader.ReadSingle();
            */


            SurfaceShaderName = p_Reader.ReadNullTerminatedString();


            var s_LayerCount = p_Reader.ReadUInt32();
            Layers = new VisualTerrainLayer[s_LayerCount];
            for (var i = 0; i < s_LayerCount; i++)
                Layers[i] = new VisualTerrainLayer(p_Reader);

            StreamingTreeResoruceName = p_Reader.ReadNullTerminatedString();
            DecalsResoruceName = p_Reader.ReadNullTerminatedString();


            // TerrainLayerCombinationDrawDatabase
            var s_CombinationDrawCount = p_Reader.ReadUInt32();
            for (var i=0; i < s_CombinationDrawCount; i++)
            {

                // TerrainLayerCombinationDraw

                var s_LayerIndexCount = p_Reader.ReadUInt32();

                var s_LayerIndicies = p_Reader.ReadBytes((int) s_LayerIndexCount);

                var s_MeshScatteringMethodCount = p_Reader.ReadUInt32();

                var s_MeshScatteringMaskScaleLevelEnd = p_Reader.ReadUByte();

                for (var j = 0; j < s_MeshScatteringMethodCount; j++)
                {
                    // MeshScatteringMaskScaleDrawMethod 

                    var s_MaskedLayerIndexCount = p_Reader.ReadUInt32();
                    var s_MaskedLayerIndicies = p_Reader.ReadBytes((int) s_MaskedLayerIndexCount);

                    var s_OutputOrderingIndexCount = p_Reader.ReadUInt32();
                    var s_OutputLayerOrder = p_Reader.ReadBytes((int)s_OutputOrderingIndexCount);


                    var s_ShaderName = p_Reader.ReadNullTerminatedString();
                    var s_DestructionMaskEnable = p_Reader.ReadBool();
                    var s_Level = p_Reader.ReadSByte();


                }


                var s_DrawPassCount = p_Reader.ReadUInt32();
                for (var j = 0; j < s_DrawPassCount; j++)
                {
                    // TerrainLayerCombinationDraw2dPass

                    var s_DrawPassType = p_Reader.ReadUInt32();

                    var s_MaskedLayerIndexCount = p_Reader.ReadUInt32();
                    var s_MaskedLayerIndicies = p_Reader.ReadBytes((int)s_MaskedLayerIndexCount);

                    var s_ShaderName = p_Reader.ReadNullTerminatedString();
                    var s_DestructionMaskEnable = p_Reader.ReadBool();
                }

                var s_Surface3DMethodCount = p_Reader.ReadUInt32();
                for (var j = 0; j < s_Surface3DMethodCount; j++)
                {
                    // Surface3dDrawMethod

                    var s_MaskedLayerIndexCount = p_Reader.ReadUInt32();
                    var s_MaskedLayerIndicies = p_Reader.ReadBytes((int)s_MaskedLayerIndexCount);


                    var s_ShaderName = p_Reader.ReadNullTerminatedString();
                    var s_DestructionMaskEnable = p_Reader.ReadBool();
                    var s_Level = p_Reader.ReadSByte();
                    var s_DrawDirectLayerCount = p_Reader.ReadSByte();
                }
            }
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
