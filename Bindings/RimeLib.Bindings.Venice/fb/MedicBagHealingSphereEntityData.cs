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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 272)]
	public class MedicBagHealingSphereEntityData : 
		ExplosionPackEntityData
	{
		protected HealingSphereData m_Healer = new HealingSphereData();
		[ContainerField(Name: "Healer", Offset: 256, NameHash: 3054336626, Flags: 41)]
		public HealingSphereData Healer { get { return m_Healer; } set { if (OnPropertyChanging("MedicBagHealingSphereEntityData." + nameof(Healer), this, m_Healer, value)) m_Healer = value; } } // 0x100 (256)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054336626:
					Healer = (HealingSphereData) p_Value;
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
				case 3054336626:
					return Healer;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054336626:
					return typeof(MedicBagHealingSphereEntityData).GetProperty(nameof(Healer));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
