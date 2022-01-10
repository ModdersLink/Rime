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
	[ContainerType(16, 304)]
	public class SkyComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayerSunColor { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer2Color { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CloudLayer1Color { get; set; } = new();

		[ContainerField(144)]
		public CtrRef<TextureAsset> SkyGradientTexture { get; set; } = new();

		[ContainerField(148), LayoutImmutable, Blittable]
		public float SunSize { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float BrightnessScale { get; set; }

		[ContainerField(156), LayoutImmutable, Blittable]
		public float SunScale { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float PanoramicUVMaxX { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float PanoramicUVMinY { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float PanoramicUVMaxY { get; set; }

		[ContainerField(172)]
		public Realm Realm { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float PanoramicUVMinX { get; set; }

		[ContainerField(180)]
		public CtrRef<TextureAsset> PanoramicTexture { get; set; } = new();

		[ContainerField(184)]
		public CtrRef<TextureAsset> PanoramicAlphaTexture { get; set; } = new();

		[ContainerField(188), LayoutImmutable, Blittable]
		public float PanoramicTileFactor { get; set; }

		[ContainerField(192)]
		public CtrRef<TextureAsset> CloudLayerMaskTexture { get; set; } = new();

		[ContainerField(196), LayoutImmutable, Blittable]
		public float CloudLayer1Altitude { get; set; }

		[ContainerField(200), LayoutImmutable, Blittable]
		public float CloudLayer1TileFactor { get; set; }

		[ContainerField(204), LayoutImmutable, Blittable]
		public float CloudLayer1Rotation { get; set; }

		[ContainerField(208), LayoutImmutable, Blittable]
		public float CloudLayer1Speed { get; set; }

		[ContainerField(212), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightIntensity { get; set; }

		[ContainerField(216), LayoutImmutable, Blittable]
		public float PanoramicRotation { get; set; }

		[ContainerField(220), LayoutImmutable, Blittable]
		public float CloudLayer1AmbientLightIntensity { get; set; }

		[ContainerField(224), LayoutImmutable, Blittable]
		public float CloudLayer1SunLightPower { get; set; }

		[ContainerField(228), LayoutImmutable, Blittable]
		public float CloudLayer1AlphaMul { get; set; }

		[ContainerField(232)]
		public CtrRef<TextureAsset> CloudLayer1Texture { get; set; } = new();

		[ContainerField(236), LayoutImmutable, Blittable]
		public float CloudLayer2Altitude { get; set; }

		[ContainerField(240), LayoutImmutable, Blittable]
		public float CloudLayer2TileFactor { get; set; }

		[ContainerField(244), LayoutImmutable, Blittable]
		public float CloudLayer2Rotation { get; set; }

		[ContainerField(248), LayoutImmutable, Blittable]
		public float CloudLayer2Speed { get; set; }

		[ContainerField(252), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightIntensity { get; set; }

		[ContainerField(256), LayoutImmutable, Blittable]
		public float CloudLayer2SunLightPower { get; set; }

		[ContainerField(260), LayoutImmutable, Blittable]
		public float CloudLayer2AmbientLightIntensity { get; set; }

		[ContainerField(264), LayoutImmutable, Blittable]
		public float StaticEnvmapScale { get; set; }

		[ContainerField(268), LayoutImmutable, Blittable]
		public float CloudLayer2AlphaMul { get; set; }

		[ContainerField(272)]
		public CtrRef<TextureAsset> CloudLayer2Texture { get; set; } = new();

		[ContainerField(276)]
		public CtrRef<TextureAsset> StaticEnvmapTexture { get; set; } = new();

		[ContainerField(280), LayoutImmutable, Blittable]
		public float SkyVisibilityExponent { get; set; }

		[ContainerField(284), LayoutImmutable, Blittable]
		public float SkyEnvmap8BitTexScale { get; set; }

		[ContainerField(288)]
		public CtrRef<TextureAsset> CustomEnvmapTexture { get; set; } = new();

		[ContainerField(292), LayoutImmutable, Blittable]
		public float CustomEnvmapScale { get; set; }

		[ContainerField(296), LayoutImmutable, Blittable]
		public float CustomEnvmapAmbient { get; set; }

		[ContainerField(300), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(SkyComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.CloudLayerSunColor, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.CloudLayer2Color, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.CloudLayer1Color, p_Reader, p_Parser);
			p_Instance.SkyGradientTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SunSize = p_Reader.ReadSingle();
			p_Instance.BrightnessScale = p_Reader.ReadSingle();
			p_Instance.SunScale = p_Reader.ReadSingle();
			p_Instance.PanoramicUVMaxX = p_Reader.ReadSingle();
			p_Instance.PanoramicUVMinY = p_Reader.ReadSingle();
			p_Instance.PanoramicUVMaxY = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.PanoramicUVMinX = p_Reader.ReadSingle();
			p_Instance.PanoramicTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PanoramicAlphaTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.PanoramicTileFactor = p_Reader.ReadSingle();
			p_Instance.CloudLayerMaskTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CloudLayer1Altitude = p_Reader.ReadSingle();
			p_Instance.CloudLayer1TileFactor = p_Reader.ReadSingle();
			p_Instance.CloudLayer1Rotation = p_Reader.ReadSingle();
			p_Instance.CloudLayer1Speed = p_Reader.ReadSingle();
			p_Instance.CloudLayer1SunLightIntensity = p_Reader.ReadSingle();
			p_Instance.PanoramicRotation = p_Reader.ReadSingle();
			p_Instance.CloudLayer1AmbientLightIntensity = p_Reader.ReadSingle();
			p_Instance.CloudLayer1SunLightPower = p_Reader.ReadSingle();
			p_Instance.CloudLayer1AlphaMul = p_Reader.ReadSingle();
			p_Instance.CloudLayer1Texture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CloudLayer2Altitude = p_Reader.ReadSingle();
			p_Instance.CloudLayer2TileFactor = p_Reader.ReadSingle();
			p_Instance.CloudLayer2Rotation = p_Reader.ReadSingle();
			p_Instance.CloudLayer2Speed = p_Reader.ReadSingle();
			p_Instance.CloudLayer2SunLightIntensity = p_Reader.ReadSingle();
			p_Instance.CloudLayer2SunLightPower = p_Reader.ReadSingle();
			p_Instance.CloudLayer2AmbientLightIntensity = p_Reader.ReadSingle();
			p_Instance.StaticEnvmapScale = p_Reader.ReadSingle();
			p_Instance.CloudLayer2AlphaMul = p_Reader.ReadSingle();
			p_Instance.CloudLayer2Texture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StaticEnvmapTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.SkyVisibilityExponent = p_Reader.ReadSingle();
			p_Instance.SkyEnvmap8BitTexScale = p_Reader.ReadSingle();
			p_Instance.CustomEnvmapTexture.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.CustomEnvmapScale = p_Reader.ReadSingle();
			p_Instance.CustomEnvmapAmbient = p_Reader.ReadSingle();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
