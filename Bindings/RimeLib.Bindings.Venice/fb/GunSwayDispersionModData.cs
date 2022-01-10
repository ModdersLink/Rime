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
	public class GunSwayDispersionModData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MinAngleModifier { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MaxAngleModifier { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float IncreasePerShotModifier { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DecreasePerSecondModifier { get; set; }
		
		public static void Deserialize(GunSwayDispersionModData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.MinAngleModifier = p_Reader.ReadSingle();
			p_Instance.MaxAngleModifier = p_Reader.ReadSingle();
			p_Instance.IncreasePerShotModifier = p_Reader.ReadSingle();
			p_Instance.DecreasePerSecondModifier = p_Reader.ReadSingle();
		}
	}
}
