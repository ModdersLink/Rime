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
	public class InspectAnimationTriggerData
	{
		[ContainerField(0)]
		public AntRef Animation { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Probability { get; set; }
		
		public static void Deserialize(InspectAnimationTriggerData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Animation, p_Reader, p_Parser);
			p_Instance.Probability = p_Reader.ReadSingle();
		}
	}
}
