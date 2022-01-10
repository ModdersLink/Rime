///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using RimeLib.IO;
using RimeLib.Frostbite.Core;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(16, 176)]
	public class PropertyDebugEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 ScreenPosition { get; set; } = new();

		[ContainerField(64), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(136), LayoutImmutable]
		public string ValuePrefix { get; set; } = string.Empty;

		[ContainerField(140)]
		public Realm Realm { get; set; } = new();

		[ContainerField(144), LayoutImmutable, Blittable]
		public float FloatValue { get; set; }

		[ContainerField(148), LayoutImmutable, Blittable]
		public int IntValue { get; set; }

		[ContainerField(152), LayoutImmutable, Blittable]
		public float TextScale { get; set; }

		[ContainerField(156), LayoutImmutable]
		public string StringValue { get; set; } = string.Empty;

		[ContainerField(160), LayoutImmutable, Blittable]
		public bool DefaultVisible { get; set; }

		[ContainerField(161), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; }

		[ContainerField(162), LayoutImmutable, Blittable]
		public bool Multiline { get; set; }

		public static void Deserialize(PropertyDebugEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Vec3Value, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.TextColor, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.ScreenPosition, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.TransformValue, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.Vec2.Deserialize(p_Instance.Vec2Value, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.ValuePrefix = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.FloatValue = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.IntValue = p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.TextScale = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.StringValue = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.DefaultVisible = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.BoolValue = p_Reader.ReadBool();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Multiline = p_Reader.ReadBool();
			p_Reader.Seek(25, SeekOrigin.Current);
		}

	}
}
