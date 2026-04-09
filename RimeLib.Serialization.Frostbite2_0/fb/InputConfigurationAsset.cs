///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 68)]
	public partial class InputConfigurationAsset :
		Asset
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<EntryInputActionMapsData> _DefaultInputConceptDefinition = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<InputConceptIdentifiers> _DefaultExclusiveInputConcepts = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<EditableActionMap> _UserConfigurableActionMaps = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private EntryInputActionEnum _TogglePoseAction = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private EntryInputActionEnum _CrouchAction = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private EntryInputActionEnum _CrouchAndHoldAction = new();

		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private EntryInputActionEnum _PickupInteractionAction = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private List<PoseTransition> _FiringDisablingTransitions = new();

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _SprintReleaseTime;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _ThrottleInputRequiredForSprint;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private bool _StandAutomaticallyIfSprinting;

		[ObservableProperty]
		[property: ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		private bool _ProneToStandOnJump;

		[ObservableProperty]
		[property: ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		private bool _DisableCrawlingWhileReloading;

		[ObservableProperty]
		[property: ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		private bool _DisableFiringWhileDeployingBipod;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private bool _DisableFiringWhileJumping;

		[ObservableProperty]
		[property: ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		private bool _DisableSprintingWhileReloading;

		[ObservableProperty]
		[property: ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		private bool _EnableSprintToCrouchTransition;

		[ObservableProperty]
		[property: ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		private bool _StopSprintingWhenReleasingThrottle;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private bool _StopSprintingWhenReleasingSprint;

		[ObservableProperty]
		[property: ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		private bool _WaitForSprintReleaseBeforeSprintAgain;

		[ObservableProperty]
		[property: ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		private bool _VehicleBoostIsToggle;

		[ObservableProperty]
		[property: ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		private bool _InputCurvesEnabled;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private bool _DisableCrawlingWhileFiring;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(DefaultInputConceptDefinition));
			(RimeWriter Writer, uint ArrayIndex) s_DefaultExclusiveInputConcepts = p_EbxWriter.GetArrayWriter(DefaultExclusiveInputConcepts.GetType(), DefaultExclusiveInputConcepts.Count);
			p_Writer.Write(s_DefaultExclusiveInputConcepts.ArrayIndex);
			foreach (var s_Entry in DefaultExclusiveInputConcepts)
			{
				s_DefaultExclusiveInputConcepts.Writer.Write((int) s_Entry);
			}
			(RimeWriter Writer, uint ArrayIndex) s_UserConfigurableActionMaps = p_EbxWriter.GetArrayWriter(UserConfigurableActionMaps.GetType(), UserConfigurableActionMaps.Count);
			p_Writer.Write(s_UserConfigurableActionMaps.ArrayIndex);
			foreach (var s_Entry in UserConfigurableActionMaps)
			{
				s_Entry.Serialize(s_UserConfigurableActionMaps.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) TogglePoseAction);
			p_Writer.Write((int) CrouchAction);
			p_Writer.Write((int) CrouchAndHoldAction);
			p_Writer.Write((int) PickupInteractionAction);
			(RimeWriter Writer, uint ArrayIndex) s_FiringDisablingTransitions = p_EbxWriter.GetArrayWriter(FiringDisablingTransitions.GetType(), FiringDisablingTransitions.Count);
			p_Writer.Write(s_FiringDisablingTransitions.ArrayIndex);
			foreach (var s_Entry in FiringDisablingTransitions)
			{
				s_FiringDisablingTransitions.Writer.Write((int) s_Entry);
			}
			p_Writer.Write(SprintReleaseTime);
			p_Writer.Write(ThrottleInputRequiredForSprint);
			p_Writer.Write(StandAutomaticallyIfSprinting);
			p_Writer.Write(ProneToStandOnJump);
			p_Writer.Write(DisableCrawlingWhileReloading);
			p_Writer.Write(DisableFiringWhileDeployingBipod);
			p_Writer.Write(DisableFiringWhileJumping);
			p_Writer.Write(DisableSprintingWhileReloading);
			p_Writer.Write(EnableSprintToCrouchTransition);
			p_Writer.Write(StopSprintingWhenReleasingThrottle);
			p_Writer.Write(StopSprintingWhenReleasingSprint);
			p_Writer.Write(WaitForSprintReleaseBeforeSprintAgain);
			p_Writer.Write(VehicleBoostIsToggle);
			p_Writer.Write(InputCurvesEnabled);
			p_Writer.Write(DisableCrawlingWhileFiring);
			p_Writer.WriteNullBytes(3);
		}
	}
}
