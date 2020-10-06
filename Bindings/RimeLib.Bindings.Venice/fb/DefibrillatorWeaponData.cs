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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(24), ContainerClass]
	public class DefibrillatorWeaponData : 
		WeaponData
	{
		protected float m_ReviveTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3083359915)]
		public float ReviveTime { get { return m_ReviveTime; } set { if (OnPropertyChanging("DefibrillatorWeaponData." + nameof(ReviveTime), this, m_ReviveTime, value)) m_ReviveTime = value; } } // 0x10 (16)
		
		protected float m_AttackTime = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1150936440)]
		public float AttackTime { get { return m_AttackTime; } set { if (OnPropertyChanging("DefibrillatorWeaponData." + nameof(AttackTime), this, m_AttackTime, value)) m_AttackTime = value; } } // 0x14 (20)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3083359915:
					ReviveTime = (float) p_Value;
					break;

				case 1150936440:
					AttackTime = (float) p_Value;
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
				case 3083359915:
					return ReviveTime;

				case 1150936440:
					return AttackTime;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3083359915:
					return typeof(DefibrillatorWeaponData).GetProperty(nameof(ReviveTime));

				case 1150936440:
					return typeof(DefibrillatorWeaponData).GetProperty(nameof(AttackTime));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
