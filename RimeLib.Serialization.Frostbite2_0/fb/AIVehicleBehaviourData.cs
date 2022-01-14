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
	[ContainerType(4, 28)]
	public class AIVehicleBehaviourData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> Controls { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<string> Behaviours { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<string> Goals { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<IntentData> Intents { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			(RimeWriter Writer, uint ArrayIndex) s_Controls = p_EbxWriter.GetArrayWriter(Controls.GetType(), Controls.Count);
			p_Writer.Write(s_Controls.ArrayIndex);
			foreach (var s_Entry in Controls)
			{
				s_Controls.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Behaviours = p_EbxWriter.GetArrayWriter(Behaviours.GetType(), Behaviours.Count);
			p_Writer.Write(s_Behaviours.ArrayIndex);
			foreach (var s_Entry in Behaviours)
			{
				s_Behaviours.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Goals = p_EbxWriter.GetArrayWriter(Goals.GetType(), Goals.Count);
			p_Writer.Write(s_Goals.ArrayIndex);
			foreach (var s_Entry in Goals)
			{
				s_Goals.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Intents = p_EbxWriter.GetArrayWriter(Intents.GetType(), Intents.Count);
			p_Writer.Write(s_Intents.ArrayIndex);
			foreach (var s_Entry in Intents)
			{
				s_Entry.Serialize(s_Intents.Writer, p_EbxWriter);
			}
		}
	}
}
