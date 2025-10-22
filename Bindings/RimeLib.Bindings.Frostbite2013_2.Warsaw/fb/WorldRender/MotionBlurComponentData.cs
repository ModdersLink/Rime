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

namespace fb.WorldRender;

[ContainerType(16, 176)]
public class MotionBlurComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float MotionBlurScale { get; set; } = 1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float MotionBlurCutoffRadius { get; set; } = 0.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float CutoffGradientScale { get; set; } = 1.000f;
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec2 RadialBlurCenter { get; set; } = new()
	{
		y = 0.500f,
		x = 0.500f,
	};
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float RadialBlurOffset { get; set; } = 0.300f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float RadialBlurScale { get; set; } = 0.100f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public bool MotionBlurEnable { get; set; } = true;
	
	[ContainerField(0xa1), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
	public bool MotionBlurCentered { get; set; } = false;
	
	[ContainerField(0xa2), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
	public bool RadialBlurEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(MotionBlurScale);
		p_Writer.Write(MotionBlurCutoffRadius);
		p_Writer.Write(CutoffGradientScale);
		RadialBlurCenter.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RadialBlurOffset);
		p_Writer.Write(RadialBlurScale);
		p_Writer.Write(MotionBlurEnable);
		p_Writer.Write(MotionBlurCentered);
		p_Writer.Write(RadialBlurEnable);
		p_Writer.WriteNullBytes(13);
	}
}

