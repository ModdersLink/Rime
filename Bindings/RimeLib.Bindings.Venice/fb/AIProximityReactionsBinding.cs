///////////////////////////////////////////////////////////////
//                                                           //
// This is an automatically generated file.                  //
// Do *NOT* modify unless you really know what you're doing. //
//                                                           //
///////////////////////////////////////////////////////////////

using System.Reflection;using RimeLib.Serialization.Attributes;using RimeLib.Serialization.Ebx;using RimeLib.Serialization.Containers;using RimeLib.Frostbite.Core;

namespace fb
{
    [ContainerType(4)]
	public class AIProximityReactionsBinding : FrostbiteContainer
	{
		[ContainerField(0)]
		public AntRef AIReaction { get; set; } = new AntRef(); // 0x0 (0)
		
		[ContainerField(4)]
		public AntRef AIExplosionReaction { get; set; } = new AntRef(); // 0x4 (4)
		
		[ContainerField(8)]
		public AntRef AIExplosionForce { get; set; } = new AntRef(); // 0x8 (8)
		
		[ContainerField(12)]
		public AntRef AIStunReaction { get; set; } = new AntRef(); // 0xC (12)
		
		[ContainerField(16)]
		public AntRef AIStunReactionRandomFactor { get; set; } = new AntRef(); // 0x10 (16)
		
		[ContainerField(20)]
		public AntRef AIReactionDirection { get; set; } = new AntRef(); // 0x14 (20)
		
		[ContainerField(24)]
		public AntRef FireNearby { get; set; } = new AntRef(); // 0x18 (24)
		
		[ContainerField(28)]
		public AntRef AimUpAndDown { get; set; } = new AntRef(); // 0x1C (28)
		
		[ContainerField(32)]
		public AntRef FocusAimScale { get; set; } = new AntRef(); // 0x20 (32)
		
		[ContainerField(36)]
		public AntRef FocusAiming { get; set; } = new AntRef(); // 0x24 (36)
		
		[ContainerField(40)]
		public AntRef EnableProceduralHeadAim { get; set; } = new AntRef(); // 0x28 (40)
		
		[ContainerField(44)]
		public AntRef KillFromAnimation { get; set; } = new AntRef(); // 0x2C (44)
		
		[ContainerField(48)]
		public AntRef PlayerAnimationKill { get; set; } = new AntRef(); // 0x30 (48)
		
		[ContainerField(52)]
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
