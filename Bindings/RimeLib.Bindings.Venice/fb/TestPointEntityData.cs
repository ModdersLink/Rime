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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 112)]
	public class TestPointEntityData : 
		GameEntityData
	{
		protected string m_OutputName = string.Empty;
		[ContainerField(Name: "OutputName", Offset: 96, NameHash: 543054269, Flags: 16509), LayoutImmutable]
		public string OutputName { get { return m_OutputName; } set { if (OnPropertyChanging("TestPointEntityData." + nameof(OutputName), this, m_OutputName, value)) m_OutputName = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 543054269:
					OutputName = (string) p_Value;
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
				case 543054269:
					return OutputName;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 543054269:
					return typeof(TestPointEntityData).GetProperty(nameof(OutputName));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
