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
	[ContainerType(4, 44)]
	public class SkeletonAsset : 
		BaseSkeletonAsset
	{
		[ContainerField(12), JsonProperty(Order = 12)]
		public List<string> BoneNames { get; set; } = new();

		[ContainerField(16), JsonProperty(Order = 16)]
		public List<int> Hierarchy { get; set; } = new();

		[ContainerField(20), JsonProperty(Order = 20)]
		public List<LinearTransform> LocalPose { get; set; } = new();

		[ContainerField(24), JsonProperty(Order = 24)]
		public List<LinearTransform> ModelPose { get; set; } = new();

		[ContainerField(28), LayoutImmutable, JsonProperty(Order = 28)]
		public string WeaponBoneName { get; set; } = string.Empty;

		[ContainerField(32), LayoutImmutable, JsonProperty(Order = 32)]
		public string HeadBoneName { get; set; } = string.Empty;

		[ContainerField(36), LayoutImmutable, JsonProperty(Order = 36)]
		public string HipBoneName { get; set; } = string.Empty;

		[ContainerField(40), LayoutImmutable, JsonProperty(Order = 40)]
		public string CameraBoneName { get; set; } = string.Empty;

	}
}
