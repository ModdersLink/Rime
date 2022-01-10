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
	public class WeaponClassModifier : 
		WeaponModifierBase
	{
		[ContainerField(8)]
		public WeaponClassEnum WeaponClass { get; set; } = new();

		public static void Deserialize(WeaponClassModifier p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.WeaponClass = (WeaponClassEnum) p_Reader.ReadInt32();
		}

	}
}
