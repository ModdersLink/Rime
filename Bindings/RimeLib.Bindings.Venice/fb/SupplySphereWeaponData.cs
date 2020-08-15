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
	public class SupplySphereWeaponData : 
		WeaponData
	{
		protected SupplyData m_SupplyData = new SupplyData();
		[ContainerField(16), ContainerFieldNameHash(3973739366)]
		public SupplyData SupplyData { get { return m_SupplyData; } set { if (OnPropertyChanging("SupplySphereWeaponData." + nameof(SupplyData), this, m_SupplyData, value)) m_SupplyData = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3973739366:
					SupplyData = (SupplyData) p_Value;
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
				case 3973739366:
					return SupplyData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3973739366:
					return typeof(SupplySphereWeaponData).GetProperty(nameof(SupplyData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
