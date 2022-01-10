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
	[ContainerType(16, 144)]
	public class LoggingEntityData : 
		EntityData
	{
		[ContainerField(12), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Vec2Value { get; set; } = new();

		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Vec3Value { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform TransformValue { get; set; } = new();

		[ContainerField(112)]
		public Realm Realm { get; set; } = new();

		[ContainerField(116), LayoutImmutable, Blittable]
		public float FloatValue { get; set; }

		[ContainerField(120)]
		public List<string> Strings { get; set; } = new();

		[ContainerField(124), LayoutImmutable, Blittable]
		public int IntValue { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public bool BoolValue { get; set; }

		public static void Deserialize(LoggingEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec2.Deserialize(p_Instance.Vec2Value, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.Vec3Value, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			fb.LinearTransform.Deserialize(p_Instance.TransformValue, p_Reader, p_Parser);
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.FloatValue = p_Reader.ReadSingle();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.Strings.Clear();
			(RimeReader Reader, uint Count) s_Strings = p_Parser.GetArrayReaderAndElementCount(p_Reader.ReadUInt32());
			for (uint i = 0; i < s_Strings.Count; ++i)
			{
				var s_Value = p_Parser.GetStringAtOffset(s_Strings.Reader.ReadUInt32());
				p_Instance.Strings.Add(s_Value);
			}
			
			s_Strings.Reader.Dispose();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.IntValue = p_Reader.ReadInt32();
			p_Reader.Seek(12, SeekOrigin.Current);
			p_Instance.BoolValue = p_Reader.ReadBool();
			p_Reader.Seek(27, SeekOrigin.Current);
		}

	}
}
