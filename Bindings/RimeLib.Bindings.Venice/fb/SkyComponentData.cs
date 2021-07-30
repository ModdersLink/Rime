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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 304)]
	public class SkyComponentData : 
		ComponentData
	{
		protected Vec3 m_CloudLayerSunColor = new Vec3();
		[ContainerField(Name: "CloudLayerSunColor", Offset: 96, NameHash: 2080466082, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayerSunColor { get { return m_CloudLayerSunColor; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayerSunColor), this, m_CloudLayerSunColor, value)) m_CloudLayerSunColor = value; } } // 0x60 (96)
		
		protected Vec3 m_CloudLayer2Color = new Vec3();
		[ContainerField(Name: "CloudLayer2Color", Offset: 112, NameHash: 2853016120, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer2Color { get { return m_CloudLayer2Color; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2Color), this, m_CloudLayer2Color, value)) m_CloudLayer2Color = value; } } // 0x70 (112)
		
		protected Vec3 m_CloudLayer1Color = new Vec3();
		[ContainerField(Name: "CloudLayer1Color", Offset: 128, NameHash: 3041579739, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer1Color { get { return m_CloudLayer1Color; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1Color), this, m_CloudLayer1Color, value)) m_CloudLayer1Color = value; } } // 0x80 (128)
		
		protected CtrRef<TextureAsset> m_SkyGradientTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "SkyGradientTexture", Offset: 144, NameHash: 1001603005, Flags: 53)]
		public CtrRef<TextureAsset> SkyGradientTexture { get { return m_SkyGradientTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(SkyGradientTexture), this, m_SkyGradientTexture, value)) m_SkyGradientTexture = value; } } // 0x90 (144)
		
		protected float m_SunSize = new float();
		[ContainerField(Name: "SunSize", Offset: 148, NameHash: 2149343816, Flags: 49469), LayoutImmutable, Blittable]
		public float SunSize { get { return m_SunSize; } set { if (OnPropertyChanging("SkyComponentData." + nameof(SunSize), this, m_SunSize, value)) m_SunSize = value; } } // 0x94 (148)
		
		protected float m_BrightnessScale = new float();
		[ContainerField(Name: "BrightnessScale", Offset: 152, NameHash: 1301955796, Flags: 49469), LayoutImmutable, Blittable]
		public float BrightnessScale { get { return m_BrightnessScale; } set { if (OnPropertyChanging("SkyComponentData." + nameof(BrightnessScale), this, m_BrightnessScale, value)) m_BrightnessScale = value; } } // 0x98 (152)
		
		protected float m_SunScale = new float();
		[ContainerField(Name: "SunScale", Offset: 156, NameHash: 2209231701, Flags: 49469), LayoutImmutable, Blittable]
		public float SunScale { get { return m_SunScale; } set { if (OnPropertyChanging("SkyComponentData." + nameof(SunScale), this, m_SunScale, value)) m_SunScale = value; } } // 0x9C (156)
		
		protected float m_PanoramicUVMaxX = new float();
		[ContainerField(Name: "PanoramicUVMaxX", Offset: 160, NameHash: 2272268590, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicUVMaxX { get { return m_PanoramicUVMaxX; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicUVMaxX), this, m_PanoramicUVMaxX, value)) m_PanoramicUVMaxX = value; } } // 0xA0 (160)
		
		protected float m_PanoramicUVMinY = new float();
		[ContainerField(Name: "PanoramicUVMinY", Offset: 164, NameHash: 2272259825, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicUVMinY { get { return m_PanoramicUVMinY; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicUVMinY), this, m_PanoramicUVMinY, value)) m_PanoramicUVMinY = value; } } // 0xA4 (164)
		
		protected float m_PanoramicUVMaxY = new float();
		[ContainerField(Name: "PanoramicUVMaxY", Offset: 168, NameHash: 2272268591, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicUVMaxY { get { return m_PanoramicUVMaxY; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicUVMaxY), this, m_PanoramicUVMaxY, value)) m_PanoramicUVMaxY = value; } } // 0xA8 (168)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 172, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("SkyComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xAC (172)
		
		protected float m_PanoramicUVMinX = new float();
		[ContainerField(Name: "PanoramicUVMinX", Offset: 176, NameHash: 2272259824, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicUVMinX { get { return m_PanoramicUVMinX; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicUVMinX), this, m_PanoramicUVMinX, value)) m_PanoramicUVMinX = value; } } // 0xB0 (176)
		
		protected CtrRef<TextureAsset> m_PanoramicTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "PanoramicTexture", Offset: 180, NameHash: 2684028734, Flags: 53)]
		public CtrRef<TextureAsset> PanoramicTexture { get { return m_PanoramicTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicTexture), this, m_PanoramicTexture, value)) m_PanoramicTexture = value; } } // 0xB4 (180)
		
		protected CtrRef<TextureAsset> m_PanoramicAlphaTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "PanoramicAlphaTexture", Offset: 184, NameHash: 2261597450, Flags: 53)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get { return m_PanoramicAlphaTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicAlphaTexture), this, m_PanoramicAlphaTexture, value)) m_PanoramicAlphaTexture = value; } } // 0xB8 (184)
		
		protected float m_PanoramicTileFactor = new float();
		[ContainerField(Name: "PanoramicTileFactor", Offset: 188, NameHash: 4205943736, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicTileFactor { get { return m_PanoramicTileFactor; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicTileFactor), this, m_PanoramicTileFactor, value)) m_PanoramicTileFactor = value; } } // 0xBC (188)
		
		protected CtrRef<TextureAsset> m_CloudLayerMaskTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CloudLayerMaskTexture", Offset: 192, NameHash: 1350837372, Flags: 53)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get { return m_CloudLayerMaskTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayerMaskTexture), this, m_CloudLayerMaskTexture, value)) m_CloudLayerMaskTexture = value; } } // 0xC0 (192)
		
		protected float m_CloudLayer1Altitude = new float();
		[ContainerField(Name: "CloudLayer1Altitude", Offset: 196, NameHash: 2061086550, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1Altitude { get { return m_CloudLayer1Altitude; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1Altitude), this, m_CloudLayer1Altitude, value)) m_CloudLayer1Altitude = value; } } // 0xC4 (196)
		
		protected float m_CloudLayer1TileFactor = new float();
		[ContainerField(Name: "CloudLayer1TileFactor", Offset: 200, NameHash: 1142043935, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1TileFactor { get { return m_CloudLayer1TileFactor; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1TileFactor), this, m_CloudLayer1TileFactor, value)) m_CloudLayer1TileFactor = value; } } // 0xC8 (200)
		
		protected float m_CloudLayer1Rotation = new float();
		[ContainerField(Name: "CloudLayer1Rotation", Offset: 204, NameHash: 1760002578, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1Rotation { get { return m_CloudLayer1Rotation; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1Rotation), this, m_CloudLayer1Rotation, value)) m_CloudLayer1Rotation = value; } } // 0xCC (204)
		
		protected float m_CloudLayer1Speed = new float();
		[ContainerField(Name: "CloudLayer1Speed", Offset: 208, NameHash: 3059870497, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1Speed { get { return m_CloudLayer1Speed; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1Speed), this, m_CloudLayer1Speed, value)) m_CloudLayer1Speed = value; } } // 0xD0 (208)
		
		protected float m_CloudLayer1SunLightIntensity = new float();
		[ContainerField(Name: "CloudLayer1SunLightIntensity", Offset: 212, NameHash: 1815101471, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightIntensity { get { return m_CloudLayer1SunLightIntensity; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1SunLightIntensity), this, m_CloudLayer1SunLightIntensity, value)) m_CloudLayer1SunLightIntensity = value; } } // 0xD4 (212)
		
		protected float m_PanoramicRotation = new float();
		[ContainerField(Name: "PanoramicRotation", Offset: 216, NameHash: 980600565, Flags: 49469), LayoutImmutable, Blittable]
		public float PanoramicRotation { get { return m_PanoramicRotation; } set { if (OnPropertyChanging("SkyComponentData." + nameof(PanoramicRotation), this, m_PanoramicRotation, value)) m_PanoramicRotation = value; } } // 0xD8 (216)
		
		protected float m_CloudLayer1AmbientLightIntensity = new float();
		[ContainerField(Name: "CloudLayer1AmbientLightIntensity", Offset: 220, NameHash: 1412432303, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1AmbientLightIntensity { get { return m_CloudLayer1AmbientLightIntensity; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1AmbientLightIntensity), this, m_CloudLayer1AmbientLightIntensity, value)) m_CloudLayer1AmbientLightIntensity = value; } } // 0xDC (220)
		
		protected float m_CloudLayer1SunLightPower = new float();
		[ContainerField(Name: "CloudLayer1SunLightPower", Offset: 224, NameHash: 650181263, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightPower { get { return m_CloudLayer1SunLightPower; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1SunLightPower), this, m_CloudLayer1SunLightPower, value)) m_CloudLayer1SunLightPower = value; } } // 0xE0 (224)
		
		protected float m_CloudLayer1AlphaMul = new float();
		[ContainerField(Name: "CloudLayer1AlphaMul", Offset: 228, NameHash: 1904139366, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer1AlphaMul { get { return m_CloudLayer1AlphaMul; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1AlphaMul), this, m_CloudLayer1AlphaMul, value)) m_CloudLayer1AlphaMul = value; } } // 0xE4 (228)
		
		protected CtrRef<TextureAsset> m_CloudLayer1Texture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CloudLayer1Texture", Offset: 232, NameHash: 3691166713, Flags: 53)]
		public CtrRef<TextureAsset> CloudLayer1Texture { get { return m_CloudLayer1Texture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer1Texture), this, m_CloudLayer1Texture, value)) m_CloudLayer1Texture = value; } } // 0xE8 (232)
		
		protected float m_CloudLayer2Altitude = new float();
		[ContainerField(Name: "CloudLayer2Altitude", Offset: 236, NameHash: 2002768725, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2Altitude { get { return m_CloudLayer2Altitude; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2Altitude), this, m_CloudLayer2Altitude, value)) m_CloudLayer2Altitude = value; } } // 0xEC (236)
		
		protected float m_CloudLayer2TileFactor = new float();
		[ContainerField(Name: "CloudLayer2TileFactor", Offset: 240, NameHash: 2650580380, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2TileFactor { get { return m_CloudLayer2TileFactor; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2TileFactor), this, m_CloudLayer2TileFactor, value)) m_CloudLayer2TileFactor = value; } } // 0xF0 (240)
		
		protected float m_CloudLayer2Rotation = new float();
		[ContainerField(Name: "CloudLayer2Rotation", Offset: 244, NameHash: 2105944465, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2Rotation { get { return m_CloudLayer2Rotation; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2Rotation), this, m_CloudLayer2Rotation, value)) m_CloudLayer2Rotation = value; } } // 0xF4 (244)
		
		protected float m_CloudLayer2Speed = new float();
		[ContainerField(Name: "CloudLayer2Speed", Offset: 248, NameHash: 2871245762, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2Speed { get { return m_CloudLayer2Speed; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2Speed), this, m_CloudLayer2Speed, value)) m_CloudLayer2Speed = value; } } // 0xF8 (248)
		
		protected float m_CloudLayer2SunLightIntensity = new float();
		[ContainerField(Name: "CloudLayer2SunLightIntensity", Offset: 252, NameHash: 787209660, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightIntensity { get { return m_CloudLayer2SunLightIntensity; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2SunLightIntensity), this, m_CloudLayer2SunLightIntensity, value)) m_CloudLayer2SunLightIntensity = value; } } // 0xFC (252)
		
		protected float m_CloudLayer2SunLightPower = new float();
		[ContainerField(Name: "CloudLayer2SunLightPower", Offset: 256, NameHash: 1463951660, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightPower { get { return m_CloudLayer2SunLightPower; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2SunLightPower), this, m_CloudLayer2SunLightPower, value)) m_CloudLayer2SunLightPower = value; } } // 0x100 (256)
		
		protected float m_CloudLayer2AmbientLightIntensity = new float();
		[ContainerField(Name: "CloudLayer2AmbientLightIntensity", Offset: 260, NameHash: 983202188, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2AmbientLightIntensity { get { return m_CloudLayer2AmbientLightIntensity; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2AmbientLightIntensity), this, m_CloudLayer2AmbientLightIntensity, value)) m_CloudLayer2AmbientLightIntensity = value; } } // 0x104 (260)
		
		protected float m_StaticEnvmapScale = new float();
		[ContainerField(Name: "StaticEnvmapScale", Offset: 264, NameHash: 1053850052, Flags: 49469), LayoutImmutable, Blittable]
		public float StaticEnvmapScale { get { return m_StaticEnvmapScale; } set { if (OnPropertyChanging("SkyComponentData." + nameof(StaticEnvmapScale), this, m_StaticEnvmapScale, value)) m_StaticEnvmapScale = value; } } // 0x108 (264)
		
		protected float m_CloudLayer2AlphaMul = new float();
		[ContainerField(Name: "CloudLayer2AlphaMul", Offset: 268, NameHash: 1847986405, Flags: 49469), LayoutImmutable, Blittable]
		public float CloudLayer2AlphaMul { get { return m_CloudLayer2AlphaMul; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2AlphaMul), this, m_CloudLayer2AlphaMul, value)) m_CloudLayer2AlphaMul = value; } } // 0x10C (268)
		
		protected CtrRef<TextureAsset> m_CloudLayer2Texture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CloudLayer2Texture", Offset: 272, NameHash: 1201990938, Flags: 53)]
		public CtrRef<TextureAsset> CloudLayer2Texture { get { return m_CloudLayer2Texture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CloudLayer2Texture), this, m_CloudLayer2Texture, value)) m_CloudLayer2Texture = value; } } // 0x110 (272)
		
		protected CtrRef<TextureAsset> m_StaticEnvmapTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "StaticEnvmapTexture", Offset: 276, NameHash: 2547512451, Flags: 53)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get { return m_StaticEnvmapTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(StaticEnvmapTexture), this, m_StaticEnvmapTexture, value)) m_StaticEnvmapTexture = value; } } // 0x114 (276)
		
		protected float m_SkyVisibilityExponent = new float();
		[ContainerField(Name: "SkyVisibilityExponent", Offset: 280, NameHash: 3116824337, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyVisibilityExponent { get { return m_SkyVisibilityExponent; } set { if (OnPropertyChanging("SkyComponentData." + nameof(SkyVisibilityExponent), this, m_SkyVisibilityExponent, value)) m_SkyVisibilityExponent = value; } } // 0x118 (280)
		
		protected float m_SkyEnvmap8BitTexScale = new float();
		[ContainerField(Name: "SkyEnvmap8BitTexScale", Offset: 284, NameHash: 3441001619, Flags: 49469), LayoutImmutable, Blittable]
		public float SkyEnvmap8BitTexScale { get { return m_SkyEnvmap8BitTexScale; } set { if (OnPropertyChanging("SkyComponentData." + nameof(SkyEnvmap8BitTexScale), this, m_SkyEnvmap8BitTexScale, value)) m_SkyEnvmap8BitTexScale = value; } } // 0x11C (284)
		
		protected CtrRef<TextureAsset> m_CustomEnvmapTexture = new CtrRef<TextureAsset>();
		[ContainerField(Name: "CustomEnvmapTexture", Offset: 288, NameHash: 321006824, Flags: 53)]
		public CtrRef<TextureAsset> CustomEnvmapTexture { get { return m_CustomEnvmapTexture; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CustomEnvmapTexture), this, m_CustomEnvmapTexture, value)) m_CustomEnvmapTexture = value; } } // 0x120 (288)
		
		protected float m_CustomEnvmapScale = new float();
		[ContainerField(Name: "CustomEnvmapScale", Offset: 292, NameHash: 3009704111, Flags: 49469), LayoutImmutable, Blittable]
		public float CustomEnvmapScale { get { return m_CustomEnvmapScale; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CustomEnvmapScale), this, m_CustomEnvmapScale, value)) m_CustomEnvmapScale = value; } } // 0x124 (292)
		
		protected float m_CustomEnvmapAmbient = new float();
		[ContainerField(Name: "CustomEnvmapAmbient", Offset: 296, NameHash: 1800201039, Flags: 49469), LayoutImmutable, Blittable]
		public float CustomEnvmapAmbient { get { return m_CustomEnvmapAmbient; } set { if (OnPropertyChanging("SkyComponentData." + nameof(CustomEnvmapAmbient), this, m_CustomEnvmapAmbient, value)) m_CustomEnvmapAmbient = value; } } // 0x128 (296)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 300, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("SkyComponentData." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x12C (300)
		
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
