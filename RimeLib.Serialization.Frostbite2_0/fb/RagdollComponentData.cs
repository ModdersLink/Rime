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
	[ContainerType(16, 144)]
	public class RagdollComponentData : 
		ComponentData
	{
		[ContainerField(96), JsonProperty(Order = 96)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(100), JsonProperty(Order = 100)]
		public CtrRef<RagdollAsset> RagdollAsset { get; set; } = new();

		[ContainerField(104), JsonProperty(Order = 104)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get; set; } = new();

		[ContainerField(108), JsonProperty(Order = 108)]
		public RagdollBinding Binding { get; set; } = new();

		[ContainerField(128), LayoutImmutable, JsonProperty(Order = 128)]
		public string LeftLegBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable, JsonProperty(Order = 132)]
		public string RightLegBoneName { get; set; } = string.Empty;

	}
}
