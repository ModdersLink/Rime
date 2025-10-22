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

namespace fb.GameShared;

[ContainerType(16, 240)]
public class VisualEnvironmentEffectEntityData
	: fb.Entity.EffectEntityData
{
	[ContainerField(0xa0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public Vec4 LifetimeCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xb0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public Vec4 CullAngleCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xc0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public Vec4 CullDistanceCurve { get; set; } = new()
	{
		w = 1.000f,
		z = 0.000f,
		y = 0.000f,
		x = 0.000f,
	};
	
	[ContainerField(0xd0), JsonProperty(Order = 208)]
	public CtrRef<VisualEnvironmentBlueprint> VisualEnvironment { get; set; } = new();
	
	[ContainerField(0xd8), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
	public float Lifetime { get; set; } = -1.000f;
	
	[ContainerField(0xdc), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
	public bool SampleOnStartOnly { get; set; } = false;
	
	[ContainerField(0xdd), LayoutImmutable, Blittable, JsonProperty(Order = 221)]
	public bool IgnoreDead { get; set; } = false;
	
	[ContainerField(0xde), LayoutImmutable, Blittable, JsonProperty(Order = 222)]
	public bool IgnoreInShieldedEntry { get; set; } = false;
	
	[ContainerField(0xdf), LayoutImmutable, Blittable, JsonProperty(Order = 223)]
	public bool HideOccluded { get; set; } = false;
	
	[ContainerField(0xe0), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
	public bool RaycastWithDetailMesh { get; set; } = false;
	
	[ContainerField(0xe1), LayoutImmutable, Blittable, JsonProperty(Order = 225)]
	public bool FadeHudDuringEffect { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		LifetimeCurve.Serialize(p_Writer, p_EbxWriter);
		CullAngleCurve.Serialize(p_Writer, p_EbxWriter);
		CullDistanceCurve.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(VisualEnvironment));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Lifetime);
		p_Writer.Write(SampleOnStartOnly);
		p_Writer.Write(IgnoreDead);
		p_Writer.Write(IgnoreInShieldedEntry);
		p_Writer.Write(HideOccluded);
		p_Writer.Write(RaycastWithDetailMesh);
		p_Writer.Write(FadeHudDuringEffect);
		p_Writer.WriteNullBytes(14);
	}
}

