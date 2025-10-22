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

[ContainerType(8, 88)]
public class WeaponFiringData
	: fb.Core.GameDataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public CtrRef<FiringFunctionData> PrimaryFire { get; set; } = new();
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DeployTime { get; set; } = 2.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float ReactivateCooldownTime { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DisableZoomOnDeployTime { get; set; } = 0.250f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AltDeployTime { get; set; } = 2.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public int AltDeployId { get; set; } = -1;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<WeaponSwayData> WeaponSway { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RumbleFiringData Rumble { get; set; } = new();
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float SupportDelayStand { get; set; } = 0.300f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float SupportDelayProne { get; set; } = 0.300f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool UseAutoAiming { get; set; } = true;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool InflictSelfDamage { get; set; } = false;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool ShowEnemyNametagOnAim { get; set; } = true;
	
	[ContainerField(0x4f), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
	public bool ReloadWholeMags { get; set; } = false;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public bool DisableReloadWhileSprinting { get; set; } = false;
	
	[ContainerField(0x51), LayoutImmutable, Blittable, JsonProperty(Order = 81)]
	public bool AbortReloadOnSprint { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(PrimaryFire));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(DeployTime);
		p_Writer.Write(ReactivateCooldownTime);
		p_Writer.Write(DisableZoomOnDeployTime);
		p_Writer.Write(AltDeployTime);
		p_Writer.Write(AltDeployId);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(WeaponSway));
		p_Writer.WriteNullBytes(4);
		Rumble.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SupportDelayStand);
		p_Writer.Write(SupportDelayProne);
		p_Writer.Write(UseAutoAiming);
		p_Writer.Write(InflictSelfDamage);
		p_Writer.Write(ShowEnemyNametagOnAim);
		p_Writer.Write(ReloadWholeMags);
		p_Writer.Write(DisableReloadWhileSprinting);
		p_Writer.Write(AbortReloadOnSprint);
		p_Writer.WriteNullBytes(6);
	}
}

