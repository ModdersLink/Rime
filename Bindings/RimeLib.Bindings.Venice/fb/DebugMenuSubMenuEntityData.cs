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
	public class DebugMenuSubMenuEntityData : 
		GameEntityData
	{
		protected string m_Text = string.Empty;
		[ContainerField(Name: "Text", Offset: 96, NameHash: 2089309304, Flags: 16509), LayoutImmutable]
		public string Text { get { return m_Text; } set { if (OnPropertyChanging("DebugMenuSubMenuEntityData." + nameof(Text), this, m_Text, value)) m_Text = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2089309304:
					Text = (string) p_Value;
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
				case 2089309304:
					return Text;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2089309304:
					return typeof(DebugMenuSubMenuEntityData).GetProperty(nameof(Text));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
