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

[ContainerType(16, 144)]
public class LogicReferenceObjectData
	: fb.Entity.ReferenceObjectData
{
	public LogicReferenceObjectData()
	{
		//ReferenceObjectData
		CastSunShadowEnable = false;
	}
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public SubRealm SubRealm { get; set; } = fb.Entity.SubRealm.SubRealm_All;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) SubRealm);
		p_Writer.WriteNullBytes(12);
	}
}

