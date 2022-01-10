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
	public class MeleeWeaponData : 
		WeaponData
	{
		[ContainerField(16), LayoutImmutable, Blittable]
		public bool UseCannedAnimation { get; set; }

		[ContainerField(17), LayoutImmutable, Blittable]
		public bool UseSphereDamage { get; set; }

		public static void Deserialize(MeleeWeaponData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.UseCannedAnimation = p_Reader.ReadBool();
			p_Instance.UseSphereDamage = p_Reader.ReadBool();
			p_Reader.Seek(2, SeekOrigin.Current);
		}

	}
}
