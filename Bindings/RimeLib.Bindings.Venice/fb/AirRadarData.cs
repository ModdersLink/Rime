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
	[ContainerType(16, 128)]
	public class AirRadarData : 
		UIPartData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float RadarRange { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float RadarSensitivity { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float HeatSensitivity { get; set; }

		[ContainerField(20)]
		public UIHudIcon MissileIcon { get; set; } = new();

		[ContainerField(24)]
		public UIHudIcon CenterIcon { get; set; } = new();

		[ContainerField(28)]
		public UIHudIcon FriendlyIcon { get; set; } = new();

		[ContainerField(32)]
		public UIHudIcon EnemyIcon { get; set; } = new();

		[ContainerField(36)]
		public UIHudIcon LaserPaintedIcon { get; set; } = new();

		[ContainerField(40)]
		public UIHudIcon NorthIcon { get; set; } = new();

		[ContainerField(48)]
		public SubScreenData SubScreen { get; set; } = new();

		[ContainerField(112)]
		public UIHudIcon WestIcon { get; set; } = new();

		[ContainerField(116)]
		public UIHudIcon SouthIcon { get; set; } = new();

		[ContainerField(120)]
		public UIHudIcon EastIcon { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public bool TrackLaserPaintedObjects { get; set; }

		[ContainerField(125), LayoutImmutable, Blittable]
		public bool TrackOnlyUsedVehicles { get; set; }

		[ContainerField(126), LayoutImmutable, Blittable]
		public bool UseCameraComponentTransform { get; set; }

		public static void Deserialize(AirRadarData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.RadarRange = p_Reader.ReadSingle();
			p_Instance.RadarSensitivity = p_Reader.ReadSingle();
			p_Instance.HeatSensitivity = p_Reader.ReadSingle();
			p_Instance.MissileIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.CenterIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.FriendlyIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.EnemyIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.LaserPaintedIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Instance.NorthIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.SubScreenData.Deserialize(p_Instance.SubScreen, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.WestIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.SouthIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.EastIcon = (UIHudIcon) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TrackLaserPaintedObjects = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.TrackOnlyUsedVehicles = p_Reader.ReadBool();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.UseCameraComponentTransform = p_Reader.ReadBool();
			p_Reader.Seek(5, SeekOrigin.Current);
		}

	}
}
