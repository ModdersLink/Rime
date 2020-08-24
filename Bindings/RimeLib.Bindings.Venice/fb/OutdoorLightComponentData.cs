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
	[ContainerType(16), MemberInfoFlag(53), ContainerClass]
	public class OutdoorLightComponentData : 
		ComponentData
	{
		protected Vec3 m_SunColor = new Vec3();
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(2189837744)]
		public Vec3 SunColor { get { return m_SunColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunColor), this, m_SunColor, value)) m_SunColor = value; } } // 0x60 (96)
		
		protected Vec2 m_CloudShadowSpeed = new Vec2();
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(4285381109)]
		public Vec2 CloudShadowSpeed { get { return m_CloudShadowSpeed; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowSpeed), this, m_CloudShadowSpeed, value)) m_CloudShadowSpeed = value; } } // 0x70 (112)
		
		protected Vec3 m_SkyColor = new Vec3();
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(3778322649)]
		public Vec3 SkyColor { get { return m_SkyColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyColor), this, m_SkyColor, value)) m_SkyColor = value; } } // 0x80 (128)
		
		protected Vec3 m_GroundColor = new Vec3();
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1770880637)]
		public Vec3 GroundColor { get { return m_GroundColor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(GroundColor), this, m_GroundColor, value)) m_GroundColor = value; } } // 0x90 (144)
		
		protected float m_SunRotationY = new float();
		[ContainerField(160), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2283294048)]
		public float SunRotationY { get { return m_SunRotationY; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunRotationY), this, m_SunRotationY, value)) m_SunRotationY = value; } } // 0xA0 (160)
		
		protected float m_SunRotationX = new float();
		[ContainerField(164), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2283294049)]
		public float SunRotationX { get { return m_SunRotationX; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunRotationX), this, m_SunRotationX, value)) m_SunRotationX = value; } } // 0xA4 (164)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(168), MemberInfoFlag(137), ContainerFieldNameHash(229961746)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xA8 (168)
		
		protected float m_SkyLightAngleFactor = new float();
		[ContainerField(172), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4138591318)]
		public float SkyLightAngleFactor { get { return m_SkyLightAngleFactor; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyLightAngleFactor), this, m_SkyLightAngleFactor, value)) m_SkyLightAngleFactor = value; } } // 0xAC (172)
		
		protected float m_SunSpecularScale = new float();
		[ContainerField(176), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3421876698)]
		public float SunSpecularScale { get { return m_SunSpecularScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunSpecularScale), this, m_SunSpecularScale, value)) m_SunSpecularScale = value; } } // 0xB0 (176)
		
		protected float m_SkyEnvmapShadowScale = new float();
		[ContainerField(180), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3000421435)]
		public float SkyEnvmapShadowScale { get { return m_SkyEnvmapShadowScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SkyEnvmapShadowScale), this, m_SkyEnvmapShadowScale, value)) m_SkyEnvmapShadowScale = value; } } // 0xB4 (180)
		
		protected float m_SunShadowHeightScale = new float();
		[ContainerField(184), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2049987628)]
		public float SunShadowHeightScale { get { return m_SunShadowHeightScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(SunShadowHeightScale), this, m_SunShadowHeightScale, value)) m_SunShadowHeightScale = value; } } // 0xB8 (184)
		
		protected float m_CloudShadowCoverage = new float();
		[ContainerField(188), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(535106300)]
		public float CloudShadowCoverage { get { return m_CloudShadowCoverage; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowCoverage), this, m_CloudShadowCoverage, value)) m_CloudShadowCoverage = value; } } // 0xBC (188)
		
		protected CtrRef<TextureAsset> m_CloudShadowTexture = new CtrRef<TextureAsset>();
		[ContainerField(192), MemberInfoFlag(53), ContainerFieldNameHash(1607365037), ContainerCtrRef]
		public CtrRef<TextureAsset> CloudShadowTexture { get { return m_CloudShadowTexture; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowTexture), this, m_CloudShadowTexture, value)) m_CloudShadowTexture = value; } } // 0xC0 (192)
		
		protected float m_TranslucencyDistortion = new float();
		[ContainerField(196), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(654575839)]
		public float TranslucencyDistortion { get { return m_TranslucencyDistortion; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyDistortion), this, m_TranslucencyDistortion, value)) m_TranslucencyDistortion = value; } } // 0xC4 (196)
		
		protected float m_CloudShadowSize = new float();
		[ContainerField(200), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2732862871)]
		public float CloudShadowSize { get { return m_CloudShadowSize; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowSize), this, m_CloudShadowSize, value)) m_CloudShadowSize = value; } } // 0xC8 (200)
		
		protected float m_TranslucencyAmbient = new float();
		[ContainerField(204), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2476604812)]
		public float TranslucencyAmbient { get { return m_TranslucencyAmbient; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyAmbient), this, m_TranslucencyAmbient, value)) m_TranslucencyAmbient = value; } } // 0xCC (204)
		
		protected float m_CloudShadowExponent = new float();
		[ContainerField(208), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1934044673)]
		public float CloudShadowExponent { get { return m_CloudShadowExponent; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(CloudShadowExponent), this, m_CloudShadowExponent, value)) m_CloudShadowExponent = value; } } // 0xD0 (208)
		
		protected float m_TranslucencyScale = new float();
		[ContainerField(212), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(317261612)]
		public float TranslucencyScale { get { return m_TranslucencyScale; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyScale), this, m_TranslucencyScale, value)) m_TranslucencyScale = value; } } // 0xD4 (212)
		
		protected float m_TranslucencyPower = new float();
		[ContainerField(216), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(311917771)]
		public float TranslucencyPower { get { return m_TranslucencyPower; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(TranslucencyPower), this, m_TranslucencyPower, value)) m_TranslucencyPower = value; } } // 0xD8 (216)
		
		protected bool m_Enable = new bool();
		[ContainerField(220), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("OutdoorLightComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xDC (220)
		
		protected bool m_CloudShadowEnable = new bool();
		[ContainerField(221), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(380549299)]
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
