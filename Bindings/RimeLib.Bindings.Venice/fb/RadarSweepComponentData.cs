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
	[ContainerType(16, 128)]
	public class RadarSweepComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ControllableSpeedThreshold { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float ControllableSweepRadius { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ControllableSweepInterval { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float MineSweepInterval { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float MineSweepRadius { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool SweepForMines { get; set; }

		[ContainerField(117), LayoutImmutable, Blittable]
		public bool SweepForControllables { get; set; }

		public static void Deserialize(RadarSweepComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ControllableSpeedThreshold = p_Reader.ReadSingle();
			p_Instance.ControllableSweepRadius = p_Reader.ReadSingle();
			p_Instance.ControllableSweepInterval = p_Reader.ReadSingle();
			p_Instance.MineSweepInterval = p_Reader.ReadSingle();
			p_Instance.MineSweepRadius = p_Reader.ReadSingle();
			p_Instance.SweepForMines = p_Reader.ReadBool();
			p_Instance.SweepForControllables = p_Reader.ReadBool();
			p_Reader.Seek(10, SeekOrigin.Current);
		}

	}
}
