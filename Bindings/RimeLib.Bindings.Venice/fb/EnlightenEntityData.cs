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
	public class EnlightenEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int Priority { get; set; }

		[ContainerField(16)]
		public Realm Realm { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Enable { get; set; }

		public static void Deserialize(EnlightenEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Priority = p_Reader.ReadInt32();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.Enable = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
