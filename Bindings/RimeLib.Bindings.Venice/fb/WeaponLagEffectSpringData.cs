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
	public class WeaponLagEffectSpringData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float Constant { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float Damping { get; set; }
		
		public static void Deserialize(WeaponLagEffectSpringData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.Constant = p_Reader.ReadSingle();
			p_Instance.Damping = p_Reader.ReadSingle();
		}
	}
}
