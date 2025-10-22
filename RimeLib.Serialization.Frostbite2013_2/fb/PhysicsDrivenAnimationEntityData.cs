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

[ContainerType(8, 736)]
public class PhysicsDrivenAnimationEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_ClientAndServer;
	
	[ContainerField(0x1c), JsonProperty(Order = 28)]
	public PhysicsDrivenAnimationEntityBinding Binding { get; set; } = new();
	
	[ContainerField(0x2d8), LayoutImmutable, Blittable, JsonProperty(Order = 728)]
	public int AnimationEntitySpacePriority { get; set; } = 0;
	
	[ContainerField(0x2dc), LayoutImmutable, Blittable, JsonProperty(Order = 732)]
	public bool UseSpineXFor1p { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write(UseSpineXFor1p);
		p_Writer.WriteNullBytes(3);
	}
}

