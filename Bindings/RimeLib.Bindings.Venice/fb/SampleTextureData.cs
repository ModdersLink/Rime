///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Collections.Generic;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SampleTextureData : 
		EvaluatorData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 TextureDimensions { get; set; } = new Vec2(); // 0xC (12)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMax { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ColorIntensityMin { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64)]
		public List<Vec4> GradientData { get; set; } = new List<Vec4>(); // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float TextureOriginU { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float TextureOriginV { get; set; } // 0x48 (72)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1486911481:
					TextureDimensions = (Vec2) p_Value;
					break;

				case 707866275:
					ColorIntensityMax = (Vec3) p_Value;
					break;

				case 707866045:
					ColorIntensityMin = (Vec3) p_Value;
					break;

				case 2003028595:
					GradientData = (List<Vec4>) p_Value;
					break;

				case 1728068571:
					TextureOriginU = (float) p_Value;
					break;

				case 1728068568:
					TextureOriginV = (float) p_Value;
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
				case 1486911481:
					return TextureDimensions;

				case 707866275:
					return ColorIntensityMax;

				case 707866045:
					return ColorIntensityMin;

				case 2003028595:
					return GradientData;

				case 1728068571:
					return TextureOriginU;

				case 1728068568:
					return TextureOriginV;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1486911481:
					return typeof(SampleTextureData).GetProperty(nameof(TextureDimensions));

				case 707866275:
					return typeof(SampleTextureData).GetProperty(nameof(ColorIntensityMax));

				case 707866045:
					return typeof(SampleTextureData).GetProperty(nameof(ColorIntensityMin));

				case 2003028595:
					return typeof(SampleTextureData).GetProperty(nameof(GradientData));

				case 1728068571:
					return typeof(SampleTextureData).GetProperty(nameof(TextureOriginU));

				case 1728068568:
					return typeof(SampleTextureData).GetProperty(nameof(TextureOriginV));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
