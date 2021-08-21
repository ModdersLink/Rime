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
	public class DynamicDataContainer : 
		DataContainer
	{
		protected List<DataField> m_Fields = new List<DataField>();
		[ContainerField(Name: "Fields", Offset: 8, NameHash: 2525411604, Flags: 65)]
		public List<DataField> Fields { get { return m_Fields; } set { if (OnPropertyChanging("DynamicDataContainer." + nameof(Fields), this, m_Fields, value)) m_Fields = value; } } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2525411604:
					Fields = (List<DataField>) p_Value;
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
				case 2525411604:
					return Fields;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2525411604:
					return typeof(DynamicDataContainer).GetProperty(nameof(Fields));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
