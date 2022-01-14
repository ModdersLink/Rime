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
	[ContainerType(4, 72)]
	public class UIPageHeaderBinding :
		UIDataBinding
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo Header { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public UIDataSourceInfo SubHeader { get; set; } = new();

		[ContainerField(40), JsonProperty(Order = 40)]
		public UIDataSourceInfo Icon { get; set; } = new();

		[ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		public string StaticHeader { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		public string StaticSubHeader { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		public string StaticIcon { get; set; } = string.Empty;

		[ContainerField(68), JsonProperty(Order = 68)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new();

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Header.Serialize(p_Writer, p_EbxWriter);
			SubHeader.Serialize(p_Writer, p_EbxWriter);
			Icon.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(StaticHeader));
			p_Writer.Write(p_EbxWriter.WriteString(StaticSubHeader));
			p_Writer.Write(p_EbxWriter.WriteString(StaticIcon));
			(RimeWriter Writer, uint ArrayIndex) s_LevelSpecificHeaders = p_EbxWriter.GetArrayWriter(LevelSpecificHeaders.GetType(), LevelSpecificHeaders.Count);
			p_Writer.Write(s_LevelSpecificHeaders.ArrayIndex);
			foreach (var s_Entry in LevelSpecificHeaders)
			{
				s_Entry.Serialize(s_LevelSpecificHeaders.Writer, p_EbxWriter);
			}
		}
	}
}
