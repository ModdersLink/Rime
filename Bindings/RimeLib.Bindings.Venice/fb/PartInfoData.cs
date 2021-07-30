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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 48)]
	public class PartInfoData : FrostbiteContainer
	{
		[ContainerField(Name: "Aabb", Offset: 0, NameHash: 2088635333, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public AxisAlignedBox Aabb { get; set; } = new AxisAlignedBox(); // 0x0 (0)
		
		[ContainerField(Name: "Translation", Offset: 32, NameHash: 2696156750, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Translation { get; set; } = new Vec3(); // 0x20 (32)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2088635333:
					Aabb = (AxisAlignedBox) p_Value;
					break;

				case 2696156750:
					Translation = (Vec3) p_Value;
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
				case 2088635333:
					return Aabb;

				case 2696156750:
					return Translation;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2088635333:
					return typeof(PartInfoData).GetProperty(nameof(Aabb));

				case 2696156750:
					return typeof(PartInfoData).GetProperty(nameof(Translation));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
