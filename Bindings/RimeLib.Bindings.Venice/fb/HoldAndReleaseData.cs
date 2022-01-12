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
	public class HoldAndReleaseData
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float MaxHoldTime { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float MinPowerModifier { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float MaxPowerModifier { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float PowerIncreasePerSecond { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float Delay { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float KilledHoldingPowerModifier { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public bool ForceFireWhenKilledHolding { get; set; }
		
	}
}
