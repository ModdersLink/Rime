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

namespace fb.Venice;

[ContainerType(16, 160)]
public class SoldierDecalComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<DecalTemplateData> BulletHitDecal { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<DecalTemplateData> SplashDecal { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float SplashRayLength { get; set; } = 2.000f;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public CtrRef<DecalTemplateData> PoolDecal { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float PoolRayYOffset { get; set; } = 0.100f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float PoolRayLength { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(BulletHitDecal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SplashDecal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SplashRayLength);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PoolDecal));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PoolRayYOffset);
		p_Writer.Write(PoolRayLength);
		p_Writer.WriteNullBytes(8);
	}
}

