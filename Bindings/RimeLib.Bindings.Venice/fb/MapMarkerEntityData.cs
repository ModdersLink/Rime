///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(16)]
	public class MapMarkerEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BaseTransform { get; set; } = new Vec3(); // 0x60 (96)
		
		[ContainerField(112), LayoutImmutable, Blittable]
		public float ProgressMinTime { get; set; } // 0x70 (112)
		
		[ContainerField(116), LayoutImmutable]
		public string Sid { get; set; } // 0x74 (116)
		
		[ContainerField(120), LayoutImmutable, Blittable]
		public int NrOfPassengers { get; set; } // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public int NrOfEntries { get; set; } // 0x7C (124)
		
		[ContainerField(128), LayoutImmutable, Blittable]
		public float ProgressTime1Player { get; set; } // 0x80 (128)
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float ShowRadius { get; set; } // 0x84 (132)
		
		[ContainerField(136), LayoutImmutable, Blittable]
		public float HideRadius { get; set; } // 0x88 (136)
		
		[ContainerField(140), LayoutImmutable, Blittable]
		public float BlinkTime { get; set; } // 0x8C (140)
		
		[ContainerField(144)]
		public MapMarkerType MarkerType { get; set; } = new MapMarkerType(); // 0x90 (144)
		
		[ContainerField(148)]
		public TeamId VisibleForTeam { get; set; } = new TeamId(); // 0x94 (148)
		
		[ContainerField(152)]
		public TeamId OwnerTeam { get; set; } = new TeamId(); // 0x98 (152)
		
		[ContainerField(156)]
		public UIHudIcon HudIcon { get; set; } = new UIHudIcon(); // 0x9C (156)
		
		[ContainerField(160), LayoutImmutable, Blittable]
		public float VerticalOffset { get; set; } // 0xA0 (160)
		
		[ContainerField(164), LayoutImmutable, Blittable]
		public float FocusPointRadius { get; set; } // 0xA4 (164)
		
		[ContainerField(168), LayoutImmutable, Blittable]
		public float InstantFlagReturnRadius { get; set; } // 0xA8 (168)
		
		[ContainerField(172), LayoutImmutable, Blittable]
		public float Progress { get; set; } // 0xAC (172)
		
		[ContainerField(176), LayoutImmutable, Blittable]
		public float ProgressPlayerSpeedUpPercentage { get; set; } // 0xB0 (176)
		
		[ContainerField(180), LayoutImmutable, Blittable]
		public uint TrackedPlayersInRange { get; set; } // 0xB4 (180)
		
		[ContainerField(184), LayoutImmutable, Blittable]
		public float TrackingPlayerRange { get; set; } // 0xB8 (184)
		
		[ContainerField(188), LayoutImmutable, Blittable]
		public float ProgressTime { get; set; } // 0xBC (188)
		
		[ContainerField(192), LayoutImmutable, Blittable]
		public bool OnlyShowSnapped { get; set; } // 0xC0 (192)
		
		[ContainerField(193), LayoutImmutable, Blittable]
		public bool FlagControlMarker { get; set; } // 0xC1 (193)
		
		[ContainerField(194), LayoutImmutable, Blittable]
		public bool ShowProgress { get; set; } // 0xC2 (194)
		
		[ContainerField(195), LayoutImmutable, Blittable]
		public bool UseMarkerTransform { get; set; } // 0xC3 (195)
		
		[ContainerField(196), LayoutImmutable, Blittable]
		public bool IsVisible { get; set; } // 0xC4 (196)
		
		[ContainerField(197), LayoutImmutable, Blittable]
		public bool Snap { get; set; } // 0xC5 (197)
		
		[ContainerField(198), LayoutImmutable, Blittable]
		public bool ShowAirTargetBox { get; set; } // 0xC6 (198)
		
		[ContainerField(199), LayoutImmutable, Blittable]
		public bool IsFocusPoint { get; set; } // 0xC7 (199)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2733408796:
					BaseTransform = (Vec3) p_Value;
					break;

				case 1288296263:
					ProgressMinTime = (float) p_Value;
					break;

				case 193466587:
					Sid = (string) p_Value;
					break;

				case 1911822697:
					NrOfPassengers = (int) p_Value;
					break;

				case 909117378:
					NrOfEntries = (int) p_Value;
					break;

				case 3224499087:
					ProgressTime1Player = (float) p_Value;
					break;

				case 2284771454:
					ShowRadius = (float) p_Value;
					break;

				case 3315533693:
					HideRadius = (float) p_Value;
					break;

				case 2878244914:
					BlinkTime = (float) p_Value;
					break;

				case 1033168991:
					MarkerType = (MapMarkerType) Enum.ToObject(typeof(MapMarkerType), p_Value);
					break;

				case 2554745645:
					VisibleForTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 2899763897:
					OwnerTeam = (TeamId) Enum.ToObject(typeof(TeamId), p_Value);
					break;

				case 2639628855:
					HudIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2125919898:
					VerticalOffset = (float) p_Value;
					break;

				case 3886659069:
					FocusPointRadius = (float) p_Value;
					break;

				case 1381394048:
					InstantFlagReturnRadius = (float) p_Value;
					break;

				case 3002510520:
					Progress = (float) p_Value;
					break;

				case 2861738545:
					ProgressPlayerSpeedUpPercentage = (float) p_Value;
					break;

				case 1098650803:
					TrackedPlayersInRange = (uint) p_Value;
					break;

				case 1572595814:
					TrackingPlayerRange = (float) p_Value;
					break;

				case 1938365101:
					ProgressTime = (float) p_Value;
					break;

				case 1611417039:
					OnlyShowSnapped = (bool) p_Value;
					break;

				case 2755443660:
					FlagControlMarker = (bool) p_Value;
					break;

				case 2139033243:
					ShowProgress = (bool) p_Value;
					break;

				case 163061160:
					UseMarkerTransform = (bool) p_Value;
					break;

				case 4174428017:
					IsVisible = (bool) p_Value;
					break;

				case 2089420457:
					Snap = (bool) p_Value;
					break;

				case 3649779096:
					ShowAirTargetBox = (bool) p_Value;
					break;

				case 1984844159:
					IsFocusPoint = (bool) p_Value;
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
				case 2733408796:
					return BaseTransform;

				case 1288296263:
					return ProgressMinTime;

				case 193466587:
					return Sid;

				case 1911822697:
					return NrOfPassengers;

				case 909117378:
					return NrOfEntries;

				case 3224499087:
					return ProgressTime1Player;

				case 2284771454:
					return ShowRadius;

				case 3315533693:
					return HideRadius;

				case 2878244914:
					return BlinkTime;

				case 1033168991:
					return MarkerType;

				case 2554745645:
					return VisibleForTeam;

				case 2899763897:
					return OwnerTeam;

				case 2639628855:
					return HudIcon;

				case 2125919898:
					return VerticalOffset;

				case 3886659069:
					return FocusPointRadius;

				case 1381394048:
					return InstantFlagReturnRadius;

				case 3002510520:
					return Progress;

				case 2861738545:
					return ProgressPlayerSpeedUpPercentage;

				case 1098650803:
					return TrackedPlayersInRange;

				case 1572595814:
					return TrackingPlayerRange;

				case 1938365101:
					return ProgressTime;

				case 1611417039:
					return OnlyShowSnapped;

				case 2755443660:
					return FlagControlMarker;

				case 2139033243:
					return ShowProgress;

				case 163061160:
					return UseMarkerTransform;

				case 4174428017:
					return IsVisible;

				case 2089420457:
					return Snap;

				case 3649779096:
					return ShowAirTargetBox;

				case 1984844159:
					return IsFocusPoint;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2733408796:
					return typeof(MapMarkerEntityData).GetProperty(nameof(BaseTransform));

				case 1288296263:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ProgressMinTime));

				case 193466587:
					return typeof(MapMarkerEntityData).GetProperty(nameof(Sid));

				case 1911822697:
					return typeof(MapMarkerEntityData).GetProperty(nameof(NrOfPassengers));

				case 909117378:
					return typeof(MapMarkerEntityData).GetProperty(nameof(NrOfEntries));

				case 3224499087:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ProgressTime1Player));

				case 2284771454:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ShowRadius));

				case 3315533693:
					return typeof(MapMarkerEntityData).GetProperty(nameof(HideRadius));

				case 2878244914:
					return typeof(MapMarkerEntityData).GetProperty(nameof(BlinkTime));

				case 1033168991:
					return typeof(MapMarkerEntityData).GetProperty(nameof(MarkerType));

				case 2554745645:
					return typeof(MapMarkerEntityData).GetProperty(nameof(VisibleForTeam));

				case 2899763897:
					return typeof(MapMarkerEntityData).GetProperty(nameof(OwnerTeam));

				case 2639628855:
					return typeof(MapMarkerEntityData).GetProperty(nameof(HudIcon));

				case 2125919898:
					return typeof(MapMarkerEntityData).GetProperty(nameof(VerticalOffset));

				case 3886659069:
					return typeof(MapMarkerEntityData).GetProperty(nameof(FocusPointRadius));

				case 1381394048:
					return typeof(MapMarkerEntityData).GetProperty(nameof(InstantFlagReturnRadius));

				case 3002510520:
					return typeof(MapMarkerEntityData).GetProperty(nameof(Progress));

				case 2861738545:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ProgressPlayerSpeedUpPercentage));

				case 1098650803:
					return typeof(MapMarkerEntityData).GetProperty(nameof(TrackedPlayersInRange));

				case 1572595814:
					return typeof(MapMarkerEntityData).GetProperty(nameof(TrackingPlayerRange));

				case 1938365101:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ProgressTime));

				case 1611417039:
					return typeof(MapMarkerEntityData).GetProperty(nameof(OnlyShowSnapped));

				case 2755443660:
					return typeof(MapMarkerEntityData).GetProperty(nameof(FlagControlMarker));

				case 2139033243:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ShowProgress));

				case 163061160:
					return typeof(MapMarkerEntityData).GetProperty(nameof(UseMarkerTransform));

				case 4174428017:
					return typeof(MapMarkerEntityData).GetProperty(nameof(IsVisible));

				case 2089420457:
					return typeof(MapMarkerEntityData).GetProperty(nameof(Snap));

				case 3649779096:
					return typeof(MapMarkerEntityData).GetProperty(nameof(ShowAirTargetBox));

				case 1984844159:
					return typeof(MapMarkerEntityData).GetProperty(nameof(IsFocusPoint));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
