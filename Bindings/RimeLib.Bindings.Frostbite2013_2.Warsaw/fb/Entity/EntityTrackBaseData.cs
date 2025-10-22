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

[ContainerType(8, 56)]
public class EntityTrackBaseData
	: fb.Entity.TimelineTrackData
{
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public RefArray<TimelineTrackData> Children { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public int Identifier { get; set; } = 0;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public bool InheritedToChildConversationLines { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Children = p_EbxWriter.GetArrayWriter(Children.GetType(), Children.Count);
		p_Writer.Write(s_Children.ArrayIndex);
		foreach (var s_Entry in Children)
		{
			s_Children.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(Identifier);
		p_Writer.Write(InheritedToChildConversationLines);
		p_Writer.WriteNullBytes(3);
	}
}

