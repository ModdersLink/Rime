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
	[ContainerType(16, 112)]
	public class MinimapData
	{
		[ContainerField(0), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Position { get; set; } = new();
		
		[ContainerField(16), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 CameraPosition { get; set; } = new();
		
		[ContainerField(32), Homogeneous, LayoutImmutable, Blittable]
		public Vec2 Size { get; set; } = new();
		
		[ContainerField(48), Homogeneous, LayoutImmutable, Blittable]
		public Vec3 OverlayColor { get; set; } = new();
		
		[ContainerField(64), LayoutImmutable, Blittable]
		public float AnchorPosVertical { get; set; }
		
		[ContainerField(68), LayoutImmutable, Blittable]
		public float AnchorPosHorizontal { get; set; }
		
		[ContainerField(72), LayoutImmutable, Blittable]
		public float CameraLookDistance { get; set; }
		
		[ContainerField(76), LayoutImmutable, Blittable]
		public float CameraDistance { get; set; }
		
		[ContainerField(80), LayoutImmutable, Blittable]
		public float CameraFov { get; set; }
		
		[ContainerField(84), LayoutImmutable, Blittable]
		public float OverlayAlpha { get; set; }
		
		[ContainerField(88), LayoutImmutable, Blittable]
		public float CameraRotation { get; set; }
		
		[ContainerField(92), LayoutImmutable, Blittable]
		public int StartZoomLevel { get; set; }
		
		[ContainerField(96), LayoutImmutable, Blittable]
		public int InnerZoomFactor { get; set; }
		
		[ContainerField(100), LayoutImmutable, Blittable]
		public int MaxZoomLevels { get; set; }
		
		[ContainerField(104), LayoutImmutable, Blittable]
		public bool CenterOnCombatArea { get; set; }
		
		[ContainerField(105), LayoutImmutable, Blittable]
		public bool RotationFromPlayer { get; set; }
		
		[ContainerField(106), LayoutImmutable, Blittable]
		public bool PositionFromPlayer { get; set; }
		
	}
}
