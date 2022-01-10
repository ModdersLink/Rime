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
	public class PitchModifier
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 Offset { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float PitchVal { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float PitchAngle { get; set; }
		
		public static void Deserialize(PitchModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.Vec3.Deserialize(p_Instance.Offset, p_Reader, p_Parser);
			p_Instance.PitchVal = p_Reader.ReadSingle();
			p_Instance.PitchAngle = p_Reader.ReadSingle();
			p_Reader.Seek(8, SeekOrigin.Current);
		}
	}
}
