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
	[ContainerType(4, 12)]
	public class CameraSineCurveData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Frequency { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Amplitude { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float PhaseShift { get; set; }
		
		public static void Deserialize(CameraSineCurveData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Frequency = p_Reader.ReadSingle();
			p_Instance.Amplitude = p_Reader.ReadSingle();
			p_Instance.PhaseShift = p_Reader.ReadSingle();
		}
	}
}
