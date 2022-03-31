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
	public class AudioLanguageSetting :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public uint NameHash { get; set; }

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string DisplayName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<AudioLanguageMapping> Mappings { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public bool IsDefault { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(NameHash);
			p_Writer.Write(p_EbxWriter.WriteString(DisplayName));
			(RimeWriter Writer, uint ArrayIndex) s_Mappings = p_EbxWriter.GetArrayWriter(Mappings.GetType(), Mappings.Count);
			p_Writer.Write(s_Mappings.ArrayIndex);
			foreach (var s_Entry in Mappings)
			{
				s_Entry.Serialize(s_Mappings.Writer, p_EbxWriter);
			}
			p_Writer.Write(IsDefault);
			p_Writer.WriteNullBytes(3);
		}
	}
}
