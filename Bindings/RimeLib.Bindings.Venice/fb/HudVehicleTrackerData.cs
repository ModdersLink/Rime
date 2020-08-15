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
	[ContainerType(4)]
	public class HudVehicleTrackerData : 
		UIPartData
	{
		protected EdgePointerData m_EdgePointer = new EdgePointerData();
		[ContainerField(8), ContainerFieldNameHash(1684895101)]
		public EdgePointerData EdgePointer { get { return m_EdgePointer; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EdgePointer), this, m_EdgePointer, value)) m_EdgePointer = value; } } // 0x8 (8)
		
		protected UIHudIcon m_EnemyTrackerIcon = new UIHudIcon();
		[ContainerField(24), ContainerFieldNameHash(1056223948)]
		public UIHudIcon EnemyTrackerIcon { get { return m_EnemyTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EnemyTrackerIcon), this, m_EnemyTrackerIcon, value)) m_EnemyTrackerIcon = value; } } // 0x18 (24)
		
		protected UIHudIcon m_OutsideScreenTrackerIcon = new UIHudIcon();
		[ContainerField(28), ContainerFieldNameHash(1957344303)]
		public UIHudIcon OutsideScreenTrackerIcon { get { return m_OutsideScreenTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(OutsideScreenTrackerIcon), this, m_OutsideScreenTrackerIcon, value)) m_OutsideScreenTrackerIcon = value; } } // 0x1C (28)
		
		protected VehicleTrackerRenderTargetData m_RenderTargetData = new VehicleTrackerRenderTargetData();
		[ContainerField(32), ContainerFieldNameHash(1018667310)]
		public VehicleTrackerRenderTargetData RenderTargetData { get { return m_RenderTargetData; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(RenderTargetData), this, m_RenderTargetData, value)) m_RenderTargetData = value; } } // 0x20 (32)
		
		protected UIHudIcon m_MissileTrackerIcon = new UIHudIcon();
		[ContainerField(56), ContainerFieldNameHash(2269397234)]
		public UIHudIcon MissileTrackerIcon { get { return m_MissileTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MissileTrackerIcon), this, m_MissileTrackerIcon, value)) m_MissileTrackerIcon = value; } } // 0x38 (56)
		
		protected float m_IconSize = new float();
		[ContainerField(60), LayoutImmutable, Blittable, ContainerFieldNameHash(269738667)]
		public float IconSize { get { return m_IconSize; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(IconSize), this, m_IconSize, value)) m_IconSize = value; } } // 0x3C (60)
		
		protected float m_RadarSensitivity = new float();
		[ContainerField(64), LayoutImmutable, Blittable, ContainerFieldNameHash(3600894796)]
		public float RadarSensitivity { get { return m_RadarSensitivity; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(RadarSensitivity), this, m_RadarSensitivity, value)) m_RadarSensitivity = value; } } // 0x40 (64)
		
		protected float m_HeatSensitivity = new float();
		[ContainerField(68), LayoutImmutable, Blittable, ContainerFieldNameHash(1227204656)]
		public float HeatSensitivity { get { return m_HeatSensitivity; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(HeatSensitivity), this, m_HeatSensitivity, value)) m_HeatSensitivity = value; } } // 0x44 (68)
		
		protected UIHudIcon m_FriendlyTrackerIcon = new UIHudIcon();
		[ContainerField(72), ContainerFieldNameHash(4060067057)]
		public UIHudIcon FriendlyTrackerIcon { get { return m_FriendlyTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(FriendlyTrackerIcon), this, m_FriendlyTrackerIcon, value)) m_FriendlyTrackerIcon = value; } } // 0x48 (72)
		
		protected UIHudIcon m_LaserPaintedVehicleTrackerIcon = new UIHudIcon();
		[ContainerField(76), ContainerFieldNameHash(743317508)]
		public UIHudIcon LaserPaintedVehicleTrackerIcon { get { return m_LaserPaintedVehicleTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(LaserPaintedVehicleTrackerIcon), this, m_LaserPaintedVehicleTrackerIcon, value)) m_LaserPaintedVehicleTrackerIcon = value; } } // 0x4C (76)
		
		protected float m_MaxDistance = new float();
		[ContainerField(80), LayoutImmutable, Blittable, ContainerFieldNameHash(3520454034)]
		public float MaxDistance { get { return m_MaxDistance; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MaxDistance), this, m_MaxDistance, value)) m_MaxDistance = value; } } // 0x50 (80)
		
		protected float m_DistanceIconShrinkFactor = new float();
		[ContainerField(84), LayoutImmutable, Blittable, ContainerFieldNameHash(3041637637)]
		public float DistanceIconShrinkFactor { get { return m_DistanceIconShrinkFactor; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(DistanceIconShrinkFactor), this, m_DistanceIconShrinkFactor, value)) m_DistanceIconShrinkFactor = value; } } // 0x54 (84)
		
		protected UIHudIcon m_MissileLockTrackerIcon = new UIHudIcon();
		[ContainerField(88), ContainerFieldNameHash(1153217497)]
		public UIHudIcon MissileLockTrackerIcon { get { return m_MissileLockTrackerIcon; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(MissileLockTrackerIcon), this, m_MissileLockTrackerIcon, value)) m_MissileLockTrackerIcon = value; } } // 0x58 (88)
		
		protected bool m_TrackOnlyUsedVehicles = new bool();
		[ContainerField(92), LayoutImmutable, Blittable, ContainerFieldNameHash(362954258)]
		public bool TrackOnlyUsedVehicles { get { return m_TrackOnlyUsedVehicles; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(TrackOnlyUsedVehicles), this, m_TrackOnlyUsedVehicles, value)) m_TrackOnlyUsedVehicles = value; } } // 0x5C (92)
		
		protected bool m_UseTrackerSignatures = new bool();
		[ContainerField(93), LayoutImmutable, Blittable, ContainerFieldNameHash(4280009289)]
		public bool UseTrackerSignatures { get { return m_UseTrackerSignatures; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(UseTrackerSignatures), this, m_UseTrackerSignatures, value)) m_UseTrackerSignatures = value; } } // 0x5D (93)
		
		protected bool m_EnableEdgePointers = new bool();
		[ContainerField(94), LayoutImmutable, Blittable, ContainerFieldNameHash(1720661007)]
		public bool EnableEdgePointers { get { return m_EnableEdgePointers; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(EnableEdgePointers), this, m_EnableEdgePointers, value)) m_EnableEdgePointers = value; } } // 0x5E (94)
		
		protected bool m_TrackLaserPaintedObjects = new bool();
		[ContainerField(95), LayoutImmutable, Blittable, ContainerFieldNameHash(598207430)]
		public bool TrackLaserPaintedObjects { get { return m_TrackLaserPaintedObjects; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(TrackLaserPaintedObjects), this, m_TrackLaserPaintedObjects, value)) m_TrackLaserPaintedObjects = value; } } // 0x5F (95)
		
		protected bool m_UseCameraComponentTransform = new bool();
		[ContainerField(96), LayoutImmutable, Blittable, ContainerFieldNameHash(3622581372)]
		public bool UseCameraComponentTransform { get { return m_UseCameraComponentTransform; } set { if (OnPropertyChanging("HudVehicleTrackerData." + nameof(UseCameraComponentTransform), this, m_UseCameraComponentTransform, value)) m_UseCameraComponentTransform = value; } } // 0x60 (96)
		
		protected bool m_ShowTracker = new bool();
		[ContainerField(97), LayoutImmutable, Blittable, ContainerFieldNameHash(3997758782)]
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
