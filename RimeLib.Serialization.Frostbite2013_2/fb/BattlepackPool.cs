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

namespace fb.VeniceShared;

[ContainerType(8, 72)]
public class BattlepackPool
	: fb.Core.Asset
{
	[ContainerField(0x18), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
	public string Key { get; set; } = string.Empty;
	
	[ContainerField(0x20), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
	public string Label { get; set; } = string.Empty;
	
	[ContainerField(0x28), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
	public string Description { get; set; } = string.Empty;
	
	[ContainerField(0x30), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
	public RarenessLevel RarenessLevel { get; set; } = fb.VeniceShared.RarenessLevel.RarenessLevel_Standard;
	
	[ContainerField(0x34), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
	public BattlepackItemType BattlepackItemType { get; set; } = fb.VeniceShared.BattlepackItemType.BattlepackItemType_Accessory;
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public RefArray<UnlockAssetBase> BattlepackItems { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public RefArray<BoostData> Boosts { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		p_Writer.Write(p_EbxWriter.WriteString(Key));
		p_Writer.Write(p_EbxWriter.WriteString(Label));
		p_Writer.Write(p_EbxWriter.WriteString(Description));
		p_Writer.Write((int) RarenessLevel);
		p_Writer.Write((int) BattlepackItemType);
		(RimeWriter Writer, uint ArrayIndex) s_BattlepackItems = p_EbxWriter.GetArrayWriter(BattlepackItems.GetType(), BattlepackItems.Count);
		p_Writer.Write(s_BattlepackItems.ArrayIndex);
		foreach (var s_Entry in BattlepackItems)
		{
			s_BattlepackItems.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Boosts = p_EbxWriter.GetArrayWriter(Boosts.GetType(), Boosts.Count);
		p_Writer.Write(s_Boosts.ArrayIndex);
		foreach (var s_Entry in Boosts)
		{
			s_Boosts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
	}
}

