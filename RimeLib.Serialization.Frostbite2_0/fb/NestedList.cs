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
	public partial class NestedList :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), LayoutImmutable, JsonProperty(Order = 0)]
		private string _Label = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(4), LayoutImmutable, JsonProperty(Order = 4)]
		private string _Index = string.Empty;
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private UIDataSourceInfo _ListDataSource = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIDataSourceInfo _DynamicShowList = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private List<string> _StaticItems = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private DefaultSelectionItem _DefaultHighlighted = new();
		
		[ObservableProperty]
		[property: ContainerField(64), JsonProperty(Order = 64)]
		private UIListRowType _RowType = new();
		
		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private bool _UseAsNormalListRows;
		
		[ObservableProperty]
		[property: ContainerField(69), LayoutImmutable, Blittable, JsonProperty(Order = 69)]
		private bool _HiddenOnPC;
		
		[ObservableProperty]
		[property: ContainerField(70), LayoutImmutable, Blittable, JsonProperty(Order = 70)]
		private bool _HiddenOnXenon;
		
		[ObservableProperty]
		[property: ContainerField(71), LayoutImmutable, Blittable, JsonProperty(Order = 71)]
		private bool _HighLightOnUpdate;
		
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
