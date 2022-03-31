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
	[ContainerType(16, 144)]
	public class LoggingEntityData :
		EntityData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(112), JsonProperty(Order = 112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable, JsonProperty(Order = 116)]
		public float FloatValue { get; set; }

		[ContainerField(120), JsonProperty(Order = 120)]
		public List<string> Strings { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable, JsonProperty(Order = 124)]
		public int IntValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public bool BoolValue { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			Vec2Value.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(12);
			Vec3Value.Serialize(p_Writer, p_EbxWriter);
			TransformValue.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write((int) Realm);
			p_Writer.Write(FloatValue);
			(RimeWriter Writer, uint ArrayIndex) s_Strings = p_EbxWriter.GetArrayWriter(Strings.GetType(), Strings.Count);
			p_Writer.Write(s_Strings.ArrayIndex);
			foreach (var s_Entry in Strings)
			{
				s_Strings.Writer.Write(p_EbxWriter.WriteString(s_Entry));
			}
			p_Writer.Write(IntValue);
			p_Writer.Write(BoolValue);
			p_Writer.WriteNullBytes(15);
		}
	}
}
