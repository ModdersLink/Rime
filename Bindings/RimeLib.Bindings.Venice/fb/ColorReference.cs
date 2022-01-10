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
	[ContainerType(16, 32)]
	public class ColorReference : 
		Asset
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 Color { get; set; } = new();

		public static void Deserialize(ColorReference p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Reader.Seek(4, SeekOrigin.Current);
			fb.Vec4.Deserialize(p_Instance.Color, p_Reader, p_Parser);
			p_Reader.Seek(4, SeekOrigin.Current);
		}

	}
}
