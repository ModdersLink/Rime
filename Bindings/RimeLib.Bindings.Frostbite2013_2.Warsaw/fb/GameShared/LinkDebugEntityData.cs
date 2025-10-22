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

[ContainerType(8, 40)]
public class LinkDebugEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x1c), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
	public uint ExpectedTargetDataCountInRuntime { get; set; } = 100000;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public uint ExpectedTargetInstanceCountInRuntime { get; set; } = 100000;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool ExpectAllTargetsToBeResolvableFromSource { get; set; } = false;
	
	[ContainerField(0x25), LayoutImmutable, Blittable, JsonProperty(Order = 37)]
	public bool ExpectAllTargetsToBeInSameSubLevel { get; set; } = false;
	
	[ContainerField(0x26), LayoutImmutable, Blittable, JsonProperty(Order = 38)]
	public bool ExpectAllTargetsToBeImmutable { get; set; } = false;
	
	[ContainerField(0x27), LayoutImmutable, Blittable, JsonProperty(Order = 39)]
	public bool ExpectAllTargetsToBeDynamic { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		p_Writer.Write(ExpectedTargetDataCountInRuntime);
		p_Writer.Write(ExpectedTargetInstanceCountInRuntime);
		p_Writer.Write(ExpectAllTargetsToBeResolvableFromSource);
		p_Writer.Write(ExpectAllTargetsToBeInSameSubLevel);
		p_Writer.Write(ExpectAllTargetsToBeImmutable);
		p_Writer.Write(ExpectAllTargetsToBeDynamic);
	}
}

