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
using fb.Render;
using fb.Entity;

namespace fb.WorldRender;

[ContainerType(16, 256)]
public class DamageEffectComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec4 TopDamage { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec4 LeftDamage { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 BottomDamage { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec4 RightDamage { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float FrameWidth { get; set; } = 0.500f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float OuterFrameOpacity { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float InnerFrameOpacity { get; set; } = 1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float FallofTime { get; set; } = 0.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float MinDamagePercentageThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float MaxOpacityDamagePercentage { get; set; } = 0.000f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float StartCriticalEffectHealthThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float EndCriticalEffectHealthThreshold { get; set; } = 0.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool DebugDamage { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		TopDamage.Serialize(p_Writer, p_EbxWriter);
		LeftDamage.Serialize(p_Writer, p_EbxWriter);
		BottomDamage.Serialize(p_Writer, p_EbxWriter);
		RightDamage.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(Shader));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FrameWidth);
		p_Writer.Write(OuterFrameOpacity);
		p_Writer.Write(InnerFrameOpacity);
		p_Writer.Write(FallofTime);
		p_Writer.Write(MinDamagePercentageThreshold);
		p_Writer.Write(MaxOpacityDamagePercentage);
		p_Writer.Write(StartCriticalEffectHealthThreshold);
		p_Writer.Write(EndCriticalEffectHealthThreshold);
		p_Writer.Write(DebugDamage);
		p_Writer.WriteNullBytes(15);
	}
}

