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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 68)]
	public class HdrSetting : 
		DataContainer
	{
		protected float m_WindowMinTop = new float();
		[ContainerField(Name: "WindowMinTop", Offset: 8, NameHash: 4075961896, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowMinTop { get { return m_WindowMinTop; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowMinTop), this, m_WindowMinTop, value)) m_WindowMinTop = value; } } // 0x8 (8)
		
		protected float m_WindowMinBottom = new float();
		[ContainerField(Name: "WindowMinBottom", Offset: 12, NameHash: 1280335404, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowMinBottom { get { return m_WindowMinBottom; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowMinBottom), this, m_WindowMinBottom, value)) m_WindowMinBottom = value; } } // 0xC (12)
		
		protected float m_WindowTopMinReleaseTime = new float();
		[ContainerField(Name: "WindowTopMinReleaseTime", Offset: 16, NameHash: 3101523828, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowTopMinReleaseTime { get { return m_WindowTopMinReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopMinReleaseTime), this, m_WindowTopMinReleaseTime, value)) m_WindowTopMinReleaseTime = value; } } // 0x10 (16)
		
		protected float m_WindowTopMaxReleaseTime = new float();
		[ContainerField(Name: "WindowTopMaxReleaseTime", Offset: 20, NameHash: 980586794, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowTopMaxReleaseTime { get { return m_WindowTopMaxReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopMaxReleaseTime), this, m_WindowTopMaxReleaseTime, value)) m_WindowTopMaxReleaseTime = value; } } // 0x14 (20)
		
		protected float m_WindowTopAttackTime = new float();
		[ContainerField(Name: "WindowTopAttackTime", Offset: 24, NameHash: 4009242335, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowTopAttackTime { get { return m_WindowTopAttackTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopAttackTime), this, m_WindowTopAttackTime, value)) m_WindowTopAttackTime = value; } } // 0x18 (24)
		
		protected float m_WindowBottomReleaseTime = new float();
		[ContainerField(Name: "WindowBottomReleaseTime", Offset: 28, NameHash: 2031081370, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowBottomReleaseTime { get { return m_WindowBottomReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowBottomReleaseTime), this, m_WindowBottomReleaseTime, value)) m_WindowBottomReleaseTime = value; } } // 0x1C (28)
		
		protected AudioCurve m_WindowTopReleaseTimeCurve = new AudioCurve();
		[ContainerField(Name: "WindowTopReleaseTimeCurve", Offset: 32, NameHash: 3335723049, Flags: 41)]
		public AudioCurve WindowTopReleaseTimeCurve { get { return m_WindowTopReleaseTimeCurve; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopReleaseTimeCurve), this, m_WindowTopReleaseTimeCurve, value)) m_WindowTopReleaseTimeCurve = value; } } // 0x20 (32)
		
		protected float m_DischargeFactor = new float();
		[ContainerField(Name: "DischargeFactor", Offset: 40, NameHash: 3485908236, Flags: 49469), LayoutImmutable, Blittable]
		public float DischargeFactor { get { return m_DischargeFactor; } set { if (OnPropertyChanging("HdrSetting." + nameof(DischargeFactor), this, m_DischargeFactor, value)) m_DischargeFactor = value; } } // 0x28 (40)
		
		protected float m_MaxAllowedEnergy = new float();
		[ContainerField(Name: "MaxAllowedEnergy", Offset: 44, NameHash: 2165069867, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxAllowedEnergy { get { return m_MaxAllowedEnergy; } set { if (OnPropertyChanging("HdrSetting." + nameof(MaxAllowedEnergy), this, m_MaxAllowedEnergy, value)) m_MaxAllowedEnergy = value; } } // 0x2C (44)
		
		protected float m_WindowBottomAttackTime = new float();
		[ContainerField(Name: "WindowBottomAttackTime", Offset: 48, NameHash: 1069365659, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowBottomAttackTime { get { return m_WindowBottomAttackTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowBottomAttackTime), this, m_WindowBottomAttackTime, value)) m_WindowBottomAttackTime = value; } } // 0x30 (48)
		
		protected float m_WindowSize = new float();
		[ContainerField(Name: "WindowSize", Offset: 52, NameHash: 1881978028, Flags: 49469), LayoutImmutable, Blittable]
		public float WindowSize { get { return m_WindowSize; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowSize), this, m_WindowSize, value)) m_WindowSize = value; } } // 0x34 (52)
		
		protected float m_CompressFactor = new float();
		[ContainerField(Name: "CompressFactor", Offset: 56, NameHash: 2404074926, Flags: 49469), LayoutImmutable, Blittable]
		public float CompressFactor { get { return m_CompressFactor; } set { if (OnPropertyChanging("HdrSetting." + nameof(CompressFactor), this, m_CompressFactor, value)) m_CompressFactor = value; } } // 0x38 (56)
		
		protected float m_Headroom = new float();
		[ContainerField(Name: "Headroom", Offset: 60, NameHash: 1877971122, Flags: 49469), LayoutImmutable, Blittable]
		public float Headroom { get { return m_Headroom; } set { if (OnPropertyChanging("HdrSetting." + nameof(Headroom), this, m_Headroom, value)) m_Headroom = value; } } // 0x3C (60)
		
		protected float m_AllowedOvershoot = new float();
		[ContainerField(Name: "AllowedOvershoot", Offset: 64, NameHash: 730342460, Flags: 49469), LayoutImmutable, Blittable]
		public float AllowedOvershoot { get { return m_AllowedOvershoot; } set { if (OnPropertyChanging("HdrSetting." + nameof(AllowedOvershoot), this, m_AllowedOvershoot, value)) m_AllowedOvershoot = value; } } // 0x40 (64)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 4075961896:
					WindowMinTop = (float) p_Value;
					break;

				case 1280335404:
					WindowMinBottom = (float) p_Value;
					break;

				case 3101523828:
					WindowTopMinReleaseTime = (float) p_Value;
					break;

				case 980586794:
					WindowTopMaxReleaseTime = (float) p_Value;
					break;

				case 4009242335:
					WindowTopAttackTime = (float) p_Value;
					break;

				case 2031081370:
					WindowBottomReleaseTime = (float) p_Value;
					break;

				case 3335723049:
					WindowTopReleaseTimeCurve = (AudioCurve) p_Value;
					break;

				case 3485908236:
					DischargeFactor = (float) p_Value;
					break;

				case 2165069867:
					MaxAllowedEnergy = (float) p_Value;
					break;

				case 1069365659:
					WindowBottomAttackTime = (float) p_Value;
					break;

				case 1881978028:
					WindowSize = (float) p_Value;
					break;

				case 2404074926:
					CompressFactor = (float) p_Value;
					break;

				case 1877971122:
					Headroom = (float) p_Value;
					break;

				case 730342460:
					AllowedOvershoot = (float) p_Value;
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
				case 4075961896:
					return WindowMinTop;

				case 1280335404:
					return WindowMinBottom;

				case 3101523828:
					return WindowTopMinReleaseTime;

				case 980586794:
					return WindowTopMaxReleaseTime;

				case 4009242335:
					return WindowTopAttackTime;

				case 2031081370:
					return WindowBottomReleaseTime;

				case 3335723049:
					return WindowTopReleaseTimeCurve;

				case 3485908236:
					return DischargeFactor;

				case 2165069867:
					return MaxAllowedEnergy;

				case 1069365659:
					return WindowBottomAttackTime;

				case 1881978028:
					return WindowSize;

				case 2404074926:
					return CompressFactor;

				case 1877971122:
					return Headroom;

				case 730342460:
					return AllowedOvershoot;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 4075961896:
					return typeof(HdrSetting).GetProperty(nameof(WindowMinTop));

				case 1280335404:
					return typeof(HdrSetting).GetProperty(nameof(WindowMinBottom));

				case 3101523828:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopMinReleaseTime));

				case 980586794:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopMaxReleaseTime));

				case 4009242335:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopAttackTime));

				case 2031081370:
					return typeof(HdrSetting).GetProperty(nameof(WindowBottomReleaseTime));

				case 3335723049:
					return typeof(HdrSetting).GetProperty(nameof(WindowTopReleaseTimeCurve));

				case 3485908236:
					return typeof(HdrSetting).GetProperty(nameof(DischargeFactor));

				case 2165069867:
					return typeof(HdrSetting).GetProperty(nameof(MaxAllowedEnergy));

				case 1069365659:
					return typeof(HdrSetting).GetProperty(nameof(WindowBottomAttackTime));

				case 1881978028:
					return typeof(HdrSetting).GetProperty(nameof(WindowSize));

				case 2404074926:
					return typeof(HdrSetting).GetProperty(nameof(CompressFactor));

				case 1877971122:
					return typeof(HdrSetting).GetProperty(nameof(Headroom));

				case 730342460:
					return typeof(HdrSetting).GetProperty(nameof(AllowedOvershoot));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
