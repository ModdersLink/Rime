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
	public class SyncAnimationsEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float NearEndEventTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public bool StartServerPaused { get; set; }

		public static void Deserialize(SyncAnimationsEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ExternalTime = p_Reader.ReadSingle();
			p_Instance.NearEndEventTime = p_Reader.ReadSingle();
			p_Instance.StartServerPaused = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
