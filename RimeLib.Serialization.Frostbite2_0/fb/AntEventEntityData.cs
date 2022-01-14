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
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 112)]
	public class AntEventEntityData :
		GameEntityData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public List<AntEventData> OnEnterEvents { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public List<AntEventData> OnUpdateEvents { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public List<AntEventData> OnLeaveEvents { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool SendAsPlayerEvent { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool AutoActivate { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_OnEnterEvents = p_EbxWriter.GetArrayWriter(OnEnterEvents.GetType(), OnEnterEvents.Count);
			p_Writer.Write(s_OnEnterEvents.ArrayIndex);
			foreach (var s_Entry in OnEnterEvents)
			{
				s_Entry.Serialize(s_OnEnterEvents.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_OnUpdateEvents = p_EbxWriter.GetArrayWriter(OnUpdateEvents.GetType(), OnUpdateEvents.Count);
			p_Writer.Write(s_OnUpdateEvents.ArrayIndex);
			foreach (var s_Entry in OnUpdateEvents)
			{
				s_Entry.Serialize(s_OnUpdateEvents.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_OnLeaveEvents = p_EbxWriter.GetArrayWriter(OnLeaveEvents.GetType(), OnLeaveEvents.Count);
			p_Writer.Write(s_OnLeaveEvents.ArrayIndex);
			foreach (var s_Entry in OnLeaveEvents)
			{
				s_Entry.Serialize(s_OnLeaveEvents.Writer, p_EbxWriter);
			}
			p_Writer.Write(SendAsPlayerEvent);
			p_Writer.Write(AutoActivate);
			p_Writer.WriteNullBytes(2);
		}
	}
}
