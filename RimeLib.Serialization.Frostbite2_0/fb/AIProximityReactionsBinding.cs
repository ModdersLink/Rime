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
using CommunityToolkit.Mvvm.ComponentModel;

namespace fb
{
	[ContainerType(4, 56)]
	public partial class AIProximityReactionsBinding :
		EbxSerializable
	{
		[ObservableProperty]
		[property: ContainerField(0), JsonProperty(Order = 0)]
		private AntRef _AIReaction = new();
		
		[ObservableProperty]
		[property: ContainerField(4), JsonProperty(Order = 4)]
		private AntRef _AIExplosionReaction = new();
		
		[ObservableProperty]
		[property: ContainerField(8), JsonProperty(Order = 8)]
		private AntRef _AIExplosionForce = new();
		
		[ObservableProperty]
		[property: ContainerField(12), JsonProperty(Order = 12)]
		private AntRef _AIStunReaction = new();
		
		[ObservableProperty]
		[property: ContainerField(16), JsonProperty(Order = 16)]
		private AntRef _AIStunReactionRandomFactor = new();
		
		[ObservableProperty]
		[property: ContainerField(20), JsonProperty(Order = 20)]
		private AntRef _AIReactionDirection = new();
		
		[ObservableProperty]
		[property: ContainerField(24), JsonProperty(Order = 24)]
		private AntRef _FireNearby = new();
		
		[ObservableProperty]
		[property: ContainerField(28), JsonProperty(Order = 28)]
		private AntRef _AimUpAndDown = new();
		
		[ObservableProperty]
		[property: ContainerField(32), JsonProperty(Order = 32)]
		private AntRef _FocusAimScale = new();
		
		[ObservableProperty]
		[property: ContainerField(36), JsonProperty(Order = 36)]
		private AntRef _FocusAiming = new();
		
		[ObservableProperty]
		[property: ContainerField(40), JsonProperty(Order = 40)]
		private AntRef _EnableProceduralHeadAim = new();
		
		[ObservableProperty]
		[property: ContainerField(44), JsonProperty(Order = 44)]
		private AntRef _KillFromAnimation = new();
		
		[ObservableProperty]
		[property: ContainerField(48), JsonProperty(Order = 48)]
		private AntRef _PlayerAnimationKill = new();
		
		[ObservableProperty]
		[property: ContainerField(52), JsonProperty(Order = 52)]
		private AntRef _PlayerInitiatedRagdoll = new();
		
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
