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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class SoldierTestEntityData : 
		GameEntityData
	{
		protected CtrRef<SoldierBlueprint> m_TestSoldier = new CtrRef<SoldierBlueprint>();
		[ContainerField(Name: "TestSoldier", Offset: 96, NameHash: 1852759097, Flags: 53)]
		public CtrRef<SoldierBlueprint> TestSoldier { get { return m_TestSoldier; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(TestSoldier), this, m_TestSoldier, value)) m_TestSoldier = value; } } // 0x60 (96)
		
		protected CtrRef<SoldierSpawnTemplateData> m_Template = new CtrRef<SoldierSpawnTemplateData>();
		[ContainerField(Name: "Template", Offset: 100, NameHash: 2427043285, Flags: 53)]
		public CtrRef<SoldierSpawnTemplateData> Template { get { return m_Template; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(Template), this, m_Template, value)) m_Template = value; } } // 0x64 (100)
		
		protected CtrRef<VehicleBlueprint> m_TestVehicle = new CtrRef<VehicleBlueprint>();
		[ContainerField(Name: "TestVehicle", Offset: 104, NameHash: 748699691, Flags: 53)]
		public CtrRef<VehicleBlueprint> TestVehicle { get { return m_TestVehicle; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(TestVehicle), this, m_TestVehicle, value)) m_TestVehicle = value; } } // 0x68 (104)
		
		protected float m_SpecialAnimationIndex = new float();
		[ContainerField(Name: "SpecialAnimationIndex", Offset: 108, NameHash: 502517260, Flags: 49469), LayoutImmutable, Blittable]
		public float SpecialAnimationIndex { get { return m_SpecialAnimationIndex; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(SpecialAnimationIndex), this, m_SpecialAnimationIndex, value)) m_SpecialAnimationIndex = value; } } // 0x6C (108)
		
		protected CtrRef<RawFileAsset> m_UnlocksProfile = new CtrRef<RawFileAsset>();
		[ContainerField(Name: "UnlocksProfile", Offset: 112, NameHash: 1408434541, Flags: 53)]
		public CtrRef<RawFileAsset> UnlocksProfile { get { return m_UnlocksProfile; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(UnlocksProfile), this, m_UnlocksProfile, value)) m_UnlocksProfile = value; } } // 0x70 (112)
		
		protected TeamId m_Team = new TeamId();
		[ContainerField(Name: "Team", Offset: 116, NameHash: 2089309528, Flags: 137)]
		public TeamId Team { get { return m_Team; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(Team), this, m_Team, value)) m_Team = value; } } // 0x74 (116)
		
		protected int m_RandomSeed = new int();
		[ContainerField(Name: "RandomSeed", Offset: 120, NameHash: 3548222249, Flags: 49405), LayoutImmutable, Blittable]
		public int RandomSeed { get { return m_RandomSeed; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(RandomSeed), this, m_RandomSeed, value)) m_RandomSeed = value; } } // 0x78 (120)
		
		protected CtrRef<MovementActionData> m_StartSequence = new CtrRef<MovementActionData>();
		[ContainerField(Name: "StartSequence", Offset: 124, NameHash: 3846144538, Flags: 53)]
		public CtrRef<MovementActionData> StartSequence { get { return m_StartSequence; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(StartSequence), this, m_StartSequence, value)) m_StartSequence = value; } } // 0x7C (124)
		
		protected CtrRef<MovementActionRoot> m_StartSequenceRoot = new CtrRef<MovementActionRoot>();
		[ContainerField(Name: "StartSequenceRoot", Offset: 128, NameHash: 2665191516, Flags: 53)]
		public CtrRef<MovementActionRoot> StartSequenceRoot { get { return m_StartSequenceRoot; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(StartSequenceRoot), this, m_StartSequenceRoot, value)) m_StartSequenceRoot = value; } } // 0x80 (128)
		
		protected float m_YawInputVal = new float();
		[ContainerField(Name: "YawInputVal", Offset: 132, NameHash: 707538759, Flags: 49469), LayoutImmutable, Blittable]
		public float YawInputVal { get { return m_YawInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(YawInputVal), this, m_YawInputVal, value)) m_YawInputVal = value; } } // 0x84 (132)
		
		protected string m_CameraMovementsFilename = string.Empty;
		[ContainerField(Name: "CameraMovementsFilename", Offset: 136, NameHash: 2458254669, Flags: 16509), LayoutImmutable]
		public string CameraMovementsFilename { get { return m_CameraMovementsFilename; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(CameraMovementsFilename), this, m_CameraMovementsFilename, value)) m_CameraMovementsFilename = value; } } // 0x88 (136)
		
		protected CtrRef<InputRecorderData> m_InputRecorder = new CtrRef<InputRecorderData>();
		[ContainerField(Name: "InputRecorder", Offset: 140, NameHash: 3674777705, Flags: 53)]
		public CtrRef<InputRecorderData> InputRecorder { get { return m_InputRecorder; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(InputRecorder), this, m_InputRecorder, value)) m_InputRecorder = value; } } // 0x8C (140)
		
		protected float m_ThrottleInputVal = new float();
		[ContainerField(Name: "ThrottleInputVal", Offset: 144, NameHash: 516869344, Flags: 49469), LayoutImmutable, Blittable]
		public float ThrottleInputVal { get { return m_ThrottleInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(ThrottleInputVal), this, m_ThrottleInputVal, value)) m_ThrottleInputVal = value; } } // 0x90 (144)
		
		protected float m_FireInputVal = new float();
		[ContainerField(Name: "FireInputVal", Offset: 148, NameHash: 3256250672, Flags: 49469), LayoutImmutable, Blittable]
		public float FireInputVal { get { return m_FireInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(FireInputVal), this, m_FireInputVal, value)) m_FireInputVal = value; } } // 0x94 (148)
		
		protected float m_StrafeInputVal = new float();
		[ContainerField(Name: "StrafeInputVal", Offset: 152, NameHash: 535453919, Flags: 49469), LayoutImmutable, Blittable]
		public float StrafeInputVal { get { return m_StrafeInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(StrafeInputVal), this, m_StrafeInputVal, value)) m_StrafeInputVal = value; } } // 0x98 (152)
		
		protected float m_ProneInputVal = new float();
		[ContainerField(Name: "ProneInputVal", Offset: 156, NameHash: 4049708718, Flags: 49469), LayoutImmutable, Blittable]
		public float ProneInputVal { get { return m_ProneInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(ProneInputVal), this, m_ProneInputVal, value)) m_ProneInputVal = value; } } // 0x9C (156)
		
		protected float m_PitchInputVal = new float();
		[ContainerField(Name: "PitchInputVal", Offset: 160, NameHash: 3163270254, Flags: 49469), LayoutImmutable, Blittable]
		public float PitchInputVal { get { return m_PitchInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(PitchInputVal), this, m_PitchInputVal, value)) m_PitchInputVal = value; } } // 0xA0 (160)
		
		protected float m_RollInputVal = new float();
		[ContainerField(Name: "RollInputVal", Offset: 164, NameHash: 3652947253, Flags: 49469), LayoutImmutable, Blittable]
		public float RollInputVal { get { return m_RollInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(RollInputVal), this, m_RollInputVal, value)) m_RollInputVal = value; } } // 0xA4 (164)
		
		protected float m_ZoomInputVal = new float();
		[ContainerField(Name: "ZoomInputVal", Offset: 168, NameHash: 2738536543, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomInputVal { get { return m_ZoomInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(ZoomInputVal), this, m_ZoomInputVal, value)) m_ZoomInputVal = value; } } // 0xA8 (168)
		
		protected float m_JumpInputVal = new float();
		[ContainerField(Name: "JumpInputVal", Offset: 172, NameHash: 1467174346, Flags: 49469), LayoutImmutable, Blittable]
		public float JumpInputVal { get { return m_JumpInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(JumpInputVal), this, m_JumpInputVal, value)) m_JumpInputVal = value; } } // 0xAC (172)
		
		protected float m_ActiveInputRecording = new float();
		[ContainerField(Name: "ActiveInputRecording", Offset: 176, NameHash: 795932082, Flags: 49469), LayoutImmutable, Blittable]
		public float ActiveInputRecording { get { return m_ActiveInputRecording; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(ActiveInputRecording), this, m_ActiveInputRecording, value)) m_ActiveInputRecording = value; } } // 0xB0 (176)
		
		protected float m_AuthoritativeAimingActive = new float();
		[ContainerField(Name: "AuthoritativeAimingActive", Offset: 180, NameHash: 397640427, Flags: 49469), LayoutImmutable, Blittable]
		public float AuthoritativeAimingActive { get { return m_AuthoritativeAimingActive; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(AuthoritativeAimingActive), this, m_AuthoritativeAimingActive, value)) m_AuthoritativeAimingActive = value; } } // 0xB4 (180)
		
		protected float m_FireCounterMeasure = new float();
		[ContainerField(Name: "FireCounterMeasure", Offset: 184, NameHash: 1565274161, Flags: 49469), LayoutImmutable, Blittable]
		public float FireCounterMeasure { get { return m_FireCounterMeasure; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(FireCounterMeasure), this, m_FireCounterMeasure, value)) m_FireCounterMeasure = value; } } // 0xB8 (184)
		
		protected float m_AuthoritativeYaw = new float();
		[ContainerField(Name: "AuthoritativeYaw", Offset: 188, NameHash: 955878509, Flags: 49469), LayoutImmutable, Blittable]
		public float AuthoritativeYaw { get { return m_AuthoritativeYaw; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(AuthoritativeYaw), this, m_AuthoritativeYaw, value)) m_AuthoritativeYaw = value; } } // 0xBC (188)
		
		protected float m_AuthoritativePitch = new float();
		[ContainerField(Name: "AuthoritativePitch", Offset: 192, NameHash: 1561461380, Flags: 49469), LayoutImmutable, Blittable]
		public float AuthoritativePitch { get { return m_AuthoritativePitch; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(AuthoritativePitch), this, m_AuthoritativePitch, value)) m_AuthoritativePitch = value; } } // 0xC0 (192)
		
		protected bool m_RunAutomatically = new bool();
		[ContainerField(Name: "RunAutomatically", Offset: 196, NameHash: 3149340329, Flags: 49325), LayoutImmutable, Blittable]
		public bool RunAutomatically { get { return m_RunAutomatically; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(RunAutomatically), this, m_RunAutomatically, value)) m_RunAutomatically = value; } } // 0xC4 (196)
		
		protected bool m_UseUnlocksProfile = new bool();
		[ContainerField(Name: "UseUnlocksProfile", Offset: 197, NameHash: 1438049134, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseUnlocksProfile { get { return m_UseUnlocksProfile; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(UseUnlocksProfile), this, m_UseUnlocksProfile, value)) m_UseUnlocksProfile = value; } } // 0xC5 (197)
		
		protected bool m_SprintInputVal = new bool();
		[ContainerField(Name: "SprintInputVal", Offset: 198, NameHash: 3056679690, Flags: 49325), LayoutImmutable, Blittable]
		public bool SprintInputVal { get { return m_SprintInputVal; } set { if (OnPropertyChanging("SoldierTestEntityData." + nameof(SprintInputVal), this, m_SprintInputVal, value)) m_SprintInputVal = value; } } // 0xC6 (198)
		
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
