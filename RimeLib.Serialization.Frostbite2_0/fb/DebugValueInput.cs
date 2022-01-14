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
	[ContainerType(4, 32)]
	public class DebugValueInput :
		AudioGraphNodePortGroup
	{
		[ContainerField(8), JsonProperty(Order = 8)]
		public AudioGraphNodePort V { get; set; } = new();

		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string Name { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public DebugRenderType RenderType { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float Min { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float Max { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			V.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(Name));
			p_Writer.Write((int) RenderType);
			p_Writer.Write(Min);
			p_Writer.Write(Max);
		}
	}
}
