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
	public class PoseTransitionTime
	{
		[ContainerField(0)]
		public CharacterPoseType ToPose { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float TransitionTime { get; set; }
		
		public static void Deserialize(PoseTransitionTime p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ToPose = (CharacterPoseType) p_Reader.ReadInt32();
			p_Instance.TransitionTime = p_Reader.ReadSingle();
		}
	}
}
