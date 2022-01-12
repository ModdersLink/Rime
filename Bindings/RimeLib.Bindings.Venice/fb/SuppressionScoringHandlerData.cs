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
	[ContainerType(4, 16)]
	public class SuppressionScoringHandlerData : 
		ScoringHandlerData
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float SuppressionAmountLimit { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float TimeSinceSuppressionLimit { get; set; }

	}
}
