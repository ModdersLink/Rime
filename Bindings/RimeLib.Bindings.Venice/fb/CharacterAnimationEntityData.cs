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
	public class CharacterAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform EntitySpaceTransform { get; set; } = new();

		[ContainerField(80)]
		public AntRef Controller { get; set; } = new();

		[ContainerField(84), LayoutImmutable, Blittable]
		public float TrackLength { get; set; }

		[ContainerField(88), LayoutImmutable, Blittable]
		public float ExternalTime { get; set; }

		[ContainerField(92), LayoutImmutable, Blittable]
		public float WarpAnimationBlendTime { get; set; }

		[ContainerField(96), LayoutImmutable, Blittable]
		public bool RestoreControllerOnFinish { get; set; }

	}
}
