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
	[ContainerType(4, 16)]
	public class CharacterMeleeBinding
	{
		[ContainerField(0)]
		public AntRef TriggerMelee { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef SelfActor { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef OtherActor { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef MeleeActive { get; set; } = new();
		
		public static void Deserialize(CharacterMeleeBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.TriggerMelee, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.SelfActor, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.OtherActor, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.MeleeActive, p_Reader, p_Parser);
		}
	}
}
