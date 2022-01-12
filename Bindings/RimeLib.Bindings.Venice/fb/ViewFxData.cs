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
	[ContainerType(16, 112)]
	public class ViewFxData : 
		DataContainer
	{
		[ContainerField(8)]
		public PoissonRadialBlurData PoissonRadialBlur { get; set; } = new();

		[ContainerField(32)]
		public ColorTintData ColorTint { get; set; } = new();

		[ContainerField(96), LayoutImmutable, Blittable]
		public float BlurAdd { get; set; }

		[ContainerField(100), LayoutImmutable, Blittable]
		public bool ColorTintEnable { get; set; }

		[ContainerField(101), LayoutImmutable, Blittable]
		public bool PoissonRadialBlurEnable { get; set; }

	}
}
