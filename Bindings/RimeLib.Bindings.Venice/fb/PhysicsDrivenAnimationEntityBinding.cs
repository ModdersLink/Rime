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
	[ContainerType(4, 116)]
	public class PhysicsDrivenAnimationEntityBinding
	{
		[ContainerField(0)]
		public AntRef AimLeftRight { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef AimUpDown { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef Crouch { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef ForceSetTrajectory { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef InAir { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef Skydive { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef Parachute { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef Swim { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef InputBackward { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef InputForward { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef InputLeft { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef InputRight { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef IsEnemy { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef Jump { get; set; } = new();
		
		[ContainerField(56)]
		public AntRef LeanLeftRight { get; set; } = new();
		
		[ContainerField(60)]
		public AntRef Prone { get; set; } = new();
		
		[ContainerField(64)]
		public AntRef Sprint { get; set; } = new();
		
		[ContainerField(68)]
		public AntRef GroundSupported { get; set; } = new();
		
		[ContainerField(72)]
		public AntRef GroundNormal { get; set; } = new();
		
		[ContainerField(76)]
		public AntRef GroundDistance { get; set; } = new();
		
		[ContainerField(80)]
		public AntRef GroundAngleZ { get; set; } = new();
		
		[ContainerField(84)]
		public AntRef GroundAngleX { get; set; } = new();
		
		[ContainerField(88)]
		public AntRef GroundAngleFromNormal { get; set; } = new();
		
		[ContainerField(92)]
		public AntRef IsClientAnimatable { get; set; } = new();
		
		[ContainerField(96)]
		public AntRef CustomizationScreen { get; set; } = new();
		
		[ContainerField(100)]
		public AntRef Minimal3pServer { get; set; } = new();
		
		[ContainerField(104)]
		public AntRef VerticalImpact { get; set; } = new();
		
		[ContainerField(108)]
		public AntRef FalseSignal { get; set; } = new();
		
		[ContainerField(112)]
		public AntRef LockArmsToCameraWeight { get; set; } = new();
		
		public static void Deserialize(PhysicsDrivenAnimationEntityBinding p_Instance, RimeReader p_Reader, IEbxParser p_Parser)
		{
			fb.AntRef.Deserialize(p_Instance.AimLeftRight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.AimUpDown, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Crouch, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.ForceSetTrajectory, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InAir, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Skydive, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Parachute, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Swim, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InputBackward, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InputForward, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InputLeft, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.InputRight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IsEnemy, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Jump, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LeanLeftRight, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Prone, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Sprint, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundSupported, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundNormal, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundDistance, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundAngleZ, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundAngleX, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.GroundAngleFromNormal, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.IsClientAnimatable, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.CustomizationScreen, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.Minimal3pServer, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.VerticalImpact, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.FalseSignal, p_Reader, p_Parser);
			fb.AntRef.Deserialize(p_Instance.LockArmsToCameraWeight, p_Reader, p_Parser);
		}
	}
}
