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
	[ContainerType(16, 256)]
	public class UIMinimapData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 0)]
		public Vec2 WorldCenter { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public Vec4 CombatAreaColor { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public Vec4 DetailTextureTint { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public Vec2 CombatAreaMultiplyWrapAmount { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public UIMinimapDistanceFieldParams Vegetation { get; set; } = new();
		
		[ContainerField(128), JsonProperty(Order = 128)]
		public CtrRef<TextureAsset> FadeTexture { get; set; } = new();
		
		[ContainerField(132), LayoutImmutable, Blittable, JsonProperty(Order = 132)]
		public float StreamingMinimapDelay { get; set; }
		
		[ContainerField(136), JsonProperty(Order = 136)]
		public CtrRef<TextureAsset> AirRadarFadeTexture { get; set; } = new();
		
		[ContainerField(140), JsonProperty(Order = 140)]
		public CtrRef<TextureAsset> DetailTexture { get; set; } = new();
		
		[ContainerField(144), JsonProperty(Order = 144)]
		public UIMinimapDistanceFieldParams Detail { get; set; } = new();
		
		[ContainerField(208), LayoutImmutable, Blittable, JsonProperty(Order = 208)]
		public float StreamingMinimapTransitionSpeed { get; set; }
		
		[ContainerField(212), LayoutImmutable, Blittable, JsonProperty(Order = 212)]
		public float WorldRotation { get; set; }
		
		[ContainerField(216), LayoutImmutable, Blittable, JsonProperty(Order = 216)]
		public float WorldRange { get; set; }
		
		[ContainerField(220), LayoutImmutable, Blittable, JsonProperty(Order = 220)]
		public float CombatAreaDistanceScale { get; set; }
		
		[ContainerField(224), LayoutImmutable, Blittable, JsonProperty(Order = 224)]
		public float CombatAreaFadeSpeed { get; set; }
		
		[ContainerField(228), LayoutImmutable, Blittable, JsonProperty(Order = 228)]
		public float CombatAreaAlphaThreshold { get; set; }
		
		[ContainerField(232), JsonProperty(Order = 232)]
		public CtrRef<TextureAsset> CombatAreaMultiplyTexture { get; set; } = new();
		
		[ContainerField(236), LayoutImmutable, Blittable, JsonProperty(Order = 236)]
		public float WorldSize { get; set; }
		
		[ContainerField(240), LayoutImmutable, Blittable, JsonProperty(Order = 240)]
		public float AirRadarRange { get; set; }
		
		[ContainerField(244), LayoutImmutable, Blittable, JsonProperty(Order = 244)]
		public float CombatAreaScale { get; set; }
		
		[ContainerField(248), LayoutImmutable, Blittable, JsonProperty(Order = 248)]
		public bool UseStreamingMinimap { get; set; }
		
		[ContainerField(249), LayoutImmutable, Blittable, JsonProperty(Order = 249)]
		public bool UseCombatAreaTexture { get; set; }
		
	}
}
