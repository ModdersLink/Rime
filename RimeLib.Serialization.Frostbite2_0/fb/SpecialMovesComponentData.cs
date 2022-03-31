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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(16, 528)]
	public class SpecialMovesComponentData :
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public SpecialMoveStateData VaultOverHighState { get; set; } = new();

		[ContainerField(156), JsonProperty(Order = 156)]
		public SpecialMoveStateData VaultUpHighState { get; set; } = new();

		[ContainerField(216), JsonProperty(Order = 216)]
		public SpecialMoveStateData VaultOverLowState { get; set; } = new();

		[ContainerField(276), JsonProperty(Order = 276)]
		public SpecialMoveStateData SprintToProneState { get; set; } = new();

		[ContainerField(336), JsonProperty(Order = 336)]
		public SpecialMoveStateData DeathState { get; set; } = new();

		[ContainerField(396), JsonProperty(Order = 396)]
		public SpecialMoveStateData SpecialAnimationState { get; set; } = new();

		[ContainerField(456), JsonProperty(Order = 456)]
		public List<SpecialMoveStateData> IndexedDeathStates { get; set; } = new();

		[ContainerField(460), JsonProperty(Order = 460)]
		public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get; set; } = new();

		[ContainerField(464), JsonProperty(Order = 464)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get; set; } = new();

		[ContainerField(468), JsonProperty(Order = 468)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get; set; } = new();

		[ContainerField(472), JsonProperty(Order = 472)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get; set; } = new();

		[ContainerField(476), JsonProperty(Order = 476)]
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
			(RimeWriter Writer, uint ArrayIndex) s_IndexedSpecialAnimationStates = p_EbxWriter.GetArrayWriter(IndexedSpecialAnimationStates.GetType(), IndexedSpecialAnimationStates.Count);
			p_Writer.Write(s_IndexedSpecialAnimationStates.ArrayIndex);
			foreach (var s_Entry in IndexedSpecialAnimationStates)
			{
				s_Entry.Serialize(s_IndexedSpecialAnimationStates.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultOverHighStates = p_EbxWriter.GetArrayWriter(IndexedVaultOverHighStates.GetType(), IndexedVaultOverHighStates.Count);
			p_Writer.Write(s_IndexedVaultOverHighStates.ArrayIndex);
			foreach (var s_Entry in IndexedVaultOverHighStates)
			{
				s_Entry.Serialize(s_IndexedVaultOverHighStates.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultUpStates = p_EbxWriter.GetArrayWriter(IndexedVaultUpStates.GetType(), IndexedVaultUpStates.Count);
			p_Writer.Write(s_IndexedVaultUpStates.ArrayIndex);
			foreach (var s_Entry in IndexedVaultUpStates)
			{
				s_Entry.Serialize(s_IndexedVaultUpStates.Writer, p_EbxWriter);
			}
			(RimeWriter Writer, uint ArrayIndex) s_IndexedVaultOverLowStates = p_EbxWriter.GetArrayWriter(IndexedVaultOverLowStates.GetType(), IndexedVaultOverLowStates.Count);
			p_Writer.Write(s_IndexedVaultOverLowStates.ArrayIndex);
			foreach (var s_Entry in IndexedVaultOverLowStates)
			{
				s_Entry.Serialize(s_IndexedVaultOverLowStates.Writer, p_EbxWriter);
			}
			Binding.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
		}
	}
}
