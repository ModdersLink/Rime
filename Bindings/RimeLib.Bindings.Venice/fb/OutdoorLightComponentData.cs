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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 224)]
	public class OutdoorLightComponentData : 
		ComponentData
	{
		protected Vec3 m_SunColor = new Vec3();
		[ContainerField(Name: "SunColor", Offset: 96, NameHash: 2189837744, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get { return m_SunColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunColor), this, m_SunColor, value)) m_SunColor = value; } } // 0x60 (96)
		
		protected Vec2 m_CloudShadowSpeed = new Vec2();
		[ContainerField(Name: "CloudShadowSpeed", Offset: 112, NameHash: 4285381109, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get { return m_CloudShadowSpeed; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowSpeed), this, m_CloudShadowSpeed, value)) m_CloudShadowSpeed = value; } } // 0x70 (112)
		
		protected Vec3 m_SkyColor = new Vec3();
		[ContainerField(Name: "SkyColor", Offset: 128, NameHash: 3778322649, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get { return m_SkyColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyColor), this, m_SkyColor, value)) m_SkyColor = value; } } // 0x80 (128)
		
		protected Vec3 m_GroundColor = new Vec3();
		[ContainerField(Name: "GroundColor", Offset: 144, NameHash: 1770880637, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get { return m_GroundColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(GroundColor), this, m_GroundColor, value)) m_GroundColor = value; } } // 0x90 (144)
		
		protected float m_SunRotationY = new float();
		[ContainerField(Name: "SunRotationY", Offset: 160, NameHash: 2283294048, Flags: 49469), LayoutImmutable, Blittable]
		public float SunRotationY { get { return m_SunRotationY; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunRotationY), this, m_SunRotationY, value)) m_SunRotationY = value; } } // 0xA0 (160)
		
		protected float m_SunRotationX = new float();
		[ContainerField(Name: "SunRotationX", Offset: 164, NameHash: 2283294049, Flags: 49469), LayoutImmutable, Blittable]
		public float SunRotationX { get { return m_SunRotationX; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunRotationX), this, m_SunRotationX, value)) m_SunRotationX = value; } } // 0xA4 (164)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 168, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xA8 (168)
		
		protected float m_SkyLightAngleFactor = new float();
		[ContainerField(Name: "SkyLightAngleFactor", Offset: 172, NameHash: 4138591318, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get { return m_SkyLightAngleFactor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyLightAngleFactor), this, m_SkyLightAngleFactor, value)) m_SkyLightAngleFactor = value; } } // 0xAC (172)
		
		protected float m_SunSpecularScale = new float();
		[ContainerField(Name: "SunSpecularScale", Offset: 176, NameHash: 3421876698, Flags: 49469), LayoutImmutable, Blittable]
		public float SunSpecularScale { get { return m_SunSpecularScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunSpecularScale), this, m_SunSpecularScale, value)) m_SunSpecularScale = value; } } // 0xB0 (176)
		
		protected float m_SkyEnvmapShadowScale = new float();
		[ContainerField(Name: "SkyEnvmapShadowScale", Offset: 180, NameHash: 3000421435, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyEnvmapShadowScale { get { return m_SkyEnvmapShadowScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyEnvmapShadowScale), this, m_SkyEnvmapShadowScale, value)) m_SkyEnvmapShadowScale = value; } } // 0xB4 (180)
		
		protected float m_SunShadowHeightScale = new float();
		[ContainerField(Name: "SunShadowHeightScale", Offset: 184, NameHash: 2049987628, Flags: 49469), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get { return m_SunShadowHeightScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunShadowHeightScale), this, m_SunShadowHeightScale, value)) m_SunShadowHeightScale = value; } } // 0xB8 (184)
		
		protected float m_CloudShadowCoverage = new float();
		[ContainerField(Name: "CloudShadowCoverage", Offset: 188, NameHash: 535106300, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get { return m_CloudShadowCoverage; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowCoverage), this, m_CloudShadowCoverage, value)) m_CloudShadowCoverage = value; } } // 0xBC (188)
		
		protected CtrRef<TextureAsset> m_CloudShadowTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CloudShadowTexture", Offset: 192, NameHash: 1607365037, Flags: 53)]
		public CtrRef<TextureAsset> CloudShadowTexture { get { return m_CloudShadowTexture; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowTexture), this, m_CloudShadowTexture, value)) m_CloudShadowTexture = value; } } // 0xC0 (192)
		
		protected float m_TranslucencyDistortion = new float();
		[ContainerField(Name: "TranslucencyDistortion", Offset: 196, NameHash: 654575839, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get { return m_TranslucencyDistortion; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyDistortion), this, m_TranslucencyDistortion, value)) m_TranslucencyDistortion = value; } } // 0xC4 (196)
		
		protected float m_CloudShadowSize = new float();
		[ContainerField(Name: "CloudShadowSize", Offset: 200, NameHash: 2732862871, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowSize { get { return m_CloudShadowSize; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowSize), this, m_CloudShadowSize, value)) m_CloudShadowSize = value; } } // 0xC8 (200)
		
		protected float m_TranslucencyAmbient = new float();
		[ContainerField(Name: "TranslucencyAmbient", Offset: 204, NameHash: 2476604812, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get { return m_TranslucencyAmbient; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyAmbient), this, m_TranslucencyAmbient, value)) m_TranslucencyAmbient = value; } } // 0xCC (204)
		
		protected float m_CloudShadowExponent = new float();
		[ContainerField(Name: "CloudShadowExponent", Offset: 208, NameHash: 1934044673, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get { return m_CloudShadowExponent; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowExponent), this, m_CloudShadowExponent, value)) m_CloudShadowExponent = value; } } // 0xD0 (208)
		
		protected float m_TranslucencyScale = new float();
		[ContainerField(Name: "TranslucencyScale", Offset: 212, NameHash: 317261612, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyScale { get { return m_TranslucencyScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyScale), this, m_TranslucencyScale, value)) m_TranslucencyScale = value; } } // 0xD4 (212)
		
		protected float m_TranslucencyPower = new float();
		[ContainerField(Name: "TranslucencyPower", Offset: 216, NameHash: 311917771, Flags: 49469), LayoutImmutable, Blittable]
		public float TranslucencyPower { get { return m_TranslucencyPower; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyPower), this, m_TranslucencyPower, value)) m_TranslucencyPower = value; } } // 0xD8 (216)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 220, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xDC (220)
		
		protected bool m_CloudShadowEnable = new bool();
		[ContainerField(Name: "CloudShadowEnable", Offset: 221, NameHash: 380549299, Flags: 49325), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get { return m_CloudShadowEnable; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowEnable), this, m_CloudShadowEnable, value)) m_CloudShadowEnable = value; } } // 0xDD (221)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2189837744:
					SunColor = (Vec3) p_Value;
					break;

				case 4285381109:
					CloudShadowSpeed = (Vec2) p_Value;
					break;

				case 3778322649:
					SkyColor = (Vec3) p_Value;
					break;

				case 1770880637:
					GroundColor = (Vec3) p_Value;
					break;

				case 2283294048:
					SunRotationY = (float) p_Value;
					break;

				case 2283294049:
					SunRotationX = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4138591318:
					SkyLightAngleFactor = (float) p_Value;
					break;

				case 3421876698:
					SunSpecularScale = (float) p_Value;
					break;

				case 3000421435:
					SkyEnvmapShadowScale = (float) p_Value;
					break;

				case 2049987628:
					SunShadowHeightScale = (float) p_Value;
					break;

				case 535106300:
					CloudShadowCoverage = (float) p_Value;
					break;

				case 1607365037:
					CloudShadowTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 654575839:
					TranslucencyDistortion = (float) p_Value;
					break;

				case 2732862871:
					CloudShadowSize = (float) p_Value;
					break;

				case 2476604812:
					TranslucencyAmbient = (float) p_Value;
					break;

				case 1934044673:
					CloudShadowExponent = (float) p_Value;
					break;

				case 317261612:
					TranslucencyScale = (float) p_Value;
					break;

				case 311917771:
					TranslucencyPower = (float) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 380549299:
					CloudShadowEnable = (bool) p_Value;
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
				case 2189837744:
					return SunColor;

				case 4285381109:
					return CloudShadowSpeed;

				case 3778322649:
					return SkyColor;

				case 1770880637:
					return GroundColor;

				case 2283294048:
					return SunRotationY;

				case 2283294049:
					return SunRotationX;

				case 229961746:
					return Realm;

				case 4138591318:
					return SkyLightAngleFactor;

				case 3421876698:
					return SunSpecularScale;

				case 3000421435:
					return SkyEnvmapShadowScale;

				case 2049987628:
					return SunShadowHeightScale;

				case 535106300:
					return CloudShadowCoverage;

				case 1607365037:
					return CloudShadowTexture;

				case 654575839:
					return TranslucencyDistortion;

				case 2732862871:
					return CloudShadowSize;

				case 2476604812:
					return TranslucencyAmbient;

				case 1934044673:
					return CloudShadowExponent;

				case 317261612:
					return TranslucencyScale;

				case 311917771:
					return TranslucencyPower;

				case 2342790116:
					return Enable;

				case 380549299:
					return CloudShadowEnable;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2189837744:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SunColor));

				case 4285381109:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowSpeed));

				case 3778322649:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SkyColor));

				case 1770880637:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(GroundColor));

				case 2283294048:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SunRotationY));

				case 2283294049:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SunRotationX));

				case 229961746:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(Realm));

				case 4138591318:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SkyLightAngleFactor));

				case 3421876698:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SunSpecularScale));

				case 3000421435:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SkyEnvmapShadowScale));

				case 2049987628:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(SunShadowHeightScale));

				case 535106300:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowCoverage));

				case 1607365037:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowTexture));

				case 654575839:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(TranslucencyDistortion));

				case 2732862871:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowSize));

				case 2476604812:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(TranslucencyAmbient));

				case 1934044673:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowExponent));

				case 317261612:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(TranslucencyScale));

				case 311917771:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(TranslucencyPower));

				case 2342790116:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(Enable));

				case 380549299:
					return typeof(OutdoorLightComponentData).GetProperty(nameof(CloudShadowEnable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
