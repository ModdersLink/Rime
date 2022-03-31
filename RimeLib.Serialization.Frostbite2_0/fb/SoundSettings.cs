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
	[ContainerType(4, 44)]
	public class SoundSettings :
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string VOEnglish { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string AudioSystemUri { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string VOCommon { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string VOItalian { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string VOSpanish { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string VOFrench { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string VOGerman { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool Enable { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(VOEnglish));
			p_Writer.Write(p_EbxWriter.WriteString(AudioSystemUri));
			p_Writer.Write(p_EbxWriter.WriteString(VOCommon));
			p_Writer.Write(p_EbxWriter.WriteString(VOItalian));
			p_Writer.Write(p_EbxWriter.WriteString(VOSpanish));
			p_Writer.Write(p_EbxWriter.WriteString(VOFrench));
			p_Writer.Write(p_EbxWriter.WriteString(VOGerman));
			p_Writer.Write(Enable);
			p_Writer.WriteNullBytes(3);
		}
	}
}
