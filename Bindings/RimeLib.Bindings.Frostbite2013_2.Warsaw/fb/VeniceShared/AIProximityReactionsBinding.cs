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

namespace fb.VeniceShared;

[ContainerType(4, 540)]
public class AIProximityReactionsBinding
	: EbxSerializable
{
	[ContainerField(0x0), JsonProperty(Order = 0)]
	public AntRef AIReaction { get; set; } = new();
	
	[ContainerField(0x14), JsonProperty(Order = 20)]
	public AntRef AIExplosionReaction { get; set; } = new();
	
	[ContainerField(0x28), JsonProperty(Order = 40)]
	public AntRef AIExplosionForce { get; set; } = new();
	
	[ContainerField(0x3c), JsonProperty(Order = 60)]
	public AntRef AIStunReaction { get; set; } = new();
	
	[ContainerField(0x50), JsonProperty(Order = 80)]
	public AntRef AIStunReactionRandomFactor { get; set; } = new();
	
	[ContainerField(0x64), JsonProperty(Order = 100)]
	public AntRef AIReactionDirection { get; set; } = new();
	
	[ContainerField(0x78), JsonProperty(Order = 120)]
	public AntRef IsPanicking { get; set; } = new();
	
	[ContainerField(0x8c), JsonProperty(Order = 140)]
	public AntRef FireNearby { get; set; } = new();
	
	[ContainerField(0xa0), JsonProperty(Order = 160)]
	public AntRef AimUpAndDown { get; set; } = new();
	
	[ContainerField(0xb4), JsonProperty(Order = 180)]
	public AntRef FocusAimScale { get; set; } = new();
	
	[ContainerField(0xc8), JsonProperty(Order = 200)]
	public AntRef FocusAiming { get; set; } = new();
	
	[ContainerField(0xdc), JsonProperty(Order = 220)]
	public AntRef EnableProceduralHeadAim { get; set; } = new();
	
	[ContainerField(0xf0), JsonProperty(Order = 240)]
	public AntRef KillFromAnimation { get; set; } = new();
	
	[ContainerField(0x104), JsonProperty(Order = 260)]
	public AntRef PlayerAnimationKill { get; set; } = new();
	
	[ContainerField(0x118), JsonProperty(Order = 280)]
	public AntRef PlayerInitiatedRagdoll { get; set; } = new();
	
	[ContainerField(0x12c), JsonProperty(Order = 300)]
	public AntRef AISuppressed { get; set; } = new();
	
	[ContainerField(0x140), JsonProperty(Order = 320)]
	public AntRef HumanAwareness { get; set; } = new();
	
	[ContainerField(0x154), JsonProperty(Order = 340)]
	public AntRef HumanIsClose { get; set; } = new();
	
	[ContainerField(0x168), JsonProperty(Order = 360)]
	public AntRef HumanTargetYaw { get; set; } = new();
	
	[ContainerField(0x17c), JsonProperty(Order = 380)]
	public AntRef LookAtHuman { get; set; } = new();
	
	[ContainerField(0x190), JsonProperty(Order = 400)]
	public AntRef RetriggerIdle { get; set; } = new();
	
	[ContainerField(0x1a4), JsonProperty(Order = 420)]
	public AntRef HasWantedPrecision { get; set; } = new();
	
	[ContainerField(0x1b8), JsonProperty(Order = 440)]
	public AntRef TargetVisible { get; set; } = new();
	
	[ContainerField(0x1cc), JsonProperty(Order = 460)]
	public AntRef TargetSpotted { get; set; } = new();
	
	[ContainerField(0x1e0), JsonProperty(Order = 480)]
	public AntRef TargetDistance { get; set; } = new();
	
	[ContainerField(0x1f4), JsonProperty(Order = 500)]
	public AntRef CruiseSpeedLevel { get; set; } = new();
	
	[ContainerField(0x208), JsonProperty(Order = 520)]
	public AntRef DrasticAimYawChange { get; set; } = new();
	
}

