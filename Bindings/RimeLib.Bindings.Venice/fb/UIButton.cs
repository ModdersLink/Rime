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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 12)]
	public class UIButton : FrostbiteContainer
	{
		[ContainerField(Name: "ButtonLabel", Offset: 0, NameHash: 139802613, Flags: 16509), LayoutImmutable]
		public string ButtonLabel { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "ButtonId", Offset: 4, NameHash: 379579614, Flags: 16509), LayoutImmutable]
		public string ButtonId { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "IsPremium", Offset: 8, NameHash: 695230116, Flags: 49325), LayoutImmutable, Blittable]
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
