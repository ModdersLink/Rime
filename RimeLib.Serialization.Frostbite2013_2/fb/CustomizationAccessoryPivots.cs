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

[ContainerType(16, 80)]
public class CustomizationAccessoryPivots
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 BasePivotPos { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 OpticPivotPos { get; set; } = new()
	{
		z = 0.400f,
		y = 0.075f,
		x = 0.000f,
	};
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 BarrelPivotPos { get; set; } = new()
	{
		z = 0.700f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 AccessoryPivotPos { get; set; } = new()
	{
		z = 0.600f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec3 UnderBarrelPivotPos { get; set; } = new()
	{
		z = 0.500f,
		y = -0.050f,
		x = 0.000f,
	};
	
}

