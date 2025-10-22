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

[ContainerType(16, 432)]
public class UIBattlepackOpeningWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFillData> AdvancedItemFill { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIElementFillData> StandardItemFill { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public UIElementColor AdvancedItemColor { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public UIElementColor StandardItemColor { get; set; } = new();
	
	[ContainerField(0xc0), JsonProperty(Order = 192)]
	public UIElementColor SuperiorItemColor { get; set; } = new();
	
	[ContainerField(0xe0), JsonProperty(Order = 224)]
	public UIElementColor DistinguishedItemColor { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public UIElementColor SpecialItemColor { get; set; } = new();
	
	[ContainerField(0x120), JsonProperty(Order = 288)]
	public UIElementColor PremiumItemColor { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public CtrRef<UIElementFillData> SuperiorItemFill { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public CtrRef<UIElementFillData> DistinguishedItemFill { get; set; } = new();
	
	[ContainerField(0x150), JsonProperty(Order = 336)]
	public CtrRef<UIElementFillData> SpecialItemFill { get; set; } = new();
	
	[ContainerField(0x158), JsonProperty(Order = 344)]
	public CtrRef<UIElementFillData> PremiumItemFill { get; set; } = new();
	
	[ContainerField(0x160), JsonProperty(Order = 352)]
	public CtrRef<UIWidgetBlueprint> CellTemplate { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public CtrRef<UIElementFillData> NormalFill { get; set; } = new();
	
	[ContainerField(0x170), JsonProperty(Order = 368)]
	public CtrRef<UIElementFillData> SelectedFill { get; set; } = new();
	
	[ContainerField(0x178), JsonProperty(Order = 376)]
	public CtrRef<UIElementFillData> SelectedLabelFill { get; set; } = new();
	
	[ContainerField(0x180), JsonProperty(Order = 384)]
	public CtrRef<UIElementFillData> DescriptionBackgroundFill { get; set; } = new();
	
	[ContainerField(0x188), JsonProperty(Order = 392)]
	public CtrRef<UIElementFontStyle> NormalFont { get; set; } = new();
	
	[ContainerField(0x190), LayoutImmutable, Blittable, JsonProperty(Order = 400)]
	public int CellSpacing { get; set; } = 2;
	
	[ContainerField(0x194), LayoutImmutable, Blittable, JsonProperty(Order = 404)]
	public float CellHeight { get; set; } = 200.000f;
	
	[ContainerField(0x198), LayoutImmutable, Blittable, JsonProperty(Order = 408)]
	public string HiddenCardTexture { get; set; } = string.Empty;
	
	[ContainerField(0x1a0), LayoutImmutable, Blittable, JsonProperty(Order = 416)]
	public string RevealedCardTexture { get; set; } = string.Empty;
	
	[ContainerField(0x1a8), LayoutImmutable, Blittable, JsonProperty(Order = 424)]
	public float BattlepackOpeningCellPaintHeight { get; set; } = 50.000f;
	
	[ContainerField(0x1ac), LayoutImmutable, Blittable, JsonProperty(Order = 428)]
	public float BattlepackOpeningCellPaintWidth { get; set; } = 200.000f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(AdvancedItemFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(StandardItemFill));
		p_Writer.WriteNullBytes(12);
		AdvancedItemColor.Serialize(p_Writer, p_EbxWriter);
		StandardItemColor.Serialize(p_Writer, p_EbxWriter);
		SuperiorItemColor.Serialize(p_Writer, p_EbxWriter);
		DistinguishedItemColor.Serialize(p_Writer, p_EbxWriter);
		SpecialItemColor.Serialize(p_Writer, p_EbxWriter);
		PremiumItemColor.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(SuperiorItemFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DistinguishedItemFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SpecialItemFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(PremiumItemFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(CellTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NormalFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(SelectedLabelFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(DescriptionBackgroundFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(NormalFont));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(CellSpacing);
		p_Writer.Write(CellHeight);
		p_Writer.Write(p_EbxWriter.WriteString(HiddenCardTexture));
		p_Writer.Write(p_EbxWriter.WriteString(RevealedCardTexture));
		p_Writer.Write(BattlepackOpeningCellPaintHeight);
		p_Writer.Write(BattlepackOpeningCellPaintWidth);
	}
}

