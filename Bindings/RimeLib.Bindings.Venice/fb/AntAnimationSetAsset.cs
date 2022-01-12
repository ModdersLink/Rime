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
	[ContainerType(4, 36)]
	public class AntAnimationSetAsset : 
		Asset
	{
		[ContainerField(12)]
		public CtrRef<SkeletonAsset> SkeletonAsset { get; set; } = new();

		[ContainerField(16), LayoutImmutable, Blittable]
		public int ActorAssetIndex { get; set; }

		[ContainerField(20)]
		public List<int> ClipAssetIndices { get; set; } = new();

		[ContainerField(24)]
		public List<int> LoopingClipAssetIndices { get; set; } = new();

		[ContainerField(28), LayoutImmutable, Blittable]
		public int SceneOpMatrixAssetIndex { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public bool UseTraj2Ref { get; set; }

		[ContainerField(33), LayoutImmutable, Blittable]
		public bool AllowAnimationCulling { get; set; }

	}
}
