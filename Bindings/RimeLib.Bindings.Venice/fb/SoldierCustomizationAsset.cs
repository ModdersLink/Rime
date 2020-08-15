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
	public class SoldierCustomizationAsset : 
		CharacterCustomizationAsset
	{
		protected CtrRef<CustomizationTable> m_WeaponTable = new CtrRef<CustomizationTable>();
		[ContainerField(32), ContainerFieldNameHash(731633497)]
		public CtrRef<CustomizationTable> WeaponTable { get { return m_WeaponTable; } set { if (OnPropertyChanging("SoldierCustomizationAsset." + nameof(WeaponTable), this, m_WeaponTable, value)) m_WeaponTable = value; } } // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 731633497:
					WeaponTable = (CtrRef<CustomizationTable>) p_Value;
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
				case 731633497:
					return WeaponTable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 731633497:
					return typeof(SoldierCustomizationAsset).GetProperty(nameof(WeaponTable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
