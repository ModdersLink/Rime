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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(68), ContainerClass]
	public class HdrSetting : 
		DataContainer
	{
		protected float m_WindowMinTop = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4075961896)]
		public float WindowMinTop { get { return m_WindowMinTop; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowMinTop), this, m_WindowMinTop, value)) m_WindowMinTop = value; } } // 0x8 (8)
		
		protected float m_WindowMinBottom = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1280335404)]
		public float WindowMinBottom { get { return m_WindowMinBottom; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowMinBottom), this, m_WindowMinBottom, value)) m_WindowMinBottom = value; } } // 0xC (12)
		
		protected float m_WindowTopMinReleaseTime = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3101523828)]
		public float WindowTopMinReleaseTime { get { return m_WindowTopMinReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopMinReleaseTime), this, m_WindowTopMinReleaseTime, value)) m_WindowTopMinReleaseTime = value; } } // 0x10 (16)
		
		protected float m_WindowTopMaxReleaseTime = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(980586794)]
		public float WindowTopMaxReleaseTime { get { return m_WindowTopMaxReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopMaxReleaseTime), this, m_WindowTopMaxReleaseTime, value)) m_WindowTopMaxReleaseTime = value; } } // 0x14 (20)
		
		protected float m_WindowTopAttackTime = new float();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4009242335)]
		public float WindowTopAttackTime { get { return m_WindowTopAttackTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopAttackTime), this, m_WindowTopAttackTime, value)) m_WindowTopAttackTime = value; } } // 0x18 (24)
		
		protected float m_WindowBottomReleaseTime = new float();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2031081370)]
		public float WindowBottomReleaseTime { get { return m_WindowBottomReleaseTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowBottomReleaseTime), this, m_WindowBottomReleaseTime, value)) m_WindowBottomReleaseTime = value; } } // 0x1C (28)
		
		protected AudioCurve m_WindowTopReleaseTimeCurve = new AudioCurve();
		[ContainerField(32), MemberInfoFlag(41), ContainerFieldNameHash(3335723049)]
		public AudioCurve WindowTopReleaseTimeCurve { get { return m_WindowTopReleaseTimeCurve; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowTopReleaseTimeCurve), this, m_WindowTopReleaseTimeCurve, value)) m_WindowTopReleaseTimeCurve = value; } } // 0x20 (32)
		
		protected float m_DischargeFactor = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3485908236)]
		public float DischargeFactor { get { return m_DischargeFactor; } set { if (OnPropertyChanging("HdrSetting." + nameof(DischargeFactor), this, m_DischargeFactor, value)) m_DischargeFactor = value; } } // 0x28 (40)
		
		protected float m_MaxAllowedEnergy = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2165069867)]
		public float MaxAllowedEnergy { get { return m_MaxAllowedEnergy; } set { if (OnPropertyChanging("HdrSetting." + nameof(MaxAllowedEnergy), this, m_MaxAllowedEnergy, value)) m_MaxAllowedEnergy = value; } } // 0x2C (44)
		
		protected float m_WindowBottomAttackTime = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1069365659)]
		public float WindowBottomAttackTime { get { return m_WindowBottomAttackTime; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowBottomAttackTime), this, m_WindowBottomAttackTime, value)) m_WindowBottomAttackTime = value; } } // 0x30 (48)
		
		protected float m_WindowSize = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1881978028)]
		public float WindowSize { get { return m_WindowSize; } set { if (OnPropertyChanging("HdrSetting." + nameof(WindowSize), this, m_WindowSize, value)) m_WindowSize = value; } } // 0x34 (52)
		
		protected float m_CompressFactor = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2404074926)]
		public float CompressFactor { get { return m_CompressFactor; } set { if (OnPropertyChanging("HdrSetting." + nameof(CompressFactor), this, m_CompressFactor, value)) m_CompressFactor = value; } } // 0x38 (56)
		
		protected float m_Headroom = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1877971122)]
		public float Headroom { get { return m_Headroom; } set { if (OnPropertyChanging("HdrSetting." + nameof(Headroom), this, m_Headroom, value)) m_Headroom = value; } } // 0x3C (60)
		
		protected float m_AllowedOvershoot = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(730342460)]
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
