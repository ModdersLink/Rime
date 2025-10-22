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
public class MixerInputEntry
	: fb.Audio.AudioGraphNodePortGroup
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Out { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<AudioGraphParameter> Source { get; set; } = new();
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public MixerValueAccumulateMode AccumulateMode { get; set; } = MixerValueAccumulateMode.MixerValueAccumulateMode_None;
	
	[ContainerField(0x24), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
	public bool KeepValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Out.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Source));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write((int) AccumulateMode);
		p_Writer.Write(KeepValue);
		p_Writer.WriteNullBytes(3);
	}
}

