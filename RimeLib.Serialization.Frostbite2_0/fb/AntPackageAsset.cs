///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 44)]
	public class AntPackageAsset :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string Win32FileName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string XePs3FileName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public AntPackagingType PackagingType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public GUID StreamingGuid { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public uint ChunkSize { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Win32FileName));
			p_Writer.Write(p_EbxWriter.WriteString(XePs3FileName));
			p_Writer.Write((int) PackagingType);
			StreamingGuid.Serialize(p_Writer);
			p_Writer.Write(ChunkSize);
		}
	}
}
