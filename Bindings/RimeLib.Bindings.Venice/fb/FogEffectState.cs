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
	[ContainerType(16, 112)]
	public class FogEffectState : 
		DataContainer
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 FogColorCurve { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Curve { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 FogColor { get; set; } = new();

		[ContainerField(64), LayoutImmutable, Blittable]
		public float Start { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float End { get; set; }

		[ContainerField(72), LayoutImmutable, Blittable]
		public float FogColorStart { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float FogColorEnd { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float HeightFogVisibilityRange { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float TransparencyFadeStart { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float TransparencyFadeEnd { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float TransparencyFadeClamp { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public float HeightFogDepth { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float HeightFogFollowCamera { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float HeightFogAltitude { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool HeightFogEnable { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(FogEffectState p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.FogColorCurve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Curve, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.FogColor, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Start = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.End = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FogColorStart = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.FogColorEnd = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HeightFogVisibilityRange = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TransparencyFadeStart = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TransparencyFadeEnd = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.TransparencyFadeClamp = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HeightFogDepth = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HeightFogFollowCamera = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HeightFogAltitude = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.HeightFogEnable = p_Reader.ReadBool();
			p_Reader.Seek(8, SeekOrigin.Current);
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
