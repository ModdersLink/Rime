///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(4, 68)]
	public class HudData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CrosshairScaleMin { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CrosshairScaleMax { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CrosshairOpacityMin { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float CrosshairOpacityMax { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CrosshairOpacityModifier { get; set; }
		
		[ContainerField(20), LayoutImmutable]
		public string CrosshairTypeId { get; set; } = string.Empty;
		
		[ContainerField(24), LayoutImmutable]
		public string WeaponClass { get; set; } = string.Empty;
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float CameraShakeModifier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SeaLevelAltFreq { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float LowAmmoWarning { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float ReloadPrompt { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public int RenderTargetIndex { get; set; }
		
		[ContainerField(48)]
		public CtrRef<UIPartPropertyList> HudPropertyList { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public bool ShowMinimap { get; set; }
		
		[ContainerField(53), LayoutImmutable, Blittable]
		public bool InfiniteAmmo { get; set; }
		
		[ContainerField(54), LayoutImmutable, Blittable]
		public bool HideCrosshairWhenAimOnFriend { get; set; }
		
		[ContainerField(55), LayoutImmutable, Blittable]
		public bool HideAmmo { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public bool UseRangeMeter { get; set; }
		
		[ContainerField(57), LayoutImmutable, Blittable]
		public bool UsePredictedSight { get; set; }
		
		[ContainerField(58), LayoutImmutable, Blittable]
		public bool UseWeaponOrientations { get; set; }
		
		[ContainerField(59), LayoutImmutable, Blittable]
		public bool UseVelocityVectorMarker { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public bool UseLockingController { get; set; }
		
		[ContainerField(61), LayoutImmutable, Blittable]
		public bool UseThrust { get; set; }
		
		[ContainerField(62), LayoutImmutable, Blittable]
		public bool UseGForce { get; set; }
		
		[ContainerField(63), LayoutImmutable, Blittable]
		public bool UseSkidSlip { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public bool UseClimbRate { get; set; }
		
		[ContainerField(65), LayoutImmutable, Blittable]
		public bool UseAimWarning { get; set; }
		
		[ContainerField(66), LayoutImmutable, Blittable]
		public bool UseRenderTarget { get; set; }
		
	}
}
