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
	public class WeaponLagEffectSpringVector
	{
		[ContainerField(0)]
		public WeaponLagEffectSpringData SpringX { get; set; } = new();
		
		[ContainerField(8)]
		public WeaponLagEffectSpringData SpringY { get; set; } = new();
		
		[ContainerField(16)]
		public WeaponLagEffectSpringData SpringZ { get; set; } = new();
		
		public static void Deserialize(WeaponLagEffectSpringVector p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.WeaponLagEffectSpringData.Deserialize(p_Instance.SpringX, p_Reader, p_Parser);
			fb.WeaponLagEffectSpringData.Deserialize(p_Instance.SpringY, p_Reader, p_Parser);
			fb.WeaponLagEffectSpringData.Deserialize(p_Instance.SpringZ, p_Reader, p_Parser);
		}
	}
}
