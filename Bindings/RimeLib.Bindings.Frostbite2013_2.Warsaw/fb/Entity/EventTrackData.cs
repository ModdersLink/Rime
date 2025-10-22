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

[ContainerType(8, 64)]
public class EventTrackData
	: fb.Entity.SchematicPinTrackData
{
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<EventKeyframe> Keyframes { get; set; } = new();
	
	[ContainerField(0x38), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
	public bool FireEventsUponSkip { get; set; } = true;
	
	[ContainerField(0x39), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
	public bool UpdatePropertiesAtEvents { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Keyframes = p_EbxWriter.GetArrayWriter(Keyframes.GetType(), Keyframes.Count);
		p_Writer.Write(s_Keyframes.ArrayIndex);
		foreach (var s_Entry in Keyframes)
		{
			s_Entry.Serialize(s_Keyframes.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(FireEventsUponSkip);
		p_Writer.Write(UpdatePropertiesAtEvents);
		p_Writer.WriteNullBytes(6);
	}
}

