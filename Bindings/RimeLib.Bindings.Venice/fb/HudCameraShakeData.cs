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
	[ContainerType(4)]
	public class HudCameraShakeData : 
		UIComponentData
	{
		protected float m_WeaponDispersionMin = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2596092207)]
		public float WeaponDispersionMin { get { return m_WeaponDispersionMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionMin), this, m_WeaponDispersionMin, value)) m_WeaponDispersionMin = value; } } // 0x1C (28)
		
		protected float m_WeaponDispersionMax = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2596092465)]
		public float WeaponDispersionMax { get { return m_WeaponDispersionMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionMax), this, m_WeaponDispersionMax, value)) m_WeaponDispersionMax = value; } } // 0x20 (32)
		
		protected float m_WeaponDispersionOffsetScale = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(2636099696)]
		public float WeaponDispersionOffsetScale { get { return m_WeaponDispersionOffsetScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponDispersionOffsetScale), this, m_WeaponDispersionOffsetScale, value)) m_WeaponDispersionOffsetScale = value; } } // 0x24 (36)
		
		protected float m_JumpEffectDurationMin = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(3119984708)]
		public float JumpEffectDurationMin { get { return m_JumpEffectDurationMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectDurationMin), this, m_JumpEffectDurationMin, value)) m_JumpEffectDurationMin = value; } } // 0x28 (40)
		
		protected float m_JumpEffectDurationMax = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(3119984474)]
		public float JumpEffectDurationMax { get { return m_JumpEffectDurationMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectDurationMax), this, m_JumpEffectDurationMax, value)) m_JumpEffectDurationMax = value; } } // 0x2C (44)
		
		protected float m_JumpEffectMin = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(2038531226)]
		public float JumpEffectMin { get { return m_JumpEffectMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectMin), this, m_JumpEffectMin, value)) m_JumpEffectMin = value; } } // 0x30 (48)
		
		protected float m_JumpEffectMax = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(2038531460)]
		public float JumpEffectMax { get { return m_JumpEffectMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(JumpEffectMax), this, m_JumpEffectMax, value)) m_JumpEffectMax = value; } } // 0x34 (52)
		
		protected float m_LandEffectDurationMin = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(3149698945)]
		public float LandEffectDurationMin { get { return m_LandEffectDurationMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectDurationMin), this, m_LandEffectDurationMin, value)) m_LandEffectDurationMin = value; } } // 0x38 (56)
		
		protected float m_LandEffectDurationMax = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(3149698719)]
		public float LandEffectDurationMax { get { return m_LandEffectDurationMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectDurationMax), this, m_LandEffectDurationMax, value)) m_LandEffectDurationMax = value; } } // 0x3C (60)
		
		protected float m_LandEffectMin = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(2460750495)]
		public float LandEffectMin { get { return m_LandEffectMin; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectMin), this, m_LandEffectMin, value)) m_LandEffectMin = value; } } // 0x40 (64)
		
		protected float m_LandEffectMax = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(2460750721)]
		public float LandEffectMax { get { return m_LandEffectMax; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(LandEffectMax), this, m_LandEffectMax, value)) m_LandEffectMax = value; } } // 0x44 (68)
		
		protected float m_CameraShakeMinAngle = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(939510435)]
		public float CameraShakeMinAngle { get { return m_CameraShakeMinAngle; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeMinAngle), this, m_CameraShakeMinAngle, value)) m_CameraShakeMinAngle = value; } } // 0x48 (72)
		
		protected float m_CameraShakeMaxAngle = new float();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(375932157)]
		public float CameraShakeMaxAngle { get { return m_CameraShakeMaxAngle; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeMaxAngle), this, m_CameraShakeMaxAngle, value)) m_CameraShakeMaxAngle = value; } } // 0x4C (76)
		
		protected float m_CameraShakeScale = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(3342909616)]
		public float CameraShakeScale { get { return m_CameraShakeScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(CameraShakeScale), this, m_CameraShakeScale, value)) m_CameraShakeScale = value; } } // 0x50 (80)
		
		protected float m_WeaponLagXScale = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(994760237)]
		public float WeaponLagXScale { get { return m_WeaponLagXScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponLagXScale), this, m_WeaponLagXScale, value)) m_WeaponLagXScale = value; } } // 0x54 (84)
		
		protected float m_WeaponLagYScale = new float();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(1109790412)]
		public float WeaponLagYScale { get { return m_WeaponLagYScale; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(WeaponLagYScale), this, m_WeaponLagYScale, value)) m_WeaponLagYScale = value; } } // 0x58 (88)
		
		protected uint m_FilterSize = new uint();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(2796213248)]
		public uint FilterSize { get { return m_FilterSize; } set { if (OnPropertyChanging("HudCameraShakeData." + nameof(FilterSize), this, m_FilterSize, value)) m_FilterSize = value; } } // 0x5C (92)
		
		protected float m_MaxDisplacement = new float();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(263952390)]
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
