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
	public class ZoomLevelData : 
		DataContainer
	{
		protected float m_FieldOfView = new float();
		[ContainerField(8), LayoutImmutable, Blittable, ContainerFieldNameHash(2227716035)]
		public float FieldOfView { get { return m_FieldOfView; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(FieldOfView), this, m_FieldOfView, value)) m_FieldOfView = value; } } // 0x8 (8)
		
		protected float m_DispersionMultiplier = new float();
		[ContainerField(12), LayoutImmutable, Blittable, ContainerFieldNameHash(2492618348)]
		public float DispersionMultiplier { get { return m_DispersionMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(DispersionMultiplier), this, m_DispersionMultiplier, value)) m_DispersionMultiplier = value; } } // 0xC (12)
		
		protected float m_LookSpeedMultiplier = new float();
		[ContainerField(16), LayoutImmutable, Blittable, ContainerFieldNameHash(1418472942)]
		public float LookSpeedMultiplier { get { return m_LookSpeedMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(LookSpeedMultiplier), this, m_LookSpeedMultiplier, value)) m_LookSpeedMultiplier = value; } } // 0x10 (16)
		
		protected float m_SprintLookSpeedMultiplier = new float();
		[ContainerField(20), LayoutImmutable, Blittable, ContainerFieldNameHash(1809327980)]
		public float SprintLookSpeedMultiplier { get { return m_SprintLookSpeedMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(SprintLookSpeedMultiplier), this, m_SprintLookSpeedMultiplier, value)) m_SprintLookSpeedMultiplier = value; } } // 0x14 (20)
		
		protected float m_MoveSpeedMultiplier = new float();
		[ContainerField(24), LayoutImmutable, Blittable, ContainerFieldNameHash(968667256)]
		public float MoveSpeedMultiplier { get { return m_MoveSpeedMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(MoveSpeedMultiplier), this, m_MoveSpeedMultiplier, value)) m_MoveSpeedMultiplier = value; } } // 0x18 (24)
		
		protected float m_SwayPitchMultiplier = new float();
		[ContainerField(28), LayoutImmutable, Blittable, ContainerFieldNameHash(2304589396)]
		public float SwayPitchMultiplier { get { return m_SwayPitchMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(SwayPitchMultiplier), this, m_SwayPitchMultiplier, value)) m_SwayPitchMultiplier = value; } } // 0x1C (28)
		
		protected float m_SwayYawMultiplier = new float();
		[ContainerField(32), LayoutImmutable, Blittable, ContainerFieldNameHash(2483524029)]
		public float SwayYawMultiplier { get { return m_SwayYawMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(SwayYawMultiplier), this, m_SwayYawMultiplier, value)) m_SwayYawMultiplier = value; } } // 0x20 (32)
		
		protected float m_SupportedSwayPitchMultiplier = new float();
		[ContainerField(36), LayoutImmutable, Blittable, ContainerFieldNameHash(44184954)]
		public float SupportedSwayPitchMultiplier { get { return m_SupportedSwayPitchMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(SupportedSwayPitchMultiplier), this, m_SupportedSwayPitchMultiplier, value)) m_SupportedSwayPitchMultiplier = value; } } // 0x24 (36)
		
		protected float m_SupportedSwayYawMultiplier = new float();
		[ContainerField(40), LayoutImmutable, Blittable, ContainerFieldNameHash(741079379)]
		public float SupportedSwayYawMultiplier { get { return m_SupportedSwayYawMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(SupportedSwayYawMultiplier), this, m_SupportedSwayYawMultiplier, value)) m_SupportedSwayYawMultiplier = value; } } // 0x28 (40)
		
		protected float m_TimePitchMultiplier = new float();
		[ContainerField(44), LayoutImmutable, Blittable, ContainerFieldNameHash(534769181)]
		public float TimePitchMultiplier { get { return m_TimePitchMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(TimePitchMultiplier), this, m_TimePitchMultiplier, value)) m_TimePitchMultiplier = value; } } // 0x2C (44)
		
		protected float m_TimeYawMultiplier = new float();
		[ContainerField(48), LayoutImmutable, Blittable, ContainerFieldNameHash(1816853300)]
		public float TimeYawMultiplier { get { return m_TimeYawMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(TimeYawMultiplier), this, m_TimeYawMultiplier, value)) m_TimeYawMultiplier = value; } } // 0x30 (48)
		
		protected float m_RecoilMultiplier = new float();
		[ContainerField(52), LayoutImmutable, Blittable, ContainerFieldNameHash(2433005616)]
		public float RecoilMultiplier { get { return m_RecoilMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(RecoilMultiplier), this, m_RecoilMultiplier, value)) m_RecoilMultiplier = value; } } // 0x34 (52)
		
		protected float m_FadeToBlackDuration = new float();
		[ContainerField(56), LayoutImmutable, Blittable, ContainerFieldNameHash(4095432289)]
		public float FadeToBlackDuration { get { return m_FadeToBlackDuration; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(FadeToBlackDuration), this, m_FadeToBlackDuration, value)) m_FadeToBlackDuration = value; } } // 0x38 (56)
		
		protected float m_RecoilFovMultiplier = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(2103090735)]
		public float RecoilFovMultiplier { get { return m_RecoilFovMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(RecoilFovMultiplier), this, m_RecoilFovMultiplier, value)) m_RecoilFovMultiplier = value; } } // 0x3C (60)
		
		protected float m_CameraImpulseMultiplier = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(907226508)]
		public float CameraImpulseMultiplier { get { return m_CameraImpulseMultiplier; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(CameraImpulseMultiplier), this, m_CameraImpulseMultiplier, value)) m_CameraImpulseMultiplier = value; } } // 0x40 (64)
		
		protected ZoomLevelActivateEventType m_OnActivateEventType = new ZoomLevelActivateEventType();
		[ContainerField(68), ContainerFieldNameHash(269248393)]
		public ZoomLevelActivateEventType OnActivateEventType { get { return m_OnActivateEventType; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(OnActivateEventType), this, m_OnActivateEventType, value)) m_OnActivateEventType = value; } } // 0x44 (68)
		
		protected float m_StartFadeToBlackAtTime = new float();
		[ContainerField(72), LayoutImmutable, Blittable, ContainerFieldNameHash(3004064735)]
		public float StartFadeToBlackAtTime { get { return m_StartFadeToBlackAtTime; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(StartFadeToBlackAtTime), this, m_StartFadeToBlackAtTime, value)) m_StartFadeToBlackAtTime = value; } } // 0x48 (72)
		
		protected float m_FadeFromBlackDuration = new float();
		[ContainerField(76), LayoutImmutable, Blittable, ContainerFieldNameHash(869388908)]
		public float FadeFromBlackDuration { get { return m_FadeFromBlackDuration; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(FadeFromBlackDuration), this, m_FadeFromBlackDuration, value)) m_FadeFromBlackDuration = value; } } // 0x4C (76)
		
		protected float m_StartFadeFromBlackAtTime = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(3621030994)]
		public float StartFadeFromBlackAtTime { get { return m_StartFadeFromBlackAtTime; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(StartFadeFromBlackAtTime), this, m_StartFadeFromBlackAtTime, value)) m_StartFadeFromBlackAtTime = value; } } // 0x50 (80)
		
		protected float m_ScreenExposureAreaScale = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(2151479797)]
		public float ScreenExposureAreaScale { get { return m_ScreenExposureAreaScale; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(ScreenExposureAreaScale), this, m_ScreenExposureAreaScale, value)) m_ScreenExposureAreaScale = value; } } // 0x54 (84)
		
		protected bool m_FadeToBlackInZoomTransition = new bool();
		[ContainerField(88), LayoutImmutable, Blittable, ContainerFieldNameHash(2005859552)]
		public bool FadeToBlackInZoomTransition { get { return m_FadeToBlackInZoomTransition; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(FadeToBlackInZoomTransition), this, m_FadeToBlackInZoomTransition, value)) m_FadeToBlackInZoomTransition = value; } } // 0x58 (88)
		
		protected bool m_UseFovSpecialisation = new bool();
		[ContainerField(89), LayoutImmutable, Blittable, ContainerFieldNameHash(3389710847)]
		public bool UseFovSpecialisation { get { return m_UseFovSpecialisation; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(UseFovSpecialisation), this, m_UseFovSpecialisation, value)) m_UseFovSpecialisation = value; } } // 0x59 (89)
		
		protected bool m_AllowFieldOfViewScaling = new bool();
		[ContainerField(90), LayoutImmutable, Blittable, ContainerFieldNameHash(899159559)]
		public bool AllowFieldOfViewScaling { get { return m_AllowFieldOfViewScaling; } set { if (OnPropertyChanging("ZoomLevelData." + nameof(AllowFieldOfViewScaling), this, m_AllowFieldOfViewScaling, value)) m_AllowFieldOfViewScaling = value; } } // 0x5A (90)
		
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
