///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(8)]
	public class SensingSettings : 
		Asset
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public double SensingTimeSpan { get; set; } // 0x10 (16)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public double AttackerTrackTime { get; set; } // 0x18 (24)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public double LineOfSightTestTime { get; set; } // 0x20 (32)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public int MaxRays { get; set; } // 0x28 (40)
		
		[ContainerField(44)]
		public VisionBoxSettings CharacterVisionBoxSettings { get; set; } = new VisionBoxSettings(); // 0x2C (44)
		
		[ContainerField(60)]
		public VisionBoxSettings VehicleVisionBoxSettings { get; set; } = new VisionBoxSettings(); // 0x3C (60)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float CloseFireImpactDistance { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CloseExplosiveImpactDistance { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float CloseTrajectoryDistance { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float ImpactSenseDistance { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float MaxVolume { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MaxSize { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float VolumeModifier { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float MovementModifier { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LuckModifier { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float BackgroundLoudnessFactor { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float MotionSizeFactor { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MotionSpeedFactor { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float MotionPeripheralityFactor { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float MotionDistanceFactor { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float SmokeSphereRadius { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float SmokeSphereDuration { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRaycastHeight { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSTraceDistance { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRaycastDistance { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float SpawnOutOfLOSRadius { get; set; } // 0x9C (156)
		
		[ContainerField(160)]
		public CtrRef<SensingTemplateData> DefaultTemplate { get; set; } = new CtrRef<SensingTemplateData>(); // 0xA0 (160)
		
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
