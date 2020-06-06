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
	public class PhysicsSettings : 
		DataContainer
	{
		[ContainerField(8), LayoutImmutable, Blittable]
		public uint IntegrateJobCount { get; set; } // 0x8 (8)
		
		[ContainerField(12), LayoutImmutable, Blittable]
		public uint ClientEffectWorldThreadCount { get; set; } // 0xC (12)
		
		[ContainerField(16), LayoutImmutable, Blittable]
		public uint ClientWorldThreadCount { get; set; } // 0x10 (16)
		
		[ContainerField(20), LayoutImmutable, Blittable]
		public uint ServerWorldThreadCount { get; set; } // 0x14 (20)
		
		[ContainerField(24), LayoutImmutable, Blittable]
		public uint CollideJobCount { get; set; } // 0x18 (24)
		
		[ContainerField(28), LayoutImmutable, Blittable]
		public bool Enable { get; set; } // 0x1C (28)
		
		[ContainerField(29), LayoutImmutable, Blittable]
		public bool EnableAIRigidBody { get; set; } // 0x1D (29)
		
		[ContainerField(30), LayoutImmutable, Blittable]
		public bool ForestEnable { get; set; } // 0x1E (30)
		
		[ContainerField(31), LayoutImmutable, Blittable]
		public bool EnableJobs { get; set; } // 0x1F (31)
		
		[ContainerField(32), LayoutImmutable, Blittable]
		public bool RemoveRagdollWhenWoken { get; set; } // 0x20 (32)
		
		[ContainerField(33), LayoutImmutable, Blittable]
		public bool RemoveFromWorldOnCollisionOverflow { get; set; } // 0x21 (33)
		
		[ContainerField(34), LayoutImmutable, Blittable]
		public bool SingleStepCharacter { get; set; } // 0x22 (34)
		
		[ContainerField(35), LayoutImmutable, Blittable]
		public bool ForceSingleStepCharacterInSP { get; set; } // 0x23 (35)
		
		[ContainerField(36), LayoutImmutable, Blittable]
		public bool EnableFollowWheelRaycasts { get; set; } // 0x24 (36)
		
		[ContainerField(37), LayoutImmutable, Blittable]
		public bool EnableClientWheelRaycasts { get; set; } // 0x25 (37)
		
		[ContainerField(38), LayoutImmutable, Blittable]
		public bool EnableASyncWheelRaycasts { get; set; } // 0x26 (38)
		
		[ContainerField(39), LayoutImmutable, Blittable]
		public bool UseDelayedWakeUpClient { get; set; } // 0x27 (39)
		
		[ContainerField(40), LayoutImmutable, Blittable]
		public bool UseDelayedWakeUpServer { get; set; } // 0x28 (40)
		
		[ContainerField(41), LayoutImmutable, Blittable]
		public bool SuppressDebrisSpawnUntilReady { get; set; } // 0x29 (41)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 3254030898:
					IntegrateJobCount = (uint) p_Value;
					break;

				case 2748873924:
					ClientEffectWorldThreadCount = (uint) p_Value;
					break;

				case 2754405235:
					ClientWorldThreadCount = (uint) p_Value;
					break;

				case 2066496687:
					ServerWorldThreadCount = (uint) p_Value;
					break;

				case 3265113317:
					CollideJobCount = (uint) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 3043137069:
					EnableAIRigidBody = (bool) p_Value;
					break;

				case 1260596861:
					ForestEnable = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 2226229296:
					RemoveRagdollWhenWoken = (bool) p_Value;
					break;

				case 422957492:
					RemoveFromWorldOnCollisionOverflow = (bool) p_Value;
					break;

				case 1398272148:
					SingleStepCharacter = (bool) p_Value;
					break;

				case 3854381293:
					ForceSingleStepCharacterInSP = (bool) p_Value;
					break;

				case 1775482970:
					EnableFollowWheelRaycasts = (bool) p_Value;
					break;

				case 2450184562:
					EnableClientWheelRaycasts = (bool) p_Value;
					break;

				case 1311090861:
					EnableASyncWheelRaycasts = (bool) p_Value;
					break;

				case 2531078454:
					UseDelayedWakeUpClient = (bool) p_Value;
					break;

				case 3164738410:
					UseDelayedWakeUpServer = (bool) p_Value;
					break;

				case 62351077:
					SuppressDebrisSpawnUntilReady = (bool) p_Value;
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
				case 3254030898:
					return IntegrateJobCount;

				case 2748873924:
					return ClientEffectWorldThreadCount;

				case 2754405235:
					return ClientWorldThreadCount;

				case 2066496687:
					return ServerWorldThreadCount;

				case 3265113317:
					return CollideJobCount;

				case 2342790116:
					return Enable;

				case 3043137069:
					return EnableAIRigidBody;

				case 1260596861:
					return ForestEnable;

				case 1190923856:
					return EnableJobs;

				case 2226229296:
					return RemoveRagdollWhenWoken;

				case 422957492:
					return RemoveFromWorldOnCollisionOverflow;

				case 1398272148:
					return SingleStepCharacter;

				case 3854381293:
					return ForceSingleStepCharacterInSP;

				case 1775482970:
					return EnableFollowWheelRaycasts;

				case 2450184562:
					return EnableClientWheelRaycasts;

				case 1311090861:
					return EnableASyncWheelRaycasts;

				case 2531078454:
					return UseDelayedWakeUpClient;

				case 3164738410:
					return UseDelayedWakeUpServer;

				case 62351077:
					return SuppressDebrisSpawnUntilReady;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 3254030898:
					return typeof(PhysicsSettings).GetProperty(nameof(IntegrateJobCount));

				case 2748873924:
					return typeof(PhysicsSettings).GetProperty(nameof(ClientEffectWorldThreadCount));

				case 2754405235:
					return typeof(PhysicsSettings).GetProperty(nameof(ClientWorldThreadCount));

				case 2066496687:
					return typeof(PhysicsSettings).GetProperty(nameof(ServerWorldThreadCount));

				case 3265113317:
					return typeof(PhysicsSettings).GetProperty(nameof(CollideJobCount));

				case 2342790116:
					return typeof(PhysicsSettings).GetProperty(nameof(Enable));

				case 3043137069:
					return typeof(PhysicsSettings).GetProperty(nameof(EnableAIRigidBody));

				case 1260596861:
					return typeof(PhysicsSettings).GetProperty(nameof(ForestEnable));

				case 1190923856:
					return typeof(PhysicsSettings).GetProperty(nameof(EnableJobs));

				case 2226229296:
					return typeof(PhysicsSettings).GetProperty(nameof(RemoveRagdollWhenWoken));

				case 422957492:
					return typeof(PhysicsSettings).GetProperty(nameof(RemoveFromWorldOnCollisionOverflow));

				case 1398272148:
					return typeof(PhysicsSettings).GetProperty(nameof(SingleStepCharacter));

				case 3854381293:
					return typeof(PhysicsSettings).GetProperty(nameof(ForceSingleStepCharacterInSP));

				case 1775482970:
					return typeof(PhysicsSettings).GetProperty(nameof(EnableFollowWheelRaycasts));

				case 2450184562:
					return typeof(PhysicsSettings).GetProperty(nameof(EnableClientWheelRaycasts));

				case 1311090861:
					return typeof(PhysicsSettings).GetProperty(nameof(EnableASyncWheelRaycasts));

				case 2531078454:
					return typeof(PhysicsSettings).GetProperty(nameof(UseDelayedWakeUpClient));

				case 3164738410:
					return typeof(PhysicsSettings).GetProperty(nameof(UseDelayedWakeUpServer));

				case 62351077:
					return typeof(PhysicsSettings).GetProperty(nameof(SuppressDebrisSpawnUntilReady));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
