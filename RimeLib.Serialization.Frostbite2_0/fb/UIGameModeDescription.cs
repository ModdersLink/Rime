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
	[ContainerType(4, 44)]
	public class UIGameModeDescription :
		UIItemDescription
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Identifier { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string Abbreviation { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string Desc { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public int BattlelogId { get; set; }

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string TexturePath { get; set; } = string.Empty;

		[ContainerField(40), JsonProperty(Order = 40)]
		public List<GameModeVariation> Variations { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Identifier));
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write(p_EbxWriter.WriteString(Abbreviation));
			p_Writer.Write(p_EbxWriter.WriteString(Desc));
			p_Writer.Write(BattlelogId);
			p_Writer.Write(p_EbxWriter.WriteString(TexturePath));
			(RimeWriter Writer, uint ArrayIndex) s_Variations = p_EbxWriter.GetArrayWriter(Variations.GetType(), Variations.Count);
			p_Writer.Write(s_Variations.ArrayIndex);
			foreach (var s_Entry in Variations)
			{
				s_Entry.Serialize(s_Variations.Writer, p_EbxWriter);
			}
		}
	}
}
