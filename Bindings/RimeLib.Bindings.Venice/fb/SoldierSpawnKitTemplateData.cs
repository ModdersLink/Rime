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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 20)]
	public class SoldierSpawnKitTemplateData : 
		Asset
	{
		protected uint m_Kit = new uint();
		[ContainerField(Name: "Kit", Offset: 12, NameHash: 193457363, Flags: 49421), LayoutImmutable, Blittable]
		public uint Kit { get { return m_Kit; } set { if (OnPropertyChanging("SoldierSpawnKitTemplateData." + nameof(Kit), this, m_Kit, value)) m_Kit = value; } } // 0xC (12)
		
		protected uint m_MainGun = new uint();
		[ContainerField(Name: "MainGun", Offset: 16, NameHash: 1295556050, Flags: 49421), LayoutImmutable, Blittable]
		public uint MainGun { get { return m_MainGun; } set { if (OnPropertyChanging("SoldierSpawnKitTemplateData." + nameof(MainGun), this, m_MainGun, value)) m_MainGun = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 193457363:
					Kit = (uint) p_Value;
					break;

				case 1295556050:
					MainGun = (uint) p_Value;
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
				case 193457363:
					return Kit;

				case 1295556050:
					return MainGun;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 193457363:
					return typeof(SoldierSpawnKitTemplateData).GetProperty(nameof(Kit));

				case 1295556050:
					return typeof(SoldierSpawnKitTemplateData).GetProperty(nameof(MainGun));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
