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
	[ContainerType(16, 144)]
	public class RagdollComponentData : 
		ComponentData
	{
		[ContainerField(96)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(100)]
		public CtrRef<RagdollAsset> RagdollAsset { get; set; } = new();

		[ContainerField(104)]
		public CtrRef<SkeletonCollisionData> SkeletonCollisionData { get; set; } = new();

		[ContainerField(108)]
		public RagdollBinding Binding { get; set; } = new();

		[ContainerField(128), LayoutImmutable]
		public string LeftLegBoneName { get; set; } = string.Empty;

		[ContainerField(132), LayoutImmutable]
		public string RightLegBoneName { get; set; } = string.Empty;

	}
}
