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
	public class OneOptionAxisEditableAction : 
		EditableAction
	{
		protected string m_Header = string.Empty;
		[ContainerField(12), LayoutImmutable, ContainerFieldNameHash(3054345338)]
		public string Header { get { return m_Header; } set { if (OnPropertyChanging("OneOptionAxisEditableAction." + nameof(Header), this, m_Header, value)) m_Header = value; } } // 0xC (12)
		
		protected bool m_Invert = new bool();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(2784486295)]
		public bool Invert { get { return m_Invert; } set { if (OnPropertyChanging("OneOptionAxisEditableAction." + nameof(Invert), this, m_Invert, value)) m_Invert = value; } } // 0x10 (16)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3054345338:
					Header = (string) p_Value;
					break;

				case 2784486295:
					Invert = (bool) p_Value;
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

				case 2784486295:
					return Invert;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3054345338:
					return typeof(OneOptionAxisEditableAction).GetProperty(nameof(Header));

				case 2784486295:
					return typeof(OneOptionAxisEditableAction).GetProperty(nameof(Invert));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
