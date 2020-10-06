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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(48), ContainerClass]
	public class DamageScoringHandlerData : 
		ScoringHandlerData
	{
		protected float m_RepairVehicleLimit = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(114758805)]
		public float RepairVehicleLimit { get { return m_RepairVehicleLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(RepairVehicleLimit), this, m_RepairVehicleLimit, value)) m_RepairVehicleLimit = value; } } // 0x8 (8)
		
		protected float m_DamageTeamVehicleLimit = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3777295358)]
		public float DamageTeamVehicleLimit { get { return m_DamageTeamVehicleLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(DamageTeamVehicleLimit), this, m_DamageTeamVehicleLimit, value)) m_DamageTeamVehicleLimit = value; } } // 0xC (12)
		
		protected float m_TeamHealingLimit = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3140344621)]
		public float TeamHealingLimit { get { return m_TeamHealingLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(TeamHealingLimit), this, m_TeamHealingLimit, value)) m_TeamHealingLimit = value; } } // 0x10 (16)
		
		protected float m_TeamDamageLimit = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2358643014)]
		public float TeamDamageLimit { get { return m_TeamDamageLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(TeamDamageLimit), this, m_TeamDamageLimit, value)) m_TeamDamageLimit = value; } } // 0x14 (20)
		
		protected float m_KillAssistLimit = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(97298589)]
		public float KillAssistLimit { get { return m_KillAssistLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(KillAssistLimit), this, m_KillAssistLimit, value)) m_KillAssistLimit = value; } } // 0x18 (24)
		
		protected float m_KillAssistTimeout = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3202038131)]
		public float KillAssistTimeout { get { return m_KillAssistTimeout; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(KillAssistTimeout), this, m_KillAssistTimeout, value)) m_KillAssistTimeout = value; } } // 0x1C (28)
		
		protected float m_VehicleDestroyAssistLimit = new float();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1242125957)]
		public float VehicleDestroyAssistLimit { get { return m_VehicleDestroyAssistLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(VehicleDestroyAssistLimit), this, m_VehicleDestroyAssistLimit, value)) m_VehicleDestroyAssistLimit = value; } } // 0x20 (32)
		
		protected float m_SaviorKillTimeout = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3941596332)]
		public float SaviorKillTimeout { get { return m_SaviorKillTimeout; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(SaviorKillTimeout), this, m_SaviorKillTimeout, value)) m_SaviorKillTimeout = value; } } // 0x24 (36)
		
		protected float m_SaviorDamageLimit = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3932840587)]
		public float SaviorDamageLimit { get { return m_SaviorDamageLimit; } set { if (OnPropertyChanging("DamageScoringHandlerData." + nameof(SaviorDamageLimit), this, m_SaviorDamageLimit, value)) m_SaviorDamageLimit = value; } } // 0x28 (40)
		
		protected float m_HotVehicleTimeout = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1202160117)]
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
