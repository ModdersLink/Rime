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

using fb.UI;
using fb.Core;

namespace fb.VeniceShared;

[ContainerType(8, 120)]
public class UINestedListDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int ListIndex { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<NestedList> NestedLists { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();
	
	[ContainerField(0x40), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
	public UIListNavigationType NavigationType { get; set; } = UIListNavigationType.loop;
	
	[ContainerField(0x44), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
	public UIListEmptyRowType EmptyRowType { get; set; } = UIListEmptyRowType.emptyRowNone;
	
	[ContainerField(0x48), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
	public int RowSpacing { get; set; } = 0;
	
	[ContainerField(0x4c), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
	public int SelectorWidth { get; set; } = 200;
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public UIDataSourceInfo Visibility { get; set; } = new();
	
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public UIListRowType RowType { get; set; } = UIListRowType.MixedRows;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public bool SendIndexWithEvent { get; set; } = false;
	
	[ContainerField(0x6d), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
	public bool ClearListAtNavigationEvent { get; set; } = false;
	
	[ContainerField(0x6e), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
	public bool UseScrollBar { get; set; } = false;
	
	[ContainerField(0x6f), LayoutImmutable, Blittable, JsonProperty(Order = 111)]
	public bool ScreenRotationEnabled { get; set; } = false;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public bool Use3DSelection { get; set; } = false;
	
	[ContainerField(0x71), LayoutImmutable, Blittable, JsonProperty(Order = 113)]
	public bool DataIncludesButtonLayout { get; set; } = false;
	
	[ContainerField(0x72), LayoutImmutable, Blittable, JsonProperty(Order = 114)]
	public bool InvertVisible { get; set; } = false;
	
	[ContainerField(0x73), LayoutImmutable, Blittable, JsonProperty(Order = 115)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x74), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
	public bool HighLightOnUpdate { get; set; } = true;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ListIndex);
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_NestedLists = p_EbxWriter.GetArrayWriter(NestedLists.GetType(), NestedLists.Count);
		p_Writer.Write(s_NestedLists.ArrayIndex);
		foreach (var s_Entry in NestedLists)
		{
			s_Entry.Serialize(s_NestedLists.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		DefaultHighlightedRow.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) NavigationType);
		p_Writer.Write((int) EmptyRowType);
		p_Writer.Write(RowSpacing);
		p_Writer.Write(SelectorWidth);
		Visibility.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RowType);
		p_Writer.Write(SendIndexWithEvent);
		p_Writer.Write(ClearListAtNavigationEvent);
		p_Writer.Write(UseScrollBar);
		p_Writer.Write(ScreenRotationEnabled);
		p_Writer.Write(Use3DSelection);
		p_Writer.Write(DataIncludesButtonLayout);
		p_Writer.Write(InvertVisible);
		p_Writer.Write(Visible);
		p_Writer.Write(HighLightOnUpdate);
		p_Writer.WriteNullBytes(3);
	}
}

