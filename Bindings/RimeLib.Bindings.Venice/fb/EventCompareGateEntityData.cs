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
	public class EventCompareGateEntityData : 
		EntityData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public int Value { get; set; }

		[ContainerField(16)]
		public EventCompareGateType CompareType { get; set; } = new();

		[ContainerField(20)]
		public Realm Realm { get; set; } = new();

		public static void Deserialize(EventCompareGateEntityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Value = p_Reader.ReadInt32();
			p_Instance.CompareType = (EventCompareGateType) p_Reader.ReadInt32();
			p_Instance.Realm = (Realm) p_Reader.ReadInt32();
		}

	}
}
