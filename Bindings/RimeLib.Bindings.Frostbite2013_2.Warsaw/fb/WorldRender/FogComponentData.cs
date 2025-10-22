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

[ContainerType(16, 304)]
public class FogComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Vec4 Curve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x90), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public Vec3 FogColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 FogColorCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec4 TransparencyFadeCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 3.000f,
		x = -2.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec3 ForwardLightScatteringColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public float FogDistanceMultiplier { get; set; } = 1.000f;
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float Start { get; set; } = 0.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float End { get; set; } = 5000.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float FogColorStart { get; set; } = 0.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float FogColorEnd { get; set; } = 5000.000f;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float TransparencyFadeStart { get; set; } = 0.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public float TransparencyFadeEnd { get; set; } = 100.000f;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public float TransparencyFadeClamp { get; set; } = 0.000f;
	
	[ContainerField(0xf4), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
	public float ForwardLightScatteringPhaseG { get; set; } = 0.000f;
	
	[ContainerField(0xf8), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
	public float ForwardLightScatteringStrength { get; set; } = 0.000f;
	
	[ContainerField(0xfc), LayoutImmutable, Blittable, JsonProperty(Order = 252)]
	public float ForwardLightScatteringPresence { get; set; } = 0.000f;
	
	[ContainerField(0x100), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
	public float ForwardLightScatteringMaxBlurLength { get; set; } = 0.500f;
	
	[ContainerField(0x104), LayoutImmutable, Blittable, JsonProperty(Order = 260)]
	public float ForwardLightScatteringExtinction { get; set; } = 14.000f;
	
	[ContainerField(0x108), LayoutImmutable, Blittable, JsonProperty(Order = 264)]
	public float ForwardLightScatteringSmoothness { get; set; } = 4.000f;
	
	[ContainerField(0x10c), LayoutImmutable, Blittable, JsonProperty(Order = 268)]
	public float HeightFogFollowCamera { get; set; } = 0.000f;
	
	[ContainerField(0x110), LayoutImmutable, Blittable, JsonProperty(Order = 272)]
	public float HeightFogAltitude { get; set; } = 0.000f;
	
	[ContainerField(0x114), LayoutImmutable, Blittable, JsonProperty(Order = 276)]
	public float HeightFogDepth { get; set; } = 100.000f;
	
	[ContainerField(0x118), LayoutImmutable, Blittable, JsonProperty(Order = 280)]
	public float HeightFogVisibilityRange { get; set; } = 100.000f;
	
	[ContainerField(0x11c), LayoutImmutable, Blittable, JsonProperty(Order = 284)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x11d), LayoutImmutable, Blittable, JsonProperty(Order = 285)]
	public bool FogGradientEnable { get; set; } = true;
	
	[ContainerField(0x11e), LayoutImmutable, Blittable, JsonProperty(Order = 286)]
	public bool FogColorEnable { get; set; } = true;
	
	[ContainerField(0x11f), LayoutImmutable, Blittable, JsonProperty(Order = 287)]
	public bool ForwardLightScatteringEnabled { get; set; } = false;
	
	[ContainerField(0x120), LayoutImmutable, Blittable, JsonProperty(Order = 288)]
	public bool HeightFogEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Curve.Serialize(p_Writer, p_EbxWriter);
		FogColor.Serialize(p_Writer, p_EbxWriter);
		FogColorCurve.Serialize(p_Writer, p_EbxWriter);
		TransparencyFadeCurve.Serialize(p_Writer, p_EbxWriter);
		ForwardLightScatteringColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(FogDistanceMultiplier);
		p_Writer.Write(Start);
		p_Writer.Write(End);
		p_Writer.Write(FogColorStart);
		p_Writer.Write(FogColorEnd);
		p_Writer.Write(TransparencyFadeStart);
		p_Writer.Write(TransparencyFadeEnd);
		p_Writer.Write(TransparencyFadeClamp);
		p_Writer.Write(ForwardLightScatteringPhaseG);
		p_Writer.Write(ForwardLightScatteringStrength);
		p_Writer.Write(ForwardLightScatteringPresence);
		p_Writer.Write(ForwardLightScatteringMaxBlurLength);
		p_Writer.Write(ForwardLightScatteringExtinction);
		p_Writer.Write(ForwardLightScatteringSmoothness);
		p_Writer.Write(HeightFogFollowCamera);
		p_Writer.Write(HeightFogAltitude);
		p_Writer.Write(HeightFogDepth);
		p_Writer.Write(HeightFogVisibilityRange);
		p_Writer.Write(Enable);
		p_Writer.Write(FogGradientEnable);
		p_Writer.Write(FogColorEnable);
		p_Writer.Write(ForwardLightScatteringEnabled);
		p_Writer.Write(HeightFogEnable);
		p_Writer.WriteNullBytes(15);
	}
}

