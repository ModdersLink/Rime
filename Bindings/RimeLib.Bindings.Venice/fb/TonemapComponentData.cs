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
	public class TonemapComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 BloomScale { get; set; } = new();

		[ContainerField(112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116)]
		public TonemapMethod TonemapMethod { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float MinExposure { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float MiddleGray { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float ExposureAdjustTime { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float MaxExposure { get; set; }

		[ContainerField(136), LayoutImmutable, Blittable]
		public float ChromostereopsisOffset { get; set; }

		[ContainerField(140), LayoutImmutable, Blittable]
		public float ChromostereopsisScale { get; set; }

		[ContainerField(144), LayoutImmutable, Blittable]
		public bool ChromostereopsisEnable { get; set; }

		public static void Deserialize(TonemapComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.BloomScale, p_Reader, p_Parser);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.TonemapMethod = (TonemapMethod) p_Reader.ReadInt32();
			p_Instance.MinExposure = p_Reader.ReadSingle();
			p_Instance.MiddleGray = p_Reader.ReadSingle();
			p_Instance.ExposureAdjustTime = p_Reader.ReadSingle();
			p_Instance.MaxExposure = p_Reader.ReadSingle();
			p_Instance.ChromostereopsisOffset = p_Reader.ReadSingle();
			p_Instance.ChromostereopsisScale = p_Reader.ReadSingle();
			p_Instance.ChromostereopsisEnable = p_Reader.ReadBool();
			p_Reader.Seek(15, SeekOrigin.Current);
		}

	}
}
