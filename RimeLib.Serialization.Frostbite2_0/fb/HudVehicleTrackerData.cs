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
	[ContainerType(4, 100)]
	public partial class HudVehicleTrackerData :
		UIPartData
	{
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private EdgePointerData _EdgePointer = new();

		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private UIHudIcon _EnemyTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private UIHudIcon _OutsideScreenTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private VehicleTrackerRenderTargetData _RenderTargetData = new();

		[ObservableProperty]
		[property: ContainerField(56), JsonProperty(Order = 56)]
		private UIHudIcon _MissileTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		private float _IconSize;

		[ObservableProperty]
		[property: ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		private float _RadarSensitivity;

		[ObservableProperty]
		[property: ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		private float _HeatSensitivity;

		[ObservableProperty]
		[property: ContainerField(72), JsonProperty(Order = 72)]
		private UIHudIcon _FriendlyTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(76), JsonProperty(Order = 76)]
		private UIHudIcon _LaserPaintedVehicleTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		private float _MaxDistance;

		[ObservableProperty]
		[property: ContainerField(84), LayoutImmutable, Blittable, JsonProperty(Order = 84)]
		private float _DistanceIconShrinkFactor;

		[ObservableProperty]
		[property: ContainerField(88), JsonProperty(Order = 88)]
		private UIHudIcon _MissileLockTrackerIcon = new();

		[ObservableProperty]
		[property: ContainerField(92), LayoutImmutable, Blittable, JsonProperty(Order = 92)]
		private bool _TrackOnlyUsedVehicles;

		[ObservableProperty]
		[property: ContainerField(93), LayoutImmutable, Blittable, JsonProperty(Order = 93)]
		private bool _UseTrackerSignatures;

		[ObservableProperty]
		[property: ContainerField(94), LayoutImmutable, Blittable, JsonProperty(Order = 94)]
		private bool _EnableEdgePointers;

		[ObservableProperty]
		[property: ContainerField(95), LayoutImmutable, Blittable, JsonProperty(Order = 95)]
		private bool _TrackLaserPaintedObjects;

		[ObservableProperty]
		[property: ContainerField(96), LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private bool _UseCameraComponentTransform;

		[ObservableProperty]
		[property: ContainerField(97), LayoutImmutable, Blittable, JsonProperty(Order = 97)]
		private bool _ShowTracker;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			EdgePointer.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) EnemyTrackerIcon);
			p_Writer.Write((int) OutsideScreenTrackerIcon);
			RenderTargetData.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) MissileTrackerIcon);
			p_Writer.Write(IconSize);
			p_Writer.Write(RadarSensitivity);
			p_Writer.Write(HeatSensitivity);
			p_Writer.Write((int) FriendlyTrackerIcon);
			p_Writer.Write((int) LaserPaintedVehicleTrackerIcon);
			p_Writer.Write(MaxDistance);
			p_Writer.Write(DistanceIconShrinkFactor);
			p_Writer.Write((int) MissileLockTrackerIcon);
			p_Writer.Write(TrackOnlyUsedVehicles);
			p_Writer.Write(UseTrackerSignatures);
			p_Writer.Write(EnableEdgePointers);
			p_Writer.Write(TrackLaserPaintedObjects);
			p_Writer.Write(UseCameraComponentTransform);
			p_Writer.Write(ShowTracker);
			p_Writer.WriteNullBytes(2);
		}
	}
}
