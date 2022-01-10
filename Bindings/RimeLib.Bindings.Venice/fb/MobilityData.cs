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
	[ContainerType(4, 16)]
	public class MobilityData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool Use3DWaypoints { get; set; }

		public static void Deserialize(MobilityData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MaxSpeed = p_Reader.ReadSingle();
			p_Instance.Use3DWaypoints = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
