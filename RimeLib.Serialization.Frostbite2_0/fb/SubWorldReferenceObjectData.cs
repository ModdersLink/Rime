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
	[ContainerType(16, 112)]
	public class SubWorldReferenceObjectData :
		ReferenceObjectData
	{
		[ContainerField(96), LayoutImmutable, JsonProperty(Order = 96)]
		public string BundleName { get; set; } = string.Empty;

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<SubWorldInclusionSettings> InclusionSettings { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable, JsonProperty(Order = 104)]
		public bool AutoLoad { get; set; }

		[ContainerField(105), LayoutImmutable, Blittable, JsonProperty(Order = 105)]
		public bool IsWin32SubLevel { get; set; }

		[ContainerField(106), LayoutImmutable, Blittable, JsonProperty(Order = 106)]
		public bool IsXenonSubLevel { get; set; }

		[ContainerField(107), LayoutImmutable, Blittable, JsonProperty(Order = 107)]
		public bool IsPs3SubLevel { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(BundleName));
			p_Writer.Write(p_EbxWriter.WriteImport(InclusionSettings));
			p_Writer.Write(AutoLoad);
			p_Writer.Write(IsWin32SubLevel);
			p_Writer.Write(IsXenonSubLevel);
			p_Writer.Write(IsPs3SubLevel);
			p_Writer.WriteNullBytes(4);
		}
	}
}
