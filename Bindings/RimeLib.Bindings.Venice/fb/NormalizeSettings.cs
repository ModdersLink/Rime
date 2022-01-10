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
	public class NormalizeSettings
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Maximum { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Minimum { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float Velocity { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float Lower { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Upper { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public bool Normalize { get; set; }
		
		public static void Deserialize(NormalizeSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Maximum = p_Reader.ReadSingle();
			p_Instance.Minimum = p_Reader.ReadSingle();
			p_Instance.Velocity = p_Reader.ReadSingle();
			p_Instance.Lower = p_Reader.ReadSingle();
			p_Instance.Upper = p_Reader.ReadSingle();
			p_Instance.Normalize = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}
	}
}
