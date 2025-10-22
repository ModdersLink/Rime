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
public class ParachuteStateData
	: fb.Physics.CharacterStateData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float DeployTime { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float TerminalVelocity { get; set; } = 8.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float ForwardDragCoefficient { get; set; } = 0.025f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float AngleOfAttack { get; set; } = 22.500f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float BankOffset { get; set; } = 0.250f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float ThrottleOffset { get; set; } = 1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float BrakeOffset { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float MaxRollVelocity { get; set; } = 20.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float MaxPitchVelocity { get; set; } = 45.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float MaxYawVelocity { get; set; } = 50.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(DeployTime);
		p_Writer.Write(TerminalVelocity);
		p_Writer.Write(ForwardDragCoefficient);
		p_Writer.Write(AngleOfAttack);
		p_Writer.Write(BankOffset);
		p_Writer.Write(ThrottleOffset);
		p_Writer.Write(BrakeOffset);
		p_Writer.Write(MaxRollVelocity);
		p_Writer.Write(MaxPitchVelocity);
		p_Writer.Write(MaxYawVelocity);
	}
}

