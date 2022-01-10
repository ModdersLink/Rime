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
	public class SlowMotionEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float TimeScale { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ScaleDownTransitionTime { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float ScaleUpTransitionTime { get; set; }

		public static void Deserialize(SlowMotionEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
			p_Instance.TimeScale = p_Reader.ReadSingle();
			p_Instance.ScaleDownTransitionTime = p_Reader.ReadSingle();
			p_Instance.ScaleUpTransitionTime = p_Reader.ReadSingle();
		}

	}
}
