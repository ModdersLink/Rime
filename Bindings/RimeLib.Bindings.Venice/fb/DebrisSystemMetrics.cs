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
	public class DebrisSystemMetrics
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public int HavokParticleCount { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public int HavokParticlePartCount { get; set; }
		
		public static void Deserialize(DebrisSystemMetrics p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HavokParticleCount = p_Reader.ReadInt32();
			p_Instance.HavokParticlePartCount = p_Reader.ReadInt32();
		}
	}
}
