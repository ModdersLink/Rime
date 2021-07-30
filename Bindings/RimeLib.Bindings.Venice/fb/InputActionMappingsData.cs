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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 12)]
	public class InputActionMappingsData : 
		DataContainer
	{
		protected RefArray<InputActionMappingData> m_Mappings = new RefArray<InputActionMappingData>();
		[ContainerField(Name: "Mappings", Offset: 8, NameHash: 673881690, Flags: 65)]
		public RefArray<InputActionMappingData> Mappings { get { return m_Mappings; } set { if (OnPropertyChanging("InputActionMappingsData." + nameof(Mappings), this, m_Mappings, value)) m_Mappings = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 673881690:
					Mappings = (RefArray<InputActionMappingData>) p_Value;
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
				case 673881690:
					return Mappings;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 673881690:
					return typeof(InputActionMappingsData).GetProperty(nameof(Mappings));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
