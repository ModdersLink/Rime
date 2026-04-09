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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 44)]
	public partial class UIGameModeDescription :
		UIItemDescription
	{
		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		private string _Identifier = string.Empty;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		private string _Name = string.Empty;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		private string _Abbreviation = string.Empty;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		private string _Desc = string.Empty;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private int _BattlelogId;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		private string _TexturePath = string.Empty;

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private List<GameModeVariation> _Variations = new();

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
