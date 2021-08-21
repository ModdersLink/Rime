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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class WeaponEntityData : 
		GameEntityData
	{
		protected List<WeaponStateData> m_WeaponStates = new List<WeaponStateData>();
		[ContainerField(Name: "WeaponStates", Offset: 96, NameHash: 2607587267, Flags: 65)]
		public List<WeaponStateData> WeaponStates { get { return m_WeaponStates; } set { if (OnPropertyChanging("WeaponEntityData." + nameof(WeaponStates), this, m_WeaponStates, value)) m_WeaponStates = value; } } // 0x60 (96)
		
		protected WeaponClassEnum m_WeaponClass = new WeaponClassEnum();
		[ContainerField(Name: "WeaponClass", Offset: 100, NameHash: 711657993, Flags: 137)]
		public WeaponClassEnum WeaponClass { get { return m_WeaponClass; } set { if (OnPropertyChanging("WeaponEntityData." + nameof(WeaponClass), this, m_WeaponClass, value)) m_WeaponClass = value; } } // 0x64 (100)
		
		protected CtrRef<GameAIWeaponData> m_AIData = new CtrRef<GameAIWeaponData>();
		[ContainerField(Name: "AIData", Offset: 104, NameHash: 2529950045, Flags: 53)]
		public CtrRef<GameAIWeaponData> AIData { get { return m_AIData; } set { if (OnPropertyChanging("WeaponEntityData." + nameof(AIData), this, m_AIData, value)) m_AIData = value; } } // 0x68 (104)
		
		protected CtrRef<WeaponFiringData> m_WeaponFiring = new CtrRef<WeaponFiringData>();
		[ContainerField(Name: "WeaponFiring", Offset: 108, NameHash: 1823157050, Flags: 53)]
		public CtrRef<WeaponFiringData> WeaponFiring { get { return m_WeaponFiring; } set { if (OnPropertyChanging("WeaponEntityData." + nameof(WeaponFiring), this, m_WeaponFiring, value)) m_WeaponFiring = value; } } // 0x6C (108)
		
		protected CtrRef<WeaponData> m_CustomWeaponType = new CtrRef<WeaponData>();
		[ContainerField(Name: "CustomWeaponType", Offset: 112, NameHash: 3603058156, Flags: 53)]
		public CtrRef<WeaponData> CustomWeaponType { get { return m_CustomWeaponType; } set { if (OnPropertyChanging("WeaponEntityData." + nameof(CustomWeaponType), this, m_CustomWeaponType, value)) m_CustomWeaponType = value; } } // 0x70 (112)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2607587267:
					WeaponStates = (List<WeaponStateData>) p_Value;
					break;

				case 711657993:
					WeaponClass = (WeaponClassEnum) Enum.ToObject(typeof(WeaponClassEnum), p_Value);
					break;

				case 2529950045:
					AIData = (CtrRef<GameAIWeaponData>) p_Value;
					break;

				case 1823157050:
					WeaponFiring = (CtrRef<WeaponFiringData>) p_Value;
					break;

				case 3603058156:
					CustomWeaponType = (CtrRef<WeaponData>) p_Value;
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
				case 2607587267:
					return WeaponStates;

				case 711657993:
					return WeaponClass;

				case 2529950045:
					return AIData;

				case 1823157050:
					return WeaponFiring;

				case 3603058156:
					return CustomWeaponType;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2607587267:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponStates));

				case 711657993:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponClass));

				case 2529950045:
					return typeof(WeaponEntityData).GetProperty(nameof(AIData));

				case 1823157050:
					return typeof(WeaponEntityData).GetProperty(nameof(WeaponFiring));

				case 3603058156:
					return typeof(WeaponEntityData).GetProperty(nameof(CustomWeaponType));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
