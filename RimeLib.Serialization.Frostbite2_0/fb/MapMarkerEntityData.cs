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
	[ContainerType(16, 208)]
	public partial class MapMarkerEntityData :
		GameEntityData
	{
		[ObservableProperty]
		[property: ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		private Vec3 _BaseTransform = new();

		[ObservableProperty]
		[property: ContainerField(112), LayoutImmutable, Blittable, JsonProperty(Order = 112)]
		private float _ProgressMinTime;

		[ObservableProperty]
		[property: ContainerField(116), LayoutImmutable, JsonProperty(Order = 116)]
		private string _Sid = string.Empty;

		[ObservableProperty]
		[property: ContainerField(120), LayoutImmutable, Blittable, JsonProperty(Order = 120)]
		private int _NrOfPassengers;

		[ObservableProperty]
		[property: ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		private int _NrOfEntries;

		[ObservableProperty]
		[property: ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		private float _ProgressTime1Player;

		[ObservableProperty]
		[property: ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		private float _ShowRadius;

		[ObservableProperty]
		[property: ContainerField(136), LayoutImmutable, Blittable, JsonProperty(Order = 136)]
		private float _HideRadius;

		[ObservableProperty]
		[property: ContainerField(140), LayoutImmutable, Blittable, JsonProperty(Order = 140)]
		private float _BlinkTime;

		[ObservableProperty]
		[property: ContainerField(144), JsonProperty(Order = 144)]
		private MapMarkerType _MarkerType = new();

		[ObservableProperty]
		[property: ContainerField(148), JsonProperty(Order = 148)]
		private TeamId _VisibleForTeam = new();

		[ObservableProperty]
		[property: ContainerField(152), JsonProperty(Order = 152)]
		private TeamId _OwnerTeam = new();

		[ObservableProperty]
		[property: ContainerField(156), JsonProperty(Order = 156)]
		private UIHudIcon _HudIcon = new();

		[ObservableProperty]
		[property: ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		private float _VerticalOffset;

		[ObservableProperty]
		[property: ContainerField(164), LayoutImmutable, Blittable, JsonProperty(Order = 164)]
		private float _FocusPointRadius;

		[ObservableProperty]
		[property: ContainerField(168), LayoutImmutable, Blittable, JsonProperty(Order = 168)]
		private float _InstantFlagReturnRadius;

		[ObservableProperty]
		[property: ContainerField(172), LayoutImmutable, Blittable, JsonProperty(Order = 172)]
		private float _Progress;

		[ObservableProperty]
		[property: ContainerField(176), LayoutImmutable, Blittable, JsonProperty(Order = 176)]
		private float _ProgressPlayerSpeedUpPercentage;

		[ObservableProperty]
		[property: ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		private uint _TrackedPlayersInRange;

		[ObservableProperty]
		[property: ContainerField(184), LayoutImmutable, Blittable, JsonProperty(Order = 184)]
		private float _TrackingPlayerRange;

		[ObservableProperty]
		[property: ContainerField(188), LayoutImmutable, Blittable, JsonProperty(Order = 188)]
		private float _ProgressTime;

		[ObservableProperty]
		[property: ContainerField(192), LayoutImmutable, Blittable, JsonProperty(Order = 192)]
		private bool _OnlyShowSnapped;

		[ObservableProperty]
		[property: ContainerField(193), LayoutImmutable, Blittable, JsonProperty(Order = 193)]
		private bool _FlagControlMarker;

		[ObservableProperty]
		[property: ContainerField(194), LayoutImmutable, Blittable, JsonProperty(Order = 194)]
		private bool _ShowProgress;

		[ObservableProperty]
		[property: ContainerField(195), LayoutImmutable, Blittable, JsonProperty(Order = 195)]
		private bool _UseMarkerTransform;

		[ObservableProperty]
		[property: ContainerField(196), LayoutImmutable, Blittable, JsonProperty(Order = 196)]
		private bool _IsVisible;

		[ObservableProperty]
		[property: ContainerField(197), LayoutImmutable, Blittable, JsonProperty(Order = 197)]
		private bool _Snap;

		[ObservableProperty]
		[property: ContainerField(198), LayoutImmutable, Blittable, JsonProperty(Order = 198)]
		private bool _ShowAirTargetBox;

		[ObservableProperty]
		[property: ContainerField(199), LayoutImmutable, Blittable, JsonProperty(Order = 199)]
		private bool _IsFocusPoint;

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
