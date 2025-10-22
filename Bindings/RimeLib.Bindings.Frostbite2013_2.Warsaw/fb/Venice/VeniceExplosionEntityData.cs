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
using fb.GameShared;
using fb.Entity;
using fb.WorldRender;

namespace fb.Venice;

[ContainerType(16, 224)]
public class VeniceExplosionEntityData
	: fb.GameShared.ExplosionEntityData
{
	[ContainerField(0xd0), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
	public float UnspottableTime { get; set; } = 1.000f;
	
	[ContainerField(0xd4), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
	public bool IsCausingSuppression { get; set; } = false;
	
	[ContainerField(0xd5), LayoutImmutable, Blittable, JsonProperty(Order = 213)]
	public bool UnspotsOnExplode { get; set; } = false;
	
	[ContainerField(0xd6), LayoutImmutable, Blittable, JsonProperty(Order = 214)]
	public bool SpotsOnExplode { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(UnspottableTime);
		p_Writer.Write(IsCausingSuppression);
		p_Writer.Write(UnspotsOnExplode);
		p_Writer.Write(SpotsOnExplode);
		p_Writer.WriteNullBytes(9);
	}
}

