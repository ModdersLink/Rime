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
using fb.Ant;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 72)]
public class CharacterAnimationSpaceEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public Realm Realm { get; set; } = fb.Core.Realm.Realm_Client;
	
	[ContainerField(0x1c), JsonProperty(Order = 28)]
	public AntRef SpacePositionGS { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AntRef SpaceRotationGS { get; set; } = new();
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public float WarpAnimationBlendTime { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Realm);
		SpacePositionGS.Serialize(p_Writer, p_EbxWriter);
		SpaceRotationGS.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(WarpAnimationBlendTime);
	}
}

