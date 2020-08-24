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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class WeaponMagazineModifier : 
		WeaponModifierBase
	{
		protected int m_MagazineCapacity = new int();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1634670339)]
		public int MagazineCapacity { get { return m_MagazineCapacity; } set { if (OnPropertyChanging("WeaponMagazineModifier." + nameof(MagazineCapacity), this, m_MagazineCapacity, value)) m_MagazineCapacity = value; } } // 0x8 (8)
		
		protected int m_NumberOfMagazines = new int();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(2684433166)]
		public int NumberOfMagazines { get { return m_NumberOfMagazines; } set { if (OnPropertyChanging("WeaponMagazineModifier." + nameof(NumberOfMagazines), this, m_NumberOfMagazines, value)) m_NumberOfMagazines = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1634670339:
					MagazineCapacity = (int) p_Value;
					break;

				case 2684433166:
					NumberOfMagazines = (int) p_Value;
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
				case 1634670339:
					return MagazineCapacity;

				case 2684433166:
					return NumberOfMagazines;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1634670339:
					return typeof(WeaponMagazineModifier).GetProperty(nameof(MagazineCapacity));

				case 2684433166:
					return typeof(WeaponMagazineModifier).GetProperty(nameof(NumberOfMagazines));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
