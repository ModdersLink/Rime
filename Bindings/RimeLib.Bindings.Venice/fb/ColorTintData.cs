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
	[ContainerType(Alignment: 16,  Flags: 41, Size: 64)]
	public class ColorTintData : FrostbiteContainer
	{
		[ContainerField(Name: "Contrast", Offset: 0, NameHash: 332991719, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new Vec3(); // 0x0 (0)
		
		[ContainerField(Name: "Brightness", Offset: 16, NameHash: 2298333740, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(Name: "Saturation", Offset: 32, NameHash: 2572315705, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(Name: "Hue", Offset: 48, NameHash: 193458845, Flags: 49469), LayoutImmutable, Blittable]
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
