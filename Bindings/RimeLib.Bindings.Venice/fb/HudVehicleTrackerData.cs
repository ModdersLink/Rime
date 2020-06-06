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
    [ContainerType(4)]
	public class HudVehicleTrackerData : 
		UIPartData
	{
		[ContainerField(8)]
		public EdgePointerData EdgePointer { get; set; } = new EdgePointerData(); // 0x8 (8)
		
		[ContainerField(24)]
		public UIHudIcon EnemyTrackerIcon { get; set; } = new UIHudIcon(); // 0x18 (24)
		
		[ContainerField(28)]
		public UIHudIcon OutsideScreenTrackerIcon { get; set; } = new UIHudIcon(); // 0x1C (28)
		
		[ContainerField(32)]
		public VehicleTrackerRenderTargetData RenderTargetData { get; set; } = new VehicleTrackerRenderTargetData(); // 0x20 (32)
		
		[ContainerField(56)]
		public UIHudIcon MissileTrackerIcon { get; set; } = new UIHudIcon(); // 0x38 (56)
		
		[ContainerField(60), LayoutImmutable, Blittable]
		public float IconSize { get; set; } // 0x3C (60)
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float RadarSensitivity { get; set; } // 0x40 (64)
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float HeatSensitivity { get; set; } // 0x44 (68)
		
		[ContainerField(72)]
		public UIHudIcon FriendlyTrackerIcon { get; set; } = new UIHudIcon(); // 0x48 (72)
		
		[ContainerField(76)]
		public UIHudIcon LaserPaintedVehicleTrackerIcon { get; set; } = new UIHudIcon(); // 0x4C (76)
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float MaxDistance { get; set; } // 0x50 (80)
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float DistanceIconShrinkFactor { get; set; } // 0x54 (84)
		
		[ContainerField(88)]
		public UIHudIcon MissileLockTrackerIcon { get; set; } = new UIHudIcon(); // 0x58 (88)
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get; set; } // 0x5C (92)
		
		[ContainerField(93), LayoutImmutable, Blittable]
		public bool UseTrackerSignatures { get; set; } // 0x5D (93)
		
		[ContainerField(94), LayoutImmutable, Blittable]
		public bool EnableEdgePointers { get; set; } // 0x5E (94)
		
		[ContainerField(95), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get; set; } // 0x5F (95)
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get; set; } // 0x60 (96)
		
		[ContainerField(97), LayoutImmutable, Blittable]
		public bool ShowTracker { get; set; } // 0x61 (97)
		
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
