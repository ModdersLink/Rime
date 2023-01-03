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
    public class MeshScatteringType : IFbSerializable
    {

        // fb::VisualTerrain::MeshScatteringFixup
        public string MeshName { get; set; } = string.Empty;
        public uint VariationAssetNameHash { get; set; } = 0;
        public float Density { get; set; } = 0.0f;
        public bool LockDensity { get; set; } = false;

        // fb::MeshScatteringType
        public float RandomPositionOffset { get; set; } = 0.0f;
        float MinMask;
        float MaxMask;

        
        float MinScaleX; //vector2
        float MinScaleY; 

        float MaxScaleX; //vector2
        float MaxScaleY;

        float MinMaskScaleFactorX; //vector2
        float MinMaskScaleFactorY;

        float ScaleRandomess;
        float WindScale;

        sbyte FirstSpawnLevel;
        sbyte SpawnLevelCount;

        sbyte RotationMode;
        sbyte OrientationMode;

        float RotateTowardSlopeWeight;

        bool CastShadowsEnable;
        float ShadowViewDistance;

        bool BillboardingEnable;
        bool BillboardingGpuAccelleration;


        // Normals = 2
        // normal + color = 3
        sbyte InstanceType; //unknown


        bool GroundClampBoundingBoxEnable;


        float RotateTowardsSlopeRandomWeight => (1.0f - RotateTowardSlopeWeight);

        float InvMaskDelta => (MaxMask - MinMask) != 0.0f ? (1.0f/ (MaxMask - MinMask)) : 1.0f;


        bool InstanceNormalEnable => InstanceType == 1 || InstanceType == 2;
        bool InstanceColorEnable => InstanceType == 2;

        int InstanceSizeBytes => (BillboardingGpuAccelleration ? 0x8 : 0x18) + (InstanceNormalEnable ? 8 : 0) + (InstanceColorEnable ? 8 : 0);

        public MeshScatteringType(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        public bool Serialize(RimeWriter p_Writer)
        {
            throw new NotImplementedException();
        }



        public void Deserialize(RimeReader p_Reader)
        {
            MeshName = p_Reader.ReadNullTerminatedString();
            VariationAssetNameHash = p_Reader.ReadUInt32();
            Density = p_Reader.ReadSingle();
            LockDensity = p_Reader.ReadBool();


            RandomPositionOffset = p_Reader.ReadSingle();
            MinMask = p_Reader.ReadSingle();
            MaxMask = p_Reader.ReadSingle();
            MinScaleX = p_Reader.ReadSingle();
            MinScaleY = p_Reader.ReadSingle();

            MaxScaleX = p_Reader.ReadSingle();
            MaxScaleY = p_Reader.ReadSingle();

            MinMaskScaleFactorX = p_Reader.ReadSingle();
            MinMaskScaleFactorY = p_Reader.ReadSingle();

            ScaleRandomess = p_Reader.ReadSingle();
            WindScale = p_Reader.ReadSingle();
            
            FirstSpawnLevel = p_Reader.ReadSByte();
            SpawnLevelCount = p_Reader.ReadSByte();
            RotationMode = p_Reader.ReadSByte();
            OrientationMode = p_Reader.ReadSByte();

            RotateTowardSlopeWeight = p_Reader.ReadSingle();

            CastShadowsEnable = p_Reader.ReadBool();
            ShadowViewDistance = p_Reader.ReadSingle();

            BillboardingEnable = p_Reader.ReadBool();
            BillboardingGpuAccelleration = p_Reader.ReadBool();

            InstanceType = p_Reader.ReadSByte();

            GroundClampBoundingBoxEnable = p_Reader.ReadBool();

            if (!BillboardingEnable)
                BillboardingGpuAccelleration = false;


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
