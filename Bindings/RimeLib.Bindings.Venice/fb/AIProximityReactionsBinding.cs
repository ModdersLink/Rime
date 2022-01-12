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
	[ContainerType(4, 56)]
	public class AIProximityReactionsBinding
	{
		[ContainerField(0)]
		public AntRef AIReaction { get; set; } = new();
		
		[ContainerField(4)]
		public AntRef AIExplosionReaction { get; set; } = new();
		
		[ContainerField(8)]
		public AntRef AIExplosionForce { get; set; } = new();
		
		[ContainerField(12)]
		public AntRef AIStunReaction { get; set; } = new();
		
		[ContainerField(16)]
		public AntRef AIStunReactionRandomFactor { get; set; } = new();
		
		[ContainerField(20)]
		public AntRef AIReactionDirection { get; set; } = new();
		
		[ContainerField(24)]
		public AntRef FireNearby { get; set; } = new();
		
		[ContainerField(28)]
		public AntRef AimUpAndDown { get; set; } = new();
		
		[ContainerField(32)]
		public AntRef FocusAimScale { get; set; } = new();
		
		[ContainerField(36)]
		public AntRef FocusAiming { get; set; } = new();
		
		[ContainerField(40)]
		public AntRef EnableProceduralHeadAim { get; set; } = new();
		
		[ContainerField(44)]
		public AntRef KillFromAnimation { get; set; } = new();
		
		[ContainerField(48)]
		public AntRef PlayerAnimationKill { get; set; } = new();
		
		[ContainerField(52)]
		public AntRef PlayerInitiatedRagdoll { get; set; } = new();
		
	}
}
