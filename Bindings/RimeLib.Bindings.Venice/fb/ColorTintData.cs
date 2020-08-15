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
	[ContainerType(16)]
	public class ColorTintData : FrostbiteContainer
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float Hue { get; set; } // 0x30 (48)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 332991719:
					Contrast = (Vec3) p_Value;
					break;

				case 2298333740:
					Brightness = (Vec3) p_Value;
					break;

				case 2572315705:
					Saturation = (Vec3) p_Value;
					break;

				case 193458845:
					Hue = (float) p_Value;
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
				case 332991719:
					return Contrast;

				case 2298333740:
					return Brightness;

				case 2572315705:
					return Saturation;

				case 193458845:
					return Hue;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 332991719:
					return typeof(ColorTintData).GetProperty(nameof(Contrast));

				case 2298333740:
					return typeof(ColorTintData).GetProperty(nameof(Brightness));

				case 2572315705:
					return typeof(ColorTintData).GetProperty(nameof(Saturation));

				case 193458845:
					return typeof(ColorTintData).GetProperty(nameof(Hue));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
