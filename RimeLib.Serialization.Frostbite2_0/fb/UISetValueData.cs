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
	[ContainerType(4, 44)]
	public class UISetValueData :
		EntityData
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public UIDataSourceInfo DataSource { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public int IntValue { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float FloatValue { get; set; }

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string StringValue { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool BoolValue { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			DataSource.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(IntValue);
			p_Writer.Write(FloatValue);
			p_Writer.Write(p_EbxWriter.WriteString(StringValue));
			p_Writer.Write(BoolValue);
			p_Writer.WriteNullBytes(3);
		}
	}
}
