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
	public class ReadinessLevels
	{
		[ContainerField(0)]
		public ReadinessLevelCharacteristics Patrol { get; set; } = new();
		
		[ContainerField(12)]
		public ReadinessLevelCharacteristics Ready { get; set; } = new();
		
		[ContainerField(24)]
		public ReadinessLevelCharacteristics Combat { get; set; } = new();
		
		public static void Deserialize(ReadinessLevels p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.ReadinessLevelCharacteristics.Deserialize(p_Instance.Patrol, p_Reader, p_Parser);
			fb.ReadinessLevelCharacteristics.Deserialize(p_Instance.Ready, p_Reader, p_Parser);
			fb.ReadinessLevelCharacteristics.Deserialize(p_Instance.Combat, p_Reader, p_Parser);
		}
	}
}
