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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 8)]
	public class UIPopupButton : FrostbiteContainer
	{
		[ContainerField(Name: "InputConcept", Offset: 0, NameHash: 2259566003, Flags: 137)]
		public UIInputAction InputConcept { get; set; } = new UIInputAction(); // 0x0 (0)
		
		[ContainerField(Name: "Label", Offset: 4, NameHash: 218105699, Flags: 16509), LayoutImmutable]
		public string Label { get; set; } // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2259566003:
						InputConcept = (UIInputAction) Enum.ToObject(typeof(UIInputAction), p_Value);
					break;

				case 218105699:
					Label = (string) p_Value;
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
				case 2259566003:
					return InputConcept;

				case 218105699:
					return Label;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2259566003:
					return typeof(UIPopupButton).GetProperty(nameof(InputConcept));

				case 218105699:
					return typeof(UIPopupButton).GetProperty(nameof(Label));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
