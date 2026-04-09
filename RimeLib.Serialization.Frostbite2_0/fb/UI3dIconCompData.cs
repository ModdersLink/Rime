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
	[ContainerType(4, 160)]
	public partial class UI3dIconCompData :
		UIComponentData
	{
		[ObservableProperty]
		[property: ContainerField(28), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		private Vec2 _PixelOffset = new();

		[ObservableProperty]
		[property: ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		private float _IconSize;

		[ObservableProperty]
		[property: ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		private float _MaxFarFade;

		[ObservableProperty]
		[property: ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		private float _MaxCloseFade;

		[ObservableProperty]
		[property: ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		private float _SnapSafeZone;

		[ObservableProperty]
		[property: ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		private float _SnapCenterYOffset;

		[ObservableProperty]
		[property: ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		private float _ShrinkSnapAnimationTime;

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _TrackerHudRadiusX;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _TrackerHudRadiusY;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _MaxLookAtThreshold;

		[ObservableProperty]
		[property: ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		private float _MinLookAtThreshold;

		[ObservableProperty]
		[property: ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		private float _MinLookAtThresholdDistance;

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _DrawDistance;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _FadeDistance;

		[ObservableProperty]
		[property: ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		private float _FadeEndDistance;

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private float _MinimumDrawDistance;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private float _MinimumFadeDistance;

		[ObservableProperty]
		[property: ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		private int _MaxTagUpdatesPerFrame;

		[ObservableProperty]
		[property: ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		private float _VerticalOffset;

		[ObservableProperty]
		[property: ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		private float _ShowLabelRange;

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _TeamRadioDistance;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		private float _ScaleDistance;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private float _MaxScaleMod;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private float _MaxXRotation;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _MaxYRotation;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _HorisontalOffset;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _ShowSupportAmmoThreshold;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _VerticalOffsetMaxOffset;

		[ObservableProperty]
		[property: ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		private float _VerticalOffsetScaleFactor;

		[ObservableProperty]
		[property: ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		private float _ShowEngineerArmorThreshold;

		[ObservableProperty]
		[property: ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		private float _ShowMedicHealthThreshold;

		[ObservableProperty]
		[property: ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		private bool _SnapIcons;

		[ObservableProperty]
		[property: ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		private bool _CircularSnap;

		[ObservableProperty]
		[property: ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		private bool _OnlyShowSnapped;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			PixelOffset.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IconSize);
			p_Writer.Write(MaxFarFade);
			p_Writer.Write(MaxCloseFade);
			p_Writer.Write(SnapSafeZone);
			p_Writer.Write(SnapCenterYOffset);
			p_Writer.Write(ShrinkSnapAnimationTime);
			p_Writer.Write(TrackerHudRadiusX);
			p_Writer.Write(TrackerHudRadiusY);
			p_Writer.Write(MaxLookAtThreshold);
			p_Writer.Write(MinLookAtThreshold);
			p_Writer.Write(MinLookAtThresholdDistance);
			p_Writer.Write(DrawDistance);
			p_Writer.Write(FadeDistance);
			p_Writer.Write(FadeEndDistance);
			p_Writer.Write(MinimumDrawDistance);
			p_Writer.Write(MinimumFadeDistance);
			p_Writer.Write(MaxTagUpdatesPerFrame);
			p_Writer.Write(VerticalOffset);
			p_Writer.Write(ShowLabelRange);
			p_Writer.Write(TeamRadioDistance);
			p_Writer.Write(ScaleDistance);
			p_Writer.Write(MaxScaleMod);
			p_Writer.Write(MaxXRotation);
			p_Writer.Write(MaxYRotation);
			p_Writer.Write(HorisontalOffset);
			p_Writer.Write(ShowSupportAmmoThreshold);
			p_Writer.Write(VerticalOffsetMaxOffset);
			p_Writer.Write(VerticalOffsetScaleFactor);
			p_Writer.Write(ShowEngineerArmorThreshold);
			p_Writer.Write(ShowMedicHealthThreshold);
			p_Writer.Write(SnapIcons);
			p_Writer.Write(CircularSnap);
			p_Writer.Write(OnlyShowSnapped);
			p_Writer.WriteNullBytes(1);
		}
	}
}
