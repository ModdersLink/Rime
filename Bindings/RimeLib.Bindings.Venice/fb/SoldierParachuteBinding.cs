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
	public class SoldierParachuteBinding
	{
		[ContainerField(0)]
		public AntRef Enabled { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef SteerLeftRight { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef AccelerateBrake { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef Pitch { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef Roll { get; set; } = new();
		
		public static void Deserialize(SoldierParachuteBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Enabled, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.SteerLeftRight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AccelerateBrake, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Pitch, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Roll, p_Reader, p_Parser);
		}
	}
}
