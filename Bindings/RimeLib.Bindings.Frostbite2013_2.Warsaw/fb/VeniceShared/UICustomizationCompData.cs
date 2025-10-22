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
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(16, 192)]
public class UICustomizationCompData
	: fb.UI.UIComponentData
{
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float WeaponScreenWidthPercent { get; set; } = 0.800f;
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 SoldierOffset { get; set; } = new()
	{
		z = -3.000f,
		y = -0.500f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 VehicleOffset { get; set; } = new()
	{
		z = -10.000f,
		y = -1.500f,
		x = 0.000f,
	};
	
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 SoldierRotation { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public Vec3 VehicleRotation { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float WeaponRotationLerpSpeed { get; set; } = 10.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float WeaponRotationSpeed { get; set; } = 3.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float GamepadZoomSpeed { get; set; } = 1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float MouseZoomSpeed { get; set; } = 0.100f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MouseRotationSpeed { get; set; } = 0.002f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float WeaponStartRotY { get; set; } = 0.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float WeaponStartRotZ { get; set; } = 0.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float WeaponMaxAngleY { get; set; } = 60.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float WeaponMinAngleY { get; set; } = -60.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float WeaponMaxAngleZ { get; set; } = 45.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float RotAroundCameraY { get; set; } = -8.500f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float WeaponAccessoryPivotLerpSpeed { get; set; } = 15.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float SoldierRotationSpeed { get; set; } = 1.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float VehicleRotationSpeed { get; set; } = 1.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float NetworkThrottleTimer { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WeaponScreenWidthPercent);
		p_Writer.WriteNullBytes(12);
		SoldierOffset.Serialize(p_Writer, p_EbxWriter);
		VehicleOffset.Serialize(p_Writer, p_EbxWriter);
		SoldierRotation.Serialize(p_Writer, p_EbxWriter);
		VehicleRotation.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WeaponRotationLerpSpeed);
		p_Writer.Write(WeaponRotationSpeed);
		p_Writer.Write(GamepadZoomSpeed);
		p_Writer.Write(MouseZoomSpeed);
		p_Writer.Write(MouseRotationSpeed);
		p_Writer.Write(WeaponStartRotY);
		p_Writer.Write(WeaponStartRotZ);
		p_Writer.Write(WeaponMaxAngleY);
		p_Writer.Write(WeaponMinAngleY);
		p_Writer.Write(WeaponMaxAngleZ);
		p_Writer.Write(RotAroundCameraY);
		p_Writer.Write(WeaponAccessoryPivotLerpSpeed);
		p_Writer.Write(SoldierRotationSpeed);
		p_Writer.Write(VehicleRotationSpeed);
		p_Writer.Write(NetworkThrottleTimer);
		p_Writer.WriteNullBytes(4);
	}
}

