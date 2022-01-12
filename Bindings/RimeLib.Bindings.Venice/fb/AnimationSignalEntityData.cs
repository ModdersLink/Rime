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
	[ContainerType(4, 40)]
	public class AnimationSignalEntityData : 
		EntityData
	{
		[ContainerField(12)]
		public Realm Realm { get; set; } = new();

		[ContainerField(16)]
		public AntRef Signal { get; set; } = new();

		[ContainerField(20)]
		public AntRef IntGameState { get; set; } = new();

		[ContainerField(24)]
		public AntRef FloatGameState { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public int ValueInt { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ValueFloat { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public bool Reset { get; set; }

		[ContainerField(37), LayoutImmutable, Blittable]
		public bool Continuous { get; set; }

	}
}
