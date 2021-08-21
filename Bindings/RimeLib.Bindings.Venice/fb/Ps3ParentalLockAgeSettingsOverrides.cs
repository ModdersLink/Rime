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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class Ps3ParentalLockAgeSettingsOverrides : 
		DataContainer
	{
		protected List<Ps3ParentalLockAgeSettingsForCountry> m_Overrides = new List<Ps3ParentalLockAgeSettingsForCountry>();
		[ContainerField(Name: "Overrides", Offset: 8, NameHash: 2465446370, Flags: 65)]
		public List<Ps3ParentalLockAgeSettingsForCountry> Overrides { get { return m_Overrides; } set { if (OnPropertyChanging("Ps3ParentalLockAgeSettingsOverrides." + nameof(Overrides), this, m_Overrides, value)) m_Overrides = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2465446370:
					Overrides = (List<Ps3ParentalLockAgeSettingsForCountry>) p_Value;
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
				case 2465446370:
					return Overrides;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2465446370:
					return typeof(Ps3ParentalLockAgeSettingsOverrides).GetProperty(nameof(Overrides));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
