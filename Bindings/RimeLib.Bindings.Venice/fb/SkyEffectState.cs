///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class SkyEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayerSunColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float PanoramicTileFactor { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float SunSize { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SkyGradientScale { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float SunScale { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float PanoramicUVMinX { get; set; } // 0x30 (48)
		
		[ContainerField(52)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float PanoramicUVMinY { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float PanoramicUVMaxY { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float PanoramicUVMaxX { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float PanoramicRotation { get; set; } // 0x44 (68)
		
		[ContainerField(72)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x48 (72)
		
		[ContainerField(76)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float WindDirection { get; set; } // 0x50 (80)
		
		[ContainerField(84)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x54 (84)
		
		[ContainerField(96)]
		public SkyCloudLayer CloudLayer1 { get; set; } = new SkyCloudLayer(); // 0x60 (96)
		
		[ContainerField(160)]
		public SkyCloudLayer CloudLayer2 { get; set; } = new SkyCloudLayer(); // 0xA0 (160)
		
		[ContainerField(224)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new CtrRef<TextureAsset>(); // 0xE0 (224)
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0xE4 (228)
		
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
