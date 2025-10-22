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

namespace fb.GameShared;

[ContainerType(16, 64)]
public class ClientEffectMaskVolumeEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float LifeTimeInSeconds { get; set; } = 3.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec4 ApplyEffectCurve { get; set; } = new()
	{
		w = 1.933f,
		z = -0.951f,
		y = 2.747f,
		x = -4.085f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float UpdatePeriodInSeconds { get; set; } = 0.200f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float Radius { get; set; } = 20.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LifeTimeInSeconds);
		p_Writer.WriteNullBytes(4);
		ApplyEffectCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UpdatePeriodInSeconds);
		p_Writer.Write(Radius);
		p_Writer.WriteNullBytes(8);
	}
}

