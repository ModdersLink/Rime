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
	public class Animated3pOnlyWeaponBinding
	{
		[ContainerField(0)]
		public AntRef Deploy3P { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef HideWeapon3p { get; set; } = new();
		
		public static void Deserialize(Animated3pOnlyWeaponBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.Deploy3P, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.HideWeapon3p, p_Reader, p_Parser);
		}
	}
}
