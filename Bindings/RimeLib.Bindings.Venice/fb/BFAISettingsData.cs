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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 100)]
	public class BFAISettingsData : 
		AISettingsData
	{
		protected CtrRef<MovementConstantData> m_MovementConstants = new CtrRef<MovementConstantData>();
		[ContainerField(Name: "MovementConstants", Offset: 80, NameHash: 4256858251, Flags: 53)]
		public CtrRef<MovementConstantData> MovementConstants { get { return m_MovementConstants; } set { if (OnPropertyChanging("BFAISettingsData." + nameof(MovementConstants), this, m_MovementConstants, value)) m_MovementConstants = value; } } // 0x50 (80)
		
		protected CtrRef<TurretControlConstantData> m_TurretControlConstants = new CtrRef<TurretControlConstantData>();
		[ContainerField(Name: "TurretControlConstants", Offset: 84, NameHash: 1803214367, Flags: 53)]
		public CtrRef<TurretControlConstantData> TurretControlConstants { get { return m_TurretControlConstants; } set { if (OnPropertyChanging("BFAISettingsData." + nameof(TurretControlConstants), this, m_TurretControlConstants, value)) m_TurretControlConstants = value; } } // 0x54 (84)
		
		protected CtrRef<SearchAndDestroyConstantData> m_SearchAndDestroyConstants = new CtrRef<SearchAndDestroyConstantData>();
		[ContainerField(Name: "SearchAndDestroyConstants", Offset: 88, NameHash: 3710618575, Flags: 53)]
		public CtrRef<SearchAndDestroyConstantData> SearchAndDestroyConstants { get { return m_SearchAndDestroyConstants; } set { if (OnPropertyChanging("BFAISettingsData." + nameof(SearchAndDestroyConstants), this, m_SearchAndDestroyConstants, value)) m_SearchAndDestroyConstants = value; } } // 0x58 (88)
		
		protected CtrRef<FollowConstantData> m_FollowConstants = new CtrRef<FollowConstantData>();
		[ContainerField(Name: "FollowConstants", Offset: 92, NameHash: 3864754617, Flags: 53)]
		public CtrRef<FollowConstantData> FollowConstants { get { return m_FollowConstants; } set { if (OnPropertyChanging("BFAISettingsData." + nameof(FollowConstants), this, m_FollowConstants, value)) m_FollowConstants = value; } } // 0x5C (92)
		
		protected CtrRef<CombatConstantData> m_CombatConstants = new CtrRef<CombatConstantData>();
		[ContainerField(Name: "CombatConstants", Offset: 96, NameHash: 2495160158, Flags: 53)]
		public CtrRef<CombatConstantData> CombatConstants { get { return m_CombatConstants; } set { if (OnPropertyChanging("BFAISettingsData." + nameof(CombatConstants), this, m_CombatConstants, value)) m_CombatConstants = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4256858251:
					MovementConstants = (CtrRef<MovementConstantData>) p_Value;
					break;

				case 1803214367:
					TurretControlConstants = (CtrRef<TurretControlConstantData>) p_Value;
					break;

				case 3710618575:
					SearchAndDestroyConstants = (CtrRef<SearchAndDestroyConstantData>) p_Value;
					break;

				case 3864754617:
					FollowConstants = (CtrRef<FollowConstantData>) p_Value;
					break;

				case 2495160158:
					CombatConstants = (CtrRef<CombatConstantData>) p_Value;
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
				case 4256858251:
					return MovementConstants;

				case 1803214367:
					return TurretControlConstants;

				case 3710618575:
					return SearchAndDestroyConstants;

				case 3864754617:
					return FollowConstants;

				case 2495160158:
					return CombatConstants;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4256858251:
					return typeof(BFAISettingsData).GetProperty(nameof(MovementConstants));

				case 1803214367:
					return typeof(BFAISettingsData).GetProperty(nameof(TurretControlConstants));

				case 3710618575:
					return typeof(BFAISettingsData).GetProperty(nameof(SearchAndDestroyConstants));

				case 3864754617:
					return typeof(BFAISettingsData).GetProperty(nameof(FollowConstants));

				case 2495160158:
					return typeof(BFAISettingsData).GetProperty(nameof(CombatConstants));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
