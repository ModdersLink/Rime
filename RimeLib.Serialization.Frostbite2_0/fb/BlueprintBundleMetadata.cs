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
	[ContainerType(4, 20)]
	public class BlueprintBundleMetadata :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, JsonProperty(Order = 8)]
		public string BundlePathName { get; set; } = string.Empty;

		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string BundleName { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string BlueprintName { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(BundlePathName));
			p_Writer.Write(p_EbxWriter.WriteString(BundleName));
			p_Writer.Write(p_EbxWriter.WriteString(BlueprintName));
		}
	}
}
