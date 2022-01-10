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
	public class StopWatchEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public UpdatePass UpdatePass { get; set; } = new();

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Multiplier { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float TriggerOnTime { get; set; }

		public static void Deserialize(StopWatchEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.UpdatePass = (UpdatePass) p_Reader.ReadInt32();
			p_Instance.Multiplier = p_Reader.ReadSingle();
			p_Instance.TriggerOnTime = p_Reader.ReadSingle();
		}

	}
}
