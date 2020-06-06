///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class SoldierAimingSimulationData : 
		GameDataContainer
	{
		[ContainerField(8)]
		public RefArray<ZoomLevelData> ZoomLevels { get; set; } = new RefArray<ZoomLevelData>(); // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ZoomTransitionTime { get; set; } // 0xC (12)
		
		[ContainerField(16)]
		public CtrRef<SoldierAimAssistData> AimAssist { get; set; } = new CtrRef<SoldierAimAssistData>(); // 0x10 (16)
		
		[ContainerField(20)]
		public AimingPoseData StandPose { get; set; } = new AimingPoseData(); // 0x14 (20)
		
		[ContainerField(44)]
		public AimingPoseData CrouchPose { get; set; } = new AimingPoseData(); // 0x2C (44)
		
		[ContainerField(68)]
		public AimingPoseData PronePose { get; set; } = new AimingPoseData(); // 0x44 (68)
		
		[ContainerField(92)]
		public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get; set; } = new List<ZoomLevelSpecificTransitionTime>(); // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float FovTransitionTime { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float FovDelayTime { get; set; } // 0x64 (100)
		
		[ContainerField(104)]
		public RefArray<AimerModifierData> Modifiers { get; set; } = new RefArray<AimerModifierData>(); // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float AimingRange { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float LockAimToTargetSpeed { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public bool ReturnToZoomAfterReload { get; set; } // 0x74 (116)
		
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
