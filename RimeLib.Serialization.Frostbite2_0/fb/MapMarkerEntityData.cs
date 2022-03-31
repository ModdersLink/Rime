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
	[ContainerType(16, 208)]
	public class MapMarkerEntityData :
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public Vec3 BaseTransform { get; set; } = new();

		[ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		public float ProgressMinTime { get; set; }

		[ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		public string Sid { get; set; } = string.Empty;

		[ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		public int NrOfPassengers { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int NrOfEntries { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public float ProgressTime1Player { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float ShowRadius { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		public float HideRadius { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		public float BlinkTime { get; set; }

		[ContainerField(144), JsonProperty(Order = 144)]
		public MapMarkerType MarkerType { get; set; } = new();

		[ContainerField(148), JsonProperty(Order = 148)]
		public TeamId VisibleForTeam { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public TeamId OwnerTeam { get; set; } = new();

		[ContainerField(156), JsonProperty(Order = 156)]
		public UIHudIcon HudIcon { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public float VerticalOffset { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		public float FocusPointRadius { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		public float InstantFlagReturnRadius { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		public float Progress { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		public float ProgressPlayerSpeedUpPercentage { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public uint TrackedPlayersInRange { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		public float TrackingPlayerRange { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		public float ProgressTime { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		public bool OnlyShowSnapped { get; set; }

		[ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		public bool FlagControlMarker { get; set; }

		[ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		public bool ShowProgress { get; set; }

		[ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		public bool UseMarkerTransform { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		public bool IsVisible { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		public bool Snap { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		public bool ShowAirTargetBox { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		public bool IsFocusPoint { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			BaseTransform.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(ProgressMinTime);
			p_Writer.Write(p_EbxWriter.WriteString(Sid));
			p_Writer.Write(NrOfPassengers);
			p_Writer.Write(NrOfEntries);
			p_Writer.Write(ProgressTime1Player);
			p_Writer.Write(ShowRadius);
			p_Writer.Write(HideRadius);
			p_Writer.Write(BlinkTime);
			p_Writer.Write((int) MarkerType);
			p_Writer.Write((int) VisibleForTeam);
			p_Writer.Write((int) OwnerTeam);
			p_Writer.Write((int) HudIcon);
			p_Writer.Write(VerticalOffset);
			p_Writer.Write(FocusPointRadius);
			p_Writer.Write(InstantFlagReturnRadius);
			p_Writer.Write(Progress);
			p_Writer.Write(ProgressPlayerSpeedUpPercentage);
			p_Writer.Write(TrackedPlayersInRange);
			p_Writer.Write(TrackingPlayerRange);
			p_Writer.Write(ProgressTime);
			p_Writer.Write(OnlyShowSnapped);
			p_Writer.Write(FlagControlMarker);
			p_Writer.Write(ShowProgress);
			p_Writer.Write(UseMarkerTransform);
			p_Writer.Write(IsVisible);
			p_Writer.Write(Snap);
			p_Writer.Write(ShowAirTargetBox);
			p_Writer.Write(IsFocusPoint);
			p_Writer.WriteNullBytes(8);
		}
	}
}
