///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(8)]
	public class SensingSettings : 
		Asset
	{
		protected double m_SensingTimeSpan = new double();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(130823511)]
		public double SensingTimeSpan { get { return m_SensingTimeSpan; } set { if (OnPropertyChanging("SensingSettings." + nameof(SensingTimeSpan), this, m_SensingTimeSpan, value)) m_SensingTimeSpan = value; } } // 0x10 (16)
		
		protected double m_AttackerTrackTime = new double();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(602739744)]
		public double AttackerTrackTime { get { return m_AttackerTrackTime; } set { if (OnPropertyChanging("SensingSettings." + nameof(AttackerTrackTime), this, m_AttackerTrackTime, value)) m_AttackerTrackTime = value; } } // 0x18 (24)
		
		protected double m_LineOfSightTestTime = new double();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(1858080768)]
		public double LineOfSightTestTime { get { return m_LineOfSightTestTime; } set { if (OnPropertyChanging("SensingSettings." + nameof(LineOfSightTestTime), this, m_LineOfSightTestTime, value)) m_LineOfSightTestTime = value; } } // 0x20 (32)
		
		protected int m_MaxRays = new int();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(1313741384)]
		public int MaxRays { get { return m_MaxRays; } set { if (OnPropertyChanging("SensingSettings." + nameof(MaxRays), this, m_MaxRays, value)) m_MaxRays = value; } } // 0x28 (40)
		
		protected VisionBoxSettings m_CharacterVisionBoxSettings = new VisionBoxSettings();
		[ContainerField(44), ContainerFieldNameHash(1597160040)]
		public VisionBoxSettings CharacterVisionBoxSettings { get { return m_CharacterVisionBoxSettings; } set { if (OnPropertyChanging("SensingSettings." + nameof(CharacterVisionBoxSettings), this, m_CharacterVisionBoxSettings, value)) m_CharacterVisionBoxSettings = value; } } // 0x2C (44)
		
		protected VisionBoxSettings m_VehicleVisionBoxSettings = new VisionBoxSettings();
		[ContainerField(60), ContainerFieldNameHash(3992899657)]
		public VisionBoxSettings VehicleVisionBoxSettings { get { return m_VehicleVisionBoxSettings; } set { if (OnPropertyChanging("SensingSettings." + nameof(VehicleVisionBoxSettings), this, m_VehicleVisionBoxSettings, value)) m_VehicleVisionBoxSettings = value; } } // 0x3C (60)
		
		protected float m_CloseFireImpactDistance = new float();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(3664555978)]
		public float CloseFireImpactDistance { get { return m_CloseFireImpactDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(CloseFireImpactDistance), this, m_CloseFireImpactDistance, value)) m_CloseFireImpactDistance = value; } } // 0x4C (76)
		
		protected float m_CloseExplosiveImpactDistance = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(1704121589)]
		public float CloseExplosiveImpactDistance { get { return m_CloseExplosiveImpactDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(CloseExplosiveImpactDistance), this, m_CloseExplosiveImpactDistance, value)) m_CloseExplosiveImpactDistance = value; } } // 0x50 (80)
		
		protected float m_CloseTrajectoryDistance = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(1007061227)]
		public float CloseTrajectoryDistance { get { return m_CloseTrajectoryDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(CloseTrajectoryDistance), this, m_CloseTrajectoryDistance, value)) m_CloseTrajectoryDistance = value; } } // 0x54 (84)
		
		protected float m_ImpactSenseDistance = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(3263899210)]
		public float ImpactSenseDistance { get { return m_ImpactSenseDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(ImpactSenseDistance), this, m_ImpactSenseDistance, value)) m_ImpactSenseDistance = value; } } // 0x58 (88)
		
		protected float m_MaxVolume = new float();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(593636889)]
		public float MaxVolume { get { return m_MaxVolume; } set { if (OnPropertyChanging("SensingSettings." + nameof(MaxVolume), this, m_MaxVolume, value)) m_MaxVolume = value; } } // 0x5C (92)
		
		protected float m_MaxSize = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(1313502420)]
		public float MaxSize { get { return m_MaxSize; } set { if (OnPropertyChanging("SensingSettings." + nameof(MaxSize), this, m_MaxSize, value)) m_MaxSize = value; } } // 0x60 (96)
		
		protected float m_MaxSpeed = new float();
		[ContainerField(100), LayoutImmutable, Blittable, ContainerFieldNameHash(396228950)]
		public float MaxSpeed { get { return m_MaxSpeed; } set { if (OnPropertyChanging("SensingSettings." + nameof(MaxSpeed), this, m_MaxSpeed, value)) m_MaxSpeed = value; } } // 0x64 (100)
		
		protected float m_VolumeModifier = new float();
		[ContainerField(104), LayoutImmutable, Blittable, ContainerFieldNameHash(452034490)]
		public float VolumeModifier { get { return m_VolumeModifier; } set { if (OnPropertyChanging("SensingSettings." + nameof(VolumeModifier), this, m_VolumeModifier, value)) m_VolumeModifier = value; } } // 0x68 (104)
		
		protected float m_MovementModifier = new float();
		[ContainerField(108), LayoutImmutable, Blittable, ContainerFieldNameHash(2212724817)]
		public float MovementModifier { get { return m_MovementModifier; } set { if (OnPropertyChanging("SensingSettings." + nameof(MovementModifier), this, m_MovementModifier, value)) m_MovementModifier = value; } } // 0x6C (108)
		
		protected float m_LuckModifier = new float();
		[ContainerField(112), LayoutImmutable, Blittable, ContainerFieldNameHash(2830676771)]
		public float LuckModifier { get { return m_LuckModifier; } set { if (OnPropertyChanging("SensingSettings." + nameof(LuckModifier), this, m_LuckModifier, value)) m_LuckModifier = value; } } // 0x70 (112)
		
		protected float m_BackgroundLoudnessFactor = new float();
		[ContainerField(116), LayoutImmutable, Blittable, ContainerFieldNameHash(137537503)]
		public float BackgroundLoudnessFactor { get { return m_BackgroundLoudnessFactor; } set { if (OnPropertyChanging("SensingSettings." + nameof(BackgroundLoudnessFactor), this, m_BackgroundLoudnessFactor, value)) m_BackgroundLoudnessFactor = value; } } // 0x74 (116)
		
		protected float m_MotionSizeFactor = new float();
		[ContainerField(120), LayoutImmutable, Blittable, ContainerFieldNameHash(481828371)]
		public float MotionSizeFactor { get { return m_MotionSizeFactor; } set { if (OnPropertyChanging("SensingSettings." + nameof(MotionSizeFactor), this, m_MotionSizeFactor, value)) m_MotionSizeFactor = value; } } // 0x78 (120)
		
		protected float m_MotionSpeedFactor = new float();
		[ContainerField(124), LayoutImmutable, Blittable, ContainerFieldNameHash(3916144273)]
		public float MotionSpeedFactor { get { return m_MotionSpeedFactor; } set { if (OnPropertyChanging("SensingSettings." + nameof(MotionSpeedFactor), this, m_MotionSpeedFactor, value)) m_MotionSpeedFactor = value; } } // 0x7C (124)
		
		protected float m_MotionPeripheralityFactor = new float();
		[ContainerField(128), LayoutImmutable, Blittable, ContainerFieldNameHash(2317868990)]
		public float MotionPeripheralityFactor { get { return m_MotionPeripheralityFactor; } set { if (OnPropertyChanging("SensingSettings." + nameof(MotionPeripheralityFactor), this, m_MotionPeripheralityFactor, value)) m_MotionPeripheralityFactor = value; } } // 0x80 (128)
		
		protected float m_MotionDistanceFactor = new float();
		[ContainerField(132), LayoutImmutable, Blittable, ContainerFieldNameHash(155233877)]
		public float MotionDistanceFactor { get { return m_MotionDistanceFactor; } set { if (OnPropertyChanging("SensingSettings." + nameof(MotionDistanceFactor), this, m_MotionDistanceFactor, value)) m_MotionDistanceFactor = value; } } // 0x84 (132)
		
		protected float m_SmokeSphereRadius = new float();
		[ContainerField(136), LayoutImmutable, Blittable, ContainerFieldNameHash(1747155003)]
		public float SmokeSphereRadius { get { return m_SmokeSphereRadius; } set { if (OnPropertyChanging("SensingSettings." + nameof(SmokeSphereRadius), this, m_SmokeSphereRadius, value)) m_SmokeSphereRadius = value; } } // 0x88 (136)
		
		protected float m_SmokeSphereDuration = new float();
		[ContainerField(140), LayoutImmutable, Blittable, ContainerFieldNameHash(2841402685)]
		public float SmokeSphereDuration { get { return m_SmokeSphereDuration; } set { if (OnPropertyChanging("SensingSettings." + nameof(SmokeSphereDuration), this, m_SmokeSphereDuration, value)) m_SmokeSphereDuration = value; } } // 0x8C (140)
		
		protected float m_SpawnOutOfLOSRaycastHeight = new float();
		[ContainerField(144), LayoutImmutable, Blittable, ContainerFieldNameHash(1269521529)]
		public float SpawnOutOfLOSRaycastHeight { get { return m_SpawnOutOfLOSRaycastHeight; } set { if (OnPropertyChanging("SensingSettings." + nameof(SpawnOutOfLOSRaycastHeight), this, m_SpawnOutOfLOSRaycastHeight, value)) m_SpawnOutOfLOSRaycastHeight = value; } } // 0x90 (144)
		
		protected float m_SpawnOutOfLOSTraceDistance = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(2742310379)]
		public float SpawnOutOfLOSTraceDistance { get { return m_SpawnOutOfLOSTraceDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(SpawnOutOfLOSTraceDistance), this, m_SpawnOutOfLOSTraceDistance, value)) m_SpawnOutOfLOSTraceDistance = value; } } // 0x94 (148)
		
		protected float m_SpawnOutOfLOSRaycastDistance = new float();
		[ContainerField(152), LayoutImmutable, Blittable, ContainerFieldNameHash(2510586213)]
		public float SpawnOutOfLOSRaycastDistance { get { return m_SpawnOutOfLOSRaycastDistance; } set { if (OnPropertyChanging("SensingSettings." + nameof(SpawnOutOfLOSRaycastDistance), this, m_SpawnOutOfLOSRaycastDistance, value)) m_SpawnOutOfLOSRaycastDistance = value; } } // 0x98 (152)
		
		protected float m_SpawnOutOfLOSRadius = new float();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(2268853041)]
		public float SpawnOutOfLOSRadius { get { return m_SpawnOutOfLOSRadius; } set { if (OnPropertyChanging("SensingSettings." + nameof(SpawnOutOfLOSRadius), this, m_SpawnOutOfLOSRadius, value)) m_SpawnOutOfLOSRadius = value; } } // 0x9C (156)
		
		protected CtrRef<SensingTemplateData> m_DefaultTemplate = new CtrRef<SensingTemplateData>();
		[ContainerField(160), ContainerFieldNameHash(2694811134)]
		public CtrRef<SensingTemplateData> DefaultTemplate { get { return m_DefaultTemplate; } set { if (OnPropertyChanging("SensingSettings." + nameof(DefaultTemplate), this, m_DefaultTemplate, value)) m_DefaultTemplate = value; } } // 0xA0 (160)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 130823511:
					SensingTimeSpan = (double) p_Value;
					break;

				case 602739744:
					AttackerTrackTime = (double) p_Value;
					break;

				case 1858080768:
					LineOfSightTestTime = (double) p_Value;
					break;

				case 1313741384:
					MaxRays = (int) p_Value;
					break;

				case 1597160040:
					CharacterVisionBoxSettings = (VisionBoxSettings) p_Value;
					break;

				case 3992899657:
					VehicleVisionBoxSettings = (VisionBoxSettings) p_Value;
					break;

				case 3664555978:
					CloseFireImpactDistance = (float) p_Value;
					break;

				case 1704121589:
					CloseExplosiveImpactDistance = (float) p_Value;
					break;

				case 1007061227:
					CloseTrajectoryDistance = (float) p_Value;
					break;

				case 3263899210:
					ImpactSenseDistance = (float) p_Value;
					break;

				case 593636889:
					MaxVolume = (float) p_Value;
					break;

				case 1313502420:
					MaxSize = (float) p_Value;
					break;

				case 396228950:
					MaxSpeed = (float) p_Value;
					break;

				case 452034490:
					VolumeModifier = (float) p_Value;
					break;

				case 2212724817:
					MovementModifier = (float) p_Value;
					break;

				case 2830676771:
					LuckModifier = (float) p_Value;
					break;

				case 137537503:
					BackgroundLoudnessFactor = (float) p_Value;
					break;

				case 481828371:
					MotionSizeFactor = (float) p_Value;
					break;

				case 3916144273:
					MotionSpeedFactor = (float) p_Value;
					break;

				case 2317868990:
					MotionPeripheralityFactor = (float) p_Value;
					break;

				case 155233877:
					MotionDistanceFactor = (float) p_Value;
					break;

				case 1747155003:
					SmokeSphereRadius = (float) p_Value;
					break;

				case 2841402685:
					SmokeSphereDuration = (float) p_Value;
					break;

				case 1269521529:
					SpawnOutOfLOSRaycastHeight = (float) p_Value;
					break;

				case 2742310379:
					SpawnOutOfLOSTraceDistance = (float) p_Value;
					break;

				case 2510586213:
					SpawnOutOfLOSRaycastDistance = (float) p_Value;
					break;

				case 2268853041:
					SpawnOutOfLOSRadius = (float) p_Value;
					break;

				case 2694811134:
					DefaultTemplate = (CtrRef<SensingTemplateData>) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 130823511:
					return SensingTimeSpan;

				case 602739744:
					return AttackerTrackTime;

				case 1858080768:
					return LineOfSightTestTime;

				case 1313741384:
					return MaxRays;

				case 1597160040:
					return CharacterVisionBoxSettings;

				case 3992899657:
					return VehicleVisionBoxSettings;

				case 3664555978:
					return CloseFireImpactDistance;

				case 1704121589:
					return CloseExplosiveImpactDistance;

				case 1007061227:
					return CloseTrajectoryDistance;

				case 3263899210:
					return ImpactSenseDistance;

				case 593636889:
					return MaxVolume;

				case 1313502420:
					return MaxSize;

				case 396228950:
					return MaxSpeed;

				case 452034490:
					return VolumeModifier;

				case 2212724817:
					return MovementModifier;

				case 2830676771:
					return LuckModifier;

				case 137537503:
					return BackgroundLoudnessFactor;

				case 481828371:
					return MotionSizeFactor;

				case 3916144273:
					return MotionSpeedFactor;

				case 2317868990:
					return MotionPeripheralityFactor;

				case 155233877:
					return MotionDistanceFactor;

				case 1747155003:
					return SmokeSphereRadius;

				case 2841402685:
					return SmokeSphereDuration;

				case 1269521529:
					return SpawnOutOfLOSRaycastHeight;

				case 2742310379:
					return SpawnOutOfLOSTraceDistance;

				case 2510586213:
					return SpawnOutOfLOSRaycastDistance;

				case 2268853041:
					return SpawnOutOfLOSRadius;

				case 2694811134:
					return DefaultTemplate;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 130823511:
					return typeof(SensingSettings).GetProperty(nameof(SensingTimeSpan));

				case 602739744:
					return typeof(SensingSettings).GetProperty(nameof(AttackerTrackTime));

				case 1858080768:
					return typeof(SensingSettings).GetProperty(nameof(LineOfSightTestTime));

				case 1313741384:
					return typeof(SensingSettings).GetProperty(nameof(MaxRays));

				case 1597160040:
					return typeof(SensingSettings).GetProperty(nameof(CharacterVisionBoxSettings));

				case 3992899657:
					return typeof(SensingSettings).GetProperty(nameof(VehicleVisionBoxSettings));

				case 3664555978:
					return typeof(SensingSettings).GetProperty(nameof(CloseFireImpactDistance));

				case 1704121589:
					return typeof(SensingSettings).GetProperty(nameof(CloseExplosiveImpactDistance));

				case 1007061227:
					return typeof(SensingSettings).GetProperty(nameof(CloseTrajectoryDistance));

				case 3263899210:
					return typeof(SensingSettings).GetProperty(nameof(ImpactSenseDistance));

				case 593636889:
					return typeof(SensingSettings).GetProperty(nameof(MaxVolume));

				case 1313502420:
					return typeof(SensingSettings).GetProperty(nameof(MaxSize));

				case 396228950:
					return typeof(SensingSettings).GetProperty(nameof(MaxSpeed));

				case 452034490:
					return typeof(SensingSettings).GetProperty(nameof(VolumeModifier));

				case 2212724817:
					return typeof(SensingSettings).GetProperty(nameof(MovementModifier));

				case 2830676771:
					return typeof(SensingSettings).GetProperty(nameof(LuckModifier));

				case 137537503:
					return typeof(SensingSettings).GetProperty(nameof(BackgroundLoudnessFactor));

				case 481828371:
					return typeof(SensingSettings).GetProperty(nameof(MotionSizeFactor));

				case 3916144273:
					return typeof(SensingSettings).GetProperty(nameof(MotionSpeedFactor));

				case 2317868990:
					return typeof(SensingSettings).GetProperty(nameof(MotionPeripheralityFactor));

				case 155233877:
					return typeof(SensingSettings).GetProperty(nameof(MotionDistanceFactor));

				case 1747155003:
					return typeof(SensingSettings).GetProperty(nameof(SmokeSphereRadius));

				case 2841402685:
					return typeof(SensingSettings).GetProperty(nameof(SmokeSphereDuration));

				case 1269521529:
					return typeof(SensingSettings).GetProperty(nameof(SpawnOutOfLOSRaycastHeight));

				case 2742310379:
					return typeof(SensingSettings).GetProperty(nameof(SpawnOutOfLOSTraceDistance));

				case 2510586213:
					return typeof(SensingSettings).GetProperty(nameof(SpawnOutOfLOSRaycastDistance));

				case 2268853041:
					return typeof(SensingSettings).GetProperty(nameof(SpawnOutOfLOSRadius));

				case 2694811134:
					return typeof(SensingSettings).GetProperty(nameof(DefaultTemplate));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
