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
	public class DelayEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Delay { get; set; }

		[ContainerField(16)]
		public Realm Realm { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool AutoStart { get; set; }

		[ContainerField(21), LayoutImmutable, Blittable]
		public bool RunOnce { get; set; }

		[ContainerField(22), LayoutImmutable, Blittable]
		public bool RemoveDuplicateEvents { get; set; }

		public static void Deserialize(DelayEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Delay = p_Reader.ReadSingle();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.AutoStart = p_Reader.ReadBool();
			p_Instance.RunOnce = p_Reader.ReadBool();
			p_Instance.RemoveDuplicateEvents = p_Reader.ReadBool();
			p_Reader.Seek(1, SeekOrigin.Current);
		}

	}
}
