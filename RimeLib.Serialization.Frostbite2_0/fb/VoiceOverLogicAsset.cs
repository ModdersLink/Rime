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

namespace fb
{
	[ContainerType(4, 28)]
	public class VoiceOverLogicAsset :
		Asset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public RefArray<VoiceOverEvent> Events { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public RefArray<VoiceOverGroup> Groups { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public RefArray<VoiceOverLogicFlow> Flows { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public CtrRef<VoiceOverSystemAsset> System { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Events = p_EbxWriter.GetArrayWriter(Events.GetType(), Events.Count);
			p_Writer.Write(s_Events.ArrayIndex);
			foreach (var s_Entry in Events)
			{
				s_Events.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Groups = p_EbxWriter.GetArrayWriter(Groups.GetType(), Groups.Count);
			p_Writer.Write(s_Groups.ArrayIndex);
			foreach (var s_Entry in Groups)
			{
				s_Groups.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Flows = p_EbxWriter.GetArrayWriter(Flows.GetType(), Flows.Count);
			p_Writer.Write(s_Flows.ArrayIndex);
			foreach (var s_Entry in Flows)
			{
				s_Flows.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
			}
			p_Writer.Write(p_EbxWriter.WriteImport(System));
		}
	}
}
