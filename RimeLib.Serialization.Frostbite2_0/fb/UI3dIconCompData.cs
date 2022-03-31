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

namespace fb
{
	[ContainerType(4, 160)]
	public class UI3dIconCompData :
		UIComponentData
	{
		[ContainerField(28), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public Vec2 PixelOffset { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float IconSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float MaxFarFade { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float MaxCloseFade { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float SnapSafeZone { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float SnapCenterYOffset { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float ShrinkSnapAnimationTime { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float TrackerHudRadiusX { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float TrackerHudRadiusY { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float MaxLookAtThreshold { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable, JsonProperty(Order = 72)]
		public float MinLookAtThreshold { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable, JsonProperty(Order = 76)]
		public float MinLookAtThresholdDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public float DrawDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		public float FadeDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable, JsonProperty(Order = 88)]
		public float FadeEndDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		public float MinimumDrawDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public float MinimumFadeDistance { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable, JsonProperty(Order = 100)]
		public int MaxTagUpdatesPerFrame { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public float VerticalOffset { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public float ShowLabelRange { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float TeamRadioDistance { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float ScaleDistance { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public float MaxScaleMod { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public float MaxXRotation { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float MaxYRotation { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float HorisontalOffset { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float ShowSupportAmmoThreshold { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float VerticalOffsetMaxOffset { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float VerticalOffsetScaleFactor { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public float ShowEngineerArmorThreshold { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float ShowMedicHealthThreshold { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool SnapIcons { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool CircularSnap { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool OnlyShowSnapped { get; set; }

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
