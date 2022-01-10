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
	[ContainerType(4, 20)]
	public class Or4EntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool In1 { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool In2 { get; set; }

		[ContainerField(18), LayoutImmutable, Blittable]
		public bool In3 { get; set; }

		[ContainerField(19), LayoutImmutable, Blittable]
		public bool In4 { get; set; }

		public static void Deserialize(Or4EntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.In1 = p_Reader.ReadBool();
			p_Instance.In2 = p_Reader.ReadBool();
			p_Instance.In3 = p_Reader.ReadBool();
			p_Instance.In4 = p_Reader.ReadBool();
		}

	}
}
