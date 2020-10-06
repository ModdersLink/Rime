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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(44), ContainerClass]
	public class PhysicsSettings : 
		DataContainer
	{
		protected uint m_IntegrateJobCount = new uint();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3254030898)]
		public uint IntegrateJobCount { get { return m_IntegrateJobCount; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(IntegrateJobCount), this, m_IntegrateJobCount, value)) m_IntegrateJobCount = value; } } // 0x8 (8)
		
		protected uint m_ClientEffectWorldThreadCount = new uint();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2748873924)]
		public uint ClientEffectWorldThreadCount { get { return m_ClientEffectWorldThreadCount; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(ClientEffectWorldThreadCount), this, m_ClientEffectWorldThreadCount, value)) m_ClientEffectWorldThreadCount = value; } } // 0xC (12)
		
		protected uint m_ClientWorldThreadCount = new uint();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2754405235)]
		public uint ClientWorldThreadCount { get { return m_ClientWorldThreadCount; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(ClientWorldThreadCount), this, m_ClientWorldThreadCount, value)) m_ClientWorldThreadCount = value; } } // 0x10 (16)
		
		protected uint m_ServerWorldThreadCount = new uint();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(2066496687)]
		public uint ServerWorldThreadCount { get { return m_ServerWorldThreadCount; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(ServerWorldThreadCount), this, m_ServerWorldThreadCount, value)) m_ServerWorldThreadCount = value; } } // 0x14 (20)
		
		protected uint m_CollideJobCount = new uint();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3265113317)]
		public uint CollideJobCount { get { return m_CollideJobCount; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(CollideJobCount), this, m_CollideJobCount, value)) m_CollideJobCount = value; } } // 0x18 (24)
		
		protected bool m_Enable = new bool();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x1C (28)
		
		protected bool m_EnableAIRigidBody = new bool();
		[ContainerField(29), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3043137069)]
		public bool EnableAIRigidBody { get { return m_EnableAIRigidBody; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(EnableAIRigidBody), this, m_EnableAIRigidBody, value)) m_EnableAIRigidBody = value; } } // 0x1D (29)
		
		protected bool m_ForestEnable = new bool();
		[ContainerField(30), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1260596861)]
		public bool ForestEnable { get { return m_ForestEnable; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(ForestEnable), this, m_ForestEnable, value)) m_ForestEnable = value; } } // 0x1E (30)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(31), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1190923856)]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x1F (31)
		
		protected bool m_RemoveRagdollWhenWoken = new bool();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2226229296)]
		public bool RemoveRagdollWhenWoken { get { return m_RemoveRagdollWhenWoken; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(RemoveRagdollWhenWoken), this, m_RemoveRagdollWhenWoken, value)) m_RemoveRagdollWhenWoken = value; } } // 0x20 (32)
		
		protected bool m_RemoveFromWorldOnCollisionOverflow = new bool();
		[ContainerField(33), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(422957492)]
		public bool RemoveFromWorldOnCollisionOverflow { get { return m_RemoveFromWorldOnCollisionOverflow; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(RemoveFromWorldOnCollisionOverflow), this, m_RemoveFromWorldOnCollisionOverflow, value)) m_RemoveFromWorldOnCollisionOverflow = value; } } // 0x21 (33)
		
		protected bool m_SingleStepCharacter = new bool();
		[ContainerField(34), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1398272148)]
		public bool SingleStepCharacter { get { return m_SingleStepCharacter; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(SingleStepCharacter), this, m_SingleStepCharacter, value)) m_SingleStepCharacter = value; } } // 0x22 (34)
		
		protected bool m_ForceSingleStepCharacterInSP = new bool();
		[ContainerField(35), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3854381293)]
		public bool ForceSingleStepCharacterInSP { get { return m_ForceSingleStepCharacterInSP; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(ForceSingleStepCharacterInSP), this, m_ForceSingleStepCharacterInSP, value)) m_ForceSingleStepCharacterInSP = value; } } // 0x23 (35)
		
		protected bool m_EnableFollowWheelRaycasts = new bool();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1775482970)]
		public bool EnableFollowWheelRaycasts { get { return m_EnableFollowWheelRaycasts; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(EnableFollowWheelRaycasts), this, m_EnableFollowWheelRaycasts, value)) m_EnableFollowWheelRaycasts = value; } } // 0x24 (36)
		
		protected bool m_EnableClientWheelRaycasts = new bool();
		[ContainerField(37), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2450184562)]
		public bool EnableClientWheelRaycasts { get { return m_EnableClientWheelRaycasts; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(EnableClientWheelRaycasts), this, m_EnableClientWheelRaycasts, value)) m_EnableClientWheelRaycasts = value; } } // 0x25 (37)
		
		protected bool m_EnableASyncWheelRaycasts = new bool();
		[ContainerField(38), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1311090861)]
		public bool EnableASyncWheelRaycasts { get { return m_EnableASyncWheelRaycasts; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(EnableASyncWheelRaycasts), this, m_EnableASyncWheelRaycasts, value)) m_EnableASyncWheelRaycasts = value; } } // 0x26 (38)
		
		protected bool m_UseDelayedWakeUpClient = new bool();
		[ContainerField(39), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2531078454)]
		public bool UseDelayedWakeUpClient { get { return m_UseDelayedWakeUpClient; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(UseDelayedWakeUpClient), this, m_UseDelayedWakeUpClient, value)) m_UseDelayedWakeUpClient = value; } } // 0x27 (39)
		
		protected bool m_UseDelayedWakeUpServer = new bool();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3164738410)]
		public bool UseDelayedWakeUpServer { get { return m_UseDelayedWakeUpServer; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(UseDelayedWakeUpServer), this, m_UseDelayedWakeUpServer, value)) m_UseDelayedWakeUpServer = value; } } // 0x28 (40)
		
		protected bool m_SuppressDebrisSpawnUntilReady = new bool();
		[ContainerField(41), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(62351077)]
		public bool SuppressDebrisSpawnUntilReady { get { return m_SuppressDebrisSpawnUntilReady; } set { if (OnPropertyChanging("PhysicsSettings." + nameof(SuppressDebrisSpawnUntilReady), this, m_SuppressDebrisSpawnUntilReady, value)) m_SuppressDebrisSpawnUntilReady = value; } } // 0x29 (41)
		
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
