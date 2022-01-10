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
	[ContainerType(16, 224)]
	public class EnlightenComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSkyColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxBackLightColor { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxGroundColor { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TerrainColor { get; set; } = new();

		[ContainerField(160), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyBoxSunLightColor { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float BounceScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float CullDistance { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float SunScale { get; set; }

		[ContainerField(188)]
		public Realm Realm { get; set; } = new();

		[ContainerField(192), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationY { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public float SkyBoxSunLightColorSize { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float SkyBoxBackLightColorSize { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float SkyBoxBackLightRotationX { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public bool SkyBoxEnable { get; set; }

		[ContainerField(209), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(EnlightenComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.SkyBoxSkyColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.SkyBoxBackLightColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.SkyBoxGroundColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.TerrainColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.SkyBoxSunLightColor, p_Reader, p_Parser);
			p_Instance.BounceScale = p_Reader.ReadSingle();
			p_Instance.CullDistance = p_Reader.ReadSingle();
			p_Instance.SunScale = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.SkyBoxBackLightRotationY = p_Reader.ReadSingle();
			p_Instance.SkyBoxSunLightColorSize = p_Reader.ReadSingle();
			p_Instance.SkyBoxBackLightColorSize = p_Reader.ReadSingle();
			p_Instance.SkyBoxBackLightRotationX = p_Reader.ReadSingle();
			p_Instance.SkyBoxEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(14, SeekOrigin.Current);
		}

	}
}
