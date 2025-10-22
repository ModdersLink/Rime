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

[ContainerType(16, 224)]
public class DofComponentData
	: fb.Entity.VisualEnvironmentComponentData
{
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float FocusDistance { get; set; } = 5.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float BlurFactor { get; set; } = 1.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float BlurAdd { get; set; } = 0.000f;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public BlurFilter SimpleDofBlurFilter { get; set; } = BlurFilter.BfGaussian9Pixels;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float SimpleDofMaxBlur { get; set; } = 3.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float SimpleDofNearStart { get; set; } = 5.000f;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public float SimpleDofNearEnd { get; set; } = 7.000f;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public float SimpleDofFarStart { get; set; } = 5.000f;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public float SimpleDofFarEnd { get; set; } = 7.000f;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public float HipToIronsightsFade { get; set; } = 1.000f;
	
	[ContainerField(0xac), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
	public float IronsightsDofStartFade { get; set; } = 0.500f;
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float IronsightsFocalDistance { get; set; } = 1.500f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float IronsightsDofCircleDistance { get; set; } = 0.350f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float SpriteDofNearStart { get; set; } = 5.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float SpriteDofNearEnd { get; set; } = 7.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float SpriteDofFarStart { get; set; } = 5.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float SpriteDofFarEnd { get; set; } = 7.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float SpriteDofMaxBlur { get; set; } = 6.000f;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<TextureAsset> SpriteDofBokehTexture { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public bool Enable { get; set; } = false;
	
	[ContainerField(0xd9), LayoutImmutable, Blittable, JsonProperty(Order = 217)]
	public bool DebugDrawFocusPlane { get; set; } = false;
	
	[ContainerField(0xda), LayoutImmutable, Blittable, JsonProperty(Order = 218)]
	public bool IronsightsDofActive { get; set; } = false;
	
	[ContainerField(0xdb), LayoutImmutable, Blittable, JsonProperty(Order = 219)]
	public bool IronsightsDofCircleBlur { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(FocusDistance);
		p_Writer.Write(BlurFactor);
		p_Writer.Write(BlurAdd);
		p_Writer.Write((int) SimpleDofBlurFilter);
		p_Writer.Write(SimpleDofMaxBlur);
		p_Writer.Write(SimpleDofNearStart);
		p_Writer.Write(SimpleDofNearEnd);
		p_Writer.Write(SimpleDofFarStart);
		p_Writer.Write(SimpleDofFarEnd);
		p_Writer.Write(HipToIronsightsFade);
		p_Writer.Write(IronsightsDofStartFade);
		p_Writer.Write(IronsightsFocalDistance);
		p_Writer.Write(IronsightsDofCircleDistance);
		p_Writer.Write(SpriteDofNearStart);
		p_Writer.Write(SpriteDofNearEnd);
		p_Writer.Write(SpriteDofFarStart);
		p_Writer.Write(SpriteDofFarEnd);
		p_Writer.Write(SpriteDofMaxBlur);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpriteDofBokehTexture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Enable);
		p_Writer.Write(DebugDrawFocusPlane);
		p_Writer.Write(IronsightsDofActive);
		p_Writer.Write(IronsightsDofCircleBlur);
		p_Writer.WriteNullBytes(4);
	}
}

