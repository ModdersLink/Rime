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
	[ContainerType(4, 20)]
	public class AwardStatus :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Code { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public uint CurrentValue { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public uint OriginalValue { get; set; }
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<CounterStatus> Counters { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public bool IsCounting { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Code));
			p_Writer.Write(CurrentValue);
			p_Writer.Write(OriginalValue);
			(RimeWriter Writer, uint ArrayIndex) s_Counters = p_EbxWriter.GetArrayWriter(Counters.GetType(), Counters.Count);
			p_Writer.Write(s_Counters.ArrayIndex);
			foreach (var s_Entry in Counters)
			{
				s_Entry.Serialize(s_Counters.Writer, p_EbxWriter);
			}
			p_Writer.Write(IsCounting);
			p_Writer.WriteNullBytes(3);
		}
	}
}
