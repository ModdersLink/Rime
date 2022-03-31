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
	[ContainerType(4, 16)]
	public class SoundGraphPluginConnection :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public SoundGraphPluginConnectionType ConnectionType { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<SoundGraphPluginConnectionParam> Parameters { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public CtrRef<SoundBusData> Bus { get; set; } = new();
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public sbyte VoiceIndex { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) ConnectionType);
			(RimeWriter Writer, uint ArrayIndex) s_Parameters = p_EbxWriter.GetArrayWriter(Parameters.GetType(), Parameters.Count);
			p_Writer.Write(s_Parameters.ArrayIndex);
			foreach (var s_Entry in Parameters)
			{
				s_Entry.Serialize(s_Parameters.Writer, p_EbxWriter);
			}
			p_Writer.Write(p_EbxWriter.WriteImport(Bus));
			p_Writer.Write(VoiceIndex);
			p_Writer.WriteNullBytes(3);
		}
	}
}
