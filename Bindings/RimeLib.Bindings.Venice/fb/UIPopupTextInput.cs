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
	[ContainerType(4), MemberInfoFlag(41), ContainerStruct]
	public class UIPopupTextInput : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Id { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string Label { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, MemberInfoFlag(16509)]
		public string DefaultValue { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsPassword { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 5862152:
					Id = (string) p_Value;
					break;

				case 218105699:
					Label = (string) p_Value;
					break;

				case 2066049125:
					DefaultValue = (string) p_Value;
					break;

				case 1832244704:
					IsPassword = (bool) p_Value;
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
				case 5862152:
					return Id;

				case 218105699:
					return Label;

				case 2066049125:
					return DefaultValue;

				case 1832244704:
					return IsPassword;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 5862152:
					return typeof(UIPopupTextInput).GetProperty(nameof(Id));

				case 218105699:
					return typeof(UIPopupTextInput).GetProperty(nameof(Label));

				case 2066049125:
					return typeof(UIPopupTextInput).GetProperty(nameof(DefaultValue));

				case 1832244704:
					return typeof(UIPopupTextInput).GetProperty(nameof(IsPassword));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
