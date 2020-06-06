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
	public class MeleeEntityCommonData : 
		Asset
	{
		[ContainerField(12)]
		public CharacterMeleeBinding MeleeBinding { get; set; } = new CharacterMeleeBinding(); // 0xC (12)
		
		[ContainerField(28)]
		public CharacterMeleeCommonBinding MeleeCommonBinding { get; set; } = new CharacterMeleeCommonBinding(); // 0x1C (28)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float TriggerDelay { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float DefendWindow { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float KillDelay { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MeleeEndDelay { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float InvalidMeleeAttackZone { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float MeleeAttackDistance { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float MaxAttackHeightDifference { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float KillDamage { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public CtrRef<AntEnumeration> ProneAttackType { get; set; } = new CtrRef<AntEnumeration>(); // 0x58 (88)
		
		[ContainerField(92)]
		public CtrRef<AntEnumeration> CrouchAttackType { get; set; } = new CtrRef<AntEnumeration>(); // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool EnableAbortPossibility { get; set; } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3448558112:
					MeleeBinding = (CharacterMeleeBinding) p_Value;
					break;

				case 4111040973:
					MeleeCommonBinding = (CharacterMeleeCommonBinding) p_Value;
					break;

				case 3587015816:
					TriggerDelay = (float) p_Value;
					break;

				case 3425275393:
					DefendWindow = (float) p_Value;
					break;

				case 1421072114:
					KillDelay = (float) p_Value;
					break;

				case 961486747:
					MeleeEndDelay = (float) p_Value;
					break;

				case 2448591846:
					InvalidMeleeAttackZone = (float) p_Value;
					break;

				case 1761928522:
					MeleeAttackDistance = (float) p_Value;
					break;

				case 2329749681:
					MaxAttackHeightDifference = (float) p_Value;
					break;

				case 3941210028:
					KillDamage = (float) p_Value;
					break;

				case 585847923:
					ProneAttackType = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 4016355349:
					CrouchAttackType = (CtrRef<AntEnumeration>) p_Value;
					break;

				case 746614459:
					EnableAbortPossibility = (bool) p_Value;
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
				case 3448558112:
					return MeleeBinding;

				case 4111040973:
					return MeleeCommonBinding;

				case 3587015816:
					return TriggerDelay;

				case 3425275393:
					return DefendWindow;

				case 1421072114:
					return KillDelay;

				case 961486747:
					return MeleeEndDelay;

				case 2448591846:
					return InvalidMeleeAttackZone;

				case 1761928522:
					return MeleeAttackDistance;

				case 2329749681:
					return MaxAttackHeightDifference;

				case 3941210028:
					return KillDamage;

				case 585847923:
					return ProneAttackType;

				case 4016355349:
					return CrouchAttackType;

				case 746614459:
					return EnableAbortPossibility;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3448558112:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(MeleeBinding));

				case 4111040973:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(MeleeCommonBinding));

				case 3587015816:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(TriggerDelay));

				case 3425275393:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(DefendWindow));

				case 1421072114:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(KillDelay));

				case 961486747:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(MeleeEndDelay));

				case 2448591846:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(InvalidMeleeAttackZone));

				case 1761928522:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(MeleeAttackDistance));

				case 2329749681:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(MaxAttackHeightDifference));

				case 3941210028:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(KillDamage));

				case 585847923:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(ProneAttackType));

				case 4016355349:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(CrouchAttackType));

				case 746614459:
					return typeof(MeleeEntityCommonData).GetProperty(nameof(EnableAbortPossibility));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
