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
	public class OneOptionButtonEditableAction : 
		EditableAction
	{
		protected string m_Header = string.Empty;
		[ContainerField(Name: "Header", Offset: 12, NameHash: 3054345338, Flags: 16509), LayoutImmutable]
		public string Header { get { return m_Header; } set { if (OnPropertyChanging("OneOptionButtonEditableAction." + nameof(Header), this, m_Header, value)) m_Header = value; } } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054345338:
					Header = (string) p_Value;
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
				case 3054345338:
					return Header;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054345338:
					return typeof(OneOptionButtonEditableAction).GetProperty(nameof(Header));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
