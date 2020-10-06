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
	[ContainerType(4), MemberInfoFlag(41), ContainerSize(8), ContainerStruct]
	public class LevelDescriptionInclusionCategory : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, MemberInfoFlag(16509)]
		public string Category { get; set; } // 0x0 (0)
		
		[ContainerField(4), MemberInfoFlag(65), ContainerArray]
		public List<string> Mode { get; set; } = new List<string>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3455858997:
					Category = (string) p_Value;
					break;

				case 2088772358:
					Mode = (List<string>) p_Value;
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
				case 3455858997:
					return Category;

				case 2088772358:
					return Mode;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3455858997:
					return typeof(LevelDescriptionInclusionCategory).GetProperty(nameof(Category));

				case 2088772358:
					return typeof(LevelDescriptionInclusionCategory).GetProperty(nameof(Mode));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
