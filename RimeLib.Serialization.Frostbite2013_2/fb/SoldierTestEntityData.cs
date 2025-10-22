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

using fb.GameShared;
using fb.Core;
using fb.SoldierShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(16, 240)]
public class SoldierTestEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<SoldierBlueprint> TestSoldier { get; set; } = new();
	
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<CharacterSpawnTemplateData> Template { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<VehicleBlueprint> TestVehicle { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<RawFileAsset> UnlocksProfile { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public TeamId Team { get; set; } = TeamId.Team1;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public int RandomSeed { get; set; } = 1023493;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<MovementActionData> StartSequence { get; set; } = new();
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<MovementActionRoot> StartSequenceRoot { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string CameraMovementsFilename { get; set; } = @"SoldierTestCamera";
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<InputRecorderData> InputRecorder { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float ThrottleInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float StrafeInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float YawInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float PitchInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float RollInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float FireInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float JumpInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float ProneInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float ZoomInputVal { get; set; } = 0.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float FireCounterMeasure { get; set; } = 0.000f;
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float ActiveInputRecording { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float AuthoritativeAimingActive { get; set; } = 0.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float AuthoritativeYaw { get; set; } = 0.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float AuthoritativePitch { get; set; } = 0.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float SpecialAnimationIndex { get; set; } = 0.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public bool UseUnlocksProfile { get; set; } = true;
	
	[ContainerField(0xe5), LayoutImmutable, Blittable, JsonProperty(Order = 229)]
	public bool RunAutomatically { get; set; } = true;
	
	[ContainerField(0xe6), LayoutImmutable, Blittable, JsonProperty(Order = 230)]
	public bool SprintInputVal { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(TestSoldier));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Template));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(TestVehicle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(UnlocksProfile));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) Team);
		p_Writer.Write(RandomSeed);
		p_Writer.Write(p_EbxWriter.WriteImport(StartSequence));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StartSequenceRoot));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(CameraMovementsFilename));
		p_Writer.Write(p_EbxWriter.WriteImport(InputRecorder));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ThrottleInputVal);
		p_Writer.Write(StrafeInputVal);
		p_Writer.Write(YawInputVal);
		p_Writer.Write(PitchInputVal);
		p_Writer.Write(RollInputVal);
		p_Writer.Write(FireInputVal);
		p_Writer.Write(JumpInputVal);
		p_Writer.Write(ProneInputVal);
		p_Writer.Write(ZoomInputVal);
		p_Writer.Write(FireCounterMeasure);
		p_Writer.Write(ActiveInputRecording);
		p_Writer.Write(AuthoritativeAimingActive);
		p_Writer.Write(AuthoritativeYaw);
		p_Writer.Write(AuthoritativePitch);
		p_Writer.Write(SpecialAnimationIndex);
		p_Writer.Write(UseUnlocksProfile);
		p_Writer.Write(RunAutomatically);
		p_Writer.Write(SprintInputVal);
		p_Writer.WriteNullBytes(9);
	}
}

