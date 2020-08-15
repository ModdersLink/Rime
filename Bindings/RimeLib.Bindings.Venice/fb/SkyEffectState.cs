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
	public class SkyEffectState : 
		DataContainer
	{
		protected Vec3 m_CloudLayerSunColor = new Vec3();
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, ContainerFieldNameHash(2080466082)]
		public Vec3 CloudLayerSunColor { get { return m_CloudLayerSunColor; } set { if (OnPropertyChanging("SkyEffectState." + nameof(CloudLayerSunColor), this, m_CloudLayerSunColor, value)) m_CloudLayerSunColor = value; } } // 0x10 (16)
		
		protected float m_PanoramicTileFactor = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(4205943736)]
		public float PanoramicTileFactor { get { return m_PanoramicTileFactor; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicTileFactor), this, m_PanoramicTileFactor, value)) m_PanoramicTileFactor = value; } } // 0x20 (32)
		
		protected float m_SunSize = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2149343816)]
		public float SunSize { get { return m_SunSize; } set { if (OnPropertyChanging("SkyEffectState." + nameof(SunSize), this, m_SunSize, value)) m_SunSize = value; } } // 0x24 (36)
		
		protected float m_SkyGradientScale = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3803360250)]
		public float SkyGradientScale { get { return m_SkyGradientScale; } set { if (OnPropertyChanging("SkyEffectState." + nameof(SkyGradientScale), this, m_SkyGradientScale, value)) m_SkyGradientScale = value; } } // 0x28 (40)
		
		protected float m_SunScale = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(2209231701)]
		public float SunScale { get { return m_SunScale; } set { if (OnPropertyChanging("SkyEffectState." + nameof(SunScale), this, m_SunScale, value)) m_SunScale = value; } } // 0x2C (44)
		
		protected float m_PanoramicUVMinX = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2272259824)]
		public float PanoramicUVMinX { get { return m_PanoramicUVMinX; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicUVMinX), this, m_PanoramicUVMinX, value)) m_PanoramicUVMinX = value; } } // 0x30 (48)
		
		protected CtrRef<TextureAsset> m_SkyGradientTexture = new CtrRef<TextureAsset>();
		[ContainerField(52), ContainerFieldNameHash(1001603005)]
		public CtrRef<TextureAsset> SkyGradientTexture { get { return m_SkyGradientTexture; } set { if (OnPropertyChanging("SkyEffectState." + nameof(SkyGradientTexture), this, m_SkyGradientTexture, value)) m_SkyGradientTexture = value; } } // 0x34 (52)
		
		protected float m_PanoramicUVMinY = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(2272259825)]
		public float PanoramicUVMinY { get { return m_PanoramicUVMinY; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicUVMinY), this, m_PanoramicUVMinY, value)) m_PanoramicUVMinY = value; } } // 0x38 (56)
		
		protected float m_PanoramicUVMaxY = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2272268591)]
		public float PanoramicUVMaxY { get { return m_PanoramicUVMaxY; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicUVMaxY), this, m_PanoramicUVMaxY, value)) m_PanoramicUVMaxY = value; } } // 0x3C (60)
		
		protected float m_PanoramicUVMaxX = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2272268590)]
		public float PanoramicUVMaxX { get { return m_PanoramicUVMaxX; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicUVMaxX), this, m_PanoramicUVMaxX, value)) m_PanoramicUVMaxX = value; } } // 0x40 (64)
		
		protected float m_PanoramicRotation = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(980600565)]
		public float PanoramicRotation { get { return m_PanoramicRotation; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicRotation), this, m_PanoramicRotation, value)) m_PanoramicRotation = value; } } // 0x44 (68)
		
		protected CtrRef<TextureAsset> m_PanoramicTexture = new CtrRef<TextureAsset>();
		[ContainerField(72), ContainerFieldNameHash(2684028734)]
		public CtrRef<TextureAsset> PanoramicTexture { get { return m_PanoramicTexture; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicTexture), this, m_PanoramicTexture, value)) m_PanoramicTexture = value; } } // 0x48 (72)
		
		protected CtrRef<TextureAsset> m_PanoramicAlphaTexture = new CtrRef<TextureAsset>();
		[ContainerField(76), ContainerFieldNameHash(2261597450)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get { return m_PanoramicAlphaTexture; } set { if (OnPropertyChanging("SkyEffectState." + nameof(PanoramicAlphaTexture), this, m_PanoramicAlphaTexture, value)) m_PanoramicAlphaTexture = value; } } // 0x4C (76)
		
		protected float m_WindDirection = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(3147800788)]
		public float WindDirection { get { return m_WindDirection; } set { if (OnPropertyChanging("SkyEffectState." + nameof(WindDirection), this, m_WindDirection, value)) m_WindDirection = value; } } // 0x50 (80)
		
		protected CtrRef<TextureAsset> m_CloudLayerMaskTexture = new CtrRef<TextureAsset>();
		[ContainerField(84), ContainerFieldNameHash(1350837372)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get { return m_CloudLayerMaskTexture; } set { if (OnPropertyChanging("SkyEffectState." + nameof(CloudLayerMaskTexture), this, m_CloudLayerMaskTexture, value)) m_CloudLayerMaskTexture = value; } } // 0x54 (84)
		
		protected SkyCloudLayer m_CloudLayer1 = new SkyCloudLayer();
		[ContainerField(96), ContainerFieldNameHash(1938926278)]
		public SkyCloudLayer CloudLayer1 { get { return m_CloudLayer1; } set { if (OnPropertyChanging("SkyEffectState." + nameof(CloudLayer1), this, m_CloudLayer1, value)) m_CloudLayer1 = value; } } // 0x60 (96)
		
		protected SkyCloudLayer m_CloudLayer2 = new SkyCloudLayer();
		[ContainerField(160), ContainerFieldNameHash(1938926277)]
		public SkyCloudLayer CloudLayer2 { get { return m_CloudLayer2; } set { if (OnPropertyChanging("SkyEffectState." + nameof(CloudLayer2), this, m_CloudLayer2, value)) m_CloudLayer2 = value; } } // 0xA0 (160)
		
		protected CtrRef<TextureAsset> m_StaticEnvmapTexture = new CtrRef<TextureAsset>();
		[ContainerField(224), ContainerFieldNameHash(2547512451)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get { return m_StaticEnvmapTexture; } set { if (OnPropertyChanging("SkyEffectState." + nameof(StaticEnvmapTexture), this, m_StaticEnvmapTexture, value)) m_StaticEnvmapTexture = value; } } // 0xE0 (224)
		
		protected bool m_Enable = new bool();
		[ContainerField(228), LayoutImmutable, Blittable, ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("SkyEffectState." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0xE4 (228)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2080466082:
					CloudLayerSunColor = (Vec3) p_Value;
					break;

				case 4205943736:
					PanoramicTileFactor = (float) p_Value;
					break;

				case 2149343816:
					SunSize = (float) p_Value;
					break;

				case 3803360250:
					SkyGradientScale = (float) p_Value;
					break;

				case 2209231701:
					SunScale = (float) p_Value;
					break;

				case 2272259824:
					PanoramicUVMinX = (float) p_Value;
					break;

				case 1001603005:
					SkyGradientTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2272259825:
					PanoramicUVMinY = (float) p_Value;
					break;

				case 2272268591:
					PanoramicUVMaxY = (float) p_Value;
					break;

				case 2272268590:
					PanoramicUVMaxX = (float) p_Value;
					break;

				case 980600565:
					PanoramicRotation = (float) p_Value;
					break;

				case 2684028734:
					PanoramicTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2261597450:
					PanoramicAlphaTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 3147800788:
					WindDirection = (float) p_Value;
					break;

				case 1350837372:
					CloudLayerMaskTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 1938926278:
					CloudLayer1 = (SkyCloudLayer) p_Value;
					break;

				case 1938926277:
					CloudLayer2 = (SkyCloudLayer) p_Value;
					break;

				case 2547512451:
					StaticEnvmapTexture = (CtrRef<TextureAsset>) p_Value;
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

				case 4205943736:
					return PanoramicTileFactor;

				case 2149343816:
					return SunSize;

				case 3803360250:
					return SkyGradientScale;

				case 2209231701:
					return SunScale;

				case 2272259824:
					return PanoramicUVMinX;

				case 1001603005:
					return SkyGradientTexture;

				case 2272259825:
					return PanoramicUVMinY;

				case 2272268591:
					return PanoramicUVMaxY;

				case 2272268590:
					return PanoramicUVMaxX;

				case 980600565:
					return PanoramicRotation;

				case 2684028734:
					return PanoramicTexture;

				case 2261597450:
					return PanoramicAlphaTexture;

				case 3147800788:
					return WindDirection;

				case 1350837372:
					return CloudLayerMaskTexture;

				case 1938926278:
					return CloudLayer1;

				case 1938926277:
					return CloudLayer2;

				case 2547512451:
					return StaticEnvmapTexture;

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
					return typeof(SkyEffectState).GetProperty(nameof(CloudLayerSunColor));

				case 4205943736:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicTileFactor));

				case 2149343816:
					return typeof(SkyEffectState).GetProperty(nameof(SunSize));

				case 3803360250:
					return typeof(SkyEffectState).GetProperty(nameof(SkyGradientScale));

				case 2209231701:
					return typeof(SkyEffectState).GetProperty(nameof(SunScale));

				case 2272259824:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicUVMinX));

				case 1001603005:
					return typeof(SkyEffectState).GetProperty(nameof(SkyGradientTexture));

				case 2272259825:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicUVMinY));

				case 2272268591:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicUVMaxY));

				case 2272268590:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicUVMaxX));

				case 980600565:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicRotation));

				case 2684028734:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicTexture));

				case 2261597450:
					return typeof(SkyEffectState).GetProperty(nameof(PanoramicAlphaTexture));

				case 3147800788:
					return typeof(SkyEffectState).GetProperty(nameof(WindDirection));

				case 1350837372:
					return typeof(SkyEffectState).GetProperty(nameof(CloudLayerMaskTexture));

				case 1938926278:
					return typeof(SkyEffectState).GetProperty(nameof(CloudLayer1));

				case 1938926277:
					return typeof(SkyEffectState).GetProperty(nameof(CloudLayer2));

				case 2547512451:
					return typeof(SkyEffectState).GetProperty(nameof(StaticEnvmapTexture));

				case 2342790116:
					return typeof(SkyEffectState).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
