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

namespace fb.SoldierShared;

[ContainerType(4, 480)]
public class SoldierHealthModuleBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef HeadShot { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef LeftArmHit { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef RightArmHit { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef LeftLegHit { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef RightLegHit { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef OnGround { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef DeathAnimationTriggered { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef RandomAnimationIndex { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef Sprinting { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef HitLeft { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef HitRight { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef HitFront { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef HitBack { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef DeathHitDirection { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef Explosion { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef Dead { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public AntRef Revived { get; set; } = new();
	
	[ContainerField(0x154), JsonProperty(Order = 340)]
	public AntRef RandomValue { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public AntRef Pose { get; set; } = new();
	
	[ContainerField(0x17c), JsonProperty(Order = 380)]
	public AntRef RightSpeed { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public AntRef ForwardSpeed { get; set; } = new();
	
	[ContainerField(0x1a4), JsonProperty(Order = 420)]
	public AntRef CriticallyHit { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public AntRef InteractiveManDown { get; set; } = new();
	
	[ContainerField(0x1cc), JsonProperty(Order = 460)]
	public AntRef Health { get; set; } = new();
	
}

