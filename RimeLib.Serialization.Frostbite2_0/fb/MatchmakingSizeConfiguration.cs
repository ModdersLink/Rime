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
	[ContainerType(4, 24)]
	public class MatchmakingSizeConfiguration :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public MatchmakingPlatform Platform { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public List<string> Settings { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint DesiredPlayerCount { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint MinPlayerCount { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public uint MaxPlayerCapacity { get; set; }
		
		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string MinFitThreshold { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Platform);
			(RimeWriter Writer, uint ArrayIndex) s_Settings = p_EbxWriter.GetArrayWriter(Settings.GetType(), Settings.Count);
			p_Writer.Write(s_Settings.ArrayIndex);
			foreach (var s_Entry in Settings)
			{
				s_Settings.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(DesiredPlayerCount);
			p_Writer.Write(MinPlayerCount);
			p_Writer.Write(MaxPlayerCapacity);
			p_Writer.Write(p_EbxWriter.WriteString(MinFitThreshold));
		}
	}
}
