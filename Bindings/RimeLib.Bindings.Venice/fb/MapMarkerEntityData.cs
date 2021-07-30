///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 16,  Flags: 53, Size: 208)]
	public class MapMarkerEntityData : 
		GameEntityData
	{
		protected Vec3 m_BaseTransform = new Vec3();
		[ContainerField(Name: "BaseTransform", Offset: 96, NameHash: 2733408796, Flags: 53289), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BaseTransform { get { return m_BaseTransform; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(BaseTransform), this, m_BaseTransform, value)) m_BaseTransform = value; } } // 0x60 (96)
		
		protected float m_ProgressMinTime = new float();
		[ContainerField(Name: "ProgressMinTime", Offset: 112, NameHash: 1288296263, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressMinTime { get { return m_ProgressMinTime; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ProgressMinTime), this, m_ProgressMinTime, value)) m_ProgressMinTime = value; } } // 0x70 (112)
		
		protected string m_Sid = string.Empty;
		[ContainerField(Name: "Sid", Offset: 116, NameHash: 193466587, Flags: 16509), LayoutImmutable]
		public string Sid { get { return m_Sid; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(Sid), this, m_Sid, value)) m_Sid = value; } } // 0x74 (116)
		
		protected int m_NrOfPassengers = new int();
		[ContainerField(Name: "NrOfPassengers", Offset: 120, NameHash: 1911822697, Flags: 49405), LayoutImmutable, Blittable]
		public int NrOfPassengers { get { return m_NrOfPassengers; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(NrOfPassengers), this, m_NrOfPassengers, value)) m_NrOfPassengers = value; } } // 0x78 (120)
		
		protected int m_NrOfEntries = new int();
		[ContainerField(Name: "NrOfEntries", Offset: 124, NameHash: 909117378, Flags: 49405), LayoutImmutable, Blittable]
		public int NrOfEntries { get { return m_NrOfEntries; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(NrOfEntries), this, m_NrOfEntries, value)) m_NrOfEntries = value; } } // 0x7C (124)
		
		protected float m_ProgressTime1Player = new float();
		[ContainerField(Name: "ProgressTime1Player", Offset: 128, NameHash: 3224499087, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressTime1Player { get { return m_ProgressTime1Player; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ProgressTime1Player), this, m_ProgressTime1Player, value)) m_ProgressTime1Player = value; } } // 0x80 (128)
		
		protected float m_ShowRadius = new float();
		[ContainerField(Name: "ShowRadius", Offset: 132, NameHash: 2284771454, Flags: 49469), LayoutImmutable, Blittable]
		public float ShowRadius { get { return m_ShowRadius; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ShowRadius), this, m_ShowRadius, value)) m_ShowRadius = value; } } // 0x84 (132)
		
		protected float m_HideRadius = new float();
		[ContainerField(Name: "HideRadius", Offset: 136, NameHash: 3315533693, Flags: 49469), LayoutImmutable, Blittable]
		public float HideRadius { get { return m_HideRadius; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(HideRadius), this, m_HideRadius, value)) m_HideRadius = value; } } // 0x88 (136)
		
		protected float m_BlinkTime = new float();
		[ContainerField(Name: "BlinkTime", Offset: 140, NameHash: 2878244914, Flags: 49469), LayoutImmutable, Blittable]
		public float BlinkTime { get { return m_BlinkTime; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(BlinkTime), this, m_BlinkTime, value)) m_BlinkTime = value; } } // 0x8C (140)
		
		protected MapMarkerType m_MarkerType = new MapMarkerType();
		[ContainerField(Name: "MarkerType", Offset: 144, NameHash: 1033168991, Flags: 137)]
		public MapMarkerType MarkerType { get { return m_MarkerType; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(MarkerType), this, m_MarkerType, value)) m_MarkerType = value; } } // 0x90 (144)
		
		protected TeamId m_VisibleForTeam = new TeamId();
		[ContainerField(Name: "VisibleForTeam", Offset: 148, NameHash: 2554745645, Flags: 137)]
		public TeamId VisibleForTeam { get { return m_VisibleForTeam; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(VisibleForTeam), this, m_VisibleForTeam, value)) m_VisibleForTeam = value; } } // 0x94 (148)
		
		protected TeamId m_OwnerTeam = new TeamId();
		[ContainerField(Name: "OwnerTeam", Offset: 152, NameHash: 2899763897, Flags: 137)]
		public TeamId OwnerTeam { get { return m_OwnerTeam; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(OwnerTeam), this, m_OwnerTeam, value)) m_OwnerTeam = value; } } // 0x98 (152)
		
		protected UIHudIcon m_HudIcon = new UIHudIcon();
		[ContainerField(Name: "HudIcon", Offset: 156, NameHash: 2639628855, Flags: 137)]
		public UIHudIcon HudIcon { get { return m_HudIcon; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(HudIcon), this, m_HudIcon, value)) m_HudIcon = value; } } // 0x9C (156)
		
		protected float m_VerticalOffset = new float();
		[ContainerField(Name: "VerticalOffset", Offset: 160, NameHash: 2125919898, Flags: 49469), LayoutImmutable, Blittable]
		public float VerticalOffset { get { return m_VerticalOffset; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(VerticalOffset), this, m_VerticalOffset, value)) m_VerticalOffset = value; } } // 0xA0 (160)
		
		protected float m_FocusPointRadius = new float();
		[ContainerField(Name: "FocusPointRadius", Offset: 164, NameHash: 3886659069, Flags: 49469), LayoutImmutable, Blittable]
		public float FocusPointRadius { get { return m_FocusPointRadius; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(FocusPointRadius), this, m_FocusPointRadius, value)) m_FocusPointRadius = value; } } // 0xA4 (164)
		
		protected float m_InstantFlagReturnRadius = new float();
		[ContainerField(Name: "InstantFlagReturnRadius", Offset: 168, NameHash: 1381394048, Flags: 49469), LayoutImmutable, Blittable]
		public float InstantFlagReturnRadius { get { return m_InstantFlagReturnRadius; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(InstantFlagReturnRadius), this, m_InstantFlagReturnRadius, value)) m_InstantFlagReturnRadius = value; } } // 0xA8 (168)
		
		protected float m_Progress = new float();
		[ContainerField(Name: "Progress", Offset: 172, NameHash: 3002510520, Flags: 49469), LayoutImmutable, Blittable]
		public float Progress { get { return m_Progress; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(Progress), this, m_Progress, value)) m_Progress = value; } } // 0xAC (172)
		
		protected float m_ProgressPlayerSpeedUpPercentage = new float();
		[ContainerField(Name: "ProgressPlayerSpeedUpPercentage", Offset: 176, NameHash: 2861738545, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressPlayerSpeedUpPercentage { get { return m_ProgressPlayerSpeedUpPercentage; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ProgressPlayerSpeedUpPercentage), this, m_ProgressPlayerSpeedUpPercentage, value)) m_ProgressPlayerSpeedUpPercentage = value; } } // 0xB0 (176)
		
		protected uint m_TrackedPlayersInRange = new uint();
		[ContainerField(Name: "TrackedPlayersInRange", Offset: 180, NameHash: 1098650803, Flags: 49421), LayoutImmutable, Blittable]
		public uint TrackedPlayersInRange { get { return m_TrackedPlayersInRange; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(TrackedPlayersInRange), this, m_TrackedPlayersInRange, value)) m_TrackedPlayersInRange = value; } } // 0xB4 (180)
		
		protected float m_TrackingPlayerRange = new float();
		[ContainerField(Name: "TrackingPlayerRange", Offset: 184, NameHash: 1572595814, Flags: 49469), LayoutImmutable, Blittable]
		public float TrackingPlayerRange { get { return m_TrackingPlayerRange; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(TrackingPlayerRange), this, m_TrackingPlayerRange, value)) m_TrackingPlayerRange = value; } } // 0xB8 (184)
		
		protected float m_ProgressTime = new float();
		[ContainerField(Name: "ProgressTime", Offset: 188, NameHash: 1938365101, Flags: 49469), LayoutImmutable, Blittable]
		public float ProgressTime { get { return m_ProgressTime; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ProgressTime), this, m_ProgressTime, value)) m_ProgressTime = value; } } // 0xBC (188)
		
		protected bool m_OnlyShowSnapped = new bool();
		[ContainerField(Name: "OnlyShowSnapped", Offset: 192, NameHash: 1611417039, Flags: 49325), LayoutImmutable, Blittable]
		public bool OnlyShowSnapped { get { return m_OnlyShowSnapped; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(OnlyShowSnapped), this, m_OnlyShowSnapped, value)) m_OnlyShowSnapped = value; } } // 0xC0 (192)
		
		protected bool m_FlagControlMarker = new bool();
		[ContainerField(Name: "FlagControlMarker", Offset: 193, NameHash: 2755443660, Flags: 49325), LayoutImmutable, Blittable]
		public bool FlagControlMarker { get { return m_FlagControlMarker; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(FlagControlMarker), this, m_FlagControlMarker, value)) m_FlagControlMarker = value; } } // 0xC1 (193)
		
		protected bool m_ShowProgress = new bool();
		[ContainerField(Name: "ShowProgress", Offset: 194, NameHash: 2139033243, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowProgress { get { return m_ShowProgress; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ShowProgress), this, m_ShowProgress, value)) m_ShowProgress = value; } } // 0xC2 (194)
		
		protected bool m_UseMarkerTransform = new bool();
		[ContainerField(Name: "UseMarkerTransform", Offset: 195, NameHash: 163061160, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseMarkerTransform { get { return m_UseMarkerTransform; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(UseMarkerTransform), this, m_UseMarkerTransform, value)) m_UseMarkerTransform = value; } } // 0xC3 (195)
		
		protected bool m_IsVisible = new bool();
		[ContainerField(Name: "IsVisible", Offset: 196, NameHash: 4174428017, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsVisible { get { return m_IsVisible; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(IsVisible), this, m_IsVisible, value)) m_IsVisible = value; } } // 0xC4 (196)
		
		protected bool m_Snap = new bool();
		[ContainerField(Name: "Snap", Offset: 197, NameHash: 2089420457, Flags: 49325), LayoutImmutable, Blittable]
		public bool Snap { get { return m_Snap; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(Snap), this, m_Snap, value)) m_Snap = value; } } // 0xC5 (197)
		
		protected bool m_ShowAirTargetBox = new bool();
		[ContainerField(Name: "ShowAirTargetBox", Offset: 198, NameHash: 3649779096, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowAirTargetBox { get { return m_ShowAirTargetBox; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(ShowAirTargetBox), this, m_ShowAirTargetBox, value)) m_ShowAirTargetBox = value; } } // 0xC6 (198)
		
		protected bool m_IsFocusPoint = new bool();
		[ContainerField(Name: "IsFocusPoint", Offset: 199, NameHash: 1984844159, Flags: 49325), LayoutImmutable, Blittable]
		public bool IsFocusPoint { get { return m_IsFocusPoint; } set { if (OnPropertyChanging("MapMarkerEntityData." + nameof(IsFocusPoint), this, m_IsFocusPoint, value)) m_IsFocusPoint = value; } } // 0xC7 (199)
		
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
