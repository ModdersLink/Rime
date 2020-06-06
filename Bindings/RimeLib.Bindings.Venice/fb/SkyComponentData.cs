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
	public class SkyComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayerSunColor { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer2Color { get; set; } = new Vec3(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer1Color { get; set; } = new Vec3(); // 0x80 (128)
		
		[ContainerField(144)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float SunSize { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float BrightnessScale { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public float SunScale { get; set; } // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float PanoramicUVMaxX { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float PanoramicUVMinY { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float PanoramicUVMaxY { get; set; } // 0xA8 (168)
		
		[ContainerField(172)]
		public Realm Realm { get; set; } = new Realm(); // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float PanoramicUVMinX { get; set; } // 0xB0 (176)
		
		[ContainerField(180)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xB4 (180)
		
		[ContainerField(184)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float PanoramicTileFactor { get; set; } // 0xBC (188)
		
		[ContainerField(192)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xC0 (192)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public float CloudLayer1Altitude { get; set; } // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public float CloudLayer1TileFactor { get; set; } // 0xC8 (200)
		
		[ContainerField(204), LayoutImmutable, Blittable]
		public float CloudLayer1Rotation { get; set; } // 0xCC (204)
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float CloudLayer1Speed { get; set; } // 0xD0 (208)
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightIntensity { get; set; } // 0xD4 (212)
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float PanoramicRotation { get; set; } // 0xD8 (216)
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float CloudLayer1AmbientLightIntensity { get; set; } // 0xDC (220)
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightPower { get; set; } // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float CloudLayer1AlphaMul { get; set; } // 0xE4 (228)
		
		[ContainerField(232)]
		public CtrRef<TextureAsset> CloudLayer1Texture { get; set; } = new CtrRef<TextureAsset>(); // 0xE8 (232)
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float CloudLayer2Altitude { get; set; } // 0xEC (236)
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float CloudLayer2TileFactor { get; set; } // 0xF0 (240)
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float CloudLayer2Rotation { get; set; } // 0xF4 (244)
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public float CloudLayer2Speed { get; set; } // 0xF8 (248)
		
		[ContainerField(252), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightIntensity { get; set; } // 0xFC (252)
		
		[ContainerField(256), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightPower { get; set; } // 0x100 (256)
		
		[ContainerField(260), LayoutImmutable, Blittable]
		public float CloudLayer2AmbientLightIntensity { get; set; } // 0x104 (260)
		
		[ContainerField(264), LayoutImmutable, Blittable]
		public float StaticEnvmapScale { get; set; } // 0x108 (264)
		
		[ContainerField(268), LayoutImmutable, Blittable]
		public float CloudLayer2AlphaMul { get; set; } // 0x10C (268)
		
		[ContainerField(272)]
		public CtrRef<TextureAsset> CloudLayer2Texture { get; set; } = new CtrRef<TextureAsset>(); // 0x110 (272)
		
		[ContainerField(276)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x114 (276)
		
		[ContainerField(280), LayoutImmutable, Blittable]
		public float SkyVisibilityExponent { get; set; } // 0x118 (280)
		
		[ContainerField(284), LayoutImmutable, Blittable]
		public float SkyEnvmap8BitTexScale { get; set; } // 0x11C (284)
		
		[ContainerField(288)]
		public CtrRef<TextureAsset> CustomEnvmapTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x120 (288)
		
		[ContainerField(292), LayoutImmutable, Blittable]
		public float CustomEnvmapScale { get; set; } // 0x124 (292)
		
		[ContainerField(296), LayoutImmutable, Blittable]
		public float CustomEnvmapAmbient { get; set; } // 0x128 (296)
		
		[ContainerField(300), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x12C (300)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2080466082:
					CloudLayerSunColor = (Vec3) p_Value;
					break;

				case 2853016120:
					CloudLayer2Color = (Vec3) p_Value;
					break;

				case 3041579739:
					CloudLayer1Color = (Vec3) p_Value;
					break;

				case 1001603005:
					SkyGradientTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2149343816:
					SunSize = (float) p_Value;
					break;

				case 1301955796:
					BrightnessScale = (float) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 2272268590:
					PanoramicUVMaxX = (float) p_Value;
					break;

				case 2272259825:
					PanoramicUVMinY = (float) p_Value;
					break;

				case 2272268591:
					PanoramicUVMaxY = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 2272259824:
					PanoramicUVMinX = (float) p_Value;
					break;

				case 2684028734:
					PanoramicTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2261597450:
					PanoramicAlphaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 4205943736:
					PanoramicTileFactor = (float) p_Value;
					break;

				case 1350837372:
					CloudLayerMaskTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2061086550:
					CloudLayer1Altitude = (float) p_Value;
					break;

				case 1142043935:
					CloudLayer1TileFactor = (float) p_Value;
					break;

				case 1760002578:
					CloudLayer1Rotation = (float) p_Value;
					break;

				case 3059870497:
					CloudLayer1Speed = (float) p_Value;
					break;

				case 1815101471:
					CloudLayer1SunLightIntensity = (float) p_Value;
					break;

				case 980600565:
					PanoramicRotation = (float) p_Value;
					break;

				case 1412432303:
					CloudLayer1AmbientLightIntensity = (float) p_Value;
					break;

				case 650181263:
					CloudLayer1SunLightPower = (float) p_Value;
					break;

				case 1904139366:
					CloudLayer1AlphaMul = (float) p_Value;
					break;

				case 3691166713:
					CloudLayer1Texture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2002768725:
					CloudLayer2Altitude = (float) p_Value;
					break;

				case 2650580380:
					CloudLayer2TileFactor = (float) p_Value;
					break;

				case 2105944465:
					CloudLayer2Rotation = (float) p_Value;
					break;

				case 2871245762:
					CloudLayer2Speed = (float) p_Value;
					break;

				case 787209660:
					CloudLayer2SunLightIntensity = (float) p_Value;
					break;

				case 1463951660:
					CloudLayer2SunLightPower = (float) p_Value;
					break;

				case 983202188:
					CloudLayer2AmbientLightIntensity = (float) p_Value;
					break;

				case 1053850052:
					StaticEnvmapScale = (float) p_Value;
					break;

				case 1847986405:
					CloudLayer2AlphaMul = (float) p_Value;
					break;

				case 1201990938:
					CloudLayer2Texture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2547512451:
					StaticEnvmapTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 3116824337:
					SkyVisibilityExponent = (float) p_Value;
					break;

				case 3441001619:
					SkyEnvmap8BitTexScale = (float) p_Value;
					break;

				case 321006824:
					CustomEnvmapTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 3009704111:
					CustomEnvmapScale = (float) p_Value;
					break;

				case 1800201039:
					CustomEnvmapAmbient = (float) p_Value;
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
				case 2080466082:
					return CloudLayerSunColor;

				case 2853016120:
					return CloudLayer2Color;

				case 3041579739:
					return CloudLayer1Color;

				case 1001603005:
					return SkyGradientTexture;

				case 2149343816:
					return SunSize;

				case 1301955796:
					return BrightnessScale;

				case 2209231701:
					return SunScale;

				case 2272268590:
					return PanoramicUVMaxX;

				case 2272259825:
					return PanoramicUVMinY;

				case 2272268591:
					return PanoramicUVMaxY;

				case 229961746:
					return Realm;

				case 2272259824:
					return PanoramicUVMinX;

				case 2684028734:
					return PanoramicTexture;

				case 2261597450:
					return PanoramicAlphaTexture;

				case 4205943736:
					return PanoramicTileFactor;

				case 1350837372:
					return CloudLayerMaskTexture;

				case 2061086550:
					return CloudLayer1Altitude;

				case 1142043935:
					return CloudLayer1TileFactor;

				case 1760002578:
					return CloudLayer1Rotation;

				case 3059870497:
					return CloudLayer1Speed;

				case 1815101471:
					return CloudLayer1SunLightIntensity;

				case 980600565:
					return PanoramicRotation;

				case 1412432303:
					return CloudLayer1AmbientLightIntensity;

				case 650181263:
					return CloudLayer1SunLightPower;

				case 1904139366:
					return CloudLayer1AlphaMul;

				case 3691166713:
					return CloudLayer1Texture;

				case 2002768725:
					return CloudLayer2Altitude;

				case 2650580380:
					return CloudLayer2TileFactor;

				case 2105944465:
					return CloudLayer2Rotation;

				case 2871245762:
					return CloudLayer2Speed;

				case 787209660:
					return CloudLayer2SunLightIntensity;

				case 1463951660:
					return CloudLayer2SunLightPower;

				case 983202188:
					return CloudLayer2AmbientLightIntensity;

				case 1053850052:
					return StaticEnvmapScale;

				case 1847986405:
					return CloudLayer2AlphaMul;

				case 1201990938:
					return CloudLayer2Texture;

				case 2547512451:
					return StaticEnvmapTexture;

				case 3116824337:
					return SkyVisibilityExponent;

				case 3441001619:
					return SkyEnvmap8BitTexScale;

				case 321006824:
					return CustomEnvmapTexture;

				case 3009704111:
					return CustomEnvmapScale;

				case 1800201039:
					return CustomEnvmapAmbient;

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
				case 2080466082:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayerSunColor));

				case 2853016120:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2Color));

				case 3041579739:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1Color));

				case 1001603005:
					return typeof(SkyComponentData).GetProperty(nameof(SkyGradientTexture));

				case 2149343816:
					return typeof(SkyComponentData).GetProperty(nameof(SunSize));

				case 1301955796:
					return typeof(SkyComponentData).GetProperty(nameof(BrightnessScale));

				case 2209231701:
					return typeof(SkyComponentData).GetProperty(nameof(SunScale));

				case 2272268590:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicUVMaxX));

				case 2272259825:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicUVMinY));

				case 2272268591:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicUVMaxY));

				case 229961746:
					return typeof(SkyComponentData).GetProperty(nameof(Realm));

				case 2272259824:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicUVMinX));

				case 2684028734:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicTexture));

				case 2261597450:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicAlphaTexture));

				case 4205943736:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicTileFactor));

				case 1350837372:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayerMaskTexture));

				case 2061086550:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1Altitude));

				case 1142043935:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1TileFactor));

				case 1760002578:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1Rotation));

				case 3059870497:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1Speed));

				case 1815101471:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1SunLightIntensity));

				case 980600565:
					return typeof(SkyComponentData).GetProperty(nameof(PanoramicRotation));

				case 1412432303:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1AmbientLightIntensity));

				case 650181263:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1SunLightPower));

				case 1904139366:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1AlphaMul));

				case 3691166713:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer1Texture));

				case 2002768725:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2Altitude));

				case 2650580380:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2TileFactor));

				case 2105944465:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2Rotation));

				case 2871245762:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2Speed));

				case 787209660:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2SunLightIntensity));

				case 1463951660:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2SunLightPower));

				case 983202188:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2AmbientLightIntensity));

				case 1053850052:
					return typeof(SkyComponentData).GetProperty(nameof(StaticEnvmapScale));

				case 1847986405:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2AlphaMul));

				case 1201990938:
					return typeof(SkyComponentData).GetProperty(nameof(CloudLayer2Texture));

				case 2547512451:
					return typeof(SkyComponentData).GetProperty(nameof(StaticEnvmapTexture));

				case 3116824337:
					return typeof(SkyComponentData).GetProperty(nameof(SkyVisibilityExponent));

				case 3441001619:
					return typeof(SkyComponentData).GetProperty(nameof(SkyEnvmap8BitTexScale));

				case 321006824:
					return typeof(SkyComponentData).GetProperty(nameof(CustomEnvmapTexture));

				case 3009704111:
					return typeof(SkyComponentData).GetProperty(nameof(CustomEnvmapScale));

				case 1800201039:
					return typeof(SkyComponentData).GetProperty(nameof(CustomEnvmapAmbient));

				case 2342790116:
					return typeof(SkyComponentData).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
