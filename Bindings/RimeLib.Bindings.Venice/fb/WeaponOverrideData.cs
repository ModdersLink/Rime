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
	public class WeaponOverrideData : 
		DataContainer
	{
		protected CtrRef<DataContainer> m_Data = new CtrRef<DataContainer>();
		[ContainerField(Name: "Data", Offset: 8, NameHash: 2088730869, Flags: 53)]
		public CtrRef<DataContainer> Data { get { return m_Data; } set { if (OnPropertyChanging("WeaponOverrideData." + nameof(Data), this, m_Data, value)) m_Data = value; } } // 0x8 (8)
		
		protected List<WeaponOverrideValue> m_Values = new List<WeaponOverrideValue>();
		[ContainerField(Name: "Values", Offset: 12, NameHash: 3142410589, Flags: 65)]
		public List<WeaponOverrideValue> Values { get { return m_Values; } set { if (OnPropertyChanging("WeaponOverrideData." + nameof(Values), this, m_Values, value)) m_Values = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088730869:
					Data = (CtrRef<DataContainer>) p_Value;
					break;

				case 3142410589:
					Values = (List<WeaponOverrideValue>) p_Value;
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
				case 2088730869:
					return Data;

				case 3142410589:
					return Values;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088730869:
					return typeof(WeaponOverrideData).GetProperty(nameof(Data));

				case 3142410589:
					return typeof(WeaponOverrideData).GetProperty(nameof(Values));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
