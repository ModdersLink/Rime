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
	public class EffectEntityData : 
		SpatialEntityData
	{
		[ContainerField(80)]
		public RefArray<GameObjectData> Components { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public uint MaxInstanceCount { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float CullDistance { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float StartDelay { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool HighEndPc { get; set; }

		[ContainerField(97), LayoutImmutable, Blittable]
		public bool MediumPc { get; set; }

		[ContainerField(98), LayoutImmutable, Blittable]
		public bool LowEndPc { get; set; }

		[ContainerField(99), LayoutImmutable, Blittable]
		public bool ResetInstanceWhenStarted { get; set; }

	}
}
