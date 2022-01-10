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
	public class SpottingTargetComponentData : 
		ComponentData
	{
		[ContainerField(96), LayoutImmutable, Blittable]
		public float ActiveSpottedTime { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public float PassiveSpottedTime { get; set; }

		[ContainerField(104), LayoutImmutable, Blittable]
		public float ActiveSpottedTimeMultiplier { get; set; }

		[ContainerField(108), LayoutImmutable, Blittable]
		public float PassiveSpottedTimeMultiplier { get; set; }

		[ContainerField(112), LayoutImmutable, Blittable]
		public float SpotOnFireMultiplier { get; set; }

		[ContainerField(116), LayoutImmutable, Blittable]
		public bool TargetBoundingBoxCenter { get; set; }

		public static void Deserialize(SpottingTargetComponentData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ActiveSpottedTime = p_Reader.ReadSingle();
			p_Instance.PassiveSpottedTime = p_Reader.ReadSingle();
			p_Instance.ActiveSpottedTimeMultiplier = p_Reader.ReadSingle();
			p_Instance.PassiveSpottedTimeMultiplier = p_Reader.ReadSingle();
			p_Instance.SpotOnFireMultiplier = p_Reader.ReadSingle();
			p_Instance.TargetBoundingBoxCenter = p_Reader.ReadBool();
			p_Reader.Seek(11, SeekOrigin.Current);
		}

	}
}
