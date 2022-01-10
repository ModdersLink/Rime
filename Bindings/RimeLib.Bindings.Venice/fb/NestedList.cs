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
	public class NestedList
	{
		[ContainerField(0), LayoutImmutable]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable]
		public string Index { get; set; } = string.Empty;
		
		[ContainerField(8)]
		public UIDataSourceInfo ListDataSource { get; set; } = new();
		
		[ContainerField(24)]
		public UIDataSourceInfo DynamicShowList { get; set; } = new();
		
		[ContainerField(40)]
		public List<string> StaticItems { get; set; } = new();
		
		[ContainerField(44)]
		public DefaultSelectionItem DefaultHighlighted { get; set; } = new();
		
		[ContainerField(64)]
		public UIListRowType RowType { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public bool UseAsNormalListRows { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable]
		public bool HiddenOnPC { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable]
		public bool HiddenOnXenon { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable]
		public bool HighLightOnUpdate { get; set; }
		
		public static void Deserialize(NestedList p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Label = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Index = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			fb.UIDataSourceInfo.Deserialize(p_Instance.ListDataSource, p_Reader, p_Parser);
			fb.UIDataSourceInfo.Deserialize(p_Instance.DynamicShowList, p_Reader, p_Parser);
			p_Instance.StaticItems.Clear();
			(RimeReader Reader, uint Count) s_StaticItems = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_StaticItems.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_StaticItems.Reader.ReadUInt32());
				p_Instance.StaticItems.Add(s_Value);
			}
			
			s_StaticItems.Reader.Dispose();
			fb.DefaultSelectionItem.Deserialize(p_Instance.DefaultHighlighted, p_Reader, p_Parser);
			p_Instance.RowType = (UIListRowType) p_Reader.ReadInt32();
			p_Instance.UseAsNormalListRows = p_Reader.ReadBool();
			p_Instance.HiddenOnPC = p_Reader.ReadBool();
			p_Instance.HiddenOnXenon = p_Reader.ReadBool();
			p_Instance.HighLightOnUpdate = p_Reader.ReadBool();
		}
	}
}
