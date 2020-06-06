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
	public class OutdoorLightComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get; set; } = new Vec2(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get; set; } = new Vec3(); // 0x90 (144)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; } // 0xA4 (164)
		
		[ContainerField(168)]
		public Realm Realm { get; set; } = new Realm(); // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float SunSpecularScale { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float SkyEnvmapShadowScale { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get; set; } // 0xBC (188)
		
		[ContainerField(192)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float CloudShadowSize { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float TranslucencyScale { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float TranslucencyPower { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xDC (220)
		
		[ContainerField(221), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; } // 0xDD (221)
		
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
