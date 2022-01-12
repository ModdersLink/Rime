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
	[ContainerType(16, 208)]
	public class DamageEffectComponentData : 
		ComponentData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 RightDamage { get; set; } = new();

		[ContainerField(112), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 TopDamage { get; set; } = new();

		[ContainerField(128), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 LeftDamage { get; set; } = new();

		[ContainerField(144), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 BottomDamage { get; set; } = new();

		[ContainerField(160), LayoutImmutable, Blittable]
		public float OuterFrameOpacity { get; set; }

		[ContainerField(164), LayoutImmutable, Blittable]
		public float InnerFrameOpacity { get; set; }

		[ContainerField(168), LayoutImmutable, Blittable]
		public float FrameWidth { get; set; }

		[ContainerField(172)]
		public CtrRef<SurfaceShaderBaseAsset> Shader { get; set; } = new();

		[ContainerField(176), LayoutImmutable, Blittable]
		public float StartCriticalEffectHealthThreshold { get; set; }

		[ContainerField(180), LayoutImmutable, Blittable]
		public float EndCriticalEffectHealthThreshold { get; set; }

		[ContainerField(184), LayoutImmutable, Blittable]
		public float MinDamagePercentageThreshold { get; set; }

		[ContainerField(188), LayoutImmutable, Blittable]
		public float FallofTime { get; set; }

		[ContainerField(192), LayoutImmutable, Blittable]
		public float MaxOpacityDamagePercentage { get; set; }

		[ContainerField(196)]
		public Realm Realm { get; set; } = new();

		[ContainerField(200), LayoutImmutable, Blittable]
		public bool DebugDamage { get; set; }

	}
}
