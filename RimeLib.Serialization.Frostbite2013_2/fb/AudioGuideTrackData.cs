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

namespace fb.Audio;

[ContainerType(8, 72)]
public class AudioGuideTrackData
	: fb.Entity.GuideTrackData
{
	public AudioGuideTrackData()
	{
		//GuideTrackData
		GuideTrackPriority = 1;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public CtrRef<SoundAsset> Sound { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public string SoundPositionName { get; set; } = @"SoundPosition";
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<AudioGuideKeyframe> Keyframes { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(Sound));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(SoundPositionName));
		(RimeWriter Writer, uint ArrayIndex) s_Keyframes = p_EbxWriter.GetArrayWriter(Keyframes.GetType(), Keyframes.Count);
		p_Writer.Write(s_Keyframes.ArrayIndex);
		foreach (var s_Entry in Keyframes)
		{
			s_Keyframes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

