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
public class BattlepackAsset
	: fb.Core.Asset
{
	[ContainerField(0x18), JsonProperty(Order = 24)]
	public List<BasicUnlockInfo> BattlepackInfos { get; set; } = new();
	
	[ContainerField(0x20), JsonProperty(Order = 32)]
	public RefArray<BoostData> Boosts { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public List<BasicUnlockInfo> UnlockInfos { get; set; } = new();
	
	[ContainerField(0x30), JsonProperty(Order = 48)]
	public List<uint> PremiumIds { get; set; } = new();
	
	[ContainerField(0x38), JsonProperty(Order = 56)]
	public List<uint> VeteranIds { get; set; } = new();
	
	[ContainerField(0x40), JsonProperty(Order = 64)]
	public List<uint> WeaponIds { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_BattlepackInfos = p_EbxWriter.GetArrayWriter(BattlepackInfos.GetType(), BattlepackInfos.Count);
		p_Writer.Write(s_BattlepackInfos.ArrayIndex);
		foreach (var s_Entry in BattlepackInfos)
		{
			s_Entry.Serialize(s_BattlepackInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_Boosts = p_EbxWriter.GetArrayWriter(Boosts.GetType(), Boosts.Count);
		p_Writer.Write(s_Boosts.ArrayIndex);
		foreach (var s_Entry in Boosts)
		{
			s_Boosts.Writer.Write(p_EbxWriter.WriteImport(s_Entry));
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_UnlockInfos = p_EbxWriter.GetArrayWriter(UnlockInfos.GetType(), UnlockInfos.Count);
		p_Writer.Write(s_UnlockInfos.ArrayIndex);
		foreach (var s_Entry in UnlockInfos)
		{
			s_Entry.Serialize(s_UnlockInfos.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_PremiumIds = p_EbxWriter.GetArrayWriter(PremiumIds.GetType(), PremiumIds.Count);
		p_Writer.Write(s_PremiumIds.ArrayIndex);
		foreach (var s_Entry in PremiumIds)
		{
			s_PremiumIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_VeteranIds = p_EbxWriter.GetArrayWriter(VeteranIds.GetType(), VeteranIds.Count);
		p_Writer.Write(s_VeteranIds.ArrayIndex);
		foreach (var s_Entry in VeteranIds)
		{
			s_VeteranIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_WeaponIds = p_EbxWriter.GetArrayWriter(WeaponIds.GetType(), WeaponIds.Count);
		p_Writer.Write(s_WeaponIds.ArrayIndex);
		foreach (var s_Entry in WeaponIds)
		{
			s_WeaponIds.Writer.Write(s_Entry);
		}
		p_Writer.WriteNullBytes(4);
	}
}

