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
	[ContainerType(4, 12)]
	public class SphereCollisionData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float ExtraRadius { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CounterNormalBrakeForceMod { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }
		
		public static void Deserialize(SphereCollisionData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.ExtraRadius = p_Reader.ReadSingle();
			p_Instance.CounterNormalBrakeForceMod = p_Reader.ReadSingle();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
