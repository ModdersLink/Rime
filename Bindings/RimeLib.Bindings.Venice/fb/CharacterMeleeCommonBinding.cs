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
	[ContainerType(4, 28)]
	public class CharacterMeleeCommonBinding
	{
		[ContainerField(0)]
		public AntRef MeleeDistance { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef MeleeAngle { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef MeleeDefenceTime { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef MeleeSequenceTime { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef MeleeAborted { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef CloseToTarget { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef MeleeType { get; set; } = new();
		
		public static void Deserialize(CharacterMeleeCommonBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.MeleeDistance, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeAngle, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeDefenceTime, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeSequenceTime, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeAborted, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CloseToTarget, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeType, p_Reader, p_Parser);
		}
	}
}
