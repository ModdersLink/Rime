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
	[ContainerType(4, 36)]
	public class RandomXYZEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float MaxX { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MinX { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxY { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MinY { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxZ { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float MinZ { get; set; }

		public static void Deserialize(RandomXYZEvaluatorData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxX = p_Reader.ReadSingle();
			p_Instance.MinX = p_Reader.ReadSingle();
			p_Instance.MaxY = p_Reader.ReadSingle();
			p_Instance.MinY = p_Reader.ReadSingle();
			p_Instance.MaxZ = p_Reader.ReadSingle();
			p_Instance.MinZ = p_Reader.ReadSingle();
		}

	}
}
