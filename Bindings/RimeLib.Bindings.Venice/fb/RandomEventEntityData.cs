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
	[ContainerType(4, 24)]
	public class RandomEventEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int Probability { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool RandomizeFirstOnly { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		public static void Deserialize(RandomEventEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Probability = p_Reader.ReadInt32();
			p_Instance.RandomizeFirstOnly = p_Reader.ReadBool();
			p_Instance.AutoStart = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
