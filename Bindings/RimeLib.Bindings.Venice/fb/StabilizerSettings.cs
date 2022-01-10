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
	public class StabilizerSettings
	{
		[ContainerField(0)]
		public StabilizerProperty Property { get; set; } = new();
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Strength { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public bool Advanced { get; set; }
		
		public static void Deserialize(StabilizerSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Property = (StabilizerProperty) p_Reader.ReadInt32();
			p_Instance.Strength = p_Reader.ReadSingle();
			p_Instance.Advanced = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
