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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 56)]
	public class ShootOrderEntityData : 
		BFOrderEntityData
	{
		protected StrengthType m_StrengthType = new StrengthType();
		[ContainerField(Name: "StrengthType", Offset: 40, NameHash: 4037075576, Flags: 137)]
		public StrengthType StrengthType { get { return m_StrengthType; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(StrengthType), this, m_StrengthType, value)) m_StrengthType = value; } } // 0x28 (40)
		
		protected PoseType m_Pose = new PoseType();
		[ContainerField(Name: "Pose", Offset: 44, NameHash: 2089458956, Flags: 137)]
		public PoseType Pose { get { return m_Pose; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(Pose), this, m_Pose, value)) m_Pose = value; } } // 0x2C (44)
		
		protected ShootType m_ShootType = new ShootType();
		[ContainerField(Name: "ShootType", Offset: 48, NameHash: 2888956146, Flags: 137)]
		public ShootType ShootType { get { return m_ShootType; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(ShootType), this, m_ShootType, value)) m_ShootType = value; } } // 0x30 (48)
		
		protected bool m_PreferAlternativeWeapon = new bool();
		[ContainerField(Name: "PreferAlternativeWeapon", Offset: 52, NameHash: 2914787134, Flags: 49325), LayoutImmutable, Blittable]
		public bool PreferAlternativeWeapon { get { return m_PreferAlternativeWeapon; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(PreferAlternativeWeapon), this, m_PreferAlternativeWeapon, value)) m_PreferAlternativeWeapon = value; } } // 0x34 (52)
		
		protected bool m_CompleteWhenHumanIsSensed = new bool();
		[ContainerField(Name: "CompleteWhenHumanIsSensed", Offset: 53, NameHash: 930658167, Flags: 49325), LayoutImmutable, Blittable]
		public bool CompleteWhenHumanIsSensed { get { return m_CompleteWhenHumanIsSensed; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(CompleteWhenHumanIsSensed), this, m_CompleteWhenHumanIsSensed, value)) m_CompleteWhenHumanIsSensed = value; } } // 0x35 (53)
		
		protected bool m_CycleTargets = new bool();
		[ContainerField(Name: "CycleTargets", Offset: 54, NameHash: 2182019831, Flags: 49325), LayoutImmutable, Blittable]
		public bool CycleTargets { get { return m_CycleTargets; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(CycleTargets), this, m_CycleTargets, value)) m_CycleTargets = value; } } // 0x36 (54)
		
		protected bool m_RandomTargetOrder = new bool();
		[ContainerField(Name: "RandomTargetOrder", Offset: 55, NameHash: 1044980993, Flags: 49325), LayoutImmutable, Blittable]
		public bool RandomTargetOrder { get { return m_RandomTargetOrder; } set { if (OnPropertyChanging("ShootOrderEntityData." + nameof(RandomTargetOrder), this, m_RandomTargetOrder, value)) m_RandomTargetOrder = value; } } // 0x37 (55)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4037075576:
					StrengthType = (StrengthType) Enum.ToObject(typeof(StrengthType), p_Value);
					break;

				case 2089458956:
					Pose = (PoseType) Enum.ToObject(typeof(PoseType), p_Value);
					break;

				case 2888956146:
					ShootType = (ShootType) Enum.ToObject(typeof(ShootType), p_Value);
					break;

				case 2914787134:
					PreferAlternativeWeapon = (bool) p_Value;
					break;

				case 930658167:
					CompleteWhenHumanIsSensed = (bool) p_Value;
					break;

				case 2182019831:
					CycleTargets = (bool) p_Value;
					break;

				case 1044980993:
					RandomTargetOrder = (bool) p_Value;
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

				case 2089458956:
					return Pose;

				case 2888956146:
					return ShootType;

				case 2914787134:
					return PreferAlternativeWeapon;

				case 930658167:
					return CompleteWhenHumanIsSensed;

				case 2182019831:
					return CycleTargets;

				case 1044980993:
					return RandomTargetOrder;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4037075576:
					return typeof(ShootOrderEntityData).GetProperty(nameof(StrengthType));

				case 2089458956:
					return typeof(ShootOrderEntityData).GetProperty(nameof(Pose));

				case 2888956146:
					return typeof(ShootOrderEntityData).GetProperty(nameof(ShootType));

				case 2914787134:
					return typeof(ShootOrderEntityData).GetProperty(nameof(PreferAlternativeWeapon));

				case 930658167:
					return typeof(ShootOrderEntityData).GetProperty(nameof(CompleteWhenHumanIsSensed));

				case 2182019831:
					return typeof(ShootOrderEntityData).GetProperty(nameof(CycleTargets));

				case 1044980993:
					return typeof(ShootOrderEntityData).GetProperty(nameof(RandomTargetOrder));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
