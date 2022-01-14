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
	[ContainerType(4, 36)]
	public class SoundTestParamTask :
		SoundTestTaskSpec
	{
		[ContainerField(16), LayoutImmutable, JsonProperty(Order = 16)]
		public string ParamName { get; set; } = string.Empty;

		[ContainerField(20), JsonProperty(Order = 20)]
		public SoundTestParamBehavior Behavior { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float RangeMin { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float RangeMax { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float InitialValue { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ParamName));
			p_Writer.Write((int) Behavior);
			p_Writer.Write(RangeMin);
			p_Writer.Write(RangeMax);
			p_Writer.Write(InitialValue);
		}
	}
}
