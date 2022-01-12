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
	public class UIMinimapConfig
	{
		[ContainerField(0), LayoutImmutable, Blittable]
		public float CombatAreaCameraDelay { get; set; }
		
		[ContainerField(4), LayoutImmutable, Blittable]
		public float CameraInterpolationTime { get; set; }
		
		[ContainerField(8), LayoutImmutable, Blittable]
		public float CombatAreaFadeSpeed { get; set; }
		
		[ContainerField(12)]
		public List<UIMinimapZoomConfig> ZoomStates { get; set; } = new();
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public float CameraPanSensitivity { get; set; }
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public float MinVelocity { get; set; }
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxVelocity { get; set; }
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public float VelocityModifier { get; set; }
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool DisableDefaultState { get; set; }
		
	}
}
