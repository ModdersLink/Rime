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

namespace fb.SoldierShared;

[ContainerType(8, 136)]
public class ZoomLevelData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float FieldOfView { get; set; } = 55.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float FieldOfViewSP { get; set; } = -1.000f;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<FOVTransitionData> FieldOfViewTransition { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float LookSpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float SprintLookSpeedMultiplier { get; set; } = 0.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float MoveSpeedMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float SwayPitchMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float SwayYawMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float SupportedSwayPitchMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float SupportedSwayYawMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float SuppressedSwayPitchMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float SuppressedSwayYawMagnitude { get; set; } = 0.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float SuppressedSwayMinFactor { get; set; } = 0.500f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float TimePitchMultiplier { get; set; } = 0.100f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float TimeYawMultiplier { get; set; } = 0.030f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float DispersionMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float DispersionRotation { get; set; } = 0.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float RecoilMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float RecoilFovMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float CameraImpulseMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float StartFadeToBlackAtTime { get; set; } = 0.100f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float FadeToBlackDuration { get; set; } = 0.200f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float StartFadeFromBlackAtTime { get; set; } = 0.300f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float FadeFromBlackDuration { get; set; } = 0.100f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ScreenExposureAreaScale { get; set; } = 1.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public ZoomLevelActivateEventType OnActivateEventType { get; set; } = ZoomLevelActivateEventType.ZoomLevelActivateEventType_Disable;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float AttractYawStrength { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float AttractPitchStrength { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public bool AllowFieldOfViewScaling { get; set; } = false;
	
	[ContainerField(0x85), LayoutImmutable, Blittable, JsonProperty(Order = 133)]
	public bool FadeToBlackInZoomTransition { get; set; } = false;
	
	[ContainerField(0x86), LayoutImmutable, Blittable, JsonProperty(Order = 134)]
	public bool UseFovSpecialisation { get; set; } = false;
	
	[ContainerField(0x87), LayoutImmutable, Blittable, JsonProperty(Order = 135)]
	public bool UseWeaponMeshZoom1p { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FieldOfView);
		p_Writer.Write(FieldOfViewSP);
		p_Writer.Write(p_EbxWriter.WriteImport(FieldOfViewTransition));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(LookSpeedMultiplier);
		p_Writer.Write(SprintLookSpeedMultiplier);
		p_Writer.Write(MoveSpeedMultiplier);
		p_Writer.Write(SwayPitchMagnitude);
		p_Writer.Write(SwayYawMagnitude);
		p_Writer.Write(SupportedSwayPitchMagnitude);
		p_Writer.Write(SupportedSwayYawMagnitude);
		p_Writer.Write(SuppressedSwayPitchMagnitude);
		p_Writer.Write(SuppressedSwayYawMagnitude);
		p_Writer.Write(SuppressedSwayMinFactor);
		p_Writer.Write(TimePitchMultiplier);
		p_Writer.Write(TimeYawMultiplier);
		p_Writer.Write(DispersionMultiplier);
		p_Writer.Write(DispersionRotation);
		p_Writer.Write(RecoilMultiplier);
		p_Writer.Write(RecoilFovMultiplier);
		p_Writer.Write(CameraImpulseMultiplier);
		p_Writer.Write(StartFadeToBlackAtTime);
		p_Writer.Write(FadeToBlackDuration);
		p_Writer.Write(StartFadeFromBlackAtTime);
		p_Writer.Write(FadeFromBlackDuration);
		p_Writer.Write(ScreenExposureAreaScale);
		p_Writer.Write((int) OnActivateEventType);
		p_Writer.Write(AttractYawStrength);
		p_Writer.Write(AttractPitchStrength);
		p_Writer.Write(AllowFieldOfViewScaling);
		p_Writer.Write(FadeToBlackInZoomTransition);
		p_Writer.Write(UseFovSpecialisation);
		p_Writer.Write(UseWeaponMeshZoom1p);
	}
}

