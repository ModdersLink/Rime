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
	public class AirRadarData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RadarRange { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float RadarSensitivity { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float HeatSensitivity { get; set; } // 0x10 (16)
		
		[ContainerField(20)]
		public UIHudIcon MissileIcon { get; set; } = new UIHudIcon(); // 0x14 (20)
		
		[ContainerField(24)]
		public UIHudIcon CenterIcon { get; set; } = new UIHudIcon(); // 0x18 (24)
		
		[ContainerField(28)]
		public UIHudIcon FriendlyIcon { get; set; } = new UIHudIcon(); // 0x1C (28)
		
		[ContainerField(32)]
		public UIHudIcon EnemyIcon { get; set; } = new UIHudIcon(); // 0x20 (32)
		
		[ContainerField(36)]
		public UIHudIcon LaserPaintedIcon { get; set; } = new UIHudIcon(); // 0x24 (36)
		
		[ContainerField(40)]
		public UIHudIcon NorthIcon { get; set; } = new UIHudIcon(); // 0x28 (40)
		
		[ContainerField(48)]
		public SubScreenData SubScreen { get; set; } = new SubScreenData(); // 0x30 (48)
		
		[ContainerField(112)]
		public UIHudIcon WestIcon { get; set; } = new UIHudIcon(); // 0x70 (112)
		
		[ContainerField(116)]
		public UIHudIcon SouthIcon { get; set; } = new UIHudIcon(); // 0x74 (116)
		
		[ContainerField(120)]
		public UIHudIcon EastIcon { get; set; } = new UIHudIcon(); // 0x78 (120)
		
		[ContainerField(124), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get; set; } // 0x7C (124)
		
		[ContainerField(125), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get; set; } // 0x7D (125)
		
		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get; set; } // 0x7E (126)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2631022494:
					RadarRange = (float) p_Value;
					break;

				case 3600894796:
					RadarSensitivity = (float) p_Value;
					break;

				case 1227204656:
					HeatSensitivity = (float) p_Value;
					break;

				case 2092113546:
					MissileIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1030044421:
					CenterIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 3884638505:
					FriendlyIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1877581364:
					EnemyIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1028218756:
					LaserPaintedIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 2335670113:
					NorthIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1572076333:
					SubScreen = (SubScreenData) p_Value;
					break;

				case 3367888667:
					WestIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 1219110587:
					SouthIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 3597079885:
					EastIcon = (UIHudIcon) Enum.ToObject(typeof(UIHudIcon), p_Value);
					break;

				case 598207430:
					TrackLaserPaintedObjects = (bool) p_Value;
					break;

				case 362954258:
					TrackOnlyUsedVehicles = (bool) p_Value;
					break;

				case 3622581372:
					UseCameraComponentTransform = (bool) p_Value;
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
				case 2631022494:
					return RadarRange;

				case 3600894796:
					return RadarSensitivity;

				case 1227204656:
					return HeatSensitivity;

				case 2092113546:
					return MissileIcon;

				case 1030044421:
					return CenterIcon;

				case 3884638505:
					return FriendlyIcon;

				case 1877581364:
					return EnemyIcon;

				case 1028218756:
					return LaserPaintedIcon;

				case 2335670113:
					return NorthIcon;

				case 1572076333:
					return SubScreen;

				case 3367888667:
					return WestIcon;

				case 1219110587:
					return SouthIcon;

				case 3597079885:
					return EastIcon;

				case 598207430:
					return TrackLaserPaintedObjects;

				case 362954258:
					return TrackOnlyUsedVehicles;

				case 3622581372:
					return UseCameraComponentTransform;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2631022494:
					return typeof(AirRadarData).GetProperty(nameof(RadarRange));

				case 3600894796:
					return typeof(AirRadarData).GetProperty(nameof(RadarSensitivity));

				case 1227204656:
					return typeof(AirRadarData).GetProperty(nameof(HeatSensitivity));

				case 2092113546:
					return typeof(AirRadarData).GetProperty(nameof(MissileIcon));

				case 1030044421:
					return typeof(AirRadarData).GetProperty(nameof(CenterIcon));

				case 3884638505:
					return typeof(AirRadarData).GetProperty(nameof(FriendlyIcon));

				case 1877581364:
					return typeof(AirRadarData).GetProperty(nameof(EnemyIcon));

				case 1028218756:
					return typeof(AirRadarData).GetProperty(nameof(LaserPaintedIcon));

				case 2335670113:
					return typeof(AirRadarData).GetProperty(nameof(NorthIcon));

				case 1572076333:
					return typeof(AirRadarData).GetProperty(nameof(SubScreen));

				case 3367888667:
					return typeof(AirRadarData).GetProperty(nameof(WestIcon));

				case 1219110587:
					return typeof(AirRadarData).GetProperty(nameof(SouthIcon));

				case 3597079885:
					return typeof(AirRadarData).GetProperty(nameof(EastIcon));

				case 598207430:
					return typeof(AirRadarData).GetProperty(nameof(TrackLaserPaintedObjects));

				case 362954258:
					return typeof(AirRadarData).GetProperty(nameof(TrackOnlyUsedVehicles));

				case 3622581372:
					return typeof(AirRadarData).GetProperty(nameof(UseCameraComponentTransform));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
