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
	[ContainerType(4, 28)]
	public class TurretControlConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SearchLookSpeed { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float SlowLookSpeed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float NormalLookSpeed { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FastLookSpeed { get; set; }

		public static void Deserialize(TurretControlConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SearchLookSpeed = p_Reader.ReadSingle();
			p_Instance.SlowLookSpeed = p_Reader.ReadSingle();
			p_Instance.NormalLookSpeed = p_Reader.ReadSingle();
			p_Instance.FastLookSpeed = p_Reader.ReadSingle();
		}

	}
}
