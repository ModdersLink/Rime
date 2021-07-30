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
	public class UIGeoLatitude : FrostbiteContainer
	{
		[ContainerField(Name: "Degrees", Offset: 0, NameHash: 3998015778, Flags: 49405), LayoutImmutable, Blittable]
		public int Degrees { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "Minuites", Offset: 4, NameHash: 3334936657, Flags: 49405), LayoutImmutable, Blittable]
		public int Minuites { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "Seconds", Offset: 8, NameHash: 2761379558, Flags: 49405), LayoutImmutable, Blittable]
		public int Seconds { get; set; } // 0x8 (8)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3998015778:
					Degrees = (int) p_Value;
					break;

				case 3334936657:
					Minuites = (int) p_Value;
					break;

				case 2761379558:
					Seconds = (int) p_Value;
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
				case 3998015778:
					return Degrees;

				case 3334936657:
					return Minuites;

				case 2761379558:
					return Seconds;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3998015778:
					return typeof(UIGeoLatitude).GetProperty(nameof(Degrees));

				case 3334936657:
					return typeof(UIGeoLatitude).GetProperty(nameof(Minuites));

				case 2761379558:
					return typeof(UIGeoLatitude).GetProperty(nameof(Seconds));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
