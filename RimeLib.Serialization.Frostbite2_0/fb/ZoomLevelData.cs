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
using RimeLib.Serialization.Frostbite2_0.Ebx;
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 92)]
	public partial class ZoomLevelData :
		DataContainer
	{
		[ObservableProperty]
		[property: ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		private float _FieldOfView;

		[ObservableProperty]
		[property: ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		private float _DispersionMultiplier;

		[ObservableProperty]
		[property: ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		private float _LookSpeedMultiplier;

		[ObservableProperty]
		[property: ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		private float _SprintLookSpeedMultiplier;

		[ObservableProperty]
		[property: ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		private float _MoveSpeedMultiplier;

		[ObservableProperty]
		[property: ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private float _SwayPitchMultiplier;

		[ObservableProperty]
		[property: ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		private float _SwayYawMultiplier;

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _SupportedSwayPitchMultiplier;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _SupportedSwayYawMultiplier;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _TimePitchMultiplier;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _TimeYawMultiplier;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _RecoilMultiplier;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _FadeToBlackDuration;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _RecoilFovMultiplier;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _CameraImpulseMultiplier;

		[ObservableProperty]
		[property: ContainerField(68), JsonProperty(Order = 68)]
		private ZoomLevelActivateEventType _OnActivateEventType = new();

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _StartFadeToBlackAtTime;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _FadeFromBlackDuration;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _StartFadeFromBlackAtTime;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _ScreenExposureAreaScale;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private bool _FadeToBlackInZoomTransition;

		[ObservableProperty]
		[property: ContainerField(89), LayoutImmutable, Blittable, JsonProperty(Order = 89)]
		private bool _UseFovSpecialisation;

		[ObservableProperty]
		[property: ContainerField(90), LayoutImmutable, Blittable, JsonProperty(Order = 90)]
		private bool _AllowFieldOfViewScaling;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			p_Writer.Write(FieldOfView);
			p_Writer.Write(DispersionMultiplier);
			p_Writer.Write(LookSpeedMultiplier);
			p_Writer.Write(SprintLookSpeedMultiplier);
			p_Writer.Write(MoveSpeedMultiplier);
			p_Writer.Write(SwayPitchMultiplier);
			p_Writer.Write(SwayYawMultiplier);
			p_Writer.Write(SupportedSwayPitchMultiplier);
			p_Writer.Write(SupportedSwayYawMultiplier);
			p_Writer.Write(TimePitchMultiplier);
			p_Writer.Write(TimeYawMultiplier);
			p_Writer.Write(RecoilMultiplier);
			p_Writer.Write(FadeToBlackDuration);
			p_Writer.Write(RecoilFovMultiplier);
			p_Writer.Write(CameraImpulseMultiplier);
			p_Writer.Write((int) OnActivateEventType);
			p_Writer.Write(StartFadeToBlackAtTime);
			p_Writer.Write(FadeFromBlackDuration);
			p_Writer.Write(StartFadeFromBlackAtTime);
			p_Writer.Write(ScreenExposureAreaScale);
			p_Writer.Write(FadeToBlackInZoomTransition);
			p_Writer.Write(UseFovSpecialisation);
			p_Writer.Write(AllowFieldOfViewScaling);
			p_Writer.WriteNullBytes(1);
		}
	}
}
