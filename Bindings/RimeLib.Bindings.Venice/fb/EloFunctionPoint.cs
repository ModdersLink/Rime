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
	[ContainerType(4, 8)]
	public class EloFunctionPoint
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float XValue { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float YValue { get; set; }
		
		public static void Deserialize(EloFunctionPoint p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.XValue = p_Reader.ReadSingle();
			p_Instance.YValue = p_Reader.ReadSingle();
		}
	}
}
