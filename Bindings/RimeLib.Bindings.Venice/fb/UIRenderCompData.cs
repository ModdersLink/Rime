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
	public class UIRenderCompData : 
		UIComponentData
	{
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BackgroundRect1 { get; set; } = new();

		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BackgroundRect0 { get; set; } = new();

		[ContainerField(64)]
		public CtrRef<TextureAsset> BgTexture2 { get; set; } = new();

		[ContainerField(68)]
		public CtrRef<TextureAsset> BgTexture1 { get; set; } = new();

		[ContainerField(72), LayoutImmutable, Blittable]
		public float AlphaMin { get; set; }

		[ContainerField(76), LayoutImmutable, Blittable]
		public float AlphaAnimationSpeed { get; set; }

		[ContainerField(80), LayoutImmutable, Blittable]
		public float AlphaOffset { get; set; }

		[ContainerField(84), LayoutImmutable, Blittable]
		public float AlphaMax { get; set; }

	}
}
