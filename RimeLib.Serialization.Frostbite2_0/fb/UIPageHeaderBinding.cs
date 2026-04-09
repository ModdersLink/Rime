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
	[ContainerType(4, 72)]
	public partial class UIPageHeaderBinding :
		UIDataBinding
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _Header = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIDataSourceInfo _SubHeader = new();

		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private UIDataSourceInfo _Icon = new();

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, JsonProperty(Order = 56)]
		private string _StaticHeader = string.Empty;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, JsonProperty(Order = 60)]
		private string _StaticSubHeader = string.Empty;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, JsonProperty(Order = 64)]
		private string _StaticIcon = string.Empty;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private List<UILevelSpecificPageHeader> _LevelSpecificHeaders = new();

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
