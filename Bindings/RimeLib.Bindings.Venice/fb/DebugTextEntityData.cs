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
	[ContainerType(16, 112)]
	public class DebugTextEntityData : 
		SpatialEntityData
	{
		[ContainerField(80), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(96), LayoutImmutable]
		public string DebugText { get; set; } = string.Empty;

		[ContainerField(100)]
		public Realm Realm { get; set; } = new();

		[ContainerField(104), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool Visible { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool Centered { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool DepthTest { get; set; }

		[ContainerField(111), LayoutImmutable, Blittable]
		public bool ScaleWithDistance { get; set; }

		public static void Deserialize(DebugTextEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.TextColor, p_Reader, p_Parser);
			p_Instance.DebugText = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Scale = p_Reader.ReadSingle();
			p_Instance.Visible = p_Reader.ReadBool();
			p_Instance.Centered = p_Reader.ReadBool();
			p_Instance.DepthTest = p_Reader.ReadBool();
			p_Instance.ScaleWithDistance = p_Reader.ReadBool();
		}

	}
}
