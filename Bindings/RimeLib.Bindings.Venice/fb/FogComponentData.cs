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
	[ContainerType(16, 208)]
	public class FogComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Curve { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FogColorCurve { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FogColor { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float FogColorStart { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public float FogDistanceMultiplier { get; set; }

		[ContainerField(152)]
		public Realm Realm { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable]
		public float End { get; set; }

		[ContainerField(160), LayoutImmutable, Blittable]
		public float TransparencyFadeStart { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float Start { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float TransparencyFadeEnd { get; set; }

		[ContainerField(172), LayoutImmutable, Blittable]
		public float FogColorEnd { get; set; }

		[ContainerField(176), LayoutImmutable, Blittable]
		public float TransparencyFadeClamp { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float HeightFogVisibilityRange { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float HeightFogAltitude { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float HeightFogDepth { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float HeightFogFollowCamera { get; set; }

		[ContainerField(196), LayoutImmutable, Blittable]
		public bool FogGradientEnable { get; set; }

		[ContainerField(197), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		[ContainerField(198), LayoutImmutable, Blittable]
		public bool HeightFogEnable { get; set; }

		[ContainerField(199), LayoutImmutable, Blittable]
		public bool FogColorEnable { get; set; }

		public static void Deserialize(FogComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec4.Deserialize(p_Instance.Curve, p_Reader, p_Parser);
			fb.Vec4.Deserialize(p_Instance.FogColorCurve, p_Reader, p_Parser);
			fb.Vec3.Deserialize(p_Instance.FogColor, p_Reader, p_Parser);
			p_Instance.FogColorStart = p_Reader.ReadSingle();
			p_Instance.FogDistanceMultiplier = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.End = p_Reader.ReadSingle();
			p_Instance.TransparencyFadeStart = p_Reader.ReadSingle();
			p_Instance.Start = p_Reader.ReadSingle();
			p_Instance.TransparencyFadeEnd = p_Reader.ReadSingle();
			p_Instance.FogColorEnd = p_Reader.ReadSingle();
			p_Instance.TransparencyFadeClamp = p_Reader.ReadSingle();
			p_Instance.HeightFogVisibilityRange = p_Reader.ReadSingle();
			p_Instance.HeightFogAltitude = p_Reader.ReadSingle();
			p_Instance.HeightFogDepth = p_Reader.ReadSingle();
			p_Instance.HeightFogFollowCamera = p_Reader.ReadSingle();
			p_Instance.FogGradientEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Instance.HeightFogEnable = p_Reader.ReadBool();
			p_Instance.FogColorEnable = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
