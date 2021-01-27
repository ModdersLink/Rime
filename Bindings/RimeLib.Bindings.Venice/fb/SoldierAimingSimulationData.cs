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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 120)]
	public class SoldierAimingSimulationData : 
		GameDataContainer
	{
		protected RefArray<ZoomLevelData> m_ZoomLevels = new RefArray<ZoomLevelData>();
		[ContainerField(Name: "ZoomLevels", Offset: 8, NameHash: 217440439, Flags: 65)]
		public RefArray<ZoomLevelData> ZoomLevels { get { return m_ZoomLevels; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(ZoomLevels), this, m_ZoomLevels, value)) m_ZoomLevels = value; } } // 0x8 (8)
		
		protected float m_ZoomTransitionTime = new float();
		[ContainerField(Name: "ZoomTransitionTime", Offset: 12, NameHash: 1414605576, Flags: 49469), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get { return m_ZoomTransitionTime; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(ZoomTransitionTime), this, m_ZoomTransitionTime, value)) m_ZoomTransitionTime = value; } } // 0xC (12)
		
		protected CtrRef<SoldierAimAssistData> m_AimAssist = new CtrRef<SoldierAimAssistData>();
		[ContainerField(Name: "AimAssist", Offset: 16, NameHash: 2040410767, Flags: 53)]
		public CtrRef<SoldierAimAssistData> AimAssist { get { return m_AimAssist; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(AimAssist), this, m_AimAssist, value)) m_AimAssist = value; } } // 0x10 (16)
		
		protected AimingPoseData m_StandPose = new AimingPoseData();
		[ContainerField(Name: "StandPose", Offset: 20, NameHash: 3580661600, Flags: 41)]
		public AimingPoseData StandPose { get { return m_StandPose; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(StandPose), this, m_StandPose, value)) m_StandPose = value; } } // 0x14 (20)
		
		protected AimingPoseData m_CrouchPose = new AimingPoseData();
		[ContainerField(Name: "CrouchPose", Offset: 44, NameHash: 1318089740, Flags: 41)]
		public AimingPoseData CrouchPose { get { return m_CrouchPose; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(CrouchPose), this, m_CrouchPose, value)) m_CrouchPose = value; } } // 0x2C (44)
		
		protected AimingPoseData m_PronePose = new AimingPoseData();
		[ContainerField(Name: "PronePose", Offset: 68, NameHash: 3841962, Flags: 41)]
		public AimingPoseData PronePose { get { return m_PronePose; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(PronePose), this, m_PronePose, value)) m_PronePose = value; } } // 0x44 (68)
		
		protected List<ZoomLevelSpecificTransitionTime> m_ZoomTransitionTimeArray = new List<ZoomLevelSpecificTransitionTime>();
		[ContainerField(Name: "ZoomTransitionTimeArray", Offset: 92, NameHash: 332980785, Flags: 65)]
		public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get { return m_ZoomTransitionTimeArray; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(ZoomTransitionTimeArray), this, m_ZoomTransitionTimeArray, value)) m_ZoomTransitionTimeArray = value; } } // 0x5C (92)
		
		protected float m_FovTransitionTime = new float();
		[ContainerField(Name: "FovTransitionTime", Offset: 96, NameHash: 1751899392, Flags: 49469), LayoutImmutable, Blittable]
		public float FovTransitionTime { get { return m_FovTransitionTime; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(FovTransitionTime), this, m_FovTransitionTime, value)) m_FovTransitionTime = value; } } // 0x60 (96)
		
		protected float m_FovDelayTime = new float();
		[ContainerField(Name: "FovDelayTime", Offset: 100, NameHash: 3279185818, Flags: 49469), LayoutImmutable, Blittable]
		public float FovDelayTime { get { return m_FovDelayTime; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(FovDelayTime), this, m_FovDelayTime, value)) m_FovDelayTime = value; } } // 0x64 (100)
		
		protected RefArray<AimerModifierData> m_Modifiers = new RefArray<AimerModifierData>();
		[ContainerField(Name: "Modifiers", Offset: 104, NameHash: 105828545, Flags: 65)]
		public RefArray<AimerModifierData> Modifiers { get { return m_Modifiers; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(Modifiers), this, m_Modifiers, value)) m_Modifiers = value; } } // 0x68 (104)
		
		protected float m_AimingRange = new float();
		[ContainerField(Name: "AimingRange", Offset: 108, NameHash: 1541306623, Flags: 49469), LayoutImmutable, Blittable]
		public float AimingRange { get { return m_AimingRange; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(AimingRange), this, m_AimingRange, value)) m_AimingRange = value; } } // 0x6C (108)
		
		protected float m_LockAimToTargetSpeed = new float();
		[ContainerField(Name: "LockAimToTargetSpeed", Offset: 112, NameHash: 127388806, Flags: 49469), LayoutImmutable, Blittable]
		public float LockAimToTargetSpeed { get { return m_LockAimToTargetSpeed; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(LockAimToTargetSpeed), this, m_LockAimToTargetSpeed, value)) m_LockAimToTargetSpeed = value; } } // 0x70 (112)
		
		protected bool m_ReturnToZoomAfterReload = new bool();
		[ContainerField(Name: "ReturnToZoomAfterReload", Offset: 116, NameHash: 3110166998, Flags: 49325), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterReload { get { return m_ReturnToZoomAfterReload; } set { if (OnPropertyChanging("SoldierAimingSimulationData." + nameof(ReturnToZoomAfterReload), this, m_ReturnToZoomAfterReload, value)) m_ReturnToZoomAfterReload = value; } } // 0x74 (116)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 217440439:
					ZoomLevels = (RefArray<ZoomLevelData>) p_Value;
					break;

				case 1414605576:
					ZoomTransitionTime = (float) p_Value;
					break;

				case 2040410767:
					AimAssist = (CtrRef<SoldierAimAssistData>) p_Value;
					break;

				case 3580661600:
					StandPose = (AimingPoseData) p_Value;
					break;

				case 1318089740:
					CrouchPose = (AimingPoseData) p_Value;
					break;

				case 3841962:
					PronePose = (AimingPoseData) p_Value;
					break;

				case 332980785:
					ZoomTransitionTimeArray = (List<ZoomLevelSpecificTransitionTime>) p_Value;
					break;

				case 1751899392:
					FovTransitionTime = (float) p_Value;
					break;

				case 3279185818:
					FovDelayTime = (float) p_Value;
					break;

				case 105828545:
					Modifiers = (RefArray<AimerModifierData>) p_Value;
					break;

				case 1541306623:
					AimingRange = (float) p_Value;
					break;

				case 127388806:
					LockAimToTargetSpeed = (float) p_Value;
					break;

				case 3110166998:
					ReturnToZoomAfterReload = (bool) p_Value;
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
				case 217440439:
					return ZoomLevels;

				case 1414605576:
					return ZoomTransitionTime;

				case 2040410767:
					return AimAssist;

				case 3580661600:
					return StandPose;

				case 1318089740:
					return CrouchPose;

				case 3841962:
					return PronePose;

				case 332980785:
					return ZoomTransitionTimeArray;

				case 1751899392:
					return FovTransitionTime;

				case 3279185818:
					return FovDelayTime;

				case 105828545:
					return Modifiers;

				case 1541306623:
					return AimingRange;

				case 127388806:
					return LockAimToTargetSpeed;

				case 3110166998:
					return ReturnToZoomAfterReload;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 217440439:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(ZoomLevels));

				case 1414605576:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(ZoomTransitionTime));

				case 2040410767:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(AimAssist));

				case 3580661600:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(StandPose));

				case 1318089740:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(CrouchPose));

				case 3841962:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(PronePose));

				case 332980785:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(ZoomTransitionTimeArray));

				case 1751899392:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(FovTransitionTime));

				case 3279185818:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(FovDelayTime));

				case 105828545:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(Modifiers));

				case 1541306623:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(AimingRange));

				case 127388806:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(LockAimToTargetSpeed));

				case 3110166998:
					return typeof(SoldierAimingSimulationData).GetProperty(nameof(ReturnToZoomAfterReload));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
