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

namespace fb.Render;

[ContainerType(16, 176)]
public class VignetteComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 Color { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x94), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public Vec2 Scale { get; set; } = new()
	{
		y = 2.000f,
		x = 2.000f,
	};
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float Exponent { get; set; } = 1.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float Opacity { get; set; } = 0.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public bool Enable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Color.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		Scale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Exponent);
		p_Writer.Write(Opacity);
		p_Writer.Write(Enable);
		p_Writer.WriteNullBytes(11);
	}
}

