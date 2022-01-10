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
	public class RadioAltitudeData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Range { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float UpdateFrequency { get; set; }

		[ContainerField(16)]
		public CollisionMethodEnum CollisionMethod { get; set; } = new();

		public static void Deserialize(RadioAltitudeData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Range = p_Reader.ReadSingle();
			p_Instance.UpdateFrequency = p_Reader.ReadSingle();
			p_Instance.CollisionMethod = (CollisionMethodEnum) p_Reader.ReadInt32();
		}

	}
}
