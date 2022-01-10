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
	[ContainerType(4, 28)]
	public class FlashlightWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public float UpdateFrequency { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float Range { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		public static void Deserialize(FlashlightWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UpdateFrequency = p_Reader.ReadSingle();
			p_Instance.Range = p_Reader.ReadSingle();
			p_Instance.Angle = p_Reader.ReadSingle();
		}

	}
}
