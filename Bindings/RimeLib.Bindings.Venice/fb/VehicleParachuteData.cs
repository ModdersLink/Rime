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
	[ContainerType(4, 72)]
	public class VehicleParachuteData : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public float TerminalVelocity { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable]
		public float FreefallGravityMultiplier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float DragCoefficient { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float MaxRollVelocity { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float MaxPitchVelocity { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float MaxYawVelocity { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float DeployTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float UndeployGroundHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float AngularDescentDamping { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float AngularDeployDamping { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float DeployPhysicsStart { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable]
		public float DeployInitialDragStart { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable]
		public float InitialDragStartVelocityScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable]
		public float InitialDragAngularVelocityPitch { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable]
		public float InitialDragRandomAngularVelocityRollMax { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable]
		public float RampLength { get; set; }

	}
}
