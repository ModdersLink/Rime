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
	[ContainerType(4, 44)]
	public class AntPackageAsset : 
		Asset
	{
		[ContainerField(12), LayoutImmutable]
		public string Win32FileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable]
		public string XePs3FileName { get; set; } = string.Empty;

		[ContainerField(20)]
		public AntPackagingType PackagingType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public GUID StreamingGuid { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public uint ChunkSize { get; set; }

		public static void Deserialize(AntPackageAsset p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Win32FileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.XePs3FileName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.PackagingType = (AntPackagingType) p_Reader.ReadInt32();
			p_Instance.StreamingGuid = new GUID(p_Reader);
			p_Instance.ChunkSize = p_Reader.ReadUInt32();
		}

	}
}
