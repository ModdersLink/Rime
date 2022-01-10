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
	[ContainerType(4, 24)]
	public class TextureCompressSettings : 
		DataContainer
	{
		[ContainerField(8)]
		public TextureCompressQualityMode ViewMode { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public uint TextureCompressJobPoolSize { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DebugDrawAlphaOverlayScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool DebugDrawEnable { get; set; }

		public static void Deserialize(TextureCompressSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ViewMode = (TextureCompressQualityMode) p_Reader.ReadInt32();
			p_Instance.TextureCompressJobPoolSize = p_Reader.ReadUInt32();
			p_Instance.DebugDrawAlphaOverlayScale = p_Reader.ReadSingle();
			p_Instance.DebugDrawEnable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
