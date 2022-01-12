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
	public class PadInputActionData : 
		AxesInputActionData
	{
		[ContainerField(20)]
		public InputDevicePadButtons Button { get; set; } = new();

		[ContainerField(24)]
		public InputDevicePOVs Pov { get; set; } = new();

		[ContainerField(28)]
		public InputDevicePadButtons PS3AlternativeButton { get; set; } = new();

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseSquareInput { get; set; }

	}
}
