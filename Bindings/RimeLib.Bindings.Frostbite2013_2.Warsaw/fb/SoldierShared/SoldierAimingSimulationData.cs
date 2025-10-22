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

namespace fb.SoldierShared;

[ContainerType(8, 152)]
public class SoldierAimingSimulationData
	: fb.Core.GameDataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<ZoomLevelData> ZoomLevels { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoldierAimAssistData> AimAssist { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AimingPoseData StandPose { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public AimingPoseData CrouchPose { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AimingPoseData PronePose { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ZoomTransitionTime { get; set; } = 0.200f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public List<ZoomLevelSpecificTransitionTime> ZoomTransitionTimeArray { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float FovDelayTime { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float FovTransitionTime { get; set; } = 0.150f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float AimingRange { get; set; } = 100.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float LockAimToTargetSpeed { get; set; } = 180.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public RefArray<AimerModifierData> Modifiers { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool ReturnToZoomAfterReload { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_ZoomLevels = p_EbxWriter.GetArrayWriter(ZoomLevels.GetType(), ZoomLevels.Count);
		p_Writer.Write(s_ZoomLevels.ArrayIndex);
		foreach (var s_Entry in ZoomLevels)
		{
			s_ZoomLevels.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(AimAssist));
		p_Writer.WriteNullBytes(4);
		StandPose.Serialize(p_Writer, p_EbxWriter);
		CrouchPose.Serialize(p_Writer, p_EbxWriter);
		PronePose.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ZoomTransitionTime);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_ZoomTransitionTimeArray = p_EbxWriter.GetArrayWriter(ZoomTransitionTimeArray.GetType(), ZoomTransitionTimeArray.Count);
		p_Writer.Write(s_ZoomTransitionTimeArray.ArrayIndex);
		foreach (var s_Entry in ZoomTransitionTimeArray)
		{
			s_Entry.Serialize(s_ZoomTransitionTimeArray.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FovDelayTime);
		p_Writer.Write(FovTransitionTime);
		p_Writer.Write(AimingRange);
		p_Writer.Write(LockAimToTargetSpeed);
		(RimeWriter Writer, uint ArrayIndex) s_Modifiers = p_EbxWriter.GetArrayWriter(Modifiers.GetType(), Modifiers.Count);
		p_Writer.Write(s_Modifiers.ArrayIndex);
		foreach (var s_Entry in Modifiers)
		{
			s_Modifiers.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ReturnToZoomAfterReload);
		p_Writer.WriteNullBytes(7);
	}
}

