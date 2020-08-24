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
	public class UIButton : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string ButtonLabel { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string ButtonId { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49325)]
		public bool IsPremium { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 139802613:
					ButtonLabel = (string) p_Value;
					break;

				case 379579614:
					ButtonId = (string) p_Value;
					break;

				case 695230116:
					IsPremium = (bool) p_Value;
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
				case 139802613:
					return ButtonLabel;

				case 379579614:
					return ButtonId;

				case 695230116:
					return IsPremium;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 139802613:
					return typeof(UIButton).GetProperty(nameof(ButtonLabel));

				case 379579614:
					return typeof(UIButton).GetProperty(nameof(ButtonId));

				case 695230116:
					return typeof(UIButton).GetProperty(nameof(IsPremium));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
