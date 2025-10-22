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

[ContainerType(16, 144)]
public class CameraParamsComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float ViewDistance { get; set; } = -1.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float NearPlane { get; set; } = -1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float SunShadowmapViewDistance { get; set; } = -1.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(ViewDistance);
		p_Writer.Write(NearPlane);
		p_Writer.Write(SunShadowmapViewDistance);
	}
}

