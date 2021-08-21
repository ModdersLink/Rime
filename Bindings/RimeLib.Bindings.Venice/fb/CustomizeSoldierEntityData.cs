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
	public class CustomizeSoldierEntityData : 
		CustomizeBaseEntityData
	{
		protected CtrRef<CustomizeSoldierData> m_CustomizeSoldierData = new CtrRef<CustomizeSoldierData>();
		[ContainerField(Name: "CustomizeSoldierData", Offset: 16, NameHash: 2875154650, Flags: 53)]
		public CtrRef<CustomizeSoldierData> CustomizeSoldierData { get { return m_CustomizeSoldierData; } set { if (OnPropertyChanging("CustomizeSoldierEntityData." + nameof(CustomizeSoldierData), this, m_CustomizeSoldierData, value)) m_CustomizeSoldierData = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2875154650:
					CustomizeSoldierData = (CtrRef<CustomizeSoldierData>) p_Value;
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
				case 2875154650:
					return CustomizeSoldierData;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2875154650:
					return typeof(CustomizeSoldierEntityData).GetProperty(nameof(CustomizeSoldierData));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
