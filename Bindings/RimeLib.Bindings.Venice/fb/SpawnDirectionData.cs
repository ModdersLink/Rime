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
	[ContainerType(16, 64)]
	public class SpawnDirectionData : 
		ProcessorData
	{
		[ContainerField(48), LayoutImmutable, Blittable]
		public float DirectionFromEmitterOrigin { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public bool InheritSpeedAndDirectionFromEmitter { get; set; }

		public static void Deserialize(SpawnDirectionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DirectionFromEmitterOrigin = p_Reader.ReadSingle();
			p_Instance.InheritSpeedAndDirectionFromEmitter = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
