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
	[ContainerType(4, 40)]
	public class StaticListItem
	{
		[ContainerField(0), LayoutImmutable]
		public string ItemName { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public UIDataSourceInfo DynamicDisable { get; set; } = new();
		
		[ContainerField(20)]
		public UIDataSourceInfo DynamicNewContent { get; set; } = new();
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool AppendPlatformToSID { get; set; }
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool ExcludeInRetail { get; set; }
		
		public static void Deserialize(StaticListItem p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ItemName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIDataSourceInfo.Deserialize(p_Instance.DynamicDisable, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.DynamicNewContent, p_Reader, p_Parser);
			p_Instance.AppendPlatformToSID = p_Reader.ReadBool();
			p_Instance.ExcludeInRetail = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
