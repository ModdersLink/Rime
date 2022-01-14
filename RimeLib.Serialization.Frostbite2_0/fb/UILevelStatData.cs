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
	public class UILevelStatData :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string StatEasy { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string StatMedium { get; set; } = string.Empty;
		
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string StatHard { get; set; } = string.Empty;
		
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string StatHardcore { get; set; } = string.Empty;
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StatEasy));
			p_Writer.Write(p_EbxWriter.WriteString(StatMedium));
			p_Writer.Write(p_EbxWriter.WriteString(StatHard));
			p_Writer.Write(p_EbxWriter.WriteString(StatHardcore));
		}
	}
}
