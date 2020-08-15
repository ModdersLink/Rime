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
	[ContainerType(4)]
	public class ShootAtFromCoverData : 
		EntityData
	{
		protected StrengthType m_StrengthType = new StrengthType();
		[ContainerField(12), ContainerFieldNameHash(4037075576)]
		public StrengthType StrengthType { get { return m_StrengthType; } set { if (OnPropertyChanging("ShootAtFromCoverData." + nameof(StrengthType), this, m_StrengthType, value)) m_StrengthType = value; } } // 0xC (12)
		
		protected ShootType m_ShootType = new ShootType();
		[ContainerField(16), ContainerFieldNameHash(2888956146)]
		public ShootType ShootType { get { return m_ShootType; } set { if (OnPropertyChanging("ShootAtFromCoverData." + nameof(ShootType), this, m_ShootType, value)) m_ShootType = value; } } // 0x10 (16)
		
		protected bool m_CycleTargets = new bool();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(2182019831)]
		public bool CycleTargets { get { return m_CycleTargets; } set { if (OnPropertyChanging("ShootAtFromCoverData." + nameof(CycleTargets), this, m_CycleTargets, value)) m_CycleTargets = value; } } // 0x14 (20)
		
		protected bool m_RandomTargetOrder = new bool();
		[ContainerField(21), LayoutImmutable, Blittable, ContainerFieldNameHash(1044980993)]
		public bool RandomTargetOrder { get { return m_RandomTargetOrder; } set { if (OnPropertyChanging("ShootAtFromCoverData." + nameof(RandomTargetOrder), this, m_RandomTargetOrder, value)) m_RandomTargetOrder = value; } } // 0x15 (21)
		
		protected bool m_PreferAlternativeWeapon = new bool();
		[ContainerField(22), LayoutImmutable, Blittable, ContainerFieldNameHash(2914787134)]
		public bool PreferAlternativeWeapon { get { return m_PreferAlternativeWeapon; } set { if (OnPropertyChanging("ShootAtFromCoverData." + nameof(PreferAlternativeWeapon), this, m_PreferAlternativeWeapon, value)) m_PreferAlternativeWeapon = value; } } // 0x16 (22)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4037075576:
					StrengthType = (StrengthType) Enum.ToObject(typeof(StrengthType), p_Value);
					break;

				case 2888956146:
					ShootType = (ShootType) Enum.ToObject(typeof(ShootType), p_Value);
					break;

				case 2182019831:
					CycleTargets = (bool) p_Value;
					break;

				case 1044980993:
					RandomTargetOrder = (bool) p_Value;
					break;

				case 2914787134:
					PreferAlternativeWeapon = (bool) p_Value;
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
				case 4037075576:
					return StrengthType;

				case 2888956146:
					return ShootType;

				case 2182019831:
					return CycleTargets;

				case 1044980993:
					return RandomTargetOrder;

				case 2914787134:
					return PreferAlternativeWeapon;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4037075576:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(StrengthType));

				case 2888956146:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(ShootType));

				case 2182019831:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(CycleTargets));

				case 1044980993:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(RandomTargetOrder));

				case 2914787134:
					return typeof(ShootAtFromCoverData).GetProperty(nameof(PreferAlternativeWeapon));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
