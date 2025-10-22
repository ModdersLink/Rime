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

[ContainerType(8, 72)]
public class RotorParameters
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float CyclicInputScaleRoll { get; set; } = 0.200f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float CyclicInputScalePitch { get; set; } = 0.200f;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float CollectiveThrottleInputScale { get; set; } = 1.100f;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public float CollectiveBrakeInputScale { get; set; } = 1.100f;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public float CollectiveInputIdle { get; set; } = 0.900f;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float HorizontalForceModifier { get; set; } = 1.000f;
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<Vec2> AngleOfAttack { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float CyclicFadeOutOffset { get; set; } = 0.250f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float AdditionalGravityModifier { get; set; } = 8.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float HorisontalMinEffectVelocity { get; set; } = 20.000f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public float HorisontalMinEffectMod { get; set; } = 0.200f;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public bool ReverseThrottle { get; set; } = false;
	
	[ContainerField(0x41), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
	public bool EnableHorisontalMinEffect { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CyclicInputScaleRoll);
		p_Writer.Write(CyclicInputScalePitch);
		p_Writer.Write(CollectiveThrottleInputScale);
		p_Writer.Write(CollectiveBrakeInputScale);
		p_Writer.Write(CollectiveInputIdle);
		p_Writer.Write(HorizontalForceModifier);
		(RimeWriter Writer, uint ArrayIndex) s_AngleOfAttack = p_EbxWriter.GetArrayWriter(AngleOfAttack.GetType(), AngleOfAttack.Count);
		p_Writer.Write(s_AngleOfAttack.ArrayIndex);
		foreach (var s_Entry in AngleOfAttack)
		{
			s_Entry.Serialize(s_AngleOfAttack.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CyclicFadeOutOffset);
		p_Writer.Write(AdditionalGravityModifier);
		p_Writer.Write(HorisontalMinEffectVelocity);
		p_Writer.Write(HorisontalMinEffectMod);
		p_Writer.Write(ReverseThrottle);
		p_Writer.Write(EnableHorisontalMinEffect);
		p_Writer.WriteNullBytes(6);
	}
}

