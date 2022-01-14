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
	[ContainerType(4, 12)]
	public class OcclusionSettings :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public bool Enable { get; set; }

		[ContainerField(9), LayoutImmutable, Blittable, JsonProperty(Order = 9)]
		public bool DrawZbuffer { get; set; }

		[ContainerField(10), LayoutImmutable, Blittable, JsonProperty(Order = 10)]
		public bool DrawBinaryBuffer { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(Enable);
			p_Writer.Write(DrawZbuffer);
			p_Writer.Write(DrawBinaryBuffer);
			p_Writer.WriteNullBytes(1);
		}
	}
}
