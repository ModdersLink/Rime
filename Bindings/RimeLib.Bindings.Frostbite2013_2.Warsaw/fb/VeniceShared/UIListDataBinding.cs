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

using fb.Core;
using fb.UI;

namespace fb.VeniceShared;

[ContainerType(8, 160)]
public class UIListDataBinding
	: fb.UI.UIDataBinding
{
	[ContainerField(0x10), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
	public int ListIndex { get; set; } = 0;
	
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public UIDataSourceInfo ListQuery { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<StaticListItem> StaticItems { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public DefaultSelectionItem DefaultHighlightedRow { get; set; } = new();
	
	[ContainerField(0x58), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
	public UIListRowType RowType { get; set; } = UIListRowType.MixedRows;
	
	[ContainerField(0x5c), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
	public UIListNavigationType NavigationType { get; set; } = UIListNavigationType.loop;
	
	[ContainerField(0x60), JsonProperty(Order = 96)]
	public UIDataSourceInfo NavigationTypeSource { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public UIListUnFocusMode UnFocusMode { get; set; } = UIListUnFocusMode.DeSelect;
	
	[ContainerField(0x7c), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
	public UIListEmptyRowType EmptyRowType { get; set; } = UIListEmptyRowType.emptyRowNone;
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public int RowSpacing { get; set; } = 0;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string DisabledRows { get; set; } = string.Empty;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public bool SendIndexWithEvent { get; set; } = false;
	
	[ContainerField(0x91), LayoutImmutable, Blittable, JsonProperty(Order = 145)]
	public bool ClearListAtNavigationEvent { get; set; } = false;
	
	[ContainerField(0x92), LayoutImmutable, Blittable, JsonProperty(Order = 146)]
	public bool UseScrollBar { get; set; } = false;
	
	[ContainerField(0x93), LayoutImmutable, Blittable, JsonProperty(Order = 147)]
	public bool ScreenRotationEnabled { get; set; } = false;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public bool Use3DSelection { get; set; } = false;
	
	[ContainerField(0x95), LayoutImmutable, Blittable, JsonProperty(Order = 149)]
	public bool FireHighlightOnMouseOut { get; set; } = false;
	
	[ContainerField(0x96), LayoutImmutable, Blittable, JsonProperty(Order = 150)]
	public bool DataIncludesButtonLayout { get; set; } = false;
	
	[ContainerField(0x97), LayoutImmutable, Blittable, JsonProperty(Order = 151)]
	public bool Visible { get; set; } = true;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public bool SpinnerEnabled { get; set; } = false;
	
	[ContainerField(0x99), LayoutImmutable, Blittable, JsonProperty(Order = 153)]
	public bool HighLightOnUpdate { get; set; } = true;
	
	[ContainerField(0x9a), LayoutImmutable, Blittable, JsonProperty(Order = 154)]
	public bool EnableScaleToText { get; set; } = true;
	
	[ContainerField(0x9b), LayoutImmutable, Blittable, JsonProperty(Order = 155)]
	public bool DisableItemCaching { get; set; } = false;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public bool DisplayDisabledItems { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(ListIndex);
		p_Writer.WriteNullBytes(4);
		ListQuery.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_StaticItems = p_EbxWriter.GetArrayWriter(StaticItems.GetType(), StaticItems.Count);
		p_Writer.Write(s_StaticItems.ArrayIndex);
		foreach (var s_Entry in StaticItems)
		{
			s_Entry.Serialize(s_StaticItems.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		DefaultHighlightedRow.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) RowType);
		p_Writer.Write((int) NavigationType);
		NavigationTypeSource.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write((int) UnFocusMode);
		p_Writer.Write((int) EmptyRowType);
		p_Writer.Write(RowSpacing);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(DisabledRows));
		p_Writer.Write(SendIndexWithEvent);
		p_Writer.Write(ClearListAtNavigationEvent);
		p_Writer.Write(UseScrollBar);
		p_Writer.Write(ScreenRotationEnabled);
		p_Writer.Write(Use3DSelection);
		p_Writer.Write(FireHighlightOnMouseOut);
		p_Writer.Write(DataIncludesButtonLayout);
		p_Writer.Write(Visible);
		p_Writer.Write(SpinnerEnabled);
		p_Writer.Write(HighLightOnUpdate);
		p_Writer.Write(EnableScaleToText);
		p_Writer.Write(DisableItemCaching);
		p_Writer.Write(DisplayDisabledItems);
		p_Writer.WriteNullBytes(3);
	}
}

