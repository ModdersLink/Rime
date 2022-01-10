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
	public class LightProbeVolumeData : 
		SpatialEntityData
	{
		[ContainerField(80), LayoutImmutable, Blittable]
		public uint Xres { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint Yres { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public uint Zres { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float BlendDistance { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public int Priority { get; set; }

		public static void Deserialize(LightProbeVolumeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Xres = p_Reader.ReadUInt32();
			p_Instance.Yres = p_Reader.ReadUInt32();
			p_Instance.Zres = p_Reader.ReadUInt32();
			p_Instance.BlendDistance = p_Reader.ReadSingle();
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
		}

	}
}
