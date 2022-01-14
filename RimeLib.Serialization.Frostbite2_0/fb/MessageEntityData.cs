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
	[ContainerType(4, 36)]
	public class MessageEntityData :
		EntityData
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string MessageSid { get; set; } = string.Empty;

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<MessageLineData> AdditionalMessages { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public UIMessageEntityType MessageType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float DisplayTime { get; set; }

		[ContainerField(28), JsonProperty(Order = 28)]
		public EntryInputActionEnum EntryInputAction { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(MessageSid));
			(RimeWriter Writer, uint ArrayIndex) s_AdditionalMessages = p_EbxWriter.GetArrayWriter(AdditionalMessages.GetType(), AdditionalMessages.Count);
			p_Writer.Write(s_AdditionalMessages.ArrayIndex);
			foreach (var s_Entry in AdditionalMessages)
			{
				s_Entry.Serialize(s_AdditionalMessages.Writer, p_EbxWriter);
			}
			p_Writer.Write((int) MessageType);
			p_Writer.Write(DisplayTime);
			p_Writer.Write((int) EntryInputAction);
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(3);
		}
	}
}
