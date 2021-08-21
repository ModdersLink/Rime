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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 16)]
	public class Ps3AgeLevels : FrostbiteContainer
	{
		[ContainerField(Name: "AgeLevel7", Offset: 0, NameHash: 2470460071, Flags: 49405), LayoutImmutable, Blittable]
		public int AgeLevel7 { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "AgeLevel8", Offset: 4, NameHash: 2470460072, Flags: 49405), LayoutImmutable, Blittable]
		public int AgeLevel8 { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "AgeLevel9", Offset: 8, NameHash: 2470460073, Flags: 49405), LayoutImmutable, Blittable]
		public int AgeLevel9 { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "AgeLevel10", Offset: 12, NameHash: 4215770865, Flags: 49405), LayoutImmutable, Blittable]
		public int AgeLevel10 { get; set; } // 0xC (12)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2470460071:
					AgeLevel7 = (int) p_Value;
					break;

				case 2470460072:
					AgeLevel8 = (int) p_Value;
					break;

				case 2470460073:
					AgeLevel9 = (int) p_Value;
					break;

				case 4215770865:
					AgeLevel10 = (int) p_Value;
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
				case 2470460071:
					return AgeLevel7;

				case 2470460072:
					return AgeLevel8;

				case 2470460073:
					return AgeLevel9;

				case 4215770865:
					return AgeLevel10;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2470460071:
					return typeof(Ps3AgeLevels).GetProperty(nameof(AgeLevel7));

				case 2470460072:
					return typeof(Ps3AgeLevels).GetProperty(nameof(AgeLevel8));

				case 2470460073:
					return typeof(Ps3AgeLevels).GetProperty(nameof(AgeLevel9));

				case 4215770865:
					return typeof(Ps3AgeLevels).GetProperty(nameof(AgeLevel10));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
