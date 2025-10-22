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

using fb.Entity;
using fb.Core;

namespace fb.GameShared;

[ContainerType(8, 56)]
public class MovieTrackData
	: fb.Entity.GuideTrackData
{
	public MovieTrackData()
	{
		//GuideTrackData
		GuideTrackPriority = 2;
	}
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public RefArray<MovieTrackKeyframe> Keyframes { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Keyframes = p_EbxWriter.GetArrayWriter(Keyframes.GetType(), Keyframes.Count);
		p_Writer.Write(s_Keyframes.ArrayIndex);
		foreach (var s_Entry in Keyframes)
		{
			s_Keyframes.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

