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

namespace fb.Entity;

[ContainerType(16, 128)]
public class ReferenceObjectData
	: fb.Entity.GameObjectData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<Blueprint> Blueprint { get; set; } = new();
	
	[ContainerField(0x20), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public LinearTransform BlueprintTransform { get; set; } = new()
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
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public CtrRef<ObjectVariation> ObjectVariation { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public StreamRealm StreamRealm { get; set; } = fb.Entity.StreamRealm.StreamRealm_None;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public RadiosityTypeOverride RadiosityTypeOverride { get; set; } = fb.Entity.RadiosityTypeOverride.RadiosityTypeOverride_None;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool CastSunShadowEnable { get; set; } = true;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool CastReflectionEnable { get; set; } = false;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool Excluded { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Blueprint));
		p_Writer.WriteNullBytes(4);
		BlueprintTransform.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(ObjectVariation));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) StreamRealm);
		p_Writer.Write((int) RadiosityTypeOverride);
		p_Writer.Write(CastSunShadowEnable);
		p_Writer.Write(CastReflectionEnable);
		p_Writer.Write(Excluded);
		p_Writer.WriteNullBytes(13);
	}
}

