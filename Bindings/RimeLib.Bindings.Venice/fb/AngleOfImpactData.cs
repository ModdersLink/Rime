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
	[ContainerType(4, 24)]
	public class AngleOfImpactData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Zone12Delimiter { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Zone23Delimiter { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Zone1Multiplier { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Zone2Multiplier { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Zone3Multiplier { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Enabled { get; set; }
		
		public static void Deserialize(AngleOfImpactData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Zone12Delimiter = p_Reader.ReadSingle();
			p_Instance.Zone23Delimiter = p_Reader.ReadSingle();
			p_Instance.Zone1Multiplier = p_Reader.ReadSingle();
			p_Instance.Zone2Multiplier = p_Reader.ReadSingle();
			p_Instance.Zone3Multiplier = p_Reader.ReadSingle();
			p_Instance.Enabled = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
