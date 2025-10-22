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
using fb.GameShared;
using fb.Entity;

namespace fb.VeniceShared;

[ContainerType(8, 168)]
public class UICustomizeItemListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
	public float CategorySpacing { get; set; } = 2.000f;
	
	[ContainerField(0x6c), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
	public float ItemSpacing { get; set; } = 0.000f;
	
	[ContainerField(0x70), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
	public float CategoryItemsSpacing { get; set; } = 2.000f;
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIWidgetBlueprint> CategoryButtonTemplate { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public CtrRef<UIWidgetBlueprint> ItemTemplate { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float ItemsScrollbarWidth { get; set; } = 5.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public float ItemsScrollbarMargin { get; set; } = 2.000f;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIElementScrollbarStyle> ItemsScrollbarStyle { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public int SelectedState { get; set; } = 0;
	
	[ContainerField(0x9c), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
	public int SelectedTab { get; set; } = 0;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public int SelectedSlot { get; set; } = 0;
	
	[ContainerField(0xa4), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
	public int SelectedItemId { get; set; } = 0;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(CategorySpacing);
		p_Writer.Write(ItemSpacing);
		p_Writer.Write(CategoryItemsSpacing);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CategoryButtonTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ItemTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ItemsScrollbarWidth);
		p_Writer.Write(ItemsScrollbarMargin);
		p_Writer.Write(p_EbxWriter.WriteImport(ItemsScrollbarStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(SelectedState);
		p_Writer.Write(SelectedTab);
		p_Writer.Write(SelectedSlot);
		p_Writer.Write(SelectedItemId);
	}
}

