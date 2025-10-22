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

using fb.Entity;
using fb.Core;
using fb.GameShared;

namespace fb.Venice;

[ContainerType(8, 64)]
public class VehicleDeployWeaponData
	: fb.GameShared.WeaponData
{
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DeployAreaRadius { get; set; } = 0.500f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float DeployAreaGroundRayLength { get; set; } = 2.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float DeployAreaGroundFlatness { get; set; } = 0.900f;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<ObjectBlueprint> PreviewObject { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool CanRemoteEnterVehicle { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool UsePreview { get; set; } = true;
	
	[ContainerField(0x3a), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
	public bool CheckClearSky { get; set; } = false;
	
	[ContainerField(0x3b), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
	public bool IsAllowedToPickupDeployedVehicle { get; set; } = true;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public bool AllowMultipleDeployedVehicles { get; set; } = false;
	
	[ContainerField(0x3d), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
	public bool DestroyVehicleWhenWeaponIsDestroyed { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DeployAreaRadius);
		p_Writer.Write(DeployAreaGroundRayLength);
		p_Writer.Write(DeployAreaGroundFlatness);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PreviewObject));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CanRemoteEnterVehicle);
		p_Writer.Write(UsePreview);
		p_Writer.Write(CheckClearSky);
		p_Writer.Write(IsAllowedToPickupDeployedVehicle);
		p_Writer.Write(AllowMultipleDeployedVehicles);
		p_Writer.Write(DestroyVehicleWhenWeaponIsDestroyed);
		p_Writer.WriteNullBytes(2);
	}
}

