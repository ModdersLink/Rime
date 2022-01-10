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
	[ContainerType(4, 52)]
	public class ParachuteStateData : 
		CharacterStateData
	{
		[ContainerField(12), LayoutImmutable, Blittable]
		public float DeployTime { get; set; }

		[ContainerField(16), LayoutImmutable, Blittable]
		public float TerminalVelocity { get; set; }

		[ContainerField(20), LayoutImmutable, Blittable]
		public float ForwardDragCoefficient { get; set; }

		[ContainerField(24), LayoutImmutable, Blittable]
		public float AngleOfAttack { get; set; }

		[ContainerField(28), LayoutImmutable, Blittable]
		public float BankOffset { get; set; }

		[ContainerField(32), LayoutImmutable, Blittable]
		public float ThrottleOffset { get; set; }

		[ContainerField(36), LayoutImmutable, Blittable]
		public float BrakeOffset { get; set; }

		[ContainerField(40), LayoutImmutable, Blittable]
		public float MaxRollVelocity { get; set; }

		[ContainerField(44), LayoutImmutable, Blittable]
		public float MaxPitchVelocity { get; set; }

		[ContainerField(48), LayoutImmutable, Blittable]
		public float MaxYawVelocity { get; set; }

		public static void Deserialize(ParachuteStateData p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			p_Instance.DeployTime = p_Reader.ReadSingle();
			p_Instance.TerminalVelocity = p_Reader.ReadSingle();
			p_Instance.ForwardDragCoefficient = p_Reader.ReadSingle();
			p_Instance.AngleOfAttack = p_Reader.ReadSingle();
			p_Instance.BankOffset = p_Reader.ReadSingle();
			p_Instance.ThrottleOffset = p_Reader.ReadSingle();
			p_Instance.BrakeOffset = p_Reader.ReadSingle();
			p_Instance.MaxRollVelocity = p_Reader.ReadSingle();
			p_Instance.MaxPitchVelocity = p_Reader.ReadSingle();
			p_Instance.MaxYawVelocity = p_Reader.ReadSingle();
		}

	}
}
