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

namespace fb.Render;

[ContainerType(8, 80)]
public class MeshSettings
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public string OverrideShadersShaderName { get; set; } = string.Empty;
	
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string OverrideShadersMeshName { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int ForceLod { get; set; } = -1;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public float GlobalLodScale { get; set; } = 1.000f;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public float ShadowDistanceScale { get; set; } = 1.000f;
	
	[ContainerField(0x2c), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
	public float TessellationMaxFactor { get; set; } = 32.000f;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float TessellationForceTessellationFactor { get; set; } = -1.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float TessellationMaxDistance { get; set; } = -1.000f;
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public float TessellationMaxDistanceFade { get; set; } = 0.100f;
	
	[ContainerField(0x3c), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
	public QualityLevel CastSunShadowQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public QualityLevel CastDynamicEnvmapQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public QualityLevel CastPlanarReflectionQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public QualityLevel MeshQualityLevel { get; set; } = QualityLevel.QualityLevel_Low;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public bool LoadingEnabled { get; set; } = true;
	
	[ContainerField(0x4d), LayoutImmutable, Blittable, JsonProperty(Order = 77)]
	public bool TessellationEnable { get; set; } = true;
	
	[ContainerField(0x4e), LayoutImmutable, Blittable, JsonProperty(Order = 78)]
	public bool TessellationBackFaceCullingEnable { get; set; } = true;
	
	[ContainerField(0x4f), LayoutImmutable, Blittable, JsonProperty(Order = 79)]
	public bool TessellationScreenSpaceAdativeEnable { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(OverrideShadersShaderName));
		p_Writer.Write(p_EbxWriter.WriteString(OverrideShadersMeshName));
		p_Writer.Write(ForceLod);
		p_Writer.Write(GlobalLodScale);
		p_Writer.Write(ShadowDistanceScale);
		p_Writer.Write(TessellationMaxFactor);
		p_Writer.Write(TessellationForceTessellationFactor);
		p_Writer.Write(TessellationMaxDistance);
		p_Writer.Write(TessellationMaxDistanceFade);
		p_Writer.Write((int) CastSunShadowQualityLevel);
		p_Writer.Write((int) CastDynamicEnvmapQualityLevel);
		p_Writer.Write((int) CastPlanarReflectionQualityLevel);
		p_Writer.Write((int) MeshQualityLevel);
		p_Writer.Write(LoadingEnabled);
		p_Writer.Write(TessellationEnable);
		p_Writer.Write(TessellationBackFaceCullingEnable);
		p_Writer.Write(TessellationScreenSpaceAdativeEnable);
	}
}

