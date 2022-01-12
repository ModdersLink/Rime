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
	public class ProfileOptionDataInt : 
		ProfileOptionData
	{
		[ContainerField(20), LayoutImmutable, Blittable]
		public int Min { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public int Max { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public int Value { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public int Step { get; set; }

	}
}
