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
	[ContainerType(4, 36)]
	public class SoundTestParamTask : 
		SoundTestTaskSpec
	{
		[ContainerField(16), LayoutImmutable]
		public string ParamName { get; set; } = string.Empty;

		[ContainerField(20)]
		public SoundTestParamBehavior Behavior { get; set; } = new();

		[ContainerField(24), LayoutImmutable, Blittable]
		public float RangeMin { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float RangeMax { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float InitialValue { get; set; }

		public static void Deserialize(SoundTestParamTask p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ParamName = p_Parser.GetStringAtOffset(p_Reader.ReadUInt32());
			p_Instance.Behavior = (SoundTestParamBehavior) p_Reader.ReadInt32();
			p_Instance.RangeMin = p_Reader.ReadSingle();
			p_Instance.RangeMax = p_Reader.ReadSingle();
			p_Instance.InitialValue = p_Reader.ReadSingle();
		}

	}
}
