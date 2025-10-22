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

[ContainerType(16, 112)]
public class WaterDepthEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x64), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
	public bool DefaultEnabled { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(DefaultEnabled);
		p_Writer.WriteNullBytes(11);
	}
}

