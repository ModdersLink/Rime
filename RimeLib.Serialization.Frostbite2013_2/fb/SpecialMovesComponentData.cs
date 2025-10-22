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

using fb.VeniceShared;
using fb.Entity;
using fb.Core;

namespace fb.Venice;

[ContainerType(16, 864)]
public class SpecialMovesComponentData
	: fb.Entity.GameComponentData
{
	[ContainerField(0x70), JsonProperty(Order = 112)]
	public SpecialMoveStateData VaultOverHighState { get; set; } = new();
	
	[ContainerField(0xb8), JsonProperty(Order = 184)]
	public SpecialMoveStateData VaultUpHighState { get; set; } = new();
	
	[ContainerField(0x100), JsonProperty(Order = 256)]
	public SpecialMoveStateData VaultOverLowState { get; set; } = new();
	
	[ContainerField(0x148), JsonProperty(Order = 328)]
	public SpecialMoveStateData SprintToProneState { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public SpecialMoveStateData DeathState { get; set; } = new();
	
	[ContainerField(0x1d8), JsonProperty(Order = 472)]
	public SpecialMoveStateData SpecialAnimationState { get; set; } = new();
	
	[ContainerField(0x220), JsonProperty(Order = 544)]
	public List<SpecialMoveStateData> IndexedDeathStates { get; set; } = new();
	
	[ContainerField(0x228), JsonProperty(Order = 552)]
	public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get; set; } = new();
	
	[ContainerField(0x230), JsonProperty(Order = 560)]
	public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get; set; } = new();
	
	[ContainerField(0x238), JsonProperty(Order = 568)]
	public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get; set; } = new();
	
	[ContainerField(0x240), JsonProperty(Order = 576)]
	public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get; set; } = new();
	
	[ContainerField(0x248), JsonProperty(Order = 584)]
	public SpecialMovesBinding Binding { get; set; } = new();
	
	public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
	{
		base.Serialize(p_Writer, p_EbxWriter);
		VaultOverHighState.Serialize(p_Writer, p_EbxWriter);
		VaultUpHighState.Serialize(p_Writer, p_EbxWriter);
		VaultOverLowState.Serialize(p_Writer, p_EbxWriter);
		SprintToProneState.Serialize(p_Writer, p_EbxWriter);
		DeathState.Serialize(p_Writer, p_EbxWriter);
		SpecialAnimationState.Serialize(p_Writer, p_EbxWriter);
		(RimeWriter Writer, uint ArrayIndex) s_IndexedDeathStates = p_EbxWriter.GetArrayWriter(IndexedDeathStates.GetType(), IndexedDeathStates.Count);
		p_Writer.Write(s_IndexedDeathStates.ArrayIndex);
		foreach (var s_Entry in IndexedDeathStates)
		{
			s_Entry.Serialize(s_IndexedDeathStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IndexedSpecialAnimationStates = p_EbxWriter.GetArrayWriter(IndexedSpecialAnimationStates.GetType(), IndexedSpecialAnimationStates.Count);
		p_Writer.Write(s_IndexedSpecialAnimationStates.ArrayIndex);
		foreach (var s_Entry in IndexedSpecialAnimationStates)
		{
			s_Entry.Serialize(s_IndexedSpecialAnimationStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultOverHighStates = p_EbxWriter.GetArrayWriter(IndexedVaultOverHighStates.GetType(), IndexedVaultOverHighStates.Count);
		p_Writer.Write(s_IndexedVaultOverHighStates.ArrayIndex);
		foreach (var s_Entry in IndexedVaultOverHighStates)
		{
			s_Entry.Serialize(s_IndexedVaultOverHighStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultUpStates = p_EbxWriter.GetArrayWriter(IndexedVaultUpStates.GetType(), IndexedVaultUpStates.Count);
		p_Writer.Write(s_IndexedVaultUpStates.ArrayIndex);
		foreach (var s_Entry in IndexedVaultUpStates)
		{
			s_Entry.Serialize(s_IndexedVaultUpStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultOverLowStates = p_EbxWriter.GetArrayWriter(IndexedVaultOverLowStates.GetType(), IndexedVaultOverLowStates.Count);
		p_Writer.Write(s_IndexedVaultOverLowStates.ArrayIndex);
		foreach (var s_Entry in IndexedVaultOverLowStates)
		{
			s_Entry.Serialize(s_IndexedVaultOverLowStates.Writer, p_EbxWriter);
		}
		p_Writer.WriteNullBytes(4);
		Binding.Serialize(p_Writer, p_EbxWriter);
	}
}

