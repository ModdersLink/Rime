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
	public class UIListItem
	{
		[ContainerField(0), LayoutImmutable]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public UIDataSourceInfo IsEnabled { get; set; } = new();
		
		[ContainerField(20)]
		public UIDataSourceInfo IsVisible { get; set; } = new();
		
		[ContainerField(36)]
		public UIDataSourceInfo ToggleItems { get; set; } = new();
		
		[ContainerField(52)]
		public UIDataSourceInfo DataUpdate { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool DefaultIsVisible { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool DefaultIsEnabled { get; set; }
		
		public static void Deserialize(UIListItem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Label = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIDataSourceInfo.Deserialize(p_Instance.IsEnabled, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.IsVisible, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.ToggleItems, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.DataUpdate, p_Reader, p_Parser);
			p_Instance.DefaultIsVisible = p_Reader.ReadBool();
			p_Instance.DefaultIsEnabled = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
