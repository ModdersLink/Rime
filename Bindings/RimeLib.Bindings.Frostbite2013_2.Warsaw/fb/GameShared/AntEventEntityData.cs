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

namespace fb.GameShared;

[ContainerType(8, 56)]
public class AntEventEntityData
	: fb.Entity.EntityData
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<AntEventData> OnEnterEvents { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public List<AntEventData> OnUpdateEvents { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<AntEventData> OnLeaveEvents { get; set; } = new();
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public bool RequireLink { get; set; } = true;
	
	[ContainerField(0x31), LayoutImmutable, Blittable, JsonProperty(Order = 49)]
	public bool SendAsPlayerEvent { get; set; } = false;
	
	[ContainerField(0x32), LayoutImmutable, Blittable, JsonProperty(Order = 50)]
	public bool AutoActivate { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_OnEnterEvents = p_EbxWriter.GetArrayWriter(OnEnterEvents.GetType(), OnEnterEvents.Count);
		p_Writer.Write(s_OnEnterEvents.ArrayIndex);
		foreach (var s_Entry in OnEnterEvents)
		{
			s_Entry.Serialize(s_OnEnterEvents.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OnUpdateEvents = p_EbxWriter.GetArrayWriter(OnUpdateEvents.GetType(), OnUpdateEvents.Count);
		p_Writer.Write(s_OnUpdateEvents.ArrayIndex);
		foreach (var s_Entry in OnUpdateEvents)
		{
			s_Entry.Serialize(s_OnUpdateEvents.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_OnLeaveEvents = p_EbxWriter.GetArrayWriter(OnLeaveEvents.GetType(), OnLeaveEvents.Count);
		p_Writer.Write(s_OnLeaveEvents.ArrayIndex);
		foreach (var s_Entry in OnLeaveEvents)
		{
			s_Entry.Serialize(s_OnLeaveEvents.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(RequireLink);
		p_Writer.Write(SendAsPlayerEvent);
		p_Writer.Write(AutoActivate);
		p_Writer.WriteNullBytes(5);
	}
}

