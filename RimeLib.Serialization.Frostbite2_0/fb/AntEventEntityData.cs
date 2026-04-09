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
	[ContainerType(16, 112)]
	public partial class AntEventEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private List<AntEventData> _OnEnterEvents = new();

		[ObservableProperty]
		[property: ContainerField(100), JsonProperty(Order = 100)]
		private List<AntEventData> _OnUpdateEvents = new();

		[ObservableProperty]
		[property: ContainerField(104), JsonProperty(Order = 104)]
		private List<AntEventData> _OnLeaveEvents = new();

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private bool _SendAsPlayerEvent;

		[ObservableProperty]
		[property: ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		private bool _AutoActivate;

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
