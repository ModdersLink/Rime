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
	[ContainerType(4, 36)]
	public class ProfileOptionDataFloat : 
		ProfileOptionData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public float Min { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float Max { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float Value { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float Step { get; set; }

	}
}
