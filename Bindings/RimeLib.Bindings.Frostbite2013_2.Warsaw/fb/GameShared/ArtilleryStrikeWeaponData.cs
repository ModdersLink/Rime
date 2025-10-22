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

[ContainerType(8, 144)]
public class ArtilleryStrikeWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MaxStrikeDistance { get; set; } = 1000.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float StrikeRadius { get; set; } = 10.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float SpawnHeight { get; set; } = 350.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float MaxRandomSpawnHeight { get; set; } = 400.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float SpawnHeightMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<TargetCameraData> Camera { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float AimingCameraHeight { get; set; } = 120.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float StrikeCameraHeight { get; set; } = 40.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float AimingCameraOffset { get; set; } = -20.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float StrikeCameraOffset { get; set; } = -30.000f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float AimingCameraFov { get; set; } = 30.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public float DelayBeforeAimingCamera { get; set; } = 1.000f;
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public float StrikeCameraFov { get; set; } = 45.000f;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public float FireCameraTime { get; set; } = 6.250f;
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float StrikeCameraTime { get; set; } = 7.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float ValidMinDistance { get; set; } = 200.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float ValidMaxDistance { get; set; } = 950.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ValidMaxAngle { get; set; } = 8.500f;
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public ArtilleryDispersionData ArtilleryDispersion { get; set; } = new();
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public bool IncreaseSpawnHeightWithDistance { get; set; } = true;
	
	[ContainerField(0x8d), LayoutImmutable, Blittable, JsonProperty(Order = 141)]
	public bool EnableProjectileTrails { get; set; } = true;
	
	[ContainerField(0x8e), LayoutImmutable, Blittable, JsonProperty(Order = 142)]
	public bool EnableCameraRotation { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxStrikeDistance);
		p_Writer.Write(StrikeRadius);
		p_Writer.Write(SpawnHeight);
		p_Writer.Write(MaxRandomSpawnHeight);
		p_Writer.Write(SpawnHeightMultiplier);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Camera));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(AimingCameraHeight);
		p_Writer.Write(StrikeCameraHeight);
		p_Writer.Write(AimingCameraOffset);
		p_Writer.Write(StrikeCameraOffset);
		p_Writer.Write(AimingCameraFov);
		p_Writer.Write(DelayBeforeAimingCamera);
		p_Writer.Write(StrikeCameraFov);
		p_Writer.Write(FireCameraTime);
		p_Writer.Write(StrikeCameraTime);
		p_Writer.Write(ValidMinDistance);
		p_Writer.Write(ValidMaxDistance);
		p_Writer.Write(ValidMaxAngle);
		ArtilleryDispersion.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(IncreaseSpawnHeightWithDistance);
		p_Writer.Write(EnableProjectileTrails);
		p_Writer.Write(EnableCameraRotation);
		p_Writer.WriteNullBytes(1);
	}
}

