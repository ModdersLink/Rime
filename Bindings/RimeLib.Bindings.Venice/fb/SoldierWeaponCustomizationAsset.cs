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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 16)]
	public class SoldierWeaponCustomizationAsset : 
		Asset
	{
		protected CtrRef<CustomizationTable> m_Customization = new CtrRef<CustomizationTable>();
		[ContainerField(Name: "Customization", Offset: 12, NameHash: 1998291608, Flags: 53)]
		public CtrRef<CustomizationTable> Customization { get { return m_Customization; } set { if (OnPropertyChanging("SoldierWeaponCustomizationAsset." + nameof(Customization), this, m_Customization, value)) m_Customization = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1998291608:
					Customization = (CtrRef<CustomizationTable>) p_Value;
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
				case 1998291608:
					return Customization;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1998291608:
					return typeof(SoldierWeaponCustomizationAsset).GetProperty(nameof(Customization));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
