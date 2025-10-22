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

[ContainerType(8, 40)]
public class CompareIntEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Server;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public int A { get; set; } = 0;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public int B { get; set; } = 0;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool TriggerOnPropertyChange { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool TriggerOnStart { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(A);
		p_Writer.Write(B);
		p_Writer.Write(TriggerOnPropertyChange);
		p_Writer.Write(TriggerOnStart);
		p_Writer.WriteNullBytes(2);
	}
}

