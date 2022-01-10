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
	public class WeaponLagBinding
	{
		[ContainerField(0)]
		public AntRef EntityPitch { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef EntityYaw { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef PitchResult { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef YawResult { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef RollResult { get; set; } = new();
		
		public static void Deserialize(WeaponLagBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.EntityPitch, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.EntityYaw, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.PitchResult, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.YawResult, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.RollResult, p_Reader, p_Parser);
		}
	}
}
