///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using RimeLib.IO;
using RimeLib.Frostbite.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Reflection;
using RimeLib.Serialization.Attributes;
using RimeLib.Serialization.Containers;
using RimeLib.Serialization.Ebx;

namespace fb
{
	[ContainerType(Alignment: 4,  Flags: 41, Size: 56)]
	public class AIProximityReactionsBinding : FrostbiteContainer
	{
		[ContainerField(Name: "AIReaction", Offset: 0, NameHash: 419848388, Flags: 41)]
		public AntRef AIReaction { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(Name: "AIExplosionReaction", Offset: 4, NameHash: 2129752945, Flags: 41)]
		public AntRef AIExplosionReaction { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(Name: "AIExplosionForce", Offset: 8, NameHash: 2244860293, Flags: 41)]
		public AntRef AIExplosionForce { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(Name: "AIStunReaction", Offset: 12, NameHash: 3419931640, Flags: 41)]
		public AntRef AIStunReaction { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(Name: "AIStunReactionRandomFactor", Offset: 16, NameHash: 382567182, Flags: 41)]
		public AntRef AIStunReactionRandomFactor { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(Name: "AIReactionDirection", Offset: 20, NameHash: 2704201761, Flags: 41)]
		public AntRef AIReactionDirection { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(Name: "FireNearby", Offset: 24, NameHash: 39716990, Flags: 41)]
		public AntRef FireNearby { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(Name: "AimUpAndDown", Offset: 28, NameHash: 1716632252, Flags: 41)]
		public AntRef AimUpAndDown { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(Name: "FocusAimScale", Offset: 32, NameHash: 1524585044, Flags: 41)]
		public AntRef FocusAimScale { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(Name: "FocusAiming", Offset: 36, NameHash: 3361584780, Flags: 41)]
		public AntRef FocusAiming { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(Name: "EnableProceduralHeadAim", Offset: 40, NameHash: 2283438924, Flags: 41)]
		public AntRef EnableProceduralHeadAim { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(Name: "KillFromAnimation", Offset: 44, NameHash: 1941020071, Flags: 41)]
		public AntRef KillFromAnimation { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(Name: "PlayerAnimationKill", Offset: 48, NameHash: 1965517602, Flags: 41)]
		public AntRef PlayerAnimationKill { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(Name: "PlayerInitiatedRagdoll", Offset: 52, NameHash: 1275134830, Flags: 41)]
		public AntRef PlayerInitiatedRagdoll { get; set; } = new AntRef(); // 0x34 (52)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 419848388:
					AIReaction = (AntRef) p_Value;
					break;

				case 2129752945:
					AIExplosionReaction = (AntRef) p_Value;
					break;

				case 2244860293:
					AIExplosionForce = (AntRef) p_Value;
					break;

				case 3419931640:
					AIStunReaction = (AntRef) p_Value;
					break;

				case 382567182:
					AIStunReactionRandomFactor = (AntRef) p_Value;
					break;

				case 2704201761:
					AIReactionDirection = (AntRef) p_Value;
					break;

				case 39716990:
					FireNearby = (AntRef) p_Value;
					break;

				case 1716632252:
					AimUpAndDown = (AntRef) p_Value;
					break;

				case 1524585044:
					FocusAimScale = (AntRef) p_Value;
					break;

				case 3361584780:
					FocusAiming = (AntRef) p_Value;
					break;

				case 2283438924:
					EnableProceduralHeadAim = (AntRef) p_Value;
					break;

				case 1941020071:
					KillFromAnimation = (AntRef) p_Value;
					break;

				case 1965517602:
					PlayerAnimationKill = (AntRef) p_Value;
					break;

				case 1275134830:
					PlayerInitiatedRagdoll = (AntRef) p_Value;
					break;

				default:
					base.Bind(p_Descriptor, p_Value);
					break;
			}
		}

		public override object GetFieldValueByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 419848388:
					return AIReaction;

				case 2129752945:
					return AIExplosionReaction;

				case 2244860293:
					return AIExplosionForce;

				case 3419931640:
					return AIStunReaction;

				case 382567182:
					return AIStunReactionRandomFactor;

				case 2704201761:
					return AIReactionDirection;

				case 39716990:
					return FireNearby;

				case 1716632252:
					return AimUpAndDown;

				case 1524585044:
					return FocusAimScale;

				case 3361584780:
					return FocusAiming;

				case 2283438924:
					return EnableProceduralHeadAim;

				case 1941020071:
					return KillFromAnimation;

				case 1965517602:
					return PlayerAnimationKill;

				case 1275134830:
					return PlayerInitiatedRagdoll;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 419848388:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIReaction));

				case 2129752945:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIExplosionReaction));

				case 2244860293:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIExplosionForce));

				case 3419931640:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIStunReaction));

				case 382567182:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIStunReactionRandomFactor));

				case 2704201761:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AIReactionDirection));

				case 39716990:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(FireNearby));

				case 1716632252:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(AimUpAndDown));

				case 1524585044:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(FocusAimScale));

				case 3361584780:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(FocusAiming));

				case 2283438924:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(EnableProceduralHeadAim));

				case 1941020071:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(KillFromAnimation));

				case 1965517602:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(PlayerAnimationKill));

				case 1275134830:
					return typeof(AIProximityReactionsBinding).GetProperty(nameof(PlayerInitiatedRagdoll));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
