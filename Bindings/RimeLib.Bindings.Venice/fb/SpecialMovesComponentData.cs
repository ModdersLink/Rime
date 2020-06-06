///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SpecialMovesComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public SpecialMoveStateData VaultOverHighState { get; set; } = new SpecialMoveStateData(); // 0x60 (96)
		
		[ContainerField(156)]
		public SpecialMoveStateData VaultUpHighState { get; set; } = new SpecialMoveStateData(); // 0x9C (156)
		
		[ContainerField(216)]
		public SpecialMoveStateData VaultOverLowState { get; set; } = new SpecialMoveStateData(); // 0xD8 (216)
		
		[ContainerField(276)]
		public SpecialMoveStateData SprintToProneState { get; set; } = new SpecialMoveStateData(); // 0x114 (276)
		
		[ContainerField(336)]
		public SpecialMoveStateData DeathState { get; set; } = new SpecialMoveStateData(); // 0x150 (336)
		
		[ContainerField(396)]
		public SpecialMoveStateData SpecialAnimationState { get; set; } = new SpecialMoveStateData(); // 0x18C (396)
		
		[ContainerField(456)]
		public List<SpecialMoveStateData> IndexedDeathStates { get; set; } = new List<SpecialMoveStateData>(); // 0x1C8 (456)
		
		[ContainerField(460)]
		public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get; set; } = new List<SpecialMoveStateData>(); // 0x1CC (460)
		
		[ContainerField(464)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get; set; } = new List<SpecialMoveVaultStateCriteria>(); // 0x1D0 (464)
		
		[ContainerField(468)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get; set; } = new List<SpecialMoveVaultStateCriteria>(); // 0x1D4 (468)
		
		[ContainerField(472)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get; set; } = new List<SpecialMoveVaultStateCriteria>(); // 0x1D8 (472)
		
		[ContainerField(476)]
		public SpecialMovesBinding Binding { get; set; } = new SpecialMovesBinding(); // 0x1DC (476)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2753012104:
					VaultOverHighState = (SpecialMoveStateData) p_Value;
					break;

				case 1265978819:
					VaultUpHighState = (SpecialMoveStateData) p_Value;
					break;

				case 1161455314:
					VaultOverLowState = (SpecialMoveStateData) p_Value;
					break;

				case 2775746029:
					SprintToProneState = (SpecialMoveStateData) p_Value;
					break;

				case 4180335470:
					DeathState = (SpecialMoveStateData) p_Value;
					break;

				case 467878821:
					SpecialAnimationState = (SpecialMoveStateData) p_Value;
					break;

				case 1958491074:
					IndexedDeathStates = (List<SpecialMoveStateData>) p_Value;
					break;

				case 208626825:
					IndexedSpecialAnimationStates = (List<SpecialMoveStateData>) p_Value;
					break;

				case 2945169956:
					IndexedVaultOverHighStates = (List<SpecialMoveVaultStateCriteria>) p_Value;
					break;

				case 655182401:
					IndexedVaultUpStates = (List<SpecialMoveVaultStateCriteria>) p_Value;
					break;

				case 4065371102:
					IndexedVaultOverLowStates = (List<SpecialMoveVaultStateCriteria>) p_Value;
					break;

				case 2590060228:
					Binding = (SpecialMovesBinding) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2753012104:
					return VaultOverHighState;

				case 1265978819:
					return VaultUpHighState;

				case 1161455314:
					return VaultOverLowState;

				case 2775746029:
					return SprintToProneState;

				case 4180335470:
					return DeathState;

				case 467878821:
					return SpecialAnimationState;

				case 1958491074:
					return IndexedDeathStates;

				case 208626825:
					return IndexedSpecialAnimationStates;

				case 2945169956:
					return IndexedVaultOverHighStates;

				case 655182401:
					return IndexedVaultUpStates;

				case 4065371102:
					return IndexedVaultOverLowStates;

				case 2590060228:
					return Binding;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2753012104:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(VaultOverHighState));

				case 1265978819:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(VaultUpHighState));

				case 1161455314:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(VaultOverLowState));

				case 2775746029:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(SprintToProneState));

				case 4180335470:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(DeathState));

				case 467878821:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(SpecialAnimationState));

				case 1958491074:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(IndexedDeathStates));

				case 208626825:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(IndexedSpecialAnimationStates));

				case 2945169956:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(IndexedVaultOverHighStates));

				case 655182401:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(IndexedVaultUpStates));

				case 4065371102:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(IndexedVaultOverLowStates));

				case 2590060228:
					return typeof(SpecialMovesComponentData).GetProperty(nameof(Binding));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
