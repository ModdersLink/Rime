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

using fb.Ant;
using fb.Core;
using fb.Entity;

namespace fb.GameShared;

[ContainerType(8, 96)]
public class FbProxyControllerEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public FbProxyControllerEntityBinding CannedAnimBinding { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public int AnimationEntitySpacePriority { get; set; } = 3;
	
	[ContainerField(0x44), JsonProperty(Order = 68)]
	public AntRef PointerGameState { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public bool AlwaysClearEntitySpaceWhenInScenario { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		CannedAnimBinding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		PointerGameState.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AlwaysClearEntitySpaceWhenInScenario);
		p_Writer.WriteNullBytes(7);
	}
}

