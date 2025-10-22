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
using fb.Physics;
using fb.Audio;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(16, 256)]
public class ChildComponentData
	: fb.GameShared.BoneComponentData
{
	[ContainerField(0x70), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public LinearTransform AlignTransform { get; set; } = new()
	{
		trans = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 0.000f,
		},
		up = new()
		{
			z = 0.000f,
			y = 1.000f,
			x = 0.000f,
		},
		forward = new()
		{
			z = 1.000f,
			y = 0.000f,
			x = 0.000f,
		},
		right = new()
		{
			z = 0.000f,
			y = 0.000f,
			x = 1.000f,
		},
	};
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public CtrRef<SoundAsset> SoundEffect { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<MovingBodyData> MovingBody { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public VehicleHealthZoneData HealthZone { get; set; } = new();
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public float SoundEffectStartRpm { get; set; } = 0.100f;
	
	[ContainerField(0xe4), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
	public float SoundEffectStopRpm { get; set; } = 0.100f;
	
	[ContainerField(0xe8), JsonProperty(Order = 232)]
	public CtrRef<AlignmentData> AlignmentSettings { get; set; } = new();
	
	[ContainerField(0xf0), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
	public bool WorldSpacePositionLock { get; set; } = false;
	
	[ContainerField(0xf1), LayoutImmutable, Blittable, JsonProperty(Order = 241)]
	public bool EnableAlignToCamera { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		AlignTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SoundEffect));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(MovingBody));
		p_Writer.WriteNullBytes(4);
		HealthZone.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(SoundEffectStartRpm);
		p_Writer.Write(SoundEffectStopRpm);
		p_Writer.Write(p_EbxWriter.WriteImport(AlignmentSettings));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(WorldSpacePositionLock);
		p_Writer.Write(EnableAlignToCamera);
		p_Writer.WriteNullBytes(14);
	}
}

