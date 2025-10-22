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

[ContainerType(8, 88)]
public class DivisibleLoopPlayerNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public AudioGraphNodePort Start { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Stop { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Amplitude { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort FreezeSegment { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public AudioGraphNodePort Output { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public CtrRef<SoundWaveAsset> Wave { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public AudioGraphNodePort ExternalWave { get; set; } = new();
	
	[ContainerField(0x48), JsonProperty(Order = 72)]
	public List<DivisibleLoopPlayerPlugins> Plugins { get; set; } = new();
	
	[ContainerField(0x50), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
	public float CrossFadeLength { get; set; } = 0.500f;
	
	[ContainerField(0x54), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
	public bool StartAtRandomPosition { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		Start.Serialize(p_Writer, p_EbxWriter);
		Stop.Serialize(p_Writer, p_EbxWriter);
		Amplitude.Serialize(p_Writer, p_EbxWriter);
		FreezeSegment.Serialize(p_Writer, p_EbxWriter);
		Output.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Wave));
		p_Writer.WriteNullBytes(4);
		ExternalWave.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
		p_Writer.Write(s_Plugins.ArrayIndex);
		foreach (var s_Entry in Plugins)
		{
			s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CrossFadeLength);
		p_Writer.Write(StartAtRandomPosition);
		p_Writer.WriteNullBytes(3);
	}
}

