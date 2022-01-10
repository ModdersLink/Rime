///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 528)]
	public class SpecialMovesComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SpecialMoveStateData VaultOverHighState { get; set; } = new();

		[ContainerField(156)]
		public SpecialMoveStateData VaultUpHighState { get; set; } = new();

		[ContainerField(216)]
		public SpecialMoveStateData VaultOverLowState { get; set; } = new();

		[ContainerField(276)]
		public SpecialMoveStateData SprintToProneState { get; set; } = new();

		[ContainerField(336)]
		public SpecialMoveStateData DeathState { get; set; } = new();

		[ContainerField(396)]
		public SpecialMoveStateData SpecialAnimationState { get; set; } = new();

		[ContainerField(456)]
		public List<SpecialMoveStateData> IndexedDeathStates { get; set; } = new();

		[ContainerField(460)]
		public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get; set; } = new();

		[ContainerField(464)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get; set; } = new();

		[ContainerField(468)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get; set; } = new();

		[ContainerField(472)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get; set; } = new();

		[ContainerField(476)]
		public SpecialMovesBinding Binding { get; set; } = new();

		public static void Deserialize(SpecialMovesComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.SpecialMoveStateData.Deserialize(p_Instance.VaultOverHighState, p_Reader, p_Parser);
			fb.SpecialMoveStateData.Deserialize(p_Instance.VaultUpHighState, p_Reader, p_Parser);
			fb.SpecialMoveStateData.Deserialize(p_Instance.VaultOverLowState, p_Reader, p_Parser);
			fb.SpecialMoveStateData.Deserialize(p_Instance.SprintToProneState, p_Reader, p_Parser);
			fb.SpecialMoveStateData.Deserialize(p_Instance.DeathState, p_Reader, p_Parser);
			fb.SpecialMoveStateData.Deserialize(p_Instance.SpecialAnimationState, p_Reader, p_Parser);
			p_Instance.IndexedDeathStates.Clear();
			(RimeReader Reader, uint Count) s_IndexedDeathStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_IndexedDeathStates.Count; ++i)
			{
				var s_Value = new SpecialMoveStateData();
				fb.SpecialMoveStateData.Deserialize(s_Value, s_IndexedDeathStates.Reader, p_Parser);
				p_Instance.IndexedDeathStates.Add(s_Value);
			}
			
			s_IndexedDeathStates.Reader.Dispose();
			p_Instance.IndexedSpecialAnimationStates.Clear();
			(RimeReader Reader, uint Count) s_IndexedSpecialAnimationStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_IndexedSpecialAnimationStates.Count; ++i)
			{
				var s_Value = new SpecialMoveStateData();
				fb.SpecialMoveStateData.Deserialize(s_Value, s_IndexedSpecialAnimationStates.Reader, p_Parser);
				p_Instance.IndexedSpecialAnimationStates.Add(s_Value);
			}
			
			s_IndexedSpecialAnimationStates.Reader.Dispose();
			p_Instance.IndexedVaultOverHighStates.Clear();
			(RimeReader Reader, uint Count) s_IndexedVaultOverHighStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_IndexedVaultOverHighStates.Count; ++i)
			{
				var s_Value = new SpecialMoveVaultStateCriteria();
				fb.SpecialMoveVaultStateCriteria.Deserialize(s_Value, s_IndexedVaultOverHighStates.Reader, p_Parser);
				p_Instance.IndexedVaultOverHighStates.Add(s_Value);
			}
			
			s_IndexedVaultOverHighStates.Reader.Dispose();
			p_Instance.IndexedVaultUpStates.Clear();
			(RimeReader Reader, uint Count) s_IndexedVaultUpStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_IndexedVaultUpStates.Count; ++i)
			{
				var s_Value = new SpecialMoveVaultStateCriteria();
				fb.SpecialMoveVaultStateCriteria.Deserialize(s_Value, s_IndexedVaultUpStates.Reader, p_Parser);
				p_Instance.IndexedVaultUpStates.Add(s_Value);
			}
			
			s_IndexedVaultUpStates.Reader.Dispose();
			p_Instance.IndexedVaultOverLowStates.Clear();
			(RimeReader Reader, uint Count) s_IndexedVaultOverLowStates = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_IndexedVaultOverLowStates.Count; ++i)
			{
				var s_Value = new SpecialMoveVaultStateCriteria();
				fb.SpecialMoveVaultStateCriteria.Deserialize(s_Value, s_IndexedVaultOverLowStates.Reader, p_Parser);
				p_Instance.IndexedVaultOverLowStates.Add(s_Value);
			}
			
			s_IndexedVaultOverLowStates.Reader.Dispose();
			fb.SpecialMovesBinding.Deserialize(p_Instance.Binding, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
