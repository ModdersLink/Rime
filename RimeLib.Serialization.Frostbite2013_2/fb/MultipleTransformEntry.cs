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

[ContainerType(8, 40)]
public class MultipleTransformEntry
	: fb.Audio.AudioGraphNodePortGroup
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Y { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Z { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public SimpleTransformOperation Operation { get; set; } = SimpleTransformOperation.SimpleTransformOperation_Multiply;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public AngleUnit AngleUnit { get; set; } = fb.Audio.AngleUnit.AngleUnit_Radians;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Y.Serialize(p_Writer, p_EbxWriter);
		Z.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) Operation);
		p_Writer.Write((int) AngleUnit);
	}
}

