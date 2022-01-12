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
	[ContainerType(4, 160)]
	public class UI3dIconCompData : 
		UIComponentData
	{
		[ContainerField(28), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 PixelOffset { get; set; } = new();

		[ContainerField(36), LayoutImmutable, Blittable]
		public float IconSize { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxFarFade { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxCloseFade { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float SnapSafeZone { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float SnapCenterYOffset { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float ShrinkSnapAnimationTime { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float TrackerHudRadiusX { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float TrackerHudRadiusY { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float MaxLookAtThreshold { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float MinLookAtThreshold { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float MinLookAtThresholdDistance { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float DrawDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float FadeDistance { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float FadeEndDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float MinimumDrawDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float MinimumFadeDistance { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public int MaxTagUpdatesPerFrame { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float VerticalOffset { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float ShowLabelRange { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float TeamRadioDistance { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public float ScaleDistance { get; set; }

		[ContainerField(120), LayoutImmutable, Blittable]
		public float MaxScaleMod { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MaxXRotation { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float MaxYRotation { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float HorisontalOffset { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ShowSupportAmmoThreshold { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float VerticalOffsetMaxOffset { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public float VerticalOffsetScaleFactor { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float ShowEngineerArmorThreshold { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float ShowMedicHealthThreshold { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public bool SnapIcons { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable]
		public bool CircularSnap { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable]
		public bool OnlyShowSnapped { get; set; }

	}
}
