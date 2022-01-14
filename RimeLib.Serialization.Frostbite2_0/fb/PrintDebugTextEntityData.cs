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
	[ContainerType(16, 48)]
	public class PrintDebugTextEntityData :
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(32), JsonProperty(Order = 32)]
		public Realm Realm { get; set; } = new();

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string Text { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public bool Enabled { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(p_EbxWriter.WriteString(Text));
			p_Writer.Write(Enabled);
			p_Writer.WriteNullBytes(7);
		}
	}
}
