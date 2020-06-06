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
	public class OutdoorLightEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get; set; } = new Vec3(); // 0x10 (16)
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get; set; } = new Vec3(); // 0x20 (32)
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get; set; } = new Vec3(); // 0x30 (48)
		
		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get; set; } = new Vec2(); // 0x40 (64)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new CtrRef<TextureAsset>(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float CloudShadowSize { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; } // 0x68 (104)
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x69 (105)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3778322649:
					SkyColor = (Vec3) p_Value;
					break;

				case 1770880637:
					GroundColor = (Vec3) p_Value;
					break;

				case 2189837744:
					SunColor = (Vec3) p_Value;
					break;

				case 4285381109:
					CloudShadowSpeed = (Vec2) p_Value;
					break;

				case 2283294049:
					SunRotationX = (float) p_Value;
					break;

				case 2283294048:
					SunRotationY = (float) p_Value;
					break;

				case 4138591318:
					SkyLightAngleFactor = (float) p_Value;
					break;

				case 2049987628:
					SunShadowHeightScale = (float) p_Value;
					break;

				case 1607365037:
					CloudShadowTexture = (CtrRef<TextureAsset>) p_Value;
					break;

				case 2732862871:
					CloudShadowSize = (float) p_Value;
					break;

				case 1934044673:
					CloudShadowExponent = (float) p_Value;
					break;

				case 535106300:
					CloudShadowCoverage = (float) p_Value;
					break;

				case 380549299:
					CloudShadowEnable = (bool) p_Value;
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
				case 3778322649:
					return SkyColor;

				case 1770880637:
					return GroundColor;

				case 2189837744:
					return SunColor;

				case 4285381109:
					return CloudShadowSpeed;

				case 2283294049:
					return SunRotationX;

				case 2283294048:
					return SunRotationY;

				case 4138591318:
					return SkyLightAngleFactor;

				case 2049987628:
					return SunShadowHeightScale;

				case 1607365037:
					return CloudShadowTexture;

				case 2732862871:
					return CloudShadowSize;

				case 1934044673:
					return CloudShadowExponent;

				case 535106300:
					return CloudShadowCoverage;

				case 380549299:
					return CloudShadowEnable;

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
				case 3778322649:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SkyColor));

				case 1770880637:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(GroundColor));

				case 2189837744:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunColor));

				case 4285381109:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowSpeed));

				case 2283294049:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunRotationX));

				case 2283294048:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunRotationY));

				case 4138591318:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SkyLightAngleFactor));

				case 2049987628:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(SunShadowHeightScale));

				case 1607365037:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowTexture));

				case 2732862871:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowSize));

				case 1934044673:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowExponent));

				case 535106300:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowCoverage));

				case 380549299:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(CloudShadowEnable));

				case 2342790116:
					return typeof(OutdoorLightEffectState).GetProperty(nameof(Enable));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
