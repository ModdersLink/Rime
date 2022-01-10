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
	public class SoundTestTask : 
		DataContainer
	{
		[ContainerField(8)]
		public CtrRef<SoundTestTaskSpec> Spec { get; set; } = new();

		[ContainerField(12)]
		public CtrRef<SoundTestTaskParam> Param { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public float StartTime { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public uint Repetitions { get; set; }

		public static void Deserialize(SoundTestTask p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Spec.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.Param.SetValue(p_Parser.GetImportAtIndex(p_Reader.ReadUInt32()));
			p_Instance.StartTime = p_Reader.ReadSingle();
			p_Instance.Repetitions = p_Reader.ReadUInt32();
		}

	}
}
