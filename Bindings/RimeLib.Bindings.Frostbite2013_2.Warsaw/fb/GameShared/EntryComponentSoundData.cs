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

using fb.Audio;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 32)]
public class EntryComponentSoundData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), JsonProperty(Order = 16)]
	public List<StanceSwitchSoundData> StanceSounds { get; set; } = new();
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public CtrRef<SoundAsset> StanceSwitchSound { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_StanceSounds = p_EbxWriter.GetArrayWriter(StanceSounds.GetType(), StanceSounds.Count);
		p_Writer.Write(s_StanceSounds.ArrayIndex);
		foreach (var s_Entry in StanceSounds)
		{
			s_Entry.Serialize(s_StanceSounds.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StanceSwitchSound));
		p_Writer.WriteNullBytes(4);
	}
}

