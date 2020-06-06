///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class UI3dIconCompData : 
		UIComponentData
	{
		[ContainerField(28), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PixelOffset { get; set; } = new Vec2(); // 0x1C (28)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float IconSize { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxFarFade { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxCloseFade { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float SnapSafeZone { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float SnapCenterYOffset { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ShrinkSnapAnimationTime { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float TrackerHudRadiusX { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float TrackerHudRadiusY { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxLookAtThreshold { get; set; } // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float MinLookAtThreshold { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float MinLookAtThresholdDistance { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float DrawDistance { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float FadeDistance { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float FadeEndDistance { get; set; } // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public float MinimumDrawDistance { get; set; } // 0x5C (92)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinimumFadeDistance { get; set; } // 0x60 (96)
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int MaxTagUpdatesPerFrame { get; set; } // 0x64 (100)
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public float VerticalOffset { get; set; } // 0x68 (104)
		
		[ContainerField(108), LayoutImmutable, Blittable]
		public float ShowLabelRange { get; set; } // 0x6C (108)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float TeamRadioDistance { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable, Blittable]
		public float ScaleDistance { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public float MaxScaleMod { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public float MaxXRotation { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxYRotation { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float HorisontalOffset { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float ShowSupportAmmoThreshold { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float VerticalOffsetMaxOffset { get; set; } // 0x8C (140)
		
		[ContainerField(144), LayoutImmutable, Blittable]
		public float VerticalOffsetScaleFactor { get; set; } // 0x90 (144)
		
		[ContainerField(148), LayoutImmutable, Blittable]
		public float ShowEngineerArmorThreshold { get; set; } // 0x94 (148)
		
		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShowMedicHealthThreshold { get; set; } // 0x98 (152)
		
		[ContainerField(156), LayoutImmutable, Blittable]
		public bool SnapIcons { get; set; } // 0x9C (156)
		
		[ContainerField(157), LayoutImmutable, Blittable]
		public bool CircularSnap { get; set; } // 0x9D (157)
		
		[ContainerField(158), LayoutImmutable, Blittable]
		public bool OnlyShowSnapped { get; set; } // 0x9E (158)
		
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
