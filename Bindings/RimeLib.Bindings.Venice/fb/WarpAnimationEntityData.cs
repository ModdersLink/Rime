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
	public class WarpAnimationEntityData : 
		EntityData
	{
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(84)]
		public WarpAnimationBinding WarpBinding { get; set; } = new();

		[ContainerField(104)]
		public GameplayBones BoneToAlign { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable]
		public bool ForceAnimationTransform { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable]
		public bool RequireAnimationWeight { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable]
		public bool ExternalConnectTransform { get; set; }

	}
}
