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
using RimeLib.Serialization.Frostbite2_0.Ebx;

namespace fb
{
	[ContainerType(4, 116)]
	public class PhysicsDrivenAnimationEntityBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef AimLeftRight { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef AimUpDown { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef Crouch { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef ForceSetTrajectory { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef InAir { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef Skydive { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef Parachute { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef Swim { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef InputBackward { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef InputForward { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef InputLeft { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef InputRight { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef IsEnemy { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef Jump { get; set; } = new();
		
		[ContainerField(56), JsonProperty(Order = 56)]
		public AntRef LeanLeftRight { get; set; } = new();
		
		[ContainerField(60), JsonProperty(Order = 60)]
		public AntRef Prone { get; set; } = new();
		
		[ContainerField(64), JsonProperty(Order = 64)]
		public AntRef Sprint { get; set; } = new();
		
		[ContainerField(68), JsonProperty(Order = 68)]
		public AntRef GroundSupported { get; set; } = new();
		
		[ContainerField(72), JsonProperty(Order = 72)]
		public AntRef GroundNormal { get; set; } = new();
		
		[ContainerField(76), JsonProperty(Order = 76)]
		public AntRef GroundDistance { get; set; } = new();
		
		[ContainerField(80), JsonProperty(Order = 80)]
		public AntRef GroundAngleZ { get; set; } = new();
		
		[ContainerField(84), JsonProperty(Order = 84)]
		public AntRef GroundAngleX { get; set; } = new();
		
		[ContainerField(88), JsonProperty(Order = 88)]
		public AntRef GroundAngleFromNormal { get; set; } = new();
		
		[ContainerField(92), JsonProperty(Order = 92)]
		public AntRef IsClientAnimatable { get; set; } = new();
		
		[ContainerField(96), JsonProperty(Order = 96)]
		public AntRef CustomizationScreen { get; set; } = new();
		
		[ContainerField(100), JsonProperty(Order = 100)]
		public AntRef Minimal3pServer { get; set; } = new();
		
		[ContainerField(104), JsonProperty(Order = 104)]
		public AntRef VerticalImpact { get; set; } = new();
		
		[ContainerField(108), JsonProperty(Order = 108)]
		public AntRef FalseSignal { get; set; } = new();
		
		[ContainerField(112), JsonProperty(Order = 112)]
		public AntRef LockArmsToCameraWeight { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AimLeftRight.Serialize(p_Writer, p_EbxWriter);
			AimUpDown.Serialize(p_Writer, p_EbxWriter);
			Crouch.Serialize(p_Writer, p_EbxWriter);
			ForceSetTrajectory.Serialize(p_Writer, p_EbxWriter);
			InAir.Serialize(p_Writer, p_EbxWriter);
			Skydive.Serialize(p_Writer, p_EbxWriter);
			Parachute.Serialize(p_Writer, p_EbxWriter);
			Swim.Serialize(p_Writer, p_EbxWriter);
			InputBackward.Serialize(p_Writer, p_EbxWriter);
			InputForward.Serialize(p_Writer, p_EbxWriter);
			InputLeft.Serialize(p_Writer, p_EbxWriter);
			InputRight.Serialize(p_Writer, p_EbxWriter);
			IsEnemy.Serialize(p_Writer, p_EbxWriter);
			Jump.Serialize(p_Writer, p_EbxWriter);
			LeanLeftRight.Serialize(p_Writer, p_EbxWriter);
			Prone.Serialize(p_Writer, p_EbxWriter);
			Sprint.Serialize(p_Writer, p_EbxWriter);
			GroundSupported.Serialize(p_Writer, p_EbxWriter);
			GroundNormal.Serialize(p_Writer, p_EbxWriter);
			GroundDistance.Serialize(p_Writer, p_EbxWriter);
			GroundAngleZ.Serialize(p_Writer, p_EbxWriter);
			GroundAngleX.Serialize(p_Writer, p_EbxWriter);
			GroundAngleFromNormal.Serialize(p_Writer, p_EbxWriter);
			IsClientAnimatable.Serialize(p_Writer, p_EbxWriter);
			CustomizationScreen.Serialize(p_Writer, p_EbxWriter);
			Minimal3pServer.Serialize(p_Writer, p_EbxWriter);
			VerticalImpact.Serialize(p_Writer, p_EbxWriter);
			FalseSignal.Serialize(p_Writer, p_EbxWriter);
			LockArmsToCameraWeight.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
