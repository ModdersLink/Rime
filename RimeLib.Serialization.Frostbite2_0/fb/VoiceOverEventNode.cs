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
	public partial class VoiceOverEventNode :
		VoiceOverStructureNode
	{
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private CtrRef<VoiceOverIntervalNode> _Interval = new();

		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private RefArray<VoiceOverStructureNode> _Relationship = new();

		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private RefArray<VoiceOverValueRedirect> _Redirects = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private CtrRef<VoiceOverEvent> _Event = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteImport(Interval));
			(RimeWriter Writer, uint ArrayIndex) s_Relationship = p_EbxWriter.GetArrayWriter(Relationship.GetType(), Relationship.Count);
			p_Writer.Write(s_Relationship.ArrayIndex);
			foreach (var s_Entry in Relationship)
			{
				s_Relationship.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Redirects = p_EbxWriter.GetArrayWriter(Redirects.GetType(), Redirects.Count);
			p_Writer.Write(s_Redirects.ArrayIndex);
			foreach (var s_Entry in Redirects)
			{
				s_Redirects.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Event));
		}
	}
}
