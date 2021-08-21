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
	public class MeleeEntityCommonData : 
		Asset
	{
		protected CharacterMeleeBinding m_MeleeBinding = new CharacterMeleeBinding();
		[ContainerField(Name: "MeleeBinding", Offset: 12, NameHash: 3448558112, Flags: 41)]
		public CharacterMeleeBinding MeleeBinding { get { return m_MeleeBinding; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(MeleeBinding), this, m_MeleeBinding, value)) m_MeleeBinding = value; } } // 0xC (12)
		
		protected CharacterMeleeCommonBinding m_MeleeCommonBinding = new CharacterMeleeCommonBinding();
		[ContainerField(Name: "MeleeCommonBinding", Offset: 28, NameHash: 4111040973, Flags: 41)]
		public CharacterMeleeCommonBinding MeleeCommonBinding { get { return m_MeleeCommonBinding; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(MeleeCommonBinding), this, m_MeleeCommonBinding, value)) m_MeleeCommonBinding = value; } } // 0x1C (28)
		
		protected float m_TriggerDelay = new float();
		[ContainerField(Name: "TriggerDelay", Offset: 56, NameHash: 3587015816, Flags: 49469), LayoutImmutable, Blittable]
		public float TriggerDelay { get { return m_TriggerDelay; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(TriggerDelay), this, m_TriggerDelay, value)) m_TriggerDelay = value; } } // 0x38 (56)
		
		protected float m_DefendWindow = new float();
		[ContainerField(Name: "DefendWindow", Offset: 60, NameHash: 3425275393, Flags: 49469), LayoutImmutable, Blittable]
		public float DefendWindow { get { return m_DefendWindow; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(DefendWindow), this, m_DefendWindow, value)) m_DefendWindow = value; } } // 0x3C (60)
		
		protected float m_KillDelay = new float();
		[ContainerField(Name: "KillDelay", Offset: 64, NameHash: 1421072114, Flags: 49469), LayoutImmutable, Blittable]
		public float KillDelay { get { return m_KillDelay; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(KillDelay), this, m_KillDelay, value)) m_KillDelay = value; } } // 0x40 (64)
		
		protected float m_MeleeEndDelay = new float();
		[ContainerField(Name: "MeleeEndDelay", Offset: 68, NameHash: 961486747, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeEndDelay { get { return m_MeleeEndDelay; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(MeleeEndDelay), this, m_MeleeEndDelay, value)) m_MeleeEndDelay = value; } } // 0x44 (68)
		
		protected float m_InvalidMeleeAttackZone = new float();
		[ContainerField(Name: "InvalidMeleeAttackZone", Offset: 72, NameHash: 2448591846, Flags: 49469), LayoutImmutable, Blittable]
		public float InvalidMeleeAttackZone { get { return m_InvalidMeleeAttackZone; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(InvalidMeleeAttackZone), this, m_InvalidMeleeAttackZone, value)) m_InvalidMeleeAttackZone = value; } } // 0x48 (72)
		
		protected float m_MeleeAttackDistance = new float();
		[ContainerField(Name: "MeleeAttackDistance", Offset: 76, NameHash: 1761928522, Flags: 49469), LayoutImmutable, Blittable]
		public float MeleeAttackDistance { get { return m_MeleeAttackDistance; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(MeleeAttackDistance), this, m_MeleeAttackDistance, value)) m_MeleeAttackDistance = value; } } // 0x4C (76)
		
		protected float m_MaxAttackHeightDifference = new float();
		[ContainerField(Name: "MaxAttackHeightDifference", Offset: 80, NameHash: 2329749681, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAttackHeightDifference { get { return m_MaxAttackHeightDifference; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(MaxAttackHeightDifference), this, m_MaxAttackHeightDifference, value)) m_MaxAttackHeightDifference = value; } } // 0x50 (80)
		
		protected float m_KillDamage = new float();
		[ContainerField(Name: "KillDamage", Offset: 84, NameHash: 3941210028, Flags: 49469), LayoutImmutable, Blittable]
		public float KillDamage { get { return m_KillDamage; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(KillDamage), this, m_KillDamage, value)) m_KillDamage = value; } } // 0x54 (84)
		
		protected CtrRef<AntEnumeration> m_ProneAttackType = new CtrRef<AntEnumeration>();
		[ContainerField(Name: "ProneAttackType", Offset: 88, NameHash: 585847923, Flags: 53)]
		public CtrRef<AntEnumeration> ProneAttackType { get { return m_ProneAttackType; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(ProneAttackType), this, m_ProneAttackType, value)) m_ProneAttackType = value; } } // 0x58 (88)
		
		protected CtrRef<AntEnumeration> m_CrouchAttackType = new CtrRef<AntEnumeration>();
		[ContainerField(Name: "CrouchAttackType", Offset: 92, NameHash: 4016355349, Flags: 53)]
		public CtrRef<AntEnumeration> CrouchAttackType { get { return m_CrouchAttackType; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(CrouchAttackType), this, m_CrouchAttackType, value)) m_CrouchAttackType = value; } } // 0x5C (92)
		
		protected bool m_EnableAbortPossibility = new bool();
		[ContainerField(Name: "EnableAbortPossibility", Offset: 96, NameHash: 746614459, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableAbortPossibility { get { return m_EnableAbortPossibility; } set { if (OnPropertyChanging("MeleeEntityCommonData." + nameof(EnableAbortPossibility), this, m_EnableAbortPossibility, value)) m_EnableAbortPossibility = value; } } // 0x60 (96)
		
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
