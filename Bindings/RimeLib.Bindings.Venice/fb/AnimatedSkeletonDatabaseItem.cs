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
	[ContainerType(4, 32)]
	public class AnimatedSkeletonDatabaseItem
	{
		[ContainerField(0)]
		public CtrRef<SkeletonAsset> Asset { get; set; } = new();
		
		[ContainerField(4)]
		public List<int> Names { get; set; } = new();
		
		[ContainerField(8)]
		public CtrRef<SkeletonCollisionData> SoldierCollision { get; set; } = new();
		
		[ContainerField(12)]
		public CtrRef<SkeletonCollisionData> RagdollCollision { get; set; } = new();
		
		[ContainerField(16)]
		public CtrRef<RagdollAsset> Ragdoll { get; set; } = new();
		
		[ContainerField(20)]
		public List<string> SpecialBones { get; set; } = new();
		
		[ContainerField(24), LayoutImmutable]
		public string HipBone { get; set; } = string.Empty;
		
		[ContainerField(28), LayoutImmutable]
		public string HeadBone { get; set; } = string.Empty;
		
	}
}
