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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(16, 528)]
	public partial class SpecialMovesComponentData :
		ComponentData
	{
		[ObservableProperty]
		[property: ContainerField(96), JsonProperty(Order = 96)]
		private SpecialMoveStateData _VaultOverHighState = new();

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private SpecialMoveStateData _VaultUpHighState = new();

		[ObservableProperty]
		[property: ContainerField(216), JsonProperty(Order = 216)]
		private SpecialMoveStateData _VaultOverLowState = new();

		[ObservableProperty]
		[property: ContainerField(276), JsonProperty(Order = 276)]
		private SpecialMoveStateData _SprintToProneState = new();

		[ObservableProperty]
		[property: ContainerField(336), JsonProperty(Order = 336)]
		private SpecialMoveStateData _DeathState = new();

		[ObservableProperty]
		[property: ContainerField(396), JsonProperty(Order = 396)]
		private SpecialMoveStateData _SpecialAnimationState = new();

		[ObservableProperty]
		[property: ContainerField(456), JsonProperty(Order = 456)]
		private List<SpecialMoveStateData> _IndexedDeathStates = new();

		[ObservableProperty]
		[property: ContainerField(460), JsonProperty(Order = 460)]
		private List<SpecialMoveStateData> _IndexedSpecialAnimationStates = new();

		[ObservableProperty]
		[property: ContainerField(464), JsonProperty(Order = 464)]
		private List<SpecialMoveVaultStateCriteria> _IndexedVaultOverHighStates = new();

		[ObservableProperty]
		[property: ContainerField(468), JsonProperty(Order = 468)]
		private List<SpecialMoveVaultStateCriteria> _IndexedVaultUpStates = new();

		[ObservableProperty]
		[property: ContainerField(472), JsonProperty(Order = 472)]
		private List<SpecialMoveVaultStateCriteria> _IndexedVaultOverLowStates = new();

		[ObservableProperty]
		[property: ContainerField(476), JsonProperty(Order = 476)]
		private SpecialMovesBinding _Binding = new();

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
