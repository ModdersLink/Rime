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
	public class HudData : FrostbiteContainer
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CrosshairScaleMin { get; set; } // 0x0 (0)
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CrosshairScaleMax { get; set; } // 0x4 (4)
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CrosshairOpacityMin { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float CrosshairOpacityMax { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CrosshairOpacityModifier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable]
		public string CrosshairTypeId { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable]
		public string WeaponClass { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float CameraShakeModifier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SeaLevelAltFreq { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float LowAmmoWarning { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ReloadPrompt { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; } // 0x2C (44)
		
		[ContainerField(48)]
		public CtrRef<UIPartPropertyList> HudPropertyList { get; set; } = new CtrRef<UIPartPropertyList>(); // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool ShowMinimap { get; set; } // 0x34 (52)
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool InfiniteAmmo { get; set; } // 0x35 (53)
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool HideCrosshairWhenAimOnFriend { get; set; } // 0x36 (54)
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool HideAmmo { get; set; } // 0x37 (55)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool UseRangeMeter { get; set; } // 0x38 (56)
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool UsePredictedSight { get; set; } // 0x39 (57)
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool UseWeaponOrientations { get; set; } // 0x3A (58)
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool UseVelocityVectorMarker { get; set; } // 0x3B (59)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool UseLockingController { get; set; } // 0x3C (60)
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool UseThrust { get; set; } // 0x3D (61)
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool UseGForce { get; set; } // 0x3E (62)
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UseSkidSlip { get; set; } // 0x3F (63)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool UseClimbRate { get; set; } // 0x40 (64)
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool UseAimWarning { get; set; } // 0x41 (65)
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool UseRenderTarget { get; set; } // 0x42 (66)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3510811323:
					CrosshairScaleMin = (float) p_Value;
					break;

				case 3510811557:
					CrosshairScaleMax = (float) p_Value;
					break;

				case 317484058:
					CrosshairOpacityMin = (float) p_Value;
					break;

				case 317484292:
					CrosshairOpacityMax = (float) p_Value;
					break;

				case 2206342791:
					CrosshairOpacityModifier = (float) p_Value;
					break;

				case 3193780508:
					CrosshairTypeId = (string) p_Value;
					break;

				case 711657993:
					WeaponClass = (string) p_Value;
					break;

				case 2283047615:
					CameraShakeModifier = (float) p_Value;
					break;

				case 887926621:
					SeaLevelAltFreq = (float) p_Value;
					break;

				case 1240499317:
					LowAmmoWarning = (float) p_Value;
					break;

				case 2668682768:
					ReloadPrompt = (float) p_Value;
					break;

				case 3545373920:
					RenderTargetIndex = (int) p_Value;
					break;

				case 3433890873:
					HudPropertyList = (CtrRef<UIPartPropertyList>) p_Value;
					break;

				case 1334258265:
					ShowMinimap = (bool) p_Value;
					break;

				case 688634165:
					InfiniteAmmo = (bool) p_Value;
					break;

				case 3009464555:
					HideCrosshairWhenAimOnFriend = (bool) p_Value;
					break;

				case 893628235:
					HideAmmo = (bool) p_Value;
					break;

				case 3411906738:
					UseRangeMeter = (bool) p_Value;
					break;

				case 1797339451:
					UsePredictedSight = (bool) p_Value;
					break;

				case 1661638241:
					UseWeaponOrientations = (bool) p_Value;
					break;

				case 3066711754:
					UseVelocityVectorMarker = (bool) p_Value;
					break;

				case 2277246513:
					UseLockingController = (bool) p_Value;
					break;

				case 140958810:
					UseThrust = (bool) p_Value;
					break;

				case 3885011324:
					UseGForce = (bool) p_Value;
					break;

				case 3699379733:
					UseSkidSlip = (bool) p_Value;
					break;

				case 2277133773:
					UseClimbRate = (bool) p_Value;
					break;

				case 1181666217:
					UseAimWarning = (bool) p_Value;
					break;

				case 3192099997:
					UseRenderTarget = (bool) p_Value;
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
				case 3510811323:
					return CrosshairScaleMin;

				case 3510811557:
					return CrosshairScaleMax;

				case 317484058:
					return CrosshairOpacityMin;

				case 317484292:
					return CrosshairOpacityMax;

				case 2206342791:
					return CrosshairOpacityModifier;

				case 3193780508:
					return CrosshairTypeId;

				case 711657993:
					return WeaponClass;

				case 2283047615:
					return CameraShakeModifier;

				case 887926621:
					return SeaLevelAltFreq;

				case 1240499317:
					return LowAmmoWarning;

				case 2668682768:
					return ReloadPrompt;

				case 3545373920:
					return RenderTargetIndex;

				case 3433890873:
					return HudPropertyList;

				case 1334258265:
					return ShowMinimap;

				case 688634165:
					return InfiniteAmmo;

				case 3009464555:
					return HideCrosshairWhenAimOnFriend;

				case 893628235:
					return HideAmmo;

				case 3411906738:
					return UseRangeMeter;

				case 1797339451:
					return UsePredictedSight;

				case 1661638241:
					return UseWeaponOrientations;

				case 3066711754:
					return UseVelocityVectorMarker;

				case 2277246513:
					return UseLockingController;

				case 140958810:
					return UseThrust;

				case 3885011324:
					return UseGForce;

				case 3699379733:
					return UseSkidSlip;

				case 2277133773:
					return UseClimbRate;

				case 1181666217:
					return UseAimWarning;

				case 3192099997:
					return UseRenderTarget;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3510811323:
					return typeof(HudData).GetProperty(nameof(CrosshairScaleMin));

				case 3510811557:
					return typeof(HudData).GetProperty(nameof(CrosshairScaleMax));

				case 317484058:
					return typeof(HudData).GetProperty(nameof(CrosshairOpacityMin));

				case 317484292:
					return typeof(HudData).GetProperty(nameof(CrosshairOpacityMax));

				case 2206342791:
					return typeof(HudData).GetProperty(nameof(CrosshairOpacityModifier));

				case 3193780508:
					return typeof(HudData).GetProperty(nameof(CrosshairTypeId));

				case 711657993:
					return typeof(HudData).GetProperty(nameof(WeaponClass));

				case 2283047615:
					return typeof(HudData).GetProperty(nameof(CameraShakeModifier));

				case 887926621:
					return typeof(HudData).GetProperty(nameof(SeaLevelAltFreq));

				case 1240499317:
					return typeof(HudData).GetProperty(nameof(LowAmmoWarning));

				case 2668682768:
					return typeof(HudData).GetProperty(nameof(ReloadPrompt));

				case 3545373920:
					return typeof(HudData).GetProperty(nameof(RenderTargetIndex));

				case 3433890873:
					return typeof(HudData).GetProperty(nameof(HudPropertyList));

				case 1334258265:
					return typeof(HudData).GetProperty(nameof(ShowMinimap));

				case 688634165:
					return typeof(HudData).GetProperty(nameof(InfiniteAmmo));

				case 3009464555:
					return typeof(HudData).GetProperty(nameof(HideCrosshairWhenAimOnFriend));

				case 893628235:
					return typeof(HudData).GetProperty(nameof(HideAmmo));

				case 3411906738:
					return typeof(HudData).GetProperty(nameof(UseRangeMeter));

				case 1797339451:
					return typeof(HudData).GetProperty(nameof(UsePredictedSight));

				case 1661638241:
					return typeof(HudData).GetProperty(nameof(UseWeaponOrientations));

				case 3066711754:
					return typeof(HudData).GetProperty(nameof(UseVelocityVectorMarker));

				case 2277246513:
					return typeof(HudData).GetProperty(nameof(UseLockingController));

				case 140958810:
					return typeof(HudData).GetProperty(nameof(UseThrust));

				case 3885011324:
					return typeof(HudData).GetProperty(nameof(UseGForce));

				case 3699379733:
					return typeof(HudData).GetProperty(nameof(UseSkidSlip));

				case 2277133773:
					return typeof(HudData).GetProperty(nameof(UseClimbRate));

				case 1181666217:
					return typeof(HudData).GetProperty(nameof(UseAimWarning));

				case 3192099997:
					return typeof(HudData).GetProperty(nameof(UseRenderTarget));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
