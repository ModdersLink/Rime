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
	public class AwardStarNameInstance : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable]
		public string Name { get; set; } // 0x0 (0)
		
		[ContainerField(4)]
		public CtrRef<StatsCategoryBaseData> Category { get; set; } = new CtrRef<StatsCategoryBaseData>(); // 0x4 (4)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088949890:
					Name = (string) p_Value;
					break;

				case 3455858997:
					Category = (CtrRef<StatsCategoryBaseData>) p_Value;
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
				case 2088949890:
					return Name;

				case 3455858997:
					return Category;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088949890:
					return typeof(AwardStarNameInstance).GetProperty(nameof(Name));

				case 3455858997:
					return typeof(AwardStarNameInstance).GetProperty(nameof(Category));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
