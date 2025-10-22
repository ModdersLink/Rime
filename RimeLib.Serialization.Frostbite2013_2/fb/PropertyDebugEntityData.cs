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

[ContainerType(16, 208)]
public class PropertyDebugEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 TextColor { get; set; } = new()
	{
		z = 0.500f,
		y = 0.500f,
		x = 0.500f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 WorldPosition { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public LinearTransform TransformValue { get; set; } = new()
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
	
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 Vec3Value { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec2 ScreenPosition { get; set; } = new()
	{
		y = 100.000f,
		x = 100.000f,
	};
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string ValuePrefix { get; set; } = @"DebugProperty: ";
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float TextScale { get; set; } = 1.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float FloatValue { get; set; } = 0.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public int IntValue { get; set; } = 0;
	
	[ContainerField(0xac), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public Vec2 Vec2Value { get; set; } = new()
	{
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public string StringValue { get; set; } = string.Empty;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public bool Multiline { get; set; } = true;
	
	[ContainerField(0xc1), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
	public bool ShowTransformInWorld { get; set; } = false;
	
	[ContainerField(0xc2), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
	public bool ShowTransformCoordinates { get; set; } = true;
	
	[ContainerField(0xc3), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
	public bool DefaultVisible { get; set; } = true;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public bool BoolValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		TextColor.Serialize(p_Writer, p_EbxWriter);
		WorldPosition.Serialize(p_Writer, p_EbxWriter);
		TransformValue.Serialize(p_Writer, p_EbxWriter);
		Vec3Value.Serialize(p_Writer, p_EbxWriter);
		ScreenPosition.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(ValuePrefix));
		p_Writer.Write(TextScale);
		p_Writer.Write(FloatValue);
		p_Writer.Write(IntValue);
		Vec2Value.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(StringValue));
		p_Writer.Write(Multiline);
		p_Writer.Write(ShowTransformInWorld);
		p_Writer.Write(ShowTransformCoordinates);
		p_Writer.Write(DefaultVisible);
		p_Writer.Write(BoolValue);
		p_Writer.WriteNullBytes(11);
	}
}

