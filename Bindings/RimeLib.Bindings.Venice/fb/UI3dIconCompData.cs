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
	[ContainerType(4), MemberInfoFlag(53), ContainerClass]
	public class UI3dIconCompData : 
		UIComponentData
	{
		protected Vec2 m_PixelOffset = new Vec2();
		[ContainerField(28), Homogeneous, LayoutImmutable, Blittable, MemberInfoFlag(53289), ContainerFieldNameHash(1847759040)]
		public Vec2 PixelOffset { get { return m_PixelOffset; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(PixelOffset), this, m_PixelOffset, value)) m_PixelOffset = value; } } // 0x1C (28)
		
		protected float m_IconSize = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(269738667)]
		public float IconSize { get { return m_IconSize; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(IconSize), this, m_IconSize, value)) m_IconSize = value; } } // 0x24 (36)
		
		protected float m_MaxFarFade = new float();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1649290658)]
		public float MaxFarFade { get { return m_MaxFarFade; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxFarFade), this, m_MaxFarFade, value)) m_MaxFarFade = value; } } // 0x28 (40)
		
		protected float m_MaxCloseFade = new float();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(539308577)]
		public float MaxCloseFade { get { return m_MaxCloseFade; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxCloseFade), this, m_MaxCloseFade, value)) m_MaxCloseFade = value; } } // 0x2C (44)
		
		protected float m_SnapSafeZone = new float();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1875567430)]
		public float SnapSafeZone { get { return m_SnapSafeZone; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(SnapSafeZone), this, m_SnapSafeZone, value)) m_SnapSafeZone = value; } } // 0x30 (48)
		
		protected float m_SnapCenterYOffset = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(209674038)]
		public float SnapCenterYOffset { get { return m_SnapCenterYOffset; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(SnapCenterYOffset), this, m_SnapCenterYOffset, value)) m_SnapCenterYOffset = value; } } // 0x34 (52)
		
		protected float m_ShrinkSnapAnimationTime = new float();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3817575151)]
		public float ShrinkSnapAnimationTime { get { return m_ShrinkSnapAnimationTime; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ShrinkSnapAnimationTime), this, m_ShrinkSnapAnimationTime, value)) m_ShrinkSnapAnimationTime = value; } } // 0x38 (56)
		
		protected float m_TrackerHudRadiusX = new float();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(494741604)]
		public float TrackerHudRadiusX { get { return m_TrackerHudRadiusX; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(TrackerHudRadiusX), this, m_TrackerHudRadiusX, value)) m_TrackerHudRadiusX = value; } } // 0x3C (60)
		
		protected float m_TrackerHudRadiusY = new float();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(494741605)]
		public float TrackerHudRadiusY { get { return m_TrackerHudRadiusY; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(TrackerHudRadiusY), this, m_TrackerHudRadiusY, value)) m_TrackerHudRadiusY = value; } } // 0x40 (64)
		
		protected float m_MaxLookAtThreshold = new float();
		[ContainerField(68), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3378079124)]
		public float MaxLookAtThreshold { get { return m_MaxLookAtThreshold; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxLookAtThreshold), this, m_MaxLookAtThreshold, value)) m_MaxLookAtThreshold = value; } } // 0x44 (68)
		
		protected float m_MinLookAtThreshold = new float();
		[ContainerField(72), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1713249226)]
		public float MinLookAtThreshold { get { return m_MinLookAtThreshold; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MinLookAtThreshold), this, m_MinLookAtThreshold, value)) m_MinLookAtThreshold = value; } } // 0x48 (72)
		
		protected float m_MinLookAtThresholdDistance = new float();
		[ContainerField(76), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(120312329)]
		public float MinLookAtThresholdDistance { get { return m_MinLookAtThresholdDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MinLookAtThresholdDistance), this, m_MinLookAtThresholdDistance, value)) m_MinLookAtThresholdDistance = value; } } // 0x4C (76)
		
		protected float m_DrawDistance = new float();
		[ContainerField(80), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3007537990)]
		public float DrawDistance { get { return m_DrawDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(DrawDistance), this, m_DrawDistance, value)) m_DrawDistance = value; } } // 0x50 (80)
		
		protected float m_FadeDistance = new float();
		[ContainerField(84), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(636128672)]
		public float FadeDistance { get { return m_FadeDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(FadeDistance), this, m_FadeDistance, value)) m_FadeDistance = value; } } // 0x54 (84)
		
		protected float m_FadeEndDistance = new float();
		[ContainerField(88), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1525884495)]
		public float FadeEndDistance { get { return m_FadeEndDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(FadeEndDistance), this, m_FadeEndDistance, value)) m_FadeEndDistance = value; } } // 0x58 (88)
		
		protected float m_MinimumDrawDistance = new float();
		[ContainerField(92), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3994158800)]
		public float MinimumDrawDistance { get { return m_MinimumDrawDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MinimumDrawDistance), this, m_MinimumDrawDistance, value)) m_MinimumDrawDistance = value; } } // 0x5C (92)
		
		protected float m_MinimumFadeDistance = new float();
		[ContainerField(96), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(501224630)]
		public float MinimumFadeDistance { get { return m_MinimumFadeDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MinimumFadeDistance), this, m_MinimumFadeDistance, value)) m_MinimumFadeDistance = value; } } // 0x60 (96)
		
		protected int m_MaxTagUpdatesPerFrame = new int();
		[ContainerField(100), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(3828005979)]
		public int MaxTagUpdatesPerFrame { get { return m_MaxTagUpdatesPerFrame; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxTagUpdatesPerFrame), this, m_MaxTagUpdatesPerFrame, value)) m_MaxTagUpdatesPerFrame = value; } } // 0x64 (100)
		
		protected float m_VerticalOffset = new float();
		[ContainerField(104), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2125919898)]
		public float VerticalOffset { get { return m_VerticalOffset; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(VerticalOffset), this, m_VerticalOffset, value)) m_VerticalOffset = value; } } // 0x68 (104)
		
		protected float m_ShowLabelRange = new float();
		[ContainerField(108), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3915682047)]
		public float ShowLabelRange { get { return m_ShowLabelRange; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ShowLabelRange), this, m_ShowLabelRange, value)) m_ShowLabelRange = value; } } // 0x6C (108)
		
		protected float m_TeamRadioDistance = new float();
		[ContainerField(112), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2116216522)]
		public float TeamRadioDistance { get { return m_TeamRadioDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(TeamRadioDistance), this, m_TeamRadioDistance, value)) m_TeamRadioDistance = value; } } // 0x70 (112)
		
		protected float m_ScaleDistance = new float();
		[ContainerField(116), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2682964318)]
		public float ScaleDistance { get { return m_ScaleDistance; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ScaleDistance), this, m_ScaleDistance, value)) m_ScaleDistance = value; } } // 0x74 (116)
		
		protected float m_MaxScaleMod = new float();
		[ContainerField(120), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3120961103)]
		public float MaxScaleMod { get { return m_MaxScaleMod; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxScaleMod), this, m_MaxScaleMod, value)) m_MaxScaleMod = value; } } // 0x78 (120)
		
		protected float m_MaxXRotation = new float();
		[ContainerField(124), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3351064765)]
		public float MaxXRotation { get { return m_MaxXRotation; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxXRotation), this, m_MaxXRotation, value)) m_MaxXRotation = value; } } // 0x7C (124)
		
		protected float m_MaxYRotation = new float();
		[ContainerField(128), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3559299260)]
		public float MaxYRotation { get { return m_MaxYRotation; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(MaxYRotation), this, m_MaxYRotation, value)) m_MaxYRotation = value; } } // 0x80 (128)
		
		protected float m_HorisontalOffset = new float();
		[ContainerField(132), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(598230047)]
		public float HorisontalOffset { get { return m_HorisontalOffset; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(HorisontalOffset), this, m_HorisontalOffset, value)) m_HorisontalOffset = value; } } // 0x84 (132)
		
		protected float m_ShowSupportAmmoThreshold = new float();
		[ContainerField(136), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3095615152)]
		public float ShowSupportAmmoThreshold { get { return m_ShowSupportAmmoThreshold; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ShowSupportAmmoThreshold), this, m_ShowSupportAmmoThreshold, value)) m_ShowSupportAmmoThreshold = value; } } // 0x88 (136)
		
		protected float m_VerticalOffsetMaxOffset = new float();
		[ContainerField(140), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1131008835)]
		public float VerticalOffsetMaxOffset { get { return m_VerticalOffsetMaxOffset; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(VerticalOffsetMaxOffset), this, m_VerticalOffsetMaxOffset, value)) m_VerticalOffsetMaxOffset = value; } } // 0x8C (140)
		
		protected float m_VerticalOffsetScaleFactor = new float();
		[ContainerField(144), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2621997839)]
		public float VerticalOffsetScaleFactor { get { return m_VerticalOffsetScaleFactor; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(VerticalOffsetScaleFactor), this, m_VerticalOffsetScaleFactor, value)) m_VerticalOffsetScaleFactor = value; } } // 0x90 (144)
		
		protected float m_ShowEngineerArmorThreshold = new float();
		[ContainerField(148), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2577691403)]
		public float ShowEngineerArmorThreshold { get { return m_ShowEngineerArmorThreshold; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ShowEngineerArmorThreshold), this, m_ShowEngineerArmorThreshold, value)) m_ShowEngineerArmorThreshold = value; } } // 0x94 (148)
		
		protected float m_ShowMedicHealthThreshold = new float();
		[ContainerField(152), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(4256908171)]
		public float ShowMedicHealthThreshold { get { return m_ShowMedicHealthThreshold; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(ShowMedicHealthThreshold), this, m_ShowMedicHealthThreshold, value)) m_ShowMedicHealthThreshold = value; } } // 0x98 (152)
		
		protected bool m_SnapIcons = new bool();
		[ContainerField(156), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1728218737)]
		public bool SnapIcons { get { return m_SnapIcons; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(SnapIcons), this, m_SnapIcons, value)) m_SnapIcons = value; } } // 0x9C (156)
		
		protected bool m_CircularSnap = new bool();
		[ContainerField(157), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3894769784)]
		public bool CircularSnap { get { return m_CircularSnap; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(CircularSnap), this, m_CircularSnap, value)) m_CircularSnap = value; } } // 0x9D (157)
		
		protected bool m_OnlyShowSnapped = new bool();
		[ContainerField(158), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1611417039)]
		public bool OnlyShowSnapped { get { return m_OnlyShowSnapped; } set { if (OnPropertyChanging("UI3dIconCompData." + nameof(OnlyShowSnapped), this, m_OnlyShowSnapped, value)) m_OnlyShowSnapped = value; } } // 0x9E (158)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1847759040:
					PixelOffset = (Vec2) p_Value;
					break;

				case 269738667:
					IconSize = (float) p_Value;
					break;

				case 1649290658:
					MaxFarFade = (float) p_Value;
					break;

				case 539308577:
					MaxCloseFade = (float) p_Value;
					break;

				case 1875567430:
					SnapSafeZone = (float) p_Value;
					break;

				case 209674038:
					SnapCenterYOffset = (float) p_Value;
					break;

				case 3817575151:
					ShrinkSnapAnimationTime = (float) p_Value;
					break;

				case 494741604:
					TrackerHudRadiusX = (float) p_Value;
					break;

				case 494741605:
					TrackerHudRadiusY = (float) p_Value;
					break;

				case 3378079124:
					MaxLookAtThreshold = (float) p_Value;
					break;

				case 1713249226:
					MinLookAtThreshold = (float) p_Value;
					break;

				case 120312329:
					MinLookAtThresholdDistance = (float) p_Value;
					break;

				case 3007537990:
					DrawDistance = (float) p_Value;
					break;

				case 636128672:
					FadeDistance = (float) p_Value;
					break;

				case 1525884495:
					FadeEndDistance = (float) p_Value;
					break;

				case 3994158800:
					MinimumDrawDistance = (float) p_Value;
					break;

				case 501224630:
					MinimumFadeDistance = (float) p_Value;
					break;

				case 3828005979:
					MaxTagUpdatesPerFrame = (int) p_Value;
					break;

				case 2125919898:
					VerticalOffset = (float) p_Value;
					break;

				case 3915682047:
					ShowLabelRange = (float) p_Value;
					break;

				case 2116216522:
					TeamRadioDistance = (float) p_Value;
					break;

				case 2682964318:
					ScaleDistance = (float) p_Value;
					break;

				case 3120961103:
					MaxScaleMod = (float) p_Value;
					break;

				case 3351064765:
					MaxXRotation = (float) p_Value;
					break;

				case 3559299260:
					MaxYRotation = (float) p_Value;
					break;

				case 598230047:
					HorisontalOffset = (float) p_Value;
					break;

				case 3095615152:
					ShowSupportAmmoThreshold = (float) p_Value;
					break;

				case 1131008835:
					VerticalOffsetMaxOffset = (float) p_Value;
					break;

				case 2621997839:
					VerticalOffsetScaleFactor = (float) p_Value;
					break;

				case 2577691403:
					ShowEngineerArmorThreshold = (float) p_Value;
					break;

				case 4256908171:
					ShowMedicHealthThreshold = (float) p_Value;
					break;

				case 1728218737:
					SnapIcons = (bool) p_Value;
					break;

				case 3894769784:
					CircularSnap = (bool) p_Value;
					break;

				case 1611417039:
					OnlyShowSnapped = (bool) p_Value;
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
				case 1847759040:
					return PixelOffset;

				case 269738667:
					return IconSize;

				case 1649290658:
					return MaxFarFade;

				case 539308577:
					return MaxCloseFade;

				case 1875567430:
					return SnapSafeZone;

				case 209674038:
					return SnapCenterYOffset;

				case 3817575151:
					return ShrinkSnapAnimationTime;

				case 494741604:
					return TrackerHudRadiusX;

				case 494741605:
					return TrackerHudRadiusY;

				case 3378079124:
					return MaxLookAtThreshold;

				case 1713249226:
					return MinLookAtThreshold;

				case 120312329:
					return MinLookAtThresholdDistance;

				case 3007537990:
					return DrawDistance;

				case 636128672:
					return FadeDistance;

				case 1525884495:
					return FadeEndDistance;

				case 3994158800:
					return MinimumDrawDistance;

				case 501224630:
					return MinimumFadeDistance;

				case 3828005979:
					return MaxTagUpdatesPerFrame;

				case 2125919898:
					return VerticalOffset;

				case 3915682047:
					return ShowLabelRange;

				case 2116216522:
					return TeamRadioDistance;

				case 2682964318:
					return ScaleDistance;

				case 3120961103:
					return MaxScaleMod;

				case 3351064765:
					return MaxXRotation;

				case 3559299260:
					return MaxYRotation;

				case 598230047:
					return HorisontalOffset;

				case 3095615152:
					return ShowSupportAmmoThreshold;

				case 1131008835:
					return VerticalOffsetMaxOffset;

				case 2621997839:
					return VerticalOffsetScaleFactor;

				case 2577691403:
					return ShowEngineerArmorThreshold;

				case 4256908171:
					return ShowMedicHealthThreshold;

				case 1728218737:
					return SnapIcons;

				case 3894769784:
					return CircularSnap;

				case 1611417039:
					return OnlyShowSnapped;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1847759040:
					return typeof(UI3dIconCompData).GetProperty(nameof(PixelOffset));

				case 269738667:
					return typeof(UI3dIconCompData).GetProperty(nameof(IconSize));

				case 1649290658:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxFarFade));

				case 539308577:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxCloseFade));

				case 1875567430:
					return typeof(UI3dIconCompData).GetProperty(nameof(SnapSafeZone));

				case 209674038:
					return typeof(UI3dIconCompData).GetProperty(nameof(SnapCenterYOffset));

				case 3817575151:
					return typeof(UI3dIconCompData).GetProperty(nameof(ShrinkSnapAnimationTime));

				case 494741604:
					return typeof(UI3dIconCompData).GetProperty(nameof(TrackerHudRadiusX));

				case 494741605:
					return typeof(UI3dIconCompData).GetProperty(nameof(TrackerHudRadiusY));

				case 3378079124:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxLookAtThreshold));

				case 1713249226:
					return typeof(UI3dIconCompData).GetProperty(nameof(MinLookAtThreshold));

				case 120312329:
					return typeof(UI3dIconCompData).GetProperty(nameof(MinLookAtThresholdDistance));

				case 3007537990:
					return typeof(UI3dIconCompData).GetProperty(nameof(DrawDistance));

				case 636128672:
					return typeof(UI3dIconCompData).GetProperty(nameof(FadeDistance));

				case 1525884495:
					return typeof(UI3dIconCompData).GetProperty(nameof(FadeEndDistance));

				case 3994158800:
					return typeof(UI3dIconCompData).GetProperty(nameof(MinimumDrawDistance));

				case 501224630:
					return typeof(UI3dIconCompData).GetProperty(nameof(MinimumFadeDistance));

				case 3828005979:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxTagUpdatesPerFrame));

				case 2125919898:
					return typeof(UI3dIconCompData).GetProperty(nameof(VerticalOffset));

				case 3915682047:
					return typeof(UI3dIconCompData).GetProperty(nameof(ShowLabelRange));

				case 2116216522:
					return typeof(UI3dIconCompData).GetProperty(nameof(TeamRadioDistance));

				case 2682964318:
					return typeof(UI3dIconCompData).GetProperty(nameof(ScaleDistance));

				case 3120961103:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxScaleMod));

				case 3351064765:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxXRotation));

				case 3559299260:
					return typeof(UI3dIconCompData).GetProperty(nameof(MaxYRotation));

				case 598230047:
					return typeof(UI3dIconCompData).GetProperty(nameof(HorisontalOffset));

				case 3095615152:
					return typeof(UI3dIconCompData).GetProperty(nameof(ShowSupportAmmoThreshold));

				case 1131008835:
					return typeof(UI3dIconCompData).GetProperty(nameof(VerticalOffsetMaxOffset));

				case 2621997839:
					return typeof(UI3dIconCompData).GetProperty(nameof(VerticalOffsetScaleFactor));

				case 2577691403:
					return typeof(UI3dIconCompData).GetProperty(nameof(ShowEngineerArmorThreshold));

				case 4256908171:
					return typeof(UI3dIconCompData).GetProperty(nameof(ShowMedicHealthThreshold));

				case 1728218737:
					return typeof(UI3dIconCompData).GetProperty(nameof(SnapIcons));

				case 3894769784:
					return typeof(UI3dIconCompData).GetProperty(nameof(CircularSnap));

				case 1611417039:
					return typeof(UI3dIconCompData).GetProperty(nameof(OnlyShowSnapped));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
