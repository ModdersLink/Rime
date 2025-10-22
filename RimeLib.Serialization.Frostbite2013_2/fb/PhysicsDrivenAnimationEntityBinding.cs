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

using fb.Ant;

namespace fb.GameShared;

[ContainerType(4, 700)]
public class PhysicsDrivenAnimationEntityBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef PhysicsMotionTarget { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef AimLeftRight { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef AimUpDown { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef Crouch { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef ForceSetTrajectory { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef InAir { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef Skydive { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef Parachute { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef Swim { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef InputBackward { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef InputForward { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef InputLeft { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef InputRight { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef IsEnemy { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef Jump { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef LeanLeftRight { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public AntRef Prone { get; set; } = new();
	
	[ContainerField(0x154), JsonProperty(Order = 340)]
	public AntRef Sprint { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public AntRef GroundSupported { get; set; } = new();
	
	[ContainerField(0x17c), JsonProperty(Order = 380)]
	public AntRef GroundNormal { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public AntRef GroundDistance { get; set; } = new();
	
	[ContainerField(0x1a4), JsonProperty(Order = 420)]
	public AntRef GroundAngleZ { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public AntRef GroundAngleX { get; set; } = new();
	
	[ContainerField(0x1cc), JsonProperty(Order = 460)]
	public AntRef GroundAngleFromNormal { get; set; } = new();
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public AntRef IsClientAnimatable { get; set; } = new();
	
	[ContainerField(0x1f4), JsonProperty(Order = 500)]
	public AntRef CustomizationScreen { get; set; } = new();
	
	[ContainerField(0x208), JsonProperty(Order = 520)]
	public AntRef Minimal3pServer { get; set; } = new();
	
	[ContainerField(0x21c), JsonProperty(Order = 540)]
	public AntRef VerticalImpact { get; set; } = new();
	
	[ContainerField(0x230), JsonProperty(Order = 560)]
	public AntRef VerticalImpactSpeed { get; set; } = new();
	
	[ContainerField(0x244), JsonProperty(Order = 580)]
	public AntRef FalseSignal { get; set; } = new();
	
	[ContainerField(0x258), JsonProperty(Order = 600)]
	public AntRef LockArmsToCameraWeight { get; set; } = new();
	
	[ContainerField(0x26c), JsonProperty(Order = 620)]
	public AntRef WindDirection { get; set; } = new();
	
	[ContainerField(0x280), JsonProperty(Order = 640)]
	public AntRef WindStrength { get; set; } = new();
	
	[ContainerField(0x294), JsonProperty(Order = 660)]
	public AntRef WaterDepth { get; set; } = new();
	
	[ContainerField(0x2a8), JsonProperty(Order = 680)]
	public AntRef EyeWaterDepth { get; set; } = new();
	
}

