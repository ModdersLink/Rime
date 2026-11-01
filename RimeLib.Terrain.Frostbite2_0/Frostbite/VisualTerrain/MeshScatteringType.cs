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
        public float MinMask { get; set; }
        public float MaxMask { get; set; }


        public float MinScaleX { get; set; }          // MinScale is a vector2
        public float MinScaleY { get; set; }

        public float MaxScaleX { get; set; }          // MaxScale is a vector2
        public float MaxScaleY { get; set; }

        public float MinMaskScaleFactorX { get; set; } // MinMaskScaleFactor is a vector2
        public float MinMaskScaleFactorY { get; set; }

        public float ScaleRandomess { get; set; }
        public float WindScale { get; set; }

        public sbyte FirstSpawnLevel { get; set; }
        public sbyte SpawnLevelCount { get; set; }

        public sbyte RotationMode { get; set; }
        public sbyte OrientationMode { get; set; }

        public float RotateTowardSlopeWeight { get; set; }

        public bool CastShadowsEnable { get; set; }
        public float ShadowViewDistance { get; set; }

        public bool BillboardingEnable { get; set; }
        public bool BillboardingGpuAccelleration { get; set; }


        // Normals = 2
        // normal + color = 3
        public sbyte InstanceType { get; set; }       // 1 = normals, 2 = normal + colour


        public bool GroundClampBoundingBoxEnable { get; set; }


        float RotateTowardsSlopeRandomWeight => (1.0f - RotateTowardSlopeWeight);

        float InvMaskDelta => (MaxMask - MinMask) != 0.0f ? (1.0f/ (MaxMask - MinMask)) : 1.0f;


        bool InstanceNormalEnable => InstanceType == 1 || InstanceType == 2;
        bool InstanceColorEnable => InstanceType == 2;

        int InstanceSizeBytes => (BillboardingGpuAccelleration ? 0x8 : 0x18) + (InstanceNormalEnable ? 8 : 0) + (InstanceColorEnable ? 8 : 0);

        public MeshScatteringType(RimeReader p_Reader)
        {
            Deserialize(p_Reader);
        }

        /// <summary>
        /// The exact mirror of <see cref="Deserialize(RimeReader)"/>, field for field and in its
        /// order. Without it a scattering type could be read and never written, so an edited
        /// terrain layer had no way back into the game.
        ///
        /// BillboardingGpuAccelleration is written as it is HELD, not as it was read: Deserialize
        /// forces it false when billboarding is off, and re-applying that here would be a second
        /// correction of an already-corrected value.
        /// </summary>
        public bool Serialize(RimeWriter p_Writer)
        {
            p_Writer.WriteNullTerminatedString(MeshName);
            p_Writer.Write(VariationAssetNameHash);
            p_Writer.Write(Density);
            p_Writer.Write(LockDensity);

            p_Writer.Write(RandomPositionOffset);
            p_Writer.Write(MinMask);
            p_Writer.Write(MaxMask);
            p_Writer.Write(MinScaleX);
            p_Writer.Write(MinScaleY);

            p_Writer.Write(MaxScaleX);
            p_Writer.Write(MaxScaleY);

            p_Writer.Write(MinMaskScaleFactorX);
            p_Writer.Write(MinMaskScaleFactorY);

            p_Writer.Write(ScaleRandomess);
            p_Writer.Write(WindScale);

            p_Writer.Write(FirstSpawnLevel);
            p_Writer.Write(SpawnLevelCount);
            p_Writer.Write(RotationMode);
            p_Writer.Write(OrientationMode);

            p_Writer.Write(RotateTowardSlopeWeight);

            p_Writer.Write(CastShadowsEnable);
            p_Writer.Write(ShadowViewDistance);

            p_Writer.Write(BillboardingEnable);
            p_Writer.Write(BillboardingGpuAccelleration);

            p_Writer.Write(InstanceType);

            p_Writer.Write(GroundClampBoundingBoxEnable);

            return true;
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
