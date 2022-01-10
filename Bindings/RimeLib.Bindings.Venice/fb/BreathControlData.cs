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
	public class BreathControlData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float BreathControlTime { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float BreathControlReleaseTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float BreathControlPenaltyMultiplier { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float BreathControlPenaltyTimeout { get; set; }

		public static void Deserialize(BreathControlData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.BreathControlTime = p_Reader.ReadSingle();
			p_Instance.BreathControlReleaseTime = p_Reader.ReadSingle();
			p_Instance.BreathControlPenaltyMultiplier = p_Reader.ReadSingle();
			p_Instance.BreathControlPenaltyTimeout = p_Reader.ReadSingle();
		}

	}
}
