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
	[ContainerType(16, 48)]
	public class PrintDebugTextEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 TextColor { get; set; } = new();

		[ContainerField(32)]
		public Realm Realm { get; set; } = new();

		[ContainerField(36), LayoutImmutable]
		public string Text { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(PrintDebugTextEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec3.Deserialize(p_Instance.TextColor, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Text = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Reader.Seek(4, SeekOrigin.Current);
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
