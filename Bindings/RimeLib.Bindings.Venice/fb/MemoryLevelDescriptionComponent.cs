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
	[ContainerType(4, 32)]
	public class MemoryLevelDescriptionComponent : 
		LevelDescriptionComponent
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public int TexturePoolSize { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public int TexturePoolSizeXenon { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int TexturePoolSizePs3 { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int MeshPoolSizePs3Cell { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int MeshPoolSizeXenon { get; set; }

		public static void Deserialize(MemoryLevelDescriptionComponent p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TexturePoolSize = p_Reader.ReadInt32();
			p_Instance.TexturePoolSizeXenon = p_Reader.ReadInt32();
			p_Instance.TexturePoolSizePs3 = p_Reader.ReadInt32();
			p_Instance.MeshPoolSizePs3 = p_Reader.ReadInt32();
			p_Instance.MeshPoolSizePs3Cell = p_Reader.ReadInt32();
			p_Instance.MeshPoolSizeXenon = p_Reader.ReadInt32();
		}

	}
}
