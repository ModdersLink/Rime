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
	public class ScreenEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 ScreenEffectParams { get; set; } = new();

		[ContainerField(112)]
		public ScreenEffectFrameType FrameType { get; set; } = new();

		[ContainerField(116)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(120), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; }

		[ContainerField(124), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(128), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(132), LayoutImmutable, Blittable]
		public float Angle { get; set; }

		[ContainerField(136)]
		public Realm Realm { get; set; } = new();

	}
}
