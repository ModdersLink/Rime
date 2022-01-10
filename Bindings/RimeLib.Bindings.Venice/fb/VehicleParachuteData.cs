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

		public static void Deserialize(VehicleParachuteData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.TerminalVelocity = p_Reader.ReadSingle();
			p_Instance.FreefallGravityMultiplier = p_Reader.ReadSingle();
			p_Instance.DragCoefficient = p_Reader.ReadSingle();
			p_Instance.MaxRollVelocity = p_Reader.ReadSingle();
			p_Instance.MaxPitchVelocity = p_Reader.ReadSingle();
			p_Instance.MaxYawVelocity = p_Reader.ReadSingle();
			p_Instance.DeployTime = p_Reader.ReadSingle();
			p_Instance.UndeployGroundHeight = p_Reader.ReadSingle();
			p_Instance.AngularDescentDamping = p_Reader.ReadSingle();
			p_Instance.AngularDeployDamping = p_Reader.ReadSingle();
			p_Instance.DeployPhysicsStart = p_Reader.ReadSingle();
			p_Instance.DeployInitialDragStart = p_Reader.ReadSingle();
			p_Instance.InitialDragStartVelocityScale = p_Reader.ReadSingle();
			p_Instance.InitialDragAngularVelocityPitch = p_Reader.ReadSingle();
			p_Instance.InitialDragRandomAngularVelocityRollMax = p_Reader.ReadSingle();
			p_Instance.RampLength = p_Reader.ReadSingle();
		}

	}
}
