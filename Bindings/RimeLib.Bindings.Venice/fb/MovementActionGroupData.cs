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
	public class MovementActionGroupData : 
		MovementActionData
	{
		[ContainerField(8)]
		public RefArray<MovementActionData> Actions { get; set; } = new();

		[ContainerField(12), LayoutImmutable, Blittable]
		public bool RunSimultaneously { get; set; }

		[ContainerField(13), LayoutImmutable, Blittable]
		public bool RestartChildren { get; set; }

	}
}
