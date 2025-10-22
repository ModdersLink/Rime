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

[ContainerType(16, 192)]
public class DynamicEnvmapComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 KeyColorEnvmap { get; set; } = new()
	{
		z = 0.914f,
		y = 0.971f,
		x = 1.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 SkyColorEnvmap { get; set; } = new()
	{
		z = 0.400f,
		y = 0.341f,
		x = 0.318f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec3 GroundColorEnvmap { get; set; } = new()
	{
		z = 0.050f,
		y = 0.050f,
		x = 0.050f,
	};
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0xb5), LayoutImmutable, Blittable, JsonProperty(Order = 181)]
	public bool TerrainReflectionsEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		KeyColorEnvmap.Serialize(p_Writer, p_EbxWriter);
		SkyColorEnvmap.Serialize(p_Writer, p_EbxWriter);
		GroundColorEnvmap.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(Enable);
		p_Writer.Write(TerrainReflectionsEnable);
		p_Writer.WriteNullBytes(10);
	}
}

