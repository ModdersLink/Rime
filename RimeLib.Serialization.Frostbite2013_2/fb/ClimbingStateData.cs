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

namespace fb.Physics;

[ContainerType(8, 64)]
public class ClimbingStateData
	: fb.Physics.CharacterStateData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float LateralInputScale { get; set; } = 0.300f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float DownAngleLimit { get; set; } = 35.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float DropOffAngle { get; set; } = 30.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AttractionVelocity { get; set; } = 0.100f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float PushAwayVelocity { get; set; } = 3.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ClimbHeightOffset { get; set; } = 0.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float ClimbOffVerticalDistance { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float ClimbOffVerticalTime { get; set; } = 1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float ClimbOffHorizontalDistance { get; set; } = 0.680f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float ClimbOffHorizontalTime { get; set; } = 0.800f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LateralInputScale);
		p_Writer.Write(DownAngleLimit);
		p_Writer.Write(DropOffAngle);
		p_Writer.Write(AttractionVelocity);
		p_Writer.Write(PushAwayVelocity);
		p_Writer.Write(ClimbHeightOffset);
		p_Writer.Write(ClimbOffVerticalDistance);
		p_Writer.Write(ClimbOffVerticalTime);
		p_Writer.Write(ClimbOffHorizontalDistance);
		p_Writer.Write(ClimbOffHorizontalTime);
	}
}

