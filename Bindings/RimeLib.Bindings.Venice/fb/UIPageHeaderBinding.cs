///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 72)]
	public class UIPageHeaderBinding : 
		UIDataBinding
	{
		[ContainerField(8)]
		public UIDataSourceInfo Header { get; set; } = new();

		[ContainerField(24)]
		public UIDataSourceInfo SubHeader { get; set; } = new();

		[ContainerField(40)]
		public UIDataSourceInfo Icon { get; set; } = new();

		[ContainerField(56), LayoutImmutable]
		public string StaticHeader { get; set; } = string.Empty;

		[ContainerField(60), LayoutImmutable]
		public string StaticSubHeader { get; set; } = string.Empty;

		[ContainerField(64), LayoutImmutable]
		public string StaticIcon { get; set; } = string.Empty;

		[ContainerField(68)]
		public List<UILevelSpecificPageHeader> LevelSpecificHeaders { get; set; } = new();

		public static void Deserialize(UIPageHeaderBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.UIDataSourceInfo.Deserialize(p_Instance.Header, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.SubHeader, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.Icon, p_Reader, p_Parser);
			p_Instance.StaticHeader = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StaticSubHeader = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.StaticIcon = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.LevelSpecificHeaders.Clear();
			(RimeReader Reader, uint Count) s_LevelSpecificHeaders = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_LevelSpecificHeaders.Count; ++i)
			{
				var s_Value = new UILevelSpecificPageHeader();
				fb.UILevelSpecificPageHeader.Deserialize(s_Value, s_LevelSpecificHeaders.Reader, p_Parser);
				p_Instance.LevelSpecificHeaders.Add(s_Value);
			}
			
			s_LevelSpecificHeaders.Reader.Dispose();
		}

	}
}
