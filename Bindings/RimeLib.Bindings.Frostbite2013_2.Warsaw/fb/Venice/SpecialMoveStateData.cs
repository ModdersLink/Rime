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

namespace fb.Venice;

[ContainerType(8, 72)]
public class SpecialMoveStateData
	: EbxSerializable
{
	[ContainerField(0x0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
	public float OptimumDistanceFromObject { get; set; } = 1.000f;
	
	[ContainerField(0x4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
	public float OptimumHeightOfObject { get; set; } = 1.000f;
	
	[ContainerField(0x8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
	public float OptimumLengthOfObject { get; set; } = 0.050f;
	
	[ContainerField(0xc), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
	public float MaxDistanceScale { get; set; } = 2.000f;
	
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float MinDistanceScale { get; set; } = 0.800f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float MaxHeightScale { get; set; } = 2.000f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float MinHeightScale { get; set; } = 0.900f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float MaxObjectLengthScale { get; set; } = 1.700f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float MinObjectLengthScale { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float ExitAnimationDrivenStateVelocity { get; set; } = -1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public SpecialMovesPoseType OverridePose { get; set; } = SpecialMovesPoseType.SpecialMovesPoseType_None;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public SpecialMovesPoseType ResetPose { get; set; } = SpecialMovesPoseType.SpecialMovesPoseType_None;
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<SpecialMoveInterpolatedPoint> GravityPoints { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<SpecialMoveInterpolatedPoint> MotionPoints { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool ScaleWithDistanceToObject { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool KeepInitialSoldierDirection { get; set; } = false;
	
}

