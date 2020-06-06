///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class ColorCorrectionComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Contrast { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Saturation { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Brightness { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144)]
		public Realm Realm { get; set; } = new Realm(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float Hue { get; set; } // 0x94 (148)
		
		[ContainerField(152)]
		public CtrRef<TextureAsset> ColorGradingTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool ColorGradingEnable { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x9D (157)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 332991719:
					Contrast = (Vec3) p_Value;
					break;

				case 2572315705:
					Saturation = (Vec3) p_Value;
					break;

				case 2298333740:
					Brightness = (Vec3) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 193458845:
					Hue = (float) p_Value;
					break;

				case 432198551:
					ColorGradingTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1205773449:
					ColorGradingEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
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

				case 2572315705:
					return Saturation;

				case 2298333740:
					return Brightness;

				case 229961746:
					return Realm;

				case 193458845:
					return Hue;

				case 432198551:
					return ColorGradingTexture;

				case 1205773449:
					return ColorGradingEnable;

				case 2342790116:
					return Enable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 332991719:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Contrast));

				case 2572315705:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Saturation));

				case 2298333740:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Brightness));

				case 229961746:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Realm));

				case 193458845:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Hue));

				case 432198551:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(ColorGradingTexture));

				case 1205773449:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(ColorGradingEnable));

				case 2342790116:
					return typeof(ColorCorrectionComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
