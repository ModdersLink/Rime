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
	[ContainerType(4, 16)]
	public class BFServerConfigurationSchedule :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<string> Licenses { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<string> Levels { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public BFServerConfigurationData Data { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Licenses = p_EbxWriter.GetArrayWriter(Licenses.GetType(), Licenses.Count);
			p_Writer.Write(s_Licenses.ArrayIndex);
			foreach (var s_Entry in Licenses)
			{
				s_Licenses.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			(RimeWriter Writer, uint ArrayIndex) s_Levels = p_EbxWriter.GetArrayWriter(Levels.GetType(), Levels.Count);
			p_Writer.Write(s_Levels.ArrayIndex);
			foreach (var s_Entry in Levels)
			{
				s_Levels.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			Data.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
