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
	[ContainerType(16, 240)]
	public class AILocoComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public AILocoBinding Binding { get; set; } = new();

		[ContainerField(132)]
		public AILocoVaultBinding VaultBinding { get; set; } = new();

		[ContainerField(160)]
		public AILocoCoverBinding CoverBinding { get; set; } = new();

		[ContainerField(232), LayoutImmutable, Blittable]
		public float WantedYaw { get; set; }

		[ContainerField(236), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

	}
}
