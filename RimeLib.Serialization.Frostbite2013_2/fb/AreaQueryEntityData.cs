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

[ContainerType(16, 112)]
public class AreaQueryEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Server;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public LinearTransform GeometryTransform { get; set; } = new()
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
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float Radius { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool Enabled { get; set; } = true;
	
	[ContainerField(0x65), LayoutImmutable, Blittable, JsonProperty(Order = 101)]
	public bool UseCharacterEntity { get; set; } = false;
	
	[ContainerField(0x66), LayoutImmutable, Blittable, JsonProperty(Order = 102)]
	public bool UseRadiusWithGeometryTransform { get; set; } = false;
	
	[ContainerField(0x67), LayoutImmutable, Blittable, JsonProperty(Order = 103)]
	public bool QueryUsingExtraPlayerInDoublePlayerEvent { get; set; } = false;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public bool OnlyQueryIfOnDifferentTeams { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		GeometryTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Radius);
		p_Writer.Write(Enabled);
		p_Writer.Write(UseCharacterEntity);
		p_Writer.Write(UseRadiusWithGeometryTransform);
		p_Writer.Write(QueryUsingExtraPlayerInDoublePlayerEvent);
		p_Writer.Write(OnlyQueryIfOnDifferentTeams);
		p_Writer.WriteNullBytes(7);
	}
}

