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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 72)]
	public class VehicleParachuteData :
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable, JsonProperty(Order = 8)]
		public float TerminalVelocity { get; set; }

		[ContainerField(12), LayoutImmutable, Blittable, JsonProperty(Order = 12)]
		public float FreefallGravityMultiplier { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable, JsonProperty(Order = 16)]
		public float DragCoefficient { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable, JsonProperty(Order = 20)]
		public float MaxRollVelocity { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable, JsonProperty(Order = 24)]
		public float MaxPitchVelocity { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable, JsonProperty(Order = 28)]
		public float MaxYawVelocity { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable, JsonProperty(Order = 32)]
		public float DeployTime { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable, JsonProperty(Order = 36)]
		public float UndeployGroundHeight { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable, JsonProperty(Order = 40)]
		public float AngularDescentDamping { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable, JsonProperty(Order = 44)]
		public float AngularDeployDamping { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable, JsonProperty(Order = 48)]
		public float DeployPhysicsStart { get; set; }

		[ContainerField(52), LayoutImmutable, Blittable, JsonProperty(Order = 52)]
		public float DeployInitialDragStart { get; set; }

		[ContainerField(56), LayoutImmutable, Blittable, JsonProperty(Order = 56)]
		public float InitialDragStartVelocityScale { get; set; }

		[ContainerField(60), LayoutImmutable, Blittable, JsonProperty(Order = 60)]
		public float InitialDragAngularVelocityPitch { get; set; }

		[ContainerField(64), LayoutImmutable, Blittable, JsonProperty(Order = 64)]
		public float InitialDragRandomAngularVelocityRollMax { get; set; }

		[ContainerField(68), LayoutImmutable, Blittable, JsonProperty(Order = 68)]
		public float RampLength { get; set; }

		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			p_Writer.Write(TerminalVelocity);
			p_Writer.Write(FreefallGravityMultiplier);
			p_Writer.Write(DragCoefficient);
			p_Writer.Write(MaxRollVelocity);
			p_Writer.Write(MaxPitchVelocity);
			p_Writer.Write(MaxYawVelocity);
			p_Writer.Write(DeployTime);
			p_Writer.Write(UndeployGroundHeight);
			p_Writer.Write(AngularDescentDamping);
			p_Writer.Write(AngularDeployDamping);
			p_Writer.Write(DeployPhysicsStart);
			p_Writer.Write(DeployInitialDragStart);
			p_Writer.Write(InitialDragStartVelocityScale);
			p_Writer.Write(InitialDragAngularVelocityPitch);
			p_Writer.Write(InitialDragRandomAngularVelocityRollMax);
			p_Writer.Write(RampLength);
		}
	}
}
