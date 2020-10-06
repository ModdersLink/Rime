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
	[ContainerType(4), MemberInfoFlag(53), ContainerSize(68), ContainerClass]
	public class VegetationSystemSettings : 
		DataContainer
	{
		protected float m_WindVariation = new float();
		[ContainerField(8), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2346154816)]
		public float WindVariation { get { return m_WindVariation; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindVariation), this, m_WindVariation, value)) m_WindVariation = value; } } // 0x8 (8)
		
		protected float m_WindVariationRate = new float();
		[ContainerField(12), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(1435068578)]
		public float WindVariationRate { get { return m_WindVariationRate; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindVariationRate), this, m_WindVariationRate, value)) m_WindVariationRate = value; } } // 0xC (12)
		
		protected float m_WindStrength = new float();
		[ContainerField(16), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(3768589012)]
		public float WindStrength { get { return m_WindStrength; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindStrength), this, m_WindStrength, value)) m_WindStrength = value; } } // 0x10 (16)
		
		protected float m_JointTensionLimit = new float();
		[ContainerField(20), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2687352802)]
		public float JointTensionLimit { get { return m_JointTensionLimit; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JointTensionLimit), this, m_JointTensionLimit, value)) m_JointTensionLimit = value; } } // 0x14 (20)
		
		protected int m_ForceShadowLod = new int();
		[ContainerField(24), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(694013785)]
		public int ForceShadowLod { get { return m_ForceShadowLod; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(ForceShadowLod), this, m_ForceShadowLod, value)) m_ForceShadowLod = value; } } // 0x18 (24)
		
		protected uint m_MaxPreSimsPerJob = new uint();
		[ContainerField(28), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3246910962)]
		public uint MaxPreSimsPerJob { get { return m_MaxPreSimsPerJob; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(MaxPreSimsPerJob), this, m_MaxPreSimsPerJob, value)) m_MaxPreSimsPerJob = value; } } // 0x1C (28)
		
		protected uint m_SimulationMemKbClient = new uint();
		[ContainerField(32), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(188140739)]
		public uint SimulationMemKbClient { get { return m_SimulationMemKbClient; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulationMemKbClient), this, m_SimulationMemKbClient, value)) m_SimulationMemKbClient = value; } } // 0x20 (32)
		
		protected float m_MaxActiveDistance = new float();
		[ContainerField(36), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(2638833886)]
		public float MaxActiveDistance { get { return m_MaxActiveDistance; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(MaxActiveDistance), this, m_MaxActiveDistance, value)) m_MaxActiveDistance = value; } } // 0x24 (36)
		
		protected uint m_SimulationMemKbServer = new uint();
		[ContainerField(40), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(3858787743)]
		public uint SimulationMemKbServer { get { return m_SimulationMemKbServer; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulationMemKbServer), this, m_SimulationMemKbServer, value)) m_SimulationMemKbServer = value; } } // 0x28 (40)
		
		protected uint m_JobCount = new uint();
		[ContainerField(44), LayoutImmutable, Blittable, MemberInfoFlag(49421), ContainerFieldNameHash(4166996065)]
		public uint JobCount { get { return m_JobCount; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JobCount), this, m_JobCount, value)) m_JobCount = value; } } // 0x2C (44)
		
		protected int m_JointTensionLimitIndex = new int();
		[ContainerField(48), LayoutImmutable, Blittable, MemberInfoFlag(49405), ContainerFieldNameHash(1641973468)]
		public int JointTensionLimitIndex { get { return m_JointTensionLimitIndex; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JointTensionLimitIndex), this, m_JointTensionLimitIndex, value)) m_JointTensionLimitIndex = value; } } // 0x30 (48)
		
		protected float m_TimeScale = new float();
		[ContainerField(52), LayoutImmutable, Blittable, MemberInfoFlag(49469), ContainerFieldNameHash(169511528)]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x34 (52)
		
		protected bool m_LocalInfluencesEnabled = new bool();
		[ContainerField(56), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(438465675)]
		public bool LocalInfluencesEnabled { get { return m_LocalInfluencesEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(LocalInfluencesEnabled), this, m_LocalInfluencesEnabled, value)) m_LocalInfluencesEnabled = value; } } // 0x38 (56)
		
		protected bool m_SubDestructionEnabled = new bool();
		[ContainerField(57), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1151400922)]
		public bool SubDestructionEnabled { get { return m_SubDestructionEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SubDestructionEnabled), this, m_SubDestructionEnabled, value)) m_SubDestructionEnabled = value; } } // 0x39 (57)
		
		protected bool m_DissolveEnable = new bool();
		[ContainerField(58), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(84402905)]
		public bool DissolveEnable { get { return m_DissolveEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DissolveEnable), this, m_DissolveEnable, value)) m_DissolveEnable = value; } } // 0x3A (58)
		
		protected bool m_Enable = new bool();
		[ContainerField(59), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2342790116)]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x3B (59)
		
		protected bool m_SimulateServerSide = new bool();
		[ContainerField(60), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(314597893)]
		public bool SimulateServerSide { get { return m_SimulateServerSide; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulateServerSide), this, m_SimulateServerSide, value)) m_SimulateServerSide = value; } } // 0x3C (60)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(61), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1190923856)]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x3D (61)
		
		protected bool m_ShadowMeshEnable = new bool();
		[ContainerField(62), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4253576529)]
		public bool ShadowMeshEnable { get { return m_ShadowMeshEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(ShadowMeshEnable), this, m_ShadowMeshEnable, value)) m_ShadowMeshEnable = value; } } // 0x3E (62)
		
		protected bool m_DrawNodes = new bool();
		[ContainerField(63), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2398188982)]
		public bool DrawNodes { get { return m_DrawNodes; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DrawNodes), this, m_DrawNodes, value)) m_DrawNodes = value; } } // 0x3F (63)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(64), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(1347356004)]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x40 (64)
		
		protected bool m_BatchDrawEnable = new bool();
		[ContainerField(65), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(3539660312)]
		public bool BatchDrawEnable { get { return m_BatchDrawEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(BatchDrawEnable), this, m_BatchDrawEnable, value)) m_BatchDrawEnable = value; } } // 0x41 (65)
		
		protected bool m_DestructionEnabled = new bool();
		[ContainerField(66), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(4087722398)]
		public bool DestructionEnabled { get { return m_DestructionEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DestructionEnabled), this, m_DestructionEnabled, value)) m_DestructionEnabled = value; } } // 0x42 (66)
		
		protected bool m_UseShadowLodOffset = new bool();
		[ContainerField(67), LayoutImmutable, Blittable, MemberInfoFlag(49325), ContainerFieldNameHash(2320118218)]
		public bool UseShadowLodOffset { get { return m_UseShadowLodOffset; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(UseShadowLodOffset), this, m_UseShadowLodOffset, value)) m_UseShadowLodOffset = value; } } // 0x43 (67)
		
		public override void Bind(FieldDescriptor p_Descriptor, object p_Value)
		{
			switch (p_Descriptor.NameHash)
			{
				case 2346154816:
					WindVariation = (float) p_Value;
					break;

				case 1435068578:
					WindVariationRate = (float) p_Value;
					break;

				case 3768589012:
					WindStrength = (float) p_Value;
					break;

				case 2687352802:
					JointTensionLimit = (float) p_Value;
					break;

				case 694013785:
					ForceShadowLod = (int) p_Value;
					break;

				case 3246910962:
					MaxPreSimsPerJob = (uint) p_Value;
					break;

				case 188140739:
					SimulationMemKbClient = (uint) p_Value;
					break;

				case 2638833886:
					MaxActiveDistance = (float) p_Value;
					break;

				case 3858787743:
					SimulationMemKbServer = (uint) p_Value;
					break;

				case 4166996065:
					JobCount = (uint) p_Value;
					break;

				case 1641973468:
					JointTensionLimitIndex = (int) p_Value;
					break;

				case 169511528:
					TimeScale = (float) p_Value;
					break;

				case 438465675:
					LocalInfluencesEnabled = (bool) p_Value;
					break;

				case 1151400922:
					SubDestructionEnabled = (bool) p_Value;
					break;

				case 84402905:
					DissolveEnable = (bool) p_Value;
					break;

				case 2342790116:
					Enable = (bool) p_Value;
					break;

				case 314597893:
					SimulateServerSide = (bool) p_Value;
					break;

				case 1190923856:
					EnableJobs = (bool) p_Value;
					break;

				case 4253576529:
					ShadowMeshEnable = (bool) p_Value;
					break;

				case 2398188982:
					DrawNodes = (bool) p_Value;
					break;

				case 1347356004:
					DrawEnable = (bool) p_Value;
					break;

				case 3539660312:
					BatchDrawEnable = (bool) p_Value;
					break;

				case 4087722398:
					DestructionEnabled = (bool) p_Value;
					break;

				case 2320118218:
					UseShadowLodOffset = (bool) p_Value;
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
				case 2346154816:
					return WindVariation;

				case 1435068578:
					return WindVariationRate;

				case 3768589012:
					return WindStrength;

				case 2687352802:
					return JointTensionLimit;

				case 694013785:
					return ForceShadowLod;

				case 3246910962:
					return MaxPreSimsPerJob;

				case 188140739:
					return SimulationMemKbClient;

				case 2638833886:
					return MaxActiveDistance;

				case 3858787743:
					return SimulationMemKbServer;

				case 4166996065:
					return JobCount;

				case 1641973468:
					return JointTensionLimitIndex;

				case 169511528:
					return TimeScale;

				case 438465675:
					return LocalInfluencesEnabled;

				case 1151400922:
					return SubDestructionEnabled;

				case 84402905:
					return DissolveEnable;

				case 2342790116:
					return Enable;

				case 314597893:
					return SimulateServerSide;

				case 1190923856:
					return EnableJobs;

				case 4253576529:
					return ShadowMeshEnable;

				case 2398188982:
					return DrawNodes;

				case 1347356004:
					return DrawEnable;

				case 3539660312:
					return BatchDrawEnable;

				case 4087722398:
					return DestructionEnabled;

				case 2320118218:
					return UseShadowLodOffset;

				default:
					return base.GetFieldValueByHash(p_Hash);
			}
		}

		public override PropertyInfo GetFieldInfoByHash(uint p_Hash)
		{
			switch (p_Hash)
			{
				case 2346154816:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindVariation));

				case 1435068578:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindVariationRate));

				case 3768589012:
					return typeof(VegetationSystemSettings).GetProperty(nameof(WindStrength));

				case 2687352802:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JointTensionLimit));

				case 694013785:
					return typeof(VegetationSystemSettings).GetProperty(nameof(ForceShadowLod));

				case 3246910962:
					return typeof(VegetationSystemSettings).GetProperty(nameof(MaxPreSimsPerJob));

				case 188140739:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulationMemKbClient));

				case 2638833886:
					return typeof(VegetationSystemSettings).GetProperty(nameof(MaxActiveDistance));

				case 3858787743:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulationMemKbServer));

				case 4166996065:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JobCount));

				case 1641973468:
					return typeof(VegetationSystemSettings).GetProperty(nameof(JointTensionLimitIndex));

				case 169511528:
					return typeof(VegetationSystemSettings).GetProperty(nameof(TimeScale));

				case 438465675:
					return typeof(VegetationSystemSettings).GetProperty(nameof(LocalInfluencesEnabled));

				case 1151400922:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SubDestructionEnabled));

				case 84402905:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DissolveEnable));

				case 2342790116:
					return typeof(VegetationSystemSettings).GetProperty(nameof(Enable));

				case 314597893:
					return typeof(VegetationSystemSettings).GetProperty(nameof(SimulateServerSide));

				case 1190923856:
					return typeof(VegetationSystemSettings).GetProperty(nameof(EnableJobs));

				case 4253576529:
					return typeof(VegetationSystemSettings).GetProperty(nameof(ShadowMeshEnable));

				case 2398188982:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DrawNodes));

				case 1347356004:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DrawEnable));

				case 3539660312:
					return typeof(VegetationSystemSettings).GetProperty(nameof(BatchDrawEnable));

				case 4087722398:
					return typeof(VegetationSystemSettings).GetProperty(nameof(DestructionEnabled));

				case 2320118218:
					return typeof(VegetationSystemSettings).GetProperty(nameof(UseShadowLodOffset));

				default:
					return base.GetFieldInfoByHash(p_Hash);
			}
		}
	}
}
