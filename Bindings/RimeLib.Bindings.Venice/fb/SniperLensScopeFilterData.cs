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
	[ContainerType(16, 160)]
	public class SniperLensScopeFilterData : 
		ScopeFilterData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationStrengths { get; set; } = new();

		[ContainerField(20), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 BlurCenter { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 ChromaticAberrationColor2 { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 RadialBlendDistanceCoefficients { get; set; } = new();

		[ContainerField(72), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement1 { get; set; } = new();

		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ChromaticAberrationDisplacement2 { get; set; } = new();

		[ContainerField(88), LayoutImmutable, Blittable]
		public float BlurScale { get; set; }

		[ContainerField(96)]
		public ColorTintData ColorTintData { get; set; } = new();

		public static void Deserialize(SniperLensScopeFilterData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.ChromaticAberrationStrengths, p_Reader, p_Parser);
			fb.Vec2.Deserialize(p_Instance.BlurCenter, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ChromaticAberrationColor1, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.ChromaticAberrationColor2, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.RadialBlendDistanceCoefficients, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.ChromaticAberrationDisplacement1, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.ChromaticAberrationDisplacement2, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.BlurScale = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
			fb.ColorTintData.Deserialize(p_Instance.ColorTintData, p_Reader, p_Parser);
			p_Reader.Seek(8, SeekOrigin.Current);
		}

	}
}
