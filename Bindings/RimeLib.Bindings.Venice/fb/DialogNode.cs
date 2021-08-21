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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 60)]
	public class DialogNode : 
		StateNode
	{
		protected string m_DialogTitle = string.Empty;
		[ContainerField(Name: "DialogTitle", Offset: 48, NameHash: 3325016493, Flags: 16509), LayoutImmutable]
		public string DialogTitle { get { return m_DialogTitle; } set { if (OnPropertyChanging("DialogNode." + nameof(DialogTitle), this, m_DialogTitle, value)) m_DialogTitle = value; } } // 0x30 (48)
		
		protected string m_DialogText = string.Empty;
		[ContainerField(Name: "DialogText", Offset: 52, NameHash: 4005286480, Flags: 16509), LayoutImmutable]
		public string DialogText { get { return m_DialogText; } set { if (OnPropertyChanging("DialogNode." + nameof(DialogText), this, m_DialogText, value)) m_DialogText = value; } } // 0x34 (52)
		
		protected List<UIPopupButton> m_Buttons = new List<UIPopupButton>();
		[ContainerField(Name: "Buttons", Offset: 56, NameHash: 2744663360, Flags: 65)]
		public List<UIPopupButton> Buttons { get { return m_Buttons; } set { if (OnPropertyChanging("DialogNode." + nameof(Buttons), this, m_Buttons, value)) m_Buttons = value; } } // 0x38 (56)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3325016493:
					DialogTitle = (string) p_Value;
					break;

				case 4005286480:
					DialogText = (string) p_Value;
					break;

				case 2744663360:
					Buttons = (List<UIPopupButton>) p_Value;
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
				case 3325016493:
					return DialogTitle;

				case 4005286480:
					return DialogText;

				case 2744663360:
					return Buttons;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3325016493:
					return typeof(DialogNode).GetProperty(nameof(DialogTitle));

				case 4005286480:
					return typeof(DialogNode).GetProperty(nameof(DialogText));

				case 2744663360:
					return typeof(DialogNode).GetProperty(nameof(Buttons));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
