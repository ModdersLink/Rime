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
	[ContainerType(4, 84)]
	public class SpecialMoveVaultStateCriteria
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float DistToObject { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float DistToObjectTolerance { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float HeightOfObject { get; set; }
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public float HeightOfObjectTolerance { get; set; }
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float LengthOfObject { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float LengthOfObjectTolerance { get; set; }
		
		[ContainerField(24)]
		public SpecialMoveStateData SpecialMoveState { get; set; } = new();
		
	}
}
