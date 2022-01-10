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
	public class MissileLockableInfoData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float HeatSignature { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float RadarSignature { get; set; }
		
		public static void Deserialize(MissileLockableInfoData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.HeatSignature = p_Reader.ReadSingle();
			p_Instance.RadarSignature = p_Reader.ReadSingle();
		}
	}
}
