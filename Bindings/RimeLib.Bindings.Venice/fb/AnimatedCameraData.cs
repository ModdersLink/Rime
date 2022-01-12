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
	[ContainerType(16, 96)]
	public class AnimatedCameraData : 
		CameraData
	{
		[ContainerField(80)]
		public CtrRef<SkeletonAsset> Skeleton { get; set; } = new();

		[ContainerField(84), LayoutImmutable]
		public string CameraBone { get; set; } = string.Empty;

		[ContainerField(88), LayoutImmutable]
		public string FovBone { get; set; } = string.Empty;

	}
}
