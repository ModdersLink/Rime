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
public class SpotLightEntityData
	: fb.WorldRender.LocalLightEntityData
{
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public SpotLightShape Shape { get; set; } = SpotLightShape.SpotLightShape_Cone;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float ConeInnerAngle { get; set; } = 0.000f;
	
	[ContainerField(0xb8), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
	public float ConeOuterAngle { get; set; } = 40.000f;
	
	[ContainerField(0xbc), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
	public float FrustumFov { get; set; } = 40.000f;
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public float FrustumAspect { get; set; } = 1.000f;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public float OrthoWidth { get; set; } = 5.000f;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public float OrthoHeight { get; set; } = 5.000f;
	
	[ContainerField(0xcc), LayoutImmutable, Blittable, JsonProperty(Order = 204)]
	public float NearPlane { get; set; } = 0.000f;
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<TextureAsset> Texture { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public QualityScalableEnabled CastShadows { get; set; } = QualityScalableEnabled.QualityScalableEnabled_Disabled;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public float ShadowRadius { get; set; } = 0.000f;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float ShadowCullDistance { get; set; } = 0.000f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public QualityScalableEnabled FrustumAsCone { get; set; } = QualityScalableEnabled.QualityScalableEnabled_Disabled;
	
	[ContainerField(0xe8), LayoutImmutable, Blittable, JsonProperty(Order = 232)]
	public float FrustumAsConeIntensityScale { get; set; } = 1.000f;
	
	[ContainerField(0xec), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
	public QualityLevel CastShadowsMinLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool FrustumAsConeAngle { get; set; } = true;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool CastShadowsEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Shape);
		p_Writer.Write(ConeInnerAngle);
		p_Writer.Write(ConeOuterAngle);
		p_Writer.Write(FrustumFov);
		p_Writer.Write(FrustumAspect);
		p_Writer.Write(OrthoWidth);
		p_Writer.Write(OrthoHeight);
		p_Writer.Write(NearPlane);
		p_Writer.Write(p_EbxWriter.WriteImport(Texture));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) CastShadows);
		p_Writer.Write(ShadowRadius);
		p_Writer.Write(ShadowCullDistance);
		p_Writer.Write((int) FrustumAsCone);
		p_Writer.Write(FrustumAsConeIntensityScale);
		p_Writer.Write((int) CastShadowsMinLevel);
		p_Writer.Write(FrustumAsConeAngle);
		p_Writer.Write(CastShadowsEnable);
		p_Writer.WriteNullBytes(14);
	}
}

