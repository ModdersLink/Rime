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

[ContainerType(8, 160)]
public class UIBattledashHListWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIElementFillData> StepperEmptyFill { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> ElementWidget { get; set; } = new();
	
	[ContainerField(0x78), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
	public string WidgetIdentifier { get; set; } = @"HorzListWidget";
	
	[ContainerField(0x80), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
	public float Padding { get; set; } = 1.000f;
	
	[ContainerField(0x84), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
	public UIBattlelogDataSource ListDataSource { get; set; } = UIBattlelogDataSource.BattlelogDataSource_ChallengeTypes;
	
	[ContainerField(0x88), JsonProperty(Order = 136)]
	public List<UIBattledashHorisontalListData> ListItems { get; set; } = new();
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public float MinAlpha { get; set; } = 0.300f;
	
	[ContainerField(0x94), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
	public float BlinkFrequency { get; set; } = 5.000f;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public float FlashTime { get; set; } = 0.500f;
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(StepperEmptyFill));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ElementWidget));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(WidgetIdentifier));
		p_Writer.Write(Padding);
		p_Writer.Write((int) ListDataSource);
		(RimeWriter Writer, uint ArrayIndex) s_ListItems = p_EbxWriter.GetArrayWriter(ListItems.GetType(), ListItems.Count);
		p_Writer.Write(s_ListItems.ArrayIndex);
		foreach (var s_Entry in ListItems)
		{
			s_Entry.Serialize(s_ListItems.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(MinAlpha);
		p_Writer.Write(BlinkFrequency);
		p_Writer.Write(FlashTime);
		p_Writer.WriteNullBytes(4);
	}
}

