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
		
	}
}
