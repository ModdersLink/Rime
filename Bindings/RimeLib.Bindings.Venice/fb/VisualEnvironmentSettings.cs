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
	public class VisualEnvironmentSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SunRotationX { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float SunRotationY { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public bool DrawStats { get; set; }

		public static void Deserialize(VisualEnvironmentSettings p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.SunRotationX = p_Reader.ReadSingle();
			p_Instance.SunRotationY = p_Reader.ReadSingle();
			p_Instance.DrawStats = p_Reader.ReadBool();
			p_Reader.Seek(3, SeekOrigin.Current);
		}

	}
}
