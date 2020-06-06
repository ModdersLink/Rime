///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class ZoomLevelData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float FieldOfView { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DispersionMultiplier { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LookSpeedMultiplier { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float SprintLookSpeedMultiplier { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MoveSpeedMultiplier { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float SwayPitchMultiplier { get; set; } // 0x1C (28)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public float SwayYawMultiplier { get; set; } // 0x20 (32)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public float SupportedSwayPitchMultiplier { get; set; } // 0x24 (36)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public float SupportedSwayYawMultiplier { get; set; } // 0x28 (40)
		
		[ContainerField(44), LayoutImmutable, Blittable]
		public float TimePitchMultiplier { get; set; } // 0x2C (44)
		
		[ContainerField(48), LayoutImmutable, Blittable]
		public float TimeYawMultiplier { get; set; } // 0x30 (48)
		
		[ContainerField(52), LayoutImmutable, Blittable]
		public float RecoilMultiplier { get; set; } // 0x34 (52)
		
		[ContainerField(56), LayoutImmutable, Blittable]
		public float FadeToBlackDuration { get; set; } // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float RecoilFovMultiplier { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float CameraImpulseMultiplier { get; set; } // 0x40 (64)
		
		[ContainerField(68)]
		public ZoomLevelActivateEventType OnActivateEventType { get; set; } = new ZoomLevelActivateEventType(); // 0x44 (68)
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float StartFadeToBlackAtTime { get; set; } // 0x48 (72)
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float FadeFromBlackDuration { get; set; } // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float StartFadeFromBlackAtTime { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float ScreenExposureAreaScale { get; set; } // 0x54 (84)
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public bool FadeToBlackInZoomTransition { get; set; } // 0x58 (88)
		
		[ContainerField(89), LayoutImmutable, Blittable]
		public bool UseFovSpecialisation { get; set; } // 0x59 (89)
		
		[ContainerField(90), LayoutImmutable, Blittable]
		public bool AllowFieldOfViewScaling { get; set; } // 0x5A (90)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2227716035:
					FieldOfView = (float) p_Value;
					break;

				case 2492618348:
					DispersionMultiplier = (float) p_Value;
					break;

				case 1418472942:
					LookSpeedMultiplier = (float) p_Value;
					break;

				case 1809327980:
					SprintLookSpeedMultiplier = (float) p_Value;
					break;

				case 968667256:
					MoveSpeedMultiplier = (float) p_Value;
					break;

				case 2304589396:
					SwayPitchMultiplier = (float) p_Value;
					break;

				case 2483524029:
					SwayYawMultiplier = (float) p_Value;
					break;

				case 44184954:
					SupportedSwayPitchMultiplier = (float) p_Value;
					break;

				case 741079379:
					SupportedSwayYawMultiplier = (float) p_Value;
					break;

				case 534769181:
					TimePitchMultiplier = (float) p_Value;
					break;

				case 1816853300:
					TimeYawMultiplier = (float) p_Value;
					break;

				case 2433005616:
					RecoilMultiplier = (float) p_Value;
					break;

				case 4095432289:
					FadeToBlackDuration = (float) p_Value;
					break;

				case 2103090735:
					RecoilFovMultiplier = (float) p_Value;
					break;

				case 907226508:
					CameraImpulseMultiplier = (float) p_Value;
					break;

				case 269248393:
					OnActivateEventType = (ZoomLevelActivateEventType) Enum.ToObject(typeof(ZoomLevelActivateEventType), p_Value);
					break;

				case 3004064735:
					StartFadeToBlackAtTime = (float) p_Value;
					break;

				case 869388908:
					FadeFromBlackDuration = (float) p_Value;
					break;

				case 3621030994:
					StartFadeFromBlackAtTime = (float) p_Value;
					break;

				case 2151479797:
					ScreenExposureAreaScale = (float) p_Value;
					break;

				case 2005859552:
					FadeToBlackInZoomTransition = (bool) p_Value;
					break;

				case 3389710847:
					UseFovSpecialisation = (bool) p_Value;
					break;

				case 899159559:
					AllowFieldOfViewScaling = (bool) p_Value;
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
				case 2227716035:
					return FieldOfView;

				case 2492618348:
					return DispersionMultiplier;

				case 1418472942:
					return LookSpeedMultiplier;

				case 1809327980:
					return SprintLookSpeedMultiplier;

				case 968667256:
					return MoveSpeedMultiplier;

				case 2304589396:
					return SwayPitchMultiplier;

				case 2483524029:
					return SwayYawMultiplier;

				case 44184954:
					return SupportedSwayPitchMultiplier;

				case 741079379:
					return SupportedSwayYawMultiplier;

				case 534769181:
					return TimePitchMultiplier;

				case 1816853300:
					return TimeYawMultiplier;

				case 2433005616:
					return RecoilMultiplier;

				case 4095432289:
					return FadeToBlackDuration;

				case 2103090735:
					return RecoilFovMultiplier;

				case 907226508:
					return CameraImpulseMultiplier;

				case 269248393:
					return OnActivateEventType;

				case 3004064735:
					return StartFadeToBlackAtTime;

				case 869388908:
					return FadeFromBlackDuration;

				case 3621030994:
					return StartFadeFromBlackAtTime;

				case 2151479797:
					return ScreenExposureAreaScale;

				case 2005859552:
					return FadeToBlackInZoomTransition;

				case 3389710847:
					return UseFovSpecialisation;

				case 899159559:
					return AllowFieldOfViewScaling;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2227716035:
					return typeof(ZoomLevelData).GetProperty(nameof(FieldOfView));

				case 2492618348:
					return typeof(ZoomLevelData).GetProperty(nameof(DispersionMultiplier));

				case 1418472942:
					return typeof(ZoomLevelData).GetProperty(nameof(LookSpeedMultiplier));

				case 1809327980:
					return typeof(ZoomLevelData).GetProperty(nameof(SprintLookSpeedMultiplier));

				case 968667256:
					return typeof(ZoomLevelData).GetProperty(nameof(MoveSpeedMultiplier));

				case 2304589396:
					return typeof(ZoomLevelData).GetProperty(nameof(SwayPitchMultiplier));

				case 2483524029:
					return typeof(ZoomLevelData).GetProperty(nameof(SwayYawMultiplier));

				case 44184954:
					return typeof(ZoomLevelData).GetProperty(nameof(SupportedSwayPitchMultiplier));

				case 741079379:
					return typeof(ZoomLevelData).GetProperty(nameof(SupportedSwayYawMultiplier));

				case 534769181:
					return typeof(ZoomLevelData).GetProperty(nameof(TimePitchMultiplier));

				case 1816853300:
					return typeof(ZoomLevelData).GetProperty(nameof(TimeYawMultiplier));

				case 2433005616:
					return typeof(ZoomLevelData).GetProperty(nameof(RecoilMultiplier));

				case 4095432289:
					return typeof(ZoomLevelData).GetProperty(nameof(FadeToBlackDuration));

				case 2103090735:
					return typeof(ZoomLevelData).GetProperty(nameof(RecoilFovMultiplier));

				case 907226508:
					return typeof(ZoomLevelData).GetProperty(nameof(CameraImpulseMultiplier));

				case 269248393:
					return typeof(ZoomLevelData).GetProperty(nameof(OnActivateEventType));

				case 3004064735:
					return typeof(ZoomLevelData).GetProperty(nameof(StartFadeToBlackAtTime));

				case 869388908:
					return typeof(ZoomLevelData).GetProperty(nameof(FadeFromBlackDuration));

				case 3621030994:
					return typeof(ZoomLevelData).GetProperty(nameof(StartFadeFromBlackAtTime));

				case 2151479797:
					return typeof(ZoomLevelData).GetProperty(nameof(ScreenExposureAreaScale));

				case 2005859552:
					return typeof(ZoomLevelData).GetProperty(nameof(FadeToBlackInZoomTransition));

				case 3389710847:
					return typeof(ZoomLevelData).GetProperty(nameof(UseFovSpecialisation));

				case 899159559:
					return typeof(ZoomLevelData).GetProperty(nameof(AllowFieldOfViewScaling));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
