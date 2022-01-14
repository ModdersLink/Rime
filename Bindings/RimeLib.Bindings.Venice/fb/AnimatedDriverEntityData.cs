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
	[ContainerType(16, 272)]
	public class AnimatedDriverEntityData : 
		GameEntityData
	{
		[ContainerField(96), Homogeneous, LayoutImmutable, Blittable, JsonProperty(Order = 96)]
		public LinearTransform InputTransform { get; set; } = new();

		[ContainerField(160), JsonProperty(Order = 160)]
		public AntRef VehicleBoost { get; set; } = new();

		[ContainerField(164), JsonProperty(Order = 164)]
		public AntRef VehicleSpeed { get; set; } = new();

		[ContainerField(168), JsonProperty(Order = 168)]
		public AntRef VehicleMovementState { get; set; } = new();

		[ContainerField(172), JsonProperty(Order = 172)]
		public AntRef VehicleClutch { get; set; } = new();

		[ContainerField(176), JsonProperty(Order = 176)]
		public AntRef VehicleBrake { get; set; } = new();

		[ContainerField(180), LayoutImmutable, Blittable, JsonProperty(Order = 180)]
		public float MovementStateStandThreshold { get; set; }

		[ContainerField(184), JsonProperty(Order = 184)]
		public NormalizeSettings Yaw { get; set; } = new();

		[ContainerField(208), JsonProperty(Order = 208)]
		public NormalizeSettings Roll { get; set; } = new();

		[ContainerField(232), JsonProperty(Order = 232)]
		public NormalizeSettings Pitch { get; set; } = new();

		[ContainerField(256), LayoutImmutable, Blittable, JsonProperty(Order = 256)]
		public bool DelayAnimationWheelTransform { get; set; }

	}
}
