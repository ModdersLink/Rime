///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class DialogNode : 
		StateNode
	{
		[ContainerField(48), LayoutImmutable]
		public string DialogTitle { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable]
		public string DialogText { get; set; } // 0x34 (52)
		
		[ContainerField(56)]
		public List<UIPopupButton> Buttons { get; set; } = new List<UIPopupButton>(); // 0x38 (56)
		
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
