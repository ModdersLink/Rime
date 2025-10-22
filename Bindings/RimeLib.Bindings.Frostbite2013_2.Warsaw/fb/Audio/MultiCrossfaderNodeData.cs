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

[ContainerType(8, 56)]
public class MultiCrossfaderNodeData
	: fb.Audio.AudioGraphNodeData
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public RefArray<MultiCrossfaderGroup> CrossfaderGroups { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public AudioGraphNodePort Start { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public AudioGraphNodePort Stop { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AudioGraphNodePort Control { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool LockControlValue { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_CrossfaderGroups = p_EbxWriter.GetArrayWriter(CrossfaderGroups.GetType(), CrossfaderGroups.Count);
		p_Writer.Write(s_CrossfaderGroups.ArrayIndex);
		foreach (var s_Entry in CrossfaderGroups)
		{
			s_CrossfaderGroups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		Start.Serialize(p_Writer, p_EbxWriter);
		Stop.Serialize(p_Writer, p_EbxWriter);
		Control.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(LockControlValue);
		p_Writer.WriteNullBytes(7);
	}
}

