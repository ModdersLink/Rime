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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 256)]
public class AnimatedDriverEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AntRef VehicleSpeed { get; set; } = new();
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public LinearTransform InputTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public AntRef VehicleMovementState { get; set; } = new();
	
	[ContainerField(0x84), JsonProperty(Order = 132)]
	public AntRef VehicleBoost { get; set; } = new();
	
	[ContainerField(0x98), JsonProperty(Order = 152)]
	public AntRef VehicleBrake { get; set; } = new();
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float MovementStateStandThreshold { get; set; } = 1.000f;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public NormalizeSettings Yaw { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public NormalizeSettings Pitch { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public NormalizeSettings Roll { get; set; } = new();
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public bool DelayAnimationWheelTransform { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		VehicleSpeed.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		InputTransform.Serialize(p_Writer, p_EbxWriter);
		VehicleMovementState.Serialize(p_Writer, p_EbxWriter);
		VehicleBoost.Serialize(p_Writer, p_EbxWriter);
		VehicleBrake.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MovementStateStandThreshold);
		Yaw.Serialize(p_Writer, p_EbxWriter);
		Pitch.Serialize(p_Writer, p_EbxWriter);
		Roll.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DelayAnimationWheelTransform);
		p_Writer.WriteNullBytes(7);
	}
}

