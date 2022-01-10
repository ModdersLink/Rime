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
	public class RandomEvaluatorData : 
		EvaluatorData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Max { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float Min { get; set; }

		public static void Deserialize(RandomEvaluatorData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Max = p_Reader.ReadSingle();
			p_Instance.Min = p_Reader.ReadSingle();
		}

	}
}
