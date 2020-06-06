///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class InputConfigurationAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<EntryInputActionMapsData> DefaultInputConceptDefinition { get; set; } = new CtrRef<EntryInputActionMapsData>(); // 0xC (12)
		
		[ContainerField(16)]
		public List<InputConceptIdentifiers> DefaultExclusiveInputConcepts { get; set; } = new List<InputConceptIdentifiers>(); // 0x10 (16)
		
		[ContainerField(20)]
		public List<EditableActionMap> UserConfigurableActionMaps { get; set; } = new List<EditableActionMap>(); // 0x14 (20)
		
		[ContainerField(24)]
		public EntryInputActionEnum TogglePoseAction { get; set; } = new EntryInputActionEnum(); // 0x18 (24)
		
		[ContainerField(28)]
		public EntryInputActionEnum CrouchAction { get; set; } = new EntryInputActionEnum(); // 0x1C (28)
		
		[ContainerField(32)]
		public EntryInputActionEnum CrouchAndHoldAction { get; set; } = new EntryInputActionEnum(); // 0x20 (32)
		
		[ContainerField(36)]
		public EntryInputActionEnum PickupInteractionAction { get; set; } = new EntryInputActionEnum(); // 0x24 (36)
		
		[ContainerField(40)]
		public List<PoseTransition> FiringDisablingTransitions { get; set; } = new List<PoseTransition>(); // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float SprintReleaseTime { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float ThrottleInputRequiredForSprint { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool StandAutomaticallyIfSprinting { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool ProneToStandOnJump { get; set; } // 0x35 (53)
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool DisableCrawlingWhileReloading { get; set; } // 0x36 (54)
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool DisableFiringWhileDeployingBipod { get; set; } // 0x37 (55)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool DisableFiringWhileJumping { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool DisableSprintingWhileReloading { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool EnableSprintToCrouchTransition { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool StopSprintingWhenReleasingThrottle { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool StopSprintingWhenReleasingSprint { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool WaitForSprintReleaseBeforeSprintAgain { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool VehicleBoostIsToggle { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool InputCurvesEnabled { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool DisableCrawlingWhileFiring { get; set; } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4121024077:
					DefaultInputConceptDefinition = (CtrRef<EntryInputActionMapsData>) p_Value;
					break;

				case 3010993925:
					if (p_Value.GetType() == typeof (List<uint>))
						DefaultExclusiveInputConcepts = ((List<uint>) p_Value).Select(x => (InputConceptIdentifiers) Enum.ToObject(typeof(InputConceptIdentifiers), x)).ToList();
					else
						DefaultExclusiveInputConcepts = (List<InputConceptIdentifiers>) p_Value;
					break;

				case 3516645410:
					UserConfigurableActionMaps = (List<EditableActionMap>) p_Value;
					break;

				case 1502188000:
					TogglePoseAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 4276692283:
					CrouchAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 3467662783:
					CrouchAndHoldAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2068877077:
					PickupInteractionAction = (EntryInputActionEnum) Enum.ToObject(typeof(EntryInputActionEnum), p_Value);
					break;

				case 2330749333:
					if (p_Value.GetType() == typeof (List<uint>))
						FiringDisablingTransitions = ((List<uint>) p_Value).Select(x => (PoseTransition) Enum.ToObject(typeof(PoseTransition), x)).ToList();
					else
						FiringDisablingTransitions = (List<PoseTransition>) p_Value;
					break;

				case 2508865115:
					SprintReleaseTime = (float) p_Value;
					break;

				case 628008395:
					ThrottleInputRequiredForSprint = (float) p_Value;
					break;

				case 2006399905:
					StandAutomaticallyIfSprinting = (bool) p_Value;
					break;

				case 1479235671:
					ProneToStandOnJump = (bool) p_Value;
					break;

				case 1988899892:
					DisableCrawlingWhileReloading = (bool) p_Value;
					break;

				case 1128942440:
					DisableFiringWhileDeployingBipod = (bool) p_Value;
					break;

				case 4184774481:
					DisableFiringWhileJumping = (bool) p_Value;
					break;

				case 2874893853:
					DisableSprintingWhileReloading = (bool) p_Value;
					break;

				case 2358130898:
					EnableSprintToCrouchTransition = (bool) p_Value;
					break;

				case 1435580527:
					StopSprintingWhenReleasingThrottle = (bool) p_Value;
					break;

				case 485538437:
					StopSprintingWhenReleasingSprint = (bool) p_Value;
					break;

				case 381150149:
					WaitForSprintReleaseBeforeSprintAgain = (bool) p_Value;
					break;

				case 1735323024:
					VehicleBoostIsToggle = (bool) p_Value;
					break;

				case 2151840626:
					InputCurvesEnabled = (bool) p_Value;
					break;

				case 1554862200:
					DisableCrawlingWhileFiring = (bool) p_Value;
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
				case 4121024077:
					return DefaultInputConceptDefinition;

				case 3010993925:
					return DefaultExclusiveInputConcepts;

				case 3516645410:
					return UserConfigurableActionMaps;

				case 1502188000:
					return TogglePoseAction;

				case 4276692283:
					return CrouchAction;

				case 3467662783:
					return CrouchAndHoldAction;

				case 2068877077:
					return PickupInteractionAction;

				case 2330749333:
					return FiringDisablingTransitions;

				case 2508865115:
					return SprintReleaseTime;

				case 628008395:
					return ThrottleInputRequiredForSprint;

				case 2006399905:
					return StandAutomaticallyIfSprinting;

				case 1479235671:
					return ProneToStandOnJump;

				case 1988899892:
					return DisableCrawlingWhileReloading;

				case 1128942440:
					return DisableFiringWhileDeployingBipod;

				case 4184774481:
					return DisableFiringWhileJumping;

				case 2874893853:
					return DisableSprintingWhileReloading;

				case 2358130898:
					return EnableSprintToCrouchTransition;

				case 1435580527:
					return StopSprintingWhenReleasingThrottle;

				case 485538437:
					return StopSprintingWhenReleasingSprint;

				case 381150149:
					return WaitForSprintReleaseBeforeSprintAgain;

				case 1735323024:
					return VehicleBoostIsToggle;

				case 2151840626:
					return InputCurvesEnabled;

				case 1554862200:
					return DisableCrawlingWhileFiring;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4121024077:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DefaultInputConceptDefinition));

				case 3010993925:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DefaultExclusiveInputConcepts));

				case 3516645410:
					return typeof(InputConfigurationAsset).GetProperty(nameof(UserConfigurableActionMaps));

				case 1502188000:
					return typeof(InputConfigurationAsset).GetProperty(nameof(TogglePoseAction));

				case 4276692283:
					return typeof(InputConfigurationAsset).GetProperty(nameof(CrouchAction));

				case 3467662783:
					return typeof(InputConfigurationAsset).GetProperty(nameof(CrouchAndHoldAction));

				case 2068877077:
					return typeof(InputConfigurationAsset).GetProperty(nameof(PickupInteractionAction));

				case 2330749333:
					return typeof(InputConfigurationAsset).GetProperty(nameof(FiringDisablingTransitions));

				case 2508865115:
					return typeof(InputConfigurationAsset).GetProperty(nameof(SprintReleaseTime));

				case 628008395:
					return typeof(InputConfigurationAsset).GetProperty(nameof(ThrottleInputRequiredForSprint));

				case 2006399905:
					return typeof(InputConfigurationAsset).GetProperty(nameof(StandAutomaticallyIfSprinting));

				case 1479235671:
					return typeof(InputConfigurationAsset).GetProperty(nameof(ProneToStandOnJump));

				case 1988899892:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DisableCrawlingWhileReloading));

				case 1128942440:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DisableFiringWhileDeployingBipod));

				case 4184774481:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DisableFiringWhileJumping));

				case 2874893853:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DisableSprintingWhileReloading));

				case 2358130898:
					return typeof(InputConfigurationAsset).GetProperty(nameof(EnableSprintToCrouchTransition));

				case 1435580527:
					return typeof(InputConfigurationAsset).GetProperty(nameof(StopSprintingWhenReleasingThrottle));

				case 485538437:
					return typeof(InputConfigurationAsset).GetProperty(nameof(StopSprintingWhenReleasingSprint));

				case 381150149:
					return typeof(InputConfigurationAsset).GetProperty(nameof(WaitForSprintReleaseBeforeSprintAgain));

				case 1735323024:
					return typeof(InputConfigurationAsset).GetProperty(nameof(VehicleBoostIsToggle));

				case 2151840626:
					return typeof(InputConfigurationAsset).GetProperty(nameof(InputCurvesEnabled));

				case 1554862200:
					return typeof(InputConfigurationAsset).GetProperty(nameof(DisableCrawlingWhileFiring));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
