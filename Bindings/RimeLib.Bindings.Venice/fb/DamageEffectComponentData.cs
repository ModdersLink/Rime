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
	public class DamageEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 RightDamage { get; set; } = new Vec4(); // 0x60 (96)
		
		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 TopDamage { get; set; } = new Vec4(); // 0x70 (112)
		
		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LeftDamage { get; set; } = new Vec4(); // 0x80 (128)
		
		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BottomDamage { get; set; } = new Vec4(); // 0x90 (144)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; } // 0xA8 (168)
		
		[ContainerField(172)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new CtrRef<SurfaceShaderBaseAsset>(); // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float StartCriticalEffectHealthThreshold { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public float EndCriticalEffectHealthThreshold { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float MinDamagePercentageThreshold { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float FallofTime { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public float MaxOpacityDamagePercentage { get; set; } // 0xC0 (192)
		
		[ContainerField(196)]
		public Realm Realm { get; set; } = new Realm(); // 0xC4 (196)
		
		[ContainerField(200), LayoutImmutable, Blittable]
		public bool DebugDamage { get; set; } // 0xC8 (200)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2283078382:
					RightDamage = (Vec4) p_Value;
					break;

				case 2171890277:
					TopDamage = (Vec4) p_Value;
					break;

				case 2720008853:
					LeftDamage = (Vec4) p_Value;
					break;

				case 3247720289:
					BottomDamage = (Vec4) p_Value;
					break;

				case 2645729368:
					OuterFrameOpacity = (float) p_Value;
					break;

				case 2573293567:
					InnerFrameOpacity = (float) p_Value;
					break;

				case 727037822:
					FrameWidth = (float) p_Value;
					break;

				case 3352909900:
					Shader = (CtrRef<SurfaceShaderBaseAsset>) p_Value;
					break;

				case 1373513650:
					StartCriticalEffectHealthThreshold = (float) p_Value;
					break;

				case 2805149341:
					EndCriticalEffectHealthThreshold = (float) p_Value;
					break;

				case 3453538411:
					MinDamagePercentageThreshold = (float) p_Value;
					break;

				case 2812010526:
					FallofTime = (float) p_Value;
					break;

				case 3785402139:
					MaxOpacityDamagePercentage = (float) p_Value;
					break;

				case 229961746:
					Realm = (Realm) Enum.ToObject(typeof(Realm), p_Value);
					break;

				case 4244670303:
					DebugDamage = (bool) p_Value;
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
				case 2283078382:
					return RightDamage;

				case 2171890277:
					return TopDamage;

				case 2720008853:
					return LeftDamage;

				case 3247720289:
					return BottomDamage;

				case 2645729368:
					return OuterFrameOpacity;

				case 2573293567:
					return InnerFrameOpacity;

				case 727037822:
					return FrameWidth;

				case 3352909900:
					return Shader;

				case 1373513650:
					return StartCriticalEffectHealthThreshold;

				case 2805149341:
					return EndCriticalEffectHealthThreshold;

				case 3453538411:
					return MinDamagePercentageThreshold;

				case 2812010526:
					return FallofTime;

				case 3785402139:
					return MaxOpacityDamagePercentage;

				case 229961746:
					return Realm;

				case 4244670303:
					return DebugDamage;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2283078382:
					return typeof(DamageEffectComponentData).GetProperty(nameof(RightDamage));

				case 2171890277:
					return typeof(DamageEffectComponentData).GetProperty(nameof(TopDamage));

				case 2720008853:
					return typeof(DamageEffectComponentData).GetProperty(nameof(LeftDamage));

				case 3247720289:
					return typeof(DamageEffectComponentData).GetProperty(nameof(BottomDamage));

				case 2645729368:
					return typeof(DamageEffectComponentData).GetProperty(nameof(OuterFrameOpacity));

				case 2573293567:
					return typeof(DamageEffectComponentData).GetProperty(nameof(InnerFrameOpacity));

				case 727037822:
					return typeof(DamageEffectComponentData).GetProperty(nameof(FrameWidth));

				case 3352909900:
					return typeof(DamageEffectComponentData).GetProperty(nameof(Shader));

				case 1373513650:
					return typeof(DamageEffectComponentData).GetProperty(nameof(StartCriticalEffectHealthThreshold));

				case 2805149341:
					return typeof(DamageEffectComponentData).GetProperty(nameof(EndCriticalEffectHealthThreshold));

				case 3453538411:
					return typeof(DamageEffectComponentData).GetProperty(nameof(MinDamagePercentageThreshold));

				case 2812010526:
					return typeof(DamageEffectComponentData).GetProperty(nameof(FallofTime));

				case 3785402139:
					return typeof(DamageEffectComponentData).GetProperty(nameof(MaxOpacityDamagePercentage));

				case 229961746:
					return typeof(DamageEffectComponentData).GetProperty(nameof(Realm));

				case 4244670303:
					return typeof(DamageEffectComponentData).GetProperty(nameof(DebugDamage));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
