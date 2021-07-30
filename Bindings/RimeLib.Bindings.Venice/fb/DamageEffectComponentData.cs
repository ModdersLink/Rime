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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class DamageEffectComponentData : 
		ComponentData
	{
		protected Vec4 m_RightDamage = new Vec4();
		[ContainerField(Name: "RightDamage", Offset: 96, NameHash: 2283078382, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 RightDamage { get { return m_RightDamage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(RightDamage), this, m_RightDamage, value)) m_RightDamage = value; } } // 0x60 (96)
		
		protected Vec4 m_TopDamage = new Vec4();
		[ContainerField(Name: "TopDamage", Offset: 112, NameHash: 2171890277, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 TopDamage { get { return m_TopDamage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(TopDamage), this, m_TopDamage, value)) m_TopDamage = value; } } // 0x70 (112)
		
		protected Vec4 m_LeftDamage = new Vec4();
		[ContainerField(Name: "LeftDamage", Offset: 128, NameHash: 2720008853, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LeftDamage { get { return m_LeftDamage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(LeftDamage), this, m_LeftDamage, value)) m_LeftDamage = value; } } // 0x80 (128)
		
		protected Vec4 m_BottomDamage = new Vec4();
		[ContainerField(Name: "BottomDamage", Offset: 144, NameHash: 3247720289, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BottomDamage { get { return m_BottomDamage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(BottomDamage), this, m_BottomDamage, value)) m_BottomDamage = value; } } // 0x90 (144)
		
		protected float m_OuterFrameOpacity = new float();
		[ContainerField(Name: "OuterFrameOpacity", Offset: 160, NameHash: 2645729368, Flags: 49469), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get { return m_OuterFrameOpacity; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(OuterFrameOpacity), this, m_OuterFrameOpacity, value)) m_OuterFrameOpacity = value; } } // 0xA0 (160)
		
		protected float m_InnerFrameOpacity = new float();
		[ContainerField(Name: "InnerFrameOpacity", Offset: 164, NameHash: 2573293567, Flags: 49469), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get { return m_InnerFrameOpacity; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(InnerFrameOpacity), this, m_InnerFrameOpacity, value)) m_InnerFrameOpacity = value; } } // 0xA4 (164)
		
		protected float m_FrameWidth = new float();
		[ContainerField(Name: "FrameWidth", Offset: 168, NameHash: 727037822, Flags: 49469), LayoutImmutable, Blittable]
		public float FrameWidth { get { return m_FrameWidth; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(FrameWidth), this, m_FrameWidth, value)) m_FrameWidth = value; } } // 0xA8 (168)
		
		protected CtrRef<SurfaceShaderBaseAsset> m_Shader = new CtrRef<SurfaceShaderBaseAsset>();
		[ContainerField(Name: "Shader", Offset: 172, NameHash: 3352909900, Flags: 53)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get { return m_Shader; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(Shader), this, m_Shader, value)) m_Shader = value; } } // 0xAC (172)
		
		protected float m_StartCriticalEffectHealthThreshold = new float();
		[ContainerField(Name: "StartCriticalEffectHealthThreshold", Offset: 176, NameHash: 1373513650, Flags: 49469), LayoutImmutable, Blittable]
		public float StartCriticalEffectHealthThreshold { get { return m_StartCriticalEffectHealthThreshold; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(StartCriticalEffectHealthThreshold), this, m_StartCriticalEffectHealthThreshold, value)) m_StartCriticalEffectHealthThreshold = value; } } // 0xB0 (176)
		
		protected float m_EndCriticalEffectHealthThreshold = new float();
		[ContainerField(Name: "EndCriticalEffectHealthThreshold", Offset: 180, NameHash: 2805149341, Flags: 49469), LayoutImmutable, Blittable]
		public float EndCriticalEffectHealthThreshold { get { return m_EndCriticalEffectHealthThreshold; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(EndCriticalEffectHealthThreshold), this, m_EndCriticalEffectHealthThreshold, value)) m_EndCriticalEffectHealthThreshold = value; } } // 0xB4 (180)
		
		protected float m_MinDamagePercentageThreshold = new float();
		[ContainerField(Name: "MinDamagePercentageThreshold", Offset: 184, NameHash: 3453538411, Flags: 49469), LayoutImmutable, Blittable]
		public float MinDamagePercentageThreshold { get { return m_MinDamagePercentageThreshold; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(MinDamagePercentageThreshold), this, m_MinDamagePercentageThreshold, value)) m_MinDamagePercentageThreshold = value; } } // 0xB8 (184)
		
		protected float m_FallofTime = new float();
		[ContainerField(Name: "FallofTime", Offset: 188, NameHash: 2812010526, Flags: 49469), LayoutImmutable, Blittable]
		public float FallofTime { get { return m_FallofTime; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(FallofTime), this, m_FallofTime, value)) m_FallofTime = value; } } // 0xBC (188)
		
		protected float m_MaxOpacityDamagePercentage = new float();
		[ContainerField(Name: "MaxOpacityDamagePercentage", Offset: 192, NameHash: 3785402139, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxOpacityDamagePercentage { get { return m_MaxOpacityDamagePercentage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(MaxOpacityDamagePercentage), this, m_MaxOpacityDamagePercentage, value)) m_MaxOpacityDamagePercentage = value; } } // 0xC0 (192)
		
		protected Realm m_Realm = new Realm();
		[ContainerField(Name: "Realm", Offset: 196, NameHash: 229961746, Flags: 137)]
		public Realm Realm { get { return m_Realm; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(Realm), this, m_Realm, value)) m_Realm = value; } } // 0xC4 (196)
		
		protected bool m_DebugDamage = new bool();
		[ContainerField(Name: "DebugDamage", Offset: 200, NameHash: 4244670303, Flags: 49325), LayoutImmutable, Blittable]
		public bool DebugDamage { get { return m_DebugDamage; } set { if (OnPropertyChanging("DamageEffectComponentData." + nameof(DebugDamage), this, m_DebugDamage, value)) m_DebugDamage = value; } } // 0xC8 (200)
		
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
