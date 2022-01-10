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
	public class SoldierDetonationData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Angle { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinSpeedForActivation { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Radius { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float SoldierDetonationActivationDelay { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseAngle { get; set; }
		
		[ContainerField(17), LayoutImmutable, Blittable]
		public bool HasSoldierDetonation { get; set; }
		
		public static void Deserialize(SoldierDetonationData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Angle = p_Reader.ReadSingle();
			p_Instance.MinSpeedForActivation = p_Reader.ReadSingle();
			p_Instance.Radius = p_Reader.ReadSingle();
			p_Instance.SoldierDetonationActivationDelay = p_Reader.ReadSingle();
			p_Instance.UseAngle = p_Reader.ReadBool();
			p_Instance.HasSoldierDetonation = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}
	}
}
