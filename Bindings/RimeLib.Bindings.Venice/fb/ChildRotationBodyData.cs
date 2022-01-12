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
	[ContainerType(4, 80)]
	public class ChildRotationBodyData : 
		RotationBodyData
	{
		[ContainerField(56), LayoutImmutable, Blittable]
		public float ForceModifier { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float ResetForceModifier { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float ResetForceInputThreshold { get; set; }

		[ContainerField(68)]
		public EntryInputActionEnum RotationInput { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public float WorldSpaceLockEfficiency { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public bool UseLinearInput { get; set; }

	}
}
