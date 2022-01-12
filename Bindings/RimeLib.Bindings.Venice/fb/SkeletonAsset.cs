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
	[ContainerType(4, 44)]
	public class SkeletonAsset : 
		BaseSkeletonAsset
	{
		[ContainerField(12)]
		public List<string> BoneNames { get; set; } = new();

		[ContainerField(16)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(20)]
		public List<LinearTransform> LocalPose { get; set; } = new();

		[ContainerField(24)]
		public List<LinearTransform> ModelPose { get; set; } = new();

		[ContainerField(28), LayoutImmutable]
		public string WeaponBoneName { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable]
		public string HeadBoneName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable]
		public string HipBoneName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable]
		public string CameraBoneName { get; set; } = string.Empty;

	}
}
