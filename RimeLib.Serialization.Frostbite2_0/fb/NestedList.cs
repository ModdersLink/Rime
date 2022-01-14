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
	public class NestedList :
		EbxSerializable
	{
		[ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		public string Label { get; set; } = string.Empty;
		
		[ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		public string Index { get; set; } = string.Empty;
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public UIDataSourceInfo ListDataSource { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public UIDataSourceInfo DynamicShowList { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public List<string> StaticItems { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public DefaultSelectionItem DefaultHighlighted { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public UIListRowType RowType { get; set; } = new();
		
		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public bool UseAsNormalListRows { get; set; }
		
		[ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		public bool HiddenOnPC { get; set; }
		
		[ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		public bool HiddenOnXenon { get; set; }
		
		[ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		public bool HighLightOnUpdate { get; set; }
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Label));
			p_Writer.Write(p_EbxWriter.WriteString(Index));
			ListDataSource.Serialize(p_Writer, p_EbxWriter);
			DynamicShowList.Serialize(p_Writer, p_EbxWriter);
			(RimeWriter Writer, uint ArrayIndex) s_StaticItems = p_EbxWriter.GetArrayWriter(StaticItems.GetType(), StaticItems.Count);
			p_Writer.Write(s_StaticItems.ArrayIndex);
			foreach (var s_Entry in StaticItems)
			{
				s_StaticItems.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			DefaultHighlighted.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) RowType);
			p_Writer.Write(UseAsNormalListRows);
			p_Writer.Write(HiddenOnPC);
			p_Writer.Write(HiddenOnXenon);
			p_Writer.Write(HighLightOnUpdate);
		}
	}
}
