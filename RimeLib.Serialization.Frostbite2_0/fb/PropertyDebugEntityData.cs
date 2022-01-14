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
	[ContainerType(16, 176)]
	public class PropertyDebugEntityData :
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec2 ScreenPosition { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 128)]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(136), LayoutImmutable, JsonProperty(Order = 136)]
		public string ValuePrefix { get; set; } = string.Empty;

		[ContainerField(140), JsonProperty(Order = 140)]
		public Realm Realm { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable, JsonProperty(Order = 144)]
		public float FloatValue { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable, JsonProperty(Order = 148)]
		public int IntValue { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable, JsonProperty(Order = 152)]
		public float TextScale { get; set; }

		[ContainerField(156), LayoutImmutable, JsonProperty(Order = 156)]
		public string StringValue { get; set; } = string.Empty;

		[ContainerField(160), LayoutImmutable, Blittable, JsonProperty(Order = 160)]
		public bool DefaultVisible { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable, JsonProperty(Order = 161)]
		public bool BoolValue { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable, JsonProperty(Order = 162)]
		public bool Multiline { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(4);
			Vec3Value.Serialize(p_Writer, p_EbxWriter);
			TextColor.Serialize(p_Writer, p_EbxWriter);
			ScreenPosition.Serialize(p_Writer, p_EbxWriter);
			p_Writer.WriteNullBytes(8);
			TransformValue.Serialize(p_Writer, p_EbxWriter);
			Vec2Value.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(p_EbxWriter.WriteString(ValuePrefix));
			p_Writer.Write((int) Realm);
			p_Writer.Write(FloatValue);
			p_Writer.Write(IntValue);
			p_Writer.Write(TextScale);
			p_Writer.Write(p_EbxWriter.WriteString(StringValue));
			p_Writer.Write(DefaultVisible);
			p_Writer.Write(BoolValue);
			p_Writer.Write(Multiline);
			p_Writer.WriteNullBytes(13);
		}
	}
}
