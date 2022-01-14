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
	[ContainerType(16, 96)]
	public class AnimatedCameraData : 
		CameraData
	{
		[ContainerField(80), JsonProperty(Order = 80)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();

		[ContainerField(84), LayoutImmutable, JsonProperty(Order = 84)]
		public string CameraBone { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable, JsonProperty(Order = 88)]
		public string FovBone { get; set; } = string.Empty;

	}
}
