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

using fb.Physics;
using fb.Core;

namespace fb.SoldierShared;

[ContainerType(16, 80)]
public class AutoAimData
	: EbxSerializable
{
	[ContainerField(0x0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public Vec3 AutoAimOuterBoxOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 1.200f,
		x = 0.000f,
	};
	
	[ContainerField(0x10), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public Vec3 AutoAimOuterBoxExtends { get; set; } = new()
	{
		z = 0.750f,
		y = 1.000f,
		x = 0.750f,
	};
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 AutoAimInnerBoxOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 1.200f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 AutoAimInnerBoxExtends { get; set; } = new()
	{
		z = 0.250f,
		y = 0.250f,
		x = 0.250f,
	};
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public CharacterPoseType PoseType { get; set; } = CharacterPoseType.CharacterPoseType_Stand;
	
}

