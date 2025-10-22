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

[ContainerType(16, 144)]
public class DebugTextEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Vec3 TextColor { get; set; } = new()
	{
		z = 0.500f,
		y = 0.500f,
		x = 0.500f,
	};
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public string DebugText { get; set; } = string.Empty;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float Scale { get; set; } = 1.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public bool Centered { get; set; } = true;
	
	[ContainerField(0x81), LayoutImmutable, Blittable, JsonProperty(Order = 129)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x82), LayoutImmutable, Blittable, JsonProperty(Order = 130)]
	public bool DepthTest { get; set; } = true;
	
	[ContainerField(0x83), LayoutImmutable, Blittable, JsonProperty(Order = 131)]
	public bool ScaleWithDistance { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TextColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(DebugText));
		p_Writer.Write((int) Realm);
		p_Writer.Write(Scale);
		p_Writer.Write(Centered);
		p_Writer.Write(Visible);
		p_Writer.Write(DepthTest);
		p_Writer.Write(ScaleWithDistance);
		p_Writer.WriteNullBytes(12);
	}
}

