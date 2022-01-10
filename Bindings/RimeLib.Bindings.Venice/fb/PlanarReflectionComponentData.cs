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
	[ContainerType(16, 128)]
	public class PlanarReflectionComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public BlurFilter VerticalBlurFilter { get; set; } = new();

		[ContainerField(100), LayoutImmutable, Blittable]
		public float HorizontalDeviation { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float GroundHeight { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float VerticalDeviation { get; set; }

		[ContainerField(112)]
		public BlurFilter HorizontalBlurFilter { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool SkyRenderEnable { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(PlanarReflectionComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.VerticalBlurFilter = (BlurFilter) p_Reader.ReadInt32();
			p_Instance.HorizontalDeviation = p_Reader.ReadSingle();
			p_Instance.GroundHeight = p_Reader.ReadSingle();
			p_Instance.VerticalDeviation = p_Reader.ReadSingle();
			p_Instance.HorizontalBlurFilter = (BlurFilter) p_Reader.ReadInt32();
			p_Instance.SkyRenderEnable = p_Reader.ReadBool();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
