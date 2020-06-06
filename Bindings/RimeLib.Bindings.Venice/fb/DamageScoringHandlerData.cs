///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DamageScoringHandlerData : 
		ScoringHandlerData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RepairVehicleLimit { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DamageTeamVehicleLimit { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float TeamHealingLimit { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float TeamDamageLimit { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float KillAssistLimit { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float KillAssistTimeout { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float VehicleDestroyAssistLimit { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float SaviorKillTimeout { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SaviorDamageLimit { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float HotVehicleTimeout { get; set; } // 0x2C (44)
		
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
