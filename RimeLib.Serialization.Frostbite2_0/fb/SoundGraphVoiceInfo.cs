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
	[ContainerType(4, 8)]
	public class SoundGraphVoiceInfo :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public List<SoundGraphPluginInfo> Plugins { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public sbyte ProcessingStage { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_Plugins = p_EbxWriter.GetArrayWriter(Plugins.GetType(), Plugins.Count);
			p_Writer.Write(s_Plugins.ArrayIndex);
			foreach (var s_Entry in Plugins)
			{
				s_Entry.Serialize(s_Plugins.Writer, p_EbxWriter);
			}
			p_Writer.Write(ProcessingStage);
			p_Writer.WriteNullBytes(3);
		}
	}
}
