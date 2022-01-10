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
	public class ResourceManagerSettings : 
		SystemSettings
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int CasBundleReadBufferSizeKb { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public int CasBundleDecompressBufferSizeKb { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public int CasBundleDecompressBufferCount { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool BundleProfilingEnable { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool SPUDecompressEnable { get; set; }

		public static void Deserialize(ResourceManagerSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.CasBundleReadBufferSizeKb = p_Reader.ReadInt32();
			p_Instance.CasBundleDecompressBufferSizeKb = p_Reader.ReadInt32();
			p_Instance.CasBundleDecompressBufferCount = p_Reader.ReadInt32();
			p_Instance.BundleProfilingEnable = p_Reader.ReadBool();
			p_Instance.SPUDecompressEnable = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
