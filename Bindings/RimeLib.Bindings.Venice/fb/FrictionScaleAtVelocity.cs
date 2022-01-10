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
	public class FrictionScaleAtVelocity
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float FrictionScale { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Velocity { get; set; }
		
		public static void Deserialize(FrictionScaleAtVelocity p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.FrictionScale = p_Reader.ReadSingle();
			p_Instance.Velocity = p_Reader.ReadSingle();
		}
	}
}
