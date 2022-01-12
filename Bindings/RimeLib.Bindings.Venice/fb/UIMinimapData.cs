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
	[ContainerType(16, 256)]
	public class UIMinimapData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 WorldCenter { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 CombatAreaColor { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec4 DetailTextureTint { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 CombatAreaMultiplyWrapAmount { get; set; } = new();
		
		[ContainerField(64)]
		public UIMinimapDistanceFieldParams Vegetation { get; set; } = new();
		
		[ContainerField(128)]
		public CtrRef<TextureAsset> FadeTexture { get; set; } = new();
		
		[ContainerField(132), LayoutImmutable, Blittable]
		public float StreamingMinimapDelay { get; set; }
		
		[ContainerField(136)]
		public CtrRef<TextureAsset> AirRadarFadeTexture { get; set; } = new();
		
		[ContainerField(140)]
		public CtrRef<TextureAsset> DetailTexture { get; set; } = new();
		
		[ContainerField(144)]
		public UIMinimapDistanceFieldParams Detail { get; set; } = new();
		
		[ContainerField(208), LayoutImmutable, Blittable]
		public float StreamingMinimapTransitionSpeed { get; set; }
		
		[ContainerField(212), LayoutImmutable, Blittable]
		public float WorldRotation { get; set; }
		
		[ContainerField(216), LayoutImmutable, Blittable]
		public float WorldRange { get; set; }
		
		[ContainerField(220), LayoutImmutable, Blittable]
		public float CombatAreaDistanceScale { get; set; }
		
		[ContainerField(224), LayoutImmutable, Blittable]
		public float CombatAreaFadeSpeed { get; set; }
		
		[ContainerField(228), LayoutImmutable, Blittable]
		public float CombatAreaAlphaThreshold { get; set; }
		
		[ContainerField(232)]
		public CtrRef<TextureAsset> CombatAreaMultiplyTexture { get; set; } = new();
		
		[ContainerField(236), LayoutImmutable, Blittable]
		public float WorldSize { get; set; }
		
		[ContainerField(240), LayoutImmutable, Blittable]
		public float AirRadarRange { get; set; }
		
		[ContainerField(244), LayoutImmutable, Blittable]
		public float CombatAreaScale { get; set; }
		
		[ContainerField(248), LayoutImmutable, Blittable]
		public bool UseStreamingMinimap { get; set; }
		
		[ContainerField(249), LayoutImmutable, Blittable]
		public bool UseCombatAreaTexture { get; set; }
		
	}
}
