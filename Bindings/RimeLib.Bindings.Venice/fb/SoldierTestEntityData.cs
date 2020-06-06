///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SoldierTestEntityData : 
		GameEntityData
	{
		[ContainerField(96)]
		public CtrRef<SoldierBlueprint> TestSoldier { get; set; } = new CtrRef<SoldierBlueprint>(); // 0x60 (96)
		
		[ContainerField(100)]
		public CtrRef<SoldierSpawnTemplateData> Template { get; set; } = new CtrRef<SoldierSpawnTemplateData>(); // 0x64 (100)
		
		[ContainerField(104)]
		public CtrRef<VehicleBlueprint> TestVehicle { get; set; } = new CtrRef<VehicleBlueprint>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float SpecialAnimationIndex { get; set; } // 0x6C (108)
		
		[ContainerField(112)]
		public CtrRef<RawFileAsset> UnlocksProfile { get; set; } = new CtrRef<RawFileAsset>(); // 0x70 (112)
		
		[ContainerField(116)]
		public TeamId Team { get; set; } = new TeamId(); // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int RandomSeed { get; set; } // 0x78 (120)
		
		[ContainerField(124)]
		public CtrRef<MovementActionData> StartSequence { get; set; } = new CtrRef<MovementActionData>(); // 0x7C (124)
		
		[ContainerField(128)]
		public CtrRef<MovementActionRoot> StartSequenceRoot { get; set; } = new CtrRef<MovementActionRoot>(); // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float YawInputVal { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable]
		public string CameraMovementsFilename { get; set; } // 0x88 (136)
		
		[ContainerField(140)]
		public CtrRef<InputRecorderData> InputRecorder { get; set; } = new CtrRef<InputRecorderData>(); // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float ThrottleInputVal { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float FireInputVal { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float StrafeInputVal { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float ProneInputVal { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float PitchInputVal { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float RollInputVal { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float ZoomInputVal { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float JumpInputVal { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float ActiveInputRecording { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float AuthoritativeAimingActive { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float FireCounterMeasure { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float AuthoritativeYaw { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float AuthoritativePitch { get; set; } // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool RunAutomatically { get; set; } // 0xC4 (196)
		
		[ContainerField(197), LayoutImmutable, Blittable]
		public bool UseUnlocksProfile { get; set; } // 0xC5 (197)
		
		[ContainerField(198), LayoutImmutable, Blittable]
		public bool SprintInputVal { get; set; } // 0xC6 (198)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1852759097:
					TestSoldier = (CtrRef<SoldierBlueprint>) p_Value;
					break;

				case 2427043285:
					Template = (CtrRef<SoldierSpawnTemplateData>) p_Value;
					break;

				case 748699691:
					TestVehicle = (CtrRef<VehicleBlueprint>) p_Value;
					break;

				case 502517260:
					SpecialAnimationIndex = (float) p_Value;
					break;

				case 1408434541:
					UnlocksProfile = (CtrRef<RawFileAsset>) p_Value;
					break;

				case 2089309528:
					Team = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 3548222249:
					RandomSeed = (int) p_Value;
					break;

				case 3846144538:
					StartSequence = (CtrRef<MovementActionData>) p_Value;
					break;

				case 2665191516:
					StartSequenceRoot = (CtrRef<MovementActionRoot>) p_Value;
					break;

				case 707538759:
					YawInputVal = (float) p_Value;
					break;

				case 2458254669:
					CameraMovementsFilename = (string) p_Value;
					break;

				case 3674777705:
					InputRecorder = (CtrRef<InputRecorderData>) p_Value;
					break;

				case 516869344:
					ThrottleInputVal = (float) p_Value;
					break;

				case 3256250672:
					FireInputVal = (float) p_Value;
					break;

				case 535453919:
					StrafeInputVal = (float) p_Value;
					break;

				case 4049708718:
					ProneInputVal = (float) p_Value;
					break;

				case 3163270254:
					PitchInputVal = (float) p_Value;
					break;

				case 3652947253:
					RollInputVal = (float) p_Value;
					break;

				case 2738536543:
					ZoomInputVal = (float) p_Value;
					break;

				case 1467174346:
					JumpInputVal = (float) p_Value;
					break;

				case 795932082:
					ActiveInputRecording = (float) p_Value;
					break;

				case 397640427:
					AuthoritativeAimingActive = (float) p_Value;
					break;

				case 1565274161:
					FireCounterMeasure = (float) p_Value;
					break;

				case 955878509:
					AuthoritativeYaw = (float) p_Value;
					break;

				case 1561461380:
					AuthoritativePitch = (float) p_Value;
					break;

				case 3149340329:
					RunAutomatically = (bool) p_Value;
					break;

				case 1438049134:
					UseUnlocksProfile = (bool) p_Value;
					break;

				case 3056679690:
					SprintInputVal = (bool) p_Value;
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
				case 1852759097:
					return TestSoldier;

				case 2427043285:
					return Template;

				case 748699691:
					return TestVehicle;

				case 502517260:
					return SpecialAnimationIndex;

				case 1408434541:
					return UnlocksProfile;

				case 2089309528:
					return Team;

				case 3548222249:
					return RandomSeed;

				case 3846144538:
					return StartSequence;

				case 2665191516:
					return StartSequenceRoot;

				case 707538759:
					return YawInputVal;

				case 2458254669:
					return CameraMovementsFilename;

				case 3674777705:
					return InputRecorder;

				case 516869344:
					return ThrottleInputVal;

				case 3256250672:
					return FireInputVal;

				case 535453919:
					return StrafeInputVal;

				case 4049708718:
					return ProneInputVal;

				case 3163270254:
					return PitchInputVal;

				case 3652947253:
					return RollInputVal;

				case 2738536543:
					return ZoomInputVal;

				case 1467174346:
					return JumpInputVal;

				case 795932082:
					return ActiveInputRecording;

				case 397640427:
					return AuthoritativeAimingActive;

				case 1565274161:
					return FireCounterMeasure;

				case 955878509:
					return AuthoritativeYaw;

				case 1561461380:
					return AuthoritativePitch;

				case 3149340329:
					return RunAutomatically;

				case 1438049134:
					return UseUnlocksProfile;

				case 3056679690:
					return SprintInputVal;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1852759097:
					return typeof(SoldierTestEntityData).GetProperty(nameof(TestSoldier));

				case 2427043285:
					return typeof(SoldierTestEntityData).GetProperty(nameof(Template));

				case 748699691:
					return typeof(SoldierTestEntityData).GetProperty(nameof(TestVehicle));

				case 502517260:
					return typeof(SoldierTestEntityData).GetProperty(nameof(SpecialAnimationIndex));

				case 1408434541:
					return typeof(SoldierTestEntityData).GetProperty(nameof(UnlocksProfile));

				case 2089309528:
					return typeof(SoldierTestEntityData).GetProperty(nameof(Team));

				case 3548222249:
					return typeof(SoldierTestEntityData).GetProperty(nameof(RandomSeed));

				case 3846144538:
					return typeof(SoldierTestEntityData).GetProperty(nameof(StartSequence));

				case 2665191516:
					return typeof(SoldierTestEntityData).GetProperty(nameof(StartSequenceRoot));

				case 707538759:
					return typeof(SoldierTestEntityData).GetProperty(nameof(YawInputVal));

				case 2458254669:
					return typeof(SoldierTestEntityData).GetProperty(nameof(CameraMovementsFilename));

				case 3674777705:
					return typeof(SoldierTestEntityData).GetProperty(nameof(InputRecorder));

				case 516869344:
					return typeof(SoldierTestEntityData).GetProperty(nameof(ThrottleInputVal));

				case 3256250672:
					return typeof(SoldierTestEntityData).GetProperty(nameof(FireInputVal));

				case 535453919:
					return typeof(SoldierTestEntityData).GetProperty(nameof(StrafeInputVal));

				case 4049708718:
					return typeof(SoldierTestEntityData).GetProperty(nameof(ProneInputVal));

				case 3163270254:
					return typeof(SoldierTestEntityData).GetProperty(nameof(PitchInputVal));

				case 3652947253:
					return typeof(SoldierTestEntityData).GetProperty(nameof(RollInputVal));

				case 2738536543:
					return typeof(SoldierTestEntityData).GetProperty(nameof(ZoomInputVal));

				case 1467174346:
					return typeof(SoldierTestEntityData).GetProperty(nameof(JumpInputVal));

				case 795932082:
					return typeof(SoldierTestEntityData).GetProperty(nameof(ActiveInputRecording));

				case 397640427:
					return typeof(SoldierTestEntityData).GetProperty(nameof(AuthoritativeAimingActive));

				case 1565274161:
					return typeof(SoldierTestEntityData).GetProperty(nameof(FireCounterMeasure));

				case 955878509:
					return typeof(SoldierTestEntityData).GetProperty(nameof(AuthoritativeYaw));

				case 1561461380:
					return typeof(SoldierTestEntityData).GetProperty(nameof(AuthoritativePitch));

				case 3149340329:
					return typeof(SoldierTestEntityData).GetProperty(nameof(RunAutomatically));

				case 1438049134:
					return typeof(SoldierTestEntityData).GetProperty(nameof(UseUnlocksProfile));

				case 3056679690:
					return typeof(SoldierTestEntityData).GetProperty(nameof(SprintInputVal));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
