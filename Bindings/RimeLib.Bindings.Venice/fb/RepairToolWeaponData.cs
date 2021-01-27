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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 40)]
	public class RepairToolWeaponData : 
		PowerToolWeaponData
	{
		protected float m_RechargeSpeed = new float();
		[ContainerField(Name: "RechargeSpeed", Offset: 36, NameHash: 171564847, Flags: 49469), LayoutImmutable, Blittable]
		public float RechargeSpeed { get { return m_RechargeSpeed; } set { if (OnPropertyChanging("RepairToolWeaponData." + nameof(RechargeSpeed), this, m_RechargeSpeed, value)) m_RechargeSpeed = value; } } // 0x24 (36)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 171564847:
					RechargeSpeed = (float) p_Value;
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
				case 171564847:
					return RechargeSpeed;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 171564847:
					return typeof(RepairToolWeaponData).GetProperty(nameof(RechargeSpeed));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
