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
	[ContainerType(16, 160)]
	public class AntAnimatableComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public Realm Realm { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public SubRealm SubRealm { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public AntAnimationHandlerData AnimationData { get; set; } = new();

		[ContainerField(152), JsonProperty(Order = 152)]
		public CtrRef<SkinnedMeshAsset> Mesh { get; set; } = new();

		[ContainerField(156), LayoutImmutable, Blittable, JsonProperty(Order = 156)]
		public bool AutoActivate { get; set; }

		[ContainerField(157), LayoutImmutable, Blittable, JsonProperty(Order = 157)]
		public bool AnimationControlledFromStart { get; set; }

		[ContainerField(158), LayoutImmutable, Blittable, JsonProperty(Order = 158)]
		public bool ForceDisableCulling { get; set; }

	}
}
