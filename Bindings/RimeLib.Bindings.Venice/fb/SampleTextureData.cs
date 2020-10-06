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
	[ContainerType(16), MemberInfoFlag(53), ContainerSize(80), ContainerClass]
	public class SampleTextureData : 
		EvaluatorData
	{
		protected Vec2 m_TextureDimensions = new Vec2();
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1486911481)]
		public Vec2 TextureDimensions { get { return m_TextureDimensions; } set { if (OnPropertyChanging("SampleTextureData." + nameof(TextureDimensions), this, m_TextureDimensions, value)) m_TextureDimensions = value; } } // 0xC (12)
		
		protected Vec3 m_ColorIntensityMax = new Vec3();
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(707866275)]
		public Vec3 ColorIntensityMax { get { return m_ColorIntensityMax; } set { if (OnPropertyChanging("SampleTextureData." + nameof(ColorIntensityMax), this, m_ColorIntensityMax, value)) m_ColorIntensityMax = value; } } // 0x20 (32)
		
		protected Vec3 m_ColorIntensityMin = new Vec3();
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(707866045)]
		public Vec3 ColorIntensityMin { get { return m_ColorIntensityMin; } set { if (OnPropertyChanging("SampleTextureData." + nameof(ColorIntensityMin), this, m_ColorIntensityMin, value)) m_ColorIntensityMin = value; } } // 0x30 (48)
		
		protected List<Vec4> m_GradientData = new List<Vec4>();
		[ContainerField(64), MemberInfoFlag(65), ContainerFieldNameHash(2003028595), ContainerArray]
		public List<Vec4> GradientData { get { return m_GradientData; } set { if (OnPropertyChanging("SampleTextureData." + nameof(GradientData), this, m_GradientData, value)) m_GradientData = value; } } // 0x40 (64)
		
		protected float m_TextureOriginU = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1728068571)]
		public float TextureOriginU { get { return m_TextureOriginU; } set { if (OnPropertyChanging("SampleTextureData." + nameof(TextureOriginU), this, m_TextureOriginU, value)) m_TextureOriginU = value; } } // 0x44 (68)
		
		protected float m_TextureOriginV = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1728068568)]
		public float TextureOriginV { get { return m_TextureOriginV; } set { if (OnPropertyChanging("SampleTextureData." + nameof(TextureOriginV), this, m_TextureOriginV, value)) m_TextureOriginV = value; } } // 0x48 (72)
		
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
