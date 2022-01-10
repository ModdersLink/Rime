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
	[ContainerType(4, 28)]
	public class InputModifierEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public EntryInputActionEnum Action { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Scale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Offset { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }

		public static void Deserialize(InputModifierEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Action = (EntryInputActionEnum) p_Reader.ReadInt32();
			p_Instance.Scale = p_Reader.ReadSingle();
			p_Instance.Offset = p_Reader.ReadSingle();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
