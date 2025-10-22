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

namespace fb.Entity;

[ContainerType(8, 48)]
public class Vec2PropertyTrackData
	: fb.Entity.SimplePropertyTrackData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<Vec2> Values { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Values = p_EbxWriter.GetArrayWriter(Values.GetType(), Values.Count);
		p_Writer.Write(s_Values.ArrayIndex);
		foreach (var s_Entry in Values)
		{
			s_Entry.Serialize(s_Values.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
	}
}

