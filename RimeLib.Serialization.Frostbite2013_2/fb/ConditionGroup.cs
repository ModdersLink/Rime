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

namespace fb.Audio;

[ContainerType(8, 48)]
public class ConditionGroup
	: fb.Audio.AudioGraphNodePortGroup
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort X { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Y { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort True { get; set; } = new();
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public ConditionType Condition { get; set; } = ConditionType.ConditionType_GreaterOrEqual;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		X.Serialize(p_Writer, p_EbxWriter);
		Y.Serialize(p_Writer, p_EbxWriter);
		True.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Condition);
		p_Writer.WriteNullBytes(4);
	}
}

