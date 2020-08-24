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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class InputConfigurationAsset : 
		Asset
	{
		protected CtrRef<EntryInputActionMapsData> m_DefaultInputConceptDefinition = new CtrRef<EntryInputActionMapsData>();
		[ContainerField(12), MemberInfoFlag(53), ContainerFieldNameHash(4121024077), ContainerCtrRef]
		public CtrRef<EntryInputActionMapsData> DefaultInputConceptDefinition { get { return m_DefaultInputConceptDefinition; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DefaultInputConceptDefinition), this, m_DefaultInputConceptDefinition, value)) m_DefaultInputConceptDefinition = value; } } // 0xC (12)
		
		protected List<InputConceptIdentifiers> m_DefaultExclusiveInputConcepts = new List<InputConceptIdentifiers>();
		[ContainerField(16), MemberInfoFlag(65), ContainerFieldNameHash(3010993925), ContainerArray]
		public List<InputConceptIdentifiers> DefaultExclusiveInputConcepts { get { return m_DefaultExclusiveInputConcepts; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DefaultExclusiveInputConcepts), this, m_DefaultExclusiveInputConcepts, value)) m_DefaultExclusiveInputConcepts = value; } } // 0x10 (16)
		
		protected List<EditableActionMap> m_UserConfigurableActionMaps = new List<EditableActionMap>();
		[ContainerField(20), MemberInfoFlag(65), ContainerFieldNameHash(3516645410), ContainerArray]
		public List<EditableActionMap> UserConfigurableActionMaps { get { return m_UserConfigurableActionMaps; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(UserConfigurableActionMaps), this, m_UserConfigurableActionMaps, value)) m_UserConfigurableActionMaps = value; } } // 0x14 (20)
		
		protected EntryInputActionEnum m_TogglePoseAction = new EntryInputActionEnum();
		[ContainerField(24), MemberInfoFlag(137), ContainerFieldNameHash(1502188000)]
		public EntryInputActionEnum TogglePoseAction { get { return m_TogglePoseAction; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(TogglePoseAction), this, m_TogglePoseAction, value)) m_TogglePoseAction = value; } } // 0x18 (24)
		
		protected EntryInputActionEnum m_CrouchAction = new EntryInputActionEnum();
		[ContainerField(28), MemberInfoFlag(137), ContainerFieldNameHash(4276692283)]
		public EntryInputActionEnum CrouchAction { get { return m_CrouchAction; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(CrouchAction), this, m_CrouchAction, value)) m_CrouchAction = value; } } // 0x1C (28)
		
		protected EntryInputActionEnum m_CrouchAndHoldAction = new EntryInputActionEnum();
		[ContainerField(32), MemberInfoFlag(137), ContainerFieldNameHash(3467662783)]
		public EntryInputActionEnum CrouchAndHoldAction { get { return m_CrouchAndHoldAction; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(CrouchAndHoldAction), this, m_CrouchAndHoldAction, value)) m_CrouchAndHoldAction = value; } } // 0x20 (32)
		
		protected EntryInputActionEnum m_PickupInteractionAction = new EntryInputActionEnum();
		[ContainerField(36), MemberInfoFlag(137), ContainerFieldNameHash(2068877077)]
		public EntryInputActionEnum PickupInteractionAction { get { return m_PickupInteractionAction; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(PickupInteractionAction), this, m_PickupInteractionAction, value)) m_PickupInteractionAction = value; } } // 0x24 (36)
		
		protected List<PoseTransition> m_FiringDisablingTransitions = new List<PoseTransition>();
		[ContainerField(40), MemberInfoFlag(65), ContainerFieldNameHash(2330749333), ContainerArray]
		public List<PoseTransition> FiringDisablingTransitions { get { return m_FiringDisablingTransitions; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(FiringDisablingTransitions), this, m_FiringDisablingTransitions, value)) m_FiringDisablingTransitions = value; } } // 0x28 (40)
		
		protected float m_SprintReleaseTime = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2508865115)]
		public float SprintReleaseTime { get { return m_SprintReleaseTime; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(SprintReleaseTime), this, m_SprintReleaseTime, value)) m_SprintReleaseTime = value; } } // 0x2C (44)
		
		protected float m_ThrottleInputRequiredForSprint = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(628008395)]
		public float ThrottleInputRequiredForSprint { get { return m_ThrottleInputRequiredForSprint; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(ThrottleInputRequiredForSprint), this, m_ThrottleInputRequiredForSprint, value)) m_ThrottleInputRequiredForSprint = value; } } // 0x30 (48)
		
		protected bool m_StandAutomaticallyIfSprinting = new bool();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2006399905)]
		public bool StandAutomaticallyIfSprinting { get { return m_StandAutomaticallyIfSprinting; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(StandAutomaticallyIfSprinting), this, m_StandAutomaticallyIfSprinting, value)) m_StandAutomaticallyIfSprinting = value; } } // 0x34 (52)
		
		protected bool m_ProneToStandOnJump = new bool();
		[ContainerField(53), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1479235671)]
		public bool ProneToStandOnJump { get { return m_ProneToStandOnJump; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(ProneToStandOnJump), this, m_ProneToStandOnJump, value)) m_ProneToStandOnJump = value; } } // 0x35 (53)
		
		protected bool m_DisableCrawlingWhileReloading = new bool();
		[ContainerField(54), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1988899892)]
		public bool DisableCrawlingWhileReloading { get { return m_DisableCrawlingWhileReloading; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DisableCrawlingWhileReloading), this, m_DisableCrawlingWhileReloading, value)) m_DisableCrawlingWhileReloading = value; } } // 0x36 (54)
		
		protected bool m_DisableFiringWhileDeployingBipod = new bool();
		[ContainerField(55), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1128942440)]
		public bool DisableFiringWhileDeployingBipod { get { return m_DisableFiringWhileDeployingBipod; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DisableFiringWhileDeployingBipod), this, m_DisableFiringWhileDeployingBipod, value)) m_DisableFiringWhileDeployingBipod = value; } } // 0x37 (55)
		
		protected bool m_DisableFiringWhileJumping = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4184774481)]
		public bool DisableFiringWhileJumping { get { return m_DisableFiringWhileJumping; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DisableFiringWhileJumping), this, m_DisableFiringWhileJumping, value)) m_DisableFiringWhileJumping = value; } } // 0x38 (56)
		
		protected bool m_DisableSprintingWhileReloading = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2874893853)]
		public bool DisableSprintingWhileReloading { get { return m_DisableSprintingWhileReloading; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DisableSprintingWhileReloading), this, m_DisableSprintingWhileReloading, value)) m_DisableSprintingWhileReloading = value; } } // 0x39 (57)
		
		protected bool m_EnableSprintToCrouchTransition = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2358130898)]
		public bool EnableSprintToCrouchTransition { get { return m_EnableSprintToCrouchTransition; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(EnableSprintToCrouchTransition), this, m_EnableSprintToCrouchTransition, value)) m_EnableSprintToCrouchTransition = value; } } // 0x3A (58)
		
		protected bool m_StopSprintingWhenReleasingThrottle = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1435580527)]
		public bool StopSprintingWhenReleasingThrottle { get { return m_StopSprintingWhenReleasingThrottle; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(StopSprintingWhenReleasingThrottle), this, m_StopSprintingWhenReleasingThrottle, value)) m_StopSprintingWhenReleasingThrottle = value; } } // 0x3B (59)
		
		protected bool m_StopSprintingWhenReleasingSprint = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(485538437)]
		public bool StopSprintingWhenReleasingSprint { get { return m_StopSprintingWhenReleasingSprint; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(StopSprintingWhenReleasingSprint), this, m_StopSprintingWhenReleasingSprint, value)) m_StopSprintingWhenReleasingSprint = value; } } // 0x3C (60)
		
		protected bool m_WaitForSprintReleaseBeforeSprintAgain = new bool();
		[ContainerField(61), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(381150149)]
		public bool WaitForSprintReleaseBeforeSprintAgain { get { return m_WaitForSprintReleaseBeforeSprintAgain; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(WaitForSprintReleaseBeforeSprintAgain), this, m_WaitForSprintReleaseBeforeSprintAgain, value)) m_WaitForSprintReleaseBeforeSprintAgain = value; } } // 0x3D (61)
		
		protected bool m_VehicleBoostIsToggle = new bool();
		[ContainerField(62), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1735323024)]
		public bool VehicleBoostIsToggle { get { return m_VehicleBoostIsToggle; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(VehicleBoostIsToggle), this, m_VehicleBoostIsToggle, value)) m_VehicleBoostIsToggle = value; } } // 0x3E (62)
		
		protected bool m_InputCurvesEnabled = new bool();
		[ContainerField(63), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2151840626)]
		public bool InputCurvesEnabled { get { return m_InputCurvesEnabled; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(InputCurvesEnabled), this, m_InputCurvesEnabled, value)) m_InputCurvesEnabled = value; } } // 0x3F (63)
		
		protected bool m_DisableCrawlingWhileFiring = new bool();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1554862200)]
		public bool DisableCrawlingWhileFiring { get { return m_DisableCrawlingWhileFiring; } set { if (OnPropertyChanging("InputConfigurationAsset." + nameof(DisableCrawlingWhileFiring), this, m_DisableCrawlingWhileFiring, value)) m_DisableCrawlingWhileFiring = value; } } // 0x40 (64)
		
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
