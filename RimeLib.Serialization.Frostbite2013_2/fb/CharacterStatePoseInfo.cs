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

[ContainerType(8, 88)]
public class CharacterStatePoseInfo
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public CharacterPoseType PoseType { get; set; } = CharacterPoseType.CharacterPoseType_Stand;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float Velocity { get; set; } = 3.500f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float AccelerationGain { get; set; } = 1.000f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float AccelerationGain_TickRateMult { get; set; } = 0.000f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float AccelerationGain_TickRatePower { get; set; } = 1.000f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float DecelerationGain { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float DecelerationGain_TickRateMult { get; set; } = 0.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float DecelerationGain_TickRatePower { get; set; } = 1.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float SprintGain { get; set; } = 1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float SprintGain_TickRateMult { get; set; } = 0.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float SprintGain_TickRatePower { get; set; } = 1.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float SprintMultiplier { get; set; } = 0.000f;
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public SpeedModifierData SpeedModifier { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ShallowWaterMultiplier { get; set; } = 1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) PoseType);
		p_Writer.Write(Velocity);
		p_Writer.Write(AccelerationGain);
		p_Writer.Write(AccelerationGain_TickRateMult);
		p_Writer.Write(AccelerationGain_TickRatePower);
		p_Writer.Write(DecelerationGain);
		p_Writer.Write(DecelerationGain_TickRateMult);
		p_Writer.Write(DecelerationGain_TickRatePower);
		p_Writer.Write(SprintGain);
		p_Writer.Write(SprintGain_TickRateMult);
		p_Writer.Write(SprintGain_TickRatePower);
		p_Writer.Write(SprintMultiplier);
		SpeedModifier.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ShallowWaterMultiplier);
		p_Writer.WriteNullBytes(4);
	}
}

