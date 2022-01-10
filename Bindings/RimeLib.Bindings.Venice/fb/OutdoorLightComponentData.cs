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
	public class OutdoorLightComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SunColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CloudShadowSpeed { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 SkyColor { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 GroundColor { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; }

		[ContainerField(168)]
		public Realm Realm { get; set; } = new();

		[ContainerField(172), LayoutImmutable, Blittable]
		public float SkyLightAngleFactor { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float SunSpecularScale { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float SkyEnvmapShadowScale { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float SunShadowHeightScale { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float CloudShadowCoverage { get; set; }

		[ContainerField(192)]
		public CtrRef<TextureAsset> CloudShadowTexture { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable]
		public float TranslucencyDistortion { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float CloudShadowSize { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float TranslucencyAmbient { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float CloudShadowExponent { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float TranslucencyScale { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float TranslucencyPower { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(221), LayoutImmutable, Blittable]
		public bool CloudShadowEnable { get; set; }

		public static void Deserialize(OutdoorLightComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.SunColor, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.CloudShadowSpeed, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.SkyColor, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.GroundColor, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SunRotationY = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SunRotationX = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SkyLightAngleFactor = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SunSpecularScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SkyEnvmapShadowScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.SunShadowHeightScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CloudShadowCoverage = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CloudShadowTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TranslucencyDistortion = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CloudShadowSize = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TranslucencyAmbient = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CloudShadowExponent = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TranslucencyScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TranslucencyPower = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.CloudShadowEnable = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
