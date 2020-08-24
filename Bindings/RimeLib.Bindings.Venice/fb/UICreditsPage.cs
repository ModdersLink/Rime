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
	public class UICreditsPage : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Header1 { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, MemberInfoFlag(16509)]
		public string Header2 { get; set; } // 0x4 (4)
		
		[ContainerField(8), MemberInfoFlag(65), ContainerArray]
		public List<UICreditsLine> Lines { get; set; } = new List<UICreditsLine>(); // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2009148299:
					Header1 = (string) p_Value;
					break;

				case 2009148296:
					Header2 = (string) p_Value;
					break;

				case 217831032:
					Lines = (List<UICreditsLine>) p_Value;
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
				case 2009148299:
					return Header1;

				case 2009148296:
					return Header2;

				case 217831032:
					return Lines;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2009148299:
					return typeof(UICreditsPage).GetProperty(nameof(Header1));

				case 2009148296:
					return typeof(UICreditsPage).GetProperty(nameof(Header2));

				case 217831032:
					return typeof(UICreditsPage).GetProperty(nameof(Lines));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
