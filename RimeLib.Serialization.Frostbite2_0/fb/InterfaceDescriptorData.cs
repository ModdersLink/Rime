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
	[ContainerType(4, 28)]
	public partial class InterfaceDescriptorData :
		DynamicDataContainer
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private List<DynamicEvent> _InputEvents = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private List<DynamicEvent> _OutputEvents = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private List<DynamicLink> _InputLinks = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private List<DynamicLink> _OutputLinks = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_InputEvents = p_EbxWriter.GetArrayWriter(InputEvents.GetType(), InputEvents.Count);
			p_Writer.Write(s_InputEvents.ArrayIndex);
			foreach (var s_Entry in InputEvents)
			{
				s_Entry.Serialize(s_InputEvents.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_OutputEvents = p_EbxWriter.GetArrayWriter(OutputEvents.GetType(), OutputEvents.Count);
			p_Writer.Write(s_OutputEvents.ArrayIndex);
			foreach (var s_Entry in OutputEvents)
			{
				s_Entry.Serialize(s_OutputEvents.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_InputLinks = p_EbxWriter.GetArrayWriter(InputLinks.GetType(), InputLinks.Count);
			p_Writer.Write(s_InputLinks.ArrayIndex);
			foreach (var s_Entry in InputLinks)
			{
				s_Entry.Serialize(s_InputLinks.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_OutputLinks = p_EbxWriter.GetArrayWriter(OutputLinks.GetType(), OutputLinks.Count);
			p_Writer.Write(s_OutputLinks.ArrayIndex);
			foreach (var s_Entry in OutputLinks)
			{
				s_Entry.Serialize(s_OutputLinks.Writer, p_EbxWriter);
			}
		}
	}
}
