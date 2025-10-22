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

[ContainerType(16, 208)]
public class CharacterLightingComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec3 TopLight { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 BottomLight { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float CameraUpRotation { get; set; } = 0.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public CharacterLightingMode CharacterLightingMode { get; set; } = fb.WorldRender.CharacterLightingMode.CharacterLightingMode_Add;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float BlendFactor { get; set; } = 1.000f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float TopLightDirX { get; set; } = 0.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float TopLightDirY { get; set; } = 90.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float StartFadeDistance { get; set; } = 0.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float EndFadeDistance { get; set; } = -1.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float StartFadeOutDistance { get; set; } = -1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float EndFadeOutDistance { get; set; } = -1.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool CharacterLightEnable { get; set; } = false;
	
	[ContainerField(0xc9), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
	public bool FirstPersonEnable { get; set; } = false;
	
	[ContainerField(0xca), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
	public bool LockToCameraDirection { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TopLight.Serialize(p_Writer, p_EbxWriter);
		BottomLight.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(CameraUpRotation);
		p_Writer.Write((int) CharacterLightingMode);
		p_Writer.Write(BlendFactor);
		p_Writer.Write(TopLightDirX);
		p_Writer.Write(TopLightDirY);
		p_Writer.Write(StartFadeDistance);
		p_Writer.Write(EndFadeDistance);
		p_Writer.Write(StartFadeOutDistance);
		p_Writer.Write(EndFadeOutDistance);
		p_Writer.Write(CharacterLightEnable);
		p_Writer.Write(FirstPersonEnable);
		p_Writer.Write(LockToCameraDirection);
		p_Writer.WriteNullBytes(5);
	}
}

