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
	[ContainerType(4, 36)]
	public class CompareEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public CompareOp Operator { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float FloatIn0 { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float FloatIn1 { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int IntIn0 { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public int IntIn1 { get; set; }

		public static void Deserialize(CompareEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Operator = (CompareOp) p_Reader.ReadInt32();
			p_Instance.FloatIn0 = p_Reader.ReadSingle();
			p_Instance.FloatIn1 = p_Reader.ReadSingle();
			p_Instance.IntIn0 = p_Reader.ReadInt32();
			p_Instance.IntIn1 = p_Reader.ReadInt32();
		}

	}
}
