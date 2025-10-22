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

namespace fb.Venice;

[ContainerType(16, 128)]
public class MobileSpawnComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float ParachuteSpawnDistance { get; set; } = 0.000f;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public float ParachuteSpawnRadiusMin { get; set; } = 0.000f;
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public float ParachuteSpawnRadiusMax { get; set; } = 0.000f;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public bool EnterMobileSpawnPoint { get; set; } = false;
	
	[ContainerField(0x7d), LayoutImmutable, Blittable, JsonProperty(Order = 125)]
	public bool ParachuteInstantDeployAtSpawn { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ParachuteSpawnDistance);
		p_Writer.Write(ParachuteSpawnRadiusMin);
		p_Writer.Write(ParachuteSpawnRadiusMax);
		p_Writer.Write(EnterMobileSpawnPoint);
		p_Writer.Write(ParachuteInstantDeployAtSpawn);
		p_Writer.WriteNullBytes(2);
	}
}

