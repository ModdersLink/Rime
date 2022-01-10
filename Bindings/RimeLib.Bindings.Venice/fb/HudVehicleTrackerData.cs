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
	[ContainerType(4, 100)]
	public class HudVehicleTrackerData : 
		UIPartData
	{
		[ContainerField(8)]
		public EdgePointerData EdgePointer { get; set; } = new();

		[ContainerField(24)]
		public UIHudIcon EnemyTrackerIcon { get; set; } = new();

		[ContainerField(28)]
		public UIHudIcon OutsideScreenTrackerIcon { get; set; } = new();

		[ContainerField(32)]
		public VehicleTrackerRenderTargetData RenderTargetData { get; set; } = new();

		[ContainerField(56)]
		public UIHudIcon MissileTrackerIcon { get; set; } = new();

		[ContainerField(60), LayoutImmutable, Blittable]
		public float IconSize { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float RadarSensitivity { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float HeatSensitivity { get; set; }

		[ContainerField(72)]
		public UIHudIcon FriendlyTrackerIcon { get; set; } = new();

		[ContainerField(76)]
		public UIHudIcon LaserPaintedVehicleTrackerIcon { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float DistanceIconShrinkFactor { get; set; }

		[ContainerField(88)]
		public UIHudIcon MissileLockTrackerIcon { get; set; } = new();

		[ContainerField(92), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get; set; }

		[ContainerField(93), LayoutImmutable, Blittable]
		public bool UseTrackerSignatures { get; set; }

		[ContainerField(94), LayoutImmutable, Blittable]
		public bool EnableEdgePointers { get; set; }

		[ContainerField(95), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool ShowTracker { get; set; }

		public static void Deserialize(HudVehicleTrackerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.EdgePointerData.Deserialize(p_Instance.EdgePointer, p_Reader, p_Parser);
			p_Instance.EnemyTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.OutsideScreenTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			fb.VehicleTrackerRenderTargetData.Deserialize(p_Instance.RenderTargetData, p_Reader, p_Parser);
			p_Instance.MissileTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.IconSize = p_Reader.ReadSingle();
			p_Instance.RadarSensitivity = p_Reader.ReadSingle();
			p_Instance.HeatSensitivity = p_Reader.ReadSingle();
			p_Instance.FriendlyTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.LaserPaintedVehicleTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.MaxDistance = p_Reader.ReadSingle();
			p_Instance.DistanceIconShrinkFactor = p_Reader.ReadSingle();
			p_Instance.MissileLockTrackerIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.TrackOnlyUsedVehicles = p_Reader.ReadBool();
			p_Instance.UseTrackerSignatures = p_Reader.ReadBool();
			p_Instance.EnableEdgePointers = p_Reader.ReadBool();
			p_Instance.TrackLaserPaintedObjects = p_Reader.ReadBool();
			p_Instance.UseCameraComponentTransform = p_Reader.ReadBool();
			p_Instance.ShowTracker = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
