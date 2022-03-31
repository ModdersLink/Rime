///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(0), LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public float CrosshairScaleMin { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable, JsonProperty(Order = 4)]
		public float CrosshairScaleMax { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float CrosshairOpacityMin { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float CrosshairOpacityMax { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float CrosshairOpacityModifier { get; set; }
		
		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string CrosshairTypeId { get; set; } = string.Empty;
		
		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string WeaponClass { get; set; } = string.Empty;
		
		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float CameraShakeModifier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float SeaLevelAltFreq { get; set; }
		
		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float LowAmmoWarning { get; set; }
		
		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float ReloadPrompt { get; set; }
		
		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public int RenderTargetIndex { get; set; }
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public CtrRef<UIPartPropertyList> HudPropertyList { get; set; } = new();
		
		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public bool ShowMinimap { get; set; }
		
		[ContainerField(53), LayoutImmutable, Blittable, JsonProperty(Order = 53)]
		public bool InfiniteAmmo { get; set; }
		
		[ContainerField(54), LayoutImmutable, Blittable, JsonProperty(Order = 54)]
		public bool HideCrosshairWhenAimOnFriend { get; set; }
		
		[ContainerField(55), LayoutImmutable, Blittable, JsonProperty(Order = 55)]
		public bool HideAmmo { get; set; }
		
		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public bool UseRangeMeter { get; set; }
		
		[ContainerField(57), LayoutImmutable, Blittable, JsonProperty(Order = 57)]
		public bool UsePredictedSight { get; set; }
		
		[ContainerField(58), LayoutImmutable, Blittable, JsonProperty(Order = 58)]
		public bool UseWeaponOrientations { get; set; }
		
		[ContainerField(59), LayoutImmutable, Blittable, JsonProperty(Order = 59)]
		public bool UseVelocityVectorMarker { get; set; }
		
		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public bool UseLockingController { get; set; }
		
		[ContainerField(61), LayoutImmutable, Blittable, JsonProperty(Order = 61)]
		public bool UseThrust { get; set; }
		
		[ContainerField(62), LayoutImmutable, Blittable, JsonProperty(Order = 62)]
		public bool UseGForce { get; set; }
		
		[ContainerField(63), LayoutImmutable, Blittable, JsonProperty(Order = 63)]
		public bool UseSkidSlip { get; set; }
		
		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public bool UseClimbRate { get; set; }
		
		[ContainerField(65), LayoutImmutable, Blittable, JsonProperty(Order = 65)]
		public bool UseAimWarning { get; set; }
		
		[ContainerField(66), LayoutImmutable, Blittable, JsonProperty(Order = 66)]
		public bool UseRenderTarget { get; set; }
		
	}
}
