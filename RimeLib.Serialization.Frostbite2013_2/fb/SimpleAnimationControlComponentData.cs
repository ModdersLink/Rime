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
using fb.VeniceShared;
using fb.Entity;

namespace fb.Venice;

[ContainerType(16, 144)]
public class SimpleAnimationControlComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SimpleAnimationControlBinding Binding { get; set; } = new();
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public int AnimationEntitySpacePriority { get; set; } = 0;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public bool Run { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Binding.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(AnimationEntitySpacePriority);
		p_Writer.Write(Run);
		p_Writer.WriteNullBytes(7);
	}
}

