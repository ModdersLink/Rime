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
using RimeLib.Frostbite.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 53, Size: 100)]
	public class HudCameraShakeData : 
		UIComponentData
	{
		protected float m_WeaponDispersionMin = new float();
		[ContainerField(Name: "WeaponDispersionMin", Offset: 28, NameHash: 2596092207, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponDispersionMin { get { return m_WeaponDispersionMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionMin), this, m_WeaponDispersionMin, value)) m_WeaponDispersionMin = value; } } // 0x1C (28)
		
		protected float m_WeaponDispersionMax = new float();
		[ContainerField(Name: "WeaponDispersionMax", Offset: 32, NameHash: 2596092465, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponDispersionMax { get { return m_WeaponDispersionMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionMax), this, m_WeaponDispersionMax, value)) m_WeaponDispersionMax = value; } } // 0x20 (32)
		
		protected float m_WeaponDispersionOffsetScale = new float();
		[ContainerField(Name: "WeaponDispersionOffsetScale", Offset: 36, NameHash: 2636099696, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponDispersionOffsetScale { get { return m_WeaponDispersionOffsetScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionOffsetScale), this, m_WeaponDispersionOffsetScale, value)) m_WeaponDispersionOffsetScale = value; } } // 0x24 (36)
		
		protected float m_JumpEffectDurationMin = new float();
		[ContainerField(Name: "JumpEffectDurationMin", Offset: 40, NameHash: 3119984708, Flags: 49469), LayoutImmutable, Blittable]
		public float JumpEffectDurationMin { get { return m_JumpEffectDurationMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectDurationMin), this, m_JumpEffectDurationMin, value)) m_JumpEffectDurationMin = value; } } // 0x28 (40)
		
		protected float m_JumpEffectDurationMax = new float();
		[ContainerField(Name: "JumpEffectDurationMax", Offset: 44, NameHash: 3119984474, Flags: 49469), LayoutImmutable, Blittable]
		public float JumpEffectDurationMax { get { return m_JumpEffectDurationMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectDurationMax), this, m_JumpEffectDurationMax, value)) m_JumpEffectDurationMax = value; } } // 0x2C (44)
		
		protected float m_JumpEffectMin = new float();
		[ContainerField(Name: "JumpEffectMin", Offset: 48, NameHash: 2038531226, Flags: 49469), LayoutImmutable, Blittable]
		public float JumpEffectMin { get { return m_JumpEffectMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectMin), this, m_JumpEffectMin, value)) m_JumpEffectMin = value; } } // 0x30 (48)
		
		protected float m_JumpEffectMax = new float();
		[ContainerField(Name: "JumpEffectMax", Offset: 52, NameHash: 2038531460, Flags: 49469), LayoutImmutable, Blittable]
		public float JumpEffectMax { get { return m_JumpEffectMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectMax), this, m_JumpEffectMax, value)) m_JumpEffectMax = value; } } // 0x34 (52)
		
		protected float m_LandEffectDurationMin = new float();
		[ContainerField(Name: "LandEffectDurationMin", Offset: 56, NameHash: 3149698945, Flags: 49469), LayoutImmutable, Blittable]
		public float LandEffectDurationMin { get { return m_LandEffectDurationMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectDurationMin), this, m_LandEffectDurationMin, value)) m_LandEffectDurationMin = value; } } // 0x38 (56)
		
		protected float m_LandEffectDurationMax = new float();
		[ContainerField(Name: "LandEffectDurationMax", Offset: 60, NameHash: 3149698719, Flags: 49469), LayoutImmutable, Blittable]
		public float LandEffectDurationMax { get { return m_LandEffectDurationMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectDurationMax), this, m_LandEffectDurationMax, value)) m_LandEffectDurationMax = value; } } // 0x3C (60)
		
		protected float m_LandEffectMin = new float();
		[ContainerField(Name: "LandEffectMin", Offset: 64, NameHash: 2460750495, Flags: 49469), LayoutImmutable, Blittable]
		public float LandEffectMin { get { return m_LandEffectMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectMin), this, m_LandEffectMin, value)) m_LandEffectMin = value; } } // 0x40 (64)
		
		protected float m_LandEffectMax = new float();
		[ContainerField(Name: "LandEffectMax", Offset: 68, NameHash: 2460750721, Flags: 49469), LayoutImmutable, Blittable]
		public float LandEffectMax { get { return m_LandEffectMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectMax), this, m_LandEffectMax, value)) m_LandEffectMax = value; } } // 0x44 (68)
		
		protected float m_CameraShakeMinAngle = new float();
		[ContainerField(Name: "CameraShakeMinAngle", Offset: 72, NameHash: 939510435, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraShakeMinAngle { get { return m_CameraShakeMinAngle; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeMinAngle), this, m_CameraShakeMinAngle, value)) m_CameraShakeMinAngle = value; } } // 0x48 (72)
		
		protected float m_CameraShakeMaxAngle = new float();
		[ContainerField(Name: "CameraShakeMaxAngle", Offset: 76, NameHash: 375932157, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraShakeMaxAngle { get { return m_CameraShakeMaxAngle; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeMaxAngle), this, m_CameraShakeMaxAngle, value)) m_CameraShakeMaxAngle = value; } } // 0x4C (76)
		
		protected float m_CameraShakeScale = new float();
		[ContainerField(Name: "CameraShakeScale", Offset: 80, NameHash: 3342909616, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraShakeScale { get { return m_CameraShakeScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeScale), this, m_CameraShakeScale, value)) m_CameraShakeScale = value; } } // 0x50 (80)
		
		protected float m_WeaponLagXScale = new float();
		[ContainerField(Name: "WeaponLagXScale", Offset: 84, NameHash: 994760237, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponLagXScale { get { return m_WeaponLagXScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponLagXScale), this, m_WeaponLagXScale, value)) m_WeaponLagXScale = value; } } // 0x54 (84)
		
		protected float m_WeaponLagYScale = new float();
		[ContainerField(Name: "WeaponLagYScale", Offset: 88, NameHash: 1109790412, Flags: 49469), LayoutImmutable, Blittable]
		public float WeaponLagYScale { get { return m_WeaponLagYScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponLagYScale), this, m_WeaponLagYScale, value)) m_WeaponLagYScale = value; } } // 0x58 (88)
		
		protected uint m_FilterSize = new uint();
		[ContainerField(Name: "FilterSize", Offset: 92, NameHash: 2796213248, Flags: 49421), LayoutImmutable, Blittable]
		public uint FilterSize { get { return m_FilterSize; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(FilterSize), this, m_FilterSize, value)) m_FilterSize = value; } } // 0x5C (92)
		
		protected float m_MaxDisplacement = new float();
		[ContainerField(Name: "MaxDisplacement", Offset: 96, NameHash: 263952390, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDisplacement { get { return m_MaxDisplacement; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(MaxDisplacement), this, m_MaxDisplacement, value)) m_MaxDisplacement = value; } } // 0x60 (96)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2596092207:
					WeaponDispersionMin = (float) p_Value;
					break;

				case 2596092465:
					WeaponDispersionMax = (float) p_Value;
					break;

				case 2636099696:
					WeaponDispersionOffsetScale = (float) p_Value;
					break;

				case 3119984708:
					JumpEffectDurationMin = (float) p_Value;
					break;

				case 3119984474:
					JumpEffectDurationMax = (float) p_Value;
					break;

				case 2038531226:
					JumpEffectMin = (float) p_Value;
					break;

				case 2038531460:
					JumpEffectMax = (float) p_Value;
					break;

				case 3149698945:
					LandEffectDurationMin = (float) p_Value;
					break;

				case 3149698719:
					LandEffectDurationMax = (float) p_Value;
					break;

				case 2460750495:
					LandEffectMin = (float) p_Value;
					break;

				case 2460750721:
					LandEffectMax = (float) p_Value;
					break;

				case 939510435:
					CameraShakeMinAngle = (float) p_Value;
					break;

				case 375932157:
					CameraShakeMaxAngle = (float) p_Value;
					break;

				case 3342909616:
					CameraShakeScale = (float) p_Value;
					break;

				case 994760237:
					WeaponLagXScale = (float) p_Value;
					break;

				case 1109790412:
					WeaponLagYScale = (float) p_Value;
					break;

				case 2796213248:
					FilterSize = (uint) p_Value;
					break;

				case 263952390:
					MaxDisplacement = (float) p_Value;
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
				case 2596092207:
					return WeaponDispersionMin;

				case 2596092465:
					return WeaponDispersionMax;

				case 2636099696:
					return WeaponDispersionOffsetScale;

				case 3119984708:
					return JumpEffectDurationMin;

				case 3119984474:
					return JumpEffectDurationMax;

				case 2038531226:
					return JumpEffectMin;

				case 2038531460:
					return JumpEffectMax;

				case 3149698945:
					return LandEffectDurationMin;

				case 3149698719:
					return LandEffectDurationMax;

				case 2460750495:
					return LandEffectMin;

				case 2460750721:
					return LandEffectMax;

				case 939510435:
					return CameraShakeMinAngle;

				case 375932157:
					return CameraShakeMaxAngle;

				case 3342909616:
					return CameraShakeScale;

				case 994760237:
					return WeaponLagXScale;

				case 1109790412:
					return WeaponLagYScale;

				case 2796213248:
					return FilterSize;

				case 263952390:
					return MaxDisplacement;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2596092207:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionMin));

				case 2596092465:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionMax));

				case 2636099696:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponDispersionOffsetScale));

				case 3119984708:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectDurationMin));

				case 3119984474:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectDurationMax));

				case 2038531226:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectMin));

				case 2038531460:
					return typeof(HudCameraShakeData).GetProperty(nameof(JumpEffectMax));

				case 3149698945:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectDurationMin));

				case 3149698719:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectDurationMax));

				case 2460750495:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectMin));

				case 2460750721:
					return typeof(HudCameraShakeData).GetProperty(nameof(LandEffectMax));

				case 939510435:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeMinAngle));

				case 375932157:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeMaxAngle));

				case 3342909616:
					return typeof(HudCameraShakeData).GetProperty(nameof(CameraShakeScale));

				case 994760237:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponLagXScale));

				case 1109790412:
					return typeof(HudCameraShakeData).GetProperty(nameof(WeaponLagYScale));

				case 2796213248:
					return typeof(HudCameraShakeData).GetProperty(nameof(FilterSize));

				case 263952390:
					return typeof(HudCameraShakeData).GetProperty(nameof(MaxDisplacement));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
