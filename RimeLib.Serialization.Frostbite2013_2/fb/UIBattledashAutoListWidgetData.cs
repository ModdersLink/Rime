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

[ContainerType(8, 208)]
public class UIBattledashAutoListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public List<UIAutoListCategoryData> Categories { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFontStyle> HeaderFont { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIElementFillData> HeaderBackgroundFill { get; set; } = new();
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float HeaderLeftMargin { get; set; } = 5.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public float HeaderPadding { get; set; } = 6.000f;
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public float HeaderHeight { get; set; } = 20.000f;
	
	[ContainerField(0x8c), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
	public UIElementAlignment HeaderTextAlignment { get; set; } = UIElementAlignment.UIElementAlignment_Left;
	
	[ContainerField(0x90), JsonProperty(Order = 144)]
	public CtrRef<UIWidgetBlueprint> EmptyHeaderInfoWidget { get; set; } = new();
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float ListPadding { get; set; } = 1.000f;
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public CtrRef<UIElementFillData> RowBackgroundFill { get; set; } = new();
	
	[ContainerField(0xa8), JsonProperty(Order = 168)]
	public CtrRef<UIWidgetBlueprint> ListRowWidget { get; set; } = new();
	
	[ContainerField(0xb0), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
	public float PinholeMarkerSize { get; set; } = 4.000f;
	
	[ContainerField(0xb4), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
	public float HighlightAnimationSpeed { get; set; } = 1.000f;
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public CtrRef<UIElementScrollbarStyle> ScrollBarStyle { get; set; } = new();
	
	[ContainerField(0xc0), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
	public uint ScrollbarWidth { get; set; } = 4;
	
	[ContainerField(0xc4), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
	public uint ScrollbarMargin { get; set; } = 5;
	
	[ContainerField(0xc8), LayoutImmutable, Blittable, JsonProperty(Order = 200)]
	public bool UseStickyCategories { get; set; } = true;
	
	[ContainerField(0xc9), LayoutImmutable, Blittable, JsonProperty(Order = 201)]
	public bool DrawHiddenRowsCount { get; set; } = false;
	
	[ContainerField(0xca), LayoutImmutable, Blittable, JsonProperty(Order = 202)]
	public bool HasRowImages { get; set; } = false;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_Categories = p_EbxWriter.GetArrayWriter(Categories.GetType(), Categories.Count);
		p_Writer.Write(s_Categories.ArrayIndex);
		foreach (var s_Entry in Categories)
		{
			s_Entry.Serialize(s_Categories.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(HeaderBackgroundFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(HeaderLeftMargin);
		p_Writer.Write(HeaderPadding);
		p_Writer.Write(HeaderHeight);
		p_Writer.Write((int) HeaderTextAlignment);
		p_Writer.Write(p_EbxWriter.WriteImport(EmptyHeaderInfoWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ListPadding);
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(RowBackgroundFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ListRowWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(PinholeMarkerSize);
		p_Writer.Write(HighlightAnimationSpeed);
		p_Writer.Write(p_EbxWriter.WriteImport(ScrollBarStyle));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(ScrollbarWidth);
		p_Writer.Write(ScrollbarMargin);
		p_Writer.Write(UseStickyCategories);
		p_Writer.Write(DrawHiddenRowsCount);
		p_Writer.Write(HasRowImages);
		p_Writer.WriteNullBytes(5);
	}
}

