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
	public class FaceAnimationWaveMapping
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int WaveNameHash { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int AntEnumValue { get; set; }
		
		public static void Deserialize(FaceAnimationWaveMapping p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WaveNameHash = p_Reader.ReadInt32();
			p_Instance.AntEnumValue = p_Reader.ReadInt32();
		}
	}
}
