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
	public class SoundEnvironmentConstantData : 
		Asset
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HumanPlayerSoldierMovementVolumeOverride { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MemoryTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinimumLoudness { get; set; }

		public static void Deserialize(SoundEnvironmentConstantData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HumanPlayerSoldierMovementVolumeOverride = p_Reader.ReadSingle();
			p_Instance.MemoryTime = p_Reader.ReadSingle();
			p_Instance.MinimumLoudness = p_Reader.ReadSingle();
		}

	}
}
