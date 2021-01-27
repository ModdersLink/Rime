///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 528)]
	public class SpecialMovesComponentData : 
		ComponentData
	{
		protected SpecialMoveStateData m_VaultOverHighState = new SpecialMoveStateData();
		[ContainerField(Name: "VaultOverHighState", Offset: 96, NameHash: 2753012104, Flags: 41)]
		public SpecialMoveStateData VaultOverHighState { get { return m_VaultOverHighState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(VaultOverHighState), this, m_VaultOverHighState, value)) m_VaultOverHighState = value; } } // 0x60 (96)
		
		protected SpecialMoveStateData m_VaultUpHighState = new SpecialMoveStateData();
		[ContainerField(Name: "VaultUpHighState", Offset: 156, NameHash: 1265978819, Flags: 41)]
		public SpecialMoveStateData VaultUpHighState { get { return m_VaultUpHighState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(VaultUpHighState), this, m_VaultUpHighState, value)) m_VaultUpHighState = value; } } // 0x9C (156)
		
		protected SpecialMoveStateData m_VaultOverLowState = new SpecialMoveStateData();
		[ContainerField(Name: "VaultOverLowState", Offset: 216, NameHash: 1161455314, Flags: 41)]
		public SpecialMoveStateData VaultOverLowState { get { return m_VaultOverLowState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(VaultOverLowState), this, m_VaultOverLowState, value)) m_VaultOverLowState = value; } } // 0xD8 (216)
		
		protected SpecialMoveStateData m_SprintToProneState = new SpecialMoveStateData();
		[ContainerField(Name: "SprintToProneState", Offset: 276, NameHash: 2775746029, Flags: 41)]
		public SpecialMoveStateData SprintToProneState { get { return m_SprintToProneState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(SprintToProneState), this, m_SprintToProneState, value)) m_SprintToProneState = value; } } // 0x114 (276)
		
		protected SpecialMoveStateData m_DeathState = new SpecialMoveStateData();
		[ContainerField(Name: "DeathState", Offset: 336, NameHash: 4180335470, Flags: 41)]
		public SpecialMoveStateData DeathState { get { return m_DeathState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(DeathState), this, m_DeathState, value)) m_DeathState = value; } } // 0x150 (336)
		
		protected SpecialMoveStateData m_SpecialAnimationState = new SpecialMoveStateData();
		[ContainerField(Name: "SpecialAnimationState", Offset: 396, NameHash: 467878821, Flags: 41)]
		public SpecialMoveStateData SpecialAnimationState { get { return m_SpecialAnimationState; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(SpecialAnimationState), this, m_SpecialAnimationState, value)) m_SpecialAnimationState = value; } } // 0x18C (396)
		
		protected List<SpecialMoveStateData> m_IndexedDeathStates = new List<SpecialMoveStateData>();
		[ContainerField(Name: "IndexedDeathStates", Offset: 456, NameHash: 1958491074, Flags: 65)]
		public List<SpecialMoveStateData> IndexedDeathStates { get { return m_IndexedDeathStates; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(IndexedDeathStates), this, m_IndexedDeathStates, value)) m_IndexedDeathStates = value; } } // 0x1C8 (456)
		
		protected List<SpecialMoveStateData> m_IndexedSpecialAnimationStates = new List<SpecialMoveStateData>();
		[ContainerField(Name: "IndexedSpecialAnimationStates", Offset: 460, NameHash: 208626825, Flags: 65)]
		public List<SpecialMoveStateData> IndexedSpecialAnimationStates { get { return m_IndexedSpecialAnimationStates; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(IndexedSpecialAnimationStates), this, m_IndexedSpecialAnimationStates, value)) m_IndexedSpecialAnimationStates = value; } } // 0x1CC (460)
		
		protected List<SpecialMoveVaultStateCriteria> m_IndexedVaultOverHighStates = new List<SpecialMoveVaultStateCriteria>();
		[ContainerField(Name: "IndexedVaultOverHighStates", Offset: 464, NameHash: 2945169956, Flags: 65)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverHighStates { get { return m_IndexedVaultOverHighStates; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(IndexedVaultOverHighStates), this, m_IndexedVaultOverHighStates, value)) m_IndexedVaultOverHighStates = value; } } // 0x1D0 (464)
		
		protected List<SpecialMoveVaultStateCriteria> m_IndexedVaultUpStates = new List<SpecialMoveVaultStateCriteria>();
		[ContainerField(Name: "IndexedVaultUpStates", Offset: 468, NameHash: 655182401, Flags: 65)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultUpStates { get { return m_IndexedVaultUpStates; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(IndexedVaultUpStates), this, m_IndexedVaultUpStates, value)) m_IndexedVaultUpStates = value; } } // 0x1D4 (468)
		
		protected List<SpecialMoveVaultStateCriteria> m_IndexedVaultOverLowStates = new List<SpecialMoveVaultStateCriteria>();
		[ContainerField(Name: "IndexedVaultOverLowStates", Offset: 472, NameHash: 4065371102, Flags: 65)]
		public List<SpecialMoveVaultStateCriteria> IndexedVaultOverLowStates { get { return m_IndexedVaultOverLowStates; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(IndexedVaultOverLowStates), this, m_IndexedVaultOverLowStates, value)) m_IndexedVaultOverLowStates = value; } } // 0x1D8 (472)
		
		protected SpecialMovesBinding m_Binding = new SpecialMovesBinding();
		[ContainerField(Name: "Binding", Offset: 476, NameHash: 2590060228, Flags: 41)]
		public SpecialMovesBinding Binding { get { return m_Binding; } set { if (OnPropertyChanging("SpecialMovesComponentData." + nameof(Binding), this, m_Binding, value)) m_Binding = value; } } // 0x1DC (476)
		
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
