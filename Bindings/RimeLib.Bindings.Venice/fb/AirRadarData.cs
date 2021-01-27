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
	[ContainerType(Alignment: 16,  Flags: 53, Size: 128)]
	public class AirRadarData : 
		UIPartData
	{
		protected float m_RadarRange = new float();
		[ContainerField(Name: "RadarRange", Offset: 8, NameHash: 2631022494, Flags: 49469), LayoutImmutable, Blittable]
		public float RadarRange { get { return m_RadarRange; } set { if (OnPropertyChanging("AirRadarData." + nameof(RadarRange), this, m_RadarRange, value)) m_RadarRange = value; } } // 0x8 (8)
		
		protected float m_RadarSensitivity = new float();
		[ContainerField(Name: "RadarSensitivity", Offset: 12, NameHash: 3600894796, Flags: 49469), LayoutImmutable, Blittable]
		public float RadarSensitivity { get { return m_RadarSensitivity; } set { if (OnPropertyChanging("AirRadarData." + nameof(RadarSensitivity), this, m_RadarSensitivity, value)) m_RadarSensitivity = value; } } // 0xC (12)
		
		protected float m_HeatSensitivity = new float();
		[ContainerField(Name: "HeatSensitivity", Offset: 16, NameHash: 1227204656, Flags: 49469), LayoutImmutable, Blittable]
		public float HeatSensitivity { get { return m_HeatSensitivity; } set { if (OnPropertyChanging("AirRadarData." + nameof(HeatSensitivity), this, m_HeatSensitivity, value)) m_HeatSensitivity = value; } } // 0x10 (16)
		
		protected UIHudIcon m_MissileIcon = new UIHudIcon();
		[ContainerField(Name: "MissileIcon", Offset: 20, NameHash: 2092113546, Flags: 137)]
		public UIHudIcon MissileIcon { get { return m_MissileIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(MissileIcon), this, m_MissileIcon, value)) m_MissileIcon = value; } } // 0x14 (20)
		
		protected UIHudIcon m_CenterIcon = new UIHudIcon();
		[ContainerField(Name: "CenterIcon", Offset: 24, NameHash: 1030044421, Flags: 137)]
		public UIHudIcon CenterIcon { get { return m_CenterIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(CenterIcon), this, m_CenterIcon, value)) m_CenterIcon = value; } } // 0x18 (24)
		
		protected UIHudIcon m_FriendlyIcon = new UIHudIcon();
		[ContainerField(Name: "FriendlyIcon", Offset: 28, NameHash: 3884638505, Flags: 137)]
		public UIHudIcon FriendlyIcon { get { return m_FriendlyIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(FriendlyIcon), this, m_FriendlyIcon, value)) m_FriendlyIcon = value; } } // 0x1C (28)
		
		protected UIHudIcon m_EnemyIcon = new UIHudIcon();
		[ContainerField(Name: "EnemyIcon", Offset: 32, NameHash: 1877581364, Flags: 137)]
		public UIHudIcon EnemyIcon { get { return m_EnemyIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(EnemyIcon), this, m_EnemyIcon, value)) m_EnemyIcon = value; } } // 0x20 (32)
		
		protected UIHudIcon m_LaserPaintedIcon = new UIHudIcon();
		[ContainerField(Name: "LaserPaintedIcon", Offset: 36, NameHash: 1028218756, Flags: 137)]
		public UIHudIcon LaserPaintedIcon { get { return m_LaserPaintedIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(LaserPaintedIcon), this, m_LaserPaintedIcon, value)) m_LaserPaintedIcon = value; } } // 0x24 (36)
		
		protected UIHudIcon m_NorthIcon = new UIHudIcon();
		[ContainerField(Name: "NorthIcon", Offset: 40, NameHash: 2335670113, Flags: 137)]
		public UIHudIcon NorthIcon { get { return m_NorthIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(NorthIcon), this, m_NorthIcon, value)) m_NorthIcon = value; } } // 0x28 (40)
		
		protected SubScreenData m_SubScreen = new SubScreenData();
		[ContainerField(Name: "SubScreen", Offset: 48, NameHash: 1572076333, Flags: 41)]
		public SubScreenData SubScreen { get { return m_SubScreen; } set { if (OnPropertyChanging("AirRadarData." + nameof(SubScreen), this, m_SubScreen, value)) m_SubScreen = value; } } // 0x30 (48)
		
		protected UIHudIcon m_WestIcon = new UIHudIcon();
		[ContainerField(Name: "WestIcon", Offset: 112, NameHash: 3367888667, Flags: 137)]
		public UIHudIcon WestIcon { get { return m_WestIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(WestIcon), this, m_WestIcon, value)) m_WestIcon = value; } } // 0x70 (112)
		
		protected UIHudIcon m_SouthIcon = new UIHudIcon();
		[ContainerField(Name: "SouthIcon", Offset: 116, NameHash: 1219110587, Flags: 137)]
		public UIHudIcon SouthIcon { get { return m_SouthIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(SouthIcon), this, m_SouthIcon, value)) m_SouthIcon = value; } } // 0x74 (116)
		
		protected UIHudIcon m_EastIcon = new UIHudIcon();
		[ContainerField(Name: "EastIcon", Offset: 120, NameHash: 3597079885, Flags: 137)]
		public UIHudIcon EastIcon { get { return m_EastIcon; } set { if (OnPropertyChanging("AirRadarData." + nameof(EastIcon), this, m_EastIcon, value)) m_EastIcon = value; } } // 0x78 (120)
		
		protected bool m_TrackLaserPaintedObjects = new bool();
		[ContainerField(Name: "TrackLaserPaintedObjects", Offset: 124, NameHash: 598207430, Flags: 49325), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get { return m_TrackLaserPaintedObjects; } set { if (OnPropertyChanging("AirRadarData." + nameof(TrackLaserPaintedObjects), this, m_TrackLaserPaintedObjects, value)) m_TrackLaserPaintedObjects = value; } } // 0x7C (124)
		
		protected bool m_TrackOnlyUsedVehicles = new bool();
		[ContainerField(Name: "TrackOnlyUsedVehicles", Offset: 125, NameHash: 362954258, Flags: 49325), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get { return m_TrackOnlyUsedVehicles; } set { if (OnPropertyChanging("AirRadarData." + nameof(TrackOnlyUsedVehicles), this, m_TrackOnlyUsedVehicles, value)) m_TrackOnlyUsedVehicles = value; } } // 0x7D (125)
		
		protected bool m_UseCameraComponentTransform = new bool();
		[ContainerField(Name: "UseCameraComponentTransform", Offset: 126, NameHash: 3622581372, Flags: 49325), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get { return m_UseCameraComponentTransform; } set { if (OnPropertyChanging("AirRadarData." + nameof(UseCameraComponentTransform), this, m_UseCameraComponentTransform, value)) m_UseCameraComponentTransform = value; } } // 0x7E (126)
		
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
