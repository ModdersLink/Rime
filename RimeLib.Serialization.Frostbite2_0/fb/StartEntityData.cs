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
	[ContainerType(4, 24)]
	public class StartEntityData :
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float SortIndex { get; set; }

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string StartName { get; set; } = string.Empty;

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public bool IsDefault { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(SortIndex);
			p_Writer.Write(p_EbxWriter.WriteString(StartName));
			p_Writer.Write(IsDefault);
			p_Writer.WriteNullBytes(3);
		}
	}
}
