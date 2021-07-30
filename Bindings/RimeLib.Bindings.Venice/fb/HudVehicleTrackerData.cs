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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 100)]
	public class HudVehicleTrackerData : 
		UIPartData
	{
		protected EdgePointerData m_EdgePointer = new EdgePointerData();
		[ContainerField(Name: "EdgePointer", Offset: 8, NameHash: 1684895101, Flags: 41)]
		public EdgePointerData EdgePointer { get { return m_EdgePointer; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EdgePointer), this, m_EdgePointer, value)) m_EdgePointer = value; } } // 0x8 (8)
		
		protected UIHudIcon m_EnemyTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "EnemyTrackerIcon", Offset: 24, NameHash: 1056223948, Flags: 137)]
		public UIHudIcon EnemyTrackerIcon { get { return m_EnemyTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EnemyTrackerIcon), this, m_EnemyTrackerIcon, value)) m_EnemyTrackerIcon = value; } } // 0x18 (24)
		
		protected UIHudIcon m_OutsideScreenTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "OutsideScreenTrackerIcon", Offset: 28, NameHash: 1957344303, Flags: 137)]
		public UIHudIcon OutsideScreenTrackerIcon { get { return m_OutsideScreenTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(OutsideScreenTrackerIcon), this, m_OutsideScreenTrackerIcon, value)) m_OutsideScreenTrackerIcon = value; } } // 0x1C (28)
		
		protected VehicleTrackerRenderTargetData m_RenderTargetData = new VehicleTrackerRenderTargetData();
		[ContainerField(Name: "RenderTargetData", Offset: 32, NameHash: 1018667310, Flags: 41)]
		public VehicleTrackerRenderTargetData RenderTargetData { get { return m_RenderTargetData; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(RenderTargetData), this, m_RenderTargetData, value)) m_RenderTargetData = value; } } // 0x20 (32)
		
		protected UIHudIcon m_MissileTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "MissileTrackerIcon", Offset: 56, NameHash: 2269397234, Flags: 137)]
		public UIHudIcon MissileTrackerIcon { get { return m_MissileTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MissileTrackerIcon), this, m_MissileTrackerIcon, value)) m_MissileTrackerIcon = value; } } // 0x38 (56)
		
		protected float m_IconSize = new float();
		[ContainerField(Name: "IconSize", Offset: 60, NameHash: 269738667, Flags: 49469), LayoutImmutable, Blittable]
		public float IconSize { get { return m_IconSize; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(IconSize), this, m_IconSize, value)) m_IconSize = value; } } // 0x3C (60)
		
		protected float m_RadarSensitivity = new float();
		[ContainerField(Name: "RadarSensitivity", Offset: 64, NameHash: 3600894796, Flags: 49469), LayoutImmutable, Blittable]
		public float RadarSensitivity { get { return m_RadarSensitivity; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(RadarSensitivity), this, m_RadarSensitivity, value)) m_RadarSensitivity = value; } } // 0x40 (64)
		
		protected float m_HeatSensitivity = new float();
		[ContainerField(Name: "HeatSensitivity", Offset: 68, NameHash: 1227204656, Flags: 49469), LayoutImmutable, Blittable]
		public float HeatSensitivity { get { return m_HeatSensitivity; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(HeatSensitivity), this, m_HeatSensitivity, value)) m_HeatSensitivity = value; } } // 0x44 (68)
		
		protected UIHudIcon m_FriendlyTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "FriendlyTrackerIcon", Offset: 72, NameHash: 4060067057, Flags: 137)]
		public UIHudIcon FriendlyTrackerIcon { get { return m_FriendlyTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(FriendlyTrackerIcon), this, m_FriendlyTrackerIcon, value)) m_FriendlyTrackerIcon = value; } } // 0x48 (72)
		
		protected UIHudIcon m_LaserPaintedVehicleTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "LaserPaintedVehicleTrackerIcon", Offset: 76, NameHash: 743317508, Flags: 137)]
		public UIHudIcon LaserPaintedVehicleTrackerIcon { get { return m_LaserPaintedVehicleTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(LaserPaintedVehicleTrackerIcon), this, m_LaserPaintedVehicleTrackerIcon, value)) m_LaserPaintedVehicleTrackerIcon = value; } } // 0x4C (76)
		
		protected float m_MaxDistance = new float();
		[ContainerField(Name: "MaxDistance", Offset: 80, NameHash: 3520454034, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x50 (80)
		
		protected float m_DistanceIconShrinkFactor = new float();
		[ContainerField(Name: "DistanceIconShrinkFactor", Offset: 84, NameHash: 3041637637, Flags: 49469), LayoutImmutable, Blittable]
		public float DistanceIconShrinkFactor { get { return m_DistanceIconShrinkFactor; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(DistanceIconShrinkFactor), this, m_DistanceIconShrinkFactor, value)) m_DistanceIconShrinkFactor = value; } } // 0x54 (84)
		
		protected UIHudIcon m_MissileLockTrackerIcon = new UIHudIcon();
		[ContainerField(Name: "MissileLockTrackerIcon", Offset: 88, NameHash: 1153217497, Flags: 137)]
		public UIHudIcon MissileLockTrackerIcon { get { return m_MissileLockTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MissileLockTrackerIcon), this, m_MissileLockTrackerIcon, value)) m_MissileLockTrackerIcon = value; } } // 0x58 (88)
		
		protected bool m_TrackOnlyUsedVehicles = new bool();
		[ContainerField(Name: "TrackOnlyUsedVehicles", Offset: 92, NameHash: 362954258, Flags: 49325), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get { return m_TrackOnlyUsedVehicles; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(TrackOnlyUsedVehicles), this, m_TrackOnlyUsedVehicles, value)) m_TrackOnlyUsedVehicles = value; } } // 0x5C (92)
		
		protected bool m_UseTrackerSignatures = new bool();
		[ContainerField(Name: "UseTrackerSignatures", Offset: 93, NameHash: 4280009289, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseTrackerSignatures { get { return m_UseTrackerSignatures; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(UseTrackerSignatures), this, m_UseTrackerSignatures, value)) m_UseTrackerSignatures = value; } } // 0x5D (93)
		
		protected bool m_EnableEdgePointers = new bool();
		[ContainerField(Name: "EnableEdgePointers", Offset: 94, NameHash: 1720661007, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableEdgePointers { get { return m_EnableEdgePointers; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EnableEdgePointers), this, m_EnableEdgePointers, value)) m_EnableEdgePointers = value; } } // 0x5E (94)
		
		protected bool m_TrackLaserPaintedObjects = new bool();
		[ContainerField(Name: "TrackLaserPaintedObjects", Offset: 95, NameHash: 598207430, Flags: 49325), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get { return m_TrackLaserPaintedObjects; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(TrackLaserPaintedObjects), this, m_TrackLaserPaintedObjects, value)) m_TrackLaserPaintedObjects = value; } } // 0x5F (95)
		
		protected bool m_UseCameraComponentTransform = new bool();
		[ContainerField(Name: "UseCameraComponentTransform", Offset: 96, NameHash: 3622581372, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get { return m_UseCameraComponentTransform; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(UseCameraComponentTransform), this, m_UseCameraComponentTransform, value)) m_UseCameraComponentTransform = value; } } // 0x60 (96)
		
		protected bool m_ShowTracker = new bool();
		[ContainerField(Name: "ShowTracker", Offset: 97, NameHash: 3997758782, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShowTracker { get { return m_ShowTracker; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(ShowTracker), this, m_ShowTracker, value)) m_ShowTracker = value; } } // 0x61 (97)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 1684895101:
					EdgePointer = (EdgePointerData) p_Value;
					break;

				case 1056223948:
					EnemyTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1957344303:
					OutsideScreenTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1018667310:
					RenderTargetData = (VehicleTrackerRenderTargetData) p_Value;
					break;

				case 2269397234:
					MissileTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 269738667:
					IconSize = (float) p_Value;
					break;

				case 3600894796:
					RadarSensitivity = (float) p_Value;
					break;

				case 1227204656:
					HeatSensitivity = (float) p_Value;
					break;

				case 4060067057:
					FriendlyTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 743317508:
					LaserPaintedVehicleTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 3520454034:
					MaxDistance = (float) p_Value;
					break;

				case 3041637637:
					DistanceIconShrinkFactor = (float) p_Value;
					break;

				case 1153217497:
					MissileLockTrackerIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 362954258:
					TrackOnlyUsedVehicles = (bool) p_Value;
					break;

				case 4280009289:
					UseTrackerSignatures = (bool) p_Value;
					break;

				case 1720661007:
					EnableEdgePointers = (bool) p_Value;
					break;

				case 598207430:
					TrackLaserPaintedObjects = (bool) p_Value;
					break;

				case 3622581372:
					UseCameraComponentTransform = (bool) p_Value;
					break;

				case 3997758782:
					ShowTracker = (bool) p_Value;
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
				case 1684895101:
					return EdgePointer;

				case 1056223948:
					return EnemyTrackerIcon;

				case 1957344303:
					return OutsideScreenTrackerIcon;

				case 1018667310:
					return RenderTargetData;

				case 2269397234:
					return MissileTrackerIcon;

				case 269738667:
					return IconSize;

				case 3600894796:
					return RadarSensitivity;

				case 1227204656:
					return HeatSensitivity;

				case 4060067057:
					return FriendlyTrackerIcon;

				case 743317508:
					return LaserPaintedVehicleTrackerIcon;

				case 3520454034:
					return MaxDistance;

				case 3041637637:
					return DistanceIconShrinkFactor;

				case 1153217497:
					return MissileLockTrackerIcon;

				case 362954258:
					return TrackOnlyUsedVehicles;

				case 4280009289:
					return UseTrackerSignatures;

				case 1720661007:
					return EnableEdgePointers;

				case 598207430:
					return TrackLaserPaintedObjects;

				case 3622581372:
					return UseCameraComponentTransform;

				case 3997758782:
					return ShowTracker;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 1684895101:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(EdgePointer));

				case 1056223948:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(EnemyTrackerIcon));

				case 1957344303:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(OutsideScreenTrackerIcon));

				case 1018667310:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(RenderTargetData));

				case 2269397234:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(MissileTrackerIcon));

				case 269738667:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(IconSize));

				case 3600894796:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(RadarSensitivity));

				case 1227204656:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(HeatSensitivity));

				case 4060067057:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(FriendlyTrackerIcon));

				case 743317508:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(LaserPaintedVehicleTrackerIcon));

				case 3520454034:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(MaxDistance));

				case 3041637637:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(DistanceIconShrinkFactor));

				case 1153217497:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(MissileLockTrackerIcon));

				case 362954258:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(TrackOnlyUsedVehicles));

				case 4280009289:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(UseTrackerSignatures));

				case 1720661007:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(EnableEdgePointers));

				case 598207430:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(TrackLaserPaintedObjects));

				case 3622581372:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(UseCameraComponentTransform));

				case 3997758782:
					return typeof(HudVehicleTrackerData).GetProperty(nameof(ShowTracker));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
