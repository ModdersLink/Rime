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

[ContainerType(8, 200)]
public class UISoldierProgressionGridWidgetData
	: fb.VeniceShared.BFUIWidgetEntityData
{
	[ContainerField(0x68), JsonProperty(Order = 104)]
	public CtrRef<UIWidgetBlueprint> RowTemplate { get; set; } = new();
	
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public CtrRef<UIWidgetBlueprint> ItemTemplate { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public CtrRef<UIWidgetBlueprint> EmptyItemTemplate { get; set; } = new();
	
	[ContainerField(0x80), JsonProperty(Order = 128)]
	public List<ScoringBucket> BucketDisplayOrder { get; set; } = new();
	
	[ContainerField(0x88), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
	public string EnableInputProperty { get; set; } = string.Empty;
	
	[ContainerField(0x90), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
	public string GadgetInfoCAI { get; set; } = string.Empty;
	
	[ContainerField(0x98), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
	public string AccessoryInfoCAI { get; set; } = string.Empty;
	
	[ContainerField(0xa0), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
	public string WeaponCompareCAI { get; set; } = string.Empty;
	
	[ContainerField(0xa8), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
	public string WeaponAccessoriesCAI { get; set; } = string.Empty;
	
	[ContainerField(0xb0), JsonProperty(Order = 176)]
	public UIGridStepperConfig GridStepperConfig { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteImport(RowTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(ItemTemplate));
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteImport(EmptyItemTemplate));
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_BucketDisplayOrder = p_EbxWriter.GetArrayWriter(BucketDisplayOrder.GetType(), BucketDisplayOrder.Count);
		p_Writer.Write(s_BucketDisplayOrder.ArrayIndex);
		foreach (var s_Entry in BucketDisplayOrder)
		{
			s_BucketDisplayOrder.Writer.Write((int) s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		p_Writer.Write(p_EbxWriter.WriteString(EnableInputProperty));
		p_Writer.Write(p_EbxWriter.WriteString(GadgetInfoCAI));
		p_Writer.Write(p_EbxWriter.WriteString(AccessoryInfoCAI));
		p_Writer.Write(p_EbxWriter.WriteString(WeaponCompareCAI));
		p_Writer.Write(p_EbxWriter.WriteString(WeaponAccessoriesCAI));
		GridStepperConfig.Serialize(p_Writer, p_EbxWriter);
	}
}

