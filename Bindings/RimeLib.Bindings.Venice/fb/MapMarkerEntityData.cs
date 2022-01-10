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
	[ContainerType(16, 208)]
	public class MapMarkerEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BaseTransform { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable]
		public float ProgressMinTime { get; set; }

		[ContainerField(116), LayoutImmutable]
		public string Sid { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable, Blittable]
		public int NrOfPassengers { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public int NrOfEntries { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ProgressTime1Player { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float ShowRadius { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float HideRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float BlinkTime { get; set; }

		[ContainerField(144)]
		public MapMarkerType MarkerType { get; set; } = new();

		[ContainerField(148)]
		public TeamId VisibleForTeam { get; set; } = new();

		[ContainerField(152)]
		public TeamId OwnerTeam { get; set; } = new();

		[ContainerField(156)]
		public UIHudIcon HudIcon { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float VerticalOffset { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float FocusPointRadius { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float InstantFlagReturnRadius { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float Progress { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float ProgressPlayerSpeedUpPercentage { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public uint TrackedPlayersInRange { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float TrackingPlayerRange { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float ProgressTime { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public bool OnlyShowSnapped { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable]
		public bool FlagControlMarker { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable]
		public bool ShowProgress { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable]
		public bool UseMarkerTransform { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool IsVisible { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable]
		public bool Snap { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable]
		public bool ShowAirTargetBox { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable]
		public bool IsFocusPoint { get; set; }

		public static void Deserialize(MapMarkerEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.BaseTransform, p_Reader, p_Parser);
			p_Instance.ProgressMinTime = p_Reader.ReadSingle();
			p_Instance.Sid = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.NrOfPassengers = p_Reader.ReadInt32();
			p_Instance.NrOfEntries = p_Reader.ReadInt32();
			p_Instance.ProgressTime1Player = p_Reader.ReadSingle();
			p_Instance.ShowRadius = p_Reader.ReadSingle();
			p_Instance.HideRadius = p_Reader.ReadSingle();
			p_Instance.BlinkTime = p_Reader.ReadSingle();
			p_Instance.MarkerType = (MapMarkerType) p_Reader.ReadInt32();
			p_Instance.VisibleForTeam = (TeamId) p_Reader.ReadInt32();
			p_Instance.OwnerTeam = (TeamId) p_Reader.ReadInt32();
			p_Instance.HudIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.VerticalOffset = p_Reader.ReadSingle();
			p_Instance.FocusPointRadius = p_Reader.ReadSingle();
			p_Instance.InstantFlagReturnRadius = p_Reader.ReadSingle();
			p_Instance.Progress = p_Reader.ReadSingle();
			p_Instance.ProgressPlayerSpeedUpPercentage = p_Reader.ReadSingle();
			p_Instance.TrackedPlayersInRange = p_Reader.ReadUInt32();
			p_Instance.TrackingPlayerRange = p_Reader.ReadSingle();
			p_Instance.ProgressTime = p_Reader.ReadSingle();
			p_Instance.OnlyShowSnapped = p_Reader.ReadBool();
			p_Instance.FlagControlMarker = p_Reader.ReadBool();
			p_Instance.ShowProgress = p_Reader.ReadBool();
			p_Instance.UseMarkerTransform = p_Reader.ReadBool();
			p_Instance.IsVisible = p_Reader.ReadBool();
			p_Instance.Snap = p_Reader.ReadBool();
			p_Instance.ShowAirTargetBox = p_Reader.ReadBool();
			p_Instance.IsFocusPoint = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
