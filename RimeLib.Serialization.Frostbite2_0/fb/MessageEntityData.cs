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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 36)]
	public partial class MessageEntityData :
		EntityData
	{
		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		private string _MessageSid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<MessageLineData> _AdditionalMessages = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private UIMessageEntityType _MessageType = new();

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _DisplayTime;

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private EntryInputActionEnum _EntryInputAction = new();

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private bool _Enabled;

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
