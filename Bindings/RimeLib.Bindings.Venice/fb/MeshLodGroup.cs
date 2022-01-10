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
	[ContainerType(4, 40)]
	public class MeshLodGroup : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Lod1Distance { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Lod2Distance { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Lod3Distance { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Lod4Distance { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Lod5Distance { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ShadowDistance { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float CullScreenArea { get; set; }

		public static void Deserialize(MeshLodGroup p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Lod1Distance = p_Reader.ReadSingle();
			p_Instance.Lod2Distance = p_Reader.ReadSingle();
			p_Instance.Lod3Distance = p_Reader.ReadSingle();
			p_Instance.Lod4Distance = p_Reader.ReadSingle();
			p_Instance.Lod5Distance = p_Reader.ReadSingle();
			p_Instance.ShadowDistance = p_Reader.ReadSingle();
			p_Instance.CullScreenArea = p_Reader.ReadSingle();
		}

	}
}
