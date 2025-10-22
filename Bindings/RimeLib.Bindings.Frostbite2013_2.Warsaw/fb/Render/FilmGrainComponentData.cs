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
public class FilmGrainComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 ColorScale { get; set; } = new()
	{
		z = 0.100f,
		y = 0.100f,
		x = 0.100f,
	};
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x94), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public Vec2 TextureScale { get; set; } = new()
	{
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<TextureAsset> Texture { get; set; } = new();
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0xa9), LayoutImmutable, Blittable, JsonProperty(Order = 169)]
	public bool LinearFilteringEnable { get; set; } = false;
	
	[ContainerField(0xaa), LayoutImmutable, Blittable, JsonProperty(Order = 170)]
	public bool RandomEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		ColorScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		TextureScale.Serialize(p_Writer, p_EbxWriter);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Texture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Enable);
		p_Writer.Write(LinearFilteringEnable);
		p_Writer.Write(RandomEnable);
		p_Writer.WriteNullBytes(5);
	}
}

