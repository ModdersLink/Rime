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
	public class ColorCorrectionComponentData : 
		ComponentData
	{
		protected Vec3 m_Contrast = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(332991719)]
		public Vec3 Contrast { get { return m_Contrast; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Contrast), this, m_Contrast, value)) m_Contrast = value; } } // 0x60 (96)
		
		protected Vec3 m_Saturation = new Vec3();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2572315705)]
		public Vec3 Saturation { get { return m_Saturation; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Saturation), this, m_Saturation, value)) m_Saturation = value; } } // 0x70 (112)
		
		protected Vec3 m_Brightness = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2298333740)]
		public Vec3 Brightness { get { return m_Brightness; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Brightness), this, m_Brightness, value)) m_Brightness = value; } } // 0x80 (128)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(144), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0x90 (144)
		
		protected float m_Hue = new float();
		[ContainerField(148), LayoutImmutable, Blittable, ContainerFieldNameHash(193458845)]
		public float Hue { get { return m_Hue; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Hue), this, m_Hue, value)) m_Hue = value; } } // 0x94 (148)
		
		protected CtrRef<TextureAsset> m_ColorGradingTexture = new CtrRef<TextureAsset>();
		[ContainerField(152), ContainerFieldNameHash(432198551)]
		public CtrRef<TextureAsset> ColorGradingTexture { get { return m_ColorGradingTexture; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(ColorGradingTexture), this, m_ColorGradingTexture, value)) m_ColorGradingTexture = value; } } // 0x98 (152)
		
		protected bool m_ColorGradingEnable = new bool();
		[ContainerField(156), LayoutImmutable, Blittable, ContainerFieldNameHash(1205773449)]
		public bool ColorGradingEnable { get { return m_ColorGradingEnable; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(ColorGradingEnable), this, m_ColorGradingEnable, value)) m_ColorGradingEnable = value; } } // 0x9C (156)
		
		protected bool m_Enable = new bool();
		[ContainerField(157), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("ColorCorrectionComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x9D (157)
		
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
