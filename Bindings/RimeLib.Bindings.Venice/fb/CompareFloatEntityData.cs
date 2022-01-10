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
	public class CompareFloatEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float A { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float B { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public bool TriggerOnPropertyChange { get; set; }

		[ContainerField(25), LayoutImmutable, Blittable]
		public bool TriggerOnStart { get; set; }

		public static void Deserialize(CompareFloatEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.A = p_Reader.ReadSingle();
			p_Instance.B = p_Reader.ReadSingle();
			p_Instance.TriggerOnPropertyChange = p_Reader.ReadBool();
			p_Instance.TriggerOnStart = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
