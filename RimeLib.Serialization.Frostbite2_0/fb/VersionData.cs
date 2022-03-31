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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 32)]
	public class VersionData :
		Asset
	{
		[ContainerField(12), LayoutImmutable, JsonProperty(Order = 12)]
		public string disclaimer { get; set; } = string.Empty;

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public int Version { get; set; }

		[ContainerField(20), LayoutImmutable, JsonProperty(Order = 20)]
		public string DateTime { get; set; } = string.Empty;

		[ContainerField(24), LayoutImmutable, JsonProperty(Order = 24)]
		public string BranchId { get; set; } = string.Empty;

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string GameName { get; set; } = string.Empty;

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(disclaimer));
			p_Writer.Write(Version);
			p_Writer.Write(p_EbxWriter.WriteString(DateTime));
			p_Writer.Write(p_EbxWriter.WriteString(BranchId));
			p_Writer.Write(p_EbxWriter.WriteString(GameName));
		}
	}
}
