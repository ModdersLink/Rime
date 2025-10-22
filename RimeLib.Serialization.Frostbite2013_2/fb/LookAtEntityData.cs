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

namespace fb.VeniceShared;

[ContainerType(16, 112)]
public class LookAtEntityData
	: fb.Entity.SpatialEntityData
{
	[ContainerField(0x60), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
	public bool RunOnce { get; set; } = true;
	
	[ContainerField(0x61), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
	public bool UseStaticDirection { get; set; } = false;
	
	[ContainerField(0x62), LayoutImmutable, Blittable, JsonProperty(Order = 98)]
	public bool Enabled { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(RunOnce);
		p_Writer.Write(UseStaticDirection);
		p_Writer.Write(Enabled);
		p_Writer.WriteNullBytes(13);
	}
}

