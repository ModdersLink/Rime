///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System;
using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;
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
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public LinearTransform ConnectTransform { get; set; } = new();

		[ContainerField(80), LayoutImmutable, Blittable, JsonProperty(Order = 80)]
		public int AnimationEntitySpacePriority { get; set; }

		[ContainerField(84), JsonProperty(Order = 84)]
		public WarpAnimationBinding WarpBinding { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public GameplayBones BoneToAlign { get; set; } = new();

		[ContainerField(108), LayoutImmutable, Blittable, JsonProperty(Order = 108)]
		public bool ForceAnimationTransform { get; set; }

		[ContainerField(109), LayoutImmutable, Blittable, JsonProperty(Order = 109)]
		public bool RequireAnimationWeight { get; set; }

		[ContainerField(110), LayoutImmutable, Blittable, JsonProperty(Order = 110)]
		public bool ExternalConnectTransform { get; set; }

	}
}
