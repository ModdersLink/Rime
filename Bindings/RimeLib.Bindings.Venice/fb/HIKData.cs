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
	public class HIKData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ReachT { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float ReachR { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Pull { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Resist { get; set; }
		
		public static void Deserialize(HIKData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ReachT = p_Reader.ReadSingle();
			p_Instance.ReachR = p_Reader.ReadSingle();
			p_Instance.Pull = p_Reader.ReadSingle();
			p_Instance.Resist = p_Reader.ReadSingle();
		}
	}
}
