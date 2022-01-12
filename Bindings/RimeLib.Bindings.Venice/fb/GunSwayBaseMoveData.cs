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
	[ContainerType(4, 76)]
	public class GunSwayBaseMoveData
	{
		[ContainerField(0)]
		public GunSwayDispersionData BaseValue { get; set; } = new();
		
		[ContainerField(16)]
		public GunSwayDispersionData Moving { get; set; } = new();
		
		[ContainerField(32)]
		public GunSwayRecoilData Recoil { get; set; } = new();
		
		[ContainerField(56)]
		public GunSwayLagData GunSwayLag { get; set; } = new();
		
	}
}
