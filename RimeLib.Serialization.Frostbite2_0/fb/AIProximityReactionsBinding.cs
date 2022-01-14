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
	[ContainerType(4, 56)]
	public class AIProximityReactionsBinding :
		EbxSerializable
	{
		[ContainerField(0), JsonProperty(Order = 0)]
		public AntRef AIReaction { get; set; } = new();
		
		[ContainerField(4), JsonProperty(Order = 4)]
		public AntRef AIExplosionReaction { get; set; } = new();
		
		[ContainerField(8), JsonProperty(Order = 8)]
		public AntRef AIExplosionForce { get; set; } = new();
		
		[ContainerField(12), JsonProperty(Order = 12)]
		public AntRef AIStunReaction { get; set; } = new();
		
		[ContainerField(16), JsonProperty(Order = 16)]
		public AntRef AIStunReactionRandomFactor { get; set; } = new();
		
		[ContainerField(20), JsonProperty(Order = 20)]
		public AntRef AIReactionDirection { get; set; } = new();
		
		[ContainerField(24), JsonProperty(Order = 24)]
		public AntRef FireNearby { get; set; } = new();
		
		[ContainerField(28), JsonProperty(Order = 28)]
		public AntRef AimUpAndDown { get; set; } = new();
		
		[ContainerField(32), JsonProperty(Order = 32)]
		public AntRef FocusAimScale { get; set; } = new();
		
		[ContainerField(36), JsonProperty(Order = 36)]
		public AntRef FocusAiming { get; set; } = new();
		
		[ContainerField(40), JsonProperty(Order = 40)]
		public AntRef EnableProceduralHeadAim { get; set; } = new();
		
		[ContainerField(44), JsonProperty(Order = 44)]
		public AntRef KillFromAnimation { get; set; } = new();
		
		[ContainerField(48), JsonProperty(Order = 48)]
		public AntRef PlayerAnimationKill { get; set; } = new();
		
		[ContainerField(52), JsonProperty(Order = 52)]
		public AntRef PlayerInitiatedRagdoll { get; set; } = new();
		
		public override void Serialize(RimeWriter p_Writer, IEbxWriter p_EbxWriter)
		{
			base.Serialize(p_Writer, p_EbxWriter);
			AIReaction.Serialize(p_Writer, p_EbxWriter);
			AIExplosionReaction.Serialize(p_Writer, p_EbxWriter);
			AIExplosionForce.Serialize(p_Writer, p_EbxWriter);
			AIStunReaction.Serialize(p_Writer, p_EbxWriter);
			AIStunReactionRandomFactor.Serialize(p_Writer, p_EbxWriter);
			AIReactionDirection.Serialize(p_Writer, p_EbxWriter);
			FireNearby.Serialize(p_Writer, p_EbxWriter);
			AimUpAndDown.Serialize(p_Writer, p_EbxWriter);
			FocusAimScale.Serialize(p_Writer, p_EbxWriter);
			FocusAiming.Serialize(p_Writer, p_EbxWriter);
			EnableProceduralHeadAim.Serialize(p_Writer, p_EbxWriter);
			KillFromAnimation.Serialize(p_Writer, p_EbxWriter);
			PlayerAnimationKill.Serialize(p_Writer, p_EbxWriter);
			PlayerInitiatedRagdoll.Serialize(p_Writer, p_EbxWriter);
		}
	}
}
