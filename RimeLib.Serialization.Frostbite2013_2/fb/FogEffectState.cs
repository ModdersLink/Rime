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

namespace fb.WorldRender;

[ContainerType(16, 160)]
public class FogEffectState
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public float Start { get; set; } = 0.000f;
	
	[ContainerField(0x14), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
	public float End { get; set; } = 5000.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec4 Curve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public Vec3 FogColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x40), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public Vec4 FogColorCurve { get; set; } = new()
	{
		w = 0.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x50), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public Vec3 ForwardLightScatteringColor { get; set; } = new()
	{
		z = 1.000f,
		y = 1.000f,
		x = 1.000f,
	};
	
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public float FogColorStart { get; set; } = 0.000f;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public float FogColorEnd { get; set; } = 5000.000f;
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float TransparencyFadeStart { get; set; } = 0.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float TransparencyFadeEnd { get; set; } = 100.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float TransparencyFadeClamp { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ForwardLightScatteringPhaseG { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ForwardLightScatteringStrength { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public float ForwardLightScatteringPresence { get; set; } = 0.000f;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float ForwardLightScatteringMaxBlurLength { get; set; } = 0.500f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float ForwardLightScatteringExtinction { get; set; } = 14.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float ForwardLightScatteringSmoothness { get; set; } = 4.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float HeightFogFollowCamera { get; set; } = 0.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float HeightFogAltitude { get; set; } = 1.000f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float HeightFogDepth { get; set; } = 100.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float HeightFogVisibilityRange { get; set; } = 100.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool Enable { get; set; } = true;
	
	[ContainerField(0x9d), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
	public bool ForwardLightScatteringEnabled { get; set; } = false;
	
	[ContainerField(0x9e), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
	public bool HeightFogEnable { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Start);
		p_Writer.Write(End);
		p_Writer.WriteNullBytes(8);
		Curve.Serialize(p_Writer, p_EbxWriter);
		FogColor.Serialize(p_Writer, p_EbxWriter);
		FogColorCurve.Serialize(p_Writer, p_EbxWriter);
		ForwardLightScatteringColor.Serialize(p_Writer, p_EbxWriter);
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
		p_Writer.Write(ForwardLightScatteringEnabled);
		p_Writer.Write(HeightFogEnable);
		p_Writer.WriteNullBytes(1);
	}
}

