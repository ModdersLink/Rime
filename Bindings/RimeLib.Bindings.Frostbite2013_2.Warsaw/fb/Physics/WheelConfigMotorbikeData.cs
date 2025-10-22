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
using fb.Entity;

namespace fb.Physics;

[ContainerType(16, 432)]
public class WheelConfigMotorbikeData
	: fb.Physics.WheelConfigData
{
	public WheelConfigMotorbikeData()
	{
		//WheelConfigData
		AllowGripSlipTransition = false;
	}
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public float MaxSpringForce { get; set; } = 15000.000f;
	
	[ContainerField(0x1a4), LayoutImmutable, Blittable, JsonProperty(Order = 420)]
	public float CollisionYawDampeningDuration { get; set; } = 0.000f;
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float CollisionYawDampening { get; set; } = 0.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(MaxSpringForce);
		p_Writer.Write(CollisionYawDampeningDuration);
		p_Writer.Write(CollisionYawDampening);
		p_Writer.WriteNullBytes(4);
	}
}

