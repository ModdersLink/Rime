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
	[ContainerType(Alignment: 4,  Flags: 53, Size: 68)]
	public class VegetationSystemSettings : 
		DataContainer
	{
		protected float m_WindVariation = new float();
		[ContainerField(Name: "WindVariation", Offset: 8, NameHash: 2346154816, Flags: 49469), LayoutImmutable, Blittable]
		public float WindVariation { get { return m_WindVariation; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindVariation), this, m_WindVariation, value)) m_WindVariation = value; } } // 0x8 (8)
		
		protected float m_WindVariationRate = new float();
		[ContainerField(Name: "WindVariationRate", Offset: 12, NameHash: 1435068578, Flags: 49469), LayoutImmutable, Blittable]
		public float WindVariationRate { get { return m_WindVariationRate; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindVariationRate), this, m_WindVariationRate, value)) m_WindVariationRate = value; } } // 0xC (12)
		
		protected float m_WindStrength = new float();
		[ContainerField(Name: "WindStrength", Offset: 16, NameHash: 3768589012, Flags: 49469), LayoutImmutable, Blittable]
		public float WindStrength { get { return m_WindStrength; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(WindStrength), this, m_WindStrength, value)) m_WindStrength = value; } } // 0x10 (16)
		
		protected float m_JointTensionLimit = new float();
		[ContainerField(Name: "JointTensionLimit", Offset: 20, NameHash: 2687352802, Flags: 49469), LayoutImmutable, Blittable]
		public float JointTensionLimit { get { return m_JointTensionLimit; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JointTensionLimit), this, m_JointTensionLimit, value)) m_JointTensionLimit = value; } } // 0x14 (20)
		
		protected int m_ForceShadowLod = new int();
		[ContainerField(Name: "ForceShadowLod", Offset: 24, NameHash: 694013785, Flags: 49405), LayoutImmutable, Blittable]
		public int ForceShadowLod { get { return m_ForceShadowLod; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(ForceShadowLod), this, m_ForceShadowLod, value)) m_ForceShadowLod = value; } } // 0x18 (24)
		
		protected uint m_MaxPreSimsPerJob = new uint();
		[ContainerField(Name: "MaxPreSimsPerJob", Offset: 28, NameHash: 3246910962, Flags: 49421), LayoutImmutable, Blittable]
		public uint MaxPreSimsPerJob { get { return m_MaxPreSimsPerJob; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(MaxPreSimsPerJob), this, m_MaxPreSimsPerJob, value)) m_MaxPreSimsPerJob = value; } } // 0x1C (28)
		
		protected uint m_SimulationMemKbClient = new uint();
		[ContainerField(Name: "SimulationMemKbClient", Offset: 32, NameHash: 188140739, Flags: 49421), LayoutImmutable, Blittable]
		public uint SimulationMemKbClient { get { return m_SimulationMemKbClient; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulationMemKbClient), this, m_SimulationMemKbClient, value)) m_SimulationMemKbClient = value; } } // 0x20 (32)
		
		protected float m_MaxActiveDistance = new float();
		[ContainerField(Name: "MaxActiveDistance", Offset: 36, NameHash: 2638833886, Flags: 49469), LayoutImmutable, Blittable]
		public float MaxActiveDistance { get { return m_MaxActiveDistance; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(MaxActiveDistance), this, m_MaxActiveDistance, value)) m_MaxActiveDistance = value; } } // 0x24 (36)
		
		protected uint m_SimulationMemKbServer = new uint();
		[ContainerField(Name: "SimulationMemKbServer", Offset: 40, NameHash: 3858787743, Flags: 49421), LayoutImmutable, Blittable]
		public uint SimulationMemKbServer { get { return m_SimulationMemKbServer; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulationMemKbServer), this, m_SimulationMemKbServer, value)) m_SimulationMemKbServer = value; } } // 0x28 (40)
		
		protected uint m_JobCount = new uint();
		[ContainerField(Name: "JobCount", Offset: 44, NameHash: 4166996065, Flags: 49421), LayoutImmutable, Blittable]
		public uint JobCount { get { return m_JobCount; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JobCount), this, m_JobCount, value)) m_JobCount = value; } } // 0x2C (44)
		
		protected int m_JointTensionLimitIndex = new int();
		[ContainerField(Name: "JointTensionLimitIndex", Offset: 48, NameHash: 1641973468, Flags: 49405), LayoutImmutable, Blittable]
		public int JointTensionLimitIndex { get { return m_JointTensionLimitIndex; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(JointTensionLimitIndex), this, m_JointTensionLimitIndex, value)) m_JointTensionLimitIndex = value; } } // 0x30 (48)
		
		protected float m_TimeScale = new float();
		[ContainerField(Name: "TimeScale", Offset: 52, NameHash: 169511528, Flags: 49469), LayoutImmutable, Blittable]
		public float TimeScale { get { return m_TimeScale; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(TimeScale), this, m_TimeScale, value)) m_TimeScale = value; } } // 0x34 (52)
		
		protected bool m_LocalInfluencesEnabled = new bool();
		[ContainerField(Name: "LocalInfluencesEnabled", Offset: 56, NameHash: 438465675, Flags: 49325), LayoutImmutable, Blittable]
		public bool LocalInfluencesEnabled { get { return m_LocalInfluencesEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(LocalInfluencesEnabled), this, m_LocalInfluencesEnabled, value)) m_LocalInfluencesEnabled = value; } } // 0x38 (56)
		
		protected bool m_SubDestructionEnabled = new bool();
		[ContainerField(Name: "SubDestructionEnabled", Offset: 57, NameHash: 1151400922, Flags: 49325), LayoutImmutable, Blittable]
		public bool SubDestructionEnabled { get { return m_SubDestructionEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SubDestructionEnabled), this, m_SubDestructionEnabled, value)) m_SubDestructionEnabled = value; } } // 0x39 (57)
		
		protected bool m_DissolveEnable = new bool();
		[ContainerField(Name: "DissolveEnable", Offset: 58, NameHash: 84402905, Flags: 49325), LayoutImmutable, Blittable]
		public bool DissolveEnable { get { return m_DissolveEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DissolveEnable), this, m_DissolveEnable, value)) m_DissolveEnable = value; } } // 0x3A (58)
		
		protected bool m_Enable = new bool();
		[ContainerField(Name: "Enable", Offset: 59, NameHash: 2342790116, Flags: 49325), LayoutImmutable, Blittable]
		public bool Enable { get { return m_Enable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(Enable), this, m_Enable, value)) m_Enable = value; } } // 0x3B (59)
		
		protected bool m_SimulateServerSide = new bool();
		[ContainerField(Name: "SimulateServerSide", Offset: 60, NameHash: 314597893, Flags: 49325), LayoutImmutable, Blittable]
		public bool SimulateServerSide { get { return m_SimulateServerSide; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(SimulateServerSide), this, m_SimulateServerSide, value)) m_SimulateServerSide = value; } } // 0x3C (60)
		
		protected bool m_EnableJobs = new bool();
		[ContainerField(Name: "EnableJobs", Offset: 61, NameHash: 1190923856, Flags: 49325), LayoutImmutable, Blittable]
		public bool EnableJobs { get { return m_EnableJobs; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(EnableJobs), this, m_EnableJobs, value)) m_EnableJobs = value; } } // 0x3D (61)
		
		protected bool m_ShadowMeshEnable = new bool();
		[ContainerField(Name: "ShadowMeshEnable", Offset: 62, NameHash: 4253576529, Flags: 49325), LayoutImmutable, Blittable]
		public bool ShadowMeshEnable { get { return m_ShadowMeshEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(ShadowMeshEnable), this, m_ShadowMeshEnable, value)) m_ShadowMeshEnable = value; } } // 0x3E (62)
		
		protected bool m_DrawNodes = new bool();
		[ContainerField(Name: "DrawNodes", Offset: 63, NameHash: 2398188982, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawNodes { get { return m_DrawNodes; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DrawNodes), this, m_DrawNodes, value)) m_DrawNodes = value; } } // 0x3F (63)
		
		protected bool m_DrawEnable = new bool();
		[ContainerField(Name: "DrawEnable", Offset: 64, NameHash: 1347356004, Flags: 49325), LayoutImmutable, Blittable]
		public bool DrawEnable { get { return m_DrawEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DrawEnable), this, m_DrawEnable, value)) m_DrawEnable = value; } } // 0x40 (64)
		
		protected bool m_BatchDrawEnable = new bool();
		[ContainerField(Name: "BatchDrawEnable", Offset: 65, NameHash: 3539660312, Flags: 49325), LayoutImmutable, Blittable]
		public bool BatchDrawEnable { get { return m_BatchDrawEnable; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(BatchDrawEnable), this, m_BatchDrawEnable, value)) m_BatchDrawEnable = value; } } // 0x41 (65)
		
		protected bool m_DestructionEnabled = new bool();
		[ContainerField(Name: "DestructionEnabled", Offset: 66, NameHash: 4087722398, Flags: 49325), LayoutImmutable, Blittable]
		public bool DestructionEnabled { get { return m_DestructionEnabled; } set { if (OnPropertyChanging("VegetationSystemSettings." + nameof(DestructionEnabled), this, m_DestructionEnabled, value)) m_DestructionEnabled = value; } } // 0x42 (66)
		
		protected bool m_UseShadowLodOffset = new bool();
		[ContainerField(Name: "UseShadowLodOffset", Offset: 67, NameHash: 2320118218, Flags: 49325), LayoutImmutable, Blittable]
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
