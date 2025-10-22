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

[ContainerType(8, 32)]
public class PropertyTrackData
	: fb.Core.DataContainer
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int Id { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<int> Times { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(Id);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Times = p_EbxWriter.GetArrayWriter(Times.GetType(), Times.Count);
		p_Writer.Write(s_Times.ArrayIndex);
		foreach (var s_Entry in Times)
		{
			s_Times.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

