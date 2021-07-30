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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 48)]
	public class DamageScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_RepairVehicleLimit = new float();
		[ContainerField(Name: "RepairVehicleLimit", Offset: 8, NameHash: 114758805, Flags: 49469), LayoutImmutable, Blittable]
		public float RepairVehicleLimit { get { return m_RepairVehicleLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(RepairVehicleLimit), this, m_RepairVehicleLimit, value)) m_RepairVehicleLimit = value; } } // 0x8 (8)
		
		protected float m_DamageTeamVehicleLimit = new float();
		[ContainerField(Name: "DamageTeamVehicleLimit", Offset: 12, NameHash: 3777295358, Flags: 49469), LayoutImmutable, Blittable]
		public float DamageTeamVehicleLimit { get { return m_DamageTeamVehicleLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(DamageTeamVehicleLimit), this, m_DamageTeamVehicleLimit, value)) m_DamageTeamVehicleLimit = value; } } // 0xC (12)
		
		protected float m_TeamHealingLimit = new float();
		[ContainerField(Name: "TeamHealingLimit", Offset: 16, NameHash: 3140344621, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamHealingLimit { get { return m_TeamHealingLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(TeamHealingLimit), this, m_TeamHealingLimit, value)) m_TeamHealingLimit = value; } } // 0x10 (16)
		
		protected float m_TeamDamageLimit = new float();
		[ContainerField(Name: "TeamDamageLimit", Offset: 20, NameHash: 2358643014, Flags: 49469), LayoutImmutable, Blittable]
		public float TeamDamageLimit { get { return m_TeamDamageLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(TeamDamageLimit), this, m_TeamDamageLimit, value)) m_TeamDamageLimit = value; } } // 0x14 (20)
		
		protected float m_KillAssistLimit = new float();
		[ContainerField(Name: "KillAssistLimit", Offset: 24, NameHash: 97298589, Flags: 49469), LayoutImmutable, Blittable]
		public float KillAssistLimit { get { return m_KillAssistLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(KillAssistLimit), this, m_KillAssistLimit, value)) m_KillAssistLimit = value; } } // 0x18 (24)
		
		protected float m_KillAssistTimeout = new float();
		[ContainerField(Name: "KillAssistTimeout", Offset: 28, NameHash: 3202038131, Flags: 49469), LayoutImmutable, Blittable]
		public float KillAssistTimeout { get { return m_KillAssistTimeout; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(KillAssistTimeout), this, m_KillAssistTimeout, value)) m_KillAssistTimeout = value; } } // 0x1C (28)
		
		protected float m_VehicleDestroyAssistLimit = new float();
		[ContainerField(Name: "VehicleDestroyAssistLimit", Offset: 32, NameHash: 1242125957, Flags: 49469), LayoutImmutable, Blittable]
		public float VehicleDestroyAssistLimit { get { return m_VehicleDestroyAssistLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(VehicleDestroyAssistLimit), this, m_VehicleDestroyAssistLimit, value)) m_VehicleDestroyAssistLimit = value; } } // 0x20 (32)
		
		protected float m_SaviorKillTimeout = new float();
		[ContainerField(Name: "SaviorKillTimeout", Offset: 36, NameHash: 3941596332, Flags: 49469), LayoutImmutable, Blittable]
		public float SaviorKillTimeout { get { return m_SaviorKillTimeout; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(SaviorKillTimeout), this, m_SaviorKillTimeout, value)) m_SaviorKillTimeout = value; } } // 0x24 (36)
		
		protected float m_SaviorDamageLimit = new float();
		[ContainerField(Name: "SaviorDamageLimit", Offset: 40, NameHash: 3932840587, Flags: 49469), LayoutImmutable, Blittable]
		public float SaviorDamageLimit { get { return m_SaviorDamageLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(SaviorDamageLimit), this, m_SaviorDamageLimit, value)) m_SaviorDamageLimit = value; } } // 0x28 (40)
		
		protected float m_HotVehicleTimeout = new float();
		[ContainerField(Name: "HotVehicleTimeout", Offset: 44, NameHash: 1202160117, Flags: 49469), LayoutImmutable, Blittable]
		public float HotVehicleTimeout { get { return m_HotVehicleTimeout; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(HotVehicleTimeout), this, m_HotVehicleTimeout, value)) m_HotVehicleTimeout = value; } } // 0x2C (44)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 114758805:
					RepairVehicleLimit = (float) p_Value;
					break;

				case 3777295358:
					DamageTeamVehicleLimit = (float) p_Value;
					break;

				case 3140344621:
					TeamHealingLimit = (float) p_Value;
					break;

				case 2358643014:
					TeamDamageLimit = (float) p_Value;
					break;

				case 97298589:
					KillAssistLimit = (float) p_Value;
					break;

				case 3202038131:
					KillAssistTimeout = (float) p_Value;
					break;

				case 1242125957:
					VehicleDestroyAssistLimit = (float) p_Value;
					break;

				case 3941596332:
					SaviorKillTimeout = (float) p_Value;
					break;

				case 3932840587:
					SaviorDamageLimit = (float) p_Value;
					break;

				case 1202160117:
					HotVehicleTimeout = (float) p_Value;
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
				case 114758805:
					return RepairVehicleLimit;

				case 3777295358:
					return DamageTeamVehicleLimit;

				case 3140344621:
					return TeamHealingLimit;

				case 2358643014:
					return TeamDamageLimit;

				case 97298589:
					return KillAssistLimit;

				case 3202038131:
					return KillAssistTimeout;

				case 1242125957:
					return VehicleDestroyAssistLimit;

				case 3941596332:
					return SaviorKillTimeout;

				case 3932840587:
					return SaviorDamageLimit;

				case 1202160117:
					return HotVehicleTimeout;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 114758805:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(RepairVehicleLimit));

				case 3777295358:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(DamageTeamVehicleLimit));

				case 3140344621:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(TeamHealingLimit));

				case 2358643014:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(TeamDamageLimit));

				case 97298589:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(KillAssistLimit));

				case 3202038131:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(KillAssistTimeout));

				case 1242125957:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(VehicleDestroyAssistLimit));

				case 3941596332:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(SaviorKillTimeout));

				case 3932840587:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(SaviorDamageLimit));

				case 1202160117:
					return typeof(DamageScoringHandlerData).GetProperty(nameof(HotVehicleTimeout));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
