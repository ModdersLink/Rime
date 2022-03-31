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

namespace fb
{
	[ContainerType(4, 68)]
	public class InputConfigurationAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public CtrRef<EntryInputActionMapsData> DefaultInputConceptDefinition { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<InputConceptIdentifiers> DefaultExclusiveInputConcepts { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<EditableActionMap> UserConfigurableActionMaps { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public EntryInputActionEnum TogglePoseAction { get; set; } = new();

		[ContainerField(28), JsonProperty(Order = 28)]
		public EntryInputActionEnum CrouchAction { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public EntryInputActionEnum CrouchAndHoldAction { get; set; } = new();

		[ContainerField(36), JsonProperty(Order = 36)]
		public EntryInputActionEnum PickupInteractionAction { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public List<PoseTransition> FiringDisablingTransitions { get; set; } = new();

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float SprintReleaseTime { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float ThrottleInputRequiredForSprint { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool StandAutomaticallyIfSprinting { get; set; }

		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool ProneToStandOnJump { get; set; }

		[ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		public bool DisableCrawlingWhileReloading { get; set; }

		[ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		public bool DisableFiringWhileDeployingBipod { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool DisableFiringWhileJumping { get; set; }

		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool DisableSprintingWhileReloading { get; set; }

		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool EnableSprintToCrouchTransition { get; set; }

		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool StopSprintingWhenReleasingThrottle { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool StopSprintingWhenReleasingSprint { get; set; }

		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool WaitForSprintReleaseBeforeSprintAgain { get; set; }

		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool VehicleBoostIsToggle { get; set; }

		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool InputCurvesEnabled { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool DisableCrawlingWhileFiring { get; set; }

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
