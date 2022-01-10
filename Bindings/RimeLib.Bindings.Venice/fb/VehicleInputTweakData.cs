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
	public class VehicleInputTweakData : 
		DataContainer
	{
		[ContainerField(8)]
		public VehicleInputTweakType InputTweakType { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public float MinSpeed { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float MaxSpeed { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinSpeedScale { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxSpeedScale { get; set; }

		public static void Deserialize(VehicleInputTweakData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.InputTweakType = (VehicleInputTweakType) p_Reader.ReadInt32();
			p_Instance.MinSpeed = p_Reader.ReadSingle();
			p_Instance.MaxSpeed = p_Reader.ReadSingle();
			p_Instance.MinSpeedScale = p_Reader.ReadSingle();
			p_Instance.MaxSpeedScale = p_Reader.ReadSingle();
		}

	}
}
