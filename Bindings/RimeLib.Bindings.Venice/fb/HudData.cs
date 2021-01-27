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
	[ContainerType(Alignment: 4,  Flags: 41, Size: 68)]
	public class HudData : FrostbiteContainer
	{
		[ContainerField(Name: "CrosshairScaleMin", Offset: 0, NameHash: 3510811323, Flags: 49469), LayoutImmutable, Blittable]
		public float CrosshairScaleMin { get; set; } // 0x0 (0)
		
		[ContainerField(Name: "CrosshairScaleMax", Offset: 4, NameHash: 3510811557, Flags: 49469), LayoutImmutable, Blittable]
		public float CrosshairScaleMax { get; set; } // 0x4 (4)
		
		[ContainerField(Name: "CrosshairOpacityMin", Offset: 8, NameHash: 317484058, Flags: 49469), LayoutImmutable, Blittable]
		public float CrosshairOpacityMin { get; set; } // 0x8 (8)
		
		[ContainerField(Name: "CrosshairOpacityMax", Offset: 12, NameHash: 317484292, Flags: 49469), LayoutImmutable, Blittable]
		public float CrosshairOpacityMax { get; set; } // 0xC (12)
		
		[ContainerField(Name: "CrosshairOpacityModifier", Offset: 16, NameHash: 2206342791, Flags: 49469), LayoutImmutable, Blittable]
		public float CrosshairOpacityModifier { get; set; } // 0x10 (16)
		
		[ContainerField(Name: "CrosshairTypeId", Offset: 20, NameHash: 3193780508, Flags: 16509), LayoutImmutable]
		public string CrosshairTypeId { get; set; } // 0x14 (20)
		
		[ContainerField(Name: "WeaponClass", Offset: 24, NameHash: 711657993, Flags: 16509), LayoutImmutable]
		public string WeaponClass { get; set; } // 0x18 (24)
		
		[ContainerField(Name: "CameraShakeModifier", Offset: 28, NameHash: 2283047615, Flags: 49469), LayoutImmutable, Blittable]
		public float CameraShakeModifier { get; set; } // 0x1C (28)
		
		[ContainerField(Name: "SeaLevelAltFreq", Offset: 32, NameHash: 887926621, Flags: 49469), LayoutImmutable, Blittable]
		public float SeaLevelAltFreq { get; set; } // 0x20 (32)
		
		[ContainerField(Name: "LowAmmoWarning", Offset: 36, NameHash: 1240499317, Flags: 49469), LayoutImmutable, Blittable]
		public float LowAmmoWarning { get; set; } // 0x24 (36)
		
		[ContainerField(Name: "ReloadPrompt", Offset: 40, NameHash: 2668682768, Flags: 49469), LayoutImmutable, Blittable]
		public float ReloadPrompt { get; set; } // 0x28 (40)
		
		[ContainerField(Name: "RenderTargetIndex", Offset: 44, NameHash: 3545373920, Flags: 49405), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; } // 0x2C (44)
		
		[ContainerField(Name: "HudPropertyList", Offset: 48, NameHash: 3433890873, Flags: 53)]
		public CtrRef<UIPartPropertyList> HudPropertyList { get; set; } = new CtrRef<UIPartPropertyList>(); // 0x30 (48)
		
		[ContainerField(Name: "ShowMinimap", Offset: 52, NameHash: 1334258265, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowMinimap { get; set; } // 0x34 (52)
		
		[ContainerField(Name: "InfiniteAmmo", Offset: 53, NameHash: 688634165, Flags: 49325), LayoutImmutable, Blittable]
		public bool InfiniteAmmo { get; set; } // 0x35 (53)
		
		[ContainerField(Name: "HideCrosshairWhenAimOnFriend", Offset: 54, NameHash: 3009464555, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideCrosshairWhenAimOnFriend { get; set; } // 0x36 (54)
		
		[ContainerField(Name: "HideAmmo", Offset: 55, NameHash: 893628235, Flags: 49325), LayoutImmutable, Blittable]
		public bool HideAmmo { get; set; } // 0x37 (55)
		
		[ContainerField(Name: "UseRangeMeter", Offset: 56, NameHash: 3411906738, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseRangeMeter { get; set; } // 0x38 (56)
		
		[ContainerField(Name: "UsePredictedSight", Offset: 57, NameHash: 1797339451, Flags: 49325), LayoutImmutable, Blittable]
		public bool UsePredictedSight { get; set; } // 0x39 (57)
		
		[ContainerField(Name: "UseWeaponOrientations", Offset: 58, NameHash: 1661638241, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseWeaponOrientations { get; set; } // 0x3A (58)
		
		[ContainerField(Name: "UseVelocityVectorMarker", Offset: 59, NameHash: 3066711754, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseVelocityVectorMarker { get; set; } // 0x3B (59)
		
		[ContainerField(Name: "UseLockingController", Offset: 60, NameHash: 2277246513, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseLockingController { get; set; } // 0x3C (60)
		
		[ContainerField(Name: "UseThrust", Offset: 61, NameHash: 140958810, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseThrust { get; set; } // 0x3D (61)
		
		[ContainerField(Name: "UseGForce", Offset: 62, NameHash: 3885011324, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseGForce { get; set; } // 0x3E (62)
		
		[ContainerField(Name: "UseSkidSlip", Offset: 63, NameHash: 3699379733, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseSkidSlip { get; set; } // 0x3F (63)
		
		[ContainerField(Name: "UseClimbRate", Offset: 64, NameHash: 2277133773, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseClimbRate { get; set; } // 0x40 (64)
		
		[ContainerField(Name: "UseAimWarning", Offset: 65, NameHash: 1181666217, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseAimWarning { get; set; } // 0x41 (65)
		
		[ContainerField(Name: "UseRenderTarget", Offset: 66, NameHash: 3192099997, Flags: 49325), LayoutImmutable, Blittable]
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
