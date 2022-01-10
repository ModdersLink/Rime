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
	[ContainerType(4, 16)]
	public class UIDataSourceInfo
	{
		[ContainerField(0), LayoutImmutable]
		public string DataName { get; set; } = string.Empty;
		
		[ContainerField(4)]
		public CtrRef<UIComponentData> DataCategory { get; set; } = new();
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public int DataKey { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public bool UseDirectAccess { get; set; }
		
		[ContainerField(13), LayoutImmutable, Blittable]
		public bool UpdateOnInitialize { get; set; }
		
		public static void Deserialize(UIDataSourceInfo p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DataName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.DataCategory.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.DataKey = p_Reader.ReadInt32();
			p_Instance.UseDirectAccess = p_Reader.ReadBool();
			p_Instance.UpdateOnInitialize = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
