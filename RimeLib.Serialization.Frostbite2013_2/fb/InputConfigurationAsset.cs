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

using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 120)]
public class InputConfigurationAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<EntryInputActionMapsData> DefaultInputConceptDefinition { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<InputConceptIdentifiers> DefaultExclusiveInputConcepts { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public CtrRef<EntryInputActionBindingsData> EntryInputActionBindings { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<EditableActionMap> UserConfigurableActionMaps { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public int TogglePoseAction { get; set; } = -467562617;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public int CrouchAction { get; set; } = 899534898;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int CrouchAndHoldAction { get; set; } = 899534898;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public int PickupInteractionAction { get; set; } = 1573615674;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int PickupInteractionActionKeyboard { get; set; } = 899534898;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float SprintReleaseTime { get; set; } = 0.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ThrottleInputRequiredForSprint { get; set; } = 0.500f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float VehicleBoostIsToggleMinInput { get; set; } = 0.500f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float EnterVehicleHoldTime { get; set; } = 0.000f;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public List<PoseTransition> FiringDisablingTransitions { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool ProneToStandOnJump { get; set; } = false;
	
	[ContainerField(0x69), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
	public bool StandAutomaticallyIfSprinting { get; set; } = true;
	
	[ContainerField(0x6a), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
	public bool DisableCrouch { get; set; } = false;
	
	[ContainerField(0x6b), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
	public bool DisableProne { get; set; } = false;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool DisableCrawlingWhileFiring { get; set; } = true;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool DisableCrawlingWhileReloading { get; set; } = true;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool DisableFiringWhileDeployingBipod { get; set; } = true;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool DisableFiringWhileJumping { get; set; } = true;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool DisableSprintingWhileReloading { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool EnableSprintToCrouchTransition { get; set; } = false;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool StopSprintingWhenReleasingThrottle { get; set; } = false;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool StopSprintingWhenReleasingSprint { get; set; } = true;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool WaitForSprintReleaseBeforeSprintAgain { get; set; } = true;
	
	[ContainerField(0x75), LayoutImmutable, Blittable, JsonProperty(Order = 117)]
	public bool VehicleBoostIsToggle { get; set; } = false;
	
	[ContainerField(0x76), LayoutImmutable, Blittable, JsonProperty(Order = 118)]
	public bool InputCurvesEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(DefaultInputConceptDefinition));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_DefaultExclusiveInputConcepts = p_EbxWriter.GetArrayWriter(DefaultExclusiveInputConcepts.GetType(), DefaultExclusiveInputConcepts.Count);
		p_Writer.Write(s_DefaultExclusiveInputConcepts.ArrayIndex);
		foreach (var s_Entry in DefaultExclusiveInputConcepts)
		{
			s_DefaultExclusiveInputConcepts.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EntryInputActionBindings));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UserConfigurableActionMaps = p_EbxWriter.GetArrayWriter(UserConfigurableActionMaps.GetType(), UserConfigurableActionMaps.Count);
		p_Writer.Write(s_UserConfigurableActionMaps.ArrayIndex);
		foreach (var s_Entry in UserConfigurableActionMaps)
		{
			s_Entry.Serialize(s_UserConfigurableActionMaps.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(TogglePoseAction);
		p_Writer.Write(CrouchAction);
		p_Writer.Write(CrouchAndHoldAction);
		p_Writer.Write(PickupInteractionAction);
		p_Writer.Write(PickupInteractionActionKeyboard);
		p_Writer.Write(SprintReleaseTime);
		p_Writer.Write(ThrottleInputRequiredForSprint);
		p_Writer.Write(VehicleBoostIsToggleMinInput);
		p_Writer.Write(EnterVehicleHoldTime);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_FiringDisablingTransitions = p_EbxWriter.GetArrayWriter(FiringDisablingTransitions.GetType(), FiringDisablingTransitions.Count);
		p_Writer.Write(s_FiringDisablingTransitions.ArrayIndex);
		foreach (var s_Entry in FiringDisablingTransitions)
		{
			s_FiringDisablingTransitions.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ProneToStandOnJump);
		p_Writer.Write(StandAutomaticallyIfSprinting);
		p_Writer.Write(DisableCrouch);
		p_Writer.Write(DisableProne);
		p_Writer.Write(DisableCrawlingWhileFiring);
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
		p_Writer.WriteNullBytes(1);
	}
}

