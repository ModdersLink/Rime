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

using fb.Render;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 96)]
public class CameraData
	: fb.Entity.GameObjectData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public float PreFadeTime { get; set; } = 0.000f;
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public Vec3 OcclusionRayOffset { get; set; } = new()
	{
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public float FadeTime { get; set; } = 0.000f;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public float FadeWaitTime { get; set; } = 0.000f;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<ViewFxData> ViewFx { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public float NearPlane { get; set; } = -1.000f;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float ShadowViewDistanceScale { get; set; } = 1.000f;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public float SoundOcclusion { get; set; } = 0.000f;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public float SoundListenerRadius { get; set; } = 0.500f;
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float ShakeFactor { get; set; } = 1.000f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool StayFadedWhileStreaming { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(PreFadeTime);
		p_Writer.WriteNullBytes(4);
		OcclusionRayOffset.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(FadeTime);
		p_Writer.Write(FadeWaitTime);
		p_Writer.Write(p_EbxWriter.WriteImport(ViewFx));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(NearPlane);
		p_Writer.Write(ShadowViewDistanceScale);
		p_Writer.Write(SoundOcclusion);
		p_Writer.Write(SoundListenerRadius);
		p_Writer.Write(ShakeFactor);
		p_Writer.Write(StayFadedWhileStreaming);
		p_Writer.WriteNullBytes(11);
	}
}

